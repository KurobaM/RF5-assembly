using System;
using System.Collections.Generic;
using BehaviorDesigner.Runtime.Tasks;
using BossData;
using Il2CppDummyDll;

// Token: 0x020006CF RID: 1743
[Token(Token = "0x20004D7")]
public class CerberusBehaviorController : BossBehaviorController
{
	// Token: 0x170006A2 RID: 1698
	// (get) Token: 0x06002AC0 RID: 10944 RVA: 0x00010698 File Offset: 0x0000E898
	[Token(Token = "0x17000548")]
	private bool IsOpossum
	{
		[Token(Token = "0x6002403")]
		[Address(RVA = "0x1E7D980", Offset = "0x1E7DA81", VA = "0x1E7D980")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170006A3 RID: 1699
	// (get) Token: 0x06002AC1 RID: 10945 RVA: 0x000106B0 File Offset: 0x0000E8B0
	[Token(Token = "0x17000549")]
	private bool IsEndOpossumAnimation
	{
		[Token(Token = "0x6002404")]
		[Address(RVA = "0x1E7D9A0", Offset = "0x1E7DAA1", VA = "0x1E7D9A0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06002AC2 RID: 10946 RVA: 0x000106C8 File Offset: 0x0000E8C8
	[Token(Token = "0x6002405")]
	[Address(RVA = "0x1E7D9C0", Offset = "0x1E7DAC1", VA = "0x1E7D9C0")]
	private TaskStatus CheckTargetInRange_Update()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x06002AC3 RID: 10947 RVA: 0x000106E0 File Offset: 0x0000E8E0
	[Token(Token = "0x6002406")]
	[Address(RVA = "0x1E7DBE0", Offset = "0x1E7DCE1", VA = "0x1E7DBE0")]
	private TaskStatus CheckRestrain_Update()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x06002AC4 RID: 10948 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002407")]
	[Address(RVA = "0x1E7DC90", Offset = "0x1E7DD91", VA = "0x1E7DC90")]
	private MonsterBehaviorController.BehaviorActionParam CreateBiteAttackAction()
	{
		return null;
	}

	// Token: 0x06002AC5 RID: 10949 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002408")]
	[Address(RVA = "0x1E7DD90", Offset = "0x1E7DE91", VA = "0x1E7DD90")]
	private MonsterBehaviorController.BehaviorActionParam CreateStrikeAttackAction()
	{
		return null;
	}

	// Token: 0x06002AC6 RID: 10950 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002409")]
	[Address(RVA = "0x1E7DE90", Offset = "0x1E7DF91", VA = "0x1E7DE90")]
	private MonsterBehaviorController.BehaviorActionParam CreateSever11AttackAction()
	{
		return null;
	}

	// Token: 0x06002AC7 RID: 10951 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600240A")]
	[Address(RVA = "0x1E7DF90", Offset = "0x1E7E091", VA = "0x1E7DF90")]
	private MonsterBehaviorController.BehaviorActionParam CreateSever12AttackAction()
	{
		return null;
	}

	// Token: 0x06002AC8 RID: 10952 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600240B")]
	[Address(RVA = "0x1E7E090", Offset = "0x1E7E191", VA = "0x1E7E090")]
	private MonsterBehaviorController.BehaviorActionParam CreateSplitAttack()
	{
		return null;
	}

	// Token: 0x06002AC9 RID: 10953 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600240C")]
	[Address(RVA = "0x1E7E1F0", Offset = "0x1E7E2F1", VA = "0x1E7E1F0")]
	private MonsterBehaviorController.BehaviorActionParam CreateOpossumBeehavior()
	{
		return null;
	}

	// Token: 0x06002ACA RID: 10954 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600240D")]
	[Address(RVA = "0x1E7E370", Offset = "0x1E7E471", VA = "0x1E7E370")]
	private MonsterBehaviorController.BehaviorActionParam CreateDarkBallAttackAction()
	{
		return null;
	}

	// Token: 0x06002ACB RID: 10955 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600240E")]
	[Address(RVA = "0x1E7E470", Offset = "0x1E7E571", VA = "0x1E7E470")]
	private MonsterBehaviorController.BehaviorActionParam CreateMovement()
	{
		return null;
	}

	// Token: 0x06002ACC RID: 10956 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600240F")]
	[Address(RVA = "0x1E7E5C0", Offset = "0x1E7E6C1", VA = "0x1E7E5C0")]
	private MonsterBehaviorController.BehaviorActionParam CreateBackJump()
	{
		return null;
	}

	// Token: 0x06002ACD RID: 10957 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002410")]
	[Address(RVA = "0x1E7E710", Offset = "0x1E7E811", VA = "0x1E7E710", Slot = "54")]
	public override void OnHitAttack()
	{
	}

	// Token: 0x06002ACE RID: 10958 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002411")]
	[Address(RVA = "0x1E7E720", Offset = "0x1E7E821", VA = "0x1E7E720", Slot = "4")]
	protected override void Start()
	{
	}

	// Token: 0x06002ACF RID: 10959 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002412")]
	[Address(RVA = "0x1E7E7C0", Offset = "0x1E7E8C1", VA = "0x1E7E7C0", Slot = "10")]
	protected override void OnSetup()
	{
	}

	// Token: 0x06002AD0 RID: 10960 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002413")]
	[Address(RVA = "0x1E7EB30", Offset = "0x1E7EC31", VA = "0x1E7EB30", Slot = "74")]
	public override void SetupMonsterAction()
	{
	}

	// Token: 0x06002AD1 RID: 10961 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002414")]
	[Address(RVA = "0x1E7EB70", Offset = "0x1E7EC71", VA = "0x1E7EB70", Slot = "69")]
	public override void OnEndAnimEventMadnessState()
	{
	}

	// Token: 0x06002AD2 RID: 10962 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002415")]
	[Address(RVA = "0x1E7EBB0", Offset = "0x1E7ECB1", VA = "0x1E7EBB0", Slot = "82")]
	public override void SetBossDataAsset(BossDataAssetBase bossData)
	{
	}

	// Token: 0x06002AD3 RID: 10963 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002416")]
	[Address(RVA = "0x1E7EBF0", Offset = "0x1E7ECF1", VA = "0x1E7EBF0", Slot = "57")]
	public override void TakeDamage(bool isDamage, float blowDist, DamageInfo damageInfo, ref DamageResult damageResult)
	{
	}

	// Token: 0x06002AD4 RID: 10964 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002417")]
	[Address(RVA = "0x1E7EE00", Offset = "0x1E7EF01", VA = "0x1E7EE00", Slot = "92")]
	protected override void UpdateRestraintBehaviorTiming()
	{
	}

	// Token: 0x06002AD5 RID: 10965 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002418")]
	[Address(RVA = "0x1E7EE70", Offset = "0x1E7EF71", VA = "0x1E7EE70", Slot = "93")]
	protected override void UpdateReciveItemBehaviorTiming()
	{
	}

	// Token: 0x06002AD6 RID: 10966 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002419")]
	[Address(RVA = "0x1E7EFF0", Offset = "0x1E7F0F1", VA = "0x1E7EFF0", Slot = "79")]
	public override void OnRestraint()
	{
	}

	// Token: 0x06002AD7 RID: 10967 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600241A")]
	[Address(RVA = "0x1E7F020", Offset = "0x1E7F121", VA = "0x1E7F020")]
	public CerberusBehaviorController()
	{
	}

	// Token: 0x06002AD8 RID: 10968 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600241B")]
	[Address(RVA = "0x1E7F110", Offset = "0x1E7F211", VA = "0x1E7F110")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2800", Offset = "0x1A2901")]
	private void <CreateBiteAttackAction>b__22_0()
	{
	}

	// Token: 0x06002AD9 RID: 10969 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600241C")]
	[Address(RVA = "0x1E7F1A0", Offset = "0x1E7F2A1", VA = "0x1E7F1A0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2810", Offset = "0x1A2911")]
	private void <CreateStrikeAttackAction>b__23_0()
	{
	}

	// Token: 0x06002ADA RID: 10970 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600241D")]
	[Address(RVA = "0x1E7F1F0", Offset = "0x1E7F2F1", VA = "0x1E7F1F0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2820", Offset = "0x1A2921")]
	private void <CreateSever11AttackAction>b__24_0()
	{
	}

	// Token: 0x06002ADB RID: 10971 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600241E")]
	[Address(RVA = "0x1E7F280", Offset = "0x1E7F381", VA = "0x1E7F280")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2830", Offset = "0x1A2931")]
	private void <CreateSever12AttackAction>b__25_0()
	{
	}

	// Token: 0x06002ADC RID: 10972 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600241F")]
	[Address(RVA = "0x1E7F310", Offset = "0x1E7F411", VA = "0x1E7F310")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2840", Offset = "0x1A2941")]
	private void <CreateSplitAttack>b__26_0()
	{
	}

	// Token: 0x06002ADD RID: 10973 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002420")]
	[Address(RVA = "0x1E7F380", Offset = "0x1E7F481", VA = "0x1E7F380")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2850", Offset = "0x1A2951")]
	private void <CreateSplitAttack>b__26_1(int index, int type)
	{
	}

	// Token: 0x06002ADE RID: 10974 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002421")]
	[Address(RVA = "0x1E7F480", Offset = "0x1E7F581", VA = "0x1E7F480")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2860", Offset = "0x1A2961")]
	private void <CreateOpossumBeehavior>b__27_0()
	{
	}

	// Token: 0x06002ADF RID: 10975 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002422")]
	[Address(RVA = "0x1E7F510", Offset = "0x1E7F611", VA = "0x1E7F510")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2870", Offset = "0x1A2971")]
	private void <CreateOpossumBeehavior>b__27_1()
	{
	}

	// Token: 0x06002AE0 RID: 10976 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002423")]
	[Address(RVA = "0x1E7F530", Offset = "0x1E7F631", VA = "0x1E7F530")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2880", Offset = "0x1A2981")]
	private void <CreateOpossumBeehavior>b__27_2(int index, int type)
	{
	}

	// Token: 0x06002AE1 RID: 10977 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002424")]
	[Address(RVA = "0x1E7F550", Offset = "0x1E7F651", VA = "0x1E7F550")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2890", Offset = "0x1A2991")]
	private void <CreateDarkBallAttackAction>b__28_0()
	{
	}

	// Token: 0x06002AE2 RID: 10978 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002425")]
	[Address(RVA = "0x1E7F5A0", Offset = "0x1E7F6A1", VA = "0x1E7F5A0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A28A0", Offset = "0x1A29A1")]
	private void <CreateMovement>b__29_0()
	{
	}

	// Token: 0x06002AE3 RID: 10979 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002426")]
	[Address(RVA = "0x1E7F610", Offset = "0x1E7F711", VA = "0x1E7F610")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A28B0", Offset = "0x1A29B1")]
	private void <CreateMovement>b__29_1(int index, int type)
	{
	}

	// Token: 0x06002AE4 RID: 10980 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002427")]
	[Address(RVA = "0x1E7F690", Offset = "0x1E7F791", VA = "0x1E7F690")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A28C0", Offset = "0x1A29C1")]
	private void <CreateBackJump>b__30_0()
	{
	}

	// Token: 0x06002AE5 RID: 10981 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002428")]
	[Address(RVA = "0x1E7F700", Offset = "0x1E7F801", VA = "0x1E7F700")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A28D0", Offset = "0x1A29D1")]
	private void <CreateBackJump>b__30_1(int index, int type)
	{
	}

	// Token: 0x04007273 RID: 29299
	[Token(Token = "0x4006A07")]
	private const float OpossumHPPercent = 20f;

	// Token: 0x04007274 RID: 29300
	[Token(Token = "0x4006A08")]
	[FieldOffset(Offset = "0x1C0")]
	private float CheckTargetRangeValue;

	// Token: 0x04007275 RID: 29301
	[Token(Token = "0x4006A09")]
	[FieldOffset(Offset = "0x1C4")]
	private bool IsInRange;

	// Token: 0x04007276 RID: 29302
	[Token(Token = "0x4006A0A")]
	[FieldOffset(Offset = "0x1C8")]
	private List<MonsterActionBehaviorType> TargetInRangeBehaviorList;

	// Token: 0x04007277 RID: 29303
	[Token(Token = "0x4006A0B")]
	[FieldOffset(Offset = "0x1D0")]
	private List<MonsterActionBehaviorType> TargetOutRangeBehaviorList;

	// Token: 0x04007278 RID: 29304
	[Token(Token = "0x4006A0C")]
	[FieldOffset(Offset = "0x1D8")]
	private List<MonsterActionBehaviorType> RestrainBehaviorList;

	// Token: 0x04007279 RID: 29305
	[Token(Token = "0x4006A0D")]
	[FieldOffset(Offset = "0x1E0")]
	private List<MonsterActionBehaviorType> NotRestrainBehaviorList;

	// Token: 0x0400727A RID: 29306
	[Token(Token = "0x4006A0E")]
	[FieldOffset(Offset = "0x1E8")]
	private CerberusController controller;

	// Token: 0x0400727B RID: 29307
	[Token(Token = "0x4006A0F")]
	[FieldOffset(Offset = "0x1F0")]
	private bool IsRestrain;

	// Token: 0x0400727C RID: 29308
	[Token(Token = "0x4006A10")]
	[FieldOffset(Offset = "0x1F1")]
	private bool OpossumBefor;

	// Token: 0x0400727D RID: 29309
	[Token(Token = "0x4006A11")]
	[FieldOffset(Offset = "0x1F2")]
	private bool IsGetUp;

	// Token: 0x020006D0 RID: 1744
	[Token(Token = "0x2001180")]
	public enum CeruberusAction
	{
		// Token: 0x0400727F RID: 29311
		[Token(Token = "0x40194DB")]
		Opossum = 23
	}

	// Token: 0x020006D1 RID: 1745
	[Token(Token = "0x2001181")]
	private enum CerberusActionScriptNo
	{
		// Token: 0x04007281 RID: 29313
		[Token(Token = "0x40194DD")]
		Vigilance = 101,
		// Token: 0x04007282 RID: 29314
		[Token(Token = "0x40194DE")]
		Eat
	}

	// Token: 0x020006D2 RID: 1746
	[Token(Token = "0x2001182")]
	private enum StateType
	{
		// Token: 0x04007284 RID: 29316
		[Token(Token = "0x40194E0")]
		Default,
		// Token: 0x04007285 RID: 29317
		[Token(Token = "0x40194E1")]
		Madness,
		// Token: 0x04007286 RID: 29318
		[Token(Token = "0x40194E2")]
		Opossum
	}

	// Token: 0x020006D3 RID: 1747
	[Token(Token = "0x2001183")]
	private enum FunctionStateType
	{
		// Token: 0x04007288 RID: 29320
		[Token(Token = "0x40194E4")]
		CheckTargetInRange,
		// Token: 0x04007289 RID: 29321
		[Token(Token = "0x40194E5")]
		CheckRestrain
	}

	// Token: 0x020006D4 RID: 1748
	[Token(Token = "0x2001184")]
	private enum CreateDogsState
	{
		// Token: 0x0400728B RID: 29323
		[Token(Token = "0x40194E7")]
		None,
		// Token: 0x0400728C RID: 29324
		[Token(Token = "0x40194E8")]
		Creating,
		// Token: 0x0400728D RID: 29325
		[Token(Token = "0x40194E9")]
		Created
	}
}
