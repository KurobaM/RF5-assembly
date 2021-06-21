using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200069D RID: 1693
[Token(Token = "0x20004BF")]
[Serializable]
public struct MonsterDropItemDataTable
{
	// Token: 0x0600293F RID: 10559 RVA: 0x00010290 File Offset: 0x0000E490
	[Token(Token = "0x60022DF")]
	[Address(RVA = "0x1E60060", Offset = "0x1E60161", VA = "0x1E60060")]
	public static MonsterDropItemDataTable GetDataTable(MonsterDropItemDataID dataID)
	{
		return default(MonsterDropItemDataTable);
	}

	// Token: 0x06002940 RID: 10560 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022E0")]
	[Address(RVA = "0x1E60220", Offset = "0x1E60321", VA = "0x1E60220")]
	private static void LoadData()
	{
	}

	// Token: 0x04007171 RID: 29041
	[Token(Token = "0x400696D")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public MonsterDropItemDataID DataID;

	// Token: 0x04007172 RID: 29042
	[Token(Token = "0x400696E")]
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	public List<DropItemParam> DropItemParamList;

	// Token: 0x04007173 RID: 29043
	[Token(Token = "0x400696F")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public List<DropItemParam> HandcuffsDropItemParamList;

	// Token: 0x04007174 RID: 29044
	[Token(Token = "0x4006970")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<DropItemParam> BonusDropItemParamList;

	// Token: 0x04007175 RID: 29045
	[Token(Token = "0x4006971")]
	[FieldOffset(Offset = "0x0")]
	private static bool IsLoad;

	// Token: 0x04007176 RID: 29046
	[Token(Token = "0x4006972")]
	[FieldOffset(Offset = "0x8")]
	private static MonsterDropItemDataTableArray _MonsterDropItemDataTableArray;
}
