using System;
using Il2CppDummyDll;

namespace nn.hid
{
	// Token: 0x02001561 RID: 5473
	[Token(Token = "0x2000F0E")]
	public struct NpadJoyDualState
	{
		// Token: 0x06007BF9 RID: 31737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067D5")]
		[Address(RVA = "0x382FA0", Offset = "0x3830A1", VA = "0x382FA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0401BF62 RID: 114530
		[Token(Token = "0x4018894")]
		[FieldOffset(Offset = "0x0")]
		public long samplingNumber;

		// Token: 0x0401BF63 RID: 114531
		[Token(Token = "0x4018895")]
		[FieldOffset(Offset = "0x8")]
		public NpadButton buttons;

		// Token: 0x0401BF64 RID: 114532
		[Token(Token = "0x4018896")]
		[FieldOffset(Offset = "0x10")]
		public AnalogStickState analogStickL;

		// Token: 0x0401BF65 RID: 114533
		[Token(Token = "0x4018897")]
		[FieldOffset(Offset = "0x18")]
		public AnalogStickState analogStickR;

		// Token: 0x0401BF66 RID: 114534
		[Token(Token = "0x4018898")]
		[FieldOffset(Offset = "0x20")]
		public NpadAttribute attributes;
	}
}
