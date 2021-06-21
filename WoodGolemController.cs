using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000771 RID: 1905
[Token(Token = "0x200051A")]
public class WoodGolemController : BossMonsterContoroller
{
	// Token: 0x0600312D RID: 12589 RVA: 0x00011208 File Offset: 0x0000F408
	[Token(Token = "0x600294D")]
	[Address(RVA = "0x1E53580", Offset = "0x1E53681", VA = "0x1E53580", Slot = "104")]
	public override bool IsCanRestraint()
	{
		return default(bool);
	}

	// Token: 0x0600312E RID: 12590 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600294E")]
	[Address(RVA = "0x1E535D0", Offset = "0x1E536D1", VA = "0x1E535D0", Slot = "12")]
	protected override void Start()
	{
	}

	// Token: 0x0600312F RID: 12591 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600294F")]
	[Address(RVA = "0x1E53680", Offset = "0x1E53781", VA = "0x1E53680", Slot = "19")]
	protected override void OnDestroy()
	{
	}

	// Token: 0x06003130 RID: 12592 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002950")]
	[Address(RVA = "0x1E53760", Offset = "0x1E53861", VA = "0x1E53760")]
	private void SetJumpPoint()
	{
	}

	// Token: 0x06003131 RID: 12593 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002951")]
	[Address(RVA = "0x1E538B0", Offset = "0x1E539B1", VA = "0x1E538B0")]
	private void EraseJumpPoint()
	{
	}

	// Token: 0x170006E5 RID: 1765
	// (get) Token: 0x06003132 RID: 12594 RVA: 0x00011220 File Offset: 0x0000F420
	// (set) Token: 0x06003133 RID: 12595 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000577")]
	public bool IsLostRightArm
	{
		[Token(Token = "0x6002952")]
		[Address(RVA = "0x1E538E0", Offset = "0x1E539E1", VA = "0x1E538E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A45F0", Offset = "0x1A46F1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002953")]
		[Address(RVA = "0x1E538F0", Offset = "0x1E539F1", VA = "0x1E538F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A4600", Offset = "0x1A4701")]
		private set
		{
		}
	}

	// Token: 0x170006E6 RID: 1766
	// (get) Token: 0x06003134 RID: 12596 RVA: 0x00011238 File Offset: 0x0000F438
	// (set) Token: 0x06003135 RID: 12597 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000578")]
	public bool IsLostBothArm
	{
		[Token(Token = "0x6002954")]
		[Address(RVA = "0x1E53900", Offset = "0x1E53A01", VA = "0x1E53900")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A4610", Offset = "0x1A4711")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002955")]
		[Address(RVA = "0x1E53910", Offset = "0x1E53A11", VA = "0x1E53910")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A4620", Offset = "0x1A4721")]
		private set
		{
		}
	}

	// Token: 0x06003136 RID: 12598 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002956")]
	[Address(RVA = "0x1E53920", Offset = "0x1E53A21", VA = "0x1E53920", Slot = "126")]
	protected override void OnSetup()
	{
	}

	// Token: 0x06003137 RID: 12599 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002957")]
	[Address(RVA = "0x1E53B10", Offset = "0x1E53C11", VA = "0x1E53B10", Slot = "128")]
	protected override void OnDeadEvent()
	{
	}

	// Token: 0x06003138 RID: 12600 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002958")]
	[Address(RVA = "0x1E53B80", Offset = "0x1E53C81", VA = "0x1E53B80", Slot = "68")]
	public override void OnAfterDamageAction(DamageActionType type, DamageResult damageResult)
	{
	}

	// Token: 0x06003139 RID: 12601 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002959")]
	[Address(RVA = "0x1E53C30", Offset = "0x1E53D31", VA = "0x1E53C30")]
	private void CreateProjectileAddList(MonsterProjectileActionScriptsController projectileActionScriptsController, int attackIndex)
	{
	}

	// Token: 0x0600313A RID: 12602 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600295A")]
	[Address(RVA = "0x1E53E80", Offset = "0x1E53F81", VA = "0x1E53E80")]
	private void GrowArm()
	{
	}

	// Token: 0x0600313B RID: 12603 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600295B")]
	[Address(RVA = "0x1E53C00", Offset = "0x1E53D01", VA = "0x1E53C00")]
	public void SwitchOn()
	{
	}

	// Token: 0x0600313C RID: 12604 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600295C")]
	[Address(RVA = "0x1E53B50", Offset = "0x1E53C51", VA = "0x1E53B50")]
	public void SwitchOff()
	{
	}

	// Token: 0x0600313D RID: 12605 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600295D")]
	[Address(RVA = "0x1E53F50", Offset = "0x1E54051", VA = "0x1E53F50", Slot = "20")]
	public override void OnEvent(int index)
	{
	}

	// Token: 0x0600313E RID: 12606 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600295E")]
	[Address(RVA = "0x1E53F90", Offset = "0x1E54091", VA = "0x1E53F90", Slot = "132")]
	public override void OnUniqueActionCommandInternal(MonsterActionCommandBase monsterActionCommandBase, ActionCommandDataTable actionCommandData)
	{
	}

	// Token: 0x0600313F RID: 12607 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600295F")]
	[Address(RVA = "0x1E543B0", Offset = "0x1E544B1", VA = "0x1E543B0")]
	public WoodGolemController()
	{
	}

	// Token: 0x06003141 RID: 12609 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002961")]
	[Address(RVA = "0x1E54450", Offset = "0x1E54551", VA = "0x1E54450")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A4630", Offset = "0x1A4731")]
	private void <Start>b__4_0(ParticleSystem particle)
	{
	}

	// Token: 0x0400761F RID: 30239
	[Token(Token = "0x4006C29")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Vector3 ATTACK_RANGE_EFFECT_SCALE;

	// Token: 0x04007620 RID: 30240
	[Token(Token = "0x4006C2A")]
	[FieldOffset(Offset = "0x508")]
	private Vector3 JumpPosition;

	// Token: 0x04007621 RID: 30241
	[Token(Token = "0x4006C2B")]
	[FieldOffset(Offset = "0x518")]
	private ParticleSystem JumpPointEffect;

	// Token: 0x04007622 RID: 30242
	[Token(Token = "0x4006C2C")]
	[FieldOffset(Offset = "0x520")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x169950", Offset = "0x169A51")]
	private bool <IsLostRightArm>k__BackingField;

	// Token: 0x04007623 RID: 30243
	[Token(Token = "0x4006C2D")]
	[FieldOffset(Offset = "0x521")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x169960", Offset = "0x169A61")]
	private bool <IsLostBothArm>k__BackingField;

	// Token: 0x04007624 RID: 30244
	[Token(Token = "0x4006C2E")]
	[FieldOffset(Offset = "0x528")]
	private GameObject ModelLeftArm;

	// Token: 0x04007625 RID: 30245
	[Token(Token = "0x4006C2F")]
	[FieldOffset(Offset = "0x530")]
	private GameObject ModelRightArm;

	// Token: 0x04007626 RID: 30246
	[Token(Token = "0x4006C30")]
	[FieldOffset(Offset = "0x538")]
	private GameObject LeftRocketPunchPrefab;

	// Token: 0x04007627 RID: 30247
	[Token(Token = "0x4006C31")]
	[FieldOffset(Offset = "0x540")]
	private GameObject RightRocketPunchPrefab;

	// Token: 0x04007628 RID: 30248
	[Token(Token = "0x4006C32")]
	[FieldOffset(Offset = "0x548")]
	private WoodGolemRocketPunchController RocketPunch;

	// Token: 0x04007629 RID: 30249
	[Token(Token = "0x4006C33")]
	private const float ROCKET_PUNCH_ROTATE_SPEED = 720f;

	// Token: 0x0400762A RID: 30250
	[Token(Token = "0x4006C34")]
	[FieldOffset(Offset = "0x550")]
	private int LaserCount;

	// Token: 0x0400762B RID: 30251
	[Token(Token = "0x4006C35")]
	[FieldOffset(Offset = "0x554")]
	private int MaxLaser;

	// Token: 0x0400762C RID: 30252
	[Token(Token = "0x4006C36")]
	[FieldOffset(Offset = "0x558")]
	private SkinnedMeshRenderer SkinnedMeshRenderer;

	// Token: 0x0400762D RID: 30253
	[Token(Token = "0x4006C37")]
	[FieldOffset(Offset = "0x560")]
	[SerializeField]
	private Material OffMaterial;

	// Token: 0x0400762E RID: 30254
	[Token(Token = "0x4006C38")]
	[FieldOffset(Offset = "0x568")]
	private Material DefaultMaterial;
}
