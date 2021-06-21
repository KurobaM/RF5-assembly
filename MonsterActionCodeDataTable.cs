using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000093 RID: 147
[Token(Token = "0x2000071")]
[Serializable]
public class MonsterActionCodeDataTable
{
	// Token: 0x060002DC RID: 732 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600022D")]
	[Address(RVA = "0x1D832A0", Offset = "0x1D833A1", VA = "0x1D832A0")]
	public MonsterActionCodeDataTable()
	{
	}

	// Token: 0x04000210 RID: 528
	[Token(Token = "0x40001A5")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public string ActionCodeDataName;

	// Token: 0x04000211 RID: 529
	[Token(Token = "0x40001A6")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public ActionCommandDataTable[] ActionCommandDataTables;
}
