using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;

// Token: 0x0200084B RID: 2123
[Token(Token = "0x2000572")]
[Attribute(Name = "MessagePackObjectAttribute", RVA = "0x146360", Offset = "0x146461")]
public class EquipItemData : SynthesisItemData
{
	// Token: 0x170007CE RID: 1998
	// (get) Token: 0x06003853 RID: 14419 RVA: 0x000135D8 File Offset: 0x000117D8
	[Token(Token = "0x17000613")]
	[Attribute(Name = "IgnoreMemberAttribute", RVA = "0x1B85F0", Offset = "0x1B86F1")]
	public ItemID BaseItemID
	{
		[Token(Token = "0x6002EDB")]
		[Address(RVA = "0x22B75E0", Offset = "0x22B76E1", VA = "0x22B75E0")]
		get
		{
			return ItemID.ITEM_EMPTY;
		}
	}

	// Token: 0x170007CF RID: 1999
	// (get) Token: 0x06003854 RID: 14420 RVA: 0x000135F0 File Offset: 0x000117F0
	[Token(Token = "0x17000614")]
	[Attribute(Name = "IgnoreMemberAttribute", RVA = "0x1B8600", Offset = "0x1B8701")]
	public bool DoneDualSmith
	{
		[Token(Token = "0x6002EDC")]
		[Address(RVA = "0x22B7600", Offset = "0x22B7701", VA = "0x22B7600")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06003855 RID: 14421 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002EDD")]
	[Address(RVA = "0x22B7640", Offset = "0x22B7741", VA = "0x22B7640", Slot = "10")]
	public override ItemData Copy()
	{
		return null;
	}

	// Token: 0x06003856 RID: 14422 RVA: 0x00013608 File Offset: 0x00011808
	[Token(Token = "0x6002EDE")]
	[Address(RVA = "0x22B7740", Offset = "0x22B7841", VA = "0x22B7740", Slot = "14")]
	public override Parameter CalcParameter()
	{
		return default(Parameter);
	}

	// Token: 0x06003857 RID: 14423 RVA: 0x00013620 File Offset: 0x00011820
	[Token(Token = "0x6002EDF")]
	[Address(RVA = "0x22B87A0", Offset = "0x22B88A1", VA = "0x22B87A0")]
	public ValueTuple<float, MagicID[]> CaclMagicIDs()
	{
		return default(ValueTuple<float, MagicID[]>);
	}

	// Token: 0x170007D0 RID: 2000
	// (get) Token: 0x06003858 RID: 14424 RVA: 0x00013638 File Offset: 0x00011838
	[Token(Token = "0x17000615")]
	[Attribute(Name = "IgnoreMemberAttribute", RVA = "0x1B8610", Offset = "0x1B8711")]
	public override int ItemLevel
	{
		[Token(Token = "0x6002EE0")]
		[Address(RVA = "0x22B8C10", Offset = "0x22B8D11", VA = "0x22B8C10", Slot = "5")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170007D1 RID: 2001
	// (get) Token: 0x06003859 RID: 14425 RVA: 0x00013650 File Offset: 0x00011850
	[Token(Token = "0x17000616")]
	[Attribute(Name = "IgnoreMemberAttribute", RVA = "0x1B8620", Offset = "0x1B8721")]
	public override int FreeSpace
	{
		[Token(Token = "0x6002EE1")]
		[Address(RVA = "0x22B8C20", Offset = "0x22B8D21", VA = "0x22B8C20", Slot = "6")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170007D2 RID: 2002
	// (get) Token: 0x0600385A RID: 14426 RVA: 0x00013668 File Offset: 0x00011868
	[Token(Token = "0x17000617")]
	[Attribute(Name = "IgnoreMemberAttribute", RVA = "0x1B8630", Offset = "0x1B8731")]
	public override int SortValue
	{
		[Token(Token = "0x6002EE2")]
		[Address(RVA = "0x22B8C30", Offset = "0x22B8D31", VA = "0x22B8C30", Slot = "7")]
		get
		{
			return 0;
		}
	}

	// Token: 0x0600385B RID: 14427 RVA: 0x00013680 File Offset: 0x00011880
	[Token(Token = "0x6002EE3")]
	[Address(RVA = "0x22B8C40", Offset = "0x22B8D41", VA = "0x22B8C40", Slot = "18")]
	public override bool CheckIsArrenge()
	{
		return default(bool);
	}

	// Token: 0x170007D3 RID: 2003
	// (get) Token: 0x0600385C RID: 14428 RVA: 0x00013698 File Offset: 0x00011898
	[Token(Token = "0x17000618")]
	[Attribute(Name = "IgnoreMemberAttribute", RVA = "0x1B8640", Offset = "0x1B8741")]
	public virtual int CalcAttack
	{
		[Token(Token = "0x6002EE4")]
		[Address(RVA = "0x22B8C90", Offset = "0x22B8D91", VA = "0x22B8C90", Slot = "19")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170007D4 RID: 2004
	// (get) Token: 0x0600385D RID: 14429 RVA: 0x000136B0 File Offset: 0x000118B0
	[Token(Token = "0x17000619")]
	[Attribute(Name = "IgnoreMemberAttribute", RVA = "0x1B8650", Offset = "0x1B8751")]
	public virtual int CalcDefense
	{
		[Token(Token = "0x6002EE5")]
		[Address(RVA = "0x22B8CC0", Offset = "0x22B8DC1", VA = "0x22B8CC0", Slot = "20")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170007D5 RID: 2005
	// (get) Token: 0x0600385E RID: 14430 RVA: 0x000136C8 File Offset: 0x000118C8
	[Token(Token = "0x1700061A")]
	[Attribute(Name = "IgnoreMemberAttribute", RVA = "0x1B8660", Offset = "0x1B8761")]
	public virtual int CalcMagicAttack
	{
		[Token(Token = "0x6002EE6")]
		[Address(RVA = "0x22B8CF0", Offset = "0x22B8DF1", VA = "0x22B8CF0", Slot = "21")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170007D6 RID: 2006
	// (get) Token: 0x0600385F RID: 14431 RVA: 0x000136E0 File Offset: 0x000118E0
	[Token(Token = "0x1700061B")]
	[Attribute(Name = "IgnoreMemberAttribute", RVA = "0x1B8670", Offset = "0x1B8771")]
	public virtual int CalcMagicDefense
	{
		[Token(Token = "0x6002EE7")]
		[Address(RVA = "0x22B8D20", Offset = "0x22B8E21", VA = "0x22B8D20", Slot = "22")]
		get
		{
			return 0;
		}
	}

	// Token: 0x06003860 RID: 14432 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002EE8")]
	[Address(RVA = "0x22B8D50", Offset = "0x22B8E51", VA = "0x22B8D50")]
	public EquipItemData()
	{
	}

	// Token: 0x04007B61 RID: 31585
	[Token(Token = "0x4006F89")]
	public const int UpgradeMax = 9;

	// Token: 0x04007B62 RID: 31586
	[Token(Token = "0x4006F8A")]
	public const int ArrangeLength = 3;

	// Token: 0x04007B63 RID: 31587
	[Token(Token = "0x4006F8B")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16B410", Offset = "0x16B511")]
	public ItemID[] AddedItems;

	// Token: 0x04007B64 RID: 31588
	[Token(Token = "0x4006F8C")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16B430", Offset = "0x16B531")]
	public ItemID[] ArrangeItems;

	// Token: 0x04007B65 RID: 31589
	[Token(Token = "0x4006F8D")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16B450", Offset = "0x16B551")]
	public ItemID ArrangeOverride;

	// Token: 0x04007B66 RID: 31590
	[Token(Token = "0x4006F8E")]
	[FieldOffset(Offset = "0x3C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16B470", Offset = "0x16B571")]
	public int BaseLevel;

	// Token: 0x04007B67 RID: 31591
	[Token(Token = "0x4006F8F")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16B490", Offset = "0x16B591")]
	public int SozaiLevel;

	// Token: 0x04007B68 RID: 31592
	[Token(Token = "0x4006F90")]
	[FieldOffset(Offset = "0x44")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16B4B0", Offset = "0x16B5B1")]
	public DualSmithActorDataTable.LotteryType DualWorkSmithBonusType;

	// Token: 0x04007B69 RID: 31593
	[Token(Token = "0x4006F91")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16B4D0", Offset = "0x16B5D1")]
	public int DualWorkLoveLevel;

	// Token: 0x04007B6A RID: 31594
	[Token(Token = "0x4006F92")]
	[FieldOffset(Offset = "0x4C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16B4F0", Offset = "0x16B5F1")]
	public ActorID DualWorkActor;

	// Token: 0x04007B6B RID: 31595
	[Token(Token = "0x4006F93")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16B510", Offset = "0x16B611")]
	public int DualWorkParam;

	// Token: 0x04007B6C RID: 31596
	[Token(Token = "0x4006F94")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<ItemID, int> SameItemNum;

	// Token: 0x04007B6D RID: 31597
	[Token(Token = "0x4006F95")]
	[FieldOffset(Offset = "0x8")]
	[Attribute(Name = "TupleElementNamesAttribute", RVA = "0x16B530", Offset = "0x16B631")]
	private static List<ValueTuple<bool, ItemID>> ItemStrengtheningList;

	// Token: 0x0200084C RID: 2124
	[Token(Token = "0x200125C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158CE0", Offset = "0x158DE1")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06003863 RID: 14435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007460")]
		[Address(RVA = "0x22B8F00", Offset = "0x22B9001", VA = "0x22B8F00")]
		public <>c()
		{
		}

		// Token: 0x06003864 RID: 14436 RVA: 0x000136F8 File Offset: 0x000118F8
		[Token(Token = "0x6007461")]
		[Address(RVA = "0x22B8F10", Offset = "0x22B9011", VA = "0x22B8F10")]
		internal ValueTuple<bool, ItemID> <CalcParameter>b__18_0(ItemID i)
		{
			return default(ValueTuple<bool, ItemID>);
		}

		// Token: 0x06003865 RID: 14437 RVA: 0x00013710 File Offset: 0x00011910
		[Token(Token = "0x6007462")]
		[Address(RVA = "0x22B8F80", Offset = "0x22B9081", VA = "0x22B8F80")]
		internal ValueTuple<bool, ItemID> <CalcParameter>b__18_1(ItemID i)
		{
			return default(ValueTuple<bool, ItemID>);
		}

		// Token: 0x04007B6E RID: 31598
		[Token(Token = "0x401983D")]
		[FieldOffset(Offset = "0x0")]
		public static readonly EquipItemData.<>c <>9;

		// Token: 0x04007B6F RID: 31599
		[Token(Token = "0x401983E")]
		[FieldOffset(Offset = "0x8")]
		[Attribute(Name = "TupleElementNamesAttribute", RVA = "0x1953F0", Offset = "0x1954F1")]
		public static Func<ItemID, ValueTuple<bool, ItemID>> <>9__18_0;

		// Token: 0x04007B70 RID: 31600
		[Token(Token = "0x401983F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "TupleElementNamesAttribute", RVA = "0x195480", Offset = "0x195581")]
		public static Func<ItemID, ValueTuple<bool, ItemID>> <>9__18_1;
	}
}
