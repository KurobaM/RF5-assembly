using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020009F9 RID: 2553
[Token(Token = "0x20006B2")]
public class DateSlotControl : ButtonLinker
{
	// Token: 0x060042FC RID: 17148 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600380D")]
	[Address(RVA = "0x1DA6FA0", Offset = "0x1DA70A1", VA = "0x1DA6FA0")]
	public void DoInit(int year, int season, int date, RectTransform parentRect)
	{
	}

	// Token: 0x060042FD RID: 17149 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600380E")]
	[Address(RVA = "0x1DA7190", Offset = "0x1DA7291", VA = "0x1DA7190")]
	public void SetIcon()
	{
	}

	// Token: 0x060042FE RID: 17150 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600380F")]
	[Address(RVA = "0x1DA7C30", Offset = "0x1DA7D31", VA = "0x1DA7C30")]
	public void SetTextDetail(Text[] texts, Text FesText)
	{
	}

	// Token: 0x060042FF RID: 17151 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003810")]
	[Address(RVA = "0x1DA82C0", Offset = "0x1DA83C1", VA = "0x1DA82C0")]
	public string GetDateText()
	{
		return null;
	}

	// Token: 0x06004300 RID: 17152 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003811")]
	[Address(RVA = "0x1DA83F0", Offset = "0x1DA84F1", VA = "0x1DA83F0")]
	public string GetYearText()
	{
		return null;
	}

	// Token: 0x06004301 RID: 17153 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003812")]
	[Address(RVA = "0x1DA8540", Offset = "0x1DA8641", VA = "0x1DA8540")]
	public string GetMonthText()
	{
		return null;
	}

	// Token: 0x06004302 RID: 17154 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003813")]
	[Address(RVA = "0x1DA87C0", Offset = "0x1DA88C1", VA = "0x1DA87C0", Slot = "8")]
	public override void OnNextFocus(CursorLinker nextObject)
	{
	}

	// Token: 0x06004303 RID: 17155 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003814")]
	[Address(RVA = "0x1DA8840", Offset = "0x1DA8941", VA = "0x1DA8840", Slot = "10")]
	public override void OnFocus()
	{
	}

	// Token: 0x06004304 RID: 17156 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003815")]
	[Address(RVA = "0x1DA8910", Offset = "0x1DA8A11", VA = "0x1DA8910")]
	public DateSlotControl()
	{
	}

	// Token: 0x0400A19D RID: 41373
	[Token(Token = "0x4007A0A")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Text DateText;

	// Token: 0x0400A19E RID: 41374
	[Token(Token = "0x4007A0B")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Image SlotImg;

	// Token: 0x0400A19F RID: 41375
	[Token(Token = "0x4007A0C")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Image FesIcon;

	// Token: 0x0400A1A0 RID: 41376
	[Token(Token = "0x4007A0D")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Image MinigameFesIcon;

	// Token: 0x0400A1A1 RID: 41377
	[Token(Token = "0x4007A0E")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Image[] BirthDayIcon;

	// Token: 0x0400A1A2 RID: 41378
	[Token(Token = "0x4007A0F")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Sprite HolidaySprite;

	// Token: 0x0400A1A3 RID: 41379
	[Token(Token = "0x4007A10")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Sprite NonHolidaySprite;

	// Token: 0x0400A1A4 RID: 41380
	[Token(Token = "0x4007A11")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private Sprite SelectingSprite;

	// Token: 0x0400A1A5 RID: 41381
	[Token(Token = "0x4007A12")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private Image myDateIcon;

	// Token: 0x0400A1A6 RID: 41382
	[Token(Token = "0x4007A13")]
	[FieldOffset(Offset = "0xA8")]
	private List<NPCID> BirthdayNpcidList;

	// Token: 0x0400A1A7 RID: 41383
	[Token(Token = "0x4007A14")]
	[FieldOffset(Offset = "0xB0")]
	private int MySeason;

	// Token: 0x0400A1A8 RID: 41384
	[Token(Token = "0x4007A15")]
	[FieldOffset(Offset = "0xB4")]
	private int MyDate;

	// Token: 0x0400A1A9 RID: 41385
	[Token(Token = "0x4007A16")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private bool SetFocusToday;

	// Token: 0x0400A1AA RID: 41386
	[Token(Token = "0x4007A17")]
	[FieldOffset(Offset = "0xBC")]
	public CalendarDataTable.FestivalId FestivalId;

	// Token: 0x0400A1AB RID: 41387
	[Token(Token = "0x4007A18")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private UICalendarMenu UICalendarMenu;

	// Token: 0x0400A1AC RID: 41388
	[Token(Token = "0x4007A19")]
	[FieldOffset(Offset = "0x0")]
	public static readonly MakingID[] MakingIdFestivalTable;

	// Token: 0x0400A1AD RID: 41389
	[Token(Token = "0x4007A1A")]
	[FieldOffset(Offset = "0xC8")]
	private readonly GameFlagData[] birthdayFlagTable;
}
