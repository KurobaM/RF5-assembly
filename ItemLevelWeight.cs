using System;
using DataTable;
using Field;
using Il2CppDummyDll;

// Token: 0x02000639 RID: 1593
[Token(Token = "0x200047E")]
public static class ItemLevelWeight
{
	// Token: 0x0600274C RID: 10060 RVA: 0x0000F690 File Offset: 0x0000D890
	[Token(Token = "0x6002132")]
	[Address(RVA = "0x208DE70", Offset = "0x208DF71", VA = "0x208DE70")]
	public static ItemLevelWeightID GetCurrectItemLevelWeightID()
	{
		return ItemLevelWeightID.None;
	}

	// Token: 0x0600274D RID: 10061 RVA: 0x0000F6A8 File Offset: 0x0000D8A8
	[Token(Token = "0x6002133")]
	[Address(RVA = "0x208E0E0", Offset = "0x208E1E1", VA = "0x208E0E0")]
	public static int GetCurrectEquipItemLevelCap()
	{
		return 0;
	}

	// Token: 0x0600274E RID: 10062 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002134")]
	[Address(RVA = "0x208E270", Offset = "0x208E371", VA = "0x208E270")]
	public static ItemLevelWeightDataTable GetLevelWeightDataTable(ItemLevelWeightID itemLevelWeightID)
	{
		return null;
	}

	// Token: 0x0600274F RID: 10063 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002135")]
	[Address(RVA = "0x208DFC0", Offset = "0x208E0C1", VA = "0x208DFC0")]
	public static SerializedItemLevelWeightDataTable[] GetLevelWeightDataTables()
	{
		return null;
	}

	// Token: 0x06002750 RID: 10064 RVA: 0x0000F6C0 File Offset: 0x0000D8C0
	[Token(Token = "0x6002136")]
	[Address(RVA = "0x208E3B0", Offset = "0x208E4B1", VA = "0x208E3B0")]
	public static int CheckCropItemLevel(ItemID id)
	{
		return 0;
	}

	// Token: 0x06002751 RID: 10065 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002137")]
	[Address(RVA = "0x208E580", Offset = "0x208E681", VA = "0x208E580")]
	public static ItemData LevelLotteryWithCreateItemData(ItemID itemID, int amount = 1)
	{
		return null;
	}

	// Token: 0x06002752 RID: 10066 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002138")]
	[Address(RVA = "0x208E7E0", Offset = "0x208E8E1", VA = "0x208E7E0")]
	public static void StrengtheningRandom(EquipItemData equip, int toLevel)
	{
	}

	// Token: 0x06002753 RID: 10067 RVA: 0x0000F6D8 File Offset: 0x0000D8D8
	[Token(Token = "0x6002139")]
	[Address(RVA = "0x208E680", Offset = "0x208E781", VA = "0x208E680")]
	public static int CalcDropItemLevel()
	{
		return 0;
	}

	// Token: 0x06002754 RID: 10068 RVA: 0x0000F6F0 File Offset: 0x0000D8F0
	[Token(Token = "0x600213A")]
	[Address(RVA = "0x208EF30", Offset = "0x208F031", VA = "0x208EF30")]
	public static int LotteryArrangeItemNum(FieldTreasureBoxData boxData)
	{
		return 0;
	}

	// Token: 0x06002755 RID: 10069 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600213B")]
	[Address(RVA = "0x208F0C0", Offset = "0x208F1C1", VA = "0x208F0C0")]
	public static void AddRandomArrangeItem(EquipItemData equip, int num)
	{
	}

	// Token: 0x04006F00 RID: 28416
	[Token(Token = "0x40067D1")]
	[FieldOffset(Offset = "0x0")]
	private static ItemLevelWeightDataTableArray _ItemLevelWeightDataTableArray;
}
