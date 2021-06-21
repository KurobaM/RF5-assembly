using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000982 RID: 2434
[Token(Token = "0x2000661")]
public class UIEMItemDetail : MonoBehaviour
{
	// Token: 0x06003FB0 RID: 16304 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003504")]
	[Address(RVA = "0x200A460", Offset = "0x200A561", VA = "0x200A460")]
	public void SetItemDetailQuick(ItemData itemData)
	{
	}

	// Token: 0x06003FB1 RID: 16305 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003505")]
	[Address(RVA = "0x200AB80", Offset = "0x200AC81", VA = "0x200AB80")]
	public void SetItemDetailFull(ItemData itemData)
	{
	}

	// Token: 0x06003FB2 RID: 16306 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003506")]
	[Address(RVA = "0x200AB60", Offset = "0x200AC61", VA = "0x200AB60")]
	public void CloseWindow()
	{
	}

	// Token: 0x06003FB3 RID: 16307 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003507")]
	[Address(RVA = "0x200B280", Offset = "0x200B381", VA = "0x200B280")]
	public void ForceClose()
	{
	}

	// Token: 0x06003FB4 RID: 16308 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003508")]
	[Address(RVA = "0x200B370", Offset = "0x200B471", VA = "0x200B370")]
	public UIEMItemDetail()
	{
	}

	// Token: 0x04009E12 RID: 40466
	[Token(Token = "0x4007720")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Text NameText;

	// Token: 0x04009E13 RID: 40467
	[Token(Token = "0x4007721")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Text LVText;

	// Token: 0x04009E14 RID: 40468
	[Token(Token = "0x4007722")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Text LevelText;

	// Token: 0x04009E15 RID: 40469
	[Token(Token = "0x4007723")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Text DiscriptText;

	// Token: 0x04009E16 RID: 40470
	[Token(Token = "0x4007724")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Text ItemBuyPriceText;

	// Token: 0x04009E17 RID: 40471
	[Token(Token = "0x4007725")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Text ItemSellPriceText;

	// Token: 0x04009E18 RID: 40472
	[Token(Token = "0x4007726")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private UIOnOffAnimate UIOnOffAnimate;
}
