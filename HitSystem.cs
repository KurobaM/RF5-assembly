using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000609 RID: 1545
[Token(Token = "0x2000459")]
public class HitSystem : MonoBehaviour
{
	// Token: 0x17000625 RID: 1573
	// (get) Token: 0x06002635 RID: 9781 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002636 RID: 9782 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170004E3")]
	private HashSet<CharacterBase>[] HitChecks
	{
		[Token(Token = "0x600203D")]
		[Address(RVA = "0x24F7070", Offset = "0x24F7171", VA = "0x24F7070")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1A20", Offset = "0x1A1B21")]
		get
		{
			return null;
		}
		[Token(Token = "0x600203E")]
		[Address(RVA = "0x24F7080", Offset = "0x24F7181", VA = "0x24F7080")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1A30", Offset = "0x1A1B31")]
		set
		{
		}
	}

	// Token: 0x17000626 RID: 1574
	// (get) Token: 0x06002637 RID: 9783 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004E4")]
	public string AnimationName
	{
		[Token(Token = "0x600203F")]
		[Address(RVA = "0x24F7090", Offset = "0x24F7191", VA = "0x24F7090")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000627 RID: 1575
	// (get) Token: 0x06002638 RID: 9784 RVA: 0x0000F168 File Offset: 0x0000D368
	// (set) Token: 0x06002639 RID: 9785 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170004E5")]
	public bool IsActive
	{
		[Token(Token = "0x6002040")]
		[Address(RVA = "0x24F70A0", Offset = "0x24F71A1", VA = "0x24F70A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1A40", Offset = "0x1A1B41")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002041")]
		[Address(RVA = "0x24F70B0", Offset = "0x24F71B1", VA = "0x24F70B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1A50", Offset = "0x1A1B51")]
		private set
		{
		}
	}

	// Token: 0x17000628 RID: 1576
	// (get) Token: 0x0600263A RID: 9786 RVA: 0x0000F180 File Offset: 0x0000D380
	// (set) Token: 0x0600263B RID: 9787 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170004E6")]
	public float CountTime
	{
		[Token(Token = "0x6002042")]
		[Address(RVA = "0x24F70C0", Offset = "0x24F71C1", VA = "0x24F70C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1A60", Offset = "0x1A1B61")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6002043")]
		[Address(RVA = "0x24F70D0", Offset = "0x24F71D1", VA = "0x24F70D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1A70", Offset = "0x1A1B71")]
		private set
		{
		}
	}

	// Token: 0x17000629 RID: 1577
	// (get) Token: 0x0600263C RID: 9788 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004E7")]
	public HitUnit[] HitUnits
	{
		[Token(Token = "0x6002044")]
		[Address(RVA = "0x24F70E0", Offset = "0x24F71E1", VA = "0x24F70E0")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700062A RID: 1578
	// (get) Token: 0x0600263D RID: 9789 RVA: 0x0000F198 File Offset: 0x0000D398
	// (set) Token: 0x0600263E RID: 9790 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170004E8")]
	public int Index
	{
		[Token(Token = "0x6002045")]
		[Address(RVA = "0x24F70F0", Offset = "0x24F71F1", VA = "0x24F70F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1A80", Offset = "0x1A1B81")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6002046")]
		[Address(RVA = "0x24F7100", Offset = "0x24F7201", VA = "0x24F7100")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1A90", Offset = "0x1A1B91")]
		set
		{
		}
	}

	// Token: 0x1700062B RID: 1579
	// (get) Token: 0x0600263F RID: 9791 RVA: 0x0000F1B0 File Offset: 0x0000D3B0
	[Token(Token = "0x170004E9")]
	public float Speed
	{
		[Token(Token = "0x6002047")]
		[Address(RVA = "0x24F7110", Offset = "0x24F7211", VA = "0x24F7110")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06002640 RID: 9792 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002048")]
	[Address(RVA = "0x24F57F0", Offset = "0x24F58F1", VA = "0x24F57F0")]
	public void HitStart()
	{
	}

	// Token: 0x06002641 RID: 9793 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002049")]
	[Address(RVA = "0x24F5960", Offset = "0x24F5A61", VA = "0x24F5960")]
	public void HitEnd()
	{
	}

	// Token: 0x06002642 RID: 9794 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600204A")]
	[Address(RVA = "0x24F5270", Offset = "0x24F5371", VA = "0x24F5270")]
	public void HitUpdate(float deltaTime)
	{
	}

	// Token: 0x06002643 RID: 9795 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600204B")]
	[Address(RVA = "0x24F5480", Offset = "0x24F5581", VA = "0x24F5480")]
	public void HitTimeSync(float time)
	{
	}

	// Token: 0x06002644 RID: 9796 RVA: 0x0000F1C8 File Offset: 0x0000D3C8
	[Token(Token = "0x600204C")]
	[Address(RVA = "0x24F7AE0", Offset = "0x24F7BE1", VA = "0x24F7AE0")]
	private static bool UpdateEnd(HitUnit unit, float time)
	{
		return default(bool);
	}

	// Token: 0x06002645 RID: 9797 RVA: 0x0000F1E0 File Offset: 0x0000D3E0
	[Token(Token = "0x600204D")]
	[Address(RVA = "0x24F7AF0", Offset = "0x24F7BF1", VA = "0x24F7AF0")]
	private static bool UpdateIdle(HitUnit unit, float time)
	{
		return default(bool);
	}

	// Token: 0x06002646 RID: 9798 RVA: 0x0000F1F8 File Offset: 0x0000D3F8
	[Token(Token = "0x600204E")]
	[Address(RVA = "0x24F7C10", Offset = "0x24F7D11", VA = "0x24F7C10")]
	private static bool UpdateHit(HitUnit unit, float time)
	{
		return default(bool);
	}

	// Token: 0x06002647 RID: 9799 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600204F")]
	[Address(RVA = "0x24F7D30", Offset = "0x24F7E31", VA = "0x24F7D30")]
	public void OnHitTriggerEnter(HitUnit unit, Collider collider)
	{
	}

	// Token: 0x06002648 RID: 9800 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002050")]
	[Address(RVA = "0x24F7F00", Offset = "0x24F8001", VA = "0x24F7F00")]
	private void OnTriggerEnterEffect(HitUnit unit, Collider collider)
	{
	}

	// Token: 0x06002649 RID: 9801 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002051")]
	[Address(RVA = "0x24F71E0", Offset = "0x24F72E1", VA = "0x24F71E0")]
	private void AttackEffectStart()
	{
	}

	// Token: 0x0600264A RID: 9802 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002052")]
	[Address(RVA = "0x24F7250", Offset = "0x24F7351", VA = "0x24F7250")]
	private void AttackEffectEnd()
	{
	}

	// Token: 0x0600264B RID: 9803 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002053")]
	[Address(RVA = "0x24F7720", Offset = "0x24F7821", VA = "0x24F7720")]
	private void AttackEffectUpdate(float time)
	{
	}

	// Token: 0x0600264C RID: 9804 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002054")]
	[Address(RVA = "0x24F8380", Offset = "0x24F8481", VA = "0x24F8380")]
	private void Awake()
	{
	}

	// Token: 0x0600264D RID: 9805 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002055")]
	[Address(RVA = "0x24F8480", Offset = "0x24F8581", VA = "0x24F8480")]
	public HitSystem()
	{
	}

	// Token: 0x04006D6C RID: 28012
	[Token(Token = "0x4006671")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string animationName;

	// Token: 0x04006D6D RID: 28013
	[Token(Token = "0x4006672")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private HitUnit[] HitUnitList;

	// Token: 0x04006D6E RID: 28014
	[Token(Token = "0x4006673")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public HitEffectUnit[] AttackEffects;

	// Token: 0x04006D6F RID: 28015
	[Token(Token = "0x4006674")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public HitMaster HitMaster;

	// Token: 0x04006D70 RID: 28016
	[Token(Token = "0x4006675")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1681F0", Offset = "0x1682F1")]
	private HashSet<CharacterBase>[] <HitChecks>k__BackingField;

	// Token: 0x04006D71 RID: 28017
	[Token(Token = "0x4006676")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x168200", Offset = "0x168301")]
	private bool <IsActive>k__BackingField;

	// Token: 0x04006D72 RID: 28018
	[Token(Token = "0x4006677")]
	[FieldOffset(Offset = "0x44")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x168210", Offset = "0x168311")]
	private float <CountTime>k__BackingField;

	// Token: 0x04006D73 RID: 28019
	[Token(Token = "0x4006678")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x168220", Offset = "0x168321")]
	private int <Index>k__BackingField;

	// Token: 0x04006D74 RID: 28020
	[Token(Token = "0x4006679")]
	[FieldOffset(Offset = "0x0")]
	private static HitSystem.UpdateVJ[] updateVJ;

	// Token: 0x0200060A RID: 1546
	// (Invoke) Token: 0x06002650 RID: 9808
	[Token(Token = "0x2001139")]
	private delegate bool UpdateVJ(HitUnit unit, float time);
}
