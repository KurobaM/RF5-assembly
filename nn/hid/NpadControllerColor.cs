using System;
using Il2CppDummyDll;
using nn.util;

namespace nn.hid
{
	// Token: 0x02001553 RID: 5459
	[Token(Token = "0x2000F00")]
	public struct NpadControllerColor
	{
		// Token: 0x06007BC6 RID: 31686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067A2")]
		[Address(RVA = "0x367130", Offset = "0x367231", VA = "0x367130", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0401BF38 RID: 114488
		[Token(Token = "0x401886A")]
		[FieldOffset(Offset = "0x0")]
		public Color4u8 main;

		// Token: 0x0401BF39 RID: 114489
		[Token(Token = "0x401886B")]
		[FieldOffset(Offset = "0x4")]
		public Color4u8 sub;
	}
}
