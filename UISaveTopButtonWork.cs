using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using RF5Input;
using UnityEngine;

// Token: 0x02000A55 RID: 2645
[Token(Token = "0x20006F1")]
public class UISaveTopButtonWork : ButtonWorkBase
{
	// Token: 0x0600450A RID: 17674 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039D4")]
	[Address(RVA = "0x1EB58C0", Offset = "0x1EB59C1", VA = "0x1EB58C0", Slot = "5")]
	public override void ButtonWork(Key btnType)
	{
	}

	// Token: 0x0600450B RID: 17675 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039D5")]
	[Address(RVA = "0x1EB5980", Offset = "0x1EB5A81", VA = "0x1EB5980")]
	private void Update()
	{
	}

	// Token: 0x0600450C RID: 17676 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039D6")]
	[Address(RVA = "0x1EB5A70", Offset = "0x1EB5B71", VA = "0x1EB5A70", Slot = "7")]
	public override void OnFocus()
	{
	}

	// Token: 0x0600450D RID: 17677 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039D7")]
	[Address(RVA = "0x1EB5D20", Offset = "0x1EB5E21", VA = "0x1EB5D20")]
	public UISaveTopButtonWork()
	{
	}

	// Token: 0x0400A3F8 RID: 41976
	[Token(Token = "0x4007C00")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private UISaveMenuManager UISaveMenuManager;

	// Token: 0x0400A3F9 RID: 41977
	[Token(Token = "0x4007C01")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private UISaveMenuManager.PageState state;

	// Token: 0x0400A3FA RID: 41978
	[Token(Token = "0x4007C02")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public CursorLinker linkerObj;

	// Token: 0x0400A3FB RID: 41979
	[Token(Token = "0x4007C03")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private List<GameObject> OpenObjects;

	// Token: 0x0400A3FC RID: 41980
	[Token(Token = "0x4007C04")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private List<GameObject> CloseObjects;
}
