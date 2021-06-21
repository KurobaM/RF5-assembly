using System;
using Il2CppDummyDll;

namespace nn.irsensor
{
	// Token: 0x0200152C RID: 5420
	[Token(Token = "0x2000EDF")]
	public struct ImageTransferProcessorState
	{
		// Token: 0x0401BE31 RID: 114225
		[Token(Token = "0x40187AB")]
		[FieldOffset(Offset = "0x0")]
		public long samplingNumber;

		// Token: 0x0401BE32 RID: 114226
		[Token(Token = "0x40187AC")]
		[FieldOffset(Offset = "0x8")]
		public IrCameraAmbientNoiseLevel ambientNoiseLevel;

		// Token: 0x0401BE33 RID: 114227
		[Token(Token = "0x40187AD")]
		[FieldOffset(Offset = "0xC")]
		private byte _reserved0;

		// Token: 0x0401BE34 RID: 114228
		[Token(Token = "0x40187AE")]
		[FieldOffset(Offset = "0xD")]
		private byte _reserved1;

		// Token: 0x0401BE35 RID: 114229
		[Token(Token = "0x40187AF")]
		[FieldOffset(Offset = "0xE")]
		private byte _reserved2;

		// Token: 0x0401BE36 RID: 114230
		[Token(Token = "0x40187B0")]
		[FieldOffset(Offset = "0xF")]
		private byte _reserved3;
	}
}
