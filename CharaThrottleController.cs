using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000215 RID: 533
[Token(Token = "0x20001B1")]
public abstract class CharaThrottleController<T> : ThrottleController where T : Character
{
	// Token: 0x06000B29 RID: 2857 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009D9")]
	protected void Awake()
	{
	}

	// Token: 0x06000B2A RID: 2858 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009DA")]
	protected virtual void OnEnable()
	{
	}

	// Token: 0x06000B2B RID: 2859 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009DB")]
	protected virtual void OnDisable()
	{
	}

	// Token: 0x06000B2C RID: 2860 RVA: 0x000056E8 File Offset: 0x000038E8
	[Token(Token = "0x60009DC")]
	public override bool CanPlay()
	{
		return default(bool);
	}

	// Token: 0x06000B2D RID: 2861 RVA: 0x00005700 File Offset: 0x00003900
	[Token(Token = "0x60009DD")]
	public override bool DoPlay(ThrottleID throttleID)
	{
		return default(bool);
	}

	// Token: 0x06000B2E RID: 2862 RVA: 0x00005718 File Offset: 0x00003918
	[Token(Token = "0x60009DE")]
	public override bool DoStop()
	{
		return default(bool);
	}

	// Token: 0x06000B2F RID: 2863 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009DF")]
	protected CharaThrottleController()
	{
	}

	// Token: 0x040006D9 RID: 1753
	[Token(Token = "0x400057E")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected T chara;
}
