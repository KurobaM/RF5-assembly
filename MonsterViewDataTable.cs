using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003A8 RID: 936
[Token(Token = "0x20002CF")]
public class MonsterViewDataTable : ScriptableObject
{
	// Token: 0x06001735 RID: 5941 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014A0")]
	[Address(RVA = "0x1E0F090", Offset = "0x1E0F191", VA = "0x1E0F090")]
	public MonsterViewDataTable()
	{
	}

	// Token: 0x04001051 RID: 4177
	[Token(Token = "0x4000D03")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public MonsterSetDataTable[] MonsterSetDataTables;
}
