using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020009F1 RID: 2545
[Token(Token = "0x20006AC")]
public class WarpButtonBlock : UIButtonLinkerInScrollBox
{
	// Token: 0x060042CA RID: 17098 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037DF")]
	[Address(RVA = "0x1E4D980", Offset = "0x1E4DA81", VA = "0x1E4D980", Slot = "16")]
	public override void Init()
	{
	}

	// Token: 0x060042CB RID: 17099 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037E0")]
	[Address(RVA = "0x1E4D990", Offset = "0x1E4DA91", VA = "0x1E4D990", Slot = "10")]
	public override void OnFocus()
	{
	}

	// Token: 0x060042CC RID: 17100 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037E1")]
	[Address(RVA = "0x1E4DA40", Offset = "0x1E4DB41", VA = "0x1E4DA40", Slot = "11")]
	public override void EndFocus()
	{
	}

	// Token: 0x060042CD RID: 17101 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037E2")]
	[Address(RVA = "0x1E4DAF0", Offset = "0x1E4DBF1", VA = "0x1E4DAF0")]
	public void Setup(bool _is_farm_dragon, string _text)
	{
	}

	// Token: 0x060042CE RID: 17102 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037E3")]
	[Address(RVA = "0x1E4DB30", Offset = "0x1E4DC31", VA = "0x1E4DB30")]
	public WarpButtonBlock()
	{
	}

	// Token: 0x0400A177 RID: 41335
	[Token(Token = "0x40079EB")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Image border;

	// Token: 0x0400A178 RID: 41336
	[Token(Token = "0x40079EC")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private SText text;

	// Token: 0x0400A179 RID: 41337
	[Token(Token = "0x40079ED")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Sprite[] onOffSprite;

	// Token: 0x0400A17A RID: 41338
	[Token(Token = "0x40079EE")]
	[FieldOffset(Offset = "0x88")]
	private readonly Vector2[] BORDER_SIZE;

	// Token: 0x020009F2 RID: 2546
	[Token(Token = "0x20012C7")]
	public enum OnOff
	{
		// Token: 0x0400A17C RID: 41340
		[Token(Token = "0x401B3F0")]
		On,
		// Token: 0x0400A17D RID: 41341
		[Token(Token = "0x401B3F1")]
		Off,
		// Token: 0x0400A17E RID: 41342
		[Token(Token = "0x401B3F2")]
		Max
	}
}
