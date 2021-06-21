using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Loader;
using UnityEngine;

// Token: 0x020006F6 RID: 1782
[Token(Token = "0x20004E6")]
public class GansekiDragonController : BossMonsterContoroller
{
	// Token: 0x170006AC RID: 1708
	// (get) Token: 0x06002C77 RID: 11383 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002C78 RID: 11384 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000552")]
	public GameObject MimicryModel
	{
		[Token(Token = "0x6002580")]
		[Address(RVA = "0x1F9B420", Offset = "0x1F9B521", VA = "0x1F9B420")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2FE0", Offset = "0x1A30E1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002581")]
		[Address(RVA = "0x1F9B430", Offset = "0x1F9B531", VA = "0x1F9B430")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2FF0", Offset = "0x1A30F1")]
		set
		{
		}
	}

	// Token: 0x170006AD RID: 1709
	// (get) Token: 0x06002C79 RID: 11385 RVA: 0x00010920 File Offset: 0x0000EB20
	// (set) Token: 0x06002C7A RID: 11386 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000553")]
	public bool IsMimicry
	{
		[Token(Token = "0x6002582")]
		[Address(RVA = "0x1F9B440", Offset = "0x1F9B541", VA = "0x1F9B440")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3000", Offset = "0x1A3101")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002583")]
		[Address(RVA = "0x1F9B450", Offset = "0x1F9B551", VA = "0x1F9B450")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3010", Offset = "0x1A3111")]
		private set
		{
		}
	}

	// Token: 0x170006AE RID: 1710
	// (get) Token: 0x06002C7B RID: 11387 RVA: 0x00010938 File Offset: 0x0000EB38
	// (set) Token: 0x06002C7C RID: 11388 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000554")]
	public float DefenceLayerDamageRate
	{
		[Token(Token = "0x6002584")]
		[Address(RVA = "0x1F9B460", Offset = "0x1F9B561", VA = "0x1F9B460")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3020", Offset = "0x1A3121")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6002585")]
		[Address(RVA = "0x1F9B470", Offset = "0x1F9B571", VA = "0x1F9B470")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3030", Offset = "0x1A3131")]
		set
		{
		}
	}

	// Token: 0x170006AF RID: 1711
	// (get) Token: 0x06002C7D RID: 11389 RVA: 0x00010950 File Offset: 0x0000EB50
	// (set) Token: 0x06002C7E RID: 11390 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000555")]
	public float ForceReleaseDamageRate
	{
		[Token(Token = "0x6002586")]
		[Address(RVA = "0x1F9B480", Offset = "0x1F9B581", VA = "0x1F9B480")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3040", Offset = "0x1A3141")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6002587")]
		[Address(RVA = "0x1F9B490", Offset = "0x1F9B591", VA = "0x1F9B490")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3050", Offset = "0x1A3151")]
		set
		{
		}
	}

	// Token: 0x170006B0 RID: 1712
	// (get) Token: 0x06002C7F RID: 11391 RVA: 0x00010968 File Offset: 0x0000EB68
	// (set) Token: 0x06002C80 RID: 11392 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000556")]
	public float ForceReleaseDamageRateTime
	{
		[Token(Token = "0x6002588")]
		[Address(RVA = "0x1F9B4A0", Offset = "0x1F9B5A1", VA = "0x1F9B4A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3060", Offset = "0x1A3161")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6002589")]
		[Address(RVA = "0x1F9B4B0", Offset = "0x1F9B5B1", VA = "0x1F9B4B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3070", Offset = "0x1A3171")]
		set
		{
		}
	}

	// Token: 0x06002C81 RID: 11393 RVA: 0x00010980 File Offset: 0x0000EB80
	[Token(Token = "0x600258A")]
	[Address(RVA = "0x1F9B4C0", Offset = "0x1F9B5C1", VA = "0x1F9B4C0", Slot = "151")]
	protected override bool CanReciveItem()
	{
		return default(bool);
	}

	// Token: 0x06002C82 RID: 11394 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600258B")]
	[Address(RVA = "0x1F9B4E0", Offset = "0x1F9B5E1", VA = "0x1F9B4E0", Slot = "19")]
	protected override void OnDestroy()
	{
	}

	// Token: 0x06002C83 RID: 11395 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600258C")]
	[Address(RVA = "0x1F9B600", Offset = "0x1F9B701", VA = "0x1F9B600", Slot = "12")]
	protected override void Start()
	{
	}

	// Token: 0x06002C84 RID: 11396 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600258D")]
	[Address(RVA = "0x1F9B6B0", Offset = "0x1F9B7B1", VA = "0x1F9B6B0", Slot = "126")]
	protected override void OnSetup()
	{
	}

	// Token: 0x06002C85 RID: 11397 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600258E")]
	[Address(RVA = "0x1F9B8B0", Offset = "0x1F9B9B1", VA = "0x1F9B8B0", Slot = "127")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A3080", Offset = "0x1A3181")]
	protected override IEnumerator OnSetupAsync()
	{
		return null;
	}

	// Token: 0x06002C86 RID: 11398 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600258F")]
	[Address(RVA = "0x1F9B960", Offset = "0x1F9BA61", VA = "0x1F9B960", Slot = "39")]
	protected override void Update()
	{
	}

	// Token: 0x06002C87 RID: 11399 RVA: 0x00010998 File Offset: 0x0000EB98
	[Token(Token = "0x6002590")]
	[Address(RVA = "0x1F9C010", Offset = "0x1F9C111", VA = "0x1F9C010", Slot = "7")]
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult damageResult)
	{
		return default(bool);
	}

	// Token: 0x06002C88 RID: 11400 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002591")]
	[Address(RVA = "0x1F9C3A0", Offset = "0x1F9C4A1", VA = "0x1F9C3A0", Slot = "128")]
	protected override void OnDeadEvent()
	{
	}

	// Token: 0x06002C89 RID: 11401 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002592")]
	[Address(RVA = "0x1F9C4C0", Offset = "0x1F9C5C1", VA = "0x1F9C4C0", Slot = "134")]
	public override void OnRestraint()
	{
	}

	// Token: 0x06002C8A RID: 11402 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002593")]
	[Address(RVA = "0x1F9C500", Offset = "0x1F9C601", VA = "0x1F9C500")]
	private void OnHitEvent(CharacterBase _, int __)
	{
	}

	// Token: 0x06002C8B RID: 11403 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002594")]
	[Address(RVA = "0x1F9C520", Offset = "0x1F9C621", VA = "0x1F9C520")]
	private void OnEndActionScript()
	{
	}

	// Token: 0x06002C8C RID: 11404 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002595")]
	[Address(RVA = "0x1F9C530", Offset = "0x1F9C631", VA = "0x1F9C530")]
	public void ReSetProjectile()
	{
	}

	// Token: 0x06002C8D RID: 11405 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002596")]
	[Address(RVA = "0x1F9C540", Offset = "0x1F9C641", VA = "0x1F9C540")]
	private void CreateProjectileRock(MonsterProjectileActionScriptsController projectileActionScriptsController, int attackIndex)
	{
	}

	// Token: 0x06002C8E RID: 11406 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002597")]
	[Address(RVA = "0x1F9A480", Offset = "0x1F9A581", VA = "0x1F9A480")]
	public void Shake(float _duration, float _strength)
	{
	}

	// Token: 0x06002C8F RID: 11407 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002598")]
	[Address(RVA = "0x1F9C770", Offset = "0x1F9C871", VA = "0x1F9C770")]
	public void Punch(float _duration, Vector3 _punch)
	{
	}

	// Token: 0x06002C90 RID: 11408 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002599")]
	[Address(RVA = "0x1F9BE30", Offset = "0x1F9BF31", VA = "0x1F9BE30")]
	private void UpdateForceReleasedTimer()
	{
	}

	// Token: 0x06002C91 RID: 11409 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600259A")]
	[Address(RVA = "0x1F9C7F0", Offset = "0x1F9C8F1", VA = "0x1F9C7F0")]
	private void NormalToMimicry()
	{
	}

	// Token: 0x06002C92 RID: 11410 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600259B")]
	[Address(RVA = "0x1F9C430", Offset = "0x1F9C531", VA = "0x1F9C430")]
	private void MimicryToNormal()
	{
	}

	// Token: 0x06002C93 RID: 11411 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600259C")]
	[Address(RVA = "0x1F9A8A0", Offset = "0x1F9A9A1", VA = "0x1F9A8A0")]
	public void OnForceMimicryRelease()
	{
	}

	// Token: 0x06002C94 RID: 11412 RVA: 0x000109B0 File Offset: 0x0000EBB0
	[Token(Token = "0x600259D")]
	[Address(RVA = "0x1F9C900", Offset = "0x1F9CA01", VA = "0x1F9C900")]
	private bool WallRayCast(Vector3 direction)
	{
		return default(bool);
	}

	// Token: 0x06002C95 RID: 11413 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600259E")]
	[Address(RVA = "0x1F9BA60", Offset = "0x1F9BB61", VA = "0x1F9BA60")]
	private void UpdateMimicryRush()
	{
	}

	// Token: 0x06002C96 RID: 11414 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600259F")]
	[Address(RVA = "0x1F9CB30", Offset = "0x1F9CC31", VA = "0x1F9CB30")]
	private void HitWall()
	{
	}

	// Token: 0x06002C97 RID: 11415 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025A0")]
	[Address(RVA = "0x1F9BEB0", Offset = "0x1F9BFB1", VA = "0x1F9BEB0")]
	public void UpdateSmoke()
	{
	}

	// Token: 0x06002C98 RID: 11416 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025A1")]
	[Address(RVA = "0x1F9CBF0", Offset = "0x1F9CCF1", VA = "0x1F9CBF0")]
	public void SmokeOn()
	{
	}

	// Token: 0x06002C99 RID: 11417 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025A2")]
	[Address(RVA = "0x1F9C4F0", Offset = "0x1F9C5F1", VA = "0x1F9C4F0")]
	public void SmokeOff()
	{
	}

	// Token: 0x06002C9A RID: 11418 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025A3")]
	[Address(RVA = "0x1F9C0E0", Offset = "0x1F9C1E1", VA = "0x1F9C0E0")]
	public void DefenceLayerEffect(bool isBreak, Vector3 hitPos)
	{
	}

	// Token: 0x06002C9B RID: 11419 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025A4")]
	[Address(RVA = "0x1F9CD30", Offset = "0x1F9CE31", VA = "0x1F9CD30", Slot = "132")]
	public override void OnUniqueActionCommandInternal(MonsterActionCommandBase monsterActionCommandBase, ActionCommandDataTable actionCommandData)
	{
	}

	// Token: 0x06002C9C RID: 11420 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025A5")]
	[Address(RVA = "0x1F9D7B0", Offset = "0x1F9D8B1", VA = "0x1F9D7B0")]
	public GansekiDragonController()
	{
	}

	// Token: 0x06002C9E RID: 11422 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025A7")]
	[Address(RVA = "0x1F9D920", Offset = "0x1F9DA21", VA = "0x1F9D920")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A30F0", Offset = "0x1A31F1")]
	private void <Start>b__42_0(ParticleSystem particle)
	{
	}

	// Token: 0x06002C9F RID: 11423 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025A8")]
	[Address(RVA = "0x1F9DAD0", Offset = "0x1F9DBD1", VA = "0x1F9DAD0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3100", Offset = "0x1A3201")]
	private void <OnUniqueActionCommandInternal>b__66_1()
	{
	}

	// Token: 0x06002CA0 RID: 11424 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025A9")]
	[Address(RVA = "0x1F9DB50", Offset = "0x1F9DC51", VA = "0x1F9DB50")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3110", Offset = "0x1A3211")]
	private void <OnUniqueActionCommandInternal>b__66_0()
	{
	}

	// Token: 0x04007360 RID: 29536
	[Token(Token = "0x4006A89")]
	private const float RAY_DISTANCE_OFFSET = 1f;

	// Token: 0x04007361 RID: 29537
	[Token(Token = "0x4006A8A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Vector3 RAY_ORIGIN_POS_OFFSET;

	// Token: 0x04007362 RID: 29538
	[Token(Token = "0x4006A8B")]
	private const float SMOKE_TIME = 1.2f;

	// Token: 0x04007363 RID: 29539
	[Token(Token = "0x4006A8C")]
	[FieldOffset(Offset = "0xC")]
	private static readonly Vector3 ATTACK_RANGE_EFFECT_SCALE;

	// Token: 0x04007364 RID: 29540
	[Token(Token = "0x4006A8D")]
	[FieldOffset(Offset = "0x508")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1696C0", Offset = "0x1697C1")]
	private GameObject <MimicryModel>k__BackingField;

	// Token: 0x04007365 RID: 29541
	[Token(Token = "0x4006A8E")]
	[FieldOffset(Offset = "0x510")]
	private int MimicryModelId;

	// Token: 0x04007366 RID: 29542
	[Token(Token = "0x4006A8F")]
	[FieldOffset(Offset = "0x514")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1696D0", Offset = "0x1697D1")]
	private bool <IsMimicry>k__BackingField;

	// Token: 0x04007367 RID: 29543
	[Token(Token = "0x4006A90")]
	[FieldOffset(Offset = "0x515")]
	private bool IsForceReleased;

	// Token: 0x04007368 RID: 29544
	[Token(Token = "0x4006A91")]
	[FieldOffset(Offset = "0x518")]
	private float ForceReleasedTimer;

	// Token: 0x04007369 RID: 29545
	[Token(Token = "0x4006A92")]
	[FieldOffset(Offset = "0x51C")]
	private bool IsSmoke;

	// Token: 0x0400736A RID: 29546
	[Token(Token = "0x4006A93")]
	[FieldOffset(Offset = "0x520")]
	private float SmokeTimer;

	// Token: 0x0400736B RID: 29547
	[Token(Token = "0x4006A94")]
	[FieldOffset(Offset = "0x528")]
	private Transform JawEndTrans;

	// Token: 0x0400736C RID: 29548
	[Token(Token = "0x4006A95")]
	[FieldOffset(Offset = "0x530")]
	private GameObject RockPrefab;

	// Token: 0x0400736D RID: 29549
	[Token(Token = "0x4006A96")]
	[FieldOffset(Offset = "0x538")]
	private MonsterProjectileActionScriptsController[] Rocks;

	// Token: 0x0400736E RID: 29550
	[Token(Token = "0x4006A97")]
	[FieldOffset(Offset = "0x540")]
	private Transform FlyRockPoints;

	// Token: 0x0400736F RID: 29551
	[Token(Token = "0x4006A98")]
	[FieldOffset(Offset = "0x548")]
	private GansekiDragonController.RushType _RushType;

	// Token: 0x04007370 RID: 29552
	[Token(Token = "0x4006A99")]
	[FieldOffset(Offset = "0x54C")]
	private bool IsRushHit;

	// Token: 0x04007371 RID: 29553
	[Token(Token = "0x4006A9A")]
	[FieldOffset(Offset = "0x550")]
	private float RushRotateSpeed;

	// Token: 0x04007372 RID: 29554
	[Token(Token = "0x4006A9B")]
	[FieldOffset(Offset = "0x554")]
	private bool IsRayCheck;

	// Token: 0x04007373 RID: 29555
	[Token(Token = "0x4006A9C")]
	[FieldOffset(Offset = "0x558")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1696E0", Offset = "0x1697E1")]
	private float <DefenceLayerDamageRate>k__BackingField;

	// Token: 0x04007374 RID: 29556
	[Token(Token = "0x4006A9D")]
	[FieldOffset(Offset = "0x55C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1696F0", Offset = "0x1697F1")]
	private float <ForceReleaseDamageRate>k__BackingField;

	// Token: 0x04007375 RID: 29557
	[Token(Token = "0x4006A9E")]
	[FieldOffset(Offset = "0x560")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x169700", Offset = "0x169801")]
	private float <ForceReleaseDamageRateTime>k__BackingField;

	// Token: 0x04007376 RID: 29558
	[Token(Token = "0x4006A9F")]
	[FieldOffset(Offset = "0x568")]
	public AnimationCurve JumpAnimationCurve;

	// Token: 0x04007377 RID: 29559
	[Token(Token = "0x4006AA0")]
	[FieldOffset(Offset = "0x570")]
	private ParticleSystem JumpPointEffect;

	// Token: 0x020006F7 RID: 1783
	[Token(Token = "0x2001197")]
	private enum RushType
	{
		// Token: 0x04007379 RID: 29561
		[Token(Token = "0x4019541")]
		None,
		// Token: 0x0400737A RID: 29562
		[Token(Token = "0x4019542")]
		Normal,
		// Token: 0x0400737B RID: 29563
		[Token(Token = "0x4019543")]
		NormalDouble,
		// Token: 0x0400737C RID: 29564
		[Token(Token = "0x4019544")]
		Mimicry,
		// Token: 0x0400737D RID: 29565
		[Token(Token = "0x4019545")]
		MadnessMimicry1,
		// Token: 0x0400737E RID: 29566
		[Token(Token = "0x4019546")]
		MadnessMimicry2
	}

	// Token: 0x020006F8 RID: 1784
	[Token(Token = "0x2001198")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1583F0", Offset = "0x1584F1")]
	private sealed class <>c__DisplayClass44_0
	{
		// Token: 0x06002CA1 RID: 11425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071E2")]
		[Address(RVA = "0x1F9DBD0", Offset = "0x1F9DCD1", VA = "0x1F9DBD0")]
		public <>c__DisplayClass44_0()
		{
		}

		// Token: 0x06002CA2 RID: 11426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071E3")]
		[Address(RVA = "0x1F9DBE0", Offset = "0x1F9DCE1", VA = "0x1F9DBE0")]
		internal void <OnSetupAsync>b__0(AssetHandle<GameObject> handle)
		{
		}

		// Token: 0x06002CA3 RID: 11427 RVA: 0x000109C8 File Offset: 0x0000EBC8
		[Token(Token = "0x60071E4")]
		[Address(RVA = "0x1F9DCE0", Offset = "0x1F9DDE1", VA = "0x1F9DCE0")]
		internal bool <OnSetupAsync>b__1()
		{
			return default(bool);
		}

		// Token: 0x0400737F RID: 29567
		[Token(Token = "0x4019547")]
		[FieldOffset(Offset = "0x10")]
		public GansekiDragonController <>4__this;

		// Token: 0x04007380 RID: 29568
		[Token(Token = "0x4019548")]
		[FieldOffset(Offset = "0x18")]
		public bool isComplete;
	}

	// Token: 0x020006F9 RID: 1785
	[Token(Token = "0x2001199")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158400", Offset = "0x158501")]
	private sealed class <OnSetupAsync>d__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06002CA4 RID: 11428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071E5")]
		[Address(RVA = "0x1F9B930", Offset = "0x1F9BA31", VA = "0x1F9B930")]
		[DebuggerHidden]
		public <OnSetupAsync>d__44(int <>1__state)
		{
		}

		// Token: 0x06002CA5 RID: 11429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071E6")]
		[Address(RVA = "0x1F9DCF0", Offset = "0x1F9DDF1", VA = "0x1F9DCF0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06002CA6 RID: 11430 RVA: 0x000109E0 File Offset: 0x0000EBE0
		[Token(Token = "0x60071E7")]
		[Address(RVA = "0x1F9DD00", Offset = "0x1F9DE01", VA = "0x1F9DD00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x06002CA7 RID: 11431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D17")]
		private object Current
		{
			[Token(Token = "0x60071E8")]
			[Address(RVA = "0x1F9DEB0", Offset = "0x1F9DFB1", VA = "0x1F9DEB0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06002CA8 RID: 11432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071E9")]
		[Address(RVA = "0x1F9DEC0", Offset = "0x1F9DFC1", VA = "0x1F9DEC0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x06002CA9 RID: 11433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D18")]
		private object Current
		{
			[Token(Token = "0x60071EA")]
			[Address(RVA = "0x1F9DF20", Offset = "0x1F9E021", VA = "0x1F9DF20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04007381 RID: 29569
		[Token(Token = "0x4019549")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04007382 RID: 29570
		[Token(Token = "0x401954A")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04007383 RID: 29571
		[Token(Token = "0x401954B")]
		[FieldOffset(Offset = "0x20")]
		public GansekiDragonController <>4__this;
	}
}
