using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000905 RID: 2309
[Token(Token = "0x200060F")]
public class LaserProjectileBulletBehavior : ProjectileBulletBehaviorBase
{
	// Token: 0x06003C9D RID: 15517 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032F3")]
	[Address(RVA = "0x2303890", Offset = "0x2303991", VA = "0x2303890")]
	public LaserProjectileBulletBehavior(float maxLength, float laserSpeed, EffectID effectID, EffectID hitEffectID, EffectID launchPointEffectID, float effectTime, bool isForcePenetration)
	{
	}

	// Token: 0x06003C9E RID: 15518 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032F4")]
	[Address(RVA = "0x23039A0", Offset = "0x2303AA1", VA = "0x23039A0", Slot = "6")]
	public override void Setup(ProjectileBulletBase projectileBulletBase)
	{
	}

	// Token: 0x06003C9F RID: 15519 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032F5")]
	[Address(RVA = "0x2303A20", Offset = "0x2303B21", VA = "0x2303A20", Slot = "7")]
	public override void Start()
	{
	}

	// Token: 0x06003CA0 RID: 15520 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032F6")]
	[Address(RVA = "0x2303EF0", Offset = "0x2303FF1", VA = "0x2303EF0", Slot = "8")]
	public override void BeginUpdate()
	{
	}

	// Token: 0x06003CA1 RID: 15521 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032F7")]
	[Address(RVA = "0x2303FF0", Offset = "0x23040F1", VA = "0x2303FF0")]
	private void UpdateHitObject()
	{
	}

	// Token: 0x06003CA2 RID: 15522 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032F8")]
	[Address(RVA = "0x2303D90", Offset = "0x2303E91", VA = "0x2303D90")]
	private void UpdateCurrentLaserLength(float length)
	{
	}

	// Token: 0x06003CA3 RID: 15523 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032F9")]
	[Address(RVA = "0x2304360", Offset = "0x2304461", VA = "0x2304360")]
	private void UpdateEndEffect()
	{
	}

	// Token: 0x06003CA4 RID: 15524 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032FA")]
	[Address(RVA = "0x23043D0", Offset = "0x23044D1", VA = "0x23043D0")]
	private void DisableParticleEmission()
	{
	}

	// Token: 0x06003CA5 RID: 15525 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032FB")]
	[Address(RVA = "0x2304650", Offset = "0x2304751", VA = "0x2304650")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6B10", Offset = "0x1A6C11")]
	private void <Start>b__22_0(ParticleSystem startEffect)
	{
	}

	// Token: 0x06003CA6 RID: 15526 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032FC")]
	[Address(RVA = "0x2304750", Offset = "0x2304851", VA = "0x2304750")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6B20", Offset = "0x1A6C21")]
	private void <Start>b__22_1(ParticleSystem lastEffect)
	{
	}

	// Token: 0x06003CA7 RID: 15527 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032FD")]
	[Address(RVA = "0x2304850", Offset = "0x2304951", VA = "0x2304850")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6B30", Offset = "0x1A6C31")]
	private void <Start>b__22_2(ParticleSystem mainEffect)
	{
	}

	// Token: 0x04007EF6 RID: 32502
	[Token(Token = "0x40072A1")]
	[FieldOffset(Offset = "0x18")]
	private EffectID LaunchPointEffectID;

	// Token: 0x04007EF7 RID: 32503
	[Token(Token = "0x40072A2")]
	[FieldOffset(Offset = "0x1C")]
	private EffectID MainEffectID;

	// Token: 0x04007EF8 RID: 32504
	[Token(Token = "0x40072A3")]
	[FieldOffset(Offset = "0x20")]
	private EffectID HitEffectID;

	// Token: 0x04007EF9 RID: 32505
	[Token(Token = "0x40072A4")]
	[FieldOffset(Offset = "0x24")]
	private float LaserWidth;

	// Token: 0x04007EFA RID: 32506
	[Token(Token = "0x40072A5")]
	[FieldOffset(Offset = "0x28")]
	private float MaxLength;

	// Token: 0x04007EFB RID: 32507
	[Token(Token = "0x40072A6")]
	[FieldOffset(Offset = "0x2C")]
	private float LaserSpeed;

	// Token: 0x04007EFC RID: 32508
	[Token(Token = "0x40072A7")]
	[FieldOffset(Offset = "0x30")]
	private float CurrentLength;

	// Token: 0x04007EFD RID: 32509
	[Token(Token = "0x40072A8")]
	[FieldOffset(Offset = "0x34")]
	private float EffectTime;

	// Token: 0x04007EFE RID: 32510
	[Token(Token = "0x40072A9")]
	[FieldOffset(Offset = "0x38")]
	private bool IsActiveHitEffect;

	// Token: 0x04007EFF RID: 32511
	[Token(Token = "0x40072AA")]
	[FieldOffset(Offset = "0x40")]
	private CapsuleCollider CapsuleCollider;

	// Token: 0x04007F00 RID: 32512
	[Token(Token = "0x40072AB")]
	[FieldOffset(Offset = "0x48")]
	private Transform LaunchPointEffectTransform;

	// Token: 0x04007F01 RID: 32513
	[Token(Token = "0x40072AC")]
	[FieldOffset(Offset = "0x50")]
	private Transform MainEffectTransform;

	// Token: 0x04007F02 RID: 32514
	[Token(Token = "0x40072AD")]
	[FieldOffset(Offset = "0x58")]
	private Transform HitEffectTransform;

	// Token: 0x04007F03 RID: 32515
	[Token(Token = "0x40072AE")]
	[FieldOffset(Offset = "0x60")]
	private ParticleSystem LaunchPointEffect;

	// Token: 0x04007F04 RID: 32516
	[Token(Token = "0x40072AF")]
	[FieldOffset(Offset = "0x68")]
	private ParticleSystem MainEffect;

	// Token: 0x04007F05 RID: 32517
	[Token(Token = "0x40072B0")]
	[FieldOffset(Offset = "0x70")]
	private ParticleSystem HitEffect;

	// Token: 0x04007F06 RID: 32518
	[Token(Token = "0x40072B1")]
	[FieldOffset(Offset = "0x78")]
	private bool IsLaserEnd;

	// Token: 0x04007F07 RID: 32519
	[Token(Token = "0x40072B2")]
	[FieldOffset(Offset = "0x79")]
	private bool IsForcePenetration;

	// Token: 0x04007F08 RID: 32520
	[Token(Token = "0x40072B3")]
	[FieldOffset(Offset = "0x80")]
	private RaycastHit[] RaycastHits;

	// Token: 0x04007F09 RID: 32521
	[Token(Token = "0x40072B4")]
	[FieldOffset(Offset = "0x88")]
	private List<int> SelfColliderIDCheckList;
}
