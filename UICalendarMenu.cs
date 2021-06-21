using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000A6A RID: 2666
[Token(Token = "0x2000700")]
public class UICalendarMenu : CursorLinkConnector
{
	// Token: 0x06004590 RID: 17808 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A36")]
	[Address(RVA = "0x1FFF6C0", Offset = "0x1FFF7C1", VA = "0x1FFF6C0")]
	public static void OpenBirthdaySelecter(UnityAction<int, int> endCallback)
	{
	}

	// Token: 0x06004591 RID: 17809 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A37")]
	[Address(RVA = "0x1FFF810", Offset = "0x1FFF911", VA = "0x1FFF810")]
	private void Start()
	{
	}

	// Token: 0x06004592 RID: 17810 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A38")]
	[Address(RVA = "0x1FFFBF0", Offset = "0x1FFFCF1", VA = "0x1FFFBF0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06004593 RID: 17811 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A39")]
	[Address(RVA = "0x1FFFC50", Offset = "0x1FFFD51", VA = "0x1FFFC50")]
	private void SetSeasonSprite()
	{
	}

	// Token: 0x06004594 RID: 17812 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003A3A")]
	[Address(RVA = "0x1FFFDA0", Offset = "0x1FFFEA1", VA = "0x1FFFDA0")]
	private string GetDayOfWeekStr(int day)
	{
		return null;
	}

	// Token: 0x06004595 RID: 17813 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A3B")]
	[Address(RVA = "0x20000B0", Offset = "0x20001B1", VA = "0x20000B0")]
	public void DoSetBirthday()
	{
	}

	// Token: 0x06004596 RID: 17814 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A3C")]
	[Address(RVA = "0x2000500", Offset = "0x2000601", VA = "0x2000500")]
	public void SetFocusingBirthday(int date, int season)
	{
	}

	// Token: 0x06004597 RID: 17815 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A3D")]
	[Address(RVA = "0x1FFFAA0", Offset = "0x1FFFBA1", VA = "0x1FFFAA0")]
	private void ForceChangePage(int nextPage)
	{
	}

	// Token: 0x06004598 RID: 17816 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A3E")]
	[Address(RVA = "0x2000590", Offset = "0x2000691", VA = "0x2000590")]
	private void SetChangePage(int nextPage)
	{
	}

	// Token: 0x06004599 RID: 17817 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A3F")]
	[Address(RVA = "0x2000600", Offset = "0x2000701", VA = "0x2000600")]
	private void Update()
	{
	}

	// Token: 0x0600459A RID: 17818 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A40")]
	[Address(RVA = "0x20009A0", Offset = "0x2000AA1", VA = "0x20009A0")]
	public UICalendarMenu()
	{
	}

	// Token: 0x0600459C RID: 17820 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A42")]
	[Address(RVA = "0x20009E0", Offset = "0x2000AE1", VA = "0x20009E0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7BE0", Offset = "0x1A7CE1")]
	private void <Start>b__24_0(bool select)
	{
	}

	// Token: 0x0600459D RID: 17821 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A43")]
	[Address(RVA = "0x20009F0", Offset = "0x2000AF1", VA = "0x20009F0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7BF0", Offset = "0x1A7CF1")]
	private void <DoSetBirthday>b__28_0(bool select)
	{
	}

	// Token: 0x0400A45B RID: 42075
	[Token(Token = "0x4007C44")]
	[FieldOffset(Offset = "0x0")]
	public static bool IsFurniture;

	// Token: 0x0400A45C RID: 42076
	[Token(Token = "0x4007C45")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private RectTransform CalendarPage;

	// Token: 0x0400A45D RID: 42077
	[Token(Token = "0x4007C46")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private CalendarDiscription calendarDiscription;

	// Token: 0x0400A45E RID: 42078
	[Token(Token = "0x4007C47")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private ButtonLinker[] PagesBtn;

	// Token: 0x0400A45F RID: 42079
	[Token(Token = "0x4007C48")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Image NowBGImage;

	// Token: 0x0400A460 RID: 42080
	[Token(Token = "0x4007C49")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Image FromBGImage;

	// Token: 0x0400A461 RID: 42081
	[Token(Token = "0x4007C4A")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Sprite[] BGSprites;

	// Token: 0x0400A462 RID: 42082
	[Token(Token = "0x4007C4B")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Image LArrowImage;

	// Token: 0x0400A463 RID: 42083
	[Token(Token = "0x4007C4C")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Image RArrowImage;

	// Token: 0x0400A464 RID: 42084
	[Token(Token = "0x4007C4D")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private Sprite[] ArrowSprites;

	// Token: 0x0400A465 RID: 42085
	[Token(Token = "0x4007C4E")]
	[FieldOffset(Offset = "0xA0")]
	public int FromPage;

	// Token: 0x0400A466 RID: 42086
	[Token(Token = "0x4007C4F")]
	[FieldOffset(Offset = "0xA4")]
	public int NowPage;

	// Token: 0x0400A467 RID: 42087
	[Token(Token = "0x4007C50")]
	[FieldOffset(Offset = "0xA8")]
	public int PageMax;

	// Token: 0x0400A468 RID: 42088
	[Token(Token = "0x4007C51")]
	[FieldOffset(Offset = "0xAC")]
	private float MoveTimeMax;

	// Token: 0x0400A469 RID: 42089
	[Token(Token = "0x4007C52")]
	[FieldOffset(Offset = "0xB0")]
	private float MoveDelayTime;

	// Token: 0x0400A46A RID: 42090
	[Token(Token = "0x4007C53")]
	[FieldOffset(Offset = "0xB4")]
	private float startPosX;

	// Token: 0x0400A46B RID: 42091
	[Token(Token = "0x4007C54")]
	[FieldOffset(Offset = "0xB8")]
	private float nextPosX;

	// Token: 0x0400A46C RID: 42092
	[Token(Token = "0x4007C55")]
	[FieldOffset(Offset = "0xBC")]
	private float SlideSize;

	// Token: 0x0400A46D RID: 42093
	[Token(Token = "0x4007C56")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	public bool isBirthdaySelecter;

	// Token: 0x0400A46E RID: 42094
	[Token(Token = "0x4007C57")]
	[FieldOffset(Offset = "0x4")]
	private static int focusingDate;

	// Token: 0x0400A46F RID: 42095
	[Token(Token = "0x4007C58")]
	[FieldOffset(Offset = "0x8")]
	private static int focusingSeason;

	// Token: 0x0400A470 RID: 42096
	[Token(Token = "0x4007C59")]
	[FieldOffset(Offset = "0x10")]
	private static UnityAction<int, int> EndCallback;

	// Token: 0x0400A471 RID: 42097
	[Token(Token = "0x4007C5A")]
	[FieldOffset(Offset = "0xC1")]
	private bool popupOpening;

	// Token: 0x02000A6B RID: 2667
	[Token(Token = "0x20012EC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159130", Offset = "0x159231")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x0600459F RID: 17823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600763F")]
		[Address(RVA = "0x2000B10", Offset = "0x2000C11", VA = "0x2000B10")]
		public <>c()
		{
		}

		// Token: 0x060045A0 RID: 17824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007640")]
		[Address(RVA = "0x2000B20", Offset = "0x2000C21", VA = "0x2000B20")]
		internal void <OpenBirthdaySelecter>b__23_0()
		{
		}

		// Token: 0x0400A472 RID: 42098
		[Token(Token = "0x401B47A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly UICalendarMenu.<>c <>9;

		// Token: 0x0400A473 RID: 42099
		[Token(Token = "0x401B47B")]
		[FieldOffset(Offset = "0x8")]
		public static UnityAction <>9__23_0;
	}
}
