using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200093A RID: 2362
[Token(Token = "0x200062E")]
public class ButtonLinkerSetImage : ButtonLinker
{
	// Token: 0x06003E73 RID: 15987 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033E6")]
	[Address(RVA = "0x219B660", Offset = "0x219B761", VA = "0x219B660", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x06003E74 RID: 15988 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033E7")]
	[Address(RVA = "0x219B690", Offset = "0x219B791", VA = "0x219B690")]
	private void initSize()
	{
	}

	// Token: 0x06003E75 RID: 15989 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033E8")]
	[Address(RVA = "0x219B820", Offset = "0x219B921", VA = "0x219B820", Slot = "10")]
	public override void OnFocus()
	{
	}

	// Token: 0x06003E76 RID: 15990 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033E9")]
	[Address(RVA = "0x219BA90", Offset = "0x219BB91", VA = "0x219BA90", Slot = "11")]
	public override void EndFocus()
	{
	}

	// Token: 0x06003E77 RID: 15991 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033EA")]
	[Address(RVA = "0x219BCB0", Offset = "0x219BDB1", VA = "0x219BCB0")]
	public ButtonLinkerSetImage()
	{
	}

	// Token: 0x0400802E RID: 32814
	[Token(Token = "0x4007382")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Image BorderImage;

	// Token: 0x0400802F RID: 32815
	[Token(Token = "0x4007383")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Sprite OutFocusSprite;

	// Token: 0x04008030 RID: 32816
	[Token(Token = "0x4007384")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Sprite OnFocusSprite;

	// Token: 0x04008031 RID: 32817
	[Token(Token = "0x4007385")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Vector2 AddPosOnFocus;

	// Token: 0x04008032 RID: 32818
	[Token(Token = "0x4007386")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Text text;

	// Token: 0x04008033 RID: 32819
	[Token(Token = "0x4007387")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Color OutTextColor;

	// Token: 0x04008034 RID: 32820
	[Token(Token = "0x4007388")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private Color OnTextColor;

	// Token: 0x04008035 RID: 32821
	[Token(Token = "0x4007389")]
	[FieldOffset(Offset = "0xA8")]
	private bool initdSize;

	// Token: 0x04008036 RID: 32822
	[Token(Token = "0x400738A")]
	[FieldOffset(Offset = "0xAC")]
	private Vector2 OffSize;

	// Token: 0x04008037 RID: 32823
	[Token(Token = "0x400738B")]
	[FieldOffset(Offset = "0xB4")]
	private Vector2 OnSize;
}
