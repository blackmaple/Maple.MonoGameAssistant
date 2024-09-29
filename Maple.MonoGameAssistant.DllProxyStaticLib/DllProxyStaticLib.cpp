#include "DllProxyStaticLib.h"

int Add(int a, int b)
{
	return a + b;
}

HMODULE LoadOriginalModule(HINSTANCE hInstance)
{
	GetModuleFileName(hInstance, FileName, MAX_PATH);
	PathStripPath(FileName);
	GetSystemDirectory(SysPath, MAX_PATH);
	PathCombine(FullPath, SysPath, FileName);
	return LoadLibrary(FullPath);
}
void LoadFunctions(HMODULE hOriginal)
{
	for (unsigned int i = 0; i < Index_MaxSize; ++i)
	{
		LPCSTR name = ApiNames[i];
		FARPROC address = GetProcAddress(hOriginal, name);
		ApiAddresses[i] = address;
	}
}
void LoadProxy(HINSTANCE hInstance)
{
	LoadFunctions(LoadOriginalModule(hInstance));
}
BOOL InitDllMain(HINSTANCE hModule, DWORD ul_reason_for_call, LPVOID lpReserved)
{
	if (ul_reason_for_call == DLL_PROCESS_ATTACH)
	{
		LoadProxy(hModule);
	}
	return TRUE;
}

void Export_CloseDriver() { ApiAddresses[Index_CloseDriver](); }
void Export_DefDriverProc() { ApiAddresses[Index_DefDriverProc](); }
void Export_DllCanUnloadNow() { ApiAddresses[Index_DllCanUnloadNow](); }
void Export_DllGetClassObject() { ApiAddresses[Index_DllGetClassObject](); }
void Export_DllRegisterServer() { ApiAddresses[Index_DllRegisterServer](); }
void Export_DllUnregisterServer() { ApiAddresses[Index_DllUnregisterServer](); }
void Export_DriverCallback() { ApiAddresses[Index_DriverCallback](); }
void Export_DrvClose() { ApiAddresses[Index_DrvClose](); }
void Export_DrvDefDriverProc() { ApiAddresses[Index_DrvDefDriverProc](); }
void Export_DrvGetModuleHandle() { ApiAddresses[Index_DrvGetModuleHandle](); }
void Export_DrvOpen() { ApiAddresses[Index_DrvOpen](); }
void Export_DrvOpenA() { ApiAddresses[Index_DrvOpenA](); }
void Export_DrvSendMessage() { ApiAddresses[Index_DrvSendMessage](); }
void Export_GetDriverFlags() { ApiAddresses[Index_GetDriverFlags](); }
void Export_GetDriverModuleHandle() { ApiAddresses[Index_GetDriverModuleHandle](); }
void Export_GetFileVersionInfoA() { ApiAddresses[Index_GetFileVersionInfoA](); }
void Export_GetFileVersionInfoExA() { ApiAddresses[Index_GetFileVersionInfoExA](); }
void Export_GetFileVersionInfoExW() { ApiAddresses[Index_GetFileVersionInfoExW](); }
void Export_GetFileVersionInfoSizeA() { ApiAddresses[Index_GetFileVersionInfoSizeA](); }
void Export_GetFileVersionInfoSizeExA() { ApiAddresses[Index_GetFileVersionInfoSizeExA](); }
void Export_GetFileVersionInfoSizeExW() { ApiAddresses[Index_GetFileVersionInfoSizeExW](); }
void Export_GetFileVersionInfoSizeW() { ApiAddresses[Index_GetFileVersionInfoSizeW](); }
void Export_GetFileVersionInfoW() { ApiAddresses[Index_GetFileVersionInfoW](); }
void Export_OpenDriver() { ApiAddresses[Index_OpenDriver](); }
void Export_OpenDriverA() { ApiAddresses[Index_OpenDriverA](); }
void Export_PlaySound() { ApiAddresses[Index_PlaySound](); }
void Export_PlaySoundA() { ApiAddresses[Index_PlaySoundA](); }
void Export_PlaySoundW() { ApiAddresses[Index_PlaySoundW](); }
void Export_SendDriverMessage() { ApiAddresses[Index_SendDriverMessage](); }
void Export_VerFindFileA() { ApiAddresses[Index_VerFindFileA](); }
void Export_VerFindFileW() { ApiAddresses[Index_VerFindFileW](); }
void Export_VerInstallFileA() { ApiAddresses[Index_VerInstallFileA](); }
void Export_VerInstallFileW() { ApiAddresses[Index_VerInstallFileW](); }
void Export_VerLanguageNameA() { ApiAddresses[Index_VerLanguageNameA](); }
void Export_VerLanguageNameW() { ApiAddresses[Index_VerLanguageNameW](); }
void Export_VerQueryValueA() { ApiAddresses[Index_VerQueryValueA](); }
void Export_VerQueryValueW() { ApiAddresses[Index_VerQueryValueW](); }
void Export_WinHttpAddRequestHeaders() { ApiAddresses[Index_WinHttpAddRequestHeaders](); }
void Export_WinHttpCheckPlatform() { ApiAddresses[Index_WinHttpCheckPlatform](); }
void Export_WinHttpCloseHandle() { ApiAddresses[Index_WinHttpCloseHandle](); }
void Export_WinHttpConnect() { ApiAddresses[Index_WinHttpConnect](); }
void Export_WinHttpCrackUrl() { ApiAddresses[Index_WinHttpCrackUrl](); }
void Export_WinHttpCreateProxyResolver() { ApiAddresses[Index_WinHttpCreateProxyResolver](); }
void Export_WinHttpCreateUrl() { ApiAddresses[Index_WinHttpCreateUrl](); }
void Export_WinHttpDetectAutoProxyConfigUrl() { ApiAddresses[Index_WinHttpDetectAutoProxyConfigUrl](); }
void Export_WinHttpFreeProxyResult() { ApiAddresses[Index_WinHttpFreeProxyResult](); }
void Export_WinHttpFreeProxyResultEx() { ApiAddresses[Index_WinHttpFreeProxyResultEx](); }
void Export_WinHttpFreeProxySettings() { ApiAddresses[Index_WinHttpFreeProxySettings](); }
void Export_WinHttpGetDefaultProxyConfiguration() { ApiAddresses[Index_WinHttpGetDefaultProxyConfiguration](); }
void Export_WinHttpGetIEProxyConfigForCurrentUser() { ApiAddresses[Index_WinHttpGetIEProxyConfigForCurrentUser](); }
void Export_WinHttpGetProxyForUrl() { ApiAddresses[Index_WinHttpGetProxyForUrl](); }
void Export_WinHttpGetProxyForUrlEx() { ApiAddresses[Index_WinHttpGetProxyForUrlEx](); }
void Export_WinHttpGetProxyForUrlEx2() { ApiAddresses[Index_WinHttpGetProxyForUrlEx2](); }
void Export_WinHttpGetProxyResult() { ApiAddresses[Index_WinHttpGetProxyResult](); }
void Export_WinHttpGetProxyResultEx() { ApiAddresses[Index_WinHttpGetProxyResultEx](); }
void Export_WinHttpGetProxySettingsVersion() { ApiAddresses[Index_WinHttpGetProxySettingsVersion](); }
void Export_WinHttpOpen() { ApiAddresses[Index_WinHttpOpen](); }
void Export_WinHttpOpenRequest() { ApiAddresses[Index_WinHttpOpenRequest](); }
void Export_WinHttpQueryAuthSchemes() { ApiAddresses[Index_WinHttpQueryAuthSchemes](); }
void Export_WinHttpQueryDataAvailable() { ApiAddresses[Index_WinHttpQueryDataAvailable](); }
void Export_WinHttpQueryHeaders() { ApiAddresses[Index_WinHttpQueryHeaders](); }
void Export_WinHttpQueryOption() { ApiAddresses[Index_WinHttpQueryOption](); }
void Export_WinHttpReadData() { ApiAddresses[Index_WinHttpReadData](); }
void Export_WinHttpReadProxySettings() { ApiAddresses[Index_WinHttpReadProxySettings](); }
void Export_WinHttpReceiveResponse() { ApiAddresses[Index_WinHttpReceiveResponse](); }
void Export_WinHttpResetAutoProxy() { ApiAddresses[Index_WinHttpResetAutoProxy](); }
void Export_WinHttpSendRequest() { ApiAddresses[Index_WinHttpSendRequest](); }
void Export_WinHttpSetCredentials() { ApiAddresses[Index_WinHttpSetCredentials](); }
void Export_WinHttpSetDefaultProxyConfiguration() { ApiAddresses[Index_WinHttpSetDefaultProxyConfiguration](); }
void Export_WinHttpSetOption() { ApiAddresses[Index_WinHttpSetOption](); }
void Export_WinHttpSetStatusCallback() { ApiAddresses[Index_WinHttpSetStatusCallback](); }
void Export_WinHttpSetTimeouts() { ApiAddresses[Index_WinHttpSetTimeouts](); }
void Export_WinHttpTimeFromSystemTime() { ApiAddresses[Index_WinHttpTimeFromSystemTime](); }
void Export_WinHttpTimeToSystemTime() { ApiAddresses[Index_WinHttpTimeToSystemTime](); }
void Export_WinHttpWebSocketClose() { ApiAddresses[Index_WinHttpWebSocketClose](); }
void Export_WinHttpWebSocketCompleteUpgrade() { ApiAddresses[Index_WinHttpWebSocketCompleteUpgrade](); }
void Export_WinHttpWebSocketQueryCloseStatus() { ApiAddresses[Index_WinHttpWebSocketQueryCloseStatus](); }
void Export_WinHttpWebSocketReceive() { ApiAddresses[Index_WinHttpWebSocketReceive](); }
void Export_WinHttpWebSocketSend() { ApiAddresses[Index_WinHttpWebSocketSend](); }
void Export_WinHttpWebSocketShutdown() { ApiAddresses[Index_WinHttpWebSocketShutdown](); }
void Export_WinHttpWriteData() { ApiAddresses[Index_WinHttpWriteData](); }
void Export_WinHttpWriteProxySettings() { ApiAddresses[Index_WinHttpWriteProxySettings](); }
void Export_auxGetDevCapsA() { ApiAddresses[Index_auxGetDevCapsA](); }
void Export_auxGetDevCapsW() { ApiAddresses[Index_auxGetDevCapsW](); }
void Export_auxGetNumDevs() { ApiAddresses[Index_auxGetNumDevs](); }
void Export_auxGetVolume() { ApiAddresses[Index_auxGetVolume](); }
void Export_auxOutMessage() { ApiAddresses[Index_auxOutMessage](); }
void Export_auxSetVolume() { ApiAddresses[Index_auxSetVolume](); }
void Export_joyConfigChanged() { ApiAddresses[Index_joyConfigChanged](); }
void Export_joyGetDevCapsA() { ApiAddresses[Index_joyGetDevCapsA](); }
void Export_joyGetDevCapsW() { ApiAddresses[Index_joyGetDevCapsW](); }
void Export_joyGetNumDevs() { ApiAddresses[Index_joyGetNumDevs](); }
void Export_joyGetPos() { ApiAddresses[Index_joyGetPos](); }
void Export_joyGetPosEx() { ApiAddresses[Index_joyGetPosEx](); }
void Export_joyGetThreshold() { ApiAddresses[Index_joyGetThreshold](); }
void Export_joyReleaseCapture() { ApiAddresses[Index_joyReleaseCapture](); }
void Export_joySetCapture() { ApiAddresses[Index_joySetCapture](); }
void Export_joySetThreshold() { ApiAddresses[Index_joySetThreshold](); }
void Export_mciDriverNotify() { ApiAddresses[Index_mciDriverNotify](); }
void Export_mciDriverYield() { ApiAddresses[Index_mciDriverYield](); }
void Export_mciExecute() { ApiAddresses[Index_mciExecute](); }
void Export_mciFreeCommandResource() { ApiAddresses[Index_mciFreeCommandResource](); }
void Export_mciGetCreatorTask() { ApiAddresses[Index_mciGetCreatorTask](); }
void Export_mciGetDeviceIDA() { ApiAddresses[Index_mciGetDeviceIDA](); }
void Export_mciGetDeviceIDFromElementIDA() { ApiAddresses[Index_mciGetDeviceIDFromElementIDA](); }
void Export_mciGetDeviceIDFromElementIDW() { ApiAddresses[Index_mciGetDeviceIDFromElementIDW](); }
void Export_mciGetDeviceIDW() { ApiAddresses[Index_mciGetDeviceIDW](); }
void Export_mciGetDriverData() { ApiAddresses[Index_mciGetDriverData](); }
void Export_mciGetErrorStringA() { ApiAddresses[Index_mciGetErrorStringA](); }
void Export_mciGetErrorStringW() { ApiAddresses[Index_mciGetErrorStringW](); }
void Export_mciGetYieldProc() { ApiAddresses[Index_mciGetYieldProc](); }
void Export_mciLoadCommandResource() { ApiAddresses[Index_mciLoadCommandResource](); }
void Export_mciSendCommandA() { ApiAddresses[Index_mciSendCommandA](); }
void Export_mciSendCommandW() { ApiAddresses[Index_mciSendCommandW](); }
void Export_mciSendStringA() { ApiAddresses[Index_mciSendStringA](); }
void Export_mciSendStringW() { ApiAddresses[Index_mciSendStringW](); }
void Export_mciSetDriverData() { ApiAddresses[Index_mciSetDriverData](); }
void Export_mciSetYieldProc() { ApiAddresses[Index_mciSetYieldProc](); }
void Export_midiConnect() { ApiAddresses[Index_midiConnect](); }
void Export_midiDisconnect() { ApiAddresses[Index_midiDisconnect](); }
void Export_midiInAddBuffer() { ApiAddresses[Index_midiInAddBuffer](); }
void Export_midiInClose() { ApiAddresses[Index_midiInClose](); }
void Export_midiInGetDevCapsA() { ApiAddresses[Index_midiInGetDevCapsA](); }
void Export_midiInGetDevCapsW() { ApiAddresses[Index_midiInGetDevCapsW](); }
void Export_midiInGetErrorTextA() { ApiAddresses[Index_midiInGetErrorTextA](); }
void Export_midiInGetErrorTextW() { ApiAddresses[Index_midiInGetErrorTextW](); }
void Export_midiInGetID() { ApiAddresses[Index_midiInGetID](); }
void Export_midiInGetNumDevs() { ApiAddresses[Index_midiInGetNumDevs](); }
void Export_midiInMessage() { ApiAddresses[Index_midiInMessage](); }
void Export_midiInOpen() { ApiAddresses[Index_midiInOpen](); }
void Export_midiInPrepareHeader() { ApiAddresses[Index_midiInPrepareHeader](); }
void Export_midiInReset() { ApiAddresses[Index_midiInReset](); }
void Export_midiInStart() { ApiAddresses[Index_midiInStart](); }
void Export_midiInStop() { ApiAddresses[Index_midiInStop](); }
void Export_midiInUnprepareHeader() { ApiAddresses[Index_midiInUnprepareHeader](); }
void Export_midiOutCacheDrumPatches() { ApiAddresses[Index_midiOutCacheDrumPatches](); }
void Export_midiOutCachePatches() { ApiAddresses[Index_midiOutCachePatches](); }
void Export_midiOutClose() { ApiAddresses[Index_midiOutClose](); }
void Export_midiOutGetDevCapsA() { ApiAddresses[Index_midiOutGetDevCapsA](); }
void Export_midiOutGetDevCapsW() { ApiAddresses[Index_midiOutGetDevCapsW](); }
void Export_midiOutGetErrorTextA() { ApiAddresses[Index_midiOutGetErrorTextA](); }
void Export_midiOutGetErrorTextW() { ApiAddresses[Index_midiOutGetErrorTextW](); }
void Export_midiOutGetID() { ApiAddresses[Index_midiOutGetID](); }
void Export_midiOutGetNumDevs() { ApiAddresses[Index_midiOutGetNumDevs](); }
void Export_midiOutGetVolume() { ApiAddresses[Index_midiOutGetVolume](); }
void Export_midiOutLongMsg() { ApiAddresses[Index_midiOutLongMsg](); }
void Export_midiOutMessage() { ApiAddresses[Index_midiOutMessage](); }
void Export_midiOutOpen() { ApiAddresses[Index_midiOutOpen](); }
void Export_midiOutPrepareHeader() { ApiAddresses[Index_midiOutPrepareHeader](); }
void Export_midiOutReset() { ApiAddresses[Index_midiOutReset](); }
void Export_midiOutSetVolume() { ApiAddresses[Index_midiOutSetVolume](); }
void Export_midiOutShortMsg() { ApiAddresses[Index_midiOutShortMsg](); }
void Export_midiOutUnprepareHeader() { ApiAddresses[Index_midiOutUnprepareHeader](); }
void Export_midiStreamClose() { ApiAddresses[Index_midiStreamClose](); }
void Export_midiStreamOpen() { ApiAddresses[Index_midiStreamOpen](); }
void Export_midiStreamOut() { ApiAddresses[Index_midiStreamOut](); }
void Export_midiStreamPause() { ApiAddresses[Index_midiStreamPause](); }
void Export_midiStreamPosition() { ApiAddresses[Index_midiStreamPosition](); }
void Export_midiStreamProperty() { ApiAddresses[Index_midiStreamProperty](); }
void Export_midiStreamRestart() { ApiAddresses[Index_midiStreamRestart](); }
void Export_midiStreamStop() { ApiAddresses[Index_midiStreamStop](); }
void Export_mixerClose() { ApiAddresses[Index_mixerClose](); }
void Export_mixerGetControlDetailsA() { ApiAddresses[Index_mixerGetControlDetailsA](); }
void Export_mixerGetControlDetailsW() { ApiAddresses[Index_mixerGetControlDetailsW](); }
void Export_mixerGetDevCapsA() { ApiAddresses[Index_mixerGetDevCapsA](); }
void Export_mixerGetDevCapsW() { ApiAddresses[Index_mixerGetDevCapsW](); }
void Export_mixerGetID() { ApiAddresses[Index_mixerGetID](); }
void Export_mixerGetLineControlsA() { ApiAddresses[Index_mixerGetLineControlsA](); }
void Export_mixerGetLineControlsW() { ApiAddresses[Index_mixerGetLineControlsW](); }
void Export_mixerGetLineInfoA() { ApiAddresses[Index_mixerGetLineInfoA](); }
void Export_mixerGetLineInfoW() { ApiAddresses[Index_mixerGetLineInfoW](); }
void Export_mixerGetNumDevs() { ApiAddresses[Index_mixerGetNumDevs](); }
void Export_mixerMessage() { ApiAddresses[Index_mixerMessage](); }
void Export_mixerOpen() { ApiAddresses[Index_mixerOpen](); }
void Export_mixerSetControlDetails() { ApiAddresses[Index_mixerSetControlDetails](); }
void Export_mmGetCurrentTask() { ApiAddresses[Index_mmGetCurrentTask](); }
void Export_mmTaskBlock() { ApiAddresses[Index_mmTaskBlock](); }
void Export_mmTaskCreate() { ApiAddresses[Index_mmTaskCreate](); }
void Export_mmTaskSignal() { ApiAddresses[Index_mmTaskSignal](); }
void Export_mmTaskYield() { ApiAddresses[Index_mmTaskYield](); }
void Export_mmioAdvance() { ApiAddresses[Index_mmioAdvance](); }
void Export_mmioAscend() { ApiAddresses[Index_mmioAscend](); }
void Export_mmioClose() { ApiAddresses[Index_mmioClose](); }
void Export_mmioCreateChunk() { ApiAddresses[Index_mmioCreateChunk](); }
void Export_mmioDescend() { ApiAddresses[Index_mmioDescend](); }
void Export_mmioFlush() { ApiAddresses[Index_mmioFlush](); }
void Export_mmioGetInfo() { ApiAddresses[Index_mmioGetInfo](); }
void Export_mmioInstallIOProc16() { ApiAddresses[Index_mmioInstallIOProc16](); }
void Export_mmioInstallIOProcA() { ApiAddresses[Index_mmioInstallIOProcA](); }
void Export_mmioInstallIOProcW() { ApiAddresses[Index_mmioInstallIOProcW](); }
void Export_mmioOpenA() { ApiAddresses[Index_mmioOpenA](); }
void Export_mmioOpenW() { ApiAddresses[Index_mmioOpenW](); }
void Export_mmioRead() { ApiAddresses[Index_mmioRead](); }
void Export_mmioRenameA() { ApiAddresses[Index_mmioRenameA](); }
void Export_mmioRenameW() { ApiAddresses[Index_mmioRenameW](); }
void Export_mmioSeek() { ApiAddresses[Index_mmioSeek](); }
void Export_mmioSendMessage() { ApiAddresses[Index_mmioSendMessage](); }
void Export_mmioSetBuffer() { ApiAddresses[Index_mmioSetBuffer](); }
void Export_mmioSetInfo() { ApiAddresses[Index_mmioSetInfo](); }
void Export_mmioStringToFOURCCA() { ApiAddresses[Index_mmioStringToFOURCCA](); }
void Export_mmioStringToFOURCCW() { ApiAddresses[Index_mmioStringToFOURCCW](); }
void Export_mmioWrite() { ApiAddresses[Index_mmioWrite](); }
void Export_mmsystemGetVersion() { ApiAddresses[Index_mmsystemGetVersion](); }
void Export_sndPlaySoundA() { ApiAddresses[Index_sndPlaySoundA](); }
void Export_sndPlaySoundW() { ApiAddresses[Index_sndPlaySoundW](); }
void Export_timeBeginPeriod() { ApiAddresses[Index_timeBeginPeriod](); }
void Export_timeEndPeriod() { ApiAddresses[Index_timeEndPeriod](); }
void Export_timeGetDevCaps() { ApiAddresses[Index_timeGetDevCaps](); }
void Export_timeGetSystemTime() { ApiAddresses[Index_timeGetSystemTime](); }
void Export_timeGetTime() { ApiAddresses[Index_timeGetTime](); }
void Export_timeKillEvent() { ApiAddresses[Index_timeKillEvent](); }
void Export_timeSetEvent() { ApiAddresses[Index_timeSetEvent](); }
void Export_waveInAddBuffer() { ApiAddresses[Index_waveInAddBuffer](); }
void Export_waveInClose() { ApiAddresses[Index_waveInClose](); }
void Export_waveInGetDevCapsA() { ApiAddresses[Index_waveInGetDevCapsA](); }
void Export_waveInGetDevCapsW() { ApiAddresses[Index_waveInGetDevCapsW](); }
void Export_waveInGetErrorTextA() { ApiAddresses[Index_waveInGetErrorTextA](); }
void Export_waveInGetErrorTextW() { ApiAddresses[Index_waveInGetErrorTextW](); }
void Export_waveInGetID() { ApiAddresses[Index_waveInGetID](); }
void Export_waveInGetNumDevs() { ApiAddresses[Index_waveInGetNumDevs](); }
void Export_waveInGetPosition() { ApiAddresses[Index_waveInGetPosition](); }
void Export_waveInMessage() { ApiAddresses[Index_waveInMessage](); }
void Export_waveInOpen() { ApiAddresses[Index_waveInOpen](); }
void Export_waveInPrepareHeader() { ApiAddresses[Index_waveInPrepareHeader](); }
void Export_waveInReset() { ApiAddresses[Index_waveInReset](); }
void Export_waveInStart() { ApiAddresses[Index_waveInStart](); }
void Export_waveInStop() { ApiAddresses[Index_waveInStop](); }
void Export_waveInUnprepareHeader() { ApiAddresses[Index_waveInUnprepareHeader](); }
void Export_waveOutBreakLoop() { ApiAddresses[Index_waveOutBreakLoop](); }
void Export_waveOutClose() { ApiAddresses[Index_waveOutClose](); }
void Export_waveOutGetDevCapsA() { ApiAddresses[Index_waveOutGetDevCapsA](); }
void Export_waveOutGetDevCapsW() { ApiAddresses[Index_waveOutGetDevCapsW](); }
void Export_waveOutGetErrorTextA() { ApiAddresses[Index_waveOutGetErrorTextA](); }
void Export_waveOutGetErrorTextW() { ApiAddresses[Index_waveOutGetErrorTextW](); }
void Export_waveOutGetID() { ApiAddresses[Index_waveOutGetID](); }
void Export_waveOutGetNumDevs() { ApiAddresses[Index_waveOutGetNumDevs](); }
void Export_waveOutGetPitch() { ApiAddresses[Index_waveOutGetPitch](); }
void Export_waveOutGetPlaybackRate() { ApiAddresses[Index_waveOutGetPlaybackRate](); }
void Export_waveOutGetPosition() { ApiAddresses[Index_waveOutGetPosition](); }
void Export_waveOutGetVolume() { ApiAddresses[Index_waveOutGetVolume](); }
void Export_waveOutMessage() { ApiAddresses[Index_waveOutMessage](); }
void Export_waveOutOpen() { ApiAddresses[Index_waveOutOpen](); }
void Export_waveOutPause() { ApiAddresses[Index_waveOutPause](); }
void Export_waveOutPrepareHeader() { ApiAddresses[Index_waveOutPrepareHeader](); }
void Export_waveOutReset() { ApiAddresses[Index_waveOutReset](); }
void Export_waveOutRestart() { ApiAddresses[Index_waveOutRestart](); }
void Export_waveOutSetPitch() { ApiAddresses[Index_waveOutSetPitch](); }
void Export_waveOutSetPlaybackRate() { ApiAddresses[Index_waveOutSetPlaybackRate](); }
void Export_waveOutSetVolume() { ApiAddresses[Index_waveOutSetVolume](); }
void Export_waveOutUnprepareHeader() { ApiAddresses[Index_waveOutUnprepareHeader](); }
void Export_waveOutWrite() { ApiAddresses[Index_waveOutWrite](); }
