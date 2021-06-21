using System;
using Il2CppDummyDll;

namespace nn.hid
{
	// Token: 0x02001559 RID: 5465
	[Token(Token = "0x2000F06")]
	public struct NpadHandheldState
	{
		// Token: 0x06007BE3 RID: 31715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067BF")]
		[Address(RVA = "0x3671E0", Offset = "0x3672E1", VA = "0x3671E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0401BF4B RID: 114507
		[Token(Token = "0x401887D")]
		[FieldOffset(Offset = "0x0")]
		public long samplingNumber;

		// Token: 0x0401BF4C RID: 114508
		[Token(Token = "0x401887E")]
		[FieldOffset(Offset = "0x8")]
		public NpadButton buttons;

		// Token: 0x0401BF4D RID: 114509
		[Token(Token = "0x401887F")]
		[FieldOffset(Offset = "0x10")]
		public AnalogStickState analogStickL;

		// Token: 0x0401BF4E RID: 114510
		[Token(Token = "0x4018880")]
		[FieldOffset(Offset = "0x18")]
		public AnalogStickState analogStickR;

		// Token: 0x0401BF4F RID: 114511
		[Token(Token = "0x4018881")]
		[FieldOffset(Offset = "0x20")]
		public NpadAttribute attributes;
	}
}
