using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000205 RID: 517
[Token(Token = "0x20001A1")]
public abstract class CharaGrappleController<T> : GrappleController where T : Character
{
	// Token: 0x06000AB1 RID: 2737 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000961")]
	protected override void Awake()
	{
	}

	// Token: 0x06000AB2 RID: 2738 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000962")]
	private void OnEnable()
	{
	}

	// Token: 0x06000AB3 RID: 2739 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000963")]
	private void OnDisable()
	{
	}

	// Token: 0x06000AB4 RID: 2740 RVA: 0x00005490 File Offset: 0x00003690
	[Token(Token = "0x6000964")]
	protected virtual DamageInfo CreateDamageInfo(MagicParamID id)
	{
		return default(DamageInfo);
	}

	// Token: 0x06000AB5 RID: 2741 RVA: 0x000054A8 File Offset: 0x000036A8
	[Token(Token = "0x6000965")]
	public override bool DoGrap(GrapInterface target)
	{
		return default(bool);
	}

	// Token: 0x06000AB6 RID: 2742 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000966")]
	public override void DoThrow(float angle, float power, MagicParamID id1, MagicParamID id2 = MagicParamID.EMPTY)
	{
	}

	// Token: 0x06000AB7 RID: 2743 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000967")]
	public override void TakeDamage(MagicParamID id)
	{
	}

	// Token: 0x06000AB8 RID: 2744 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000968")]
	protected override void ResetThrowPosition()
	{
	}

	// Token: 0x06000AB9 RID: 2745 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000969")]
	protected CharaGrappleController()
	{
	}

	// Token: 0x040006AB RID: 1707
	[Token(Token = "0x4000550")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected T chara;
}
