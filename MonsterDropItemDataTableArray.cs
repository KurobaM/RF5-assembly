using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200069E RID: 1694
[Token(Token = "0x20004C0")]
[Serializable]
public class MonsterDropItemDataTableArray : ScriptableObject
{
	// Token: 0x06002942 RID: 10562 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022E2")]
	[Address(RVA = "0x1E60360", Offset = "0x1E60461", VA = "0x1E60360")]
	public MonsterDropItemDataTableArray()
	{
	}

	// Token: 0x04007177 RID: 29047
	[Token(Token = "0x4006973")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public MonsterDropItemDataTable[] DataTables;
}
