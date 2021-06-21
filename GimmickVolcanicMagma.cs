using System;
using Define;
using Il2CppDummyDll;
using RF5_Sound;
using UnityEngine;

// Token: 0x020005F0 RID: 1520
[Token(Token = "0x2000446")]
public class GimmickVolcanicMagma : GimmickBase
{
	// Token: 0x06002571 RID: 9585 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F93")]
	[Address(RVA = "0x1FEC520", Offset = "0x1FEC621", VA = "0x1FEC520", Slot = "7")]
	public override void SetGimmickState(bool newState)
	{
	}

	// Token: 0x06002572 RID: 9586 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F94")]
	[Address(RVA = "0x1FEC530", Offset = "0x1FEC631", VA = "0x1FEC530", Slot = "9")]
	public override void Init()
	{
	}

	// Token: 0x06002573 RID: 9587 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F95")]
	[Address(RVA = "0x1FEC540", Offset = "0x1FEC641", VA = "0x1FEC540")]
	private void Awake()
	{
	}

	// Token: 0x06002574 RID: 9588 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F96")]
	[Address(RVA = "0x1FEC5C0", Offset = "0x1FEC6C1", VA = "0x1FEC5C0")]
	private void Update()
	{
	}

	// Token: 0x06002575 RID: 9589 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F97")]
	[Address(RVA = "0x1FEC780", Offset = "0x1FEC881", VA = "0x1FEC780")]
	private void StartVolcanicMagma()
	{
	}

	// Token: 0x06002576 RID: 9590 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F98")]
	[Address(RVA = "0x1FEC940", Offset = "0x1FECA41", VA = "0x1FEC940")]
	private void StartEffect()
	{
	}

	// Token: 0x06002577 RID: 9591 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F99")]
	[Address(RVA = "0x1FECC20", Offset = "0x1FECD21", VA = "0x1FECC20")]
	private void StopVolcanicMagma()
	{
	}

	// Token: 0x06002578 RID: 9592 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F9A")]
	[Address(RVA = "0x1FECC60", Offset = "0x1FECD61", VA = "0x1FECC60")]
	private void StopEffect()
	{
	}

	// Token: 0x06002579 RID: 9593 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F9B")]
	[Address(RVA = "0x1FEC660", Offset = "0x1FEC761", VA = "0x1FEC660")]
	private void StartSignEffect()
	{
	}

	// Token: 0x0600257A RID: 9594 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F9C")]
	[Address(RVA = "0x1FEC8A0", Offset = "0x1FEC9A1", VA = "0x1FEC8A0")]
	private void StopSignEffect()
	{
	}

	// Token: 0x0600257B RID: 9595 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F9D")]
	[Address(RVA = "0x1FECD50", Offset = "0x1FECE51", VA = "0x1FECD50")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x0600257C RID: 9596 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F9E")]
	[Address(RVA = "0x1FED100", Offset = "0x1FED201", VA = "0x1FED100")]
	public GimmickVolcanicMagma()
	{
	}

	// Token: 0x0600257D RID: 9597 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F9F")]
	[Address(RVA = "0x1FED120", Offset = "0x1FED221", VA = "0x1FED120")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1770", Offset = "0x1A1871")]
	private void <StartVolcanicMagma>b__19_0()
	{
	}

	// Token: 0x0600257E RID: 9598 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FA0")]
	[Address(RVA = "0x1FED160", Offset = "0x1FED261", VA = "0x1FED160")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1780", Offset = "0x1A1881")]
	private void <StartEffect>b__20_0(ParticleSystem effect)
	{
	}

	// Token: 0x0600257F RID: 9599 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FA1")]
	[Address(RVA = "0x1FED1E0", Offset = "0x1FED2E1", VA = "0x1FED1E0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1790", Offset = "0x1A1891")]
	private void <StartSignEffect>b__23_0(ParticleSystem effect)
	{
	}

	// Token: 0x04006CC0 RID: 27840
	[Token(Token = "0x40065E2")]
	private const EffectID EffectId = EffectID.Effect_Map_GimmickFire;

	// Token: 0x04006CC1 RID: 27841
	[Token(Token = "0x40065E3")]
	private const EffectID SignEffectId = EffectID.Effect_MapFireplace;

	// Token: 0x04006CC2 RID: 27842
	[Token(Token = "0x40065E4")]
	private const float SEPlayDistance = 32f;

	// Token: 0x04006CC3 RID: 27843
	[Token(Token = "0x40065E5")]
	[FieldOffset(Offset = "0x20")]
	private float CurrentTime;

	// Token: 0x04006CC4 RID: 27844
	[Token(Token = "0x40065E6")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float Interval;

	// Token: 0x04006CC5 RID: 27845
	[Token(Token = "0x40065E7")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float Duration;

	// Token: 0x04006CC6 RID: 27846
	[Token(Token = "0x40065E8")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float DamagePercent;

	// Token: 0x04006CC7 RID: 27847
	[Token(Token = "0x40065E9")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float Damage;

	// Token: 0x04006CC8 RID: 27848
	[Token(Token = "0x40065EA")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float AttackKnockbackPower;

	// Token: 0x04006CC9 RID: 27849
	[Token(Token = "0x40065EB")]
	[FieldOffset(Offset = "0x38")]
	private Collider HitCollider;

	// Token: 0x04006CCA RID: 27850
	[Token(Token = "0x40065EC")]
	[FieldOffset(Offset = "0x40")]
	private ParticleSystem VolcanicEffect;

	// Token: 0x04006CCB RID: 27851
	[Token(Token = "0x40065ED")]
	[FieldOffset(Offset = "0x48")]
	private ParticleSystem SignEffect;

	// Token: 0x04006CCC RID: 27852
	[Token(Token = "0x40065EE")]
	[FieldOffset(Offset = "0x50")]
	private DamageInfo DamageInfo;

	// Token: 0x04006CCD RID: 27853
	[Token(Token = "0x40065EF")]
	[FieldOffset(Offset = "0xD0")]
	private SEController SEController;

	// Token: 0x04006CCE RID: 27854
	[Token(Token = "0x40065F0")]
	[FieldOffset(Offset = "0xD8")]
	private bool sign;
}
