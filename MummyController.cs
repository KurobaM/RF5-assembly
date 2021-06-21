using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000749 RID: 1865
[Token(Token = "0x2000508")]
public class MummyController : BossMonsterContoroller
{
	// Token: 0x170006D4 RID: 1748
	// (get) Token: 0x06002FA0 RID: 12192 RVA: 0x00010E48 File Offset: 0x0000F048
	// (set) Token: 0x06002FA1 RID: 12193 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700056C")]
	public bool IsForceLockonMove
	{
		[Token(Token = "0x6002815")]
		[Address(RVA = "0x1E19B40", Offset = "0x1E19C41", VA = "0x1E19B40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3EF0", Offset = "0x1A3FF1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002816")]
		[Address(RVA = "0x1E19B50", Offset = "0x1E19C51", VA = "0x1E19B50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3F00", Offset = "0x1A4001")]
		set
		{
		}
	}

	// Token: 0x170006D5 RID: 1749
	// (get) Token: 0x06002FA2 RID: 12194 RVA: 0x00010E60 File Offset: 0x0000F060
	// (set) Token: 0x06002FA3 RID: 12195 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700056D")]
	public int WalkIndex
	{
		[Token(Token = "0x6002817")]
		[Address(RVA = "0x1E19B60", Offset = "0x1E19C61", VA = "0x1E19B60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3F10", Offset = "0x1A4011")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6002818")]
		[Address(RVA = "0x1E19B70", Offset = "0x1E19C71", VA = "0x1E19B70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3F20", Offset = "0x1A4021")]
		private set
		{
		}
	}

	// Token: 0x06002FA4 RID: 12196 RVA: 0x00010E78 File Offset: 0x0000F078
	[Token(Token = "0x6002819")]
	[Address(RVA = "0x1E19B80", Offset = "0x1E19C81", VA = "0x1E19B80", Slot = "104")]
	public override bool IsCanRestraint()
	{
		return default(bool);
	}

	// Token: 0x06002FA5 RID: 12197 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600281A")]
	[Address(RVA = "0x1E19BD0", Offset = "0x1E19CD1", VA = "0x1E19BD0", Slot = "19")]
	protected override void OnDestroy()
	{
	}

	// Token: 0x06002FA6 RID: 12198 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600281B")]
	[Address(RVA = "0x1E19CB0", Offset = "0x1E19DB1", VA = "0x1E19CB0", Slot = "12")]
	protected override void Start()
	{
	}

	// Token: 0x06002FA7 RID: 12199 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600281C")]
	[Address(RVA = "0x1E19E10", Offset = "0x1E19F11", VA = "0x1E19E10", Slot = "125")]
	protected override void OnSetModelObject(GameObject model)
	{
	}

	// Token: 0x06002FA8 RID: 12200 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600281D")]
	[Address(RVA = "0x1E1A4B0", Offset = "0x1E1A5B1", VA = "0x1E1A4B0", Slot = "128")]
	protected override void OnDeadEvent()
	{
	}

	// Token: 0x06002FA9 RID: 12201 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600281E")]
	[Address(RVA = "0x1E1A770", Offset = "0x1E1A871", VA = "0x1E1A770", Slot = "134")]
	public override void OnRestraint()
	{
	}

	// Token: 0x06002FAA RID: 12202 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600281F")]
	[Address(RVA = "0x1E1A8C0", Offset = "0x1E1A9C1", VA = "0x1E1A8C0", Slot = "135")]
	public override void OnRelease()
	{
	}

	// Token: 0x06002FAB RID: 12203 RVA: 0x00010E90 File Offset: 0x0000F090
	[Token(Token = "0x6002820")]
	[Address(RVA = "0x1E1A8E0", Offset = "0x1E1A9E1", VA = "0x1E1A8E0", Slot = "7")]
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult damageResult)
	{
		return default(bool);
	}

	// Token: 0x06002FAC RID: 12204 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002821")]
	[Address(RVA = "0x1E1A6E0", Offset = "0x1E1A7E1", VA = "0x1E1A6E0")]
	private void SetEnableEffectEmission(ParticleSystem[] particles, bool active)
	{
	}

	// Token: 0x06002FAD RID: 12205 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002822")]
	[Address(RVA = "0x1E1AA60", Offset = "0x1E1AB61", VA = "0x1E1AA60")]
	private void UpdateDeathSmokeMove()
	{
	}

	// Token: 0x06002FAE RID: 12206 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002823")]
	[Address(RVA = "0x1E1ACA0", Offset = "0x1E1ADA1", VA = "0x1E1ACA0")]
	private void NextWalkIndex()
	{
	}

	// Token: 0x06002FAF RID: 12207 RVA: 0x00010EA8 File Offset: 0x0000F0A8
	[Token(Token = "0x6002824")]
	[Address(RVA = "0x1E19040", Offset = "0x1E19141", VA = "0x1E19040")]
	public Vector3 GetNextWalkPos()
	{
		return default(Vector3);
	}

	// Token: 0x06002FB0 RID: 12208 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002825")]
	[Address(RVA = "0x1E192C0", Offset = "0x1E193C1", VA = "0x1E192C0")]
	public void FetchNearWalkPosIndex()
	{
	}

	// Token: 0x06002FB1 RID: 12209 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002826")]
	[Address(RVA = "0x1E1AD40", Offset = "0x1E1AE41", VA = "0x1E1AD40")]
	private void BatHitEvent(CharacterBase characterBase, MonsterProjectileActionScriptsController projectileActionScriptsController, int attackIndex)
	{
	}

	// Token: 0x06002FB2 RID: 12210 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002827")]
	[Address(RVA = "0x1E1ADC0", Offset = "0x1E1AEC1", VA = "0x1E1ADC0")]
	private void BatGoUp(MonsterProjectileActionScriptsController projectileActionScriptsController)
	{
	}

	// Token: 0x06002FB3 RID: 12211 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002828")]
	[Address(RVA = "0x1E1AF00", Offset = "0x1E1B001", VA = "0x1E1AF00")]
	private void CreateProjectileEvent(MonsterProjectileActionScriptsController projectileActionScriptsController, int attackIndex)
	{
	}

	// Token: 0x06002FB4 RID: 12212 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002829")]
	[Address(RVA = "0x1E1B0A0", Offset = "0x1E1B1A1", VA = "0x1E1B0A0")]
	private void StartSuction()
	{
	}

	// Token: 0x06002FB5 RID: 12213 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600282A")]
	[Address(RVA = "0x1E1A7C0", Offset = "0x1E1A8C1", VA = "0x1E1A7C0")]
	private void EndSuction()
	{
	}

	// Token: 0x06002FB6 RID: 12214 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600282B")]
	[Address(RVA = "0x1E1B240", Offset = "0x1E1B341", VA = "0x1E1B240")]
	private void UpadateBackSoul()
	{
	}

	// Token: 0x06002FB7 RID: 12215 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600282C")]
	[Address(RVA = "0x1E1B480", Offset = "0x1E1B581", VA = "0x1E1B480")]
	private void UpdateRotateSoul()
	{
	}

	// Token: 0x06002FB8 RID: 12216 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600282D")]
	[Address(RVA = "0x1E1B5D0", Offset = "0x1E1B6D1", VA = "0x1E1B5D0", Slot = "136")]
	protected override void OnHit(CharacterBase characterBase, int actionIndex)
	{
	}

	// Token: 0x06002FB9 RID: 12217 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600282E")]
	[Address(RVA = "0x1E1B610", Offset = "0x1E1B711", VA = "0x1E1B610", Slot = "132")]
	public override void OnUniqueActionCommandInternal(MonsterActionCommandBase monsterActionCommandBase, ActionCommandDataTable actionCommandData)
	{
	}

	// Token: 0x06002FBA RID: 12218 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600282F")]
	[Address(RVA = "0x1E1CBB0", Offset = "0x1E1CCB1", VA = "0x1E1CBB0", Slot = "133")]
	public override void OnUniqueProjectileActionCommandInternal(MonsterProjectileActionScriptsController monsterProjectileActionScriptsController, ActionCommandDataTable actionCommandData)
	{
	}

	// Token: 0x06002FBB RID: 12219 RVA: 0x00010EC0 File Offset: 0x0000F0C0
	[Token(Token = "0x6002830")]
	[Address(RVA = "0x1E1AB90", Offset = "0x1E1AC91", VA = "0x1E1AB90")]
	private bool HasArrived(float dist)
	{
		return default(bool);
	}

	// Token: 0x06002FBC RID: 12220 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002831")]
	[Address(RVA = "0x1E1CC60", Offset = "0x1E1CD61", VA = "0x1E1CC60", Slot = "39")]
	protected override void Update()
	{
	}

	// Token: 0x06002FBD RID: 12221 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002832")]
	[Address(RVA = "0x1E1CE30", Offset = "0x1E1CF31", VA = "0x1E1CE30")]
	public MummyController()
	{
	}

	// Token: 0x06002FBF RID: 12223 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002834")]
	[Address(RVA = "0x1E1CFE0", Offset = "0x1E1D0E1", VA = "0x1E1CFE0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3F30", Offset = "0x1A4031")]
	private void <OnSetModelObject>b__57_0(ParticleSystem particle)
	{
	}

	// Token: 0x06002FC0 RID: 12224 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002835")]
	[Address(RVA = "0x1E1D0C0", Offset = "0x1E1D1C1", VA = "0x1E1D0C0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3F40", Offset = "0x1A4041")]
	private void <OnSetModelObject>b__57_1(ParticleSystem particle)
	{
	}

	// Token: 0x06002FC1 RID: 12225 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002836")]
	[Address(RVA = "0x1E1D180", Offset = "0x1E1D281", VA = "0x1E1D180")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3F50", Offset = "0x1A4051")]
	private void <OnSetModelObject>b__57_2(ParticleSystem particle)
	{
	}

	// Token: 0x06002FC2 RID: 12226 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002837")]
	[Address(RVA = "0x1E1D240", Offset = "0x1E1D341", VA = "0x1E1D240")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3F60", Offset = "0x1A4061")]
	private void <OnSetModelObject>b__57_3(ParticleSystem particle)
	{
	}

	// Token: 0x06002FC3 RID: 12227 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002838")]
	[Address(RVA = "0x1E1D340", Offset = "0x1E1D441", VA = "0x1E1D340")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3F70", Offset = "0x1A4071")]
	private void <OnUniqueActionCommandInternal>b__75_0()
	{
	}

	// Token: 0x06002FC4 RID: 12228 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002839")]
	[Address(RVA = "0x1E1D380", Offset = "0x1E1D481", VA = "0x1E1D380")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3F80", Offset = "0x1A4081")]
	private void <OnUniqueActionCommandInternal>b__75_1()
	{
	}

	// Token: 0x04007528 RID: 29992
	[Token(Token = "0x4006B8B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Vector3 SCUTION_FLOOR_EFFECT_SCALE;

	// Token: 0x04007529 RID: 29993
	[Token(Token = "0x4006B8C")]
	[FieldOffset(Offset = "0xC")]
	private static readonly Vector3 SUCTION_ROTATESOUL_OFFSET;

	// Token: 0x0400752A RID: 29994
	[Token(Token = "0x4006B8D")]
	private const float ROTATESOUL_DOWN_MOVE_TIME = 1f;

	// Token: 0x0400752B RID: 29995
	[Token(Token = "0x4006B8E")]
	private const float ROTATESOUL_BACK_MOVE_SPEED = 3f;

	// Token: 0x0400752C RID: 29996
	[Token(Token = "0x4006B8F")]
	private const float WALK_MOVE_SCALE = 0.5f;

	// Token: 0x0400752D RID: 29997
	[Token(Token = "0x4006B90")]
	private const float WALK_DISTANCE = 5f;

	// Token: 0x0400752E RID: 29998
	[Token(Token = "0x4006B91")]
	private const float FORCE_WALK_DISTANCE = 1f;

	// Token: 0x0400752F RID: 29999
	[Token(Token = "0x4006B92")]
	private const float BULLET_SIN_SCALE = 0.4f;

	// Token: 0x04007530 RID: 30000
	[Token(Token = "0x4006B93")]
	private const float UPDOWN_SCALE = 1.5f;

	// Token: 0x04007531 RID: 30001
	[Token(Token = "0x4006B94")]
	[FieldOffset(Offset = "0x508")]
	private bool IsSetup;

	// Token: 0x04007532 RID: 30002
	[Token(Token = "0x4006B95")]
	[FieldOffset(Offset = "0x509")]
	private bool IsDeathSmoke;

	// Token: 0x04007533 RID: 30003
	[Token(Token = "0x4006B96")]
	[FieldOffset(Offset = "0x50A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1698C0", Offset = "0x1699C1")]
	private bool <IsForceLockonMove>k__BackingField;

	// Token: 0x04007534 RID: 30004
	[Token(Token = "0x4006B97")]
	[FieldOffset(Offset = "0x50C")]
	private int HandPressCount;

	// Token: 0x04007535 RID: 30005
	[Token(Token = "0x4006B98")]
	[FieldOffset(Offset = "0x510")]
	private int HandPressMin;

	// Token: 0x04007536 RID: 30006
	[Token(Token = "0x4006B99")]
	[FieldOffset(Offset = "0x514")]
	private int HandPressMax;

	// Token: 0x04007537 RID: 30007
	[Token(Token = "0x4006B9A")]
	[FieldOffset(Offset = "0x518")]
	private bool IsHitHand;

	// Token: 0x04007538 RID: 30008
	[Token(Token = "0x4006B9B")]
	[FieldOffset(Offset = "0x520")]
	private MummyHand MummyHandLeft;

	// Token: 0x04007539 RID: 30009
	[Token(Token = "0x4006B9C")]
	[FieldOffset(Offset = "0x528")]
	private MummyHand MummyHandRight;

	// Token: 0x0400753A RID: 30010
	[Token(Token = "0x4006B9D")]
	[FieldOffset(Offset = "0x530")]
	private GameObject LeftArm;

	// Token: 0x0400753B RID: 30011
	[Token(Token = "0x4006B9E")]
	[FieldOffset(Offset = "0x538")]
	private GameObject RightArm;

	// Token: 0x0400753C RID: 30012
	[Token(Token = "0x4006B9F")]
	[FieldOffset(Offset = "0x540")]
	private bool IsRightPress;

	// Token: 0x0400753D RID: 30013
	[Token(Token = "0x4006BA0")]
	[FieldOffset(Offset = "0x548")]
	private Transform SuctionColliderTransform;

	// Token: 0x0400753E RID: 30014
	[Token(Token = "0x4006BA1")]
	[FieldOffset(Offset = "0x550")]
	private bool IsSuction;

	// Token: 0x0400753F RID: 30015
	[Token(Token = "0x4006BA2")]
	[FieldOffset(Offset = "0x554")]
	private float SuctionPower;

	// Token: 0x04007540 RID: 30016
	[Token(Token = "0x4006BA3")]
	[FieldOffset(Offset = "0x558")]
	private float SuctionMaxRange;

	// Token: 0x04007541 RID: 30017
	[Token(Token = "0x4006BA4")]
	[FieldOffset(Offset = "0x55C")]
	private float SuctionMinRange;

	// Token: 0x04007542 RID: 30018
	[Token(Token = "0x4006BA5")]
	[FieldOffset(Offset = "0x560")]
	private bool IsFlying;

	// Token: 0x04007543 RID: 30019
	[Token(Token = "0x4006BA6")]
	[FieldOffset(Offset = "0x561")]
	private bool IsBackSoul;

	// Token: 0x04007544 RID: 30020
	[Token(Token = "0x4006BA7")]
	[FieldOffset(Offset = "0x568")]
	private string ASRestraintName;

	// Token: 0x04007545 RID: 30021
	[Token(Token = "0x4006BA8")]
	[FieldOffset(Offset = "0x570")]
	private string ASEndName;

	// Token: 0x04007546 RID: 30022
	[Token(Token = "0x4006BA9")]
	[FieldOffset(Offset = "0x578")]
	private int BulletCount;

	// Token: 0x04007547 RID: 30023
	[Token(Token = "0x4006BAA")]
	[FieldOffset(Offset = "0x57C")]
	private int TempBulletCount;

	// Token: 0x04007548 RID: 30024
	[Token(Token = "0x4006BAB")]
	[FieldOffset(Offset = "0x580")]
	private int PhaseCount;

	// Token: 0x04007549 RID: 30025
	[Token(Token = "0x4006BAC")]
	[FieldOffset(Offset = "0x584")]
	private Vector3 RotateSoul;

	// Token: 0x0400754A RID: 30026
	[Token(Token = "0x4006BAD")]
	[FieldOffset(Offset = "0x590")]
	private bool IsFlyingDead;

	// Token: 0x0400754B RID: 30027
	[Token(Token = "0x4006BAE")]
	[FieldOffset(Offset = "0x594")]
	private float UpDownTimer;

	// Token: 0x0400754C RID: 30028
	[Token(Token = "0x4006BAF")]
	[FieldOffset(Offset = "0x598")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1698D0", Offset = "0x1699D1")]
	private int <WalkIndex>k__BackingField;

	// Token: 0x0400754D RID: 30029
	[Token(Token = "0x4006BB0")]
	[FieldOffset(Offset = "0x5A0")]
	public List<Transform> WalkPosList;

	// Token: 0x0400754E RID: 30030
	[Token(Token = "0x4006BB1")]
	[FieldOffset(Offset = "0x5A8")]
	private bool IsForceBat;

	// Token: 0x0400754F RID: 30031
	[Token(Token = "0x4006BB2")]
	[FieldOffset(Offset = "0x5B0")]
	private ParticleSystem BreathEffect;

	// Token: 0x04007550 RID: 30032
	[Token(Token = "0x4006BB3")]
	[FieldOffset(Offset = "0x5B8")]
	private ParticleSystem[] BreathEffects;

	// Token: 0x04007551 RID: 30033
	[Token(Token = "0x4006BB4")]
	[FieldOffset(Offset = "0x5C0")]
	private ParticleSystem SoulEffect;

	// Token: 0x04007552 RID: 30034
	[Token(Token = "0x4006BB5")]
	[FieldOffset(Offset = "0x5C8")]
	private ParticleSystem RotateSoulEffect;

	// Token: 0x04007553 RID: 30035
	[Token(Token = "0x4006BB6")]
	[FieldOffset(Offset = "0x5D0")]
	private ParticleSystem[] RotateSoulEffects;

	// Token: 0x04007554 RID: 30036
	[Token(Token = "0x4006BB7")]
	[FieldOffset(Offset = "0x5D8")]
	private ParticleSystem SuctionEffect;

	// Token: 0x04007555 RID: 30037
	[Token(Token = "0x4006BB8")]
	[FieldOffset(Offset = "0x5E0")]
	private ParticleSystem[] SuctionEffects;

	// Token: 0x04007556 RID: 30038
	[Token(Token = "0x4006BB9")]
	[FieldOffset(Offset = "0x5E8")]
	private ParticleSystem FloorSuctionEffect;

	// Token: 0x04007557 RID: 30039
	[Token(Token = "0x4006BBA")]
	[FieldOffset(Offset = "0x5F0")]
	private ParticleSystem[] FloorSuctionEffects;
}
