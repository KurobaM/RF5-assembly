using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B2B RID: 2859
[Token(Token = "0x2000776")]
public struct DamageResult
{
	// Token: 0x060049D9 RID: 18905 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003DCB")]
	[Address(RVA = "0x2DD9E0", Offset = "0x2DDAE1", VA = "0x2DD9E0")]
	public DamageResult(CharacterBase characterBase)
	{
	}

	// Token: 0x060049DA RID: 18906 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003DCC")]
	[Address(RVA = "0x2DDA30", Offset = "0x2DDB31", VA = "0x2DDA30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x0400A9D5 RID: 43477
	[Token(Token = "0x4008001")]
	[FieldOffset(Offset = "0x0")]
	public CharacterBase CharacterBase;

	// Token: 0x0400A9D6 RID: 43478
	[Token(Token = "0x4008002")]
	[FieldOffset(Offset = "0x8")]
	public int TotalDamage;

	// Token: 0x0400A9D7 RID: 43479
	[Token(Token = "0x4008003")]
	[FieldOffset(Offset = "0xC")]
	public bool IsCritical;

	// Token: 0x0400A9D8 RID: 43480
	[Token(Token = "0x4008004")]
	[FieldOffset(Offset = "0x10")]
	public float KnockbackPower;

	// Token: 0x0400A9D9 RID: 43481
	[Token(Token = "0x4008005")]
	[FieldOffset(Offset = "0x14")]
	public float CauserKnockbackPower;

	// Token: 0x0400A9DA RID: 43482
	[Token(Token = "0x4008006")]
	[FieldOffset(Offset = "0x18")]
	public float KnockbackTime;

	// Token: 0x0400A9DB RID: 43483
	[Token(Token = "0x4008007")]
	[FieldOffset(Offset = "0x1C")]
	public Vector3 Direction;

	// Token: 0x0400A9DC RID: 43484
	[Token(Token = "0x4008008")]
	[FieldOffset(Offset = "0x28")]
	public float BlowPowerRate;

	// Token: 0x0400A9DD RID: 43485
	[Token(Token = "0x4008009")]
	[FieldOffset(Offset = "0x2C")]
	public bool IsFly;

	// Token: 0x0400A9DE RID: 43486
	[Token(Token = "0x400800A")]
	[FieldOffset(Offset = "0x2D")]
	public bool IsBlow;

	// Token: 0x0400A9DF RID: 43487
	[Token(Token = "0x400800B")]
	[FieldOffset(Offset = "0x2E")]
	public bool IsDead;

	// Token: 0x0400A9E0 RID: 43488
	[Token(Token = "0x400800C")]
	[FieldOffset(Offset = "0x2F")]
	public bool IsWeakAttribute;

	// Token: 0x0400A9E1 RID: 43489
	[Token(Token = "0x400800D")]
	[FieldOffset(Offset = "0x30")]
	public bool IsResistAttribute;

	// Token: 0x0400A9E2 RID: 43490
	[Token(Token = "0x400800E")]
	[FieldOffset(Offset = "0x31")]
	public bool OnPoison;

	// Token: 0x0400A9E3 RID: 43491
	[Token(Token = "0x400800F")]
	[FieldOffset(Offset = "0x32")]
	public bool OnSeal;

	// Token: 0x0400A9E4 RID: 43492
	[Token(Token = "0x4008010")]
	[FieldOffset(Offset = "0x33")]
	public bool OnParalysis;

	// Token: 0x0400A9E5 RID: 43493
	[Token(Token = "0x4008011")]
	[FieldOffset(Offset = "0x34")]
	public bool OnSleep;

	// Token: 0x0400A9E6 RID: 43494
	[Token(Token = "0x4008012")]
	[FieldOffset(Offset = "0x35")]
	public bool OnTire;

	// Token: 0x0400A9E7 RID: 43495
	[Token(Token = "0x4008013")]
	[FieldOffset(Offset = "0x36")]
	public bool OnSick;

	// Token: 0x0400A9E8 RID: 43496
	[Token(Token = "0x4008014")]
	[FieldOffset(Offset = "0x37")]
	public bool OnDeath;

	// Token: 0x0400A9E9 RID: 43497
	[Token(Token = "0x4008015")]
	[FieldOffset(Offset = "0x38")]
	public bool OnStun;
}
