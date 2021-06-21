using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020009F7 RID: 2551
[Token(Token = "0x20006B0")]
public class CalendarDiscription : CursorEvent
{
	// Token: 0x060042F6 RID: 17142 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003807")]
	[Address(RVA = "0x1E74720", Offset = "0x1E74821", VA = "0x1E74720")]
	private void ClearDetailText()
	{
	}

	// Token: 0x060042F7 RID: 17143 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003808")]
	[Address(RVA = "0x1E747D0", Offset = "0x1E748D1", VA = "0x1E747D0")]
	private void Start()
	{
	}

	// Token: 0x060042F8 RID: 17144 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003809")]
	[Address(RVA = "0x1E74840", Offset = "0x1E74941", VA = "0x1E74840", Slot = "7")]
	public override void OnFocusIn(CursorLinker focusObject)
	{
	}

	// Token: 0x060042F9 RID: 17145 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600380A")]
	[Address(RVA = "0x1E74990", Offset = "0x1E74A91", VA = "0x1E74990")]
	public CalendarDiscription()
	{
	}

	// Token: 0x0400A194 RID: 41364
	[Token(Token = "0x4007A01")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Text[] DetailText;

	// Token: 0x0400A195 RID: 41365
	[Token(Token = "0x4007A02")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Text DateText;

	// Token: 0x0400A196 RID: 41366
	[Token(Token = "0x4007A03")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Text MonthText;

	// Token: 0x0400A197 RID: 41367
	[Token(Token = "0x4007A04")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Text YearText;

	// Token: 0x0400A198 RID: 41368
	[Token(Token = "0x4007A05")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Text FesDetailText;
}
