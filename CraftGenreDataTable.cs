using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200035B RID: 859
[Token(Token = "0x2000289")]
[Serializable]
public class CraftGenreDataTable
{
	// Token: 0x0600166D RID: 5741 RVA: 0x00009ED0 File Offset: 0x000080D0
	[Token(Token = "0x60013DE")]
	[Address(RVA = "0x20E22B0", Offset = "0x20E23B1", VA = "0x20E22B0")]
	public static bool IsGenreID(ItemID genreID)
	{
		return default(bool);
	}

	// Token: 0x0600166E RID: 5742 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013DF")]
	[Address(RVA = "0x20E25D0", Offset = "0x20E26D1", VA = "0x20E25D0")]
	public static ItemID[] GetItemDatasByCraftGenere(ItemID genreID)
	{
		return null;
	}

	// Token: 0x0600166F RID: 5743 RVA: 0x00009EE8 File Offset: 0x000080E8
	[Token(Token = "0x60013E0")]
	[Address(RVA = "0x20E2780", Offset = "0x20E2881", VA = "0x20E2780")]
	public static ItemID GetGenreId(ItemID itemID)
	{
		return ItemID.ITEM_EMPTY;
	}

	// Token: 0x06001670 RID: 5744 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013E1")]
	[Address(RVA = "0x20E2920", Offset = "0x20E2A21", VA = "0x20E2920")]
	public CraftGenreDataTable()
	{
	}

	// Token: 0x04000E74 RID: 3700
	[Token(Token = "0x4000B53")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public ItemID GenreItem;

	// Token: 0x04000E75 RID: 3701
	[Token(Token = "0x4000B54")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public ItemID[] CategoryItems;

	// Token: 0x04000E76 RID: 3702
	[Token(Token = "0x4000B55")]
	[FieldOffset(Offset = "0x0")]
	private static CraftGenreDataTableArray _CraftGenreDataTableArray;
}
