using System;
using System.Collections.Generic;
using Define;
using Farm;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200063A RID: 1594
[Token(Token = "0x200047F")]
public static class ItemLotty
{
	// Token: 0x06002756 RID: 10070 RVA: 0x0000F708 File Offset: 0x0000D908
	[Token(Token = "0x600213C")]
	[Address(RVA = "0x208E920", Offset = "0x208EA21", VA = "0x208E920")]
	public static ItemID ItemLottery(ItemLotteryID id, bool isHiDropCapOver = false)
	{
		return ItemID.ITEM_EMPTY;
	}

	// Token: 0x06002757 RID: 10071 RVA: 0x0000F720 File Offset: 0x0000D920
	[Token(Token = "0x600213D")]
	[Address(RVA = "0x208F7A0", Offset = "0x208F8A1", VA = "0x208F7A0")]
	public static ItemID ItemLotteryNoCap(ItemLotteryID id)
	{
		return ItemID.ITEM_EMPTY;
	}

	// Token: 0x17000647 RID: 1607
	// (get) Token: 0x06002758 RID: 10072 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000501")]
	public static UniqueRandom UniqueRandom
	{
		[Token(Token = "0x600213E")]
		[Address(RVA = "0x208F950", Offset = "0x208FA51", VA = "0x208F950")]
		get
		{
			return null;
		}
	}

	// Token: 0x06002759 RID: 10073 RVA: 0x0000F738 File Offset: 0x0000D938
	[Token(Token = "0x600213F")]
	[Address(RVA = "0x208F9F0", Offset = "0x208FAF1", VA = "0x208F9F0")]
	public static ItemID ItemLotteryWeight(ItemLotteryWeightID id, int seed)
	{
		return ItemID.ITEM_EMPTY;
	}

	// Token: 0x0600275A RID: 10074 RVA: 0x0000F750 File Offset: 0x0000D950
	[Token(Token = "0x6002140")]
	[Address(RVA = "0x208FB10", Offset = "0x208FC11", VA = "0x208FB10")]
	public static ItemID LotteryWeight(List<ItemWeightData> lotteryList, int seed)
	{
		return ItemID.ITEM_EMPTY;
	}

	// Token: 0x0600275B RID: 10075 RVA: 0x0000F768 File Offset: 0x0000D968
	[Token(Token = "0x6002141")]
	[Address(RVA = "0x208FE10", Offset = "0x208FF11", VA = "0x208FE10")]
	public static ItemID ItemLotteryWeight(ItemLotty.ItemLotteryWeightParam[] lotteryParams)
	{
		return ItemID.ITEM_EMPTY;
	}

	// Token: 0x0600275C RID: 10076 RVA: 0x0000F780 File Offset: 0x0000D980
	[Token(Token = "0x6002142")]
	[Address(RVA = "0x208FFA0", Offset = "0x20900A1", VA = "0x208FFA0")]
	public static bool CalcItemCapCheck(ItemID itemID, bool isHiDropCapOver)
	{
		return default(bool);
	}

	// Token: 0x0600275D RID: 10077 RVA: 0x0000F798 File Offset: 0x0000D998
	[Token(Token = "0x6002143")]
	[Address(RVA = "0x20904D0", Offset = "0x20905D1", VA = "0x20904D0")]
	public static ItemID CalcItemDropByCategory(ItemCategory itemCategory, bool isHiDropCapOver)
	{
		return ItemID.ITEM_EMPTY;
	}

	// Token: 0x0600275E RID: 10078 RVA: 0x0000F7B0 File Offset: 0x0000D9B0
	[Token(Token = "0x6002144")]
	[Address(RVA = "0x2090700", Offset = "0x2090801", VA = "0x2090700")]
	public static ItemID CalcItemDropByCraftGenre(ItemID itemGenre, bool isHiDropCapOver)
	{
		return ItemID.ITEM_EMPTY;
	}

	// Token: 0x0600275F RID: 10079 RVA: 0x0000F7C8 File Offset: 0x0000D9C8
	[Token(Token = "0x6002145")]
	[Address(RVA = "0x2090260", Offset = "0x2090361", VA = "0x2090260")]
	public static bool IsSeedSellCheck(ItemID itemID)
	{
		return default(bool);
	}

	// Token: 0x06002760 RID: 10080 RVA: 0x0000F7E0 File Offset: 0x0000D9E0
	[Token(Token = "0x6002146")]
	[Address(RVA = "0x2090310", Offset = "0x2090411", VA = "0x2090310")]
	private static bool IsCropSellCheck(ItemID itemID)
	{
		return default(bool);
	}

	// Token: 0x04006F01 RID: 28417
	[Token(Token = "0x40067D2")]
	[FieldOffset(Offset = "0x0")]
	private static UniqueRandom uniqueRandom;

	// Token: 0x0200063B RID: 1595
	[Token(Token = "0x2001144")]
	[Serializable]
	public class ItemLotteryWeightParam
	{
		// Token: 0x06002761 RID: 10081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007105")]
		[Address(RVA = "0x2090A10", Offset = "0x2090B11", VA = "0x2090A10")]
		public ItemLotteryWeightParam()
		{
		}

		// Token: 0x04006F02 RID: 28418
		[Token(Token = "0x40193A2")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public ItemID ItemID;

		// Token: 0x04006F03 RID: 28419
		[Token(Token = "0x40193A3")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		public int Weight;
	}

	// Token: 0x0200063C RID: 1596
	[Token(Token = "0x2001145")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158130", Offset = "0x158231")]
	private sealed class <>c__DisplayClass0_0
	{
		// Token: 0x06002762 RID: 10082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007106")]
		[Address(RVA = "0x208F790", Offset = "0x208F891", VA = "0x208F790")]
		public <>c__DisplayClass0_0()
		{
		}

		// Token: 0x06002763 RID: 10083 RVA: 0x0000F7F8 File Offset: 0x0000D9F8
		[Token(Token = "0x6007107")]
		[Address(RVA = "0x20909F0", Offset = "0x2090AF1", VA = "0x20909F0")]
		internal bool <ItemLottery>b__0(ItemID itemID)
		{
			return default(bool);
		}

		// Token: 0x06002764 RID: 10084 RVA: 0x0000F810 File Offset: 0x0000DA10
		[Token(Token = "0x6007108")]
		[Address(RVA = "0x2090A00", Offset = "0x2090B01", VA = "0x2090A00")]
		internal bool <ItemLottery>b__1(ItemID itemID)
		{
			return default(bool);
		}

		// Token: 0x04006F04 RID: 28420
		[Token(Token = "0x40193A4")]
		[FieldOffset(Offset = "0x10")]
		public bool isHiDropCapOver;

		// Token: 0x04006F05 RID: 28421
		[Token(Token = "0x40193A5")]
		[FieldOffset(Offset = "0x18")]
		public Func<ItemID, bool> <>9__0;

		// Token: 0x04006F06 RID: 28422
		[Token(Token = "0x40193A6")]
		[FieldOffset(Offset = "0x20")]
		public Func<ItemID, bool> <>9__1;
	}

	// Token: 0x0200063D RID: 1597
	[Token(Token = "0x2001146")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158140", Offset = "0x158241")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06002766 RID: 10086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600710A")]
		[Address(RVA = "0x20909A0", Offset = "0x2090AA1", VA = "0x20909A0")]
		public <>c()
		{
		}

		// Token: 0x06002767 RID: 10087 RVA: 0x0000F828 File Offset: 0x0000DA28
		[Token(Token = "0x600710B")]
		[Address(RVA = "0x20909B0", Offset = "0x2090AB1", VA = "0x20909B0")]
		internal int <LotteryWeight>b__6_0(ItemWeightData x)
		{
			return 0;
		}

		// Token: 0x06002768 RID: 10088 RVA: 0x0000F840 File Offset: 0x0000DA40
		[Token(Token = "0x600710C")]
		[Address(RVA = "0x20909D0", Offset = "0x2090AD1", VA = "0x20909D0")]
		internal int <ItemLotteryWeight>b__8_0(ItemLotty.ItemLotteryWeightParam x)
		{
			return 0;
		}

		// Token: 0x04006F07 RID: 28423
		[Token(Token = "0x40193A7")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ItemLotty.<>c <>9;

		// Token: 0x04006F08 RID: 28424
		[Token(Token = "0x40193A8")]
		[FieldOffset(Offset = "0x8")]
		public static Func<ItemWeightData, int> <>9__6_0;

		// Token: 0x04006F09 RID: 28425
		[Token(Token = "0x40193A9")]
		[FieldOffset(Offset = "0x10")]
		public static Func<ItemLotty.ItemLotteryWeightParam, int> <>9__8_0;
	}
}
