namespace Steamworks
{
	public enum EBroadcastUploadResult
	{
		k_EBroadcastUploadResultNone = 0,
		k_EBroadcastUploadResultOK = 1,
		k_EBroadcastUploadResultInitFailed = 2,
		k_EBroadcastUploadResultFrameFailed = 3,
		k_EBroadcastUploadResultTimeout = 4,
		k_EBroadcastUploadResultBandwidthExceeded = 5,
		k_EBroadcastUploadResultLowFPS = 6,
		k_EBroadcastUploadResultMissingKeyFrames = 7,
		k_EBroadcastUploadResultNoConnection = 8,
		k_EBroadcastUploadResultRelayFailed = 9,
		k_EBroadcastUploadResultSettingsChanged = 10,
		k_EBroadcastUploadResultMissingAudio = 11,
		k_EBroadcastUploadResultTooFarBehind = 12,
		k_EBroadcastUploadResultTranscodeBehind = 13,
		k_EBroadcastUploadResultNotAllowedToPlay = 14,
		k_EBroadcastUploadResultBusy = 15,
		k_EBroadcastUploadResultBanned = 16,
		k_EBroadcastUploadResultAlreadyActive = 17,
		k_EBroadcastUploadResultForcedOff = 18,
		k_EBroadcastUploadResultAudioBehind = 19,
		k_EBroadcastUploadResultShutdown = 20,
		k_EBroadcastUploadResultDisconnect = 21,
		k_EBroadcastUploadResultVideoInitFailed = 22,
		k_EBroadcastUploadResultAudioInitFailed = 23
	}
}
