using System;
using BehaviorDesigner.Runtime;
using Define;
using Field;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020006E7 RID: 1767
[Token(Token = "0x20004E1")]
public class EnemyBehaviorController : MonsterBehaviorController
{
	// Token: 0x170006A6 RID: 1702
	// (get) Token: 0x06002B7C RID: 11132 RVA: 0x000107D0 File Offset: 0x0000E9D0
	// (set) Token: 0x06002B7D RID: 11133 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700054C")]
	public float MaxCautionTime
	{
		[Token(Token = "0x60024A9")]
		[Address(RVA = "0x22B1E40", Offset = "0x22B1F41", VA = "0x22B1E40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2AD0", Offset = "0x1A2BD1")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60024AA")]
		[Address(RVA = "0x22B1E50", Offset = "0x22B1F51", VA = "0x22B1E50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2AE0", Offset = "0x1A2BE1")]
		private set
		{
		}
	}

	// Token: 0x170006A7 RID: 1703
	// (get) Token: 0x06002B7E RID: 11134 RVA: 0x000107E8 File Offset: 0x0000E9E8
	// (set) Token: 0x06002B7F RID: 11135 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700054D")]
	public float MinCautionTime
	{
		[Token(Token = "0x60024AB")]
		[Address(RVA = "0x22B1E60", Offset = "0x22B1F61", VA = "0x22B1E60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2AF0", Offset = "0x1A2BF1")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60024AC")]
		[Address(RVA = "0x22B1E70", Offset = "0x22B1F71", VA = "0x22B1E70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2B00", Offset = "0x1A2C01")]
		private set
		{
		}
	}

	// Token: 0x170006A8 RID: 1704
	// (get) Token: 0x06002B80 RID: 11136 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002B81 RID: 11137 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700054E")]
	public MonsterActionBehaviorController ActionBehaviorController
	{
		[Token(Token = "0x60024AD")]
		[Address(RVA = "0x22B1E80", Offset = "0x22B1F81", VA = "0x22B1E80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2B10", Offset = "0x1A2C11")]
		get
		{
			return null;
		}
		[Token(Token = "0x60024AE")]
		[Address(RVA = "0x22B1E90", Offset = "0x22B1F91", VA = "0x22B1E90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2B20", Offset = "0x1A2C21")]
		protected set
		{
		}
	}

	// Token: 0x06002B82 RID: 11138 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60024AF")]
	[Address(RVA = "0x22B1EA0", Offset = "0x22B1FA1", VA = "0x22B1EA0", Slot = "4")]
	protected override void Start()
	{
	}

	// Token: 0x06002B83 RID: 11139 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60024B0")]
	[Address(RVA = "0x22B1EB0", Offset = "0x22B1FB1", VA = "0x22B1EB0")]
	public void UpdateTerritory()
	{
	}

	// Token: 0x06002B84 RID: 11140 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60024B1")]
	[Address(RVA = "0x22B1F90", Offset = "0x22B2091", VA = "0x22B1F90", Slot = "10")]
	protected override void OnSetup()
	{
	}

	// Token: 0x06002B85 RID: 11141 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60024B2")]
	[Address(RVA = "0x22B2420", Offset = "0x22B2521", VA = "0x22B2420", Slot = "11")]
	protected override void OnRelese()
	{
	}

	// Token: 0x06002B86 RID: 11142 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60024B3")]
	[Address(RVA = "0x22B24F0", Offset = "0x22B25F1", VA = "0x22B24F0")]
	private void OnDisable()
	{
	}

	// Token: 0x06002B87 RID: 11143 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60024B4")]
	[Address(RVA = "0x22B25A0", Offset = "0x22B26A1", VA = "0x22B25A0", Slot = "19")]
	protected override void OnGetVariableBehaviorParameter()
	{
	}

	// Token: 0x06002B88 RID: 11144 RVA: 0x00010800 File Offset: 0x0000EA00
	[Token(Token = "0x60024B5")]
	[Address(RVA = "0x22B26E0", Offset = "0x22B27E1", VA = "0x22B26E0")]
	private bool IgnoreCharacter(Character character)
	{
		return default(bool);
	}

	// Token: 0x06002B89 RID: 11145 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60024B6")]
	[Address(RVA = "0x22B2720", Offset = "0x22B2821", VA = "0x22B2720", Slot = "15")]
	public override void SetupSearchCharacterController()
	{
	}

	// Token: 0x06002B8A RID: 11146 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60024B7")]
	[Address(RVA = "0x22B2900", Offset = "0x22B2A01", VA = "0x22B2900", Slot = "9")]
	protected override void Update()
	{
	}

	// Token: 0x06002B8B RID: 11147 RVA: 0x00010818 File Offset: 0x0000EA18
	[Token(Token = "0x60024B8")]
	[Address(RVA = "0x22B1F70", Offset = "0x22B2071", VA = "0x22B1F70")]
	public bool IsHoldPatrolPoint()
	{
		return default(bool);
	}

	// Token: 0x06002B8C RID: 11148 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60024B9")]
	[Address(RVA = "0x22B2C20", Offset = "0x22B2D21", VA = "0x22B2C20", Slot = "57")]
	public override void TakeDamage(bool isDamage, float blowDist, DamageInfo damageInfo, ref DamageResult damageResult)
	{
	}

	// Token: 0x06002B8D RID: 11149 RVA: 0x00010830 File Offset: 0x0000EA30
	[Token(Token = "0x60024BA")]
	[Address(RVA = "0x22B2E30", Offset = "0x22B2F31", VA = "0x22B2E30")]
	public PatrolBehaviorType GetPatrollBehavior(out float moveSpeedScale, out float moveTime, out int waitCount)
	{
		return PatrolBehaviorType.Wait;
	}

	// Token: 0x06002B8E RID: 11150 RVA: 0x00010848 File Offset: 0x0000EA48
	[Token(Token = "0x60024BB")]
	[Address(RVA = "0x22B3220", Offset = "0x22B3321", VA = "0x22B3220")]
	public Vector3 GetPatrollPosition()
	{
		return default(Vector3);
	}

	// Token: 0x06002B8F RID: 11151 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024BC")]
	[Address(RVA = "0x22B32A0", Offset = "0x22B33A1", VA = "0x22B32A0")]
	public MonsterActionInformation GetNearestDistanceAttackInformation(float distance)
	{
		return null;
	}

	// Token: 0x06002B90 RID: 11152 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60024BD")]
	[Address(RVA = "0x22B2BA0", Offset = "0x22B2CA1", VA = "0x22B2BA0")]
	public void OnEnterGateArea()
	{
	}

	// Token: 0x06002B91 RID: 11153 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60024BE")]
	[Address(RVA = "0x22B2AD0", Offset = "0x22B2BD1", VA = "0x22B2AD0")]
	public void OnExitGateArea()
	{
	}

	// Token: 0x06002B92 RID: 11154 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60024BF")]
	[Address(RVA = "0x22B3440", Offset = "0x22B3541", VA = "0x22B3440", Slot = "63")]
	public override void OnEndActionScript()
	{
	}

	// Token: 0x06002B93 RID: 11155 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60024C0")]
	[Address(RVA = "0x22B3500", Offset = "0x22B3601", VA = "0x22B3500", Slot = "78")]
	public override void OnHearFootSteps()
	{
	}

	// Token: 0x06002B94 RID: 11156 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60024C1")]
	[Address(RVA = "0x22B35F0", Offset = "0x22B36F1", VA = "0x22B35F0", Slot = "81")]
	protected override void OnEndContDeadFade()
	{
	}

	// Token: 0x06002B95 RID: 11157 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60024C2")]
	[Address(RVA = "0x22B37B0", Offset = "0x22B38B1", VA = "0x22B37B0", Slot = "65")]
	public override void OnEndAnimEventDeadState()
	{
	}

	// Token: 0x06002B96 RID: 11158 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60024C3")]
	[Address(RVA = "0x22B37E0", Offset = "0x22B38E1", VA = "0x22B37E0", Slot = "71")]
	public override void OnEndAnimEventWait_2State()
	{
	}

	// Token: 0x06002B97 RID: 11159 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60024C4")]
	[Address(RVA = "0x22B2170", Offset = "0x22B2271", VA = "0x22B2170")]
	private void SetCautionWaitTime()
	{
	}

	// Token: 0x06002B98 RID: 11160 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60024C5")]
	[Address(RVA = "0x22B21F0", Offset = "0x22B22F1", VA = "0x22B21F0")]
	private void SetupActionBehaviorContriller()
	{
	}

	// Token: 0x06002B99 RID: 11161 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60024C6")]
	[Address(RVA = "0x22B3850", Offset = "0x22B3951", VA = "0x22B3850", Slot = "74")]
	public override void SetupMonsterAction()
	{
	}

	// Token: 0x06002B9A RID: 11162 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60024C7")]
	[Address(RVA = "0x22B38A0", Offset = "0x22B39A1", VA = "0x22B38A0", Slot = "75")]
	public override void ExecuteMonsterAction(int index)
	{
	}

	// Token: 0x06002B9B RID: 11163 RVA: 0x00010860 File Offset: 0x0000EA60
	[Token(Token = "0x60024C8")]
	[Address(RVA = "0x22B38C0", Offset = "0x22B39C1", VA = "0x22B38C0")]
	private bool IsFireWoolScene(FieldSceneId sceneId)
	{
		return default(bool);
	}

	// Token: 0x06002B9C RID: 11164 RVA: 0x00010878 File Offset: 0x0000EA78
	[Token(Token = "0x60024C9")]
	[Address(RVA = "0x22B3910", Offset = "0x22B3A11", VA = "0x22B3910")]
	private bool IsFireWoolField(FieldPlaceId fieldPlaceId)
	{
		return default(bool);
	}

	// Token: 0x06002B9D RID: 11165 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60024CA")]
	[Address(RVA = "0x22B2280", Offset = "0x22B2381", VA = "0x22B2280")]
	private void CheckStageWool()
	{
	}

	// Token: 0x06002B9E RID: 11166 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60024CB")]
	[Address(RVA = "0x22B3920", Offset = "0x22B3A21", VA = "0x22B3920", Slot = "21")]
	protected override void OnDrawGizmosSelected()
	{
	}

	// Token: 0x06002B9F RID: 11167 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60024CC")]
	[Address(RVA = "0x22B3930", Offset = "0x22B3A31", VA = "0x22B3930")]
	public EnemyBehaviorController()
	{
	}

	// Token: 0x06002BA0 RID: 11168 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60024CD")]
	[Address(RVA = "0x22B3940", Offset = "0x22B3A41", VA = "0x22B3940")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2B30", Offset = "0x1A2C31")]
	private void <OnEndContDeadFade>b__39_0()
	{
	}

	// Token: 0x040072DD RID: 29405
	[Token(Token = "0x4006A41")]
	[FieldOffset(Offset = "0x118")]
	public Vector3[] PatrolPoints;

	// Token: 0x040072DE RID: 29406
	[Token(Token = "0x4006A42")]
	[FieldOffset(Offset = "0x120")]
	public GateController GateController;

	// Token: 0x040072DF RID: 29407
	[Token(Token = "0x4006A43")]
	[FieldOffset(Offset = "0x128")]
	private int CurrentPatrolIndex;

	// Token: 0x040072E0 RID: 29408
	[Token(Token = "0x4006A44")]
	[FieldOffset(Offset = "0x130")]
	private SharedBool IsInTerritory;

	// Token: 0x040072E1 RID: 29409
	[Token(Token = "0x4006A45")]
	[FieldOffset(Offset = "0x138")]
	private SharedEnemyBehaviorTreeState State;

	// Token: 0x040072E2 RID: 29410
	[Token(Token = "0x4006A46")]
	[FieldOffset(Offset = "0x140")]
	private Vector3 TerritoryCenterPosition;

	// Token: 0x040072E3 RID: 29411
	[Token(Token = "0x4006A47")]
	[FieldOffset(Offset = "0x14C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x169610", Offset = "0x169711")]
	private float <MaxCautionTime>k__BackingField;

	// Token: 0x040072E4 RID: 29412
	[Token(Token = "0x4006A48")]
	[FieldOffset(Offset = "0x150")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x169620", Offset = "0x169721")]
	private float <MinCautionTime>k__BackingField;

	// Token: 0x040072E5 RID: 29413
	[Token(Token = "0x4006A49")]
	[FieldOffset(Offset = "0x154")]
	public Vector3 ExecPoint;

	// Token: 0x040072E6 RID: 29414
	[Token(Token = "0x4006A4A")]
	[FieldOffset(Offset = "0x160")]
	private GameObject SoulEffect;

	// Token: 0x040072E7 RID: 29415
	[Token(Token = "0x4006A4B")]
	[FieldOffset(Offset = "0x168")]
	private SimpleHpBar SimpleHpBar;

	// Token: 0x040072E8 RID: 29416
	[Token(Token = "0x4006A4C")]
	[FieldOffset(Offset = "0x170")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x169630", Offset = "0x169731")]
	private MonsterActionBehaviorController <ActionBehaviorController>k__BackingField;
}
