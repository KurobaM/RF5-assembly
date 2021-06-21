using System;
using Il2CppDummyDll;

namespace nn.account
{
	// Token: 0x020015F0 RID: 5616
	[Token(Token = "0x2000F73")]
	public struct Nickname
	{
		// Token: 0x0600800B RID: 32779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A49")]
		[Address(RVA = "0x363CE0", Offset = "0x363DE1", VA = "0x363CE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0401C181 RID: 115073
		[Token(Token = "0x40189B2")]
		public const int NameBytesMax = 32;

		// Token: 0x0401C182 RID: 115074
		[Token(Token = "0x40189B3")]
		[FieldOffset(Offset = "0x0")]
		public string name;
	}
}
