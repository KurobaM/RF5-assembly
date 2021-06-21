using System;
using Il2CppDummyDll;

namespace nn.hid
{
	// Token: 0x02001556 RID: 5462
	[Token(Token = "0x2000F03")]
	public struct NpadStateArrayItem
	{
		// Token: 0x06007BDD RID: 31709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067B9")]
		[Address(RVA = "0x383090", Offset = "0x383191", VA = "0x383090", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0401BF41 RID: 114497
		[Token(Token = "0x4018873")]
		[FieldOffset(Offset = "0x0")]
		public long samplingNumber;

		// Token: 0x0401BF42 RID: 114498
		[Token(Token = "0x4018874")]
		[FieldOffset(Offset = "0x8")]
		public NpadButton buttons;

		// Token: 0x0401BF43 RID: 114499
		[Token(Token = "0x4018875")]
		[FieldOffset(Offset = "0x10")]
		public AnalogStickState analogStickL;

		// Token: 0x0401BF44 RID: 114500
		[Token(Token = "0x4018876")]
		[FieldOffset(Offset = "0x18")]
		public AnalogStickState analogStickR;

		// Token: 0x0401BF45 RID: 114501
		[Token(Token = "0x4018877")]
		[FieldOffset(Offset = "0x20")]
		public NpadAttribute attributes;
	}
}
