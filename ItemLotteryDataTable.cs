using System;
using DataTable;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000389 RID: 905
[Token(Token = "0x20002B3")]
[Serializable]
public class ItemLotteryDataTable
{
	// Token: 0x060016FC RID: 5884 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600146C")]
	[Address(RVA = "0x208F2A0", Offset = "0x208F3A1", VA = "0x208F2A0")]
	public static ItemLotteryDataTable GetDataTable(ItemLotteryID id)
	{
		return null;
	}

	// Token: 0x060016FD RID: 5885 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600146D")]
	[Address(RVA = "0x208F3E0", Offset = "0x208F4E1", VA = "0x208F3E0")]
	public ItemLotteryDataTable()
	{
	}

	// Token: 0x04000FE6 RID: 4070
	[Token(Token = "0x4000C9E")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public ItemID[] LotteryItems;

	// Token: 0x04000FE7 RID: 4071
	[Token(Token = "0x4000C9F")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public ItemCategory[] LotteryItemCategories;

	// Token: 0x04000FE8 RID: 4072
	[Token(Token = "0x4000CA0")]
	[FieldOffset(Offset = "0x0")]
	private static ItemLotteryDataTableArray _ItemLotteryDataTableArray;
}
