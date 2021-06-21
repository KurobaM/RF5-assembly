using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001EF RID: 495
[Token(Token = "0x200018D")]
public abstract class CharaBattleModeController<T> : BattleModeController where T : Character
{
	// Token: 0x06000A10 RID: 2576 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008C1")]
	protected void Awake()
	{
	}

	// Token: 0x06000A11 RID: 2577 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008C2")]
	protected virtual void OnEnable()
	{
	}

	// Token: 0x06000A12 RID: 2578 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008C3")]
	protected virtual void OnDisable()
	{
	}

	// Token: 0x06000A13 RID: 2579 RVA: 0x00005148 File Offset: 0x00003348
	[Token(Token = "0x60008C4")]
	public override bool CanStart()
	{
		return default(bool);
	}

	// Token: 0x06000A14 RID: 2580 RVA: 0x00005160 File Offset: 0x00003360
	[Token(Token = "0x60008C5")]
	public override bool CanEnd()
	{
		return default(bool);
	}

	// Token: 0x06000A15 RID: 2581 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008C6")]
	protected CharaBattleModeController()
	{
	}

	// Token: 0x0400065E RID: 1630
	[Token(Token = "0x4000507")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected T chara;
}
