using System;
using Il2CppDummyDll;

namespace Common
{
	// Token: 0x020011C9 RID: 4553
	[Token(Token = "0x2000B9E")]
	[Serializable]
	public class VariableString : Variable<string>
	{
		// Token: 0x06007125 RID: 28965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DE1")]
		[Address(RVA = "0x20DBDF0", Offset = "0x20DBEF1", VA = "0x20DBDF0")]
		public VariableString(string value)
		{
		}

		// Token: 0x06007126 RID: 28966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DE2")]
		[Address(RVA = "0x20DBE60", Offset = "0x20DBF61", VA = "0x20DBE60", Slot = "7")]
		public override string GetString()
		{
			return null;
		}
	}
}
