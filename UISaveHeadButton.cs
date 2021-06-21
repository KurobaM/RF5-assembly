using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000A4C RID: 2636
[Token(Token = "0x20006EF")]
public class UISaveHeadButton : ButtonLinker
{
	// Token: 0x060044CE RID: 17614 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039AB")]
	[Address(RVA = "0x1EB1FE0", Offset = "0x1EB20E1", VA = "0x1EB1FE0")]
	private void PageSwitch(bool openSaveBlock)
	{
	}

	// Token: 0x060044CF RID: 17615 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039AC")]
	[Address(RVA = "0x1EB2030", Offset = "0x1EB2131", VA = "0x1EB2030")]
	private void OnEnable()
	{
	}

	// Token: 0x060044D0 RID: 17616 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039AD")]
	[Address(RVA = "0x1EB2190", Offset = "0x1EB2291", VA = "0x1EB2190", Slot = "10")]
	public override void OnFocus()
	{
	}

	// Token: 0x060044D1 RID: 17617 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039AE")]
	[Address(RVA = "0x1EB2240", Offset = "0x1EB2341", VA = "0x1EB2240", Slot = "8")]
	public override void OnNextFocus(CursorLinker nextObject)
	{
	}

	// Token: 0x060044D2 RID: 17618 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039AF")]
	[Address(RVA = "0x1EB2310", Offset = "0x1EB2411", VA = "0x1EB2310")]
	public UISaveHeadButton()
	{
	}

	// Token: 0x0400A3BF RID: 41919
	[Token(Token = "0x4007BE2")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Image OnSelectImage;

	// Token: 0x0400A3C0 RID: 41920
	[Token(Token = "0x4007BE3")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Image OffSelectImage;

	// Token: 0x0400A3C1 RID: 41921
	[Token(Token = "0x4007BE4")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Sprite[] OnSelectBorderSprite;

	// Token: 0x0400A3C2 RID: 41922
	[Token(Token = "0x4007BE5")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Sprite[] OffSelectBorderSprite;

	// Token: 0x0400A3C3 RID: 41923
	[Token(Token = "0x4007BE6")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private SText onText;

	// Token: 0x0400A3C4 RID: 41924
	[Token(Token = "0x4007BE7")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private SText offText;

	// Token: 0x0400A3C5 RID: 41925
	[Token(Token = "0x4007BE8")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Color[] onTextColor;

	// Token: 0x0400A3C6 RID: 41926
	[Token(Token = "0x4007BE9")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private Color[] offTextColor;

	// Token: 0x0400A3C7 RID: 41927
	[Token(Token = "0x4007BEA")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private GameObject NoSaveActiveOnFocusObj;

	// Token: 0x0400A3C8 RID: 41928
	[Token(Token = "0x4007BEB")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private GameObject NoSaveUnActiveOnFocusObj;
}
