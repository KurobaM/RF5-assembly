using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000A8D RID: 2701
[Token(Token = "0x2000712")]
public class UIMovieSlot : UIButtonLinkerInScrollBox
{
	// Token: 0x06004654 RID: 18004 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AD8")]
	[Address(RVA = "0x1EA68A0", Offset = "0x1EA69A1", VA = "0x1EA68A0", Slot = "16")]
	public override void Init()
	{
	}

	// Token: 0x06004655 RID: 18005 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AD9")]
	[Address(RVA = "0x1EA6930", Offset = "0x1EA6A31", VA = "0x1EA6930", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x06004656 RID: 18006 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003ADA")]
	[Address(RVA = "0x1EA6A50", Offset = "0x1EA6B51", VA = "0x1EA6A50")]
	private new void OnTouch()
	{
	}

	// Token: 0x06004657 RID: 18007 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003ADB")]
	[Address(RVA = "0x1EA6A70", Offset = "0x1EA6B71", VA = "0x1EA6A70", Slot = "10")]
	public override void OnFocus()
	{
	}

	// Token: 0x06004658 RID: 18008 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003ADC")]
	[Address(RVA = "0x1EA6AD0", Offset = "0x1EA6BD1", VA = "0x1EA6AD0", Slot = "11")]
	public override void EndFocus()
	{
	}

	// Token: 0x06004659 RID: 18009 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003ADD")]
	[Address(RVA = "0x1EA6B30", Offset = "0x1EA6C31", VA = "0x1EA6B30")]
	public void Setup(int _index)
	{
	}

	// Token: 0x0600465A RID: 18010 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003ADE")]
	[Address(RVA = "0x1EA6B80", Offset = "0x1EA6C81", VA = "0x1EA6B80")]
	public UIMovieSlot()
	{
	}

	// Token: 0x0600465B RID: 18011 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003ADF")]
	[Address(RVA = "0x1EA6BF0", Offset = "0x1EA6CF1", VA = "0x1EA6BF0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7EA0", Offset = "0x1A7FA1")]
	private void <Awake>b__6_0(BaseEventData _data)
	{
	}

	// Token: 0x0400A562 RID: 42338
	[Token(Token = "0x4007CED")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Sprite[] onOffSprite;

	// Token: 0x0400A563 RID: 42339
	[Token(Token = "0x4007CEE")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Image movieTextBorder;

	// Token: 0x0400A564 RID: 42340
	[Token(Token = "0x4007CEF")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Text movieText;

	// Token: 0x0400A565 RID: 42341
	[Token(Token = "0x4007CF0")]
	[FieldOffset(Offset = "0x88")]
	private MovieRoom movieRoom;

	// Token: 0x02000A8E RID: 2702
	[Token(Token = "0x20012FD")]
	public enum OnOff
	{
		// Token: 0x0400A567 RID: 42343
		[Token(Token = "0x401B4D9")]
		On,
		// Token: 0x0400A568 RID: 42344
		[Token(Token = "0x401B4DA")]
		Off,
		// Token: 0x0400A569 RID: 42345
		[Token(Token = "0x401B4DB")]
		Max
	}
}
