using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000AB0 RID: 2736
[Token(Token = "0x200072D")]
public class UIShipmentTotalRecord : MonoBehaviour
{
	// Token: 0x0600472C RID: 18220 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BA2")]
	[Address(RVA = "0x1EB94A0", Offset = "0x1EB95A1", VA = "0x1EB94A0")]
	public void SetPage()
	{
	}

	// Token: 0x0600472D RID: 18221 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BA3")]
	[Address(RVA = "0x1EB9F10", Offset = "0x1EBA011", VA = "0x1EB9F10")]
	public UIShipmentTotalRecord()
	{
	}

	// Token: 0x0400A632 RID: 42546
	[Token(Token = "0x4007D9A")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Text HeadText;

	// Token: 0x0400A633 RID: 42547
	[Token(Token = "0x4007D9B")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Text NextShippingPriceText;

	// Token: 0x0400A634 RID: 42548
	[Token(Token = "0x4007D9C")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Text CompleteText;

	// Token: 0x0400A635 RID: 42549
	[Token(Token = "0x4007D9D")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private ItemIconLoader BestItemIcon;

	// Token: 0x0400A636 RID: 42550
	[Token(Token = "0x4007D9E")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Text BestItemTotalPrice;
}
