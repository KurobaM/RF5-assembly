using System;
using Il2CppDummyDll;
using RF5SHOP;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

// Token: 0x02000ABF RID: 2751
[Token(Token = "0x2000738")]
public class UIShopItemBlock : ButtonLinker
{
	// Token: 0x0600478F RID: 18319 RVA: 0x000175F8 File Offset: 0x000157F8
	[Token(Token = "0x6003BFD")]
	[Address(RVA = "0x211A3C0", Offset = "0x211A4C1", VA = "0x211A3C0")]
	public bool CheckBuildDataCanBuy()
	{
		return default(bool);
	}

	// Token: 0x06004790 RID: 18320 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BFE")]
	[Address(RVA = "0x211A520", Offset = "0x211A621", VA = "0x211A520")]
	public void BuyBuildData(int _buildid)
	{
	}

	// Token: 0x06004791 RID: 18321 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BFF")]
	[Address(RVA = "0x211AC20", Offset = "0x211AD21", VA = "0x211AC20")]
	public void BuyBuildData()
	{
	}

	// Token: 0x06004792 RID: 18322 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C00")]
	[Address(RVA = "0x211ACE0", Offset = "0x211ADE1", VA = "0x211ACE0")]
	public void BuyFurnitureData()
	{
	}

	// Token: 0x06004793 RID: 18323 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C01")]
	[Address(RVA = "0x211AE60", Offset = "0x211AF61", VA = "0x211AE60")]
	public void SetItem(ShopItem _shopItem, int price)
	{
	}

	// Token: 0x06004794 RID: 18324 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C02")]
	[Address(RVA = "0x211B020", Offset = "0x211B121", VA = "0x211B020")]
	public void SetLoadBuildIcon(SpriteAtlas spriteAtlas)
	{
	}

	// Token: 0x06004795 RID: 18325 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C03")]
	[Address(RVA = "0x211B120", Offset = "0x211B221", VA = "0x211B120")]
	private void SetPriceBuild(BuildItemData buildData)
	{
	}

	// Token: 0x06004796 RID: 18326 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C04")]
	[Address(RVA = "0x211B550", Offset = "0x211B651", VA = "0x211B550")]
	public void SetBuild(BuildItemData _buildData)
	{
	}

	// Token: 0x06004797 RID: 18327 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C05")]
	[Address(RVA = "0x211B640", Offset = "0x211B741", VA = "0x211B640")]
	public void SetFurniture(BuildItemData _buildData)
	{
	}

	// Token: 0x06004798 RID: 18328 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C06")]
	[Address(RVA = "0x211B720", Offset = "0x211B821", VA = "0x211B720")]
	public void ClearItem()
	{
	}

	// Token: 0x06004799 RID: 18329 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C07")]
	[Address(RVA = "0x211B8A0", Offset = "0x211B9A1", VA = "0x211B8A0", Slot = "10")]
	public override void OnFocus()
	{
	}

	// Token: 0x0600479A RID: 18330 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C08")]
	[Address(RVA = "0x211B8E0", Offset = "0x211B9E1", VA = "0x211B8E0", Slot = "11")]
	public override void EndFocus()
	{
	}

	// Token: 0x0600479B RID: 18331 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C09")]
	[Address(RVA = "0x211B920", Offset = "0x211BA21", VA = "0x211B920")]
	public UIShopItemBlock()
	{
	}

	// Token: 0x0400A6E3 RID: 42723
	[Token(Token = "0x4007E37")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	public UIShopController UIShopController;

	// Token: 0x0400A6E4 RID: 42724
	[Token(Token = "0x4007E38")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	public Image ItemBagImage;

	// Token: 0x0400A6E5 RID: 42725
	[Token(Token = "0x4007E39")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	public Image BuildImage;

	// Token: 0x0400A6E6 RID: 42726
	[Token(Token = "0x4007E3A")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	public ItemIconLoader ItemImage;

	// Token: 0x0400A6E7 RID: 42727
	[Token(Token = "0x4007E3B")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Text Gold;

	// Token: 0x0400A6E8 RID: 42728
	[Token(Token = "0x4007E3C")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Text Point;

	// Token: 0x0400A6E9 RID: 42729
	[Token(Token = "0x4007E3D")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Text Stone;

	// Token: 0x0400A6EA RID: 42730
	[Token(Token = "0x4007E3E")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private Text Lumber;

	// Token: 0x0400A6EB RID: 42731
	[Token(Token = "0x4007E3F")]
	[FieldOffset(Offset = "0xA0")]
	public ItemID ItemID;

	// Token: 0x0400A6EC RID: 42732
	[Token(Token = "0x4007E40")]
	[FieldOffset(Offset = "0xA4")]
	public int buildId;

	// Token: 0x0400A6ED RID: 42733
	[Token(Token = "0x4007E41")]
	[FieldOffset(Offset = "0xA8")]
	public ShopItem shopItem;

	// Token: 0x0400A6EE RID: 42734
	[Token(Token = "0x4007E42")]
	[FieldOffset(Offset = "0xB0")]
	public BuildItemData buildData;

	// Token: 0x0400A6EF RID: 42735
	[Token(Token = "0x4007E43")]
	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	private string NotEnoughColorHead;
}
