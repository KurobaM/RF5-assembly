using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace nn.irsensor
{
	// Token: 0x02001523 RID: 5411
	[Token(Token = "0x2000ED6")]
	public static class ImageProcessor
	{
		// Token: 0x06007B13 RID: 31507
		[Token(Token = "0x6006731")]
		[Address(RVA = "0x34DC390", Offset = "0x34DC491", VA = "0x34DC390")]
		[PreserveSig]
		public static extern void Stop(IrCameraHandle handle);

		// Token: 0x06007B14 RID: 31508
		[Token(Token = "0x6006732")]
		[Address(RVA = "0x34DC3A0", Offset = "0x34DC4A1", VA = "0x34DC3A0")]
		[PreserveSig]
		public static extern void StopAsync(IrCameraHandle handle);

		// Token: 0x06007B15 RID: 31509
		[Token(Token = "0x6006733")]
		[Address(RVA = "0x34DC3B0", Offset = "0x34DC4B1", VA = "0x34DC3B0")]
		[PreserveSig]
		public static extern ImageProcessorStatus GetStatus(IrCameraHandle handle);
	}
}
