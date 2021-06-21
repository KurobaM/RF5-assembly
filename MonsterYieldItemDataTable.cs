using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020006A3 RID: 1699
[Token(Token = "0x20004C5")]
public struct MonsterYieldItemDataTable
{
	// Token: 0x0600294F RID: 10575 RVA: 0x00010308 File Offset: 0x0000E508
	[Token(Token = "0x60022EF")]
	[Address(RVA = "0x1E0F2C0", Offset = "0x1E0F3C1", VA = "0x1E0F2C0")]
	public static MonsterYieldItemDataTable GetDataTable(MonsterYieldItemDataID dataID)
	{
		return default(MonsterYieldItemDataTable);
	}

	// Token: 0x0400718F RID: 29071
	[Token(Token = "0x400698B")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public MonsterYieldItemDataID DataID;

	// Token: 0x04007190 RID: 29072
	[Token(Token = "0x400698C")]
	[FieldOffset(Offset = "0x4")]
	[SerializeField]
	public int YieldPercent;

	// Token: 0x04007191 RID: 29073
	[Token(Token = "0x400698D")]
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	private List<YieldItemParam> YieldItemParamList;

	// Token: 0x04007192 RID: 29074
	[Token(Token = "0x400698E")]
	[FieldOffset(Offset = "0x0")]
	private static MonsterYieldItemDataTableArray _MonsterYieldItemDataTableArray;
}
