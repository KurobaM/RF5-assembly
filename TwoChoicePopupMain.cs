using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000AA5 RID: 2725
[Token(Token = "0x2000726")]
public class TwoChoicePopupMain : MonoBehaviour
{
	// Token: 0x060046E5 RID: 18149 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B67")]
	[Address(RVA = "0x1FFCDD0", Offset = "0x1FFCED1", VA = "0x1FFCDD0")]
	public void OpenMenu(UnityAction<bool> _OnSelected, string str, bool StartOnYesButton)
	{
	}

	// Token: 0x060046E6 RID: 18150 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B68")]
	[Address(RVA = "0x1FFD0F0", Offset = "0x1FFD1F1", VA = "0x1FFD0F0")]
	public void TouchSelect()
	{
	}

	// Token: 0x060046E7 RID: 18151 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B69")]
	[Address(RVA = "0x1FFD180", Offset = "0x1FFD281", VA = "0x1FFD180")]
	private void SwitchButton(bool selectButton)
	{
	}

	// Token: 0x060046E8 RID: 18152 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B6A")]
	[Address(RVA = "0x1FFD270", Offset = "0x1FFD371", VA = "0x1FFD270")]
	private void Update()
	{
	}

	// Token: 0x060046E9 RID: 18153 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B6B")]
	[Address(RVA = "0x1FFD780", Offset = "0x1FFD881", VA = "0x1FFD780", Slot = "4")]
	protected virtual void InitButtonHint()
	{
	}

	// Token: 0x060046EA RID: 18154 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B6C")]
	[Address(RVA = "0x1FFD810", Offset = "0x1FFD911", VA = "0x1FFD810", Slot = "5")]
	protected virtual void ClearButtonHint()
	{
	}

	// Token: 0x060046EB RID: 18155 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B6D")]
	[Address(RVA = "0x1FFCDA0", Offset = "0x1FFCEA1", VA = "0x1FFCDA0")]
	public TwoChoicePopupMain()
	{
	}

	// Token: 0x060046EC RID: 18156 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B6E")]
	[Address(RVA = "0x1FFD8D0", Offset = "0x1FFD9D1", VA = "0x1FFD8D0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7F50", Offset = "0x1A8051")]
	private void <OpenMenu>b__15_0()
	{
	}

	// Token: 0x060046ED RID: 18157 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B6F")]
	[Address(RVA = "0x1FFD8E0", Offset = "0x1FFD9E1", VA = "0x1FFD8E0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7F60", Offset = "0x1A8061")]
	private void <OpenMenu>b__15_1()
	{
	}

	// Token: 0x0400A5DB RID: 42459
	[Token(Token = "0x4007D5A")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ChoiceButton yesButton;

	// Token: 0x0400A5DC RID: 42460
	[Token(Token = "0x4007D5B")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ChoiceButton noButton;

	// Token: 0x0400A5DD RID: 42461
	[Token(Token = "0x4007D5C")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Image YesChoiceImg;

	// Token: 0x0400A5DE RID: 42462
	[Token(Token = "0x4007D5D")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Image NoChoiceImg;

	// Token: 0x0400A5DF RID: 42463
	[Token(Token = "0x4007D5E")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Text HeadText;

	// Token: 0x0400A5E0 RID: 42464
	[Token(Token = "0x4007D5F")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private RectTransform BorderMask;

	// Token: 0x0400A5E1 RID: 42465
	[Token(Token = "0x4007D60")]
	[FieldOffset(Offset = "0x48")]
	private bool isOpening;

	// Token: 0x0400A5E2 RID: 42466
	[Token(Token = "0x4007D61")]
	[FieldOffset(Offset = "0x49")]
	private bool isYesSelect;

	// Token: 0x0400A5E3 RID: 42467
	[Token(Token = "0x4007D62")]
	[FieldOffset(Offset = "0x50")]
	private UnityAction<bool> OnSelected;

	// Token: 0x0400A5E4 RID: 42468
	[Token(Token = "0x4007D63")]
	[FieldOffset(Offset = "0x58")]
	private bool Selected;

	// Token: 0x0400A5E5 RID: 42469
	[Token(Token = "0x4007D64")]
	[FieldOffset(Offset = "0x5C")]
	private float openTime;

	// Token: 0x0400A5E6 RID: 42470
	[Token(Token = "0x4007D65")]
	[FieldOffset(Offset = "0x60")]
	private float openTimeMax;

	// Token: 0x0400A5E7 RID: 42471
	[Token(Token = "0x4007D66")]
	[FieldOffset(Offset = "0x64")]
	private float closeTime;

	// Token: 0x0400A5E8 RID: 42472
	[Token(Token = "0x4007D67")]
	[FieldOffset(Offset = "0x68")]
	private float closeTimeMax;

	// Token: 0x0400A5E9 RID: 42473
	[Token(Token = "0x4007D68")]
	[FieldOffset(Offset = "0x6C")]
	private ButtonGuideId guideOnOpenId;
}
