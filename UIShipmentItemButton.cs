using System;
using Il2CppDummyDll;
using RF5SHIPPING;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000AA9 RID: 2729
[Token(Token = "0x2000729")]
public class UIShipmentItemButton : UIButtonLinkerInScrollBox
{
	// Token: 0x1700097D RID: 2429
	// (get) Token: 0x06004700 RID: 18176 RVA: 0x000173A0 File Offset: 0x000155A0
	// (set) Token: 0x06004701 RID: 18177 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700079F")]
	public ItemID ItemID
	{
		[Token(Token = "0x6003B82")]
		[Address(RVA = "0x1EB7190", Offset = "0x1EB7291", VA = "0x1EB7190")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7F80", Offset = "0x1A8081")]
		get
		{
			return ItemID.ITEM_EMPTY;
		}
		[Token(Token = "0x6003B83")]
		[Address(RVA = "0x1EB71A0", Offset = "0x1EB72A1", VA = "0x1EB71A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7F90", Offset = "0x1A8091")]
		private set
		{
		}
	}

	// Token: 0x06004702 RID: 18178 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B84")]
	[Address(RVA = "0x1EB71B0", Offset = "0x1EB72B1", VA = "0x1EB71B0", Slot = "16")]
	public override void Init()
	{
	}

	// Token: 0x06004703 RID: 18179 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B85")]
	[Address(RVA = "0x1EB71C0", Offset = "0x1EB72C1", VA = "0x1EB71C0")]
	public void SetItem(ShipmentItemRecords shipmentItemRecords, Sprite crownSprite)
	{
	}

	// Token: 0x06004704 RID: 18180 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B86")]
	[Address(RVA = "0x1EB73F0", Offset = "0x1EB74F1", VA = "0x1EB73F0")]
	public void SetItem(ShipmentItemRecords shipmentItemRecords, FishShipmentRecords fishShipmentRecords, Sprite crownSprite)
	{
	}

	// Token: 0x06004705 RID: 18181 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B87")]
	[Address(RVA = "0x1EB7670", Offset = "0x1EB7771", VA = "0x1EB7670", Slot = "10")]
	public override void OnFocus()
	{
	}

	// Token: 0x06004706 RID: 18182 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B88")]
	[Address(RVA = "0x1EB7680", Offset = "0x1EB7781", VA = "0x1EB7680", Slot = "11")]
	public override void EndFocus()
	{
	}

	// Token: 0x06004707 RID: 18183 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B89")]
	[Address(RVA = "0x1EB7690", Offset = "0x1EB7791", VA = "0x1EB7690")]
	public UIShipmentItemButton()
	{
	}

	// Token: 0x0400A600 RID: 42496
	[Token(Token = "0x4007D71")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Text ItemName;

	// Token: 0x0400A601 RID: 42497
	[Token(Token = "0x4007D72")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Text Score;

	// Token: 0x0400A602 RID: 42498
	[Token(Token = "0x4007D73")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Image Crown;

	// Token: 0x0400A603 RID: 42499
	[Token(Token = "0x4007D74")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private ItemIconLoader ItemIcon;

	// Token: 0x0400A604 RID: 42500
	[Token(Token = "0x4007D75")]
	[FieldOffset(Offset = "0x90")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x173550", Offset = "0x173651")]
	private ItemID <ItemID>k__BackingField;
}
