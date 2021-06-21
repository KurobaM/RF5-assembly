using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002D0 RID: 720
[Token(Token = "0x2000231")]
public abstract class CharaSlowStateController<T> : SlowStateController where T : Character
{
	// Token: 0x06001332 RID: 4914 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001175")]
	protected override void Awake()
	{
	}

	// Token: 0x06001333 RID: 4915 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001176")]
	protected virtual void OnEnable()
	{
	}

	// Token: 0x06001334 RID: 4916 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001177")]
	protected override void OnDisable()
	{
	}

	// Token: 0x06001335 RID: 4917 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001178")]
	public override void OnUpdate()
	{
	}

	// Token: 0x06001336 RID: 4918 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001179")]
	public override void DoSlow()
	{
	}

	// Token: 0x06001337 RID: 4919 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600117A")]
	protected CharaSlowStateController()
	{
	}

	// Token: 0x04000AD6 RID: 2774
	[Token(Token = "0x4000876")]
	private const float SlowStateDuration = 10f;

	// Token: 0x04000AD7 RID: 2775
	[Token(Token = "0x4000877")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected T chara;

	// Token: 0x04000AD8 RID: 2776
	[Token(Token = "0x4000878")]
	[FieldOffset(Offset = "0x0")]
	private float m_elapsed;
}
