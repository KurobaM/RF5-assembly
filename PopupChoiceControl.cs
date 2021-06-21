using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x02000AA0 RID: 2720
[Token(Token = "0x2000722")]
public class PopupChoiceControl : MonoBehaviour
{
	// Token: 0x1700097A RID: 2426
	// (get) Token: 0x060046C0 RID: 18112 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700079C")]
	private AdvDialogControl AdvDialogControl
	{
		[Token(Token = "0x6003B44")]
		[Address(RVA = "0x28087F0", Offset = "0x28088F1", VA = "0x28087F0")]
		get
		{
			return null;
		}
	}

	// Token: 0x060046C1 RID: 18113 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B45")]
	[Address(RVA = "0x2808900", Offset = "0x2808A01", VA = "0x2808900")]
	private void Awake()
	{
	}

	// Token: 0x060046C2 RID: 18114 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B46")]
	[Address(RVA = "0x2808A60", Offset = "0x2808B61", VA = "0x2808A60")]
	public void ChoiceImageAdjustPosition()
	{
	}

	// Token: 0x060046C3 RID: 18115 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B47")]
	[Address(RVA = "0x2808C60", Offset = "0x2808D61", VA = "0x2808C60")]
	public void SetArrow()
	{
	}

	// Token: 0x060046C4 RID: 18116 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B48")]
	[Address(RVA = "0x2808D60", Offset = "0x2808E61", VA = "0x2808D60")]
	public void ChoiceDetailSet()
	{
	}

	// Token: 0x060046C5 RID: 18117 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B49")]
	[Address(RVA = "0x2808F20", Offset = "0x2809021", VA = "0x2808F20")]
	public void Selecting(int select)
	{
	}

	// Token: 0x060046C6 RID: 18118 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B4A")]
	[Address(RVA = "0x28090F0", Offset = "0x28091F1", VA = "0x28090F0")]
	public void CreateChoice(UnityAction<int> onSelectedEvent, List<string> texts, bool useCancelButton = false, bool pauseGameOnChoice = false)
	{
	}

	// Token: 0x060046C7 RID: 18119 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B4B")]
	[Address(RVA = "0x28093F0", Offset = "0x28094F1", VA = "0x28093F0")]
	public void CreateChoiceWithAdvText(UnityAction<int> onSelectedEvent, List<string> texts, List<string> texts2, List<string> advTexts, List<string> advNames, bool useCancelButton = false, bool pauseGameOnChoice = false)
	{
	}

	// Token: 0x060046C8 RID: 18120 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B4C")]
	[Address(RVA = "0x2809460", Offset = "0x2809561", VA = "0x2809460")]
	public void AddChoice(UnityAction<int> onSelectedEvent, string text, bool useCancelButton = false, bool pauseGameOnChoice = false)
	{
	}

	// Token: 0x060046C9 RID: 18121 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B4D")]
	[Address(RVA = "0x28097B0", Offset = "0x28098B1", VA = "0x28097B0")]
	public void AddChoice(UnityAction<int> onSelectedEvent, string text, string advText, string advName, bool useCancelButton = false, bool pauseGameOnChoice = false)
	{
	}

	// Token: 0x060046CA RID: 18122 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B4E")]
	[Address(RVA = "0x2809A30", Offset = "0x2809B31", VA = "0x2809A30")]
	private void ClearNotSelectedChoice()
	{
	}

	// Token: 0x060046CB RID: 18123 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B4F")]
	[Address(RVA = "0x28095D0", Offset = "0x28096D1", VA = "0x28095D0")]
	private void ClearAllChoice()
	{
	}

	// Token: 0x060046CC RID: 18124 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B50")]
	[Address(RVA = "0x2809B40", Offset = "0x2809C41", VA = "0x2809B40")]
	private void EndMessageSelected()
	{
	}

	// Token: 0x060046CD RID: 18125 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B51")]
	[Address(RVA = "0x2809C20", Offset = "0x2809D21", VA = "0x2809C20")]
	private void Input()
	{
	}

	// Token: 0x060046CE RID: 18126 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B52")]
	[Address(RVA = "0x280A080", Offset = "0x280A181", VA = "0x280A080")]
	private void OnSubmit()
	{
	}

	// Token: 0x060046CF RID: 18127 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B53")]
	[Address(RVA = "0x2809300", Offset = "0x2809401", VA = "0x2809300")]
	private void SetTouchEvent(int _index)
	{
	}

	// Token: 0x060046D0 RID: 18128 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B54")]
	[Address(RVA = "0x280A170", Offset = "0x280A271", VA = "0x280A170")]
	private void Update()
	{
	}

	// Token: 0x060046D1 RID: 18129 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B55")]
	[Address(RVA = "0x280A280", Offset = "0x280A381", VA = "0x280A280")]
	public PopupChoiceControl()
	{
	}

	// Token: 0x060046D3 RID: 18131 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B57")]
	[Address(RVA = "0x280A2C0", Offset = "0x280A3C1", VA = "0x280A2C0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7F30", Offset = "0x1A8031")]
	private void <Awake>b__28_0()
	{
	}

	// Token: 0x060046D4 RID: 18132 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B58")]
	[Address(RVA = "0x280A360", Offset = "0x280A461", VA = "0x280A360")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7F40", Offset = "0x1A8041")]
	private void <Awake>b__28_1()
	{
	}

	// Token: 0x0400A5AB RID: 42411
	[Token(Token = "0x4007D2C")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool isSingleton;

	// Token: 0x0400A5AC RID: 42412
	[Token(Token = "0x4007D2D")]
	[FieldOffset(Offset = "0x19")]
	[SerializeField]
	private bool UseFirstSuspension;

	// Token: 0x0400A5AD RID: 42413
	[Token(Token = "0x4007D2E")]
	[FieldOffset(Offset = "0x1A")]
	private bool onSuspension;

	// Token: 0x0400A5AE RID: 42414
	[Token(Token = "0x4007D2F")]
	[FieldOffset(Offset = "0x0")]
	public static PopupChoiceControl Instance;

	// Token: 0x0400A5AF RID: 42415
	[Token(Token = "0x4007D30")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ChoiceImage ChoiceImageObj;

	// Token: 0x0400A5B0 RID: 42416
	[Token(Token = "0x4007D31")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private RectTransform CenterChoice;

	// Token: 0x0400A5B1 RID: 42417
	[Token(Token = "0x4007D32")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private NonFocusButton UpArrow;

	// Token: 0x0400A5B2 RID: 42418
	[Token(Token = "0x4007D33")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private NonFocusButton DownArrow;

	// Token: 0x0400A5B3 RID: 42419
	[Token(Token = "0x4007D34")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float HeightMergin;

	// Token: 0x0400A5B4 RID: 42420
	[Token(Token = "0x4007D35")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private int DispMax;

	// Token: 0x0400A5B5 RID: 42421
	[Token(Token = "0x4007D36")]
	[FieldOffset(Offset = "0x48")]
	private float ChoiceImgHeight;

	// Token: 0x0400A5B6 RID: 42422
	[Token(Token = "0x4007D37")]
	[FieldOffset(Offset = "0x50")]
	private List<string> ChoiceTexts;

	// Token: 0x0400A5B7 RID: 42423
	[Token(Token = "0x4007D38")]
	[FieldOffset(Offset = "0x58")]
	private List<string> ChoiceTexts2;

	// Token: 0x0400A5B8 RID: 42424
	[Token(Token = "0x4007D39")]
	[FieldOffset(Offset = "0x60")]
	private List<ChoiceImage> ChoiceList;

	// Token: 0x0400A5B9 RID: 42425
	[Token(Token = "0x4007D3A")]
	[FieldOffset(Offset = "0x68")]
	private List<string> ChoiceAdvTexts;

	// Token: 0x0400A5BA RID: 42426
	[Token(Token = "0x4007D3B")]
	[FieldOffset(Offset = "0x70")]
	private List<string> ChoiceAdvNameTexts;

	// Token: 0x0400A5BB RID: 42427
	[Token(Token = "0x4007D3C")]
	[FieldOffset(Offset = "0x78")]
	private UnityAction<int> OnSelected;

	// Token: 0x0400A5BC RID: 42428
	[Token(Token = "0x4007D3D")]
	[FieldOffset(Offset = "0x80")]
	private int selecting;

	// Token: 0x0400A5BD RID: 42429
	[Token(Token = "0x4007D3E")]
	[FieldOffset(Offset = "0x84")]
	private int dispHead;

	// Token: 0x0400A5BE RID: 42430
	[Token(Token = "0x4007D3F")]
	[FieldOffset(Offset = "0x88")]
	private bool UseCancelButton;

	// Token: 0x0400A5BF RID: 42431
	[Token(Token = "0x4007D40")]
	[FieldOffset(Offset = "0x89")]
	private bool PauseGameOnChoice;

	// Token: 0x0400A5C0 RID: 42432
	[Token(Token = "0x4007D41")]
	private const float DefaultStartupTime = 0.3f;

	// Token: 0x0400A5C1 RID: 42433
	[Token(Token = "0x4007D42")]
	[FieldOffset(Offset = "0x8C")]
	private float StartupTime;

	// Token: 0x0400A5C2 RID: 42434
	[Token(Token = "0x4007D43")]
	private const float StartConfirmAcceptDelayMax = 0.8f;

	// Token: 0x0400A5C3 RID: 42435
	[Token(Token = "0x4007D44")]
	[FieldOffset(Offset = "0x90")]
	private float StartConfirmAcceptDelay;

	// Token: 0x0400A5C4 RID: 42436
	[Token(Token = "0x4007D45")]
	[FieldOffset(Offset = "0x98")]
	private AdvDialogControl _AdvDialogControl;

	// Token: 0x0400A5C5 RID: 42437
	[Token(Token = "0x4007D46")]
	[FieldOffset(Offset = "0xA0")]
	private bool IsSelected;

	// Token: 0x0400A5C6 RID: 42438
	[Token(Token = "0x4007D47")]
	private const float endWaitTimeMax = 0.3f;

	// Token: 0x0400A5C7 RID: 42439
	[Token(Token = "0x4007D48")]
	[FieldOffset(Offset = "0xA4")]
	private float endWaitTime;

	// Token: 0x02000AA1 RID: 2721
	[Token(Token = "0x2001300")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1591D0", Offset = "0x1592D1")]
	private sealed class <>c__DisplayClass45_0
	{
		// Token: 0x060046D5 RID: 18133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007660")]
		[Address(RVA = "0x280A160", Offset = "0x280A261", VA = "0x280A160")]
		public <>c__DisplayClass45_0()
		{
		}

		// Token: 0x060046D6 RID: 18134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007661")]
		[Address(RVA = "0x280A400", Offset = "0x280A501", VA = "0x280A400")]
		internal void <SetTouchEvent>b__0()
		{
		}

		// Token: 0x0400A5C8 RID: 42440
		[Token(Token = "0x401B4E2")]
		[FieldOffset(Offset = "0x10")]
		public PopupChoiceControl <>4__this;

		// Token: 0x0400A5C9 RID: 42441
		[Token(Token = "0x401B4E3")]
		[FieldOffset(Offset = "0x18")]
		public int _index;
	}
}
