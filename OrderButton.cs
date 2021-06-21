using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000A5F RID: 2655
[Token(Token = "0x20006FA")]
public class OrderButton : UIButtonLinkerInScrollBox
{
	// Token: 0x0600455A RID: 17754 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A10")]
	[Address(RVA = "0x20C7EF0", Offset = "0x20C7FF1", VA = "0x20C7EF0", Slot = "16")]
	public override void Init()
	{
	}

	// Token: 0x0600455B RID: 17755 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A11")]
	[Address(RVA = "0x20C7F00", Offset = "0x20C8001", VA = "0x20C7F00", Slot = "10")]
	public override void OnFocus()
	{
	}

	// Token: 0x0600455C RID: 17756 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A12")]
	[Address(RVA = "0x20C7F60", Offset = "0x20C8061", VA = "0x20C7F60", Slot = "11")]
	public override void EndFocus()
	{
	}

	// Token: 0x0600455D RID: 17757 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A13")]
	[Address(RVA = "0x20C7FC0", Offset = "0x20C80C1", VA = "0x20C7FC0")]
	public void Setup(UIOrderBoardMenu.OrderList orderList, Sprite iconSprite)
	{
	}

	// Token: 0x0600455E RID: 17758 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A14")]
	[Address(RVA = "0x20C8210", Offset = "0x20C8311", VA = "0x20C8210")]
	public OrderButton()
	{
	}

	// Token: 0x0400A432 RID: 42034
	[Token(Token = "0x4007C27")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Text NameText;

	// Token: 0x0400A433 RID: 42035
	[Token(Token = "0x4007C28")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Image IconImage;

	// Token: 0x0400A434 RID: 42036
	[Token(Token = "0x4007C29")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Image BorderImage;

	// Token: 0x0400A435 RID: 42037
	[Token(Token = "0x4007C2A")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Sprite OnSprite;

	// Token: 0x0400A436 RID: 42038
	[Token(Token = "0x4007C2B")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Sprite NoSprite;

	// Token: 0x0400A437 RID: 42039
	[Token(Token = "0x4007C2C")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private Color OnSelectColor;

	// Token: 0x0400A438 RID: 42040
	[Token(Token = "0x4007C2D")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private Color NoSelectColor;
}
