using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using nn.hid;

namespace nn.irsensor
{
	// Token: 0x02001524 RID: 5412
	[Token(Token = "0x2000ED7")]
	public static class IrCamera
	{
		// Token: 0x06007B16 RID: 31510
		[Token(Token = "0x6006734")]
		[Address(RVA = "0x34DCB70", Offset = "0x34DCC71", VA = "0x34DCB70")]
		[PreserveSig]
		public static extern IrCameraHandle GetHandle(NpadId npadId);

		// Token: 0x06007B17 RID: 31511
		[Token(Token = "0x6006735")]
		[Address(RVA = "0x34DCB90", Offset = "0x34DCC91", VA = "0x34DCB90")]
		[PreserveSig]
		public static extern void Initialize(IrCameraHandle handle);

		// Token: 0x06007B18 RID: 31512
		[Token(Token = "0x6006736")]
		[Address(RVA = "0x34DCBA0", Offset = "0x34DCCA1", VA = "0x34DCBA0")]
		[PreserveSig]
		public static extern void Finalize(IrCameraHandle handle);

		// Token: 0x06007B19 RID: 31513
		[Token(Token = "0x6006737")]
		[Address(RVA = "0x34DCBB0", Offset = "0x34DCCB1", VA = "0x34DCBB0")]
		[PreserveSig]
		public static extern IrCameraStatus GetStatus(IrCameraHandle handle);

		// Token: 0x06007B1A RID: 31514
		[Token(Token = "0x6006738")]
		[Address(RVA = "0x34DCBC0", Offset = "0x34DCCC1", VA = "0x34DCBC0")]
		[PreserveSig]
		public static extern Result CheckFirmwareUpdateNecessity(ref bool pOutIsUpdateNeeded, IrCameraHandle handle);

		// Token: 0x0401BDFC RID: 114172
		[Token(Token = "0x4018776")]
		public const int IntensityMax = 255;

		// Token: 0x0401BDFD RID: 114173
		[Token(Token = "0x4018777")]
		public const int ImageWidth = 320;

		// Token: 0x0401BDFE RID: 114174
		[Token(Token = "0x4018778")]
		public const int ImageHeight = 240;

		// Token: 0x0401BDFF RID: 114175
		[Token(Token = "0x4018779")]
		public const int GainMin = 1;

		// Token: 0x0401BE00 RID: 114176
		[Token(Token = "0x401877A")]
		public const int GainMax = 16;
	}
}
