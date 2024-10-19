#pragma once
#include <windows.h>
#include <Shlwapi.h> 

#pragma region Api Const

#define Index_CloseDriver 0
#define Index_DefDriverProc 1
#define Index_DllCanUnloadNow 2
#define Index_DllGetClassObject 3
#define Index_DllRegisterServer 4
#define Index_DllUnregisterServer 5
#define Index_DriverCallback 6
#define Index_DrvClose 7
#define Index_DrvDefDriverProc 8
#define Index_DrvGetModuleHandle 9
#define Index_DrvOpen 10
#define Index_DrvOpenA 11
#define Index_DrvSendMessage 12
#define Index_GetDriverFlags 13
#define Index_GetDriverModuleHandle 14
#define Index_GetFileVersionInfoA 15
#define Index_GetFileVersionInfoExA 16
#define Index_GetFileVersionInfoExW 17
#define Index_GetFileVersionInfoSizeA 18
#define Index_GetFileVersionInfoSizeExA 19
#define Index_GetFileVersionInfoSizeExW 20
#define Index_GetFileVersionInfoSizeW 21
#define Index_GetFileVersionInfoW 22
#define Index_OpenDriver 23
#define Index_OpenDriverA 24
#define Index_PlaySound 25
#define Index_PlaySoundA 26
#define Index_PlaySoundW 27
#define Index_SendDriverMessage 28
#define Index_VerFindFileA 29
#define Index_VerFindFileW 30
#define Index_VerInstallFileA 31
#define Index_VerInstallFileW 32
#define Index_VerLanguageNameA 33
#define Index_VerLanguageNameW 34
#define Index_VerQueryValueA 35
#define Index_VerQueryValueW 36
#define Index_WinHttpAddRequestHeaders 37
#define Index_WinHttpCheckPlatform 38
#define Index_WinHttpCloseHandle 39
#define Index_WinHttpConnect 40
#define Index_WinHttpCrackUrl 41
#define Index_WinHttpCreateProxyResolver 42
#define Index_WinHttpCreateUrl 43
#define Index_WinHttpDetectAutoProxyConfigUrl 44
#define Index_WinHttpFreeProxyResult 45
#define Index_WinHttpFreeProxyResultEx 46
#define Index_WinHttpFreeProxySettings 47
#define Index_WinHttpGetDefaultProxyConfiguration 48
#define Index_WinHttpGetIEProxyConfigForCurrentUser 49
#define Index_WinHttpGetProxyForUrl 50
#define Index_WinHttpGetProxyForUrlEx 51
#define Index_WinHttpGetProxyForUrlEx2 52
#define Index_WinHttpGetProxyResult 53
#define Index_WinHttpGetProxyResultEx 54
#define Index_WinHttpGetProxySettingsVersion 55
#define Index_WinHttpOpen 56
#define Index_WinHttpOpenRequest 57
#define Index_WinHttpQueryAuthSchemes 58
#define Index_WinHttpQueryDataAvailable 59
#define Index_WinHttpQueryHeaders 60
#define Index_WinHttpQueryOption 61
#define Index_WinHttpReadData 62
#define Index_WinHttpReadProxySettings 63
#define Index_WinHttpReceiveResponse 64
#define Index_WinHttpResetAutoProxy 65
#define Index_WinHttpSendRequest 66
#define Index_WinHttpSetCredentials 67
#define Index_WinHttpSetDefaultProxyConfiguration 68
#define Index_WinHttpSetOption 69
#define Index_WinHttpSetStatusCallback 70
#define Index_WinHttpSetTimeouts 71
#define Index_WinHttpTimeFromSystemTime 72
#define Index_WinHttpTimeToSystemTime 73
#define Index_WinHttpWebSocketClose 74
#define Index_WinHttpWebSocketCompleteUpgrade 75
#define Index_WinHttpWebSocketQueryCloseStatus 76
#define Index_WinHttpWebSocketReceive 77
#define Index_WinHttpWebSocketSend 78
#define Index_WinHttpWebSocketShutdown 79
#define Index_WinHttpWriteData 80
#define Index_WinHttpWriteProxySettings 81
#define Index_auxGetDevCapsA 82
#define Index_auxGetDevCapsW 83
#define Index_auxGetNumDevs 84
#define Index_auxGetVolume 85
#define Index_auxOutMessage 86
#define Index_auxSetVolume 87
#define Index_joyConfigChanged 88
#define Index_joyGetDevCapsA 89
#define Index_joyGetDevCapsW 90
#define Index_joyGetNumDevs 91
#define Index_joyGetPos 92
#define Index_joyGetPosEx 93
#define Index_joyGetThreshold 94
#define Index_joyReleaseCapture 95
#define Index_joySetCapture 96
#define Index_joySetThreshold 97
#define Index_mciDriverNotify 98
#define Index_mciDriverYield 99
#define Index_mciExecute 100
#define Index_mciFreeCommandResource 101
#define Index_mciGetCreatorTask 102
#define Index_mciGetDeviceIDA 103
#define Index_mciGetDeviceIDFromElementIDA 104
#define Index_mciGetDeviceIDFromElementIDW 105
#define Index_mciGetDeviceIDW 106
#define Index_mciGetDriverData 107
#define Index_mciGetErrorStringA 108
#define Index_mciGetErrorStringW 109
#define Index_mciGetYieldProc 110
#define Index_mciLoadCommandResource 111
#define Index_mciSendCommandA 112
#define Index_mciSendCommandW 113
#define Index_mciSendStringA 114
#define Index_mciSendStringW 115
#define Index_mciSetDriverData 116
#define Index_mciSetYieldProc 117
#define Index_midiConnect 118
#define Index_midiDisconnect 119
#define Index_midiInAddBuffer 120
#define Index_midiInClose 121
#define Index_midiInGetDevCapsA 122
#define Index_midiInGetDevCapsW 123
#define Index_midiInGetErrorTextA 124
#define Index_midiInGetErrorTextW 125
#define Index_midiInGetID 126
#define Index_midiInGetNumDevs 127
#define Index_midiInMessage 128
#define Index_midiInOpen 129
#define Index_midiInPrepareHeader 130
#define Index_midiInReset 131
#define Index_midiInStart 132
#define Index_midiInStop 133
#define Index_midiInUnprepareHeader 134
#define Index_midiOutCacheDrumPatches 135
#define Index_midiOutCachePatches 136
#define Index_midiOutClose 137
#define Index_midiOutGetDevCapsA 138
#define Index_midiOutGetDevCapsW 139
#define Index_midiOutGetErrorTextA 140
#define Index_midiOutGetErrorTextW 141
#define Index_midiOutGetID 142
#define Index_midiOutGetNumDevs 143
#define Index_midiOutGetVolume 144
#define Index_midiOutLongMsg 145
#define Index_midiOutMessage 146
#define Index_midiOutOpen 147
#define Index_midiOutPrepareHeader 148
#define Index_midiOutReset 149
#define Index_midiOutSetVolume 150
#define Index_midiOutShortMsg 151
#define Index_midiOutUnprepareHeader 152
#define Index_midiStreamClose 153
#define Index_midiStreamOpen 154
#define Index_midiStreamOut 155
#define Index_midiStreamPause 156
#define Index_midiStreamPosition 157
#define Index_midiStreamProperty 158
#define Index_midiStreamRestart 159
#define Index_midiStreamStop 160
#define Index_mixerClose 161
#define Index_mixerGetControlDetailsA 162
#define Index_mixerGetControlDetailsW 163
#define Index_mixerGetDevCapsA 164
#define Index_mixerGetDevCapsW 165
#define Index_mixerGetID 166
#define Index_mixerGetLineControlsA 167
#define Index_mixerGetLineControlsW 168
#define Index_mixerGetLineInfoA 169
#define Index_mixerGetLineInfoW 170
#define Index_mixerGetNumDevs 171
#define Index_mixerMessage 172
#define Index_mixerOpen 173
#define Index_mixerSetControlDetails 174
#define Index_mmGetCurrentTask 175
#define Index_mmTaskBlock 176
#define Index_mmTaskCreate 177
#define Index_mmTaskSignal 178
#define Index_mmTaskYield 179
#define Index_mmioAdvance 180
#define Index_mmioAscend 181
#define Index_mmioClose 182
#define Index_mmioCreateChunk 183
#define Index_mmioDescend 184
#define Index_mmioFlush 185
#define Index_mmioGetInfo 186
#define Index_mmioInstallIOProc16 187
#define Index_mmioInstallIOProcA 188
#define Index_mmioInstallIOProcW 189
#define Index_mmioOpenA 190
#define Index_mmioOpenW 191
#define Index_mmioRead 192
#define Index_mmioRenameA 193
#define Index_mmioRenameW 194
#define Index_mmioSeek 195
#define Index_mmioSendMessage 196
#define Index_mmioSetBuffer 197
#define Index_mmioSetInfo 198
#define Index_mmioStringToFOURCCA 199
#define Index_mmioStringToFOURCCW 200
#define Index_mmioWrite 201
#define Index_mmsystemGetVersion 202
#define Index_sndPlaySoundA 203
#define Index_sndPlaySoundW 204
#define Index_timeBeginPeriod 205
#define Index_timeEndPeriod 206
#define Index_timeGetDevCaps 207
#define Index_timeGetSystemTime 208
#define Index_timeGetTime 209
#define Index_timeKillEvent 210
#define Index_timeSetEvent 211
#define Index_waveInAddBuffer 212
#define Index_waveInClose 213
#define Index_waveInGetDevCapsA 214
#define Index_waveInGetDevCapsW 215
#define Index_waveInGetErrorTextA 216
#define Index_waveInGetErrorTextW 217
#define Index_waveInGetID 218
#define Index_waveInGetNumDevs 219
#define Index_waveInGetPosition 220
#define Index_waveInMessage 221
#define Index_waveInOpen 222
#define Index_waveInPrepareHeader 223
#define Index_waveInReset 224
#define Index_waveInStart 225
#define Index_waveInStop 226
#define Index_waveInUnprepareHeader 227
#define Index_waveOutBreakLoop 228
#define Index_waveOutClose 229
#define Index_waveOutGetDevCapsA 230
#define Index_waveOutGetDevCapsW 231
#define Index_waveOutGetErrorTextA 232
#define Index_waveOutGetErrorTextW 233
#define Index_waveOutGetID 234
#define Index_waveOutGetNumDevs 235
#define Index_waveOutGetPitch 236
#define Index_waveOutGetPlaybackRate 237
#define Index_waveOutGetPosition 238
#define Index_waveOutGetVolume 239
#define Index_waveOutMessage 240
#define Index_waveOutOpen 241
#define Index_waveOutPause 242
#define Index_waveOutPrepareHeader 243
#define Index_waveOutReset 244
#define Index_waveOutRestart 245
#define Index_waveOutSetPitch 246
#define Index_waveOutSetPlaybackRate 247
#define Index_waveOutSetVolume 248
#define Index_waveOutUnprepareHeader 249
#define Index_waveOutWrite 250
#define Index_MaxSize 251

#define ApiName_CloseDriver  "CloseDriver"
#define ApiName_DefDriverProc  "DefDriverProc"
#define ApiName_DllCanUnloadNow  "DllCanUnloadNow"
#define ApiName_DllGetClassObject  "DllGetClassObject"
#define ApiName_DllRegisterServer  "DllRegisterServer"
#define ApiName_DllUnregisterServer  "DllUnregisterServer"
#define ApiName_DriverCallback  "DriverCallback"
#define ApiName_DrvClose  "DrvClose"
#define ApiName_DrvDefDriverProc  "DrvDefDriverProc"
#define ApiName_DrvGetModuleHandle  "DrvGetModuleHandle"
#define ApiName_DrvOpen  "DrvOpen"
#define ApiName_DrvOpenA  "DrvOpenA"
#define ApiName_DrvSendMessage  "DrvSendMessage"
#define ApiName_GetDriverFlags  "GetDriverFlags"
#define ApiName_GetDriverModuleHandle  "GetDriverModuleHandle"
#define ApiName_GetFileVersionInfoA  "GetFileVersionInfoA"
#define ApiName_GetFileVersionInfoExA  "GetFileVersionInfoExA"
#define ApiName_GetFileVersionInfoExW  "GetFileVersionInfoExW"
#define ApiName_GetFileVersionInfoSizeA  "GetFileVersionInfoSizeA"
#define ApiName_GetFileVersionInfoSizeExA  "GetFileVersionInfoSizeExA"
#define ApiName_GetFileVersionInfoSizeExW  "GetFileVersionInfoSizeExW"
#define ApiName_GetFileVersionInfoSizeW  "GetFileVersionInfoSizeW"
#define ApiName_GetFileVersionInfoW  "GetFileVersionInfoW"
#define ApiName_OpenDriver  "OpenDriver"
#define ApiName_OpenDriverA  "OpenDriverA"
#define ApiName_PlaySound  "PlaySound"
#define ApiName_PlaySoundA  "PlaySoundA"
#define ApiName_PlaySoundW  "PlaySoundW"
#define ApiName_SendDriverMessage  "SendDriverMessage"
#define ApiName_VerFindFileA  "VerFindFileA"
#define ApiName_VerFindFileW  "VerFindFileW"
#define ApiName_VerInstallFileA  "VerInstallFileA"
#define ApiName_VerInstallFileW  "VerInstallFileW"
#define ApiName_VerLanguageNameA  "VerLanguageNameA"
#define ApiName_VerLanguageNameW  "VerLanguageNameW"
#define ApiName_VerQueryValueA  "VerQueryValueA"
#define ApiName_VerQueryValueW  "VerQueryValueW"
#define ApiName_WinHttpAddRequestHeaders  "WinHttpAddRequestHeaders"
#define ApiName_WinHttpCheckPlatform  "WinHttpCheckPlatform"
#define ApiName_WinHttpCloseHandle  "WinHttpCloseHandle"
#define ApiName_WinHttpConnect  "WinHttpConnect"
#define ApiName_WinHttpCrackUrl  "WinHttpCrackUrl"
#define ApiName_WinHttpCreateProxyResolver  "WinHttpCreateProxyResolver"
#define ApiName_WinHttpCreateUrl  "WinHttpCreateUrl"
#define ApiName_WinHttpDetectAutoProxyConfigUrl  "WinHttpDetectAutoProxyConfigUrl"
#define ApiName_WinHttpFreeProxyResult  "WinHttpFreeProxyResult"
#define ApiName_WinHttpFreeProxyResultEx  "WinHttpFreeProxyResultEx"
#define ApiName_WinHttpFreeProxySettings  "WinHttpFreeProxySettings"
#define ApiName_WinHttpGetDefaultProxyConfiguration  "WinHttpGetDefaultProxyConfiguration"
#define ApiName_WinHttpGetIEProxyConfigForCurrentUser  "WinHttpGetIEProxyConfigForCurrentUser"
#define ApiName_WinHttpGetProxyForUrl  "WinHttpGetProxyForUrl"
#define ApiName_WinHttpGetProxyForUrlEx  "WinHttpGetProxyForUrlEx"
#define ApiName_WinHttpGetProxyForUrlEx2  "WinHttpGetProxyForUrlEx2"
#define ApiName_WinHttpGetProxyResult  "WinHttpGetProxyResult"
#define ApiName_WinHttpGetProxyResultEx  "WinHttpGetProxyResultEx"
#define ApiName_WinHttpGetProxySettingsVersion  "WinHttpGetProxySettingsVersion"
#define ApiName_WinHttpOpen  "WinHttpOpen"
#define ApiName_WinHttpOpenRequest  "WinHttpOpenRequest"
#define ApiName_WinHttpQueryAuthSchemes  "WinHttpQueryAuthSchemes"
#define ApiName_WinHttpQueryDataAvailable  "WinHttpQueryDataAvailable"
#define ApiName_WinHttpQueryHeaders  "WinHttpQueryHeaders"
#define ApiName_WinHttpQueryOption  "WinHttpQueryOption"
#define ApiName_WinHttpReadData  "WinHttpReadData"
#define ApiName_WinHttpReadProxySettings  "WinHttpReadProxySettings"
#define ApiName_WinHttpReceiveResponse  "WinHttpReceiveResponse"
#define ApiName_WinHttpResetAutoProxy  "WinHttpResetAutoProxy"
#define ApiName_WinHttpSendRequest  "WinHttpSendRequest"
#define ApiName_WinHttpSetCredentials  "WinHttpSetCredentials"
#define ApiName_WinHttpSetDefaultProxyConfiguration  "WinHttpSetDefaultProxyConfiguration"
#define ApiName_WinHttpSetOption  "WinHttpSetOption"
#define ApiName_WinHttpSetStatusCallback  "WinHttpSetStatusCallback"
#define ApiName_WinHttpSetTimeouts  "WinHttpSetTimeouts"
#define ApiName_WinHttpTimeFromSystemTime  "WinHttpTimeFromSystemTime"
#define ApiName_WinHttpTimeToSystemTime  "WinHttpTimeToSystemTime"
#define ApiName_WinHttpWebSocketClose  "WinHttpWebSocketClose"
#define ApiName_WinHttpWebSocketCompleteUpgrade  "WinHttpWebSocketCompleteUpgrade"
#define ApiName_WinHttpWebSocketQueryCloseStatus  "WinHttpWebSocketQueryCloseStatus"
#define ApiName_WinHttpWebSocketReceive  "WinHttpWebSocketReceive"
#define ApiName_WinHttpWebSocketSend  "WinHttpWebSocketSend"
#define ApiName_WinHttpWebSocketShutdown  "WinHttpWebSocketShutdown"
#define ApiName_WinHttpWriteData  "WinHttpWriteData"
#define ApiName_WinHttpWriteProxySettings  "WinHttpWriteProxySettings"
#define ApiName_auxGetDevCapsA  "auxGetDevCapsA"
#define ApiName_auxGetDevCapsW  "auxGetDevCapsW"
#define ApiName_auxGetNumDevs  "auxGetNumDevs"
#define ApiName_auxGetVolume  "auxGetVolume"
#define ApiName_auxOutMessage  "auxOutMessage"
#define ApiName_auxSetVolume  "auxSetVolume"
#define ApiName_joyConfigChanged  "joyConfigChanged"
#define ApiName_joyGetDevCapsA  "joyGetDevCapsA"
#define ApiName_joyGetDevCapsW  "joyGetDevCapsW"
#define ApiName_joyGetNumDevs  "joyGetNumDevs"
#define ApiName_joyGetPos  "joyGetPos"
#define ApiName_joyGetPosEx  "joyGetPosEx"
#define ApiName_joyGetThreshold  "joyGetThreshold"
#define ApiName_joyReleaseCapture  "joyReleaseCapture"
#define ApiName_joySetCapture  "joySetCapture"
#define ApiName_joySetThreshold  "joySetThreshold"
#define ApiName_mciDriverNotify  "mciDriverNotify"
#define ApiName_mciDriverYield  "mciDriverYield"
#define ApiName_mciExecute  "mciExecute"
#define ApiName_mciFreeCommandResource  "mciFreeCommandResource"
#define ApiName_mciGetCreatorTask  "mciGetCreatorTask"
#define ApiName_mciGetDeviceIDA  "mciGetDeviceIDA"
#define ApiName_mciGetDeviceIDFromElementIDA  "mciGetDeviceIDFromElementIDA"
#define ApiName_mciGetDeviceIDFromElementIDW  "mciGetDeviceIDFromElementIDW"
#define ApiName_mciGetDeviceIDW  "mciGetDeviceIDW"
#define ApiName_mciGetDriverData  "mciGetDriverData"
#define ApiName_mciGetErrorStringA  "mciGetErrorStringA"
#define ApiName_mciGetErrorStringW  "mciGetErrorStringW"
#define ApiName_mciGetYieldProc  "mciGetYieldProc"
#define ApiName_mciLoadCommandResource  "mciLoadCommandResource"
#define ApiName_mciSendCommandA  "mciSendCommandA"
#define ApiName_mciSendCommandW  "mciSendCommandW"
#define ApiName_mciSendStringA  "mciSendStringA"
#define ApiName_mciSendStringW  "mciSendStringW"
#define ApiName_mciSetDriverData  "mciSetDriverData"
#define ApiName_mciSetYieldProc  "mciSetYieldProc"
#define ApiName_midiConnect  "midiConnect"
#define ApiName_midiDisconnect  "midiDisconnect"
#define ApiName_midiInAddBuffer  "midiInAddBuffer"
#define ApiName_midiInClose  "midiInClose"
#define ApiName_midiInGetDevCapsA  "midiInGetDevCapsA"
#define ApiName_midiInGetDevCapsW  "midiInGetDevCapsW"
#define ApiName_midiInGetErrorTextA  "midiInGetErrorTextA"
#define ApiName_midiInGetErrorTextW  "midiInGetErrorTextW"
#define ApiName_midiInGetID  "midiInGetID"
#define ApiName_midiInGetNumDevs  "midiInGetNumDevs"
#define ApiName_midiInMessage  "midiInMessage"
#define ApiName_midiInOpen  "midiInOpen"
#define ApiName_midiInPrepareHeader  "midiInPrepareHeader"
#define ApiName_midiInReset  "midiInReset"
#define ApiName_midiInStart  "midiInStart"
#define ApiName_midiInStop  "midiInStop"
#define ApiName_midiInUnprepareHeader  "midiInUnprepareHeader"
#define ApiName_midiOutCacheDrumPatches  "midiOutCacheDrumPatches"
#define ApiName_midiOutCachePatches  "midiOutCachePatches"
#define ApiName_midiOutClose  "midiOutClose"
#define ApiName_midiOutGetDevCapsA  "midiOutGetDevCapsA"
#define ApiName_midiOutGetDevCapsW  "midiOutGetDevCapsW"
#define ApiName_midiOutGetErrorTextA  "midiOutGetErrorTextA"
#define ApiName_midiOutGetErrorTextW  "midiOutGetErrorTextW"
#define ApiName_midiOutGetID  "midiOutGetID"
#define ApiName_midiOutGetNumDevs  "midiOutGetNumDevs"
#define ApiName_midiOutGetVolume  "midiOutGetVolume"
#define ApiName_midiOutLongMsg  "midiOutLongMsg"
#define ApiName_midiOutMessage  "midiOutMessage"
#define ApiName_midiOutOpen  "midiOutOpen"
#define ApiName_midiOutPrepareHeader  "midiOutPrepareHeader"
#define ApiName_midiOutReset  "midiOutReset"
#define ApiName_midiOutSetVolume  "midiOutSetVolume"
#define ApiName_midiOutShortMsg  "midiOutShortMsg"
#define ApiName_midiOutUnprepareHeader  "midiOutUnprepareHeader"
#define ApiName_midiStreamClose  "midiStreamClose"
#define ApiName_midiStreamOpen  "midiStreamOpen"
#define ApiName_midiStreamOut  "midiStreamOut"
#define ApiName_midiStreamPause  "midiStreamPause"
#define ApiName_midiStreamPosition  "midiStreamPosition"
#define ApiName_midiStreamProperty  "midiStreamProperty"
#define ApiName_midiStreamRestart  "midiStreamRestart"
#define ApiName_midiStreamStop  "midiStreamStop"
#define ApiName_mixerClose  "mixerClose"
#define ApiName_mixerGetControlDetailsA  "mixerGetControlDetailsA"
#define ApiName_mixerGetControlDetailsW  "mixerGetControlDetailsW"
#define ApiName_mixerGetDevCapsA  "mixerGetDevCapsA"
#define ApiName_mixerGetDevCapsW  "mixerGetDevCapsW"
#define ApiName_mixerGetID  "mixerGetID"
#define ApiName_mixerGetLineControlsA  "mixerGetLineControlsA"
#define ApiName_mixerGetLineControlsW  "mixerGetLineControlsW"
#define ApiName_mixerGetLineInfoA  "mixerGetLineInfoA"
#define ApiName_mixerGetLineInfoW  "mixerGetLineInfoW"
#define ApiName_mixerGetNumDevs  "mixerGetNumDevs"
#define ApiName_mixerMessage  "mixerMessage"
#define ApiName_mixerOpen  "mixerOpen"
#define ApiName_mixerSetControlDetails  "mixerSetControlDetails"
#define ApiName_mmGetCurrentTask  "mmGetCurrentTask"
#define ApiName_mmTaskBlock  "mmTaskBlock"
#define ApiName_mmTaskCreate  "mmTaskCreate"
#define ApiName_mmTaskSignal  "mmTaskSignal"
#define ApiName_mmTaskYield  "mmTaskYield"
#define ApiName_mmioAdvance  "mmioAdvance"
#define ApiName_mmioAscend  "mmioAscend"
#define ApiName_mmioClose  "mmioClose"
#define ApiName_mmioCreateChunk  "mmioCreateChunk"
#define ApiName_mmioDescend  "mmioDescend"
#define ApiName_mmioFlush  "mmioFlush"
#define ApiName_mmioGetInfo  "mmioGetInfo"
#define ApiName_mmioInstallIOProc16  "mmioInstallIOProc16"
#define ApiName_mmioInstallIOProcA  "mmioInstallIOProcA"
#define ApiName_mmioInstallIOProcW  "mmioInstallIOProcW"
#define ApiName_mmioOpenA  "mmioOpenA"
#define ApiName_mmioOpenW  "mmioOpenW"
#define ApiName_mmioRead  "mmioRead"
#define ApiName_mmioRenameA  "mmioRenameA"
#define ApiName_mmioRenameW  "mmioRenameW"
#define ApiName_mmioSeek  "mmioSeek"
#define ApiName_mmioSendMessage  "mmioSendMessage"
#define ApiName_mmioSetBuffer  "mmioSetBuffer"
#define ApiName_mmioSetInfo  "mmioSetInfo"
#define ApiName_mmioStringToFOURCCA  "mmioStringToFOURCCA"
#define ApiName_mmioStringToFOURCCW  "mmioStringToFOURCCW"
#define ApiName_mmioWrite  "mmioWrite"
#define ApiName_mmsystemGetVersion  "mmsystemGetVersion"
#define ApiName_sndPlaySoundA  "sndPlaySoundA"
#define ApiName_sndPlaySoundW  "sndPlaySoundW"
#define ApiName_timeBeginPeriod  "timeBeginPeriod"
#define ApiName_timeEndPeriod  "timeEndPeriod"
#define ApiName_timeGetDevCaps  "timeGetDevCaps"
#define ApiName_timeGetSystemTime  "timeGetSystemTime"
#define ApiName_timeGetTime  "timeGetTime"
#define ApiName_timeKillEvent  "timeKillEvent"
#define ApiName_timeSetEvent  "timeSetEvent"
#define ApiName_waveInAddBuffer  "waveInAddBuffer"
#define ApiName_waveInClose  "waveInClose"
#define ApiName_waveInGetDevCapsA  "waveInGetDevCapsA"
#define ApiName_waveInGetDevCapsW  "waveInGetDevCapsW"
#define ApiName_waveInGetErrorTextA  "waveInGetErrorTextA"
#define ApiName_waveInGetErrorTextW  "waveInGetErrorTextW"
#define ApiName_waveInGetID  "waveInGetID"
#define ApiName_waveInGetNumDevs  "waveInGetNumDevs"
#define ApiName_waveInGetPosition  "waveInGetPosition"
#define ApiName_waveInMessage  "waveInMessage"
#define ApiName_waveInOpen  "waveInOpen"
#define ApiName_waveInPrepareHeader  "waveInPrepareHeader"
#define ApiName_waveInReset  "waveInReset"
#define ApiName_waveInStart  "waveInStart"
#define ApiName_waveInStop  "waveInStop"
#define ApiName_waveInUnprepareHeader  "waveInUnprepareHeader"
#define ApiName_waveOutBreakLoop  "waveOutBreakLoop"
#define ApiName_waveOutClose  "waveOutClose"
#define ApiName_waveOutGetDevCapsA  "waveOutGetDevCapsA"
#define ApiName_waveOutGetDevCapsW  "waveOutGetDevCapsW"
#define ApiName_waveOutGetErrorTextA  "waveOutGetErrorTextA"
#define ApiName_waveOutGetErrorTextW  "waveOutGetErrorTextW"
#define ApiName_waveOutGetID  "waveOutGetID"
#define ApiName_waveOutGetNumDevs  "waveOutGetNumDevs"
#define ApiName_waveOutGetPitch  "waveOutGetPitch"
#define ApiName_waveOutGetPlaybackRate  "waveOutGetPlaybackRate"
#define ApiName_waveOutGetPosition  "waveOutGetPosition"
#define ApiName_waveOutGetVolume  "waveOutGetVolume"
#define ApiName_waveOutMessage  "waveOutMessage"
#define ApiName_waveOutOpen  "waveOutOpen"
#define ApiName_waveOutPause  "waveOutPause"
#define ApiName_waveOutPrepareHeader  "waveOutPrepareHeader"
#define ApiName_waveOutReset  "waveOutReset"
#define ApiName_waveOutRestart  "waveOutRestart"
#define ApiName_waveOutSetPitch  "waveOutSetPitch"
#define ApiName_waveOutSetPlaybackRate  "waveOutSetPlaybackRate"
#define ApiName_waveOutSetVolume  "waveOutSetVolume"
#define ApiName_waveOutUnprepareHeader  "waveOutUnprepareHeader"
#define ApiName_waveOutWrite  "waveOutWrite"


#pragma endregion

#pragma region ApiNames

LPCSTR ApiNames[Index_MaxSize] =
{
ApiName_CloseDriver,
ApiName_DefDriverProc,
ApiName_DllCanUnloadNow,
ApiName_DllGetClassObject,
ApiName_DllRegisterServer,
ApiName_DllUnregisterServer,
ApiName_DriverCallback,
ApiName_DrvClose,
ApiName_DrvDefDriverProc,
ApiName_DrvGetModuleHandle,
ApiName_DrvOpen,
ApiName_DrvOpenA,
ApiName_DrvSendMessage,
ApiName_GetDriverFlags,
ApiName_GetDriverModuleHandle,
ApiName_GetFileVersionInfoA,
ApiName_GetFileVersionInfoExA,
ApiName_GetFileVersionInfoExW,
ApiName_GetFileVersionInfoSizeA,
ApiName_GetFileVersionInfoSizeExA,
ApiName_GetFileVersionInfoSizeExW,
ApiName_GetFileVersionInfoSizeW,
ApiName_GetFileVersionInfoW,
ApiName_OpenDriver,
ApiName_OpenDriverA,
ApiName_PlaySound,
ApiName_PlaySoundA,
ApiName_PlaySoundW,
ApiName_SendDriverMessage,
ApiName_VerFindFileA,
ApiName_VerFindFileW,
ApiName_VerInstallFileA,
ApiName_VerInstallFileW,
ApiName_VerLanguageNameA,
ApiName_VerLanguageNameW,
ApiName_VerQueryValueA,
ApiName_VerQueryValueW,
ApiName_WinHttpAddRequestHeaders,
ApiName_WinHttpCheckPlatform,
ApiName_WinHttpCloseHandle,
ApiName_WinHttpConnect,
ApiName_WinHttpCrackUrl,
ApiName_WinHttpCreateProxyResolver,
ApiName_WinHttpCreateUrl,
ApiName_WinHttpDetectAutoProxyConfigUrl,
ApiName_WinHttpFreeProxyResult,
ApiName_WinHttpFreeProxyResultEx,
ApiName_WinHttpFreeProxySettings,
ApiName_WinHttpGetDefaultProxyConfiguration,
ApiName_WinHttpGetIEProxyConfigForCurrentUser,
ApiName_WinHttpGetProxyForUrl,
ApiName_WinHttpGetProxyForUrlEx,
ApiName_WinHttpGetProxyForUrlEx2,
ApiName_WinHttpGetProxyResult,
ApiName_WinHttpGetProxyResultEx,
ApiName_WinHttpGetProxySettingsVersion,
ApiName_WinHttpOpen,
ApiName_WinHttpOpenRequest,
ApiName_WinHttpQueryAuthSchemes,
ApiName_WinHttpQueryDataAvailable,
ApiName_WinHttpQueryHeaders,
ApiName_WinHttpQueryOption,
ApiName_WinHttpReadData,
ApiName_WinHttpReadProxySettings,
ApiName_WinHttpReceiveResponse,
ApiName_WinHttpResetAutoProxy,
ApiName_WinHttpSendRequest,
ApiName_WinHttpSetCredentials,
ApiName_WinHttpSetDefaultProxyConfiguration,
ApiName_WinHttpSetOption,
ApiName_WinHttpSetStatusCallback,
ApiName_WinHttpSetTimeouts,
ApiName_WinHttpTimeFromSystemTime,
ApiName_WinHttpTimeToSystemTime,
ApiName_WinHttpWebSocketClose,
ApiName_WinHttpWebSocketCompleteUpgrade,
ApiName_WinHttpWebSocketQueryCloseStatus,
ApiName_WinHttpWebSocketReceive,
ApiName_WinHttpWebSocketSend,
ApiName_WinHttpWebSocketShutdown,
ApiName_WinHttpWriteData,
ApiName_WinHttpWriteProxySettings,
ApiName_auxGetDevCapsA,
ApiName_auxGetDevCapsW,
ApiName_auxGetNumDevs,
ApiName_auxGetVolume,
ApiName_auxOutMessage,
ApiName_auxSetVolume,
ApiName_joyConfigChanged,
ApiName_joyGetDevCapsA,
ApiName_joyGetDevCapsW,
ApiName_joyGetNumDevs,
ApiName_joyGetPos,
ApiName_joyGetPosEx,
ApiName_joyGetThreshold,
ApiName_joyReleaseCapture,
ApiName_joySetCapture,
ApiName_joySetThreshold,
ApiName_mciDriverNotify,
ApiName_mciDriverYield,
ApiName_mciExecute,
ApiName_mciFreeCommandResource,
ApiName_mciGetCreatorTask,
ApiName_mciGetDeviceIDA,
ApiName_mciGetDeviceIDFromElementIDA,
ApiName_mciGetDeviceIDFromElementIDW,
ApiName_mciGetDeviceIDW,
ApiName_mciGetDriverData,
ApiName_mciGetErrorStringA,
ApiName_mciGetErrorStringW,
ApiName_mciGetYieldProc,
ApiName_mciLoadCommandResource,
ApiName_mciSendCommandA,
ApiName_mciSendCommandW,
ApiName_mciSendStringA,
ApiName_mciSendStringW,
ApiName_mciSetDriverData,
ApiName_mciSetYieldProc,
ApiName_midiConnect,
ApiName_midiDisconnect,
ApiName_midiInAddBuffer,
ApiName_midiInClose,
ApiName_midiInGetDevCapsA,
ApiName_midiInGetDevCapsW,
ApiName_midiInGetErrorTextA,
ApiName_midiInGetErrorTextW,
ApiName_midiInGetID,
ApiName_midiInGetNumDevs,
ApiName_midiInMessage,
ApiName_midiInOpen,
ApiName_midiInPrepareHeader,
ApiName_midiInReset,
ApiName_midiInStart,
ApiName_midiInStop,
ApiName_midiInUnprepareHeader,
ApiName_midiOutCacheDrumPatches,
ApiName_midiOutCachePatches,
ApiName_midiOutClose,
ApiName_midiOutGetDevCapsA,
ApiName_midiOutGetDevCapsW,
ApiName_midiOutGetErrorTextA,
ApiName_midiOutGetErrorTextW,
ApiName_midiOutGetID,
ApiName_midiOutGetNumDevs,
ApiName_midiOutGetVolume,
ApiName_midiOutLongMsg,
ApiName_midiOutMessage,
ApiName_midiOutOpen,
ApiName_midiOutPrepareHeader,
ApiName_midiOutReset,
ApiName_midiOutSetVolume,
ApiName_midiOutShortMsg,
ApiName_midiOutUnprepareHeader,
ApiName_midiStreamClose,
ApiName_midiStreamOpen,
ApiName_midiStreamOut,
ApiName_midiStreamPause,
ApiName_midiStreamPosition,
ApiName_midiStreamProperty,
ApiName_midiStreamRestart,
ApiName_midiStreamStop,
ApiName_mixerClose,
ApiName_mixerGetControlDetailsA,
ApiName_mixerGetControlDetailsW,
ApiName_mixerGetDevCapsA,
ApiName_mixerGetDevCapsW,
ApiName_mixerGetID,
ApiName_mixerGetLineControlsA,
ApiName_mixerGetLineControlsW,
ApiName_mixerGetLineInfoA,
ApiName_mixerGetLineInfoW,
ApiName_mixerGetNumDevs,
ApiName_mixerMessage,
ApiName_mixerOpen,
ApiName_mixerSetControlDetails,
ApiName_mmGetCurrentTask,
ApiName_mmTaskBlock,
ApiName_mmTaskCreate,
ApiName_mmTaskSignal,
ApiName_mmTaskYield,
ApiName_mmioAdvance,
ApiName_mmioAscend,
ApiName_mmioClose,
ApiName_mmioCreateChunk,
ApiName_mmioDescend,
ApiName_mmioFlush,
ApiName_mmioGetInfo,
ApiName_mmioInstallIOProc16,
ApiName_mmioInstallIOProcA,
ApiName_mmioInstallIOProcW,
ApiName_mmioOpenA,
ApiName_mmioOpenW,
ApiName_mmioRead,
ApiName_mmioRenameA,
ApiName_mmioRenameW,
ApiName_mmioSeek,
ApiName_mmioSendMessage,
ApiName_mmioSetBuffer,
ApiName_mmioSetInfo,
ApiName_mmioStringToFOURCCA,
ApiName_mmioStringToFOURCCW,
ApiName_mmioWrite,
ApiName_mmsystemGetVersion,
ApiName_sndPlaySoundA,
ApiName_sndPlaySoundW,
ApiName_timeBeginPeriod,
ApiName_timeEndPeriod,
ApiName_timeGetDevCaps,
ApiName_timeGetSystemTime,
ApiName_timeGetTime,
ApiName_timeKillEvent,
ApiName_timeSetEvent,
ApiName_waveInAddBuffer,
ApiName_waveInClose,
ApiName_waveInGetDevCapsA,
ApiName_waveInGetDevCapsW,
ApiName_waveInGetErrorTextA,
ApiName_waveInGetErrorTextW,
ApiName_waveInGetID,
ApiName_waveInGetNumDevs,
ApiName_waveInGetPosition,
ApiName_waveInMessage,
ApiName_waveInOpen,
ApiName_waveInPrepareHeader,
ApiName_waveInReset,
ApiName_waveInStart,
ApiName_waveInStop,
ApiName_waveInUnprepareHeader,
ApiName_waveOutBreakLoop,
ApiName_waveOutClose,
ApiName_waveOutGetDevCapsA,
ApiName_waveOutGetDevCapsW,
ApiName_waveOutGetErrorTextA,
ApiName_waveOutGetErrorTextW,
ApiName_waveOutGetID,
ApiName_waveOutGetNumDevs,
ApiName_waveOutGetPitch,
ApiName_waveOutGetPlaybackRate,
ApiName_waveOutGetPosition,
ApiName_waveOutGetVolume,
ApiName_waveOutMessage,
ApiName_waveOutOpen,
ApiName_waveOutPause,
ApiName_waveOutPrepareHeader,
ApiName_waveOutReset,
ApiName_waveOutRestart,
ApiName_waveOutSetPitch,
ApiName_waveOutSetPlaybackRate,
ApiName_waveOutSetVolume,
ApiName_waveOutUnprepareHeader,
ApiName_waveOutWrite,

};

#pragma endregion

#pragma region ApiAddresses
static FARPROC ApiAddresses[Index_MaxSize] =
{
	nullptr,
};
#pragma endregion

#pragma region Cache
wchar_t FileName[512] = { 0 };
wchar_t SysPath[512] = { 0 };
wchar_t FullPath[512] = { 0 };
#pragma endregion

#pragma region Funcs

HMODULE WINAPI LoadOriginalModule(HINSTANCE hInstance);
void WINAPI LoadFunctions(HMODULE hOriginal);
void WINAPI LoadProxy(HINSTANCE hInstance);
extern "C" BOOL WINAPI InitDllMain(HINSTANCE hModule, DWORD ul_reason_for_call, LPVOID lpReserved);
#pragma endregion

#pragma region Exports



////#pragma comment(linker, "/export:AddMaple=Add")
//extern "C"  int WINAPI Add(int a, int b);


#pragma comment(lib, "Shlwapi.lib")





extern "C" void WINAPI Export_CloseDriver();
extern "C" void WINAPI Export_DefDriverProc();
extern "C" void WINAPI Export_DllCanUnloadNow();
extern "C" void WINAPI Export_DllGetClassObject();
extern "C" void WINAPI Export_DllRegisterServer();
extern "C" void WINAPI Export_DllUnregisterServer();
extern "C" void WINAPI Export_DriverCallback();
extern "C" void WINAPI Export_DrvClose();
extern "C" void WINAPI Export_DrvDefDriverProc();
extern "C" void WINAPI Export_DrvGetModuleHandle();
extern "C" void WINAPI Export_DrvOpen();
extern "C" void WINAPI Export_DrvOpenA();
extern "C" void WINAPI Export_DrvSendMessage();
extern "C" void WINAPI Export_GetDriverFlags();
extern "C" void WINAPI Export_GetDriverModuleHandle();
extern "C" void WINAPI Export_GetFileVersionInfoA();
extern "C" void WINAPI Export_GetFileVersionInfoExA();
extern "C" void WINAPI Export_GetFileVersionInfoExW();
extern "C" void WINAPI Export_GetFileVersionInfoSizeA();
extern "C" void WINAPI Export_GetFileVersionInfoSizeExA();
extern "C" void WINAPI Export_GetFileVersionInfoSizeExW();
extern "C" void WINAPI Export_GetFileVersionInfoSizeW();
extern "C" void WINAPI Export_GetFileVersionInfoW();
extern "C" void WINAPI Export_OpenDriver();
extern "C" void WINAPI Export_OpenDriverA();
extern "C" void WINAPI Export_PlaySound();
extern "C" void WINAPI Export_PlaySoundA();
extern "C" void WINAPI Export_PlaySoundW();
extern "C" void WINAPI Export_SendDriverMessage();
extern "C" void WINAPI Export_VerFindFileA();
extern "C" void WINAPI Export_VerFindFileW();
extern "C" void WINAPI Export_VerInstallFileA();
extern "C" void WINAPI Export_VerInstallFileW();
extern "C" void WINAPI Export_VerLanguageNameA();
extern "C" void WINAPI Export_VerLanguageNameW();
extern "C" void WINAPI Export_VerQueryValueA();
extern "C" void WINAPI Export_VerQueryValueW();
extern "C" void WINAPI Export_WinHttpAddRequestHeaders();
extern "C" void WINAPI Export_WinHttpCheckPlatform();
extern "C" void WINAPI Export_WinHttpCloseHandle();
extern "C" void WINAPI Export_WinHttpConnect();
extern "C" void WINAPI Export_WinHttpCrackUrl();
extern "C" void WINAPI Export_WinHttpCreateProxyResolver();
extern "C" void WINAPI Export_WinHttpCreateUrl();
extern "C" void WINAPI Export_WinHttpDetectAutoProxyConfigUrl();
extern "C" void WINAPI Export_WinHttpFreeProxyResult();
extern "C" void WINAPI Export_WinHttpFreeProxyResultEx();
extern "C" void WINAPI Export_WinHttpFreeProxySettings();
extern "C" void WINAPI Export_WinHttpGetDefaultProxyConfiguration();
extern "C" void WINAPI Export_WinHttpGetIEProxyConfigForCurrentUser();
extern "C" void WINAPI Export_WinHttpGetProxyForUrl();
extern "C" void WINAPI Export_WinHttpGetProxyForUrlEx();
extern "C" void WINAPI Export_WinHttpGetProxyForUrlEx2();
extern "C" void WINAPI Export_WinHttpGetProxyResult();
extern "C" void WINAPI Export_WinHttpGetProxyResultEx();
extern "C" void WINAPI Export_WinHttpGetProxySettingsVersion();
extern "C" void WINAPI Export_WinHttpOpen();
extern "C" void WINAPI Export_WinHttpOpenRequest();
extern "C" void WINAPI Export_WinHttpQueryAuthSchemes();
extern "C" void WINAPI Export_WinHttpQueryDataAvailable();
extern "C" void WINAPI Export_WinHttpQueryHeaders();
extern "C" void WINAPI Export_WinHttpQueryOption();
extern "C" void WINAPI Export_WinHttpReadData();
extern "C" void WINAPI Export_WinHttpReadProxySettings();
extern "C" void WINAPI Export_WinHttpReceiveResponse();
extern "C" void WINAPI Export_WinHttpResetAutoProxy();
extern "C" void WINAPI Export_WinHttpSendRequest();
extern "C" void WINAPI Export_WinHttpSetCredentials();
extern "C" void WINAPI Export_WinHttpSetDefaultProxyConfiguration();
extern "C" void WINAPI Export_WinHttpSetOption();
extern "C" void WINAPI Export_WinHttpSetStatusCallback();
extern "C" void WINAPI Export_WinHttpSetTimeouts();
extern "C" void WINAPI Export_WinHttpTimeFromSystemTime();
extern "C" void WINAPI Export_WinHttpTimeToSystemTime();
extern "C" void WINAPI Export_WinHttpWebSocketClose();
extern "C" void WINAPI Export_WinHttpWebSocketCompleteUpgrade();
extern "C" void WINAPI Export_WinHttpWebSocketQueryCloseStatus();
extern "C" void WINAPI Export_WinHttpWebSocketReceive();
extern "C" void WINAPI Export_WinHttpWebSocketSend();
extern "C" void WINAPI Export_WinHttpWebSocketShutdown();
extern "C" void WINAPI Export_WinHttpWriteData();
extern "C" void WINAPI Export_WinHttpWriteProxySettings();
extern "C" void WINAPI Export_auxGetDevCapsA();
extern "C" void WINAPI Export_auxGetDevCapsW();
extern "C" void WINAPI Export_auxGetNumDevs();
extern "C" void WINAPI Export_auxGetVolume();
extern "C" void WINAPI Export_auxOutMessage();
extern "C" void WINAPI Export_auxSetVolume();
extern "C" void WINAPI Export_joyConfigChanged();
extern "C" void WINAPI Export_joyGetDevCapsA();
extern "C" void WINAPI Export_joyGetDevCapsW();
extern "C" void WINAPI Export_joyGetNumDevs();
extern "C" void WINAPI Export_joyGetPos();
extern "C" void WINAPI Export_joyGetPosEx();
extern "C" void WINAPI Export_joyGetThreshold();
extern "C" void WINAPI Export_joyReleaseCapture();
extern "C" void WINAPI Export_joySetCapture();
extern "C" void WINAPI Export_joySetThreshold();
extern "C" void WINAPI Export_mciDriverNotify();
extern "C" void WINAPI Export_mciDriverYield();
extern "C" void WINAPI Export_mciExecute();
extern "C" void WINAPI Export_mciFreeCommandResource();
extern "C" void WINAPI Export_mciGetCreatorTask();
extern "C" void WINAPI Export_mciGetDeviceIDA();
extern "C" void WINAPI Export_mciGetDeviceIDFromElementIDA();
extern "C" void WINAPI Export_mciGetDeviceIDFromElementIDW();
extern "C" void WINAPI Export_mciGetDeviceIDW();
extern "C" void WINAPI Export_mciGetDriverData();
extern "C" void WINAPI Export_mciGetErrorStringA();
extern "C" void WINAPI Export_mciGetErrorStringW();
extern "C" void WINAPI Export_mciGetYieldProc();
extern "C" void WINAPI Export_mciLoadCommandResource();
extern "C" void WINAPI Export_mciSendCommandA();
extern "C" void WINAPI Export_mciSendCommandW();
extern "C" void WINAPI Export_mciSendStringA();
extern "C" void WINAPI Export_mciSendStringW();
extern "C" void WINAPI Export_mciSetDriverData();
extern "C" void WINAPI Export_mciSetYieldProc();
extern "C" void WINAPI Export_midiConnect();
extern "C" void WINAPI Export_midiDisconnect();
extern "C" void WINAPI Export_midiInAddBuffer();
extern "C" void WINAPI Export_midiInClose();
extern "C" void WINAPI Export_midiInGetDevCapsA();
extern "C" void WINAPI Export_midiInGetDevCapsW();
extern "C" void WINAPI Export_midiInGetErrorTextA();
extern "C" void WINAPI Export_midiInGetErrorTextW();
extern "C" void WINAPI Export_midiInGetID();
extern "C" void WINAPI Export_midiInGetNumDevs();
extern "C" void WINAPI Export_midiInMessage();
extern "C" void WINAPI Export_midiInOpen();
extern "C" void WINAPI Export_midiInPrepareHeader();
extern "C" void WINAPI Export_midiInReset();
extern "C" void WINAPI Export_midiInStart();
extern "C" void WINAPI Export_midiInStop();
extern "C" void WINAPI Export_midiInUnprepareHeader();
extern "C" void WINAPI Export_midiOutCacheDrumPatches();
extern "C" void WINAPI Export_midiOutCachePatches();
extern "C" void WINAPI Export_midiOutClose();
extern "C" void WINAPI Export_midiOutGetDevCapsA();
extern "C" void WINAPI Export_midiOutGetDevCapsW();
extern "C" void WINAPI Export_midiOutGetErrorTextA();
extern "C" void WINAPI Export_midiOutGetErrorTextW();
extern "C" void WINAPI Export_midiOutGetID();
extern "C" void WINAPI Export_midiOutGetNumDevs();
extern "C" void WINAPI Export_midiOutGetVolume();
extern "C" void WINAPI Export_midiOutLongMsg();
extern "C" void WINAPI Export_midiOutMessage();
extern "C" void WINAPI Export_midiOutOpen();
extern "C" void WINAPI Export_midiOutPrepareHeader();
extern "C" void WINAPI Export_midiOutReset();
extern "C" void WINAPI Export_midiOutSetVolume();
extern "C" void WINAPI Export_midiOutShortMsg();
extern "C" void WINAPI Export_midiOutUnprepareHeader();
extern "C" void WINAPI Export_midiStreamClose();
extern "C" void WINAPI Export_midiStreamOpen();
extern "C" void WINAPI Export_midiStreamOut();
extern "C" void WINAPI Export_midiStreamPause();
extern "C" void WINAPI Export_midiStreamPosition();
extern "C" void WINAPI Export_midiStreamProperty();
extern "C" void WINAPI Export_midiStreamRestart();
extern "C" void WINAPI Export_midiStreamStop();
extern "C" void WINAPI Export_mixerClose();
extern "C" void WINAPI Export_mixerGetControlDetailsA();
extern "C" void WINAPI Export_mixerGetControlDetailsW();
extern "C" void WINAPI Export_mixerGetDevCapsA();
extern "C" void WINAPI Export_mixerGetDevCapsW();
extern "C" void WINAPI Export_mixerGetID();
extern "C" void WINAPI Export_mixerGetLineControlsA();
extern "C" void WINAPI Export_mixerGetLineControlsW();
extern "C" void WINAPI Export_mixerGetLineInfoA();
extern "C" void WINAPI Export_mixerGetLineInfoW();
extern "C" void WINAPI Export_mixerGetNumDevs();
extern "C" void WINAPI Export_mixerMessage();
extern "C" void WINAPI Export_mixerOpen();
extern "C" void WINAPI Export_mixerSetControlDetails();
extern "C" void WINAPI Export_mmGetCurrentTask();
extern "C" void WINAPI Export_mmTaskBlock();
extern "C" void WINAPI Export_mmTaskCreate();
extern "C" void WINAPI Export_mmTaskSignal();
extern "C" void WINAPI Export_mmTaskYield();
extern "C" void WINAPI Export_mmioAdvance();
extern "C" void WINAPI Export_mmioAscend();
extern "C" void WINAPI Export_mmioClose();
extern "C" void WINAPI Export_mmioCreateChunk();
extern "C" void WINAPI Export_mmioDescend();
extern "C" void WINAPI Export_mmioFlush();
extern "C" void WINAPI Export_mmioGetInfo();
extern "C" void WINAPI Export_mmioInstallIOProc16();
extern "C" void WINAPI Export_mmioInstallIOProcA();
extern "C" void WINAPI Export_mmioInstallIOProcW();
extern "C" void WINAPI Export_mmioOpenA();
extern "C" void WINAPI Export_mmioOpenW();
extern "C" void WINAPI Export_mmioRead();
extern "C" void WINAPI Export_mmioRenameA();
extern "C" void WINAPI Export_mmioRenameW();
extern "C" void WINAPI Export_mmioSeek();
extern "C" void WINAPI Export_mmioSendMessage();
extern "C" void WINAPI Export_mmioSetBuffer();
extern "C" void WINAPI Export_mmioSetInfo();
extern "C" void WINAPI Export_mmioStringToFOURCCA();
extern "C" void WINAPI Export_mmioStringToFOURCCW();
extern "C" void WINAPI Export_mmioWrite();
extern "C" void WINAPI Export_mmsystemGetVersion();
extern "C" void WINAPI Export_sndPlaySoundA();
extern "C" void WINAPI Export_sndPlaySoundW();
extern "C" void WINAPI Export_timeBeginPeriod();
extern "C" void WINAPI Export_timeEndPeriod();
extern "C" void WINAPI Export_timeGetDevCaps();
extern "C" void WINAPI Export_timeGetSystemTime();
extern "C" void WINAPI Export_timeGetTime();
extern "C" void WINAPI Export_timeKillEvent();
extern "C" void WINAPI Export_timeSetEvent();
extern "C" void WINAPI Export_waveInAddBuffer();
extern "C" void WINAPI Export_waveInClose();
extern "C" void WINAPI Export_waveInGetDevCapsA();
extern "C" void WINAPI Export_waveInGetDevCapsW();
extern "C" void WINAPI Export_waveInGetErrorTextA();
extern "C" void WINAPI Export_waveInGetErrorTextW();
extern "C" void WINAPI Export_waveInGetID();
extern "C" void WINAPI Export_waveInGetNumDevs();
extern "C" void WINAPI Export_waveInGetPosition();
extern "C" void WINAPI Export_waveInMessage();
extern "C" void WINAPI Export_waveInOpen();
extern "C" void WINAPI Export_waveInPrepareHeader();
extern "C" void WINAPI Export_waveInReset();
extern "C" void WINAPI Export_waveInStart();
extern "C" void WINAPI Export_waveInStop();
extern "C" void WINAPI Export_waveInUnprepareHeader();
extern "C" void WINAPI Export_waveOutBreakLoop();
extern "C" void WINAPI Export_waveOutClose();
extern "C" void WINAPI Export_waveOutGetDevCapsA();
extern "C" void WINAPI Export_waveOutGetDevCapsW();
extern "C" void WINAPI Export_waveOutGetErrorTextA();
extern "C" void WINAPI Export_waveOutGetErrorTextW();
extern "C" void WINAPI Export_waveOutGetID();
extern "C" void WINAPI Export_waveOutGetNumDevs();
extern "C" void WINAPI Export_waveOutGetPitch();
extern "C" void WINAPI Export_waveOutGetPlaybackRate();
extern "C" void WINAPI Export_waveOutGetPosition();
extern "C" void WINAPI Export_waveOutGetVolume();
extern "C" void WINAPI Export_waveOutMessage();
extern "C" void WINAPI Export_waveOutOpen();
extern "C" void WINAPI Export_waveOutPause();
extern "C" void WINAPI Export_waveOutPrepareHeader();
extern "C" void WINAPI Export_waveOutReset();
extern "C" void WINAPI Export_waveOutRestart();
extern "C" void WINAPI Export_waveOutSetPitch();
extern "C" void WINAPI Export_waveOutSetPlaybackRate();
extern "C" void WINAPI Export_waveOutSetVolume();
extern "C" void WINAPI Export_waveOutUnprepareHeader();
extern "C" void WINAPI Export_waveOutWrite();

#if _WIN64
#pragma comment(linker, "/export:CloseDriver=Export_CloseDriver")
#pragma comment(linker, "/export:DefDriverProc=Export_DefDriverProc")
#pragma comment(linker, "/export:DllCanUnloadNow=Export_DllCanUnloadNow")
#pragma comment(linker, "/export:DllGetClassObject=Export_DllGetClassObject")
#pragma comment(linker, "/export:DllRegisterServer=Export_DllRegisterServer")
#pragma comment(linker, "/export:DllUnregisterServer=Export_DllUnregisterServer")
#pragma comment(linker, "/export:DriverCallback=Export_DriverCallback")
#pragma comment(linker, "/export:DrvClose=Export_DrvClose")
#pragma comment(linker, "/export:DrvDefDriverProc=Export_DrvDefDriverProc")
#pragma comment(linker, "/export:DrvGetModuleHandle=Export_DrvGetModuleHandle")
#pragma comment(linker, "/export:DrvOpen=Export_DrvOpen")
#pragma comment(linker, "/export:DrvOpenA=Export_DrvOpenA")
#pragma comment(linker, "/export:DrvSendMessage=Export_DrvSendMessage")
#pragma comment(linker, "/export:GetDriverFlags=Export_GetDriverFlags")
#pragma comment(linker, "/export:GetDriverModuleHandle=Export_GetDriverModuleHandle")
#pragma comment(linker, "/export:GetFileVersionInfoA=Export_GetFileVersionInfoA")
#pragma comment(linker, "/export:GetFileVersionInfoExA=Export_GetFileVersionInfoExA")
#pragma comment(linker, "/export:GetFileVersionInfoExW=Export_GetFileVersionInfoExW")
#pragma comment(linker, "/export:GetFileVersionInfoSizeA=Export_GetFileVersionInfoSizeA")
#pragma comment(linker, "/export:GetFileVersionInfoSizeExA=Export_GetFileVersionInfoSizeExA")
#pragma comment(linker, "/export:GetFileVersionInfoSizeExW=Export_GetFileVersionInfoSizeExW")
#pragma comment(linker, "/export:GetFileVersionInfoSizeW=Export_GetFileVersionInfoSizeW")
#pragma comment(linker, "/export:GetFileVersionInfoW=Export_GetFileVersionInfoW")
#pragma comment(linker, "/export:OpenDriver=Export_OpenDriver")
#pragma comment(linker, "/export:OpenDriverA=Export_OpenDriverA")
#pragma comment(linker, "/export:PlaySound=Export_PlaySound")
#pragma comment(linker, "/export:PlaySoundA=Export_PlaySoundA")
#pragma comment(linker, "/export:PlaySoundW=Export_PlaySoundW")
#pragma comment(linker, "/export:SendDriverMessage=Export_SendDriverMessage")
#pragma comment(linker, "/export:VerFindFileA=Export_VerFindFileA")
#pragma comment(linker, "/export:VerFindFileW=Export_VerFindFileW")
#pragma comment(linker, "/export:VerInstallFileA=Export_VerInstallFileA")
#pragma comment(linker, "/export:VerInstallFileW=Export_VerInstallFileW")
#pragma comment(linker, "/export:VerLanguageNameA=Export_VerLanguageNameA")
#pragma comment(linker, "/export:VerLanguageNameW=Export_VerLanguageNameW")
#pragma comment(linker, "/export:VerQueryValueA=Export_VerQueryValueA")
#pragma comment(linker, "/export:VerQueryValueW=Export_VerQueryValueW")
#pragma comment(linker, "/export:WinHttpAddRequestHeaders=Export_WinHttpAddRequestHeaders")
#pragma comment(linker, "/export:WinHttpCheckPlatform=Export_WinHttpCheckPlatform")
#pragma comment(linker, "/export:WinHttpCloseHandle=Export_WinHttpCloseHandle")
#pragma comment(linker, "/export:WinHttpConnect=Export_WinHttpConnect")
#pragma comment(linker, "/export:WinHttpCrackUrl=Export_WinHttpCrackUrl")
#pragma comment(linker, "/export:WinHttpCreateProxyResolver=Export_WinHttpCreateProxyResolver")
#pragma comment(linker, "/export:WinHttpCreateUrl=Export_WinHttpCreateUrl")
#pragma comment(linker, "/export:WinHttpDetectAutoProxyConfigUrl=Export_WinHttpDetectAutoProxyConfigUrl")
#pragma comment(linker, "/export:WinHttpFreeProxyResult=Export_WinHttpFreeProxyResult")
#pragma comment(linker, "/export:WinHttpFreeProxyResultEx=Export_WinHttpFreeProxyResultEx")
#pragma comment(linker, "/export:WinHttpFreeProxySettings=Export_WinHttpFreeProxySettings")
#pragma comment(linker, "/export:WinHttpGetDefaultProxyConfiguration=Export_WinHttpGetDefaultProxyConfiguration")
#pragma comment(linker, "/export:WinHttpGetIEProxyConfigForCurrentUser=Export_WinHttpGetIEProxyConfigForCurrentUser")
#pragma comment(linker, "/export:WinHttpGetProxyForUrl=Export_WinHttpGetProxyForUrl")
#pragma comment(linker, "/export:WinHttpGetProxyForUrlEx=Export_WinHttpGetProxyForUrlEx")
#pragma comment(linker, "/export:WinHttpGetProxyForUrlEx2=Export_WinHttpGetProxyForUrlEx2")
#pragma comment(linker, "/export:WinHttpGetProxyResult=Export_WinHttpGetProxyResult")
#pragma comment(linker, "/export:WinHttpGetProxyResultEx=Export_WinHttpGetProxyResultEx")
#pragma comment(linker, "/export:WinHttpGetProxySettingsVersion=Export_WinHttpGetProxySettingsVersion")
#pragma comment(linker, "/export:WinHttpOpen=Export_WinHttpOpen")
#pragma comment(linker, "/export:WinHttpOpenRequest=Export_WinHttpOpenRequest")
#pragma comment(linker, "/export:WinHttpQueryAuthSchemes=Export_WinHttpQueryAuthSchemes")
#pragma comment(linker, "/export:WinHttpQueryDataAvailable=Export_WinHttpQueryDataAvailable")
#pragma comment(linker, "/export:WinHttpQueryHeaders=Export_WinHttpQueryHeaders")
#pragma comment(linker, "/export:WinHttpQueryOption=Export_WinHttpQueryOption")
#pragma comment(linker, "/export:WinHttpReadData=Export_WinHttpReadData")
#pragma comment(linker, "/export:WinHttpReadProxySettings=Export_WinHttpReadProxySettings")
#pragma comment(linker, "/export:WinHttpReceiveResponse=Export_WinHttpReceiveResponse")
#pragma comment(linker, "/export:WinHttpResetAutoProxy=Export_WinHttpResetAutoProxy")
#pragma comment(linker, "/export:WinHttpSendRequest=Export_WinHttpSendRequest")
#pragma comment(linker, "/export:WinHttpSetCredentials=Export_WinHttpSetCredentials")
#pragma comment(linker, "/export:WinHttpSetDefaultProxyConfiguration=Export_WinHttpSetDefaultProxyConfiguration")
#pragma comment(linker, "/export:WinHttpSetOption=Export_WinHttpSetOption")
#pragma comment(linker, "/export:WinHttpSetStatusCallback=Export_WinHttpSetStatusCallback")
#pragma comment(linker, "/export:WinHttpSetTimeouts=Export_WinHttpSetTimeouts")
#pragma comment(linker, "/export:WinHttpTimeFromSystemTime=Export_WinHttpTimeFromSystemTime")
#pragma comment(linker, "/export:WinHttpTimeToSystemTime=Export_WinHttpTimeToSystemTime")
#pragma comment(linker, "/export:WinHttpWebSocketClose=Export_WinHttpWebSocketClose")
#pragma comment(linker, "/export:WinHttpWebSocketCompleteUpgrade=Export_WinHttpWebSocketCompleteUpgrade")
#pragma comment(linker, "/export:WinHttpWebSocketQueryCloseStatus=Export_WinHttpWebSocketQueryCloseStatus")
#pragma comment(linker, "/export:WinHttpWebSocketReceive=Export_WinHttpWebSocketReceive")
#pragma comment(linker, "/export:WinHttpWebSocketSend=Export_WinHttpWebSocketSend")
#pragma comment(linker, "/export:WinHttpWebSocketShutdown=Export_WinHttpWebSocketShutdown")
#pragma comment(linker, "/export:WinHttpWriteData=Export_WinHttpWriteData")
#pragma comment(linker, "/export:WinHttpWriteProxySettings=Export_WinHttpWriteProxySettings")
#pragma comment(linker, "/export:auxGetDevCapsA=Export_auxGetDevCapsA")
#pragma comment(linker, "/export:auxGetDevCapsW=Export_auxGetDevCapsW")
#pragma comment(linker, "/export:auxGetNumDevs=Export_auxGetNumDevs")
#pragma comment(linker, "/export:auxGetVolume=Export_auxGetVolume")
#pragma comment(linker, "/export:auxOutMessage=Export_auxOutMessage")
#pragma comment(linker, "/export:auxSetVolume=Export_auxSetVolume")
#pragma comment(linker, "/export:joyConfigChanged=Export_joyConfigChanged")
#pragma comment(linker, "/export:joyGetDevCapsA=Export_joyGetDevCapsA")
#pragma comment(linker, "/export:joyGetDevCapsW=Export_joyGetDevCapsW")
#pragma comment(linker, "/export:joyGetNumDevs=Export_joyGetNumDevs")
#pragma comment(linker, "/export:joyGetPos=Export_joyGetPos")
#pragma comment(linker, "/export:joyGetPosEx=Export_joyGetPosEx")
#pragma comment(linker, "/export:joyGetThreshold=Export_joyGetThreshold")
#pragma comment(linker, "/export:joyReleaseCapture=Export_joyReleaseCapture")
#pragma comment(linker, "/export:joySetCapture=Export_joySetCapture")
#pragma comment(linker, "/export:joySetThreshold=Export_joySetThreshold")
#pragma comment(linker, "/export:mciDriverNotify=Export_mciDriverNotify")
#pragma comment(linker, "/export:mciDriverYield=Export_mciDriverYield")
#pragma comment(linker, "/export:mciExecute=Export_mciExecute")
#pragma comment(linker, "/export:mciFreeCommandResource=Export_mciFreeCommandResource")
#pragma comment(linker, "/export:mciGetCreatorTask=Export_mciGetCreatorTask")
#pragma comment(linker, "/export:mciGetDeviceIDA=Export_mciGetDeviceIDA")
#pragma comment(linker, "/export:mciGetDeviceIDFromElementIDA=Export_mciGetDeviceIDFromElementIDA")
#pragma comment(linker, "/export:mciGetDeviceIDFromElementIDW=Export_mciGetDeviceIDFromElementIDW")
#pragma comment(linker, "/export:mciGetDeviceIDW=Export_mciGetDeviceIDW")
#pragma comment(linker, "/export:mciGetDriverData=Export_mciGetDriverData")
#pragma comment(linker, "/export:mciGetErrorStringA=Export_mciGetErrorStringA")
#pragma comment(linker, "/export:mciGetErrorStringW=Export_mciGetErrorStringW")
#pragma comment(linker, "/export:mciGetYieldProc=Export_mciGetYieldProc")
#pragma comment(linker, "/export:mciLoadCommandResource=Export_mciLoadCommandResource")
#pragma comment(linker, "/export:mciSendCommandA=Export_mciSendCommandA")
#pragma comment(linker, "/export:mciSendCommandW=Export_mciSendCommandW")
#pragma comment(linker, "/export:mciSendStringA=Export_mciSendStringA")
#pragma comment(linker, "/export:mciSendStringW=Export_mciSendStringW")
#pragma comment(linker, "/export:mciSetDriverData=Export_mciSetDriverData")
#pragma comment(linker, "/export:mciSetYieldProc=Export_mciSetYieldProc")
#pragma comment(linker, "/export:midiConnect=Export_midiConnect")
#pragma comment(linker, "/export:midiDisconnect=Export_midiDisconnect")
#pragma comment(linker, "/export:midiInAddBuffer=Export_midiInAddBuffer")
#pragma comment(linker, "/export:midiInClose=Export_midiInClose")
#pragma comment(linker, "/export:midiInGetDevCapsA=Export_midiInGetDevCapsA")
#pragma comment(linker, "/export:midiInGetDevCapsW=Export_midiInGetDevCapsW")
#pragma comment(linker, "/export:midiInGetErrorTextA=Export_midiInGetErrorTextA")
#pragma comment(linker, "/export:midiInGetErrorTextW=Export_midiInGetErrorTextW")
#pragma comment(linker, "/export:midiInGetID=Export_midiInGetID")
#pragma comment(linker, "/export:midiInGetNumDevs=Export_midiInGetNumDevs")
#pragma comment(linker, "/export:midiInMessage=Export_midiInMessage")
#pragma comment(linker, "/export:midiInOpen=Export_midiInOpen")
#pragma comment(linker, "/export:midiInPrepareHeader=Export_midiInPrepareHeader")
#pragma comment(linker, "/export:midiInReset=Export_midiInReset")
#pragma comment(linker, "/export:midiInStart=Export_midiInStart")
#pragma comment(linker, "/export:midiInStop=Export_midiInStop")
#pragma comment(linker, "/export:midiInUnprepareHeader=Export_midiInUnprepareHeader")
#pragma comment(linker, "/export:midiOutCacheDrumPatches=Export_midiOutCacheDrumPatches")
#pragma comment(linker, "/export:midiOutCachePatches=Export_midiOutCachePatches")
#pragma comment(linker, "/export:midiOutClose=Export_midiOutClose")
#pragma comment(linker, "/export:midiOutGetDevCapsA=Export_midiOutGetDevCapsA")
#pragma comment(linker, "/export:midiOutGetDevCapsW=Export_midiOutGetDevCapsW")
#pragma comment(linker, "/export:midiOutGetErrorTextA=Export_midiOutGetErrorTextA")
#pragma comment(linker, "/export:midiOutGetErrorTextW=Export_midiOutGetErrorTextW")
#pragma comment(linker, "/export:midiOutGetID=Export_midiOutGetID")
#pragma comment(linker, "/export:midiOutGetNumDevs=Export_midiOutGetNumDevs")
#pragma comment(linker, "/export:midiOutGetVolume=Export_midiOutGetVolume")
#pragma comment(linker, "/export:midiOutLongMsg=Export_midiOutLongMsg")
#pragma comment(linker, "/export:midiOutMessage=Export_midiOutMessage")
#pragma comment(linker, "/export:midiOutOpen=Export_midiOutOpen")
#pragma comment(linker, "/export:midiOutPrepareHeader=Export_midiOutPrepareHeader")
#pragma comment(linker, "/export:midiOutReset=Export_midiOutReset")
#pragma comment(linker, "/export:midiOutSetVolume=Export_midiOutSetVolume")
#pragma comment(linker, "/export:midiOutShortMsg=Export_midiOutShortMsg")
#pragma comment(linker, "/export:midiOutUnprepareHeader=Export_midiOutUnprepareHeader")
#pragma comment(linker, "/export:midiStreamClose=Export_midiStreamClose")
#pragma comment(linker, "/export:midiStreamOpen=Export_midiStreamOpen")
#pragma comment(linker, "/export:midiStreamOut=Export_midiStreamOut")
#pragma comment(linker, "/export:midiStreamPause=Export_midiStreamPause")
#pragma comment(linker, "/export:midiStreamPosition=Export_midiStreamPosition")
#pragma comment(linker, "/export:midiStreamProperty=Export_midiStreamProperty")
#pragma comment(linker, "/export:midiStreamRestart=Export_midiStreamRestart")
#pragma comment(linker, "/export:midiStreamStop=Export_midiStreamStop")
#pragma comment(linker, "/export:mixerClose=Export_mixerClose")
#pragma comment(linker, "/export:mixerGetControlDetailsA=Export_mixerGetControlDetailsA")
#pragma comment(linker, "/export:mixerGetControlDetailsW=Export_mixerGetControlDetailsW")
#pragma comment(linker, "/export:mixerGetDevCapsA=Export_mixerGetDevCapsA")
#pragma comment(linker, "/export:mixerGetDevCapsW=Export_mixerGetDevCapsW")
#pragma comment(linker, "/export:mixerGetID=Export_mixerGetID")
#pragma comment(linker, "/export:mixerGetLineControlsA=Export_mixerGetLineControlsA")
#pragma comment(linker, "/export:mixerGetLineControlsW=Export_mixerGetLineControlsW")
#pragma comment(linker, "/export:mixerGetLineInfoA=Export_mixerGetLineInfoA")
#pragma comment(linker, "/export:mixerGetLineInfoW=Export_mixerGetLineInfoW")
#pragma comment(linker, "/export:mixerGetNumDevs=Export_mixerGetNumDevs")
#pragma comment(linker, "/export:mixerMessage=Export_mixerMessage")
#pragma comment(linker, "/export:mixerOpen=Export_mixerOpen")
#pragma comment(linker, "/export:mixerSetControlDetails=Export_mixerSetControlDetails")
#pragma comment(linker, "/export:mmGetCurrentTask=Export_mmGetCurrentTask")
#pragma comment(linker, "/export:mmTaskBlock=Export_mmTaskBlock")
#pragma comment(linker, "/export:mmTaskCreate=Export_mmTaskCreate")
#pragma comment(linker, "/export:mmTaskSignal=Export_mmTaskSignal")
#pragma comment(linker, "/export:mmTaskYield=Export_mmTaskYield")
#pragma comment(linker, "/export:mmioAdvance=Export_mmioAdvance")
#pragma comment(linker, "/export:mmioAscend=Export_mmioAscend")
#pragma comment(linker, "/export:mmioClose=Export_mmioClose")
#pragma comment(linker, "/export:mmioCreateChunk=Export_mmioCreateChunk")
#pragma comment(linker, "/export:mmioDescend=Export_mmioDescend")
#pragma comment(linker, "/export:mmioFlush=Export_mmioFlush")
#pragma comment(linker, "/export:mmioGetInfo=Export_mmioGetInfo")
#pragma comment(linker, "/export:mmioInstallIOProc16=Export_mmioInstallIOProc16")
#pragma comment(linker, "/export:mmioInstallIOProcA=Export_mmioInstallIOProcA")
#pragma comment(linker, "/export:mmioInstallIOProcW=Export_mmioInstallIOProcW")
#pragma comment(linker, "/export:mmioOpenA=Export_mmioOpenA")
#pragma comment(linker, "/export:mmioOpenW=Export_mmioOpenW")
#pragma comment(linker, "/export:mmioRead=Export_mmioRead")
#pragma comment(linker, "/export:mmioRenameA=Export_mmioRenameA")
#pragma comment(linker, "/export:mmioRenameW=Export_mmioRenameW")
#pragma comment(linker, "/export:mmioSeek=Export_mmioSeek")
#pragma comment(linker, "/export:mmioSendMessage=Export_mmioSendMessage")
#pragma comment(linker, "/export:mmioSetBuffer=Export_mmioSetBuffer")
#pragma comment(linker, "/export:mmioSetInfo=Export_mmioSetInfo")
#pragma comment(linker, "/export:mmioStringToFOURCCA=Export_mmioStringToFOURCCA")
#pragma comment(linker, "/export:mmioStringToFOURCCW=Export_mmioStringToFOURCCW")
#pragma comment(linker, "/export:mmioWrite=Export_mmioWrite")
#pragma comment(linker, "/export:mmsystemGetVersion=Export_mmsystemGetVersion")
#pragma comment(linker, "/export:sndPlaySoundA=Export_sndPlaySoundA")
#pragma comment(linker, "/export:sndPlaySoundW=Export_sndPlaySoundW")
#pragma comment(linker, "/export:timeBeginPeriod=Export_timeBeginPeriod")
#pragma comment(linker, "/export:timeEndPeriod=Export_timeEndPeriod")
#pragma comment(linker, "/export:timeGetDevCaps=Export_timeGetDevCaps")
#pragma comment(linker, "/export:timeGetSystemTime=Export_timeGetSystemTime")
#pragma comment(linker, "/export:timeGetTime=Export_timeGetTime")
#pragma comment(linker, "/export:timeKillEvent=Export_timeKillEvent")
#pragma comment(linker, "/export:timeSetEvent=Export_timeSetEvent")
#pragma comment(linker, "/export:waveInAddBuffer=Export_waveInAddBuffer")
#pragma comment(linker, "/export:waveInClose=Export_waveInClose")
#pragma comment(linker, "/export:waveInGetDevCapsA=Export_waveInGetDevCapsA")
#pragma comment(linker, "/export:waveInGetDevCapsW=Export_waveInGetDevCapsW")
#pragma comment(linker, "/export:waveInGetErrorTextA=Export_waveInGetErrorTextA")
#pragma comment(linker, "/export:waveInGetErrorTextW=Export_waveInGetErrorTextW")
#pragma comment(linker, "/export:waveInGetID=Export_waveInGetID")
#pragma comment(linker, "/export:waveInGetNumDevs=Export_waveInGetNumDevs")
#pragma comment(linker, "/export:waveInGetPosition=Export_waveInGetPosition")
#pragma comment(linker, "/export:waveInMessage=Export_waveInMessage")
#pragma comment(linker, "/export:waveInOpen=Export_waveInOpen")
#pragma comment(linker, "/export:waveInPrepareHeader=Export_waveInPrepareHeader")
#pragma comment(linker, "/export:waveInReset=Export_waveInReset")
#pragma comment(linker, "/export:waveInStart=Export_waveInStart")
#pragma comment(linker, "/export:waveInStop=Export_waveInStop")
#pragma comment(linker, "/export:waveInUnprepareHeader=Export_waveInUnprepareHeader")
#pragma comment(linker, "/export:waveOutBreakLoop=Export_waveOutBreakLoop")
#pragma comment(linker, "/export:waveOutClose=Export_waveOutClose")
#pragma comment(linker, "/export:waveOutGetDevCapsA=Export_waveOutGetDevCapsA")
#pragma comment(linker, "/export:waveOutGetDevCapsW=Export_waveOutGetDevCapsW")
#pragma comment(linker, "/export:waveOutGetErrorTextA=Export_waveOutGetErrorTextA")
#pragma comment(linker, "/export:waveOutGetErrorTextW=Export_waveOutGetErrorTextW")
#pragma comment(linker, "/export:waveOutGetID=Export_waveOutGetID")
#pragma comment(linker, "/export:waveOutGetNumDevs=Export_waveOutGetNumDevs")
#pragma comment(linker, "/export:waveOutGetPitch=Export_waveOutGetPitch")
#pragma comment(linker, "/export:waveOutGetPlaybackRate=Export_waveOutGetPlaybackRate")
#pragma comment(linker, "/export:waveOutGetPosition=Export_waveOutGetPosition")
#pragma comment(linker, "/export:waveOutGetVolume=Export_waveOutGetVolume")
#pragma comment(linker, "/export:waveOutMessage=Export_waveOutMessage")
#pragma comment(linker, "/export:waveOutOpen=Export_waveOutOpen")
#pragma comment(linker, "/export:waveOutPause=Export_waveOutPause")
#pragma comment(linker, "/export:waveOutPrepareHeader=Export_waveOutPrepareHeader")
#pragma comment(linker, "/export:waveOutReset=Export_waveOutReset")
#pragma comment(linker, "/export:waveOutRestart=Export_waveOutRestart")
#pragma comment(linker, "/export:waveOutSetPitch=Export_waveOutSetPitch")
#pragma comment(linker, "/export:waveOutSetPlaybackRate=Export_waveOutSetPlaybackRate")
#pragma comment(linker, "/export:waveOutSetVolume=Export_waveOutSetVolume")
#pragma comment(linker, "/export:waveOutUnprepareHeader=Export_waveOutUnprepareHeader")
#pragma comment(linker, "/export:waveOutWrite=Export_waveOutWrite")
#else
#pragma comment(linker, "/export:CloseDriver=_Export_CloseDriver@0")
#pragma comment(linker, "/export:DefDriverProc=_Export_DefDriverProc@0")
#pragma comment(linker, "/export:DllCanUnloadNow=_Export_DllCanUnloadNow@0")
#pragma comment(linker, "/export:DllGetClassObject=_Export_DllGetClassObject@0")
#pragma comment(linker, "/export:DllRegisterServer=_Export_DllRegisterServer@0")
#pragma comment(linker, "/export:DllUnregisterServer=_Export_DllUnregisterServer@0")
#pragma comment(linker, "/export:DriverCallback=_Export_DriverCallback@0")
#pragma comment(linker, "/export:DrvClose=_Export_DrvClose@0")
#pragma comment(linker, "/export:DrvDefDriverProc=_Export_DrvDefDriverProc@0")
#pragma comment(linker, "/export:DrvGetModuleHandle=_Export_DrvGetModuleHandle@0")
#pragma comment(linker, "/export:DrvOpen=_Export_DrvOpen@0")
#pragma comment(linker, "/export:DrvOpenA=_Export_DrvOpenA@0")
#pragma comment(linker, "/export:DrvSendMessage=_Export_DrvSendMessage@0")
#pragma comment(linker, "/export:GetDriverFlags=_Export_GetDriverFlags@0")
#pragma comment(linker, "/export:GetDriverModuleHandle=_Export_GetDriverModuleHandle@0")
#pragma comment(linker, "/export:GetFileVersionInfoA=_Export_GetFileVersionInfoA@0")
#pragma comment(linker, "/export:GetFileVersionInfoExA=_Export_GetFileVersionInfoExA@0")
#pragma comment(linker, "/export:GetFileVersionInfoExW=_Export_GetFileVersionInfoExW@0")
#pragma comment(linker, "/export:GetFileVersionInfoSizeA=_Export_GetFileVersionInfoSizeA@0")
#pragma comment(linker, "/export:GetFileVersionInfoSizeExA=_Export_GetFileVersionInfoSizeExA@0")
#pragma comment(linker, "/export:GetFileVersionInfoSizeExW=_Export_GetFileVersionInfoSizeExW@0")
#pragma comment(linker, "/export:GetFileVersionInfoSizeW=_Export_GetFileVersionInfoSizeW@0")
#pragma comment(linker, "/export:GetFileVersionInfoW=_Export_GetFileVersionInfoW@0")
#pragma comment(linker, "/export:OpenDriver=_Export_OpenDriver@0")
#pragma comment(linker, "/export:OpenDriverA=_Export_OpenDriverA@0")
#pragma comment(linker, "/export:PlaySound=_Export_PlaySound@0")
#pragma comment(linker, "/export:PlaySoundA=_Export_PlaySoundA@0")
#pragma comment(linker, "/export:PlaySoundW=_Export_PlaySoundW@0")
#pragma comment(linker, "/export:SendDriverMessage=_Export_SendDriverMessage@0")
#pragma comment(linker, "/export:VerFindFileA=_Export_VerFindFileA@0")
#pragma comment(linker, "/export:VerFindFileW=_Export_VerFindFileW@0")
#pragma comment(linker, "/export:VerInstallFileA=_Export_VerInstallFileA@0")
#pragma comment(linker, "/export:VerInstallFileW=_Export_VerInstallFileW@0")
#pragma comment(linker, "/export:VerLanguageNameA=_Export_VerLanguageNameA@0")
#pragma comment(linker, "/export:VerLanguageNameW=_Export_VerLanguageNameW@0")
#pragma comment(linker, "/export:VerQueryValueA=_Export_VerQueryValueA@0")
#pragma comment(linker, "/export:VerQueryValueW=_Export_VerQueryValueW@0")
#pragma comment(linker, "/export:WinHttpAddRequestHeaders=_Export_WinHttpAddRequestHeaders@0")
#pragma comment(linker, "/export:WinHttpCheckPlatform=_Export_WinHttpCheckPlatform@0")
#pragma comment(linker, "/export:WinHttpCloseHandle=_Export_WinHttpCloseHandle@0")
#pragma comment(linker, "/export:WinHttpConnect=_Export_WinHttpConnect@0")
#pragma comment(linker, "/export:WinHttpCrackUrl=_Export_WinHttpCrackUrl@0")
#pragma comment(linker, "/export:WinHttpCreateProxyResolver=_Export_WinHttpCreateProxyResolver@0")
#pragma comment(linker, "/export:WinHttpCreateUrl=_Export_WinHttpCreateUrl@0")
#pragma comment(linker, "/export:WinHttpDetectAutoProxyConfigUrl=_Export_WinHttpDetectAutoProxyConfigUrl@0")
#pragma comment(linker, "/export:WinHttpFreeProxyResult=_Export_WinHttpFreeProxyResult@0")
#pragma comment(linker, "/export:WinHttpFreeProxyResultEx=_Export_WinHttpFreeProxyResultEx@0")
#pragma comment(linker, "/export:WinHttpFreeProxySettings=_Export_WinHttpFreeProxySettings@0")
#pragma comment(linker, "/export:WinHttpGetDefaultProxyConfiguration=_Export_WinHttpGetDefaultProxyConfiguration@0")
#pragma comment(linker, "/export:WinHttpGetIEProxyConfigForCurrentUser=_Export_WinHttpGetIEProxyConfigForCurrentUser@0")
#pragma comment(linker, "/export:WinHttpGetProxyForUrl=_Export_WinHttpGetProxyForUrl@0")
#pragma comment(linker, "/export:WinHttpGetProxyForUrlEx=_Export_WinHttpGetProxyForUrlEx@0")
#pragma comment(linker, "/export:WinHttpGetProxyForUrlEx2=_Export_WinHttpGetProxyForUrlEx2@0")
#pragma comment(linker, "/export:WinHttpGetProxyResult=_Export_WinHttpGetProxyResult@0")
#pragma comment(linker, "/export:WinHttpGetProxyResultEx=_Export_WinHttpGetProxyResultEx@0")
#pragma comment(linker, "/export:WinHttpGetProxySettingsVersion=_Export_WinHttpGetProxySettingsVersion@0")
#pragma comment(linker, "/export:WinHttpOpen=_Export_WinHttpOpen@0")
#pragma comment(linker, "/export:WinHttpOpenRequest=_Export_WinHttpOpenRequest@0")
#pragma comment(linker, "/export:WinHttpQueryAuthSchemes=_Export_WinHttpQueryAuthSchemes@0")
#pragma comment(linker, "/export:WinHttpQueryDataAvailable=_Export_WinHttpQueryDataAvailable@0")
#pragma comment(linker, "/export:WinHttpQueryHeaders=_Export_WinHttpQueryHeaders@0")
#pragma comment(linker, "/export:WinHttpQueryOption=_Export_WinHttpQueryOption@0")
#pragma comment(linker, "/export:WinHttpReadData=_Export_WinHttpReadData@0")
#pragma comment(linker, "/export:WinHttpReadProxySettings=_Export_WinHttpReadProxySettings@0")
#pragma comment(linker, "/export:WinHttpReceiveResponse=_Export_WinHttpReceiveResponse@0")
#pragma comment(linker, "/export:WinHttpResetAutoProxy=_Export_WinHttpResetAutoProxy@0")
#pragma comment(linker, "/export:WinHttpSendRequest=_Export_WinHttpSendRequest@0")
#pragma comment(linker, "/export:WinHttpSetCredentials=_Export_WinHttpSetCredentials@0")
#pragma comment(linker, "/export:WinHttpSetDefaultProxyConfiguration=_Export_WinHttpSetDefaultProxyConfiguration@0")
#pragma comment(linker, "/export:WinHttpSetOption=_Export_WinHttpSetOption@0")
#pragma comment(linker, "/export:WinHttpSetStatusCallback=_Export_WinHttpSetStatusCallback@0")
#pragma comment(linker, "/export:WinHttpSetTimeouts=_Export_WinHttpSetTimeouts@0")
#pragma comment(linker, "/export:WinHttpTimeFromSystemTime=_Export_WinHttpTimeFromSystemTime@0")
#pragma comment(linker, "/export:WinHttpTimeToSystemTime=_Export_WinHttpTimeToSystemTime@0")
#pragma comment(linker, "/export:WinHttpWebSocketClose=_Export_WinHttpWebSocketClose@0")
#pragma comment(linker, "/export:WinHttpWebSocketCompleteUpgrade=_Export_WinHttpWebSocketCompleteUpgrade@0")
#pragma comment(linker, "/export:WinHttpWebSocketQueryCloseStatus=_Export_WinHttpWebSocketQueryCloseStatus@0")
#pragma comment(linker, "/export:WinHttpWebSocketReceive=_Export_WinHttpWebSocketReceive@0")
#pragma comment(linker, "/export:WinHttpWebSocketSend=_Export_WinHttpWebSocketSend@0")
#pragma comment(linker, "/export:WinHttpWebSocketShutdown=_Export_WinHttpWebSocketShutdown@0")
#pragma comment(linker, "/export:WinHttpWriteData=_Export_WinHttpWriteData@0")
#pragma comment(linker, "/export:WinHttpWriteProxySettings=_Export_WinHttpWriteProxySettings@0")
#pragma comment(linker, "/export:auxGetDevCapsA=_Export_auxGetDevCapsA@0")
#pragma comment(linker, "/export:auxGetDevCapsW=_Export_auxGetDevCapsW@0")
#pragma comment(linker, "/export:auxGetNumDevs=_Export_auxGetNumDevs@0")
#pragma comment(linker, "/export:auxGetVolume=_Export_auxGetVolume@0")
#pragma comment(linker, "/export:auxOutMessage=_Export_auxOutMessage@0")
#pragma comment(linker, "/export:auxSetVolume=_Export_auxSetVolume@0")
#pragma comment(linker, "/export:joyConfigChanged=_Export_joyConfigChanged@0")
#pragma comment(linker, "/export:joyGetDevCapsA=_Export_joyGetDevCapsA@0")
#pragma comment(linker, "/export:joyGetDevCapsW=_Export_joyGetDevCapsW@0")
#pragma comment(linker, "/export:joyGetNumDevs=_Export_joyGetNumDevs@0")
#pragma comment(linker, "/export:joyGetPos=_Export_joyGetPos@0")
#pragma comment(linker, "/export:joyGetPosEx=_Export_joyGetPosEx@0")
#pragma comment(linker, "/export:joyGetThreshold=_Export_joyGetThreshold@0")
#pragma comment(linker, "/export:joyReleaseCapture=_Export_joyReleaseCapture@0")
#pragma comment(linker, "/export:joySetCapture=_Export_joySetCapture@0")
#pragma comment(linker, "/export:joySetThreshold=_Export_joySetThreshold@0")
#pragma comment(linker, "/export:mciDriverNotify=_Export_mciDriverNotify@0")
#pragma comment(linker, "/export:mciDriverYield=_Export_mciDriverYield@0")
#pragma comment(linker, "/export:mciExecute=_Export_mciExecute@0")
#pragma comment(linker, "/export:mciFreeCommandResource=_Export_mciFreeCommandResource@0")
#pragma comment(linker, "/export:mciGetCreatorTask=_Export_mciGetCreatorTask@0")
#pragma comment(linker, "/export:mciGetDeviceIDA=_Export_mciGetDeviceIDA@0")
#pragma comment(linker, "/export:mciGetDeviceIDFromElementIDA=_Export_mciGetDeviceIDFromElementIDA@0")
#pragma comment(linker, "/export:mciGetDeviceIDFromElementIDW=_Export_mciGetDeviceIDFromElementIDW@0")
#pragma comment(linker, "/export:mciGetDeviceIDW=_Export_mciGetDeviceIDW@0")
#pragma comment(linker, "/export:mciGetDriverData=_Export_mciGetDriverData@0")
#pragma comment(linker, "/export:mciGetErrorStringA=_Export_mciGetErrorStringA@0")
#pragma comment(linker, "/export:mciGetErrorStringW=_Export_mciGetErrorStringW@0")
#pragma comment(linker, "/export:mciGetYieldProc=_Export_mciGetYieldProc@0")
#pragma comment(linker, "/export:mciLoadCommandResource=_Export_mciLoadCommandResource@0")
#pragma comment(linker, "/export:mciSendCommandA=_Export_mciSendCommandA@0")
#pragma comment(linker, "/export:mciSendCommandW=_Export_mciSendCommandW@0")
#pragma comment(linker, "/export:mciSendStringA=_Export_mciSendStringA@0")
#pragma comment(linker, "/export:mciSendStringW=_Export_mciSendStringW@0")
#pragma comment(linker, "/export:mciSetDriverData=_Export_mciSetDriverData@0")
#pragma comment(linker, "/export:mciSetYieldProc=_Export_mciSetYieldProc@0")
#pragma comment(linker, "/export:midiConnect=_Export_midiConnect@0")
#pragma comment(linker, "/export:midiDisconnect=_Export_midiDisconnect@0")
#pragma comment(linker, "/export:midiInAddBuffer=_Export_midiInAddBuffer@0")
#pragma comment(linker, "/export:midiInClose=_Export_midiInClose@0")
#pragma comment(linker, "/export:midiInGetDevCapsA=_Export_midiInGetDevCapsA@0")
#pragma comment(linker, "/export:midiInGetDevCapsW=_Export_midiInGetDevCapsW@0")
#pragma comment(linker, "/export:midiInGetErrorTextA=_Export_midiInGetErrorTextA@0")
#pragma comment(linker, "/export:midiInGetErrorTextW=_Export_midiInGetErrorTextW@0")
#pragma comment(linker, "/export:midiInGetID=_Export_midiInGetID@0")
#pragma comment(linker, "/export:midiInGetNumDevs=_Export_midiInGetNumDevs@0")
#pragma comment(linker, "/export:midiInMessage=_Export_midiInMessage@0")
#pragma comment(linker, "/export:midiInOpen=_Export_midiInOpen@0")
#pragma comment(linker, "/export:midiInPrepareHeader=_Export_midiInPrepareHeader@0")
#pragma comment(linker, "/export:midiInReset=_Export_midiInReset@0")
#pragma comment(linker, "/export:midiInStart=_Export_midiInStart@0")
#pragma comment(linker, "/export:midiInStop=_Export_midiInStop@0")
#pragma comment(linker, "/export:midiInUnprepareHeader=_Export_midiInUnprepareHeader@0")
#pragma comment(linker, "/export:midiOutCacheDrumPatches=_Export_midiOutCacheDrumPatches@0")
#pragma comment(linker, "/export:midiOutCachePatches=_Export_midiOutCachePatches@0")
#pragma comment(linker, "/export:midiOutClose=_Export_midiOutClose@0")
#pragma comment(linker, "/export:midiOutGetDevCapsA=_Export_midiOutGetDevCapsA@0")
#pragma comment(linker, "/export:midiOutGetDevCapsW=_Export_midiOutGetDevCapsW@0")
#pragma comment(linker, "/export:midiOutGetErrorTextA=_Export_midiOutGetErrorTextA@0")
#pragma comment(linker, "/export:midiOutGetErrorTextW=_Export_midiOutGetErrorTextW@0")
#pragma comment(linker, "/export:midiOutGetID=_Export_midiOutGetID@0")
#pragma comment(linker, "/export:midiOutGetNumDevs=_Export_midiOutGetNumDevs@0")
#pragma comment(linker, "/export:midiOutGetVolume=_Export_midiOutGetVolume@0")
#pragma comment(linker, "/export:midiOutLongMsg=_Export_midiOutLongMsg@0")
#pragma comment(linker, "/export:midiOutMessage=_Export_midiOutMessage@0")
#pragma comment(linker, "/export:midiOutOpen=_Export_midiOutOpen@0")
#pragma comment(linker, "/export:midiOutPrepareHeader=_Export_midiOutPrepareHeader@0")
#pragma comment(linker, "/export:midiOutReset=_Export_midiOutReset@0")
#pragma comment(linker, "/export:midiOutSetVolume=_Export_midiOutSetVolume@0")
#pragma comment(linker, "/export:midiOutShortMsg=_Export_midiOutShortMsg@0")
#pragma comment(linker, "/export:midiOutUnprepareHeader=_Export_midiOutUnprepareHeader@0")
#pragma comment(linker, "/export:midiStreamClose=_Export_midiStreamClose@0")
#pragma comment(linker, "/export:midiStreamOpen=_Export_midiStreamOpen@0")
#pragma comment(linker, "/export:midiStreamOut=_Export_midiStreamOut@0")
#pragma comment(linker, "/export:midiStreamPause=_Export_midiStreamPause@0")
#pragma comment(linker, "/export:midiStreamPosition=_Export_midiStreamPosition@0")
#pragma comment(linker, "/export:midiStreamProperty=_Export_midiStreamProperty@0")
#pragma comment(linker, "/export:midiStreamRestart=_Export_midiStreamRestart@0")
#pragma comment(linker, "/export:midiStreamStop=_Export_midiStreamStop@0")
#pragma comment(linker, "/export:mixerClose=_Export_mixerClose@0")
#pragma comment(linker, "/export:mixerGetControlDetailsA=_Export_mixerGetControlDetailsA@0")
#pragma comment(linker, "/export:mixerGetControlDetailsW=_Export_mixerGetControlDetailsW@0")
#pragma comment(linker, "/export:mixerGetDevCapsA=_Export_mixerGetDevCapsA@0")
#pragma comment(linker, "/export:mixerGetDevCapsW=_Export_mixerGetDevCapsW@0")
#pragma comment(linker, "/export:mixerGetID=_Export_mixerGetID@0")
#pragma comment(linker, "/export:mixerGetLineControlsA=_Export_mixerGetLineControlsA@0")
#pragma comment(linker, "/export:mixerGetLineControlsW=_Export_mixerGetLineControlsW@0")
#pragma comment(linker, "/export:mixerGetLineInfoA=_Export_mixerGetLineInfoA@0")
#pragma comment(linker, "/export:mixerGetLineInfoW=_Export_mixerGetLineInfoW@0")
#pragma comment(linker, "/export:mixerGetNumDevs=_Export_mixerGetNumDevs@0")
#pragma comment(linker, "/export:mixerMessage=_Export_mixerMessage@0")
#pragma comment(linker, "/export:mixerOpen=_Export_mixerOpen@0")
#pragma comment(linker, "/export:mixerSetControlDetails=_Export_mixerSetControlDetails@0")
#pragma comment(linker, "/export:mmGetCurrentTask=_Export_mmGetCurrentTask@0")
#pragma comment(linker, "/export:mmTaskBlock=_Export_mmTaskBlock@0")
#pragma comment(linker, "/export:mmTaskCreate=_Export_mmTaskCreate@0")
#pragma comment(linker, "/export:mmTaskSignal=_Export_mmTaskSignal@0")
#pragma comment(linker, "/export:mmTaskYield=_Export_mmTaskYield@0")
#pragma comment(linker, "/export:mmioAdvance=_Export_mmioAdvance@0")
#pragma comment(linker, "/export:mmioAscend=_Export_mmioAscend@0")
#pragma comment(linker, "/export:mmioClose=_Export_mmioClose@0")
#pragma comment(linker, "/export:mmioCreateChunk=_Export_mmioCreateChunk@0")
#pragma comment(linker, "/export:mmioDescend=_Export_mmioDescend@0")
#pragma comment(linker, "/export:mmioFlush=_Export_mmioFlush@0")
#pragma comment(linker, "/export:mmioGetInfo=_Export_mmioGetInfo@0")
#pragma comment(linker, "/export:mmioInstallIOProc16=_Export_mmioInstallIOProc16@0")
#pragma comment(linker, "/export:mmioInstallIOProcA=_Export_mmioInstallIOProcA@0")
#pragma comment(linker, "/export:mmioInstallIOProcW=_Export_mmioInstallIOProcW@0")
#pragma comment(linker, "/export:mmioOpenA=_Export_mmioOpenA@0")
#pragma comment(linker, "/export:mmioOpenW=_Export_mmioOpenW@0")
#pragma comment(linker, "/export:mmioRead=_Export_mmioRead@0")
#pragma comment(linker, "/export:mmioRenameA=_Export_mmioRenameA@0")
#pragma comment(linker, "/export:mmioRenameW=_Export_mmioRenameW@0")
#pragma comment(linker, "/export:mmioSeek=_Export_mmioSeek@0")
#pragma comment(linker, "/export:mmioSendMessage=_Export_mmioSendMessage@0")
#pragma comment(linker, "/export:mmioSetBuffer=_Export_mmioSetBuffer@0")
#pragma comment(linker, "/export:mmioSetInfo=_Export_mmioSetInfo@0")
#pragma comment(linker, "/export:mmioStringToFOURCCA=_Export_mmioStringToFOURCCA@0")
#pragma comment(linker, "/export:mmioStringToFOURCCW=_Export_mmioStringToFOURCCW@0")
#pragma comment(linker, "/export:mmioWrite=_Export_mmioWrite@0")
#pragma comment(linker, "/export:mmsystemGetVersion=_Export_mmsystemGetVersion@0")
#pragma comment(linker, "/export:sndPlaySoundA=_Export_sndPlaySoundA@0")
#pragma comment(linker, "/export:sndPlaySoundW=_Export_sndPlaySoundW@0")
#pragma comment(linker, "/export:timeBeginPeriod=_Export_timeBeginPeriod@0")
#pragma comment(linker, "/export:timeEndPeriod=_Export_timeEndPeriod@0")
#pragma comment(linker, "/export:timeGetDevCaps=_Export_timeGetDevCaps@0")
#pragma comment(linker, "/export:timeGetSystemTime=_Export_timeGetSystemTime@0")
#pragma comment(linker, "/export:timeGetTime=_Export_timeGetTime@0")
#pragma comment(linker, "/export:timeKillEvent=_Export_timeKillEvent@0")
#pragma comment(linker, "/export:timeSetEvent=_Export_timeSetEvent@0")
#pragma comment(linker, "/export:waveInAddBuffer=_Export_waveInAddBuffer@0")
#pragma comment(linker, "/export:waveInClose=_Export_waveInClose@0")
#pragma comment(linker, "/export:waveInGetDevCapsA=_Export_waveInGetDevCapsA@0")
#pragma comment(linker, "/export:waveInGetDevCapsW=_Export_waveInGetDevCapsW@0")
#pragma comment(linker, "/export:waveInGetErrorTextA=_Export_waveInGetErrorTextA@0")
#pragma comment(linker, "/export:waveInGetErrorTextW=_Export_waveInGetErrorTextW@0")
#pragma comment(linker, "/export:waveInGetID=_Export_waveInGetID@0")
#pragma comment(linker, "/export:waveInGetNumDevs=_Export_waveInGetNumDevs@0")
#pragma comment(linker, "/export:waveInGetPosition=_Export_waveInGetPosition@0")
#pragma comment(linker, "/export:waveInMessage=_Export_waveInMessage@0")
#pragma comment(linker, "/export:waveInOpen=_Export_waveInOpen@0")
#pragma comment(linker, "/export:waveInPrepareHeader=_Export_waveInPrepareHeader@0")
#pragma comment(linker, "/export:waveInReset=_Export_waveInReset@0")
#pragma comment(linker, "/export:waveInStart=_Export_waveInStart@0")
#pragma comment(linker, "/export:waveInStop=_Export_waveInStop@0")
#pragma comment(linker, "/export:waveInUnprepareHeader=_Export_waveInUnprepareHeader@0")
#pragma comment(linker, "/export:waveOutBreakLoop=_Export_waveOutBreakLoop@0")
#pragma comment(linker, "/export:waveOutClose=_Export_waveOutClose@0")
#pragma comment(linker, "/export:waveOutGetDevCapsA=_Export_waveOutGetDevCapsA@0")
#pragma comment(linker, "/export:waveOutGetDevCapsW=_Export_waveOutGetDevCapsW@0")
#pragma comment(linker, "/export:waveOutGetErrorTextA=_Export_waveOutGetErrorTextA@0")
#pragma comment(linker, "/export:waveOutGetErrorTextW=_Export_waveOutGetErrorTextW@0")
#pragma comment(linker, "/export:waveOutGetID=_Export_waveOutGetID@0")
#pragma comment(linker, "/export:waveOutGetNumDevs=_Export_waveOutGetNumDevs@0")
#pragma comment(linker, "/export:waveOutGetPitch=_Export_waveOutGetPitch@0")
#pragma comment(linker, "/export:waveOutGetPlaybackRate=_Export_waveOutGetPlaybackRate@0")
#pragma comment(linker, "/export:waveOutGetPosition=_Export_waveOutGetPosition@0")
#pragma comment(linker, "/export:waveOutGetVolume=_Export_waveOutGetVolume@0")
#pragma comment(linker, "/export:waveOutMessage=_Export_waveOutMessage@0")
#pragma comment(linker, "/export:waveOutOpen=_Export_waveOutOpen@0")
#pragma comment(linker, "/export:waveOutPause=_Export_waveOutPause@0")
#pragma comment(linker, "/export:waveOutPrepareHeader=_Export_waveOutPrepareHeader@0")
#pragma comment(linker, "/export:waveOutReset=_Export_waveOutReset@0")
#pragma comment(linker, "/export:waveOutRestart=_Export_waveOutRestart@0")
#pragma comment(linker, "/export:waveOutSetPitch=_Export_waveOutSetPitch@0")
#pragma comment(linker, "/export:waveOutSetPlaybackRate=_Export_waveOutSetPlaybackRate@0")
#pragma comment(linker, "/export:waveOutSetVolume=_Export_waveOutSetVolume@0")
#pragma comment(linker, "/export:waveOutUnprepareHeader=_Export_waveOutUnprepareHeader@0")
#pragma comment(linker, "/export:waveOutWrite=_Export_waveOutWrite@0")
#endif



#pragma endregion


