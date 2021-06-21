using System;
using Il2CppDummyDll;
using RF5SHIPPING;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000AAF RID: 2735
[Token(Token = "0x200072C")]
public class UIShipmentRecordMain : CursorLinkConnector
{
	// Token: 0x06004722 RID: 18210 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B98")]
	[Address(RVA = "0x1EB8CC0", Offset = "0x1EB8DC1", VA = "0x1EB8CC0")]
	private void SetTopText()
	{
	}

	// Token: 0x06004723 RID: 18211 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B99")]
	[Address(RVA = "0x1EB8E10", Offset = "0x1EB8F11", VA = "0x1EB8E10")]
	public void OpenPage(ShipTabButton tab)
	{
	}

	// Token: 0x06004724 RID: 18212 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B9A")]
	[Address(RVA = "0x1EB9880", Offset = "0x1EB9981", VA = "0x1EB9880")]
	public void RegisTab(ShipTabButton button)
	{
	}

	// Token: 0x06004725 RID: 18213 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B9B")]
	[Address(RVA = "0x1EB9900", Offset = "0x1EB9A01", VA = "0x1EB9900")]
	public void ChangePage(int addNum)
	{
	}

	// Token: 0x06004726 RID: 18214 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B9C")]
	[Address(RVA = "0x1EB99D0", Offset = "0x1EB9AD1", VA = "0x1EB99D0")]
	public void SelectSort(SORTTYPE _sortType)
	{
	}

	// Token: 0x06004727 RID: 18215 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B9D")]
	[Address(RVA = "0x1EB9A40", Offset = "0x1EB9B41", VA = "0x1EB9A40")]
	public void SwitchSort()
	{
	}

	// Token: 0x06004728 RID: 18216 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B9E")]
	[Address(RVA = "0x1EB9AF0", Offset = "0x1EB9BF1", VA = "0x1EB9AF0")]
	public void OpenItemSortMenu()
	{
	}

	// Token: 0x06004729 RID: 18217 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B9F")]
	[Address(RVA = "0x1EB9BF0", Offset = "0x1EB9CF1", VA = "0x1EB9BF0")]
	private void Start()
	{
	}

	// Token: 0x0600472A RID: 18218 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BA0")]
	[Address(RVA = "0x1EB9CA0", Offset = "0x1EB9DA1", VA = "0x1EB9CA0")]
	private void Update()
	{
	}

	// Token: 0x0600472B RID: 18219 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BA1")]
	[Address(RVA = "0x1EB9EA0", Offset = "0x1EB9FA1", VA = "0x1EB9EA0")]
	public UIShipmentRecordMain()
	{
	}

	// Token: 0x0400A621 RID: 42529
	[Token(Token = "0x4007D89")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private ShipTabButton FirstPageTab;

	// Token: 0x0400A622 RID: 42530
	[Token(Token = "0x4007D8A")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private ShipTabButton NowPageTab;

	// Token: 0x0400A623 RID: 42531
	[Token(Token = "0x4007D8B")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private UIOnOffAnimate TopMenuAnimatePrefab;

	// Token: 0x0400A624 RID: 42532
	[Token(Token = "0x4007D8C")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Text TopMenuText;

	// Token: 0x0400A625 RID: 42533
	[Token(Token = "0x4007D8D")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private UIShipmentItemList UIShipmentItemList;

	// Token: 0x0400A626 RID: 42534
	[Token(Token = "0x4007D8E")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private GameObject MainPage;

	// Token: 0x0400A627 RID: 42535
	[Token(Token = "0x4007D8F")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private GameObject NoShipmentDataPage;

	// Token: 0x0400A628 RID: 42536
	[Token(Token = "0x4007D90")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Text NoShipmentDataText;

	// Token: 0x0400A629 RID: 42537
	[Token(Token = "0x4007D91")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private UIShipmentItemRecord UIShipmentItemRecord;

	// Token: 0x0400A62A RID: 42538
	[Token(Token = "0x4007D92")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private UIShipmentTotalRecord UIShipmentTotalRecord;

	// Token: 0x0400A62B RID: 42539
	[Token(Token = "0x4007D93")]
	[FieldOffset(Offset = "0xA8")]
	private bool isHasShipmentData;

	// Token: 0x0400A62C RID: 42540
	[Token(Token = "0x4007D94")]
	[FieldOffset(Offset = "0xB0")]
	private UIOnOffAnimate TopMenuAnimate;

	// Token: 0x0400A62D RID: 42541
	[Token(Token = "0x4007D95")]
	[FieldOffset(Offset = "0xB8")]
	private ShipTabButton[] shipTabButtons;

	// Token: 0x0400A62E RID: 42542
	[Token(Token = "0x4007D96")]
	[FieldOffset(Offset = "0xC0")]
	private SORTTYPE sortType;

	// Token: 0x0400A62F RID: 42543
	[Token(Token = "0x4007D97")]
	[FieldOffset(Offset = "0xC4")]
	private bool isSortRevert;

	// Token: 0x0400A630 RID: 42544
	[Token(Token = "0x4007D98")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private NonFocusButton L_Button;

	// Token: 0x0400A631 RID: 42545
	[Token(Token = "0x4007D99")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private NonFocusButton R_Button;
}
