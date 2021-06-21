using System;
using Il2CppDummyDll;

namespace nn.irsensor
{
	// Token: 0x0200152B RID: 5419
	[Token(Token = "0x2000EDE")]
	public struct ImageTransferProcessorExConfig
	{
		// Token: 0x0401BE2B RID: 114219
		[Token(Token = "0x40187A5")]
		[FieldOffset(Offset = "0x0")]
		public IrCameraConfig irCameraConfig;

		// Token: 0x0401BE2C RID: 114220
		[Token(Token = "0x40187A6")]
		[FieldOffset(Offset = "0x18")]
		public ImageTransferProcessorFormat origFormat;

		// Token: 0x0401BE2D RID: 114221
		[Token(Token = "0x40187A7")]
		[FieldOffset(Offset = "0x1C")]
		public ImageTransferProcessorFormat trimmingFormat;

		// Token: 0x0401BE2E RID: 114222
		[Token(Token = "0x40187A8")]
		[FieldOffset(Offset = "0x20")]
		public short trimmingStartX;

		// Token: 0x0401BE2F RID: 114223
		[Token(Token = "0x40187A9")]
		[FieldOffset(Offset = "0x22")]
		public short trimmingStartY;

		// Token: 0x0401BE30 RID: 114224
		[Token(Token = "0x40187AA")]
		[FieldOffset(Offset = "0x24")]
		public bool isExternalLightFilterEnabled;
	}
}
