using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001F0 RID: 496
[Token(Token = "0x200018E")]
public class BitBase : MonoBehaviour
{
	// Token: 0x170001D1 RID: 465
	// (get) Token: 0x06000A16 RID: 2582 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000A17 RID: 2583 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001B4")]
	public Character Owner
	{
		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x2452180", Offset = "0x2452281", VA = "0x2452180")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B000", Offset = "0x19B101")]
		get
		{
			return null;
		}
		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x2452190", Offset = "0x2452291", VA = "0x2452190")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B010", Offset = "0x19B111")]
		protected set
		{
		}
	}

	// Token: 0x170001D2 RID: 466
	// (get) Token: 0x06000A18 RID: 2584 RVA: 0x00005178 File Offset: 0x00003378
	// (set) Token: 0x06000A19 RID: 2585 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001B5")]
	public int Level
	{
		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x24521A0", Offset = "0x24522A1", VA = "0x24521A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B020", Offset = "0x19B121")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x24521B0", Offset = "0x24522B1", VA = "0x24521B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B030", Offset = "0x19B131")]
		private set
		{
		}
	}

	// Token: 0x170001D3 RID: 467
	// (get) Token: 0x06000A1A RID: 2586 RVA: 0x00005190 File Offset: 0x00003390
	[Token(Token = "0x170001B6")]
	public Alliance Alliance
	{
		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x24521C0", Offset = "0x24522C1", VA = "0x24521C0")]
		get
		{
			return Alliance.None;
		}
	}

	// Token: 0x170001D4 RID: 468
	// (get) Token: 0x06000A1B RID: 2587 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001B7")]
	public Collider Target
	{
		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x2452260", Offset = "0x2452361", VA = "0x2452260")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001D5 RID: 469
	// (get) Token: 0x06000A1C RID: 2588 RVA: 0x000051A8 File Offset: 0x000033A8
	// (set) Token: 0x06000A1D RID: 2589 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001B8")]
	public bool IsActive
	{
		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x2452270", Offset = "0x2452371", VA = "0x2452270")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x2452280", Offset = "0x2452381", VA = "0x2452280")]
		protected set
		{
		}
	}

	// Token: 0x170001D6 RID: 470
	// (get) Token: 0x06000A1E RID: 2590 RVA: 0x000051C0 File Offset: 0x000033C0
	[Token(Token = "0x170001B9")]
	public bool IsCooling
	{
		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x2452290", Offset = "0x2452391", VA = "0x2452290")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000A1F RID: 2591 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008D0")]
	[Address(RVA = "0x24522A0", Offset = "0x24523A1", VA = "0x24522A0")]
	protected void Awake()
	{
	}

	// Token: 0x06000A20 RID: 2592 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008D1")]
	[Address(RVA = "0x24522B0", Offset = "0x24523B1", VA = "0x24522B0")]
	private void OnEnable()
	{
	}

	// Token: 0x06000A21 RID: 2593 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008D2")]
	[Address(RVA = "0x2452370", Offset = "0x2452471", VA = "0x2452370")]
	public void Setup(Character owner, Vector3 offset, BitParam bitParam, int level, float initCoolTime = 0f)
	{
	}

	// Token: 0x06000A22 RID: 2594 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008D3")]
	[Address(RVA = "0x24525E0", Offset = "0x24526E1", VA = "0x24525E0")]
	public void SetState(BitState bitState)
	{
	}

	// Token: 0x06000A23 RID: 2595 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008D4")]
	[Address(RVA = "0x24525F0", Offset = "0x24526F1", VA = "0x24525F0")]
	public void SetMode(BitMode bitMode)
	{
	}

	// Token: 0x06000A24 RID: 2596 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008D5")]
	[Address(RVA = "0x2452600", Offset = "0x2452701", VA = "0x2452600")]
	public void OnUpdate()
	{
	}

	// Token: 0x06000A25 RID: 2597 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008D6")]
	[Address(RVA = "0x2452840", Offset = "0x2452941", VA = "0x2452840")]
	public void OnFixedUpdate()
	{
	}

	// Token: 0x06000A26 RID: 2598 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008D7")]
	[Address(RVA = "0x2452940", Offset = "0x2452A41", VA = "0x2452940")]
	private void UpdateIdleState()
	{
	}

	// Token: 0x06000A27 RID: 2599 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008D8")]
	[Address(RVA = "0x2452B00", Offset = "0x2452C01", VA = "0x2452B00")]
	private void UpdateTrackingMode()
	{
	}

	// Token: 0x06000A28 RID: 2600 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008D9")]
	[Address(RVA = "0x2452EE0", Offset = "0x2452FE1", VA = "0x2452EE0")]
	private void UpdateHomingMode()
	{
	}

	// Token: 0x06000A29 RID: 2601 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008DA")]
	[Address(RVA = "0x2453930", Offset = "0x2453A31", VA = "0x2453930")]
	private void TryShot()
	{
	}

	// Token: 0x06000A2A RID: 2602 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008DB")]
	[Address(RVA = "0x2452960", Offset = "0x2452A61", VA = "0x2452960")]
	private void UpdateShotState()
	{
	}

	// Token: 0x06000A2B RID: 2603 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008DC")]
	[Address(RVA = "0x2452680", Offset = "0x2452781", VA = "0x2452680")]
	public void OnDead()
	{
	}

	// Token: 0x06000A2C RID: 2604 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008DD")]
	[Address(RVA = "0x24540B0", Offset = "0x24541B1", VA = "0x24540B0")]
	public void Destroy()
	{
	}

	// Token: 0x06000A2D RID: 2605 RVA: 0x000051D8 File Offset: 0x000033D8
	[Token(Token = "0x60008DE")]
	[Address(RVA = "0x2453520", Offset = "0x2453621", VA = "0x2453520")]
	private bool DoSearch()
	{
		return default(bool);
	}

	// Token: 0x06000A2E RID: 2606 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008DF")]
	[Address(RVA = "0x2453A50", Offset = "0x2453B51", VA = "0x2453A50")]
	public void DoShot()
	{
	}

	// Token: 0x06000A2F RID: 2607 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008E0")]
	[Address(RVA = "0x2454150", Offset = "0x2454251", VA = "0x2454150")]
	public void TryDestroy()
	{
	}

	// Token: 0x06000A30 RID: 2608 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008E1")]
	[Address(RVA = "0x2454180", Offset = "0x2454281", VA = "0x2454180")]
	public BitBase()
	{
	}

	// Token: 0x06000A31 RID: 2609 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008E2")]
	[Address(RVA = "0x2454210", Offset = "0x2454311", VA = "0x2454210")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B040", Offset = "0x19B141")]
	private void <DoShot>b__45_0(BulletBase bullet, BulletDataTable table)
	{
	}

	// Token: 0x0400065F RID: 1631
	[Token(Token = "0x4000508")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x15D050", Offset = "0x15D151")]
	[SerializeField]
	protected Animator m_Animator;

	// Token: 0x04000660 RID: 1632
	[Token(Token = "0x4000509")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected BitMotor m_Motor;

	// Token: 0x04000661 RID: 1633
	[Token(Token = "0x400050A")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	protected BitBody m_Body;

	// Token: 0x04000662 RID: 1634
	[Token(Token = "0x400050B")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	protected EffectID m_StartEffectID;

	// Token: 0x04000663 RID: 1635
	[Token(Token = "0x400050C")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	protected EffectID m_DeadEffectID;

	// Token: 0x04000664 RID: 1636
	[Token(Token = "0x400050D")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	protected BitParam m_BitParam;

	// Token: 0x04000665 RID: 1637
	[Token(Token = "0x400050E")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	protected AnimationCurve m_SpeedRateCurve;

	// Token: 0x04000666 RID: 1638
	[Token(Token = "0x400050F")]
	[FieldOffset(Offset = "0x48")]
	private Vector3 m_offset;

	// Token: 0x04000667 RID: 1639
	[Token(Token = "0x4000510")]
	[FieldOffset(Offset = "0x58")]
	private Collider m_target;

	// Token: 0x04000668 RID: 1640
	[Token(Token = "0x4000511")]
	[FieldOffset(Offset = "0x60")]
	private float m_elapsed;

	// Token: 0x04000669 RID: 1641
	[Token(Token = "0x4000512")]
	[FieldOffset(Offset = "0x64")]
	private float m_cooltime;

	// Token: 0x0400066A RID: 1642
	[Token(Token = "0x4000513")]
	[FieldOffset(Offset = "0x68")]
	private BitState m_bitState;

	// Token: 0x0400066B RID: 1643
	[Token(Token = "0x4000514")]
	[FieldOffset(Offset = "0x6C")]
	private BitMode m_bitMode;

	// Token: 0x0400066C RID: 1644
	[Token(Token = "0x4000515")]
	[FieldOffset(Offset = "0x70")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D100", Offset = "0x15D201")]
	private Character <Owner>k__BackingField;

	// Token: 0x0400066D RID: 1645
	[Token(Token = "0x4000516")]
	[FieldOffset(Offset = "0x78")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D110", Offset = "0x15D211")]
	private int <Level>k__BackingField;
}
