using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Serialize
{
	// Token: 0x020011BE RID: 4542
	[Token(Token = "0x2000B94")]
	[Attribute(Name = "MessagePackObjectAttribute", RVA = "0x14A1F0", Offset = "0x14A2F1")]
	public class KeyAndValue<TKey, TValue>
	{
		// Token: 0x060070FE RID: 28926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DBD")]
		public KeyAndValue(TKey key, TValue value)
		{
		}

		// Token: 0x060070FF RID: 28927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DBE")]
		public KeyAndValue(KeyValuePair<TKey, TValue> pair)
		{
		}

		// Token: 0x040182ED RID: 99053
		[Token(Token = "0x4014D5B")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "KeyAttribute", RVA = "0x181890", Offset = "0x181991")]
		public TKey Key;

		// Token: 0x040182EE RID: 99054
		[Token(Token = "0x4014D5C")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "KeyAttribute", RVA = "0x1818B0", Offset = "0x1819B1")]
		public TValue Value;
	}
}
