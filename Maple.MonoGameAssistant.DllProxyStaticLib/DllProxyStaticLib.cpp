#include "DllProxyStaticLib.h"

HMODULE WINAPI LoadOriginalModule(HINSTANCE hInstance)
{
	GetModuleFileName(hInstance, FileName, MAX_PATH);
	PathStripPath(FileName);
	GetSystemDirectory(SysPath, MAX_PATH);
	PathCombine(FullPath, SysPath, FileName);
	return LoadLibrary(FullPath);
}
void WINAPI LoadFunctions(HMODULE hOriginal)
{
	for (unsigned int i = 0; i < Index_MaxSize; ++i)
	{
		LPCSTR name = ApiNames[i];
		FARPROC address = GetProcAddress(hOriginal, name);
		ApiAddresses[i] = address;
	}
}
void WINAPI LoadProxy(HINSTANCE hInstance)
{
	LoadFunctions(LoadOriginalModule(hInstance));
}
BOOL WINAPI InitDllMain(HINSTANCE hModule, DWORD ul_reason_for_call, LPVOID lpReserved)
{
	if (ul_reason_for_call == DLL_PROCESS_ATTACH)
	{
		LoadProxy(hModule);
	}
	return TRUE;
}

void WINAPI Export_CloseDriver() { ApiAddresses[Index_CloseDriver](); }
void WINAPI Export_DefDriverProc() { ApiAddresses[Index_DefDriverProc](); }
void WINAPI Export_DllCanUnloadNow() { ApiAddresses[Index_DllCanUnloadNow](); }
void WINAPI Export_DllGetClassObject() { ApiAddresses[Index_DllGetClassObject](); }
void WINAPI Export_DllRegisterServer() { ApiAddresses[Index_DllRegisterServer](); }
void WINAPI Export_DllUnregisterServer() { ApiAddresses[Index_DllUnregisterServer](); }
void WINAPI Export_DriverCallback() { ApiAddresses[Index_DriverCallback](); }
void WINAPI Export_DrvClose() { ApiAddresses[Index_DrvClose](); }
void WINAPI Export_DrvDefDriverProc() { ApiAddresses[Index_DrvDefDriverProc](); }
void WINAPI Export_DrvGetModuleHandle() { ApiAddresses[Index_DrvGetModuleHandle](); }
void WINAPI Export_DrvOpen() { ApiAddresses[Index_DrvOpen](); }
void WINAPI Export_DrvOpenA() { ApiAddresses[Index_DrvOpenA](); }
void WINAPI Export_DrvSendMessage() { ApiAddresses[Index_DrvSendMessage](); }
void WINAPI Export_GetDriverFlags() { ApiAddresses[Index_GetDriverFlags](); }
void WINAPI Export_GetDriverModuleHandle() { ApiAddresses[Index_GetDriverModuleHandle](); }
void WINAPI Export_GetFileVersionInfoA() { ApiAddresses[Index_GetFileVersionInfoA](); }
void WINAPI Export_GetFileVersionInfoExA() { ApiAddresses[Index_GetFileVersionInfoExA](); }
void WINAPI Export_GetFileVersionInfoExW() { ApiAddresses[Index_GetFileVersionInfoExW](); }
void WINAPI Export_GetFileVersionInfoSizeA() { ApiAddresses[Index_GetFileVersionInfoSizeA](); }
void WINAPI Export_GetFileVersionInfoSizeExA() { ApiAddresses[Index_GetFileVersionInfoSizeExA](); }
void WINAPI Export_GetFileVersionInfoSizeExW() { ApiAddresses[Index_GetFileVersionInfoSizeExW](); }
void WINAPI Export_GetFileVersionInfoSizeW() { ApiAddresses[Index_GetFileVersionInfoSizeW](); }
void WINAPI Export_GetFileVersionInfoW() { ApiAddresses[Index_GetFileVersionInfoW](); }
void WINAPI Export_OpenDriver() { ApiAddresses[Index_OpenDriver](); }
void WINAPI Export_OpenDriverA() { ApiAddresses[Index_OpenDriverA](); }
void WINAPI Export_PlaySound() { ApiAddresses[Index_PlaySound](); }
void WINAPI Export_PlaySoundA() { ApiAddresses[Index_PlaySoundA](); }
void WINAPI Export_PlaySoundW() { ApiAddresses[Index_PlaySoundW](); }
void WINAPI Export_SendDriverMessage() { ApiAddresses[Index_SendDriverMessage](); }
void WINAPI Export_VerFindFileA() { ApiAddresses[Index_VerFindFileA](); }
void WINAPI Export_VerFindFileW() { ApiAddresses[Index_VerFindFileW](); }
void WINAPI Export_VerInstallFileA() { ApiAddresses[Index_VerInstallFileA](); }
void WINAPI Export_VerInstallFileW() { ApiAddresses[Index_VerInstallFileW](); }
void WINAPI Export_VerLanguageNameA() { ApiAddresses[Index_VerLanguageNameA](); }
void WINAPI Export_VerLanguageNameW() { ApiAddresses[Index_VerLanguageNameW](); }
void WINAPI Export_VerQueryValueA() { ApiAddresses[Index_VerQueryValueA](); }
void WINAPI Export_VerQueryValueW() { ApiAddresses[Index_VerQueryValueW](); }
void WINAPI Export_WinHttpAddRequestHeaders() { ApiAddresses[Index_WinHttpAddRequestHeaders](); }
void WINAPI Export_WinHttpCheckPlatform() { ApiAddresses[Index_WinHttpCheckPlatform](); }
void WINAPI Export_WinHttpCloseHandle() { ApiAddresses[Index_WinHttpCloseHandle](); }
void WINAPI Export_WinHttpConnect() { ApiAddresses[Index_WinHttpConnect](); }
void WINAPI Export_WinHttpCrackUrl() { ApiAddresses[Index_WinHttpCrackUrl](); }
void WINAPI Export_WinHttpCreateProxyResolver() { ApiAddresses[Index_WinHttpCreateProxyResolver](); }
void WINAPI Export_WinHttpCreateUrl() { ApiAddresses[Index_WinHttpCreateUrl](); }
void WINAPI Export_WinHttpDetectAutoProxyConfigUrl() { ApiAddresses[Index_WinHttpDetectAutoProxyConfigUrl](); }
void WINAPI Export_WinHttpFreeProxyResult() { ApiAddresses[Index_WinHttpFreeProxyResult](); }
void WINAPI Export_WinHttpFreeProxyResultEx() { ApiAddresses[Index_WinHttpFreeProxyResultEx](); }
void WINAPI Export_WinHttpFreeProxySettings() { ApiAddresses[Index_WinHttpFreeProxySettings](); }
void WINAPI Export_WinHttpGetDefaultProxyConfiguration() { ApiAddresses[Index_WinHttpGetDefaultProxyConfiguration](); }
void WINAPI Export_WinHttpGetIEProxyConfigForCurrentUser() { ApiAddresses[Index_WinHttpGetIEProxyConfigForCurrentUser](); }
void WINAPI Export_WinHttpGetProxyForUrl() { ApiAddresses[Index_WinHttpGetProxyForUrl](); }
void WINAPI Export_WinHttpGetProxyForUrlEx() { ApiAddresses[Index_WinHttpGetProxyForUrlEx](); }
void WINAPI Export_WinHttpGetProxyForUrlEx2() { ApiAddresses[Index_WinHttpGetProxyForUrlEx2](); }
void WINAPI Export_WinHttpGetProxyResult() { ApiAddresses[Index_WinHttpGetProxyResult](); }
void WINAPI Export_WinHttpGetProxyResultEx() { ApiAddresses[Index_WinHttpGetProxyResultEx](); }
void WINAPI Export_WinHttpGetProxySettingsVersion() { ApiAddresses[Index_WinHttpGetProxySettingsVersion](); }
void WINAPI Export_WinHttpOpen() { ApiAddresses[Index_WinHttpOpen](); }
void WINAPI Export_WinHttpOpenRequest() { ApiAddresses[Index_WinHttpOpenRequest](); }
void WINAPI Export_WinHttpQueryAuthSchemes() { ApiAddresses[Index_WinHttpQueryAuthSchemes](); }
void WINAPI Export_WinHttpQueryDataAvailable() { ApiAddresses[Index_WinHttpQueryDataAvailable](); }
void WINAPI Export_WinHttpQueryHeaders() { ApiAddresses[Index_WinHttpQueryHeaders](); }
void WINAPI Export_WinHttpQueryOption() { ApiAddresses[Index_WinHttpQueryOption](); }
void WINAPI Export_WinHttpReadData() { ApiAddresses[Index_WinHttpReadData](); }
void WINAPI Export_WinHttpReadProxySettings() { ApiAddresses[Index_WinHttpReadProxySettings](); }
void WINAPI Export_WinHttpReceiveResponse() { ApiAddresses[Index_WinHttpReceiveResponse](); }
void WINAPI Export_WinHttpResetAutoProxy() { ApiAddresses[Index_WinHttpResetAutoProxy](); }
void WINAPI Export_WinHttpSendRequest() { ApiAddresses[Index_WinHttpSendRequest](); }
void WINAPI Export_WinHttpSetCredentials() { ApiAddresses[Index_WinHttpSetCredentials](); }
void WINAPI Export_WinHttpSetDefaultProxyConfiguration() { ApiAddresses[Index_WinHttpSetDefaultProxyConfiguration](); }
void WINAPI Export_WinHttpSetOption() { ApiAddresses[Index_WinHttpSetOption](); }
void WINAPI Export_WinHttpSetStatusCallback() { ApiAddresses[Index_WinHttpSetStatusCallback](); }
void WINAPI Export_WinHttpSetTimeouts() { ApiAddresses[Index_WinHttpSetTimeouts](); }
void WINAPI Export_WinHttpTimeFromSystemTime() { ApiAddresses[Index_WinHttpTimeFromSystemTime](); }
void WINAPI Export_WinHttpTimeToSystemTime() { ApiAddresses[Index_WinHttpTimeToSystemTime](); }
void WINAPI Export_WinHttpWebSocketClose() { ApiAddresses[Index_WinHttpWebSocketClose](); }
void WINAPI Export_WinHttpWebSocketCompleteUpgrade() { ApiAddresses[Index_WinHttpWebSocketCompleteUpgrade](); }
void WINAPI Export_WinHttpWebSocketQueryCloseStatus() { ApiAddresses[Index_WinHttpWebSocketQueryCloseStatus](); }
void WINAPI Export_WinHttpWebSocketReceive() { ApiAddresses[Index_WinHttpWebSocketReceive](); }
void WINAPI Export_WinHttpWebSocketSend() { ApiAddresses[Index_WinHttpWebSocketSend](); }
void WINAPI Export_WinHttpWebSocketShutdown() { ApiAddresses[Index_WinHttpWebSocketShutdown](); }
void WINAPI Export_WinHttpWriteData() { ApiAddresses[Index_WinHttpWriteData](); }
void WINAPI Export_WinHttpWriteProxySettings() { ApiAddresses[Index_WinHttpWriteProxySettings](); }
void WINAPI Export_auxGetDevCapsA() { ApiAddresses[Index_auxGetDevCapsA](); }
void WINAPI Export_auxGetDevCapsW() { ApiAddresses[Index_auxGetDevCapsW](); }
void WINAPI Export_auxGetNumDevs() { ApiAddresses[Index_auxGetNumDevs](); }
void WINAPI Export_auxGetVolume() { ApiAddresses[Index_auxGetVolume](); }
void WINAPI Export_auxOutMessage() { ApiAddresses[Index_auxOutMessage](); }
void WINAPI Export_auxSetVolume() { ApiAddresses[Index_auxSetVolume](); }
void WINAPI Export_joyConfigChanged() { ApiAddresses[Index_joyConfigChanged](); }
void WINAPI Export_joyGetDevCapsA() { ApiAddresses[Index_joyGetDevCapsA](); }
void WINAPI Export_joyGetDevCapsW() { ApiAddresses[Index_joyGetDevCapsW](); }
void WINAPI Export_joyGetNumDevs() { ApiAddresses[Index_joyGetNumDevs](); }
void WINAPI Export_joyGetPos() { ApiAddresses[Index_joyGetPos](); }
void WINAPI Export_joyGetPosEx() { ApiAddresses[Index_joyGetPosEx](); }
void WINAPI Export_joyGetThreshold() { ApiAddresses[Index_joyGetThreshold](); }
void WINAPI Export_joyReleaseCapture() { ApiAddresses[Index_joyReleaseCapture](); }
void WINAPI Export_joySetCapture() { ApiAddresses[Index_joySetCapture](); }
void WINAPI Export_joySetThreshold() { ApiAddresses[Index_joySetThreshold](); }
void WINAPI Export_mciDriverNotify() { ApiAddresses[Index_mciDriverNotify](); }
void WINAPI Export_mciDriverYield() { ApiAddresses[Index_mciDriverYield](); }
void WINAPI Export_mciExecute() { ApiAddresses[Index_mciExecute](); }
void WINAPI Export_mciFreeCommandResource() { ApiAddresses[Index_mciFreeCommandResource](); }
void WINAPI Export_mciGetCreatorTask() { ApiAddresses[Index_mciGetCreatorTask](); }
void WINAPI Export_mciGetDeviceIDA() { ApiAddresses[Index_mciGetDeviceIDA](); }
void WINAPI Export_mciGetDeviceIDFromElementIDA() { ApiAddresses[Index_mciGetDeviceIDFromElementIDA](); }
void WINAPI Export_mciGetDeviceIDFromElementIDW() { ApiAddresses[Index_mciGetDeviceIDFromElementIDW](); }
void WINAPI Export_mciGetDeviceIDW() { ApiAddresses[Index_mciGetDeviceIDW](); }
void WINAPI Export_mciGetDriverData() { ApiAddresses[Index_mciGetDriverData](); }
void WINAPI Export_mciGetErrorStringA() { ApiAddresses[Index_mciGetErrorStringA](); }
void WINAPI Export_mciGetErrorStringW() { ApiAddresses[Index_mciGetErrorStringW](); }
void WINAPI Export_mciGetYieldProc() { ApiAddresses[Index_mciGetYieldProc](); }
void WINAPI Export_mciLoadCommandResource() { ApiAddresses[Index_mciLoadCommandResource](); }
void WINAPI Export_mciSendCommandA() { ApiAddresses[Index_mciSendCommandA](); }
void WINAPI Export_mciSendCommandW() { ApiAddresses[Index_mciSendCommandW](); }
void WINAPI Export_mciSendStringA() { ApiAddresses[Index_mciSendStringA](); }
void WINAPI Export_mciSendStringW() { ApiAddresses[Index_mciSendStringW](); }
void WINAPI Export_mciSetDriverData() { ApiAddresses[Index_mciSetDriverData](); }
void WINAPI Export_mciSetYieldProc() { ApiAddresses[Index_mciSetYieldProc](); }
void WINAPI Export_midiConnect() { ApiAddresses[Index_midiConnect](); }
void WINAPI Export_midiDisconnect() { ApiAddresses[Index_midiDisconnect](); }
void WINAPI Export_midiInAddBuffer() { ApiAddresses[Index_midiInAddBuffer](); }
void WINAPI Export_midiInClose() { ApiAddresses[Index_midiInClose](); }
void WINAPI Export_midiInGetDevCapsA() { ApiAddresses[Index_midiInGetDevCapsA](); }
void WINAPI Export_midiInGetDevCapsW() { ApiAddresses[Index_midiInGetDevCapsW](); }
void WINAPI Export_midiInGetErrorTextA() { ApiAddresses[Index_midiInGetErrorTextA](); }
void WINAPI Export_midiInGetErrorTextW() { ApiAddresses[Index_midiInGetErrorTextW](); }
void WINAPI Export_midiInGetID() { ApiAddresses[Index_midiInGetID](); }
void WINAPI Export_midiInGetNumDevs() { ApiAddresses[Index_midiInGetNumDevs](); }
void WINAPI Export_midiInMessage() { ApiAddresses[Index_midiInMessage](); }
void WINAPI Export_midiInOpen() { ApiAddresses[Index_midiInOpen](); }
void WINAPI Export_midiInPrepareHeader() { ApiAddresses[Index_midiInPrepareHeader](); }
void WINAPI Export_midiInReset() { ApiAddresses[Index_midiInReset](); }
void WINAPI Export_midiInStart() { ApiAddresses[Index_midiInStart](); }
void WINAPI Export_midiInStop() { ApiAddresses[Index_midiInStop](); }
void WINAPI Export_midiInUnprepareHeader() { ApiAddresses[Index_midiInUnprepareHeader](); }
void WINAPI Export_midiOutCacheDrumPatches() { ApiAddresses[Index_midiOutCacheDrumPatches](); }
void WINAPI Export_midiOutCachePatches() { ApiAddresses[Index_midiOutCachePatches](); }
void WINAPI Export_midiOutClose() { ApiAddresses[Index_midiOutClose](); }
void WINAPI Export_midiOutGetDevCapsA() { ApiAddresses[Index_midiOutGetDevCapsA](); }
void WINAPI Export_midiOutGetDevCapsW() { ApiAddresses[Index_midiOutGetDevCapsW](); }
void WINAPI Export_midiOutGetErrorTextA() { ApiAddresses[Index_midiOutGetErrorTextA](); }
void WINAPI Export_midiOutGetErrorTextW() { ApiAddresses[Index_midiOutGetErrorTextW](); }
void WINAPI Export_midiOutGetID() { ApiAddresses[Index_midiOutGetID](); }
void WINAPI Export_midiOutGetNumDevs() { ApiAddresses[Index_midiOutGetNumDevs](); }
void WINAPI Export_midiOutGetVolume() { ApiAddresses[Index_midiOutGetVolume](); }
void WINAPI Export_midiOutLongMsg() { ApiAddresses[Index_midiOutLongMsg](); }
void WINAPI Export_midiOutMessage() { ApiAddresses[Index_midiOutMessage](); }
void WINAPI Export_midiOutOpen() { ApiAddresses[Index_midiOutOpen](); }
void WINAPI Export_midiOutPrepareHeader() { ApiAddresses[Index_midiOutPrepareHeader](); }
void WINAPI Export_midiOutReset() { ApiAddresses[Index_midiOutReset](); }
void WINAPI Export_midiOutSetVolume() { ApiAddresses[Index_midiOutSetVolume](); }
void WINAPI Export_midiOutShortMsg() { ApiAddresses[Index_midiOutShortMsg](); }
void WINAPI Export_midiOutUnprepareHeader() { ApiAddresses[Index_midiOutUnprepareHeader](); }
void WINAPI Export_midiStreamClose() { ApiAddresses[Index_midiStreamClose](); }
void WINAPI Export_midiStreamOpen() { ApiAddresses[Index_midiStreamOpen](); }
void WINAPI Export_midiStreamOut() { ApiAddresses[Index_midiStreamOut](); }
void WINAPI Export_midiStreamPause() { ApiAddresses[Index_midiStreamPause](); }
void WINAPI Export_midiStreamPosition() { ApiAddresses[Index_midiStreamPosition](); }
void WINAPI Export_midiStreamProperty() { ApiAddresses[Index_midiStreamProperty](); }
void WINAPI Export_midiStreamRestart() { ApiAddresses[Index_midiStreamRestart](); }
void WINAPI Export_midiStreamStop() { ApiAddresses[Index_midiStreamStop](); }
void WINAPI Export_mixerClose() { ApiAddresses[Index_mixerClose](); }
void WINAPI Export_mixerGetControlDetailsA() { ApiAddresses[Index_mixerGetControlDetailsA](); }
void WINAPI Export_mixerGetControlDetailsW() { ApiAddresses[Index_mixerGetControlDetailsW](); }
void WINAPI Export_mixerGetDevCapsA() { ApiAddresses[Index_mixerGetDevCapsA](); }
void WINAPI Export_mixerGetDevCapsW() { ApiAddresses[Index_mixerGetDevCapsW](); }
void WINAPI Export_mixerGetID() { ApiAddresses[Index_mixerGetID](); }
void WINAPI Export_mixerGetLineControlsA() { ApiAddresses[Index_mixerGetLineControlsA](); }
void WINAPI Export_mixerGetLineControlsW() { ApiAddresses[Index_mixerGetLineControlsW](); }
void WINAPI Export_mixerGetLineInfoA() { ApiAddresses[Index_mixerGetLineInfoA](); }
void WINAPI Export_mixerGetLineInfoW() { ApiAddresses[Index_mixerGetLineInfoW](); }
void WINAPI Export_mixerGetNumDevs() { ApiAddresses[Index_mixerGetNumDevs](); }
void WINAPI Export_mixerMessage() { ApiAddresses[Index_mixerMessage](); }
void WINAPI Export_mixerOpen() { ApiAddresses[Index_mixerOpen](); }
void WINAPI Export_mixerSetControlDetails() { ApiAddresses[Index_mixerSetControlDetails](); }
void WINAPI Export_mmGetCurrentTask() { ApiAddresses[Index_mmGetCurrentTask](); }
void WINAPI Export_mmTaskBlock() { ApiAddresses[Index_mmTaskBlock](); }
void WINAPI Export_mmTaskCreate() { ApiAddresses[Index_mmTaskCreate](); }
void WINAPI Export_mmTaskSignal() { ApiAddresses[Index_mmTaskSignal](); }
void WINAPI Export_mmTaskYield() { ApiAddresses[Index_mmTaskYield](); }
void WINAPI Export_mmioAdvance() { ApiAddresses[Index_mmioAdvance](); }
void WINAPI Export_mmioAscend() { ApiAddresses[Index_mmioAscend](); }
void WINAPI Export_mmioClose() { ApiAddresses[Index_mmioClose](); }
void WINAPI Export_mmioCreateChunk() { ApiAddresses[Index_mmioCreateChunk](); }
void WINAPI Export_mmioDescend() { ApiAddresses[Index_mmioDescend](); }
void WINAPI Export_mmioFlush() { ApiAddresses[Index_mmioFlush](); }
void WINAPI Export_mmioGetInfo() { ApiAddresses[Index_mmioGetInfo](); }
void WINAPI Export_mmioInstallIOProc16() { ApiAddresses[Index_mmioInstallIOProc16](); }
void WINAPI Export_mmioInstallIOProcA() { ApiAddresses[Index_mmioInstallIOProcA](); }
void WINAPI Export_mmioInstallIOProcW() { ApiAddresses[Index_mmioInstallIOProcW](); }
void WINAPI Export_mmioOpenA() { ApiAddresses[Index_mmioOpenA](); }
void WINAPI Export_mmioOpenW() { ApiAddresses[Index_mmioOpenW](); }
void WINAPI Export_mmioRead() { ApiAddresses[Index_mmioRead](); }
void WINAPI Export_mmioRenameA() { ApiAddresses[Index_mmioRenameA](); }
void WINAPI Export_mmioRenameW() { ApiAddresses[Index_mmioRenameW](); }
void WINAPI Export_mmioSeek() { ApiAddresses[Index_mmioSeek](); }
void WINAPI Export_mmioSendMessage() { ApiAddresses[Index_mmioSendMessage](); }
void WINAPI Export_mmioSetBuffer() { ApiAddresses[Index_mmioSetBuffer](); }
void WINAPI Export_mmioSetInfo() { ApiAddresses[Index_mmioSetInfo](); }
void WINAPI Export_mmioStringToFOURCCA() { ApiAddresses[Index_mmioStringToFOURCCA](); }
void WINAPI Export_mmioStringToFOURCCW() { ApiAddresses[Index_mmioStringToFOURCCW](); }
void WINAPI Export_mmioWrite() { ApiAddresses[Index_mmioWrite](); }
void WINAPI Export_mmsystemGetVersion() { ApiAddresses[Index_mmsystemGetVersion](); }
void WINAPI Export_sndPlaySoundA() { ApiAddresses[Index_sndPlaySoundA](); }
void WINAPI Export_sndPlaySoundW() { ApiAddresses[Index_sndPlaySoundW](); }
void WINAPI Export_timeBeginPeriod() { ApiAddresses[Index_timeBeginPeriod](); }
void WINAPI Export_timeEndPeriod() { ApiAddresses[Index_timeEndPeriod](); }
void WINAPI Export_timeGetDevCaps() { ApiAddresses[Index_timeGetDevCaps](); }
void WINAPI Export_timeGetSystemTime() { ApiAddresses[Index_timeGetSystemTime](); }
void WINAPI Export_timeGetTime() { ApiAddresses[Index_timeGetTime](); }
void WINAPI Export_timeKillEvent() { ApiAddresses[Index_timeKillEvent](); }
void WINAPI Export_timeSetEvent() { ApiAddresses[Index_timeSetEvent](); }
void WINAPI Export_waveInAddBuffer() { ApiAddresses[Index_waveInAddBuffer](); }
void WINAPI Export_waveInClose() { ApiAddresses[Index_waveInClose](); }
void WINAPI Export_waveInGetDevCapsA() { ApiAddresses[Index_waveInGetDevCapsA](); }
void WINAPI Export_waveInGetDevCapsW() { ApiAddresses[Index_waveInGetDevCapsW](); }
void WINAPI Export_waveInGetErrorTextA() { ApiAddresses[Index_waveInGetErrorTextA](); }
void WINAPI Export_waveInGetErrorTextW() { ApiAddresses[Index_waveInGetErrorTextW](); }
void WINAPI Export_waveInGetID() { ApiAddresses[Index_waveInGetID](); }
void WINAPI Export_waveInGetNumDevs() { ApiAddresses[Index_waveInGetNumDevs](); }
void WINAPI Export_waveInGetPosition() { ApiAddresses[Index_waveInGetPosition](); }
void WINAPI Export_waveInMessage() { ApiAddresses[Index_waveInMessage](); }
void WINAPI Export_waveInOpen() { ApiAddresses[Index_waveInOpen](); }
void WINAPI Export_waveInPrepareHeader() { ApiAddresses[Index_waveInPrepareHeader](); }
void WINAPI Export_waveInReset() { ApiAddresses[Index_waveInReset](); }
void WINAPI Export_waveInStart() { ApiAddresses[Index_waveInStart](); }
void WINAPI Export_waveInStop() { ApiAddresses[Index_waveInStop](); }
void WINAPI Export_waveInUnprepareHeader() { ApiAddresses[Index_waveInUnprepareHeader](); }
void WINAPI Export_waveOutBreakLoop() { ApiAddresses[Index_waveOutBreakLoop](); }
void WINAPI Export_waveOutClose() { ApiAddresses[Index_waveOutClose](); }
void WINAPI Export_waveOutGetDevCapsA() { ApiAddresses[Index_waveOutGetDevCapsA](); }
void WINAPI Export_waveOutGetDevCapsW() { ApiAddresses[Index_waveOutGetDevCapsW](); }
void WINAPI Export_waveOutGetErrorTextA() { ApiAddresses[Index_waveOutGetErrorTextA](); }
void WINAPI Export_waveOutGetErrorTextW() { ApiAddresses[Index_waveOutGetErrorTextW](); }
void WINAPI Export_waveOutGetID() { ApiAddresses[Index_waveOutGetID](); }
void WINAPI Export_waveOutGetNumDevs() { ApiAddresses[Index_waveOutGetNumDevs](); }
void WINAPI Export_waveOutGetPitch() { ApiAddresses[Index_waveOutGetPitch](); }
void WINAPI Export_waveOutGetPlaybackRate() { ApiAddresses[Index_waveOutGetPlaybackRate](); }
void WINAPI Export_waveOutGetPosition() { ApiAddresses[Index_waveOutGetPosition](); }
void WINAPI Export_waveOutGetVolume() { ApiAddresses[Index_waveOutGetVolume](); }
void WINAPI Export_waveOutMessage() { ApiAddresses[Index_waveOutMessage](); }
void WINAPI Export_waveOutOpen() { ApiAddresses[Index_waveOutOpen](); }
void WINAPI Export_waveOutPause() { ApiAddresses[Index_waveOutPause](); }
void WINAPI Export_waveOutPrepareHeader() { ApiAddresses[Index_waveOutPrepareHeader](); }
void WINAPI Export_waveOutReset() { ApiAddresses[Index_waveOutReset](); }
void WINAPI Export_waveOutRestart() { ApiAddresses[Index_waveOutRestart](); }
void WINAPI Export_waveOutSetPitch() { ApiAddresses[Index_waveOutSetPitch](); }
void WINAPI Export_waveOutSetPlaybackRate() { ApiAddresses[Index_waveOutSetPlaybackRate](); }
void WINAPI Export_waveOutSetVolume() { ApiAddresses[Index_waveOutSetVolume](); }
void WINAPI Export_waveOutUnprepareHeader() { ApiAddresses[Index_waveOutUnprepareHeader](); }
void WINAPI Export_waveOutWrite() { ApiAddresses[Index_waveOutWrite](); }
