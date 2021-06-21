using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B2A RID: 2858
[Token(Token = "0x2000775")]
public struct DamageInfo
{
	// Token: 0x060049D8 RID: 18904 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003DCA")]
	[Address(RVA = "0x2DD980", Offset = "0x2DDA81", VA = "0x2DD980", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x0400A9AF RID: 43439
	[Token(Token = "0x4007FDB")]
	[FieldOffset(Offset = "0x0")]
	public float Damage;

	// Token: 0x0400A9B0 RID: 43440
	[Token(Token = "0x4007FDC")]
	[FieldOffset(Offset = "0x4")]
	public float AttackCritical;

	// Token: 0x0400A9B1 RID: 43441
	[Token(Token = "0x4007FDD")]
	[FieldOffset(Offset = "0x8")]
	public float AttackKnockbackPower;

	// Token: 0x0400A9B2 RID: 43442
	[Token(Token = "0x4007FDE")]
	[FieldOffset(Offset = "0xC")]
	public float AttackKnockbackTime;

	// Token: 0x0400A9B3 RID: 43443
	[Token(Token = "0x4007FDF")]
	[FieldOffset(Offset = "0x10")]
	public int AttackBlowPower;

	// Token: 0x0400A9B4 RID: 43444
	[Token(Token = "0x4007FE0")]
	[FieldOffset(Offset = "0x14")]
	public float BlowPowerRate;

	// Token: 0x0400A9B5 RID: 43445
	[Token(Token = "0x4007FE1")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 Direction;

	// Token: 0x0400A9B6 RID: 43446
	[Token(Token = "0x4007FE2")]
	[FieldOffset(Offset = "0x24")]
	public AttackType AttackType;

	// Token: 0x0400A9B7 RID: 43447
	[Token(Token = "0x4007FE3")]
	[FieldOffset(Offset = "0x28")]
	public Character Causer;

	// Token: 0x0400A9B8 RID: 43448
	[Token(Token = "0x4007FE4")]
	[FieldOffset(Offset = "0x30")]
	public Alliance Alliance;

	// Token: 0x0400A9B9 RID: 43449
	[Token(Token = "0x4007FE5")]
	[FieldOffset(Offset = "0x34")]
	public AttackAttribute AttackAttribute;

	// Token: 0x0400A9BA RID: 43450
	[Token(Token = "0x4007FE6")]
	[FieldOffset(Offset = "0x38")]
	public float AttackPoison;

	// Token: 0x0400A9BB RID: 43451
	[Token(Token = "0x4007FE7")]
	[FieldOffset(Offset = "0x3C")]
	public float AttackParalysis;

	// Token: 0x0400A9BC RID: 43452
	[Token(Token = "0x4007FE8")]
	[FieldOffset(Offset = "0x40")]
	public float AttackSleep;

	// Token: 0x0400A9BD RID: 43453
	[Token(Token = "0x4007FE9")]
	[FieldOffset(Offset = "0x44")]
	public float AttackTire;

	// Token: 0x0400A9BE RID: 43454
	[Token(Token = "0x4007FEA")]
	[FieldOffset(Offset = "0x48")]
	public float AttackSick;

	// Token: 0x0400A9BF RID: 43455
	[Token(Token = "0x4007FEB")]
	[FieldOffset(Offset = "0x4C")]
	public float AttackDeath;

	// Token: 0x0400A9C0 RID: 43456
	[Token(Token = "0x4007FEC")]
	[FieldOffset(Offset = "0x50")]
	public float AttackHpDrain;

	// Token: 0x0400A9C1 RID: 43457
	[Token(Token = "0x4007FED")]
	[FieldOffset(Offset = "0x54")]
	public float AttackSeal;

	// Token: 0x0400A9C2 RID: 43458
	[Token(Token = "0x4007FEE")]
	[FieldOffset(Offset = "0x58")]
	public float AttackStun;

	// Token: 0x0400A9C3 RID: 43459
	[Token(Token = "0x4007FEF")]
	[FieldOffset(Offset = "0x5C")]
	public bool HealPoison;

	// Token: 0x0400A9C4 RID: 43460
	[Token(Token = "0x4007FF0")]
	[FieldOffset(Offset = "0x5D")]
	public bool HealParalysis;

	// Token: 0x0400A9C5 RID: 43461
	[Token(Token = "0x4007FF1")]
	[FieldOffset(Offset = "0x5E")]
	public bool HealSleep;

	// Token: 0x0400A9C6 RID: 43462
	[Token(Token = "0x4007FF2")]
	[FieldOffset(Offset = "0x5F")]
	public bool HealTire;

	// Token: 0x0400A9C7 RID: 43463
	[Token(Token = "0x4007FF3")]
	[FieldOffset(Offset = "0x60")]
	public bool HealSick;

	// Token: 0x0400A9C8 RID: 43464
	[Token(Token = "0x4007FF4")]
	[FieldOffset(Offset = "0x61")]
	public bool HealDeath;

	// Token: 0x0400A9C9 RID: 43465
	[Token(Token = "0x4007FF5")]
	[FieldOffset(Offset = "0x62")]
	public bool HealSeal;

	// Token: 0x0400A9CA RID: 43466
	[Token(Token = "0x4007FF6")]
	[FieldOffset(Offset = "0x63")]
	public bool HealStun;

	// Token: 0x0400A9CB RID: 43467
	[Token(Token = "0x4007FF7")]
	[FieldOffset(Offset = "0x64")]
	public bool IsPercentDamage;

	// Token: 0x0400A9CC RID: 43468
	[Token(Token = "0x4007FF8")]
	[FieldOffset(Offset = "0x65")]
	public bool IsTrueDamage;

	// Token: 0x0400A9CD RID: 43469
	[Token(Token = "0x4007FF9")]
	[FieldOffset(Offset = "0x68")]
	public Vector3 HitPosition;

	// Token: 0x0400A9CE RID: 43470
	[Token(Token = "0x4007FFA")]
	[FieldOffset(Offset = "0x74")]
	public int HitParts;

	// Token: 0x0400A9CF RID: 43471
	[Token(Token = "0x4007FFB")]
	[FieldOffset(Offset = "0x78")]
	public bool IsHideDamageText;

	// Token: 0x0400A9D0 RID: 43472
	[Token(Token = "0x4007FFC")]
	[FieldOffset(Offset = "0x79")]
	public bool IsHideDamageEffect;

	// Token: 0x0400A9D1 RID: 43473
	[Token(Token = "0x4007FFD")]
	[FieldOffset(Offset = "0x7A")]
	public bool IsNotJustAvoid;

	// Token: 0x0400A9D2 RID: 43474
	[Token(Token = "0x4007FFE")]
	[FieldOffset(Offset = "0x7B")]
	public bool IsNotDeath;

	// Token: 0x0400A9D3 RID: 43475
	[Token(Token = "0x4007FFF")]
	[FieldOffset(Offset = "0x7C")]
	public bool IgnoreGamePause;

	// Token: 0x0400A9D4 RID: 43476
	[Token(Token = "0x4008000")]
	[FieldOffset(Offset = "0x7D")]
	public bool IsNotDamageSkill;
}
