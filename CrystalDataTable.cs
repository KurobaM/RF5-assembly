using System;
using System.Collections.Generic;
using DataTable;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200035D RID: 861
[Token(Token = "0x200028B")]
[Serializable]
public class CrystalDataTable
{
	// Token: 0x06001677 RID: 5751 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013E8")]
	[Address(RVA = "0x20EAAC0", Offset = "0x20EABC1", VA = "0x20EAAC0")]
	public static CrystalDataTable GetDataTable(ItemID CrystalID)
	{
		return null;
	}

	// Token: 0x06001678 RID: 5752 RVA: 0x00009F00 File Offset: 0x00008100
	[Token(Token = "0x60013E9")]
	[Address(RVA = "0x20EAC00", Offset = "0x20EAD01", VA = "0x20EAC00")]
	public static bool HasDataTable(ItemID CrystalID)
	{
		return default(bool);
	}

	// Token: 0x06001679 RID: 5753 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013EA")]
	[Address(RVA = "0x20EAD40", Offset = "0x20EAE41", VA = "0x20EAD40")]
	public static IEnumerable<SerializeCrystalDataTable> GetDataTables()
	{
		return null;
	}

	// Token: 0x0600167A RID: 5754 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013EB")]
	[Address(RVA = "0x20EAE60", Offset = "0x20EAF61", VA = "0x20EAE60")]
	public CrystalDataTable()
	{
	}

	// Token: 0x04000E7A RID: 3706
	[Token(Token = "0x4000B59")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public ItemID FragmentItemID;

	// Token: 0x04000E7B RID: 3707
	[Token(Token = "0x4000B5A")]
	[FieldOffset(Offset = "0x0")]
	private static CrystalDataTableArray _CrystalDataTableArray;
}
