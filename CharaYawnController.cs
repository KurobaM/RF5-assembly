using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002D5 RID: 725
[Token(Token = "0x2000236")]
public abstract class CharaYawnController<T> : YawnController where T : Character
{
	// Token: 0x0600135B RID: 4955 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600119E")]
	protected void Awake()
	{
	}

	// Token: 0x0600135C RID: 4956 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600119F")]
	protected virtual void OnEnable()
	{
	}

	// Token: 0x0600135D RID: 4957 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011A0")]
	protected virtual void OnDisable()
	{
	}

	// Token: 0x0600135E RID: 4958 RVA: 0x00008B20 File Offset: 0x00006D20
	[Token(Token = "0x60011A1")]
	public override bool CanPlay()
	{
		return default(bool);
	}

	// Token: 0x0600135F RID: 4959 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011A2")]
	public override void OnUpdate()
	{
	}

	// Token: 0x06001360 RID: 4960 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011A3")]
	protected CharaYawnController()
	{
	}

	// Token: 0x04000AE3 RID: 2787
	[Token(Token = "0x4000883")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected T chara;
}
