using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000085 RID: 133
[Token(Token = "0x2000066")]
[Serializable]
public class ActionCodeDataTableArray : ScriptableObject
{
	// Token: 0x0600025B RID: 603 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000216")]
	[Address(RVA = "0x1FD5D10", Offset = "0x1FD5E11", VA = "0x1FD5D10")]
	public ActionCodeDataTableArray()
	{
	}

	// Token: 0x0400019E RID: 414
	[Token(Token = "0x4000137")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public ActionCodeDataTable[] ActionCodeDataTables;
}
