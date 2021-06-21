using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace nn.audio
{
	// Token: 0x020015E5 RID: 5605
	[Token(Token = "0x2000F6B")]
	public static class AudioDevice
	{
		// Token: 0x06007FAA RID: 32682
		[Token(Token = "0x60069FE")]
		[Address(RVA = "0x2852870", Offset = "0x2852971", VA = "0x2852870")]
		[PreserveSig]
		public static extern bool SetOutputVolume(AudioDevice.AudioDeviceName deviceName, float volume);

		// Token: 0x0401C15E RID: 115038
		[Token(Token = "0x40189A0")]
		public const float OutputVolumeMax = 128f;

		// Token: 0x0401C15F RID: 115039
		[Token(Token = "0x40189A1")]
		public const float OutputVolumeMin = 0f;

		// Token: 0x020015E6 RID: 5606
		[Token(Token = "0x20015CC")]
		public enum AudioDeviceName
		{
			// Token: 0x0401C161 RID: 115041
			[Token(Token = "0x401C37D")]
			StereoJackOutput,
			// Token: 0x0401C162 RID: 115042
			[Token(Token = "0x401C37E")]
			BuiltInSpeakerOutput,
			// Token: 0x0401C163 RID: 115043
			[Token(Token = "0x401C37F")]
			TvOutput,
			// Token: 0x0401C164 RID: 115044
			[Token(Token = "0x401C380")]
			UsbDeviceOutput
		}
	}
}
