using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000849 RID: 2121
[Token(Token = "0x2000571")]
[Attribute(Name = "MessagePackObjectAttribute", RVA = "0x146340", Offset = "0x146441")]
public class AmountItemData : ItemData
{
	// Token: 0x170007C9 RID: 1993
	// (get) Token: 0x06003844 RID: 14404 RVA: 0x00013518 File Offset: 0x00011718
	[Token(Token = "0x1700060E")]
	[Attribute(Name = "IgnoreMemberAttribute", RVA = "0x1B85A0", Offset = "0x1B86A1")]
	private int StackSize
	{
		[Token(Token = "0x6002ECE")]
		[Address(RVA = "0x2435260", Offset = "0x2435361", VA = "0x2435260")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170007CA RID: 1994
	// (get) Token: 0x06003845 RID: 14405 RVA: 0x00013530 File Offset: 0x00011730
	[Token(Token = "0x1700060F")]
	[Attribute(Name = "IgnoreMemberAttribute", RVA = "0x1B85B0", Offset = "0x1B86B1")]
	public override int Amount
	{
		[Token(Token = "0x6002ECF")]
		[Address(RVA = "0x2435290", Offset = "0x2435391", VA = "0x2435290", Slot = "4")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170007CB RID: 1995
	// (get) Token: 0x06003846 RID: 14406 RVA: 0x00013548 File Offset: 0x00011748
	[Token(Token = "0x17000610")]
	[Attribute(Name = "IgnoreMemberAttribute", RVA = "0x1B85C0", Offset = "0x1B86C1")]
	public override int ItemLevel
	{
		[Token(Token = "0x6002ED0")]
		[Address(RVA = "0x24352E0", Offset = "0x24353E1", VA = "0x24352E0", Slot = "5")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170007CC RID: 1996
	// (get) Token: 0x06003847 RID: 14407 RVA: 0x00013560 File Offset: 0x00011760
	[Token(Token = "0x17000611")]
	[Attribute(Name = "IgnoreMemberAttribute", RVA = "0x1B85D0", Offset = "0x1B86D1")]
	public override int FreeSpace
	{
		[Token(Token = "0x6002ED1")]
		[Address(RVA = "0x2435350", Offset = "0x2435451", VA = "0x2435350", Slot = "6")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170007CD RID: 1997
	// (get) Token: 0x06003848 RID: 14408 RVA: 0x00013578 File Offset: 0x00011778
	[Token(Token = "0x17000612")]
	[Attribute(Name = "IgnoreMemberAttribute", RVA = "0x1B85E0", Offset = "0x1B86E1")]
	public override int SortValue
	{
		[Token(Token = "0x6002ED2")]
		[Address(RVA = "0x24353A0", Offset = "0x24354A1", VA = "0x24353A0", Slot = "7")]
		get
		{
			return 0;
		}
	}

	// Token: 0x06003849 RID: 14409 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002ED3")]
	[Address(RVA = "0x2435450", Offset = "0x2435551", VA = "0x2435450")]
	private void LevelAmountSort()
	{
	}

	// Token: 0x0600384A RID: 14410 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002ED4")]
	[Address(RVA = "0x24354E0", Offset = "0x24355E1", VA = "0x24354E0", Slot = "8")]
	public override void AppendMigrate(ItemData itemData)
	{
	}

	// Token: 0x0600384B RID: 14411 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002ED5")]
	[Address(RVA = "0x24356C0", Offset = "0x24357C1", VA = "0x24356C0", Slot = "9")]
	public override ItemData Pop(int amount)
	{
		return null;
	}

	// Token: 0x0600384C RID: 14412 RVA: 0x00013590 File Offset: 0x00011790
	[Token(Token = "0x6002ED6")]
	[Address(RVA = "0x2435780", Offset = "0x2435881", VA = "0x2435780", Slot = "16")]
	public override int GetTotalShopPrice()
	{
		return 0;
	}

	// Token: 0x0600384D RID: 14413 RVA: 0x000135A8 File Offset: 0x000117A8
	[Token(Token = "0x6002ED7")]
	[Address(RVA = "0x2435880", Offset = "0x2435981", VA = "0x2435880", Slot = "17")]
	public override int GetTotalSellPrice()
	{
		return 0;
	}

	// Token: 0x0600384E RID: 14414 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002ED8")]
	[Address(RVA = "0x2435980", Offset = "0x2435A81", VA = "0x2435980", Slot = "10")]
	public override ItemData Copy()
	{
		return null;
	}

	// Token: 0x0600384F RID: 14415 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002ED9")]
	[Address(RVA = "0x2435A60", Offset = "0x2435B61", VA = "0x2435A60")]
	public AmountItemData()
	{
	}

	// Token: 0x04007B5F RID: 31583
	[Token(Token = "0x4006F87")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16B3F0", Offset = "0x16B4F1")]
	public List<int> LevelAmount;

	// Token: 0x04007B60 RID: 31584
	[Token(Token = "0x4006F88")]
	[FieldOffset(Offset = "0x0")]
	private static AmountItemData.LevelAmountCompare CompareClass;

	// Token: 0x0200084A RID: 2122
	[Token(Token = "0x200125B")]
	private class LevelAmountCompare : IComparer<int>
	{
		// Token: 0x06003851 RID: 14417 RVA: 0x000135C0 File Offset: 0x000117C0
		[Token(Token = "0x600745D")]
		[Address(RVA = "0x2435B60", Offset = "0x2435C61", VA = "0x2435B60", Slot = "4")]
		public int Compare(int x, int y)
		{
			return 0;
		}

		// Token: 0x06003852 RID: 14418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600745E")]
		[Address(RVA = "0x2435B50", Offset = "0x2435C51", VA = "0x2435B50")]
		public LevelAmountCompare()
		{
		}
	}
}
