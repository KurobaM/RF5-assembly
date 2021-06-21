using System;
using DataTable;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200038F RID: 911
[Token(Token = "0x20002B7")]
[Serializable]
public class ItemStrengtheningDataTable
{
	// Token: 0x06001707 RID: 5895 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001473")]
	[Address(RVA = "0x223FE70", Offset = "0x223FF71", VA = "0x223FE70")]
	public static ItemStrengtheningDataTable GetDataTable(ItemID itemID)
	{
		return null;
	}

	// Token: 0x06001708 RID: 5896 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001474")]
	[Address(RVA = "0x2240010", Offset = "0x2240111", VA = "0x2240010")]
	public static SerializedStrengtheningDataTable[] GetDataTables()
	{
		return null;
	}

	// Token: 0x06001709 RID: 5897 RVA: 0x0000A248 File Offset: 0x00008448
	[Token(Token = "0x6001475")]
	[Address(RVA = "0x2240130", Offset = "0x2240231", VA = "0x2240130")]
	public static bool HasDataTable(ItemID itemID)
	{
		return default(bool);
	}

	// Token: 0x0600170A RID: 5898 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001476")]
	[Address(RVA = "0x2240000", Offset = "0x2240101", VA = "0x2240000")]
	public ItemStrengtheningDataTable()
	{
	}

	// Token: 0x04000FF1 RID: 4081
	[Token(Token = "0x4000CA5")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public int Difficulty;

	// Token: 0x04000FF2 RID: 4082
	[Token(Token = "0x4000CA6")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public Parameter Parameter;

	// Token: 0x04000FF3 RID: 4083
	[Token(Token = "0x4000CA7")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	public MagicID MagicID1;

	// Token: 0x04000FF4 RID: 4084
	[Token(Token = "0x4000CA8")]
	[FieldOffset(Offset = "0xD4")]
	[SerializeField]
	public MagicID MagicID2;

	// Token: 0x04000FF5 RID: 4085
	[Token(Token = "0x4000CA9")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	public MagicID MagicID3;

	// Token: 0x04000FF6 RID: 4086
	[Token(Token = "0x4000CAA")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	public EquipSubAttribute[] EquipSubAttribute;

	// Token: 0x04000FF7 RID: 4087
	[Token(Token = "0x4000CAB")]
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	public bool IsGomi;

	// Token: 0x04000FF8 RID: 4088
	[Token(Token = "0x4000CAC")]
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	public UseParameter UseParameter;

	// Token: 0x04000FF9 RID: 4089
	[Token(Token = "0x4000CAD")]
	[FieldOffset(Offset = "0x0")]
	private static ItemStrengtheningDataTableArray _ItemStrengtheningDataTableArray;
}
