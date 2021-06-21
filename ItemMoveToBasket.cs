using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000AB4 RID: 2740
[Token(Token = "0x2000731")]
public class ItemMoveToBasket : MonoBehaviour
{
	// Token: 0x06004733 RID: 18227 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003BA9")]
	[Address(RVA = "0x2090A20", Offset = "0x2090B21", VA = "0x2090A20")]
	public ItemMoveToBasket CloneUse(Image _baseItem, bool EndSplash = false)
	{
		return null;
	}

	// Token: 0x06004734 RID: 18228 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BAA")]
	[Address(RVA = "0x2090B00", Offset = "0x2090C01", VA = "0x2090B00")]
	public void SetCloneInit(Image _baseItem, ItemMoveToBasket originalObject, bool EndSplash)
	{
	}

	// Token: 0x06004735 RID: 18229 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BAB")]
	[Address(RVA = "0x2090CB0", Offset = "0x2090DB1", VA = "0x2090CB0")]
	private void Start()
	{
	}

	// Token: 0x06004736 RID: 18230 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BAC")]
	[Address(RVA = "0x2090D30", Offset = "0x2090E31", VA = "0x2090D30")]
	private void Update()
	{
	}

	// Token: 0x06004737 RID: 18231 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BAD")]
	[Address(RVA = "0x2090FF0", Offset = "0x20910F1", VA = "0x2090FF0")]
	private void SplashItem(Image baseItem)
	{
	}

	// Token: 0x06004738 RID: 18232 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BAE")]
	[Address(RVA = "0x2091090", Offset = "0x2091191", VA = "0x2091090")]
	public void SplashItem()
	{
	}

	// Token: 0x06004739 RID: 18233 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BAF")]
	[Address(RVA = "0x20910A0", Offset = "0x20911A1", VA = "0x20910A0")]
	public ItemMoveToBasket()
	{
	}

	// Token: 0x0400A64E RID: 42574
	[Token(Token = "0x4007DB6")]
	[FieldOffset(Offset = "0x18")]
	public UIShopController UIShopController;

	// Token: 0x0400A64F RID: 42575
	[Token(Token = "0x4007DB7")]
	[FieldOffset(Offset = "0x20")]
	public RectTransform BasketItem;

	// Token: 0x0400A650 RID: 42576
	[Token(Token = "0x4007DB8")]
	[FieldOffset(Offset = "0x28")]
	private Vector2 StartPos;

	// Token: 0x0400A651 RID: 42577
	[Token(Token = "0x4007DB9")]
	[FieldOffset(Offset = "0x30")]
	private Vector2 StartSize;

	// Token: 0x0400A652 RID: 42578
	[Token(Token = "0x4007DBA")]
	[FieldOffset(Offset = "0x38")]
	private Image Image;

	// Token: 0x0400A653 RID: 42579
	[Token(Token = "0x4007DBB")]
	[FieldOffset(Offset = "0x40")]
	private Image BaseItem;

	// Token: 0x0400A654 RID: 42580
	[Token(Token = "0x4007DBC")]
	[FieldOffset(Offset = "0x48")]
	public float MovTimeMax;

	// Token: 0x0400A655 RID: 42581
	[Token(Token = "0x4007DBD")]
	[FieldOffset(Offset = "0x4C")]
	private float MovTime;

	// Token: 0x0400A656 RID: 42582
	[Token(Token = "0x4007DBE")]
	[FieldOffset(Offset = "0x50")]
	public AnimationCurve AddXCurve;

	// Token: 0x0400A657 RID: 42583
	[Token(Token = "0x4007DBF")]
	[FieldOffset(Offset = "0x58")]
	public AnimationCurve AddYCurve;

	// Token: 0x0400A658 RID: 42584
	[Token(Token = "0x4007DC0")]
	[FieldOffset(Offset = "0x60")]
	public Vector2 AddRange;

	// Token: 0x0400A659 RID: 42585
	[Token(Token = "0x4007DC1")]
	[FieldOffset(Offset = "0x68")]
	public BasketAnim basketAnim;

	// Token: 0x0400A65A RID: 42586
	[Token(Token = "0x4007DC2")]
	[FieldOffset(Offset = "0x70")]
	public UIShopItemSplash UIShopItemSplash;

	// Token: 0x0400A65B RID: 42587
	[Token(Token = "0x4007DC3")]
	[FieldOffset(Offset = "0x78")]
	private bool EndsplashFlag;
}
