using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020006EB RID: 1771
[Token(Token = "0x20004E3")]
public class GandageController : BossMonsterContoroller
{
	// Token: 0x170006AA RID: 1706
	// (get) Token: 0x06002BEE RID: 11246 RVA: 0x00010890 File Offset: 0x0000EA90
	// (set) Token: 0x06002BEF RID: 11247 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000550")]
	public bool CanRestraint
	{
		[Token(Token = "0x6002518")]
		[Address(RVA = "0x1F92F50", Offset = "0x1F93051", VA = "0x1F92F50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2D40", Offset = "0x1A2E41")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002519")]
		[Address(RVA = "0x1F92F60", Offset = "0x1F93061", VA = "0x1F92F60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2D50", Offset = "0x1A2E51")]
		private set
		{
		}
	}

	// Token: 0x06002BF0 RID: 11248 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600251A")]
	[Address(RVA = "0x1F92F70", Offset = "0x1F93071", VA = "0x1F92F70")]
	private Vector3[] GetWaypointStartFlyswatter()
	{
		return null;
	}

	// Token: 0x06002BF1 RID: 11249 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600251B")]
	[Address(RVA = "0x1F930E0", Offset = "0x1F931E1", VA = "0x1F930E0")]
	private Vector3[] GetWaypointAttackFlyswatter()
	{
		return null;
	}

	// Token: 0x06002BF2 RID: 11250 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600251C")]
	[Address(RVA = "0x1F93250", Offset = "0x1F93351", VA = "0x1F93250")]
	private Vector3[] GetWaypointStartUpperDown()
	{
		return null;
	}

	// Token: 0x06002BF3 RID: 11251 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600251D")]
	[Address(RVA = "0x1F933C0", Offset = "0x1F934C1", VA = "0x1F933C0")]
	private Vector3[] GetWaypointAttackUpperDown()
	{
		return null;
	}

	// Token: 0x06002BF4 RID: 11252 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600251E")]
	[Address(RVA = "0x1F93670", Offset = "0x1F93771", VA = "0x1F93670")]
	private Vector3[] GetWaypointBeatup_R1()
	{
		return null;
	}

	// Token: 0x06002BF5 RID: 11253 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600251F")]
	[Address(RVA = "0x1F93800", Offset = "0x1F93901", VA = "0x1F93800")]
	private Vector3[] GetWaypointBeatup_R2()
	{
		return null;
	}

	// Token: 0x06002BF6 RID: 11254 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002520")]
	[Address(RVA = "0x1F93990", Offset = "0x1F93A91", VA = "0x1F93990")]
	private Vector3[] GetWaypointBeatup_L1()
	{
		return null;
	}

	// Token: 0x06002BF7 RID: 11255 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002521")]
	[Address(RVA = "0x1F93B10", Offset = "0x1F93C11", VA = "0x1F93B10")]
	private Vector3[] GetWaypointBeatup_L2()
	{
		return null;
	}

	// Token: 0x06002BF8 RID: 11256 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002522")]
	[Address(RVA = "0x1F93CA0", Offset = "0x1F93DA1", VA = "0x1F93CA0")]
	private void ResetCrackAreaFlag()
	{
	}

	// Token: 0x06002BF9 RID: 11257 RVA: 0x000108A8 File Offset: 0x0000EAA8
	[Token(Token = "0x6002523")]
	[Address(RVA = "0x1F93D10", Offset = "0x1F93E11", VA = "0x1F93D10")]
	private GandageController.CrackArea SelectCrackArea()
	{
		return GandageController.CrackArea.Left;
	}

	// Token: 0x06002BFA RID: 11258 RVA: 0x000108C0 File Offset: 0x0000EAC0
	[Token(Token = "0x6002524")]
	[Address(RVA = "0x1F93F00", Offset = "0x1F94001", VA = "0x1F93F00")]
	private float GetDurationTargetPosition(Vector3 targetPosition, float speed)
	{
		return 0f;
	}

	// Token: 0x06002BFB RID: 11259 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002525")]
	[Address(RVA = "0x1F94010", Offset = "0x1F94111", VA = "0x1F94010")]
	private void PlayJumpTween(float jumpHeight, float duration)
	{
	}

	// Token: 0x06002BFC RID: 11260 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002526")]
	[Address(RVA = "0x1F94180", Offset = "0x1F94281", VA = "0x1F94180")]
	private void PlayMoveTargetTween(float speed)
	{
	}

	// Token: 0x06002BFD RID: 11261 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002527")]
	[Address(RVA = "0x1F94470", Offset = "0x1F94571", VA = "0x1F94470")]
	public void ChangeRuntimeAnimator(bool isMadness)
	{
	}

	// Token: 0x06002BFE RID: 11262 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002528")]
	[Address(RVA = "0x1F944D0", Offset = "0x1F945D1", VA = "0x1F944D0")]
	public void SetBossStage(DN17BossStageInterface bossStage)
	{
	}

	// Token: 0x06002BFF RID: 11263 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002529")]
	[Address(RVA = "0x1F944E0", Offset = "0x1F945E1", VA = "0x1F944E0", Slot = "126")]
	protected override void OnSetup()
	{
	}

	// Token: 0x06002C00 RID: 11264 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600252A")]
	[Address(RVA = "0x1F94570", Offset = "0x1F94671", VA = "0x1F94570", Slot = "136")]
	protected override void OnHit(CharacterBase characterBase, int actionIndex)
	{
	}

	// Token: 0x06002C01 RID: 11265 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600252B")]
	[Address(RVA = "0x1F945E0", Offset = "0x1F946E1", VA = "0x1F945E0", Slot = "132")]
	public override void OnUniqueActionCommandInternal(MonsterActionCommandBase monsterActionCommandBase, ActionCommandDataTable actionCommandData)
	{
	}

	// Token: 0x06002C02 RID: 11266 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600252C")]
	[Address(RVA = "0x1F95D20", Offset = "0x1F95E21", VA = "0x1F95D20", Slot = "116")]
	protected override void OnResetActionScriptAction()
	{
	}

	// Token: 0x06002C03 RID: 11267 RVA: 0x000108D8 File Offset: 0x0000EAD8
	[Token(Token = "0x600252D")]
	[Address(RVA = "0x1F95D50", Offset = "0x1F95E51", VA = "0x1F95D50", Slot = "7")]
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult damageResult)
	{
		return default(bool);
	}

	// Token: 0x06002C04 RID: 11268 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600252E")]
	[Address(RVA = "0x1F95E10", Offset = "0x1F95F11", VA = "0x1F95E10")]
	public GandageController()
	{
	}

	// Token: 0x06002C05 RID: 11269 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600252F")]
	[Address(RVA = "0x1F96250", Offset = "0x1F96351", VA = "0x1F96250")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2D60", Offset = "0x1A2E61")]
	private void <PlayMoveTargetTween>b__48_0()
	{
	}

	// Token: 0x06002C06 RID: 11270 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002530")]
	[Address(RVA = "0x1F96290", Offset = "0x1F96391", VA = "0x1F96290")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2D70", Offset = "0x1A2E71")]
	private void <OnUniqueActionCommandInternal>b__53_0()
	{
	}

	// Token: 0x06002C07 RID: 11271 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002531")]
	[Address(RVA = "0x1F96420", Offset = "0x1F96521", VA = "0x1F96420")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2D80", Offset = "0x1A2E81")]
	private void <OnUniqueActionCommandInternal>b__53_1()
	{
	}

	// Token: 0x06002C08 RID: 11272 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002532")]
	[Address(RVA = "0x1F96510", Offset = "0x1F96611", VA = "0x1F96510")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2D90", Offset = "0x1A2E91")]
	private void <OnUniqueActionCommandInternal>b__53_2()
	{
	}

	// Token: 0x06002C09 RID: 11273 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002533")]
	[Address(RVA = "0x1F965D0", Offset = "0x1F966D1", VA = "0x1F965D0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2DA0", Offset = "0x1A2EA1")]
	private void <OnUniqueActionCommandInternal>b__53_3()
	{
	}

	// Token: 0x06002C0A RID: 11274 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002534")]
	[Address(RVA = "0x1F96690", Offset = "0x1F96791", VA = "0x1F96690")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2DB0", Offset = "0x1A2EB1")]
	private void <OnUniqueActionCommandInternal>b__53_4()
	{
	}

	// Token: 0x06002C0B RID: 11275 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002535")]
	[Address(RVA = "0x1F96730", Offset = "0x1F96831", VA = "0x1F96730")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2DC0", Offset = "0x1A2EC1")]
	private void <OnUniqueActionCommandInternal>b__53_5()
	{
	}

	// Token: 0x06002C0C RID: 11276 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002536")]
	[Address(RVA = "0x1F967D0", Offset = "0x1F968D1", VA = "0x1F967D0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2DD0", Offset = "0x1A2ED1")]
	private void <OnUniqueActionCommandInternal>b__53_6()
	{
	}

	// Token: 0x06002C0D RID: 11277 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002537")]
	[Address(RVA = "0x1F96880", Offset = "0x1F96981", VA = "0x1F96880")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2DE0", Offset = "0x1A2EE1")]
	private void <OnUniqueActionCommandInternal>b__53_7()
	{
	}

	// Token: 0x06002C0E RID: 11278 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002538")]
	[Address(RVA = "0x1F968C0", Offset = "0x1F969C1", VA = "0x1F968C0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2DF0", Offset = "0x1A2EF1")]
	private void <OnUniqueActionCommandInternal>b__53_8()
	{
	}

	// Token: 0x06002C0F RID: 11279 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002539")]
	[Address(RVA = "0x1F96900", Offset = "0x1F96A01", VA = "0x1F96900")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2E00", Offset = "0x1A2F01")]
	private void <OnUniqueActionCommandInternal>b__53_9()
	{
	}

	// Token: 0x06002C10 RID: 11280 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600253A")]
	[Address(RVA = "0x1F96940", Offset = "0x1F96A41", VA = "0x1F96940")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2E10", Offset = "0x1A2F11")]
	private void <OnUniqueActionCommandInternal>b__53_10()
	{
	}

	// Token: 0x06002C11 RID: 11281 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600253B")]
	[Address(RVA = "0x1F96970", Offset = "0x1F96A71", VA = "0x1F96970")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2E20", Offset = "0x1A2F21")]
	private void <OnUniqueActionCommandInternal>b__53_11()
	{
	}

	// Token: 0x06002C12 RID: 11282 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600253C")]
	[Address(RVA = "0x1F969A0", Offset = "0x1F96AA1", VA = "0x1F969A0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2E30", Offset = "0x1A2F31")]
	private void <OnUniqueActionCommandInternal>b__53_12()
	{
	}

	// Token: 0x04007301 RID: 29441
	[Token(Token = "0x4006A5B")]
	private const float TakeBehindRange = 2f;

	// Token: 0x04007302 RID: 29442
	[Token(Token = "0x4006A5C")]
	private const float EscapeRange = 5f;

	// Token: 0x04007303 RID: 29443
	[Token(Token = "0x4006A5D")]
	private const string MADNESS_ADV_SCRIPT_NAME = "boss_gandage_002";

	// Token: 0x04007304 RID: 29444
	[Token(Token = "0x4006A5E")]
	[FieldOffset(Offset = "0x508")]
	private Transform WeaponTransform;

	// Token: 0x04007305 RID: 29445
	[Token(Token = "0x4006A5F")]
	[FieldOffset(Offset = "0x510")]
	[SerializeField]
	private GandageHandController R_OpenHandController;

	// Token: 0x04007306 RID: 29446
	[Token(Token = "0x4006A60")]
	[FieldOffset(Offset = "0x518")]
	[SerializeField]
	private GandageHandController L_OpenHandController;

	// Token: 0x04007307 RID: 29447
	[Token(Token = "0x4006A61")]
	[FieldOffset(Offset = "0x520")]
	[SerializeField]
	private GandageHandController R_FistController;

	// Token: 0x04007308 RID: 29448
	[Token(Token = "0x4006A62")]
	[FieldOffset(Offset = "0x528")]
	[SerializeField]
	private GandageHandController L_FistController;

	// Token: 0x04007309 RID: 29449
	[Token(Token = "0x4006A63")]
	[FieldOffset(Offset = "0x530")]
	[SerializeField]
	private RuntimeAnimatorController AnimatorController;

	// Token: 0x0400730A RID: 29450
	[Token(Token = "0x4006A64")]
	[FieldOffset(Offset = "0x538")]
	[SerializeField]
	private RuntimeAnimatorController MadnessAnimatorController;

	// Token: 0x0400730B RID: 29451
	[Token(Token = "0x4006A65")]
	[FieldOffset(Offset = "0x540")]
	private DN17BossStageInterface BossStage;

	// Token: 0x0400730C RID: 29452
	[Token(Token = "0x4006A66")]
	[FieldOffset(Offset = "0x548")]
	private bool IsHitAttack;

	// Token: 0x0400730D RID: 29453
	[Token(Token = "0x4006A67")]
	[FieldOffset(Offset = "0x549")]
	private bool CheckHitAttackNext;

	// Token: 0x0400730E RID: 29454
	[Token(Token = "0x4006A68")]
	[FieldOffset(Offset = "0x550")]
	private bool[] SelectCrackAreaArray;

	// Token: 0x0400730F RID: 29455
	[Token(Token = "0x4006A69")]
	[FieldOffset(Offset = "0x558")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1696A0", Offset = "0x1697A1")]
	private bool <CanRestraint>k__BackingField;

	// Token: 0x04007310 RID: 29456
	[Token(Token = "0x4006A6A")]
	[FieldOffset(Offset = "0x55C")]
	private readonly Vector3 FlyswatterStartPosition;

	// Token: 0x04007311 RID: 29457
	[Token(Token = "0x4006A6B")]
	[FieldOffset(Offset = "0x568")]
	private readonly Vector3 FlyswatterWaitPosition;

	// Token: 0x04007312 RID: 29458
	[Token(Token = "0x4006A6C")]
	[FieldOffset(Offset = "0x574")]
	private readonly Vector3 FlyswatterAttackPosition;

	// Token: 0x04007313 RID: 29459
	[Token(Token = "0x4006A6D")]
	[FieldOffset(Offset = "0x580")]
	private readonly Vector3 UpperDownStartPosition;

	// Token: 0x04007314 RID: 29460
	[Token(Token = "0x4006A6E")]
	[FieldOffset(Offset = "0x58C")]
	private readonly Vector3 UpperDownWaitPosition;

	// Token: 0x04007315 RID: 29461
	[Token(Token = "0x4006A6F")]
	[FieldOffset(Offset = "0x598")]
	private readonly Vector3 UpperDownAttack01Position;

	// Token: 0x04007316 RID: 29462
	[Token(Token = "0x4006A70")]
	[FieldOffset(Offset = "0x5A4")]
	private readonly Vector3 UpperDownAttack02Position;

	// Token: 0x04007317 RID: 29463
	[Token(Token = "0x4006A71")]
	[FieldOffset(Offset = "0x5B0")]
	private readonly Vector3 Beatup_R1_StartPosition;

	// Token: 0x04007318 RID: 29464
	[Token(Token = "0x4006A72")]
	[FieldOffset(Offset = "0x5BC")]
	private readonly Vector3 Beatup_R1_EndPosition;

	// Token: 0x04007319 RID: 29465
	[Token(Token = "0x4006A73")]
	[FieldOffset(Offset = "0x5C8")]
	private readonly Vector3 Beatup_R2_StartPosition;

	// Token: 0x0400731A RID: 29466
	[Token(Token = "0x4006A74")]
	[FieldOffset(Offset = "0x5D4")]
	private readonly Vector3 Beatup_R2_EndPosition;

	// Token: 0x0400731B RID: 29467
	[Token(Token = "0x4006A75")]
	[FieldOffset(Offset = "0x5E0")]
	private readonly Vector3 Beatup_L1_StartPosition;

	// Token: 0x0400731C RID: 29468
	[Token(Token = "0x4006A76")]
	[FieldOffset(Offset = "0x5EC")]
	private readonly Vector3 Beatup_L1_EndPosition;

	// Token: 0x0400731D RID: 29469
	[Token(Token = "0x4006A77")]
	[FieldOffset(Offset = "0x5F8")]
	private readonly Vector3 Beatup_L2_StartPosition;

	// Token: 0x0400731E RID: 29470
	[Token(Token = "0x4006A78")]
	[FieldOffset(Offset = "0x604")]
	private readonly Vector3 Beatup_L2_EndPosition;

	// Token: 0x0400731F RID: 29471
	[Token(Token = "0x4006A79")]
	[FieldOffset(Offset = "0x610")]
	private Tweener JumpAttack;

	// Token: 0x04007320 RID: 29472
	[Token(Token = "0x4006A7A")]
	[FieldOffset(Offset = "0x618")]
	private Vector3 GroundPosition;

	// Token: 0x020006EC RID: 1772
	[Token(Token = "0x2001190")]
	private enum CrackArea
	{
		// Token: 0x04007322 RID: 29474
		[Token(Token = "0x4019515")]
		Left,
		// Token: 0x04007323 RID: 29475
		[Token(Token = "0x4019516")]
		Right,
		// Token: 0x04007324 RID: 29476
		[Token(Token = "0x4019517")]
		Up,
		// Token: 0x04007325 RID: 29477
		[Token(Token = "0x4019518")]
		eCount,
		// Token: 0x04007326 RID: 29478
		[Token(Token = "0x4019519")]
		None
	}
}
