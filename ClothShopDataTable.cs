using System;
using System.Collections.Generic;
using DataTable;
using Define;
using Il2CppDummyDll;
using RF5SHOP;
using UnityEngine;

// Token: 0x02000354 RID: 852
[Token(Token = "0x2000283")]
[Serializable]
public class ClothShopDataTable
{
	// Token: 0x06001660 RID: 5728 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013D2")]
	[Address(RVA = "0x1EA1CC0", Offset = "0x1EA1DC1", VA = "0x1EA1CC0")]
	public static ClothShopDataTable GetDataTable(ClothShopID clothShopID)
	{
		return null;
	}

	// Token: 0x06001661 RID: 5729 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013D3")]
	[Address(RVA = "0x1EA1E00", Offset = "0x1EA1F01", VA = "0x1EA1E00")]
	public static IEnumerable<SerializeClothShopDataTable> GetDataTables()
	{
		return null;
	}

	// Token: 0x06001662 RID: 5730 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013D4")]
	[Address(RVA = "0x1EA1F20", Offset = "0x1EA2021", VA = "0x1EA1F20")]
	public ClothShopDataTable()
	{
	}

	// Token: 0x04000E48 RID: 3656
	[Token(Token = "0x4000B29")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public int Price;

	// Token: 0x04000E49 RID: 3657
	[Token(Token = "0x4000B2A")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public VariationNo Variation;

	// Token: 0x04000E4A RID: 3658
	[Token(Token = "0x4000B2B")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public BuilderId Release_BuilderID;

	// Token: 0x04000E4B RID: 3659
	[Token(Token = "0x4000B2C")]
	[FieldOffset(Offset = "0x0")]
	private static ClothShopDataTableArray _ClothShopDataTableArray;
}
