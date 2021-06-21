using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000AB5 RID: 2741
[Token(Token = "0x2000732")]
public class UIItemDetailDisp : MonoBehaviour
{
	// Token: 0x0600473A RID: 18234 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BB0")]
	[Address(RVA = "0x2013FB0", Offset = "0x20140B1", VA = "0x2013FB0")]
	public void SetItemDetailQuick(ItemID itemId)
	{
	}

	// Token: 0x0600473B RID: 18235 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BB1")]
	[Address(RVA = "0x20147E0", Offset = "0x20148E1", VA = "0x20147E0")]
	public void SetItemDetailFull(ItemID itemId)
	{
	}

	// Token: 0x0600473C RID: 18236 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BB2")]
	[Address(RVA = "0x2013FF0", Offset = "0x20140F1", VA = "0x2013FF0")]
	public void SetItemDetailQuick(ItemData itemData)
	{
	}

	// Token: 0x0600473D RID: 18237 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BB3")]
	[Address(RVA = "0x2014820", Offset = "0x2014921", VA = "0x2014820")]
	public void SetItemDetailFull(ItemData itemData)
	{
	}

	// Token: 0x0600473E RID: 18238 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BB4")]
	[Address(RVA = "0x20154A0", Offset = "0x20155A1", VA = "0x20154A0")]
	public void ClearText()
	{
	}

	// Token: 0x0600473F RID: 18239 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BB5")]
	[Address(RVA = "0x20156F0", Offset = "0x20157F1", VA = "0x20156F0")]
	public UIItemDetailDisp()
	{
	}

	// Token: 0x0400A65C RID: 42588
	[Token(Token = "0x4007DC4")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Text NameText;

	// Token: 0x0400A65D RID: 42589
	[Token(Token = "0x4007DC5")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Text LevelText;

	// Token: 0x0400A65E RID: 42590
	[Token(Token = "0x4007DC6")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Text DiscriptText;

	// Token: 0x0400A65F RID: 42591
	[Token(Token = "0x4007DC7")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Text ItemBuyPriceText;

	// Token: 0x0400A660 RID: 42592
	[Token(Token = "0x4007DC8")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Text ItemSellPriceText;

	// Token: 0x0400A661 RID: 42593
	[Token(Token = "0x4007DC9")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private UIOnOffAnimate UIOnOffAnimate;

	// Token: 0x0400A662 RID: 42594
	[Token(Token = "0x4007DCA")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private bool ClearOnNullData;
}
