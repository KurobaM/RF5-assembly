using System;
using Il2CppDummyDll;

namespace nn.account
{
	// Token: 0x020015EF RID: 5615
	[Token(Token = "0x2000F72")]
	public struct UserHandle
	{
		// Token: 0x0600800A RID: 32778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A48")]
		[Address(RVA = "0x363F10", Offset = "0x364011", VA = "0x363F10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0401C17E RID: 115070
		[Token(Token = "0x40189AF")]
		[FieldOffset(Offset = "0x0")]
		public ulong _data0;

		// Token: 0x0401C17F RID: 115071
		[Token(Token = "0x40189B0")]
		[FieldOffset(Offset = "0x8")]
		public ulong _data1;

		// Token: 0x0401C180 RID: 115072
		[Token(Token = "0x40189B1")]
		[FieldOffset(Offset = "0x10")]
		public ulong _context;
	}
}
