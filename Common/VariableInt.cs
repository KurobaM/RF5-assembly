using System;
using Il2CppDummyDll;

namespace Common
{
	// Token: 0x020011C7 RID: 4551
	[Token(Token = "0x2000B9C")]
	[Serializable]
	public class VariableInt : Variable<int>
	{
		// Token: 0x06007121 RID: 28961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DDD")]
		[Address(RVA = "0x20DBD70", Offset = "0x20DBE71", VA = "0x20DBD70")]
		public VariableInt(int value)
		{
		}

		// Token: 0x06007122 RID: 28962 RVA: 0x00026FB8 File Offset: 0x000251B8
		[Token(Token = "0x6005DDE")]
		[Address(RVA = "0x20DBDE0", Offset = "0x20DBEE1", VA = "0x20DBDE0", Slot = "5")]
		public override int GetInt()
		{
			return 0;
		}
	}
}
