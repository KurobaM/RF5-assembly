using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200073D RID: 1853
[Token(Token = "0x2000504")]
public class LastBossController : BossMonsterContoroller
{
	// Token: 0x170006D3 RID: 1747
	// (get) Token: 0x06002F4A RID: 12106 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002F4B RID: 12107 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700056B")]
	public DN18BossStageManager DN18BossStageManager
	{
		[Token(Token = "0x60027D8")]
		[Address(RVA = "0x23077F0", Offset = "0x23078F1", VA = "0x23077F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3E00", Offset = "0x1A3F01")]
		get
		{
			return null;
		}
		[Token(Token = "0x60027D9")]
		[Address(RVA = "0x2307800", Offset = "0x2307901", VA = "0x2307800")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3E10", Offset = "0x1A3F11")]
		private set
		{
		}
	}

	// Token: 0x06002F4C RID: 12108 RVA: 0x00010DD0 File Offset: 0x0000EFD0
	[Token(Token = "0x60027DA")]
	[Address(RVA = "0x2307810", Offset = "0x2307911", VA = "0x2307810", Slot = "104")]
	public override bool IsCanRestraint()
	{
		return default(bool);
	}

	// Token: 0x06002F4D RID: 12109 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60027DB")]
	[Address(RVA = "0x2307860", Offset = "0x2307961", VA = "0x2307860", Slot = "154")]
	public override void CreateMadnessEffect(ParticleSystem prefab, List<string> boneNameList, float scaleValue)
	{
	}

	// Token: 0x06002F4E RID: 12110 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60027DC")]
	[Address(RVA = "0x23079C0", Offset = "0x2307AC1", VA = "0x23079C0", Slot = "12")]
	protected override void Start()
	{
	}

	// Token: 0x06002F4F RID: 12111 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60027DD")]
	[Address(RVA = "0x2307A80", Offset = "0x2307B81", VA = "0x2307A80", Slot = "128")]
	protected override void OnDeadEvent()
	{
	}

	// Token: 0x06002F50 RID: 12112 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60027DE")]
	[Address(RVA = "0x2307AB0", Offset = "0x2307BB1", VA = "0x2307AB0", Slot = "126")]
	protected override void OnSetup()
	{
	}

	// Token: 0x06002F51 RID: 12113 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60027DF")]
	[Address(RVA = "0x23083A0", Offset = "0x23084A1", VA = "0x23083A0", Slot = "39")]
	protected override void Update()
	{
	}

	// Token: 0x06002F52 RID: 12114 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60027E0")]
	[Address(RVA = "0x2308910", Offset = "0x2308A11", VA = "0x2308910")]
	private void CreateProjectileEvent(MonsterProjectileActionScriptsController projectileActionScriptsController, int attackIndex)
	{
	}

	// Token: 0x06002F53 RID: 12115 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60027E1")]
	[Address(RVA = "0x2308C30", Offset = "0x2308D31", VA = "0x2308C30", Slot = "134")]
	public override void OnRestraint()
	{
	}

	// Token: 0x06002F54 RID: 12116 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60027E2")]
	[Address(RVA = "0x2308C50", Offset = "0x2308D51", VA = "0x2308C50", Slot = "135")]
	public override void OnRelease()
	{
	}

	// Token: 0x06002F55 RID: 12117 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60027E3")]
	[Address(RVA = "0x2308CC0", Offset = "0x2308DC1", VA = "0x2308CC0")]
	private void UpdateSuction()
	{
	}

	// Token: 0x06002F56 RID: 12118 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60027E4")]
	[Address(RVA = "0x23088E0", Offset = "0x23089E1", VA = "0x23088E0")]
	private void UpdateBone()
	{
	}

	// Token: 0x06002F57 RID: 12119 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60027E5")]
	[Address(RVA = "0x2308F70", Offset = "0x2309071", VA = "0x2308F70")]
	private void UpdateBonePointRotation()
	{
	}

	// Token: 0x06002F58 RID: 12120 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60027E6")]
	[Address(RVA = "0x23092A0", Offset = "0x23093A1", VA = "0x23092A0")]
	private void UpdateFadeBone()
	{
	}

	// Token: 0x06002F59 RID: 12121 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60027E7")]
	[Address(RVA = "0x23080B0", Offset = "0x23081B1", VA = "0x23080B0")]
	private void SetupEmission()
	{
	}

	// Token: 0x06002F5A RID: 12122 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60027E8")]
	[Address(RVA = "0x23096C0", Offset = "0x23097C1", VA = "0x23096C0")]
	private void OnEmission()
	{
	}

	// Token: 0x06002F5B RID: 12123 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60027E9")]
	[Address(RVA = "0x2309750", Offset = "0x2309851", VA = "0x2309750")]
	private void OnFlashing()
	{
	}

	// Token: 0x06002F5C RID: 12124 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60027EA")]
	[Address(RVA = "0x23097E0", Offset = "0x23098E1", VA = "0x23097E0")]
	private void OffEmission()
	{
	}

	// Token: 0x06002F5D RID: 12125 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60027EB")]
	[Address(RVA = "0x23084D0", Offset = "0x23085D1", VA = "0x23084D0")]
	private void UpdateEmission()
	{
	}

	// Token: 0x06002F5E RID: 12126 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60027EC")]
	[Address(RVA = "0x23097F0", Offset = "0x23098F1", VA = "0x23097F0", Slot = "132")]
	public override void OnUniqueActionCommandInternal(MonsterActionCommandBase monsterActionCommandBase, ActionCommandDataTable actionCommandData)
	{
	}

	// Token: 0x06002F5F RID: 12127 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60027ED")]
	[Address(RVA = "0x230A550", Offset = "0x230A651", VA = "0x230A550")]
	public LastBossController()
	{
	}

	// Token: 0x06002F61 RID: 12129 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60027EF")]
	[Address(RVA = "0x230B100", Offset = "0x230B201", VA = "0x230B100")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3E20", Offset = "0x1A3F21")]
	private void <OnUniqueActionCommandInternal>b__64_0()
	{
	}

	// Token: 0x06002F62 RID: 12130 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60027F0")]
	[Address(RVA = "0x230B3B0", Offset = "0x230B4B1", VA = "0x230B3B0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3E30", Offset = "0x1A3F31")]
	private void <OnUniqueActionCommandInternal>b__64_1()
	{
	}

	// Token: 0x040074E1 RID: 29921
	[Token(Token = "0x4006B60")]
	private const float SCALE_2M = 0.1f;

	// Token: 0x040074E2 RID: 29922
	[Token(Token = "0x4006B61")]
	private const float SCALE_6M = 0.3f;

	// Token: 0x040074E3 RID: 29923
	[Token(Token = "0x4006B62")]
	private const float SCALE_10M = 0.5f;

	// Token: 0x040074E4 RID: 29924
	[Token(Token = "0x4006B63")]
	private const float SCALE_15M = 0.75f;

	// Token: 0x040074E5 RID: 29925
	[Token(Token = "0x4006B64")]
	private const float SCALE_20M = 1f;

	// Token: 0x040074E6 RID: 29926
	[Token(Token = "0x4006B65")]
	private const float SCALE_40M = 2f;

	// Token: 0x040074E7 RID: 29927
	[Token(Token = "0x4006B66")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string[] BonePointNames;

	// Token: 0x040074E8 RID: 29928
	[Token(Token = "0x4006B67")]
	[FieldOffset(Offset = "0x8")]
	private static readonly Vector3[] LocalPosition;

	// Token: 0x040074E9 RID: 29929
	[Token(Token = "0x4006B68")]
	private const float ARRIVED_LENGTH = 3f;

	// Token: 0x040074EA RID: 29930
	[Token(Token = "0x4006B69")]
	private const float WARP_FADE_TIME = 0.5f;

	// Token: 0x040074EB RID: 29931
	[Token(Token = "0x4006B6A")]
	[FieldOffset(Offset = "0x10")]
	private static readonly string[] BONE_MATERIAL_NAMES;

	// Token: 0x040074EC RID: 29932
	[Token(Token = "0x4006B6B")]
	private const float BONE_FADE_MIN = 0.001f;

	// Token: 0x040074ED RID: 29933
	[Token(Token = "0x4006B6C")]
	[FieldOffset(Offset = "0x18")]
	private static readonly Vector3 PUNCH_VEC;

	// Token: 0x040074EE RID: 29934
	[Token(Token = "0x4006B6D")]
	private const float PUNCH_SEC = 0.1f;

	// Token: 0x040074EF RID: 29935
	[Token(Token = "0x4006B6E")]
	private const string MADNESS_ADV_SCRIPT_NAME = "boss_lastboss_002";

	// Token: 0x040074F0 RID: 29936
	[Token(Token = "0x4006B6F")]
	private const string EMISSION_COLOR = "_EmissionColor";

	// Token: 0x040074F1 RID: 29937
	[Token(Token = "0x4006B70")]
	[FieldOffset(Offset = "0x508")]
	public float EMISSION_FADEINOUT_SPEED;

	// Token: 0x040074F2 RID: 29938
	[Token(Token = "0x4006B71")]
	[FieldOffset(Offset = "0x50C")]
	public float EMISSION_LOOP_SPEED;

	// Token: 0x040074F3 RID: 29939
	[Token(Token = "0x4006B72")]
	[FieldOffset(Offset = "0x510")]
	private float EMISSION_LOOP_ALPHA_MIN_RATIO;

	// Token: 0x040074F4 RID: 29940
	[Token(Token = "0x4006B73")]
	[FieldOffset(Offset = "0x514")]
	private float EMISSION_FLASHING_SPEED;

	// Token: 0x040074F5 RID: 29941
	[Token(Token = "0x4006B74")]
	[FieldOffset(Offset = "0x518")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1698B0", Offset = "0x1699B1")]
	private DN18BossStageManager <DN18BossStageManager>k__BackingField;

	// Token: 0x040074F6 RID: 29942
	[Token(Token = "0x4006B75")]
	[FieldOffset(Offset = "0x520")]
	private Transform SuctionColliderTransform;

	// Token: 0x040074F7 RID: 29943
	[Token(Token = "0x4006B76")]
	[FieldOffset(Offset = "0x528")]
	private bool IsSuction;

	// Token: 0x040074F8 RID: 29944
	[Token(Token = "0x4006B77")]
	[FieldOffset(Offset = "0x52C")]
	private float SuctionPower;

	// Token: 0x040074F9 RID: 29945
	[Token(Token = "0x4006B78")]
	[FieldOffset(Offset = "0x530")]
	private float SuctionMaxRange;

	// Token: 0x040074FA RID: 29946
	[Token(Token = "0x4006B79")]
	[FieldOffset(Offset = "0x534")]
	private float SuctionMinRange;

	// Token: 0x040074FB RID: 29947
	[Token(Token = "0x4006B7A")]
	[FieldOffset(Offset = "0x538")]
	private Transform[] BonePoints;

	// Token: 0x040074FC RID: 29948
	[Token(Token = "0x4006B7B")]
	[FieldOffset(Offset = "0x540")]
	private Transform Attack4Points;

	// Token: 0x040074FD RID: 29949
	[Token(Token = "0x4006B7C")]
	[FieldOffset(Offset = "0x548")]
	private List<ParticleSystem> Attack4EffectList;

	// Token: 0x040074FE RID: 29950
	[Token(Token = "0x4006B7D")]
	[FieldOffset(Offset = "0x28")]
	private static readonly string[] ATTACK4EFFECTLIST;

	// Token: 0x040074FF RID: 29951
	[Token(Token = "0x4006B7E")]
	[FieldOffset(Offset = "0x550")]
	private bool IsRestaintBodyFadeIn;

	// Token: 0x04007500 RID: 29952
	[Token(Token = "0x4006B7F")]
	[FieldOffset(Offset = "0x551")]
	private bool IsBoneDrop;

	// Token: 0x04007501 RID: 29953
	[Token(Token = "0x4006B80")]
	[FieldOffset(Offset = "0x554")]
	private MonsterControllerBase.FadeType BoneFadeType;

	// Token: 0x04007502 RID: 29954
	[Token(Token = "0x4006B81")]
	[FieldOffset(Offset = "0x558")]
	private List<Material> BoneMaterialList;

	// Token: 0x04007503 RID: 29955
	[Token(Token = "0x4006B82")]
	[FieldOffset(Offset = "0x560")]
	private float BoneFadeTimer;

	// Token: 0x04007504 RID: 29956
	[Token(Token = "0x4006B83")]
	[FieldOffset(Offset = "0x564")]
	private float BoneFadeDuration;

	// Token: 0x04007505 RID: 29957
	[Token(Token = "0x4006B84")]
	[FieldOffset(Offset = "0x568")]
	private LastBossBone PrefabLastBossBone;

	// Token: 0x04007506 RID: 29958
	[Token(Token = "0x4006B85")]
	[FieldOffset(Offset = "0x570")]
	private List<LastBossBone> LastBossBoneList;

	// Token: 0x04007507 RID: 29959
	[Token(Token = "0x4006B86")]
	[FieldOffset(Offset = "0x578")]
	private string ASReleaseName;

	// Token: 0x04007508 RID: 29960
	[Token(Token = "0x4006B87")]
	[FieldOffset(Offset = "0x580")]
	private List<Color> DefaultEmissionColors;

	// Token: 0x04007509 RID: 29961
	[Token(Token = "0x4006B88")]
	[FieldOffset(Offset = "0x588")]
	private float EmissionAlphaTimer;

	// Token: 0x0400750A RID: 29962
	[Token(Token = "0x4006B89")]
	[FieldOffset(Offset = "0x58C")]
	private LastBossController.EmissionState _EmissionState;

	// Token: 0x0200073E RID: 1854
	[Token(Token = "0x20011C0")]
	private enum EmissionState
	{
		// Token: 0x0400750C RID: 29964
		[Token(Token = "0x40195EB")]
		None,
		// Token: 0x0400750D RID: 29965
		[Token(Token = "0x40195EC")]
		Start,
		// Token: 0x0400750E RID: 29966
		[Token(Token = "0x40195ED")]
		Loop,
		// Token: 0x0400750F RID: 29967
		[Token(Token = "0x40195EE")]
		Flashing,
		// Token: 0x04007510 RID: 29968
		[Token(Token = "0x40195EF")]
		End
	}

	// Token: 0x0200073F RID: 1855
	[Token(Token = "0x20011C1")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158590", Offset = "0x158691")]
	private sealed class <>c__DisplayClass52_0
	{
		// Token: 0x06002F63 RID: 12131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600725D")]
		[Address(RVA = "0x2308C10", Offset = "0x2308D11", VA = "0x2308C10")]
		public <>c__DisplayClass52_0()
		{
		}

		// Token: 0x04007511 RID: 29969
		[Token(Token = "0x40195F0")]
		[FieldOffset(Offset = "0x10")]
		public LastBossController <>4__this;

		// Token: 0x04007512 RID: 29970
		[Token(Token = "0x40195F1")]
		[FieldOffset(Offset = "0x18")]
		public MonsterProjectileActionScriptsController projectileActionScriptsController;
	}

	// Token: 0x02000740 RID: 1856
	[Token(Token = "0x20011C2")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1585A0", Offset = "0x1586A1")]
	private sealed class <>c__DisplayClass52_1
	{
		// Token: 0x06002F64 RID: 12132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600725E")]
		[Address(RVA = "0x2308C20", Offset = "0x2308D21", VA = "0x2308C20")]
		public <>c__DisplayClass52_1()
		{
		}

		// Token: 0x06002F65 RID: 12133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600725F")]
		[Address(RVA = "0x230B600", Offset = "0x230B701", VA = "0x230B600")]
		internal void <CreateProjectileEvent>b__0()
		{
		}

		// Token: 0x06002F66 RID: 12134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007260")]
		[Address(RVA = "0x230B6B0", Offset = "0x230B7B1", VA = "0x230B6B0")]
		internal void <CreateProjectileEvent>b__1(Collider collider)
		{
		}

		// Token: 0x04007513 RID: 29971
		[Token(Token = "0x40195F2")]
		[FieldOffset(Offset = "0x10")]
		public LastBossBone bone;

		// Token: 0x04007514 RID: 29972
		[Token(Token = "0x40195F3")]
		[FieldOffset(Offset = "0x18")]
		public UnityEventCollider action;

		// Token: 0x04007515 RID: 29973
		[Token(Token = "0x40195F4")]
		[FieldOffset(Offset = "0x20")]
		public LastBossController.<>c__DisplayClass52_0 CS$<>8__locals1;
	}
}
