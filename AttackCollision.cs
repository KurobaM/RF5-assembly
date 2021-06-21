using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001EB RID: 491
[Token(Token = "0x2000189")]
public class AttackCollision : MonoBehaviour
{
	// Token: 0x170001CC RID: 460
	// (get) Token: 0x060009ED RID: 2541 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060009EE RID: 2542 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001AF")]
	public List<CharacterBase> HitList
	{
		[Token(Token = "0x600089E")]
		[Address(RVA = "0x2444CD0", Offset = "0x2444DD1", VA = "0x2444CD0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AF60", Offset = "0x19B061")]
		get
		{
			return null;
		}
		[Token(Token = "0x600089F")]
		[Address(RVA = "0x2444CE0", Offset = "0x2444DE1", VA = "0x2444CE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AF70", Offset = "0x19B071")]
		set
		{
		}
	}

	// Token: 0x060009EF RID: 2543 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008A0")]
	[Address(RVA = "0x2444CF0", Offset = "0x2444DF1", VA = "0x2444CF0")]
	private void Start()
	{
	}

	// Token: 0x060009F0 RID: 2544 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008A1")]
	[Address(RVA = "0x2444D80", Offset = "0x2444E81", VA = "0x2444D80")]
	public void Setup(HumanController human, float power, AttackType attackType, float knockbackPower, int blowPower, EffectID effectName, string hitStopName, ItemData itemData)
	{
	}

	// Token: 0x060009F1 RID: 2545 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008A2")]
	[Address(RVA = "0x2445000", Offset = "0x2445101", VA = "0x2445000")]
	protected void OnHit(HitResult result)
	{
	}

	// Token: 0x060009F2 RID: 2546 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008A3")]
	[Address(RVA = "0x2445020", Offset = "0x2445121", VA = "0x2445020")]
	protected void OnHit(Collider collider, Vector3 point, Vector3 normal)
	{
	}

	// Token: 0x060009F3 RID: 2547 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008A4")]
	[Address(RVA = "0x2445780", Offset = "0x2445881", VA = "0x2445780")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x060009F4 RID: 2548 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008A5")]
	[Address(RVA = "0x24458D0", Offset = "0x24459D1", VA = "0x24458D0")]
	public AttackCollision()
	{
	}

	// Token: 0x04000652 RID: 1618
	[Token(Token = "0x40004FB")]
	[FieldOffset(Offset = "0x18")]
	private HumanController m_Human;

	// Token: 0x04000653 RID: 1619
	[Token(Token = "0x40004FC")]
	[FieldOffset(Offset = "0x20")]
	private float m_MotionPower;

	// Token: 0x04000654 RID: 1620
	[Token(Token = "0x40004FD")]
	[FieldOffset(Offset = "0x24")]
	private float m_KnockbackPower;

	// Token: 0x04000655 RID: 1621
	[Token(Token = "0x40004FE")]
	[FieldOffset(Offset = "0x28")]
	private int m_BlowPower;

	// Token: 0x04000656 RID: 1622
	[Token(Token = "0x40004FF")]
	[FieldOffset(Offset = "0x2C")]
	private EffectID m_HitEffectName;

	// Token: 0x04000657 RID: 1623
	[Token(Token = "0x4000500")]
	[FieldOffset(Offset = "0x30")]
	private ItemData m_ItemData;

	// Token: 0x04000658 RID: 1624
	[Token(Token = "0x4000501")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15CFE0", Offset = "0x15D0E1")]
	private List<CharacterBase> <HitList>k__BackingField;
}
