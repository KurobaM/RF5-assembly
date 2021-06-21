using System;
using Il2CppDummyDll;

namespace nn.hid
{
	// Token: 0x02001557 RID: 5463
	[Token(Token = "0x2000F04")]
	public struct NpadFullKeyState
	{
		// Token: 0x06007BDE RID: 31710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067BA")]
		[Address(RVA = "0x3671D0", Offset = "0x3672D1", VA = "0x3671D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0401BF46 RID: 114502
		[Token(Token = "0x4018878")]
		[FieldOffset(Offset = "0x0")]
		public long samplingNumber;

		// Token: 0x0401BF47 RID: 114503
		[Token(Token = "0x4018879")]
		[FieldOffset(Offset = "0x8")]
		public NpadButton buttons;

		// Token: 0x0401BF48 RID: 114504
		[Token(Token = "0x401887A")]
		[FieldOffset(Offset = "0x10")]
		public AnalogStickState analogStickL;

		// Token: 0x0401BF49 RID: 114505
		[Token(Token = "0x401887B")]
		[FieldOffset(Offset = "0x18")]
		public AnalogStickState analogStickR;

		// Token: 0x0401BF4A RID: 114506
		[Token(Token = "0x401887C")]
		[FieldOffset(Offset = "0x20")]
		public NpadAttribute attributes;
	}
}
