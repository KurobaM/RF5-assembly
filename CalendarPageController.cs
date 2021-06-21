using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020009F8 RID: 2552
[Token(Token = "0x20006B1")]
public class CalendarPageController : CursorLinkConnector
{
	// Token: 0x060042FA RID: 17146 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600380B")]
	[Address(RVA = "0x1E74CF0", Offset = "0x1E74DF1", VA = "0x1E74CF0")]
	private void Start()
	{
	}

	// Token: 0x060042FB RID: 17147 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600380C")]
	[Address(RVA = "0x1E75200", Offset = "0x1E75301", VA = "0x1E75200")]
	public CalendarPageController()
	{
	}

	// Token: 0x0400A199 RID: 41369
	[Token(Token = "0x4007A06")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private DateSlotControl DateSlot;

	// Token: 0x0400A19A RID: 41370
	[Token(Token = "0x4007A07")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private RectTransform SlotPoint;

	// Token: 0x0400A19B RID: 41371
	[Token(Token = "0x4007A08")]
	[FieldOffset(Offset = "0x68")]
	private List<DateSlotControl> DateSlots;

	// Token: 0x0400A19C RID: 41372
	[Token(Token = "0x4007A09")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private int season;
}
