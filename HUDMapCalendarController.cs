using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020009B1 RID: 2481
[Token(Token = "0x200067F")]
public class HUDMapCalendarController : SingletonMonoBehaviour<HUDMapCalendarController>
{
	// Token: 0x060040BB RID: 16571 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035F6")]
	[Address(RVA = "0x204C650", Offset = "0x204C751", VA = "0x204C650")]
	private void Start()
	{
	}

	// Token: 0x060040BC RID: 16572 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035F7")]
	[Address(RVA = "0x204C870", Offset = "0x204C971", VA = "0x204C870")]
	private void Update()
	{
	}

	// Token: 0x060040BD RID: 16573 RVA: 0x00015DB0 File Offset: 0x00013FB0
	[Token(Token = "0x60035F8")]
	[Address(RVA = "0x204CC60", Offset = "0x204CD61", VA = "0x204CC60")]
	private bool CheckBadStatusBlock()
	{
		return default(bool);
	}

	// Token: 0x060040BE RID: 16574 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035F9")]
	[Address(RVA = "0x204CAD0", Offset = "0x204CBD1", VA = "0x204CAD0")]
	private void OpenMap()
	{
	}

	// Token: 0x060040BF RID: 16575 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035FA")]
	[Address(RVA = "0x204C980", Offset = "0x204CA81", VA = "0x204C980")]
	private void OpenCalendar()
	{
	}

	// Token: 0x060040C0 RID: 16576 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035FB")]
	[Address(RVA = "0x204C7F0", Offset = "0x204C8F1", VA = "0x204C7F0")]
	public void SetMapActive(bool _flag)
	{
	}

	// Token: 0x060040C1 RID: 16577 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035FC")]
	[Address(RVA = "0x204C830", Offset = "0x204C931", VA = "0x204C830")]
	public void SetCalendarActive(bool _flag)
	{
	}

	// Token: 0x060040C2 RID: 16578 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035FD")]
	[Address(RVA = "0x204CD80", Offset = "0x204CE81", VA = "0x204CD80")]
	public HUDMapCalendarController()
	{
	}

	// Token: 0x060040C3 RID: 16579 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035FE")]
	[Address(RVA = "0x204CDD0", Offset = "0x204CED1", VA = "0x204CDD0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7350", Offset = "0x1A7451")]
	private void <Start>b__2_0()
	{
	}

	// Token: 0x060040C4 RID: 16580 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035FF")]
	[Address(RVA = "0x204CDE0", Offset = "0x204CEE1", VA = "0x204CDE0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7360", Offset = "0x1A7461")]
	private void <Start>b__2_1()
	{
	}

	// Token: 0x04009F72 RID: 40818
	[Token(Token = "0x4007831")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private HUDButtonController mapButton;

	// Token: 0x04009F73 RID: 40819
	[Token(Token = "0x4007832")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private HUDButtonController calendarButton;
}
