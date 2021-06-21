using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000852 RID: 2130
[Token(Token = "0x2000578")]
[Attribute(Name = "UnionAttribute", RVA = "0x146400", Offset = "0x146501")]
[Attribute(Name = "UnionAttribute", RVA = "0x146400", Offset = "0x146501")]
[Attribute(Name = "UnionAttribute", RVA = "0x146400", Offset = "0x146501")]
[Attribute(Name = "UnionAttribute", RVA = "0x146400", Offset = "0x146501")]
[Attribute(Name = "UnionAttribute", RVA = "0x146400", Offset = "0x146501")]
[Attribute(Name = "UnionAttribute", RVA = "0x146400", Offset = "0x146501")]
[Attribute(Name = "UnionAttribute", RVA = "0x146400", Offset = "0x146501")]
[Attribute(Name = "MessagePackObjectAttribute", RVA = "0x146400", Offset = "0x146501")]
public abstract class ItemData
{
	// Token: 0x170007D8 RID: 2008
	// (get) Token: 0x0600386F RID: 14447 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700061D")]
	[Attribute(Name = "IgnoreMemberAttribute", RVA = "0x1B8690", Offset = "0x1B8791")]
	public ItemDataTable ItemDataTable
	{
		[Token(Token = "0x6002EF3")]
		[Address(RVA = "0x22367F0", Offset = "0x22368F1", VA = "0x22367F0")]
		get
		{
			return null;
		}
	}

	// Token: 0x170007D9 RID: 2009
	// (get) Token: 0x06003870 RID: 14448 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700061E")]
	[Attribute(Name = "IgnoreMemberAttribute", RVA = "0x1B86A0", Offset = "0x1B87A1")]
	public UseParamDataTable UseParameterDataTable
	{
		[Token(Token = "0x6002EF4")]
		[Address(RVA = "0x2236940", Offset = "0x2236A41", VA = "0x2236940")]
		get
		{
			return null;
		}
	}

	// Token: 0x06003871 RID: 14449 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002EF5")]
	[Address(RVA = "0x2236950", Offset = "0x2236A51", VA = "0x2236950")]
	public static ItemData Instantiate(ItemID itemID, int level = 1)
	{
		return null;
	}

	// Token: 0x06003872 RID: 14450 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002EF6")]
	[Address(RVA = "0x2236A30", Offset = "0x2236B31", VA = "0x2236A30")]
	public static ItemData Instantiate(ItemID itemID, int[] levelAmount)
	{
		return null;
	}

	// Token: 0x06003873 RID: 14451 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002EF7")]
	[Address(RVA = "0x2236AB0", Offset = "0x2236BB1", VA = "0x2236AB0")]
	public static ItemData Instantiate(ItemID itemID, List<int> levelAmount)
	{
		return null;
	}

	// Token: 0x170007DA RID: 2010
	// (get) Token: 0x06003874 RID: 14452
	[Token(Token = "0x1700061F")]
	[Attribute(Name = "IgnoreMemberAttribute", RVA = "0x1B86B0", Offset = "0x1B87B1")]
	public abstract int Amount { [Token(Token = "0x6002EF8")] get; }

	// Token: 0x170007DB RID: 2011
	// (get) Token: 0x06003875 RID: 14453
	[Token(Token = "0x17000620")]
	[Attribute(Name = "IgnoreMemberAttribute", RVA = "0x1B86C0", Offset = "0x1B87C1")]
	public abstract int ItemLevel { [Token(Token = "0x6002EF9")] get; }

	// Token: 0x170007DC RID: 2012
	// (get) Token: 0x06003876 RID: 14454
	[Token(Token = "0x17000621")]
	[Attribute(Name = "IgnoreMemberAttribute", RVA = "0x1B86D0", Offset = "0x1B87D1")]
	public abstract int FreeSpace { [Token(Token = "0x6002EFA")] get; }

	// Token: 0x170007DD RID: 2013
	// (get) Token: 0x06003877 RID: 14455
	[Token(Token = "0x17000622")]
	[Attribute(Name = "IgnoreMemberAttribute", RVA = "0x1B86E0", Offset = "0x1B87E1")]
	public abstract int SortValue { [Token(Token = "0x6002EFB")] get; }

	// Token: 0x06003878 RID: 14456
	[Token(Token = "0x6002EFC")]
	public abstract void AppendMigrate(ItemData ItemData);

	// Token: 0x06003879 RID: 14457 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002EFD")]
	[Address(RVA = "0x2236E00", Offset = "0x2236F01", VA = "0x2236E00")]
	public ItemData Pop()
	{
		return null;
	}

	// Token: 0x0600387A RID: 14458 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002EFE")]
	[Address(RVA = "0x2236E10", Offset = "0x2236F11", VA = "0x2236E10")]
	public ItemData PopAll()
	{
		return null;
	}

	// Token: 0x0600387B RID: 14459
	[Token(Token = "0x6002EFF")]
	public abstract ItemData Pop(int amount);

	// Token: 0x0600387C RID: 14460
	[Token(Token = "0x6002F00")]
	public abstract ItemData Copy();

	// Token: 0x170007DE RID: 2014
	// (get) Token: 0x0600387D RID: 14461 RVA: 0x00013758 File Offset: 0x00011958
	[Token(Token = "0x17000623")]
	[Attribute(Name = "IgnoreMemberAttribute", RVA = "0x1B86F0", Offset = "0x1B87F1")]
	public bool IsFull
	{
		[Token(Token = "0x6002F01")]
		[Address(RVA = "0x2236E50", Offset = "0x2236F51", VA = "0x2236E50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170007DF RID: 2015
	// (get) Token: 0x0600387E RID: 14462 RVA: 0x00013770 File Offset: 0x00011970
	[Token(Token = "0x17000624")]
	[Attribute(Name = "IgnoreMemberAttribute", RVA = "0x1B8700", Offset = "0x1B8801")]
	public bool IsEquipale
	{
		[Token(Token = "0x6002F02")]
		[Address(RVA = "0x2236E80", Offset = "0x2236F81", VA = "0x2236E80")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170007E0 RID: 2016
	// (get) Token: 0x0600387F RID: 14463 RVA: 0x00013788 File Offset: 0x00011988
	[Token(Token = "0x17000625")]
	[Attribute(Name = "IgnoreMemberAttribute", RVA = "0x1B8710", Offset = "0x1B8811")]
	public virtual bool IsEatble
	{
		[Token(Token = "0x6002F03")]
		[Address(RVA = "0x2236E90", Offset = "0x2236F91", VA = "0x2236E90", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170007E1 RID: 2017
	// (get) Token: 0x06003880 RID: 14464 RVA: 0x000137A0 File Offset: 0x000119A0
	[Token(Token = "0x17000626")]
	[Attribute(Name = "IgnoreMemberAttribute", RVA = "0x1B8720", Offset = "0x1B8821")]
	public virtual bool CalcCheckGomi
	{
		[Token(Token = "0x6002F04")]
		[Address(RVA = "0x2236EA0", Offset = "0x2236FA1", VA = "0x2236EA0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170007E2 RID: 2018
	// (get) Token: 0x06003881 RID: 14465 RVA: 0x000137B8 File Offset: 0x000119B8
	[Token(Token = "0x17000627")]
	[Attribute(Name = "IgnoreMemberAttribute", RVA = "0x1B8730", Offset = "0x1B8831")]
	public bool IsStackable
	{
		[Token(Token = "0x6002F05")]
		[Address(RVA = "0x2236EB0", Offset = "0x2236FB1", VA = "0x2236EB0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170007E3 RID: 2019
	// (get) Token: 0x06003882 RID: 14466 RVA: 0x000137D0 File Offset: 0x000119D0
	[Token(Token = "0x17000628")]
	[Attribute(Name = "IgnoreMemberAttribute", RVA = "0x1B8740", Offset = "0x1B8841")]
	public virtual bool IsOriginal
	{
		[Token(Token = "0x6002F06")]
		[Address(RVA = "0x2236EE0", Offset = "0x2236FE1", VA = "0x2236EE0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06003883 RID: 14467 RVA: 0x000137E8 File Offset: 0x000119E8
	[Token(Token = "0x6002F07")]
	[Address(RVA = "0x2236EF0", Offset = "0x2236FF1", VA = "0x2236EF0", Slot = "14")]
	public virtual Parameter CalcParameter()
	{
		return default(Parameter);
	}

	// Token: 0x06003884 RID: 14468 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F08")]
	[Address(RVA = "0x2236F30", Offset = "0x2237031", VA = "0x2236F30", Slot = "15")]
	public virtual UseParameter CalcUseParameter()
	{
		return null;
	}

	// Token: 0x170007E4 RID: 2020
	// (get) Token: 0x06003885 RID: 14469 RVA: 0x00013800 File Offset: 0x00011A00
	[Token(Token = "0x17000629")]
	[Attribute(Name = "IgnoreMemberAttribute", RVA = "0x1B8750", Offset = "0x1B8851")]
	public int ShopPrice
	{
		[Token(Token = "0x6002F09")]
		[Address(RVA = "0x22370D0", Offset = "0x22371D1", VA = "0x22370D0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170007E5 RID: 2021
	// (get) Token: 0x06003886 RID: 14470 RVA: 0x00013818 File Offset: 0x00011A18
	[Token(Token = "0x1700062A")]
	[Attribute(Name = "IgnoreMemberAttribute", RVA = "0x1B8760", Offset = "0x1B8861")]
	public int SellPrice
	{
		[Token(Token = "0x6002F0A")]
		[Address(RVA = "0x2237230", Offset = "0x2237331", VA = "0x2237230")]
		get
		{
			return 0;
		}
	}

	// Token: 0x06003887 RID: 14471 RVA: 0x00013830 File Offset: 0x00011A30
	[Token(Token = "0x6002F0B")]
	[Address(RVA = "0x22372A0", Offset = "0x22373A1", VA = "0x22372A0", Slot = "16")]
	public virtual int GetTotalShopPrice()
	{
		return 0;
	}

	// Token: 0x06003888 RID: 14472 RVA: 0x00013848 File Offset: 0x00011A48
	[Token(Token = "0x6002F0C")]
	[Address(RVA = "0x2237310", Offset = "0x2237411", VA = "0x2237310", Slot = "17")]
	public virtual int GetTotalSellPrice()
	{
		return 0;
	}

	// Token: 0x06003889 RID: 14473 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F0D")]
	[Address(RVA = "0x2237380", Offset = "0x2237481", VA = "0x2237380", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x0600388A RID: 14474 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002F0E")]
	[Address(RVA = "0x2237390", Offset = "0x2237491", VA = "0x2237390")]
	protected ItemData()
	{
	}

	// Token: 0x04007B79 RID: 31609
	[Token(Token = "0x4006F9E")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16B6C0", Offset = "0x16B7C1")]
	public ItemID ItemID;

	// Token: 0x02000853 RID: 2131
	[Token(Token = "0x200125D")]
	private enum ItemDataType
	{
		// Token: 0x04007B7B RID: 31611
		[Token(Token = "0x4019841")]
		Amount,
		// Token: 0x04007B7C RID: 31612
		[Token(Token = "0x4019842")]
		Equip,
		// Token: 0x04007B7D RID: 31613
		[Token(Token = "0x4019843")]
		Food,
		// Token: 0x04007B7E RID: 31614
		[Token(Token = "0x4019844")]
		Pot
	}
}
