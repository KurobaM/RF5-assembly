using System;
using Il2CppDummyDll;
using RF5Input;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x02000A4B RID: 2635
[Token(Token = "0x20006EE")]
public class UISaveButtonWork : ButtonWorkBase
{
	// Token: 0x060044CB RID: 17611 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039A8")]
	[Address(RVA = "0x1EB1D00", Offset = "0x1EB1E01", VA = "0x1EB1D00", Slot = "5")]
	public override void ButtonWork(Key btnType)
	{
	}

	// Token: 0x060044CC RID: 17612 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039A9")]
	[Address(RVA = "0x1EB1E40", Offset = "0x1EB1F41", VA = "0x1EB1E40", Slot = "6")]
	public override void OnFocusingUpdate()
	{
	}

	// Token: 0x060044CD RID: 17613 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039AA")]
	[Address(RVA = "0x1EB1FD0", Offset = "0x1EB20D1", VA = "0x1EB1FD0")]
	public UISaveButtonWork()
	{
	}

	// Token: 0x0400A3BC RID: 41916
	[Token(Token = "0x4007BDF")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private UnityEvent action;

	// Token: 0x0400A3BD RID: 41917
	[Token(Token = "0x4007BE0")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private UnityEvent UpButtonAction;

	// Token: 0x0400A3BE RID: 41918
	[Token(Token = "0x4007BE1")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private UnityEvent DownButtonAction;
}
