using System;
using Il2CppDummyDll;
using RF5SHOP;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000AB9 RID: 2745
[Token(Token = "0x2000736")]
public class UIShopControl : MonoBehaviour
{
	// Token: 0x0600474C RID: 18252 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BC2")]
	[Address(RVA = "0x1EBAD20", Offset = "0x1EBAE21", VA = "0x1EBAD20")]
	private void Start()
	{
	}

	// Token: 0x0600474D RID: 18253 RVA: 0x000174C0 File Offset: 0x000156C0
	[Token(Token = "0x6003BC3")]
	[Address(RVA = "0x1EBB050", Offset = "0x1EBB151", VA = "0x1EBB050")]
	public int CalDiscountPrice(int basePrice)
	{
		return 0;
	}

	// Token: 0x0600474E RID: 18254 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BC4")]
	[Address(RVA = "0x1EBAD30", Offset = "0x1EBAE31", VA = "0x1EBAD30")]
	public void OpenShop()
	{
	}

	// Token: 0x0600474F RID: 18255 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BC5")]
	[Address(RVA = "0x1EBB120", Offset = "0x1EBB221", VA = "0x1EBB120")]
	public void CloseShop()
	{
	}

	// Token: 0x06004750 RID: 18256 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BC6")]
	[Address(RVA = "0x1EBB150", Offset = "0x1EBB251", VA = "0x1EBB150")]
	public void SetPageNameText(string pageName)
	{
	}

	// Token: 0x06004751 RID: 18257 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BC7")]
	[Address(RVA = "0x1EBB210", Offset = "0x1EBB311", VA = "0x1EBB210")]
	private void UpdateBasketItem()
	{
	}

	// Token: 0x06004752 RID: 18258 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BC8")]
	[Address(RVA = "0x1EBBAC0", Offset = "0x1EBBBC1", VA = "0x1EBBAC0")]
	public void SetFocusItem(ItemID itemID)
	{
	}

	// Token: 0x06004753 RID: 18259 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BC9")]
	[Address(RVA = "0x1EBB0E0", Offset = "0x1EBB1E1", VA = "0x1EBB0E0")]
	public void SetBasketItem(ShopItem basketItem, int InCount)
	{
	}

	// Token: 0x06004754 RID: 18260 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BCA")]
	[Address(RVA = "0x1EBBAD0", Offset = "0x1EBBBD1", VA = "0x1EBBAD0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06004755 RID: 18261 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BCB")]
	[Address(RVA = "0x1EBBF40", Offset = "0x1EBC041", VA = "0x1EBBF40")]
	public UIShopControl()
	{
	}

	// Token: 0x0400A67F RID: 42623
	[Token(Token = "0x4007DE7")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Text PlayerMoneyText;

	// Token: 0x0400A680 RID: 42624
	[Token(Token = "0x4007DE8")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Text PlayerPointText;

	// Token: 0x0400A681 RID: 42625
	[Token(Token = "0x4007DE9")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Text PlayerStoneText;

	// Token: 0x0400A682 RID: 42626
	[Token(Token = "0x4007DEA")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Text PlayerLumberText;

	// Token: 0x0400A683 RID: 42627
	[Token(Token = "0x4007DEB")]
	[FieldOffset(Offset = "0x38")]
	private long NowDispPlayerMoney;

	// Token: 0x0400A684 RID: 42628
	[Token(Token = "0x4007DEC")]
	[FieldOffset(Offset = "0x40")]
	private long NowDispPlayerPoint;

	// Token: 0x0400A685 RID: 42629
	[Token(Token = "0x4007DED")]
	[FieldOffset(Offset = "0x48")]
	private long NowDispPlayerStone;

	// Token: 0x0400A686 RID: 42630
	[Token(Token = "0x4007DEE")]
	[FieldOffset(Offset = "0x50")]
	private long NowDispPlayerLumber;

	// Token: 0x0400A687 RID: 42631
	[Token(Token = "0x4007DEF")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Text BasketItemNameText;

	// Token: 0x0400A688 RID: 42632
	[Token(Token = "0x4007DF0")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Text BaketItemPiecesText;

	// Token: 0x0400A689 RID: 42633
	[Token(Token = "0x4007DF1")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Text BasketItemTotalPriceText;

	// Token: 0x0400A68A RID: 42634
	[Token(Token = "0x4007DF2")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	public ItemIconLoader BasketItemIconImage;

	// Token: 0x0400A68B RID: 42635
	[Token(Token = "0x4007DF3")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Text ItemInRuckText;

	// Token: 0x0400A68C RID: 42636
	[Token(Token = "0x4007DF4")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Text PageNameText;

	// Token: 0x0400A68D RID: 42637
	[Token(Token = "0x4007DF5")]
	[FieldOffset(Offset = "0x88")]
	public float discountRate;

	// Token: 0x0400A68E RID: 42638
	[Token(Token = "0x4007DF6")]
	[FieldOffset(Offset = "0x8C")]
	private ItemID focusingItemID;

	// Token: 0x0400A68F RID: 42639
	[Token(Token = "0x4007DF7")]
	[FieldOffset(Offset = "0x90")]
	private ShopItem inBasketItem;

	// Token: 0x0400A690 RID: 42640
	[Token(Token = "0x4007DF8")]
	[FieldOffset(Offset = "0x98")]
	private int inBasketCount;
}
