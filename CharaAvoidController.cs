using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001ED RID: 493
[Token(Token = "0x200018B")]
public abstract class CharaAvoidController<T> : AvoidController where T : Character
{
	// Token: 0x06000A01 RID: 2561 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008B2")]
	protected void Awake()
	{
	}

	// Token: 0x06000A02 RID: 2562 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008B3")]
	protected virtual void OnEnable()
	{
	}

	// Token: 0x06000A03 RID: 2563 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008B4")]
	protected virtual void OnDisable()
	{
	}

	// Token: 0x06000A04 RID: 2564 RVA: 0x000050A0 File Offset: 0x000032A0
	[Token(Token = "0x60008B5")]
	public override bool CanPlay()
	{
		return default(bool);
	}

	// Token: 0x06000A05 RID: 2565 RVA: 0x000050B8 File Offset: 0x000032B8
	[Token(Token = "0x60008B6")]
	public override bool DoPlay()
	{
		return default(bool);
	}

	// Token: 0x06000A06 RID: 2566 RVA: 0x000050D0 File Offset: 0x000032D0
	[Token(Token = "0x60008B7")]
	public override bool DoStop()
	{
		return default(bool);
	}

	// Token: 0x06000A07 RID: 2567 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008B8")]
	public override void OnUpdate()
	{
	}

	// Token: 0x06000A08 RID: 2568 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008B9")]
	protected CharaAvoidController()
	{
	}

	// Token: 0x0400065C RID: 1628
	[Token(Token = "0x4000505")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected T chara;
}
