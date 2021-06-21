using System;
using Il2CppDummyDll;

namespace Loader
{
	// Token: 0x02001016 RID: 4118
	[Token(Token = "0x2000A6D")]
	[Serializable]
	public class ASSET_TABLE
	{
		// Token: 0x060067D1 RID: 26577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600566A")]
		[Address(RVA = "0x2310AD0", Offset = "0x2310BD1", VA = "0x2310AD0")]
		public ASSET_TABLE()
		{
		}

		// Token: 0x0400C739 RID: 51001
		[Token(Token = "0x40093D1")]
		[FieldOffset(Offset = "0x10")]
		public int Id;

		// Token: 0x0400C73A RID: 51002
		[Token(Token = "0x40093D2")]
		[FieldOffset(Offset = "0x14")]
		public bool Region;

		// Token: 0x0400C73B RID: 51003
		[Token(Token = "0x40093D3")]
		[FieldOffset(Offset = "0x18")]
		public string Label;
	}
}
