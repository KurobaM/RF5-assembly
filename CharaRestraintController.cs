using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002C2 RID: 706
[Token(Token = "0x2000228")]
public abstract class CharaRestraintController<T> : RestraintController where T : Character
{
	// Token: 0x0600129C RID: 4764 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010FD")]
	protected override void Awake()
	{
	}

	// Token: 0x0600129D RID: 4765 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010FE")]
	protected virtual void OnEnable()
	{
	}

	// Token: 0x0600129E RID: 4766 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010FF")]
	protected override void OnDisable()
	{
	}

	// Token: 0x0600129F RID: 4767
	[Token(Token = "0x6001100")]
	protected abstract bool ReleaseCondition();

	// Token: 0x060012A0 RID: 4768 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001101")]
	public override void OnUpdate()
	{
	}

	// Token: 0x060012A1 RID: 4769 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001102")]
	public override void OnRestraint()
	{
	}

	// Token: 0x060012A2 RID: 4770 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001103")]
	protected CharaRestraintController()
	{
	}

	// Token: 0x04000A7B RID: 2683
	[Token(Token = "0x400082F")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected T chara;

	// Token: 0x04000A7C RID: 2684
	[Token(Token = "0x4000830")]
	[FieldOffset(Offset = "0x0")]
	protected float m_elapsed;
}
