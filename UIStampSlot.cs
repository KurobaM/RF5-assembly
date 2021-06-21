using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000A31 RID: 2609
[Token(Token = "0x20006DB")]
public class UIStampSlot : UIButtonLinkerInScrollBox
{
	// Token: 0x06004444 RID: 17476 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600392D")]
	[Address(RVA = "0x211F500", Offset = "0x211F601", VA = "0x211F500", Slot = "16")]
	public override void Init()
	{
	}

	// Token: 0x06004445 RID: 17477 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600392E")]
	[Address(RVA = "0x211F590", Offset = "0x211F691", VA = "0x211F590", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x06004446 RID: 17478 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600392F")]
	[Address(RVA = "0x211F790", Offset = "0x211F891", VA = "0x211F790")]
	private new void OnTouch()
	{
	}

	// Token: 0x06004447 RID: 17479 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003930")]
	[Address(RVA = "0x211F7B0", Offset = "0x211F8B1", VA = "0x211F7B0", Slot = "10")]
	public override void OnFocus()
	{
	}

	// Token: 0x06004448 RID: 17480 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003931")]
	[Address(RVA = "0x211F810", Offset = "0x211F911", VA = "0x211F810", Slot = "11")]
	public override void EndFocus()
	{
	}

	// Token: 0x06004449 RID: 17481 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003932")]
	[Address(RVA = "0x211F0B0", Offset = "0x211F1B1", VA = "0x211F0B0")]
	public void Setup(int _focus_index)
	{
	}

	// Token: 0x0600444A RID: 17482 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003933")]
	[Address(RVA = "0x211F870", Offset = "0x211F971", VA = "0x211F870")]
	public UIStampSlot()
	{
	}

	// Token: 0x0600444B RID: 17483 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003934")]
	[Address(RVA = "0x211F8E0", Offset = "0x211F9E1", VA = "0x211F8E0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7820", Offset = "0x1A7921")]
	private void <Awake>b__7_0(BaseEventData _data)
	{
	}

	// Token: 0x0400A332 RID: 41778
	[Token(Token = "0x4007B65")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Sprite[] onOffSprite;

	// Token: 0x0400A333 RID: 41779
	[Token(Token = "0x4007B66")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Image stampIcon;

	// Token: 0x0400A334 RID: 41780
	[Token(Token = "0x4007B67")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Image stampTextBorder;

	// Token: 0x0400A335 RID: 41781
	[Token(Token = "0x4007B68")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Text stampText;

	// Token: 0x0400A336 RID: 41782
	[Token(Token = "0x4007B69")]
	[FieldOffset(Offset = "0x90")]
	private UIStampList stampList;

	// Token: 0x02000A32 RID: 2610
	[Token(Token = "0x20012D8")]
	public enum OnOff
	{
		// Token: 0x0400A338 RID: 41784
		[Token(Token = "0x401B431")]
		On,
		// Token: 0x0400A339 RID: 41785
		[Token(Token = "0x401B432")]
		Off,
		// Token: 0x0400A33A RID: 41786
		[Token(Token = "0x401B433")]
		Max
	}
}
