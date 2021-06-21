using System;
using DataTable;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000962 RID: 2402
[Token(Token = "0x200064B")]
[Serializable]
public class DropSeedDataTable
{
	// Token: 0x06003F88 RID: 16264 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60034DD")]
	[Address(RVA = "0x1E03EB0", Offset = "0x1E03FB1", VA = "0x1E03EB0")]
	public static DropSeedDataTable GetDataTable(ItemID itemID)
	{
		return null;
	}

	// Token: 0x06003F89 RID: 16265 RVA: 0x000158E8 File Offset: 0x00013AE8
	[Token(Token = "0x60034DE")]
	[Address(RVA = "0x1E03FF0", Offset = "0x1E040F1", VA = "0x1E03FF0")]
	public static bool HasDataTable(ItemID itemID)
	{
		return default(bool);
	}

	// Token: 0x06003F8A RID: 16266 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034DF")]
	[Address(RVA = "0x1E04130", Offset = "0x1E04231", VA = "0x1E04130")]
	public DropSeedDataTable()
	{
	}

	// Token: 0x04008129 RID: 33065
	[Token(Token = "0x400742A")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public GameFlagData GameFlagData;

	// Token: 0x0400812A RID: 33066
	[Token(Token = "0x400742B")]
	[FieldOffset(Offset = "0x0")]
	private static DropSeedDataTableArray _DropSeedDataTableArray;
}
