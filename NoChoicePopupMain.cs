using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000AA3 RID: 2723
[Token(Token = "0x2000724")]
public class NoChoicePopupMain : MonoBehaviour
{
	// Token: 0x060046DA RID: 18138 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B5C")]
	[Address(RVA = "0x1E23930", Offset = "0x1E23A31", VA = "0x1E23930")]
	public void OpenMenu(UnityAction<bool> _OnSelected, string str, TextAnchor anchor = TextAnchor.MiddleCenter)
	{
	}

	// Token: 0x060046DB RID: 18139 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B5D")]
	[Address(RVA = "0x1E23BD0", Offset = "0x1E23CD1", VA = "0x1E23BD0")]
	public void OpenMenu(UnityAction<bool> _OnSelected, List<string> strList, TextAnchor anchor = TextAnchor.MiddleCenter)
	{
	}

	// Token: 0x060046DC RID: 18140 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B5E")]
	[Address(RVA = "0x1E23F60", Offset = "0x1E24061", VA = "0x1E23F60")]
	public void TouchSelect()
	{
	}

	// Token: 0x060046DD RID: 18141 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B5F")]
	[Address(RVA = "0x1E23FF0", Offset = "0x1E240F1", VA = "0x1E23FF0")]
	private void Update()
	{
	}

	// Token: 0x060046DE RID: 18142 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B60")]
	[Address(RVA = "0x1E24270", Offset = "0x1E24371", VA = "0x1E24270")]
	private void updateClose()
	{
	}

	// Token: 0x060046DF RID: 18143 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B61")]
	[Address(RVA = "0x1E24410", Offset = "0x1E24511", VA = "0x1E24410", Slot = "4")]
	protected virtual void InitButtonHint()
	{
	}

	// Token: 0x060046E0 RID: 18144 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B62")]
	[Address(RVA = "0x1E244A0", Offset = "0x1E245A1", VA = "0x1E244A0", Slot = "5")]
	protected virtual void ClearButtonHint()
	{
	}

	// Token: 0x060046E1 RID: 18145 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B63")]
	[Address(RVA = "0x1E23900", Offset = "0x1E23A01", VA = "0x1E23900")]
	public NoChoicePopupMain()
	{
	}

	// Token: 0x0400A5CA RID: 42442
	[Token(Token = "0x4007D49")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ChoiceButton yesButton;

	// Token: 0x0400A5CB RID: 42443
	[Token(Token = "0x4007D4A")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Image YesChoiceImg;

	// Token: 0x0400A5CC RID: 42444
	[Token(Token = "0x4007D4B")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Text HeadText;

	// Token: 0x0400A5CD RID: 42445
	[Token(Token = "0x4007D4C")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private RectTransform BorderMask;

	// Token: 0x0400A5CE RID: 42446
	[Token(Token = "0x4007D4D")]
	[FieldOffset(Offset = "0x38")]
	private bool isOpening;

	// Token: 0x0400A5CF RID: 42447
	[Token(Token = "0x4007D4E")]
	[FieldOffset(Offset = "0x39")]
	private bool isYesSelect;

	// Token: 0x0400A5D0 RID: 42448
	[Token(Token = "0x4007D4F")]
	[FieldOffset(Offset = "0x40")]
	private UnityAction<bool> OnSelected;

	// Token: 0x0400A5D1 RID: 42449
	[Token(Token = "0x4007D50")]
	[FieldOffset(Offset = "0x48")]
	private bool Selected;

	// Token: 0x0400A5D2 RID: 42450
	[Token(Token = "0x4007D51")]
	[FieldOffset(Offset = "0x4C")]
	private float openTime;

	// Token: 0x0400A5D3 RID: 42451
	[Token(Token = "0x4007D52")]
	[FieldOffset(Offset = "0x50")]
	private float openTimeMax;

	// Token: 0x0400A5D4 RID: 42452
	[Token(Token = "0x4007D53")]
	[FieldOffset(Offset = "0x54")]
	private float closeTime;

	// Token: 0x0400A5D5 RID: 42453
	[Token(Token = "0x4007D54")]
	[FieldOffset(Offset = "0x58")]
	private float closeTimeMax;

	// Token: 0x0400A5D6 RID: 42454
	[Token(Token = "0x4007D55")]
	[FieldOffset(Offset = "0x5C")]
	private bool modePage;

	// Token: 0x0400A5D7 RID: 42455
	[Token(Token = "0x4007D56")]
	[FieldOffset(Offset = "0x60")]
	private int pageCnt;

	// Token: 0x0400A5D8 RID: 42456
	[Token(Token = "0x4007D57")]
	[FieldOffset(Offset = "0x68")]
	private List<string> messTextList;

	// Token: 0x0400A5D9 RID: 42457
	[Token(Token = "0x4007D58")]
	[FieldOffset(Offset = "0x70")]
	private float inputStayTime;

	// Token: 0x0400A5DA RID: 42458
	[Token(Token = "0x4007D59")]
	[FieldOffset(Offset = "0x74")]
	private ButtonGuideId guideOnOpenId;
}
