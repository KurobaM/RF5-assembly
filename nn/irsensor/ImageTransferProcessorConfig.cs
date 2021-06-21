using System;
using Il2CppDummyDll;

namespace nn.irsensor
{
	// Token: 0x0200152A RID: 5418
	[Token(Token = "0x2000EDD")]
	public struct ImageTransferProcessorConfig
	{
		// Token: 0x0401BE29 RID: 114217
		[Token(Token = "0x40187A3")]
		[FieldOffset(Offset = "0x0")]
		public IrCameraConfig irCameraConfig;

		// Token: 0x0401BE2A RID: 114218
		[Token(Token = "0x40187A4")]
		[FieldOffset(Offset = "0x18")]
		public ImageTransferProcessorFormat format;
	}
}
