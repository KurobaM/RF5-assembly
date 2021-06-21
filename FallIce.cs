using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005C1 RID: 1473
[Token(Token = "0x2000423")]
public class FallIce : MonoBehaviour
{
	// Token: 0x0600241F RID: 9247 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E65")]
	[Address(RVA = "0x21C7E20", Offset = "0x21C7F21", VA = "0x21C7E20")]
	private void Awake()
	{
	}

	// Token: 0x06002420 RID: 9248 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E66")]
	[Address(RVA = "0x21C7FB0", Offset = "0x21C80B1", VA = "0x21C7FB0")]
	private void Start()
	{
	}

	// Token: 0x06002421 RID: 9249 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E67")]
	[Address(RVA = "0x21C80E0", Offset = "0x21C81E1", VA = "0x21C80E0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06002422 RID: 9250 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E68")]
	[Address(RVA = "0x21C8500", Offset = "0x21C8601", VA = "0x21C8500")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06002423 RID: 9251 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E69")]
	[Address(RVA = "0x21C88F0", Offset = "0x21C89F1", VA = "0x21C88F0")]
	private void Break()
	{
	}

	// Token: 0x06002424 RID: 9252 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E6A")]
	[Address(RVA = "0x21C8A70", Offset = "0x21C8B71", VA = "0x21C8A70")]
	public FallIce()
	{
	}

	// Token: 0x06002425 RID: 9253 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E6B")]
	[Address(RVA = "0x21C8AA0", Offset = "0x21C8BA1", VA = "0x21C8AA0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A12D0", Offset = "0x1A13D1")]
	private void <Start>b__17_0(ParticleSystem obj)
	{
	}

	// Token: 0x06002426 RID: 9254 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E6C")]
	[Address(RVA = "0x21C8AB0", Offset = "0x21C8BB1", VA = "0x21C8AB0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A12E0", Offset = "0x1A13E1")]
	private void <Start>b__17_1(ParticleSystem obj)
	{
	}

	// Token: 0x04006B83 RID: 27523
	[Token(Token = "0x40064DA")]
	[FieldOffset(Offset = "0x18")]
	public float DamagePercent;

	// Token: 0x04006B84 RID: 27524
	[Token(Token = "0x40064DB")]
	[FieldOffset(Offset = "0x1C")]
	public float AttackKnockbackPower;

	// Token: 0x04006B85 RID: 27525
	[Token(Token = "0x40064DC")]
	[FieldOffset(Offset = "0x20")]
	public float FallAccelSpeed;

	// Token: 0x04006B86 RID: 27526
	[Token(Token = "0x40064DD")]
	[FieldOffset(Offset = "0x24")]
	public float FallMaxSpeed;

	// Token: 0x04006B87 RID: 27527
	[Token(Token = "0x40064DE")]
	[FieldOffset(Offset = "0x28")]
	public float FallStartTime;

	// Token: 0x04006B88 RID: 27528
	[Token(Token = "0x40064DF")]
	[FieldOffset(Offset = "0x2C")]
	public float ColliderStartTime;

	// Token: 0x04006B89 RID: 27529
	[Token(Token = "0x40064E0")]
	[FieldOffset(Offset = "0x30")]
	public float ShadowScale5m;

	// Token: 0x04006B8A RID: 27530
	[Token(Token = "0x40064E1")]
	[FieldOffset(Offset = "0x34")]
	public float ShadowScale0m;

	// Token: 0x04006B8B RID: 27531
	[Token(Token = "0x40064E2")]
	[FieldOffset(Offset = "0x38")]
	private float time_;

	// Token: 0x04006B8C RID: 27532
	[Token(Token = "0x40064E3")]
	[FieldOffset(Offset = "0x3C")]
	private float CurrentSpeed;

	// Token: 0x04006B8D RID: 27533
	[Token(Token = "0x40064E4")]
	[FieldOffset(Offset = "0x40")]
	private bool IsBreak;

	// Token: 0x04006B8E RID: 27534
	[Token(Token = "0x40064E5")]
	[FieldOffset(Offset = "0x48")]
	private ParticleSystem tulala;

	// Token: 0x04006B8F RID: 27535
	[Token(Token = "0x40064E6")]
	[FieldOffset(Offset = "0x50")]
	private ParticleSystem shadow;

	// Token: 0x04006B90 RID: 27536
	[Token(Token = "0x40064E7")]
	[FieldOffset(Offset = "0x58")]
	private ParticleDestroy showdowTransform;

	// Token: 0x04006B91 RID: 27537
	[Token(Token = "0x40064E8")]
	[FieldOffset(Offset = "0x60")]
	private GameObject shadowPos;

	// Token: 0x04006B92 RID: 27538
	[Token(Token = "0x40064E9")]
	[FieldOffset(Offset = "0x68")]
	private Collider _collider;
}
