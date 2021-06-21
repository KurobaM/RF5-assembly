using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020006FD RID: 1789
[Token(Token = "0x20004E9")]
public class GateEnemyModelContainer : CharacterModel
{
	// Token: 0x170006B6 RID: 1718
	// (get) Token: 0x06002CC2 RID: 11458 RVA: 0x00010A40 File Offset: 0x0000EC40
	[Token(Token = "0x17000558")]
	public EffectID DisapperEffectID
	{
		[Token(Token = "0x60025BC")]
		[Address(RVA = "0x1FA3B60", Offset = "0x1FA3C61", VA = "0x1FA3B60")]
		get
		{
			return EffectID.EFFECT_EMPTY;
		}
	}

	// Token: 0x170006B7 RID: 1719
	// (get) Token: 0x06002CC3 RID: 11459 RVA: 0x00010A58 File Offset: 0x0000EC58
	[Token(Token = "0x17000559")]
	public EffectID SummonEffectID
	{
		[Token(Token = "0x60025BD")]
		[Address(RVA = "0x1FA3480", Offset = "0x1FA3581", VA = "0x1FA3480")]
		get
		{
			return EffectID.EFFECT_EMPTY;
		}
	}

	// Token: 0x170006B8 RID: 1720
	// (get) Token: 0x06002CC4 RID: 11460 RVA: 0x00010A70 File Offset: 0x0000EC70
	[Token(Token = "0x1700055A")]
	public EffectID DamageEffectID
	{
		[Token(Token = "0x60025BE")]
		[Address(RVA = "0x1FA3710", Offset = "0x1FA3811", VA = "0x1FA3710")]
		get
		{
			return EffectID.EFFECT_EMPTY;
		}
	}

	// Token: 0x06002CC5 RID: 11461 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025BF")]
	[Address(RVA = "0x1FA3280", Offset = "0x1FA3381", VA = "0x1FA3280")]
	public void Setup(Vector3 offset)
	{
	}

	// Token: 0x06002CC6 RID: 11462 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025C0")]
	[Address(RVA = "0x1FA3D20", Offset = "0x1FA3E21", VA = "0x1FA3D20")]
	public GateEnemyModelContainer()
	{
	}

	// Token: 0x0400739C RID: 29596
	[Token(Token = "0x4006AB5")]
	[FieldOffset(Offset = "0x68")]
	private Dictionary<GateEnemyModelContainer.GateType, EffectID> DisapperEffectDic;

	// Token: 0x0400739D RID: 29597
	[Token(Token = "0x4006AB6")]
	[FieldOffset(Offset = "0x70")]
	public ParticleSystem DefaultEffect;

	// Token: 0x0400739E RID: 29598
	[Token(Token = "0x4006AB7")]
	[FieldOffset(Offset = "0x78")]
	public GateEnemyModelContainer.GateType SelectGateType;

	// Token: 0x020006FE RID: 1790
	[Token(Token = "0x200119B")]
	public enum GateType
	{
		// Token: 0x040073A0 RID: 29600
		[Token(Token = "0x4019551")]
		Normal,
		// Token: 0x040073A1 RID: 29601
		[Token(Token = "0x4019552")]
		Fire,
		// Token: 0x040073A2 RID: 29602
		[Token(Token = "0x4019553")]
		Water,
		// Token: 0x040073A3 RID: 29603
		[Token(Token = "0x4019554")]
		Earth,
		// Token: 0x040073A4 RID: 29604
		[Token(Token = "0x4019555")]
		Wind,
		// Token: 0x040073A5 RID: 29605
		[Token(Token = "0x4019556")]
		Shine,
		// Token: 0x040073A6 RID: 29606
		[Token(Token = "0x4019557")]
		Dark,
		// Token: 0x040073A7 RID: 29607
		[Token(Token = "0x4019558")]
		Love
	}
}
