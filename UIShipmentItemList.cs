using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using RF5SHIPPING;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000AAA RID: 2730
[Token(Token = "0x200072A")]
public class UIShipmentItemList : UIScrollBoxBase
{
	// Token: 0x1700097E RID: 2430
	// (get) Token: 0x06004708 RID: 18184 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007A0")]
	private List<FishShipmentRecords> FishRecordList
	{
		[Token(Token = "0x6003B8A")]
		[Address(RVA = "0x1EB76A0", Offset = "0x1EB77A1", VA = "0x1EB76A0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06004709 RID: 18185 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B8B")]
	[Address(RVA = "0x1EB77B0", Offset = "0x1EB78B1", VA = "0x1EB77B0")]
	private void SetSort()
	{
	}

	// Token: 0x0600470A RID: 18186 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003B8C")]
	[Address(RVA = "0x1EB7BE0", Offset = "0x1EB7CE1", VA = "0x1EB7BE0")]
	private Sprite GetCrownImage(CROWNTYPE type)
	{
		return null;
	}

	// Token: 0x0600470B RID: 18187 RVA: 0x000173B8 File Offset: 0x000155B8
	[Token(Token = "0x6003B8D")]
	[Address(RVA = "0x1EB7C30", Offset = "0x1EB7D31", VA = "0x1EB7C30")]
	public bool OpenCategory(ShippingCategory _shippingCategory, SORTTYPE _sortType)
	{
		return default(bool);
	}

	// Token: 0x0600470C RID: 18188 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B8E")]
	[Address(RVA = "0x1EB7DF0", Offset = "0x1EB7EF1", VA = "0x1EB7DF0")]
	public void ChangeSort(SORTTYPE _sortType, bool _sortRevert)
	{
	}

	// Token: 0x0600470D RID: 18189 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B8F")]
	[Address(RVA = "0x1EB7E30", Offset = "0x1EB7F31", VA = "0x1EB7E30", Slot = "9")]
	protected override void Update()
	{
	}

	// Token: 0x0600470E RID: 18190 RVA: 0x000173D0 File Offset: 0x000155D0
	[Token(Token = "0x6003B90")]
	[Address(RVA = "0x1EB7E40", Offset = "0x1EB7F41", VA = "0x1EB7E40", Slot = "5")]
	protected override int GetListCount()
	{
		return 0;
	}

	// Token: 0x0600470F RID: 18191 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B91")]
	[Address(RVA = "0x1EB7EC0", Offset = "0x1EB7FC1", VA = "0x1EB7EC0", Slot = "6")]
	protected override void SetButtonDisp(UIButtonLinkerInScrollBox button)
	{
	}

	// Token: 0x06004710 RID: 18192 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B92")]
	[Address(RVA = "0x1EB81C0", Offset = "0x1EB82C1", VA = "0x1EB81C0", Slot = "7")]
	public override void SetFocusDetail()
	{
	}

	// Token: 0x06004711 RID: 18193 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B93")]
	[Address(RVA = "0x1EB8250", Offset = "0x1EB8351", VA = "0x1EB8250")]
	public UIShipmentItemList()
	{
	}

	// Token: 0x06004712 RID: 18194 RVA: 0x000173E8 File Offset: 0x000155E8
	[Token(Token = "0x6003B94")]
	[Address(RVA = "0x1EB8270", Offset = "0x1EB8371", VA = "0x1EB8270")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7FA0", Offset = "0x1A80A1")]
	private bool <get_FishRecordList>b__12_0(FishShipmentRecords a)
	{
		return default(bool);
	}

	// Token: 0x0400A605 RID: 42501
	[Token(Token = "0x4007D76")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Text HeadText;

	// Token: 0x0400A606 RID: 42502
	[Token(Token = "0x4007D77")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private UISortBlock UISortBlock;

	// Token: 0x0400A607 RID: 42503
	[Token(Token = "0x4007D78")]
	[FieldOffset(Offset = "0x78")]
	private ShippingCategory shippingCategory;

	// Token: 0x0400A608 RID: 42504
	[Token(Token = "0x4007D79")]
	[FieldOffset(Offset = "0x7C")]
	private SORTTYPE sortType;

	// Token: 0x0400A609 RID: 42505
	[Token(Token = "0x4007D7A")]
	[FieldOffset(Offset = "0x80")]
	private bool sortRevert;

	// Token: 0x0400A60A RID: 42506
	[Token(Token = "0x4007D7B")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Sprite BronzeCrownSprite;

	// Token: 0x0400A60B RID: 42507
	[Token(Token = "0x4007D7C")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Sprite SilverCrownSprite;

	// Token: 0x0400A60C RID: 42508
	[Token(Token = "0x4007D7D")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private Sprite GoldCrownSprite;

	// Token: 0x0400A60D RID: 42509
	[Token(Token = "0x4007D7E")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private ItemTextDiscription ItemTextDiscription;

	// Token: 0x0400A60E RID: 42510
	[Token(Token = "0x4007D7F")]
	[FieldOffset(Offset = "0xA8")]
	private List<ShipmentItemRecords> ItemRecordList;

	// Token: 0x0400A60F RID: 42511
	[Token(Token = "0x4007D80")]
	[FieldOffset(Offset = "0xB0")]
	private List<FishShipmentRecords> _FishRecordList;

	// Token: 0x02000AAB RID: 2731
	[Token(Token = "0x2001302")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1591E0", Offset = "0x1592E1")]
	private sealed class <>c__DisplayClass12_0
	{
		// Token: 0x06004713 RID: 18195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007662")]
		[Address(RVA = "0x1EB8350", Offset = "0x1EB8451", VA = "0x1EB8350")]
		public <>c__DisplayClass12_0()
		{
		}

		// Token: 0x06004714 RID: 18196 RVA: 0x00017400 File Offset: 0x00015600
		[Token(Token = "0x6007663")]
		[Address(RVA = "0x1EB8500", Offset = "0x1EB8601", VA = "0x1EB8500")]
		internal bool <get_FishRecordList>b__1(ShipmentItemRecords b)
		{
			return default(bool);
		}

		// Token: 0x0400A610 RID: 42512
		[Token(Token = "0x401B4F2")]
		[FieldOffset(Offset = "0x10")]
		public FishShipmentRecords a;
	}

	// Token: 0x02000AAC RID: 2732
	[Token(Token = "0x2001303")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1591F0", Offset = "0x1592F1")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06004716 RID: 18198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007665")]
		[Address(RVA = "0x1EB83D0", Offset = "0x1EB84D1", VA = "0x1EB83D0")]
		public <>c()
		{
		}

		// Token: 0x06004717 RID: 18199 RVA: 0x00017418 File Offset: 0x00015618
		[Token(Token = "0x6007666")]
		[Address(RVA = "0x1EB83E0", Offset = "0x1EB84E1", VA = "0x1EB83E0")]
		internal int <SetSort>b__13_0(ShipmentItemRecords a, ShipmentItemRecords b)
		{
			return 0;
		}

		// Token: 0x06004718 RID: 18200 RVA: 0x00017430 File Offset: 0x00015630
		[Token(Token = "0x6007667")]
		[Address(RVA = "0x1EB8410", Offset = "0x1EB8511", VA = "0x1EB8410")]
		internal int <SetSort>b__13_1(ShipmentItemRecords a, ShipmentItemRecords b)
		{
			return 0;
		}

		// Token: 0x06004719 RID: 18201 RVA: 0x00017448 File Offset: 0x00015648
		[Token(Token = "0x6007668")]
		[Address(RVA = "0x1EB8440", Offset = "0x1EB8541", VA = "0x1EB8440")]
		internal int <SetSort>b__13_2(ShipmentItemRecords a, ShipmentItemRecords b)
		{
			return 0;
		}

		// Token: 0x0600471A RID: 18202 RVA: 0x00017460 File Offset: 0x00015660
		[Token(Token = "0x6007669")]
		[Address(RVA = "0x1EB8470", Offset = "0x1EB8571", VA = "0x1EB8470")]
		internal int <SetSort>b__13_3(ShipmentItemRecords a, ShipmentItemRecords b)
		{
			return 0;
		}

		// Token: 0x0600471B RID: 18203 RVA: 0x00017478 File Offset: 0x00015678
		[Token(Token = "0x600766A")]
		[Address(RVA = "0x1EB84A0", Offset = "0x1EB85A1", VA = "0x1EB84A0")]
		internal int <SetSort>b__13_4(FishShipmentRecords a, FishShipmentRecords b)
		{
			return 0;
		}

		// Token: 0x0600471C RID: 18204 RVA: 0x00017490 File Offset: 0x00015690
		[Token(Token = "0x600766B")]
		[Address(RVA = "0x1EB84D0", Offset = "0x1EB85D1", VA = "0x1EB84D0")]
		internal int <SetSort>b__13_5(FishShipmentRecords a, FishShipmentRecords b)
		{
			return 0;
		}

		// Token: 0x0400A611 RID: 42513
		[Token(Token = "0x401B4F3")]
		[FieldOffset(Offset = "0x0")]
		public static readonly UIShipmentItemList.<>c <>9;

		// Token: 0x0400A612 RID: 42514
		[Token(Token = "0x401B4F4")]
		[FieldOffset(Offset = "0x8")]
		public static Comparison<ShipmentItemRecords> <>9__13_0;

		// Token: 0x0400A613 RID: 42515
		[Token(Token = "0x401B4F5")]
		[FieldOffset(Offset = "0x10")]
		public static Comparison<ShipmentItemRecords> <>9__13_1;

		// Token: 0x0400A614 RID: 42516
		[Token(Token = "0x401B4F6")]
		[FieldOffset(Offset = "0x18")]
		public static Comparison<ShipmentItemRecords> <>9__13_2;

		// Token: 0x0400A615 RID: 42517
		[Token(Token = "0x401B4F7")]
		[FieldOffset(Offset = "0x20")]
		public static Comparison<ShipmentItemRecords> <>9__13_3;

		// Token: 0x0400A616 RID: 42518
		[Token(Token = "0x401B4F8")]
		[FieldOffset(Offset = "0x28")]
		public static Comparison<FishShipmentRecords> <>9__13_4;

		// Token: 0x0400A617 RID: 42519
		[Token(Token = "0x401B4F9")]
		[FieldOffset(Offset = "0x30")]
		public static Comparison<FishShipmentRecords> <>9__13_5;
	}

	// Token: 0x02000AAD RID: 2733
	[Token(Token = "0x2001304")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159200", Offset = "0x159301")]
	private sealed class <>c__DisplayClass19_0
	{
		// Token: 0x0600471D RID: 18205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600766C")]
		[Address(RVA = "0x1EB81B0", Offset = "0x1EB82B1", VA = "0x1EB81B0")]
		public <>c__DisplayClass19_0()
		{
		}

		// Token: 0x0600471E RID: 18206 RVA: 0x000174A8 File Offset: 0x000156A8
		[Token(Token = "0x600766D")]
		[Address(RVA = "0x1EB8530", Offset = "0x1EB8631", VA = "0x1EB8530")]
		internal bool <SetButtonDisp>b__0(ShipmentItemRecords a)
		{
			return default(bool);
		}

		// Token: 0x0400A618 RID: 42520
		[Token(Token = "0x401B4FA")]
		[FieldOffset(Offset = "0x10")]
		public FishShipmentRecords fishRec;
	}
}
