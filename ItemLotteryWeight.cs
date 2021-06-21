using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200038A RID: 906
[Token(Token = "0x20002B4")]
[Serializable]
public class ItemLotteryWeight
{
	// Token: 0x060016FE RID: 5886 RVA: 0x0000A218 File Offset: 0x00008418
	[Token(Token = "0x600146E")]
	[Address(RVA = "0x208F3F0", Offset = "0x208F4F1", VA = "0x208F3F0")]
	public ItemID Lottery(ItemLotteryWeight.ItemLotteryWeightParam[] lotteryParams)
	{
		return ItemID.ITEM_EMPTY;
	}

	// Token: 0x060016FF RID: 5887 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600146F")]
	[Address(RVA = "0x208F580", Offset = "0x208F681", VA = "0x208F580")]
	public ItemLotteryWeight()
	{
	}

	// Token: 0x0200038B RID: 907
	[Token(Token = "0x200105F")]
	[Serializable]
	public class ItemLotteryWeightParam
	{
		// Token: 0x06001700 RID: 5888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D7B")]
		[Address(RVA = "0x208F630", Offset = "0x208F731", VA = "0x208F630")]
		public ItemLotteryWeightParam()
		{
		}

		// Token: 0x04000FE9 RID: 4073
		[Token(Token = "0x4018FBB")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public ItemID ItemID;

		// Token: 0x04000FEA RID: 4074
		[Token(Token = "0x4018FBC")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		public int Weight;
	}

	// Token: 0x0200038C RID: 908
	[Token(Token = "0x2001060")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157580", Offset = "0x157681")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001702 RID: 5890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D7D")]
		[Address(RVA = "0x208F600", Offset = "0x208F701", VA = "0x208F600")]
		public <>c()
		{
		}

		// Token: 0x06001703 RID: 5891 RVA: 0x0000A230 File Offset: 0x00008430
		[Token(Token = "0x6006D7E")]
		[Address(RVA = "0x208F610", Offset = "0x208F711", VA = "0x208F610")]
		internal int <Lottery>b__1_0(ItemLotteryWeight.ItemLotteryWeightParam x)
		{
			return 0;
		}

		// Token: 0x04000FEB RID: 4075
		[Token(Token = "0x4018FBD")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ItemLotteryWeight.<>c <>9;

		// Token: 0x04000FEC RID: 4076
		[Token(Token = "0x4018FBE")]
		[FieldOffset(Offset = "0x8")]
		public static Func<ItemLotteryWeight.ItemLotteryWeightParam, int> <>9__1_0;
	}
}
