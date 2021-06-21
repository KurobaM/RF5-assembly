using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000A21 RID: 2593
[Token(Token = "0x20006CC")]
public class ItemTextDiscription : MonoBehaviour
{
	// Token: 0x060043E2 RID: 17378 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038CE")]
	[Address(RVA = "0x2240270", Offset = "0x2240371", VA = "0x2240270")]
	private void SetShippedText(ItemID itemID)
	{
	}

	// Token: 0x060043E3 RID: 17379 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038CF")]
	[Address(RVA = "0x2240400", Offset = "0x2240501", VA = "0x2240400")]
	private void OnDisable()
	{
	}

	// Token: 0x060043E4 RID: 17380 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038D0")]
	[Address(RVA = "0x2240460", Offset = "0x2240561", VA = "0x2240460")]
	public void SetItem(ItemData ItemData)
	{
	}

	// Token: 0x060043E5 RID: 17381 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038D1")]
	[Address(RVA = "0x2240F80", Offset = "0x2241081", VA = "0x2240F80")]
	public void SetItemPresent(ItemID itemId)
	{
	}

	// Token: 0x060043E6 RID: 17382 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038D2")]
	[Address(RVA = "0x2240410", Offset = "0x2240511", VA = "0x2240410")]
	public void SetItem(ItemID itemId)
	{
	}

	// Token: 0x060043E7 RID: 17383 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038D3")]
	[Address(RVA = "0x2240D10", Offset = "0x2240E11", VA = "0x2240D10")]
	private void ClearItemDisp()
	{
	}

	// Token: 0x060043E8 RID: 17384 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038D4")]
	[Address(RVA = "0x22411C0", Offset = "0x22412C1", VA = "0x22411C0")]
	private void Start()
	{
	}

	// Token: 0x060043E9 RID: 17385 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038D5")]
	[Address(RVA = "0x2241220", Offset = "0x2241321", VA = "0x2241220")]
	public ItemTextDiscription()
	{
	}

	// Token: 0x0400A2DB RID: 41691
	[Token(Token = "0x4007B10")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Text ItemNameText;

	// Token: 0x0400A2DC RID: 41692
	[Token(Token = "0x4007B11")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Text DetailText;

	// Token: 0x0400A2DD RID: 41693
	[Token(Token = "0x4007B12")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Image CategoryIcon;

	// Token: 0x0400A2DE RID: 41694
	[Token(Token = "0x4007B13")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Text ItemBuyPriceText;

	// Token: 0x0400A2DF RID: 41695
	[Token(Token = "0x4007B14")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Text ItemSellPriceText;

	// Token: 0x0400A2E0 RID: 41696
	[Token(Token = "0x4007B15")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Text ItemLvText;

	// Token: 0x0400A2E1 RID: 41697
	[Token(Token = "0x4007B16")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Text UnShippedText;

	// Token: 0x0400A2E2 RID: 41698
	[Token(Token = "0x4007B17")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private ItemIconLoader ItemIcon;

	// Token: 0x0400A2E3 RID: 41699
	[Token(Token = "0x4007B18")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private GameObject[] OnOffNullItems;
}
