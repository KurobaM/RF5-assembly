using System;
using Il2CppDummyDll;

namespace nn.hid
{
	// Token: 0x02001565 RID: 5477
	[Token(Token = "0x2000F12")]
	public struct NpadJoyRightState
	{
		// Token: 0x06007C03 RID: 31747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067DF")]
		[Address(RVA = "0x382FC0", Offset = "0x3830C1", VA = "0x382FC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0401BF6C RID: 114540
		[Token(Token = "0x401889E")]
		[FieldOffset(Offset = "0x0")]
		public long samplingNumber;

		// Token: 0x0401BF6D RID: 114541
		[Token(Token = "0x401889F")]
		[FieldOffset(Offset = "0x8")]
		public NpadButton buttons;

		// Token: 0x0401BF6E RID: 114542
		[Token(Token = "0x40188A0")]
		[FieldOffset(Offset = "0x10")]
		public AnalogStickState analogStickL;

		// Token: 0x0401BF6F RID: 114543
		[Token(Token = "0x40188A1")]
		[FieldOffset(Offset = "0x18")]
		public AnalogStickState analogStickR;

		// Token: 0x0401BF70 RID: 114544
		[Token(Token = "0x40188A2")]
		[FieldOffset(Offset = "0x20")]
		public NpadAttribute attributes;
	}
}
