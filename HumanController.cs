using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000232 RID: 562
[Token(Token = "0x20001C4")]
[Attribute(Name = "DefaultExecutionOrder", RVA = "0x145920", Offset = "0x145A21")]
public class HumanController : Character
{
	// Token: 0x1700027F RID: 639
	// (get) Token: 0x06000CED RID: 3309 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000CEE RID: 3310 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700025F")]
	public CharacterAnimationMonitor AnimationMonitor
	{
		[Token(Token = "0x6000B8F")]
		[Address(RVA = "0x2095570", Offset = "0x2095671", VA = "0x2095570")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BBD0", Offset = "0x19BCD1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000B90")]
		[Address(RVA = "0x2095580", Offset = "0x2095681", VA = "0x2095580")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BBE0", Offset = "0x19BCE1")]
		protected set
		{
		}
	}

	// Token: 0x17000280 RID: 640
	// (get) Token: 0x06000CEF RID: 3311 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000CF0 RID: 3312 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000260")]
	public HumanEquipment Equipment
	{
		[Token(Token = "0x6000B91")]
		[Address(RVA = "0x2095590", Offset = "0x2095691", VA = "0x2095590")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BBF0", Offset = "0x19BCF1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000B92")]
		[Address(RVA = "0x20955A0", Offset = "0x20956A1", VA = "0x20955A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BC00", Offset = "0x19BD01")]
		protected set
		{
		}
	}

	// Token: 0x17000281 RID: 641
	// (get) Token: 0x06000CF1 RID: 3313 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000CF2 RID: 3314 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000261")]
	public HumanItemHold ItemHolder
	{
		[Token(Token = "0x6000B93")]
		[Address(RVA = "0x20955B0", Offset = "0x20956B1", VA = "0x20955B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BC10", Offset = "0x19BD11")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000B94")]
		[Address(RVA = "0x20955C0", Offset = "0x20956C1", VA = "0x20955C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BC20", Offset = "0x19BD21")]
		protected set
		{
		}
	}

	// Token: 0x17000282 RID: 642
	// (get) Token: 0x06000CF3 RID: 3315 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000CF4 RID: 3316 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000262")]
	public HumanLookIK LookIK
	{
		[Token(Token = "0x6000B95")]
		[Address(RVA = "0x20955D0", Offset = "0x20956D1", VA = "0x20955D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BC30", Offset = "0x19BD31")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000B96")]
		[Address(RVA = "0x20955E0", Offset = "0x20956E1", VA = "0x20955E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BC40", Offset = "0x19BD41")]
		protected set
		{
		}
	}

	// Token: 0x17000283 RID: 643
	// (get) Token: 0x06000CF5 RID: 3317 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000CF6 RID: 3318 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000263")]
	public AvoidController AvoidController
	{
		[Token(Token = "0x6000B97")]
		[Address(RVA = "0x20955F0", Offset = "0x20956F1", VA = "0x20955F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BC50", Offset = "0x19BD51")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000B98")]
		[Address(RVA = "0x2095600", Offset = "0x2095701", VA = "0x2095600")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BC60", Offset = "0x19BD61")]
		protected set
		{
		}
	}

	// Token: 0x17000284 RID: 644
	// (get) Token: 0x06000CF7 RID: 3319 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000CF8 RID: 3320 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000264")]
	public BattleModeController BattleModeController
	{
		[Token(Token = "0x6000B99")]
		[Address(RVA = "0x2095610", Offset = "0x2095711", VA = "0x2095610")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BC70", Offset = "0x19BD71")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000B9A")]
		[Address(RVA = "0x2095620", Offset = "0x2095721", VA = "0x2095620")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BC80", Offset = "0x19BD81")]
		protected set
		{
		}
	}

	// Token: 0x17000285 RID: 645
	// (get) Token: 0x06000CF9 RID: 3321 RVA: 0x000062A0 File Offset: 0x000044A0
	// (set) Token: 0x06000CFA RID: 3322 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000265")]
	public HumanMotionType MotionType
	{
		[Token(Token = "0x6000B9B")]
		[Address(RVA = "0x2095630", Offset = "0x2095731", VA = "0x2095630")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BC90", Offset = "0x19BD91")]
		get
		{
			return HumanMotionType.Common;
		}
		[Token(Token = "0x6000B9C")]
		[Address(RVA = "0x2095640", Offset = "0x2095741", VA = "0x2095640")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BCA0", Offset = "0x19BDA1")]
		private set
		{
		}
	}

	// Token: 0x17000286 RID: 646
	// (get) Token: 0x06000CFB RID: 3323 RVA: 0x000062B8 File Offset: 0x000044B8
	// (set) Token: 0x06000CFC RID: 3324 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000266")]
	private DamageResult currentDamageResult
	{
		[Token(Token = "0x6000B9D")]
		[Address(RVA = "0x2095650", Offset = "0x2095751", VA = "0x2095650")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BCB0", Offset = "0x19BDB1")]
		get
		{
			return default(DamageResult);
		}
		[Token(Token = "0x6000B9E")]
		[Address(RVA = "0x2095680", Offset = "0x2095781", VA = "0x2095680")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BCC0", Offset = "0x19BDC1")]
		set
		{
		}
	}

	// Token: 0x17000287 RID: 647
	// (get) Token: 0x06000CFD RID: 3325 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000267")]
	public HumanModel HumanModel
	{
		[Token(Token = "0x6000B9F")]
		[Address(RVA = "0x20956B0", Offset = "0x20957B1", VA = "0x20956B0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000288 RID: 648
	// (get) Token: 0x06000CFE RID: 3326 RVA: 0x000062D0 File Offset: 0x000044D0
	[Token(Token = "0x17000268")]
	protected virtual bool FadeEnable
	{
		[Token(Token = "0x6000BA0")]
		[Address(RVA = "0x2095790", Offset = "0x2095891", VA = "0x2095790", Slot = "73")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000289 RID: 649
	// (get) Token: 0x06000CFF RID: 3327 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000269")]
	public override CharacterStatusBase Status
	{
		[Token(Token = "0x6000BA1")]
		[Address(RVA = "0x20957A0", Offset = "0x20958A1", VA = "0x20957A0", Slot = "26")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700028A RID: 650
	// (get) Token: 0x06000D00 RID: 3328 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700026A")]
	public HumanStatus HumanStatus
	{
		[Token(Token = "0x6000BA2")]
		[Address(RVA = "0x20947D0", Offset = "0x20948D1", VA = "0x20947D0")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700028B RID: 651
	// (get) Token: 0x06000D01 RID: 3329 RVA: 0x000062E8 File Offset: 0x000044E8
	[Token(Token = "0x1700026B")]
	public override bool IsInvincible
	{
		[Token(Token = "0x6000BA3")]
		[Address(RVA = "0x20957B0", Offset = "0x20958B1", VA = "0x20957B0", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700028C RID: 652
	// (get) Token: 0x06000D02 RID: 3330 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700026C")]
	protected virtual HumanEquip EquipItem
	{
		[Token(Token = "0x6000BA4")]
		[Address(RVA = "0x2095870", Offset = "0x2095971", VA = "0x2095870", Slot = "74")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700028D RID: 653
	// (get) Token: 0x06000D03 RID: 3331 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700026D")]
	public ItemData CurrentWeaponData
	{
		[Token(Token = "0x6000BA5")]
		[Address(RVA = "0x2095910", Offset = "0x2095A11", VA = "0x2095910")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700028E RID: 654
	// (get) Token: 0x06000D04 RID: 3332 RVA: 0x00006300 File Offset: 0x00004500
	[Token(Token = "0x1700026E")]
	protected virtual bool EnableEquipWeaponAndTool
	{
		[Token(Token = "0x6000BA6")]
		[Address(RVA = "0x2095A20", Offset = "0x2095B21", VA = "0x2095A20", Slot = "75")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700028F RID: 655
	// (get) Token: 0x06000D05 RID: 3333 RVA: 0x00006318 File Offset: 0x00004518
	// (set) Token: 0x06000D06 RID: 3334 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700026F")]
	public bool IsWalking
	{
		[Token(Token = "0x6000BA7")]
		[Address(RVA = "0x2095A30", Offset = "0x2095B31", VA = "0x2095A30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BCD0", Offset = "0x19BDD1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000BA8")]
		[Address(RVA = "0x2095A40", Offset = "0x2095B41", VA = "0x2095A40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BCE0", Offset = "0x19BDE1")]
		set
		{
		}
	}

	// Token: 0x17000290 RID: 656
	// (get) Token: 0x06000D07 RID: 3335 RVA: 0x00006330 File Offset: 0x00004530
	[Token(Token = "0x17000270")]
	public override bool IsBattleMode
	{
		[Token(Token = "0x6000BA9")]
		[Address(RVA = "0x2095A50", Offset = "0x2095B51", VA = "0x2095A50", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000291 RID: 657
	// (get) Token: 0x06000D08 RID: 3336 RVA: 0x00006348 File Offset: 0x00004548
	[Token(Token = "0x17000271")]
	public override bool IsItemHold
	{
		[Token(Token = "0x6000BAA")]
		[Address(RVA = "0x2095AF0", Offset = "0x2095BF1", VA = "0x2095AF0", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000D09 RID: 3337 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BAB")]
	[Address(RVA = "0x2095BA0", Offset = "0x2095CA1", VA = "0x2095BA0")]
	private void InitComponent()
	{
	}

	// Token: 0x06000D0A RID: 3338 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BAC")]
	[Address(RVA = "0x2095F40", Offset = "0x2096041", VA = "0x2095F40", Slot = "11")]
	protected override void Awake()
	{
	}

	// Token: 0x06000D0B RID: 3339 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BAD")]
	[Address(RVA = "0x2095F70", Offset = "0x2096071", VA = "0x2095F70", Slot = "12")]
	protected override void Start()
	{
	}

	// Token: 0x06000D0C RID: 3340 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BAE")]
	[Address(RVA = "0x2095FE0", Offset = "0x20960E1", VA = "0x2095FE0")]
	private void CreateEffectPoint()
	{
	}

	// Token: 0x06000D0D RID: 3341 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BAF")]
	[Address(RVA = "0x2096230", Offset = "0x2096331", VA = "0x2096230", Slot = "17")]
	public override void OnSwitchActorBase(bool on)
	{
	}

	// Token: 0x06000D0E RID: 3342 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BB0")]
	[Address(RVA = "0x20975E0", Offset = "0x20976E1", VA = "0x20975E0", Slot = "44")]
	protected override void InitAnimator()
	{
	}

	// Token: 0x06000D0F RID: 3343 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BB1")]
	[Address(RVA = "0x20976B0", Offset = "0x20977B1", VA = "0x20976B0", Slot = "19")]
	protected override void OnDestroy()
	{
	}

	// Token: 0x06000D10 RID: 3344 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BB2")]
	[Address(RVA = "0x20976C0", Offset = "0x20977C1", VA = "0x20976C0", Slot = "39")]
	protected override void Update()
	{
	}

	// Token: 0x06000D11 RID: 3345 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BB3")]
	[Address(RVA = "0x2097220", Offset = "0x2097321", VA = "0x2097220")]
	public void ApplyEquipVisible()
	{
	}

	// Token: 0x06000D12 RID: 3346 RVA: 0x00006360 File Offset: 0x00004560
	[Token(Token = "0x6000BB4")]
	[Address(RVA = "0x2094DB0", Offset = "0x2094EB1", VA = "0x2094DB0")]
	public bool UpdateMotionType()
	{
		return default(bool);
	}

	// Token: 0x06000D13 RID: 3347 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BB5")]
	[Address(RVA = "0x20981B0", Offset = "0x20982B1", VA = "0x20981B0", Slot = "13")]
	public override void ResetAnimator()
	{
	}

	// Token: 0x06000D14 RID: 3348 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BB6")]
	[Address(RVA = "0x20983A0", Offset = "0x20984A1", VA = "0x20983A0", Slot = "76")]
	protected virtual void UpdateLookIK()
	{
	}

	// Token: 0x06000D15 RID: 3349 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BB7")]
	[Address(RVA = "0x2098B30", Offset = "0x2098C31", VA = "0x2098B30")]
	public void SetLeftArmIK(bool isIk)
	{
	}

	// Token: 0x06000D16 RID: 3350 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BB8")]
	[Address(RVA = "0x2098B40", Offset = "0x2098C41", VA = "0x2098B40")]
	public void SetLeftArmIKWeight(float weight)
	{
	}

	// Token: 0x06000D17 RID: 3351 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BB9")]
	[Address(RVA = "0x20977E0", Offset = "0x20978E1", VA = "0x20977E0")]
	public void UpdateArmIK()
	{
	}

	// Token: 0x06000D18 RID: 3352 RVA: 0x00006378 File Offset: 0x00004578
	[Token(Token = "0x6000BBA")]
	[Address(RVA = "0x2098B50", Offset = "0x2098C51", VA = "0x2098B50", Slot = "77")]
	protected virtual float UpdateArmIKWeight(float currentWeight, bool isArmIk)
	{
		return 0f;
	}

	// Token: 0x06000D19 RID: 3353 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BBB")]
	[Address(RVA = "0x2098C00", Offset = "0x2098D01", VA = "0x2098C00", Slot = "61")]
	public override void SetGrounderIKWeight(float weight)
	{
	}

	// Token: 0x06000D1A RID: 3354 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BBC")]
	[Address(RVA = "0x2098DF0", Offset = "0x2098EF1", VA = "0x2098DF0", Slot = "62")]
	public override void SetLookIKWeight(float weight)
	{
	}

	// Token: 0x06000D1B RID: 3355 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BBD")]
	[Address(RVA = "0x2098E90", Offset = "0x2098F91", VA = "0x2098E90", Slot = "63")]
	public override void SetNavMeshAgentEnable(bool enable)
	{
	}

	// Token: 0x06000D1C RID: 3356 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BBE")]
	[Address(RVA = "0x2098F40", Offset = "0x2099041", VA = "0x2098F40", Slot = "78")]
	public virtual void SetItemLayerWeight(float weight)
	{
	}

	// Token: 0x06000D1D RID: 3357 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BBF")]
	[Address(RVA = "0x2099000", Offset = "0x2099101", VA = "0x2099000", Slot = "79")]
	public virtual void SetConstraintWeight(ConstraintPresetID presetId)
	{
	}

	// Token: 0x06000D1E RID: 3358 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BC0")]
	[Address(RVA = "0x20991F0", Offset = "0x20992F1", VA = "0x20991F0", Slot = "80")]
	public virtual void StopAction()
	{
	}

	// Token: 0x06000D1F RID: 3359 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BC1")]
	[Address(RVA = "0x2099290", Offset = "0x2099391", VA = "0x2099290", Slot = "42")]
	public override void PlayMotion(string name, float fadeTime = 0f)
	{
	}

	// Token: 0x06000D20 RID: 3360 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BC2")]
	[Address(RVA = "0x2099320", Offset = "0x2099421", VA = "0x2099320")]
	public void PlayMotionBasic(string name, float fadeTime = 0f)
	{
	}

	// Token: 0x06000D21 RID: 3361 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BC3")]
	[Address(RVA = "0x20993A0", Offset = "0x20994A1", VA = "0x20993A0")]
	public void ShowCurrentToolEquip()
	{
	}

	// Token: 0x06000D22 RID: 3362 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BC4")]
	[Address(RVA = "0x20993D0", Offset = "0x20994D1", VA = "0x20993D0")]
	public void HideCurrentToolEquip()
	{
	}

	// Token: 0x06000D23 RID: 3363 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BC5")]
	[Address(RVA = "0x2099400", Offset = "0x2099501", VA = "0x2099400", Slot = "57")]
	public override void StartBattleMode()
	{
	}

	// Token: 0x06000D24 RID: 3364 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BC6")]
	[Address(RVA = "0x2099410", Offset = "0x2099511", VA = "0x2099410")]
	public void StartBattleMode(bool immediate)
	{
	}

	// Token: 0x06000D25 RID: 3365 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BC7")]
	[Address(RVA = "0x20995A0", Offset = "0x20996A1", VA = "0x20995A0", Slot = "58")]
	public override void EndBattleMode()
	{
	}

	// Token: 0x06000D26 RID: 3366 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BC8")]
	[Address(RVA = "0x2099620", Offset = "0x2099721", VA = "0x2099620")]
	public void EndBattleMode(bool immediate)
	{
	}

	// Token: 0x06000D27 RID: 3367 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BC9")]
	[Address(RVA = "0x20996C0", Offset = "0x20997C1", VA = "0x20996C0", Slot = "59")]
	public override void ForceEndBattleMode()
	{
	}

	// Token: 0x06000D28 RID: 3368 RVA: 0x00006390 File Offset: 0x00004590
	[Token(Token = "0x6000BCA")]
	[Address(RVA = "0x2099730", Offset = "0x2099831", VA = "0x2099730", Slot = "7")]
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult damageResult)
	{
		return default(bool);
	}

	// Token: 0x06000D29 RID: 3369 RVA: 0x000063A8 File Offset: 0x000045A8
	[Token(Token = "0x6000BCB")]
	[Address(RVA = "0x2099D80", Offset = "0x2099E81", VA = "0x2099D80", Slot = "65")]
	public override bool OnBeforeDamageAction(DamageActionType type, DamageResult damageResult)
	{
		return default(bool);
	}

	// Token: 0x06000D2A RID: 3370 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BCC")]
	[Address(RVA = "0x2099E00", Offset = "0x2099F01", VA = "0x2099E00")]
	private void PlayDamageMotion()
	{
	}

	// Token: 0x06000D2B RID: 3371 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BCD")]
	[Address(RVA = "0x2099ED0", Offset = "0x2099FD1", VA = "0x2099ED0", Slot = "66")]
	public override void OnPlayDamageAction(DamageActionType type, DamageResult damageResult)
	{
	}

	// Token: 0x06000D2C RID: 3372 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BCE")]
	[Address(RVA = "0x209AA00", Offset = "0x209AB01", VA = "0x209AA00", Slot = "68")]
	public override void OnAfterDamageAction(DamageActionType type, DamageResult damageResult)
	{
	}

	// Token: 0x06000D2D RID: 3373 RVA: 0x000063C0 File Offset: 0x000045C0
	[Token(Token = "0x6000BCF")]
	[Address(RVA = "0x209AE60", Offset = "0x209AF61", VA = "0x209AE60", Slot = "48")]
	public override bool InputMove(Vector3 vector)
	{
		return default(bool);
	}

	// Token: 0x06000D2E RID: 3374 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BD0")]
	[Address(RVA = "0x209B4E0", Offset = "0x209B5E1", VA = "0x209B4E0", Slot = "51")]
	protected override void UpdateRotate(float deltaTime)
	{
	}

	// Token: 0x06000D2F RID: 3375 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BD1")]
	[Address(RVA = "0x209BA30", Offset = "0x209BB31", VA = "0x209BA30", Slot = "50")]
	protected override void UpdateMove(float deltaTime)
	{
	}

	// Token: 0x06000D30 RID: 3376 RVA: 0x000063D8 File Offset: 0x000045D8
	[Token(Token = "0x6000BD2")]
	[Address(RVA = "0x209BA40", Offset = "0x209BB41", VA = "0x209BA40", Slot = "52")]
	protected override float GetSlowMoveScale()
	{
		return 0f;
	}

	// Token: 0x06000D31 RID: 3377 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BD3")]
	[Address(RVA = "0x209BB60", Offset = "0x209BC61", VA = "0x209BB60", Slot = "70")]
	public override void OnLanding()
	{
	}

	// Token: 0x06000D32 RID: 3378 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BD4")]
	[Address(RVA = "0x209BCF0", Offset = "0x209BDF1", VA = "0x209BCF0", Slot = "71")]
	public override void OnFalling()
	{
	}

	// Token: 0x06000D33 RID: 3379 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BD5")]
	[Address(RVA = "0x209BFA0", Offset = "0x209C0A1", VA = "0x209BFA0", Slot = "72")]
	public override void OnSliding()
	{
	}

	// Token: 0x06000D34 RID: 3380 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BD6")]
	[Address(RVA = "0x209C080", Offset = "0x209C181", VA = "0x209C080", Slot = "81")]
	public virtual void OnGroundRightFoot()
	{
	}

	// Token: 0x06000D35 RID: 3381 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BD7")]
	[Address(RVA = "0x209C090", Offset = "0x209C191", VA = "0x209C090", Slot = "82")]
	public virtual void OnGroundLeftFoot()
	{
	}

	// Token: 0x06000D36 RID: 3382 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BD8")]
	[Address(RVA = "0x209C0A0", Offset = "0x209C1A1", VA = "0x209C0A0", Slot = "83")]
	protected virtual void FallingEnemyCheck()
	{
	}

	// Token: 0x06000D37 RID: 3383 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BD9")]
	[Address(RVA = "0x209C620", Offset = "0x209C721", VA = "0x209C620", Slot = "84")]
	protected virtual void OnChangeEquip_ForNoticeStatus()
	{
	}

	// Token: 0x06000D38 RID: 3384 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BDA")]
	[Address(RVA = "0x209C650", Offset = "0x209C751", VA = "0x209C650", Slot = "64")]
	public override void OnBadStatus(BadStatus badStatus, bool isEnable)
	{
	}

	// Token: 0x06000D39 RID: 3385 RVA: 0x000063F0 File Offset: 0x000045F0
	[Token(Token = "0x6000BDB")]
	[Address(RVA = "0x209C720", Offset = "0x209C821", VA = "0x209C720")]
	public EquipSlotType CheckEquipSlot(ItemData item_data)
	{
		return EquipSlotType.RuneRX;
	}

	// Token: 0x06000D3A RID: 3386 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BDC")]
	[Address(RVA = "0x209C780", Offset = "0x209C881", VA = "0x209C780", Slot = "85")]
	public virtual void ResetEquip()
	{
	}

	// Token: 0x06000D3B RID: 3387 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BDD")]
	[Address(RVA = "0x209CC30", Offset = "0x209CD31", VA = "0x209CC30", Slot = "86")]
	public virtual void Equip(EquipSlotType slot_type)
	{
	}

	// Token: 0x06000D3C RID: 3388 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BDE")]
	[Address(RVA = "0x209CF30", Offset = "0x209D031", VA = "0x209CF30", Slot = "87")]
	public virtual ItemData UnEquip(EquipSlotType slot_type)
	{
		return null;
	}

	// Token: 0x06000D3D RID: 3389 RVA: 0x00006408 File Offset: 0x00004608
	[Token(Token = "0x6000BDF")]
	[Address(RVA = "0x209D080", Offset = "0x209D181", VA = "0x209D080", Slot = "88")]
	public virtual bool Equip(EquipSlotType slot_type, ItemData item_data)
	{
		return default(bool);
	}

	// Token: 0x06000D3E RID: 3390 RVA: 0x00006420 File Offset: 0x00004620
	[Token(Token = "0x6000BE0")]
	[Address(RVA = "0x209D2E0", Offset = "0x209D3E1", VA = "0x209D2E0", Slot = "89")]
	public virtual bool Equip(ItemData item_data)
	{
		return default(bool);
	}

	// Token: 0x06000D3F RID: 3391 RVA: 0x00006438 File Offset: 0x00004638
	[Token(Token = "0x6000BE1")]
	[Address(RVA = "0x209D380", Offset = "0x209D481", VA = "0x209D380")]
	public bool IsEquipToolCategory(ItemCategory itemCategory)
	{
		return default(bool);
	}

	// Token: 0x06000D40 RID: 3392 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BE2")]
	[Address(RVA = "0x209D490", Offset = "0x209D591", VA = "0x209D490", Slot = "90")]
	public virtual void DoEquipedTool(bool visible)
	{
	}

	// Token: 0x06000D41 RID: 3393 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BE3")]
	[Address(RVA = "0x209D550", Offset = "0x209D651", VA = "0x209D550", Slot = "91")]
	public virtual void SwitchEquipedTool(EquipSlotType slotType)
	{
	}

	// Token: 0x06000D42 RID: 3394 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BE4")]
	[Address(RVA = "0x209D640", Offset = "0x209D741", VA = "0x209D640", Slot = "92")]
	public virtual void Avoid()
	{
	}

	// Token: 0x06000D43 RID: 3395 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BE5")]
	[Address(RVA = "0x209D720", Offset = "0x209D821", VA = "0x209D720")]
	public void Attack()
	{
	}

	// Token: 0x06000D44 RID: 3396 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BE6")]
	[Address(RVA = "0x209D810", Offset = "0x209D911", VA = "0x209D810")]
	public void ChargeStart()
	{
	}

	// Token: 0x06000D45 RID: 3397 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BE7")]
	[Address(RVA = "0x209DA20", Offset = "0x209DB21", VA = "0x209DA20")]
	public void ChargeEnd()
	{
	}

	// Token: 0x06000D46 RID: 3398 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BE8")]
	[Address(RVA = "0x209DB00", Offset = "0x209DC01", VA = "0x209DB00")]
	public void RapidPickUpOnGroundItem_WithItemDataAppend(ItemData itemData)
	{
	}

	// Token: 0x06000D47 RID: 3399 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BE9")]
	[Address(RVA = "0x209DE30", Offset = "0x209DF31", VA = "0x209DE30")]
	public void PutOnGroundItem()
	{
	}

	// Token: 0x06000D48 RID: 3400 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BEA")]
	[Address(RVA = "0x209E0A0", Offset = "0x209E1A1", VA = "0x209E0A0")]
	public void ThrowItem()
	{
	}

	// Token: 0x06000D49 RID: 3401 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BEB")]
	[Address(RVA = "0x209E2D0", Offset = "0x209E3D1", VA = "0x209E2D0")]
	public void RuckInItem()
	{
	}

	// Token: 0x06000D4A RID: 3402 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BEC")]
	[Address(RVA = "0x209E5C0", Offset = "0x209E6C1", VA = "0x209E5C0")]
	public void UseItem()
	{
	}

	// Token: 0x06000D4B RID: 3403 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BED")]
	[Address(RVA = "0x209EAC0", Offset = "0x209EBC1", VA = "0x209EAC0")]
	public void RuneAbility(int index)
	{
	}

	// Token: 0x06000D4C RID: 3404 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BEE")]
	[Address(RVA = "0x209EC20", Offset = "0x209ED21", VA = "0x209EC20", Slot = "5")]
	public override void OnEnableHitSystem()
	{
	}

	// Token: 0x06000D4D RID: 3405 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BEF")]
	[Address(RVA = "0x209ECB0", Offset = "0x209EDB1", VA = "0x209ECB0", Slot = "6")]
	public override void OnHitSystemTriggerEnter(Collider collider, CharacterBase characterBase, Vector3 direction, HitOptionParamID paramID, Collider attackCollider)
	{
	}

	// Token: 0x06000D4E RID: 3406 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BF0")]
	[Address(RVA = "0x209F8E0", Offset = "0x209F9E1", VA = "0x209F8E0")]
	private void CreateDamageInfoHitSystem(out DamageInfo damageInfo, float DamageRate, float KnockBackRate, AttackAttribute attackAttribute, int BlowPower, float BlowPowerRate, float AttackPoison, float AttackParalysis, float AttackSleep, float AttackTire, float AttackSick, float AttackDeath, float AttackHpDrain, float AttackSeal)
	{
	}

	// Token: 0x06000D4F RID: 3407 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BF1")]
	[Address(RVA = "0x209FAB0", Offset = "0x209FBB1", VA = "0x209FAB0", Slot = "69")]
	public override void AddDamagedPost(DamageInfo damageInfo, DamageResult result)
	{
	}

	// Token: 0x06000D50 RID: 3408 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BF2")]
	[Address(RVA = "0x209FF70", Offset = "0x20A0071", VA = "0x209FF70", Slot = "93")]
	public virtual void AddDamagedPost(DamageInfo damageInfo, DamageResult result, ItemData itemData_)
	{
	}

	// Token: 0x06000D51 RID: 3409 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BF3")]
	[Address(RVA = "0x20A0210", Offset = "0x20A0311", VA = "0x20A0210")]
	public void LeftHandIkOff()
	{
	}

	// Token: 0x06000D52 RID: 3410 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BF4")]
	[Address(RVA = "0x20A0220", Offset = "0x20A0321", VA = "0x20A0220")]
	public void LeftHandIkOn()
	{
	}

	// Token: 0x06000D53 RID: 3411 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BF5")]
	[Address(RVA = "0x20A0230", Offset = "0x20A0331", VA = "0x20A0230")]
	public void ApproachFarm(GameObject approachTarget)
	{
	}

	// Token: 0x06000D54 RID: 3412 RVA: 0x00006450 File Offset: 0x00004650
	[Token(Token = "0x6000BF6")]
	[Address(RVA = "0x20A0760", Offset = "0x20A0861", VA = "0x20A0760", Slot = "60")]
	protected override bool CheckEnemySearchList(CharacterBase characterBase)
	{
		return default(bool);
	}

	// Token: 0x06000D55 RID: 3413 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BF7")]
	[Address(RVA = "0x20A0860", Offset = "0x20A0961", VA = "0x20A0860", Slot = "47")]
	protected override void OnWince()
	{
	}

	// Token: 0x06000D56 RID: 3414 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BF8")]
	[Address(RVA = "0x209BDA0", Offset = "0x209BEA1", VA = "0x209BDA0")]
	private void DoActCancel()
	{
	}

	// Token: 0x06000D57 RID: 3415 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BF9")]
	[Address(RVA = "0x20A0910", Offset = "0x20A0A11", VA = "0x20A0910")]
	public HumanController()
	{
	}

	// Token: 0x040007AD RID: 1965
	[Token(Token = "0x400063A")]
	[FieldOffset(Offset = "0x188")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15DDD0", Offset = "0x15DED1")]
	private CharacterAnimationMonitor <AnimationMonitor>k__BackingField;

	// Token: 0x040007AE RID: 1966
	[Token(Token = "0x400063B")]
	[FieldOffset(Offset = "0x190")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15DDE0", Offset = "0x15DEE1")]
	private HumanEquipment <Equipment>k__BackingField;

	// Token: 0x040007AF RID: 1967
	[Token(Token = "0x400063C")]
	[FieldOffset(Offset = "0x198")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15DDF0", Offset = "0x15DEF1")]
	private HumanItemHold <ItemHolder>k__BackingField;

	// Token: 0x040007B0 RID: 1968
	[Token(Token = "0x400063D")]
	[FieldOffset(Offset = "0x1A0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15DE00", Offset = "0x15DF01")]
	private HumanLookIK <LookIK>k__BackingField;

	// Token: 0x040007B1 RID: 1969
	[Token(Token = "0x400063E")]
	[FieldOffset(Offset = "0x1A8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15DE10", Offset = "0x15DF11")]
	private AvoidController <AvoidController>k__BackingField;

	// Token: 0x040007B2 RID: 1970
	[Token(Token = "0x400063F")]
	[FieldOffset(Offset = "0x1B0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15DE20", Offset = "0x15DF21")]
	private BattleModeController <BattleModeController>k__BackingField;

	// Token: 0x040007B3 RID: 1971
	[Token(Token = "0x4000640")]
	[FieldOffset(Offset = "0x1B8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15DE30", Offset = "0x15DF31")]
	private HumanMotionType <MotionType>k__BackingField;

	// Token: 0x040007B4 RID: 1972
	[Token(Token = "0x4000641")]
	[FieldOffset(Offset = "0x1C0")]
	public CharacterBase JustAvoidTarget;

	// Token: 0x040007B5 RID: 1973
	[Token(Token = "0x4000642")]
	[FieldOffset(Offset = "0x1C8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15DE40", Offset = "0x15DF41")]
	private DamageResult <currentDamageResult>k__BackingField;

	// Token: 0x040007B6 RID: 1974
	[Token(Token = "0x4000643")]
	[FieldOffset(Offset = "0x208")]
	private bool isLeftArmIK;

	// Token: 0x040007B7 RID: 1975
	[Token(Token = "0x4000644")]
	[FieldOffset(Offset = "0x20C")]
	private float weightLeftArmIK;

	// Token: 0x040007B8 RID: 1976
	[Token(Token = "0x4000645")]
	[FieldOffset(Offset = "0x210")]
	private int paramLeftArmIKWeight;

	// Token: 0x040007B9 RID: 1977
	[Token(Token = "0x4000646")]
	[FieldOffset(Offset = "0x214")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x15DE50", Offset = "0x15DF51")]
	[SerializeField]
	private float m_FarmApproachForce;

	// Token: 0x040007BA RID: 1978
	[Token(Token = "0x4000647")]
	[FieldOffset(Offset = "0x218")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x15DEA0", Offset = "0x15DFA1")]
	[SerializeField]
	private GrappleController m_GrappleController;

	// Token: 0x040007BB RID: 1979
	[Token(Token = "0x4000648")]
	[FieldOffset(Offset = "0x220")]
	private HumanController.HitSystemInfo CurrentHitSystemInfo;

	// Token: 0x040007BC RID: 1980
	[Token(Token = "0x4000649")]
	[FieldOffset(Offset = "0x228")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15DEF0", Offset = "0x15DFF1")]
	private bool <IsWalking>k__BackingField;

	// Token: 0x040007BD RID: 1981
	[Token(Token = "0x400064A")]
	[FieldOffset(Offset = "0x230")]
	private readonly string[] MotionStateName;

	// Token: 0x02000233 RID: 563
	[Token(Token = "0x2000FF7")]
	private class HitSystemInfo
	{
		// Token: 0x06000D58 RID: 3416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C49")]
		[Address(RVA = "0x20A1AE0", Offset = "0x20A1BE1", VA = "0x20A1AE0")]
		public HitSystemInfo()
		{
		}

		// Token: 0x040007BE RID: 1982
		[Token(Token = "0x4018DE6")]
		[FieldOffset(Offset = "0x10")]
		public ItemData ItemData;

		// Token: 0x040007BF RID: 1983
		[Token(Token = "0x4018DE7")]
		[FieldOffset(Offset = "0x18")]
		public EquipSlotType EquipSlotType;
	}
}
