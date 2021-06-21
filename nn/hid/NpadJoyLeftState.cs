using System;
using Il2CppDummyDll;

namespace nn.hid
{
	// Token: 0x02001563 RID: 5475
	[Token(Token = "0x2000F10")]
	public struct NpadJoyLeftState
	{
		// Token: 0x06007BFE RID: 31742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067DA")]
		[Address(RVA = "0x382FB0", Offset = "0x3830B1", VA = "0x382FB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0401BF67 RID: 114535
		[Token(Token = "0x4018899")]
		[FieldOffset(Offset = "0x0")]
		public long samplingNumber;

		// Token: 0x0401BF68 RID: 114536
		[Token(Token = "0x401889A")]
		[FieldOffset(Offset = "0x8")]
		public NpadButton buttons;

		// Token: 0x0401BF69 RID: 114537
		[Token(Token = "0x401889B")]
		[FieldOffset(Offset = "0x10")]
		public AnalogStickState analogStickL;

		// Token: 0x0401BF6A RID: 114538
		[Token(Token = "0x401889C")]
		[FieldOffset(Offset = "0x18")]
		public AnalogStickState analogStickR;

		// Token: 0x0401BF6B RID: 114539
		[Token(Token = "0x401889D")]
		[FieldOffset(Offset = "0x20")]
		public NpadAttribute attributes;
	}
}
