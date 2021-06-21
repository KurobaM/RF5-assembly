using System;
using Il2CppDummyDll;

namespace nn.hid
{
	// Token: 0x02001545 RID: 5445
	[Token(Token = "0x2000EF4")]
	public struct DebugPadState
	{
		// Token: 0x06007B9F RID: 31647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006791")]
		[Address(RVA = "0x366970", Offset = "0x366A71", VA = "0x366970", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0401BECB RID: 114379
		[Token(Token = "0x4018805")]
		[FieldOffset(Offset = "0x0")]
		public long samplingNumber;

		// Token: 0x0401BECC RID: 114380
		[Token(Token = "0x4018806")]
		[FieldOffset(Offset = "0x8")]
		public DebugPadAttribute attributes;

		// Token: 0x0401BECD RID: 114381
		[Token(Token = "0x4018807")]
		[FieldOffset(Offset = "0xC")]
		public DebugPadButton buttons;

		// Token: 0x0401BECE RID: 114382
		[Token(Token = "0x4018808")]
		[FieldOffset(Offset = "0x10")]
		public AnalogStickState analogStickR;

		// Token: 0x0401BECF RID: 114383
		[Token(Token = "0x4018809")]
		[FieldOffset(Offset = "0x18")]
		public AnalogStickState analogStickL;
	}
}
