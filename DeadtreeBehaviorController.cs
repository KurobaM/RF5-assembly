using System;
using BehaviorDesigner.Runtime.Tasks;
using BossData;
using Il2CppDummyDll;

// Token: 0x020006DB RID: 1755
[Token(Token = "0x20004DA")]
public class DeadtreeBehaviorController : BossBehaviorController
{
	// Token: 0x170006A4 RID: 1700
	// (get) Token: 0x06002B0C RID: 11020 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700054A")]
	private DeadtreeController DeadTreeController
	{
		[Token(Token = "0x6002442")]
		[Address(RVA = "0x1DA9FE0", Offset = "0x1DAA0E1", VA = "0x1DA9FE0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06002B0D RID: 11021 RVA: 0x00010788 File Offset: 0x0000E988
	[Token(Token = "0x6002443")]
	[Address(RVA = "0x1DAA0C0", Offset = "0x1DAA1C1", VA = "0x1DAA0C0")]
	private TaskStatus Stripping_Update()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x06002B0E RID: 11022 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002444")]
	[Address(RVA = "0x1DAA160", Offset = "0x1DAA261", VA = "0x1DAA160")]
	private void RespawnBurr_End()
	{
	}

	// Token: 0x06002B0F RID: 11023 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002445")]
	[Address(RVA = "0x1DAA280", Offset = "0x1DAA381", VA = "0x1DAA280")]
	public void LotteryHeal(int heal)
	{
	}

	// Token: 0x06002B10 RID: 11024 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002446")]
	[Address(RVA = "0x1DAA360", Offset = "0x1DAA461", VA = "0x1DAA360")]
	private MonsterBehaviorController.BehaviorActionParam CreateAroundMoveAction()
	{
		return null;
	}

	// Token: 0x06002B11 RID: 11025 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002447")]
	[Address(RVA = "0x1DAA490", Offset = "0x1DAA591", VA = "0x1DAA490")]
	private MonsterBehaviorController.BehaviorActionParam CreateLeaveMoveAction()
	{
		return null;
	}

	// Token: 0x06002B12 RID: 11026 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002448")]
	[Address(RVA = "0x1DAA5C0", Offset = "0x1DAA6C1", VA = "0x1DAA5C0")]
	private MonsterBehaviorController.BehaviorActionParam CreateWaitAction()
	{
		return null;
	}

	// Token: 0x06002B13 RID: 11027 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002449")]
	[Address(RVA = "0x1DAA6F0", Offset = "0x1DAA7F1", VA = "0x1DAA6F0")]
	private MonsterBehaviorController.BehaviorActionParam CreateStrippingAttackAction()
	{
		return null;
	}

	// Token: 0x06002B14 RID: 11028 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600244A")]
	[Address(RVA = "0x1DAA820", Offset = "0x1DAA921", VA = "0x1DAA820")]
	private MonsterBehaviorController.BehaviorActionParam CreateBurrBarrierAction()
	{
		return null;
	}

	// Token: 0x06002B15 RID: 11029 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600244B")]
	[Address(RVA = "0x1DAA920", Offset = "0x1DAAA21", VA = "0x1DAA920")]
	private MonsterBehaviorController.BehaviorActionParam CreateBurrBombAction()
	{
		return null;
	}

	// Token: 0x06002B16 RID: 11030 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600244C")]
	[Address(RVA = "0x1DAAA20", Offset = "0x1DAAB21", VA = "0x1DAAA20")]
	private MonsterBehaviorController.BehaviorActionParam CreateNoiseofTreeAttackAction()
	{
		return null;
	}

	// Token: 0x06002B17 RID: 11031 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600244D")]
	[Address(RVA = "0x1DAAB40", Offset = "0x1DAAC41", VA = "0x1DAAB40")]
	private MonsterBehaviorController.BehaviorActionParam CreateCureAction()
	{
		return null;
	}

	// Token: 0x06002B18 RID: 11032 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600244E")]
	[Address(RVA = "0x1DAACC0", Offset = "0x1DAADC1", VA = "0x1DAACC0")]
	private MonsterBehaviorController.BehaviorActionParam CreateLeaveRespawnBurrAction()
	{
		return null;
	}

	// Token: 0x06002B19 RID: 11033 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600244F")]
	[Address(RVA = "0x1DAADC0", Offset = "0x1DAAEC1", VA = "0x1DAADC0", Slot = "10")]
	protected override void OnSetup()
	{
	}

	// Token: 0x06002B1A RID: 11034 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002450")]
	[Address(RVA = "0x1DAAFE0", Offset = "0x1DAB0E1", VA = "0x1DAAFE0", Slot = "82")]
	public override void SetBossDataAsset(BossDataAssetBase bossData)
	{
	}

	// Token: 0x06002B1B RID: 11035 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002451")]
	[Address(RVA = "0x1DAB020", Offset = "0x1DAB121", VA = "0x1DAB020", Slot = "88")]
	public override void OnUpdateBossDataBitArray()
	{
	}

	// Token: 0x06002B1C RID: 11036 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002452")]
	[Address(RVA = "0x1DAB0D0", Offset = "0x1DAB1D1", VA = "0x1DAB0D0", Slot = "69")]
	public override void OnEndAnimEventMadnessState()
	{
	}

	// Token: 0x06002B1D RID: 11037 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002453")]
	[Address(RVA = "0x1DAB130", Offset = "0x1DAB231", VA = "0x1DAB130", Slot = "9")]
	protected override void Update()
	{
	}

	// Token: 0x06002B1E RID: 11038 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002454")]
	[Address(RVA = "0x1DAB520", Offset = "0x1DAB621", VA = "0x1DAB520", Slot = "93")]
	protected override void UpdateReciveItemBehaviorTiming()
	{
	}

	// Token: 0x06002B1F RID: 11039 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002455")]
	[Address(RVA = "0x1DAB5A0", Offset = "0x1DAB6A1", VA = "0x1DAB5A0")]
	public DeadtreeBehaviorController()
	{
	}

	// Token: 0x06002B20 RID: 11040 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002456")]
	[Address(RVA = "0x1DAB5B0", Offset = "0x1DAB6B1", VA = "0x1DAB5B0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2920", Offset = "0x1A2A21")]
	private void <CreateAroundMoveAction>b__15_0()
	{
	}

	// Token: 0x06002B21 RID: 11041 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002457")]
	[Address(RVA = "0x1DAB610", Offset = "0x1DAB711", VA = "0x1DAB610")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2930", Offset = "0x1A2A31")]
	private void <CreateAroundMoveAction>b__15_1(int index, int type)
	{
	}

	// Token: 0x06002B22 RID: 11042 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002458")]
	[Address(RVA = "0x1DAB800", Offset = "0x1DAB901", VA = "0x1DAB800")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2940", Offset = "0x1A2A41")]
	private void <CreateLeaveMoveAction>b__16_0()
	{
	}

	// Token: 0x06002B23 RID: 11043 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002459")]
	[Address(RVA = "0x1DAB860", Offset = "0x1DAB961", VA = "0x1DAB860")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2950", Offset = "0x1A2A51")]
	private void <CreateLeaveMoveAction>b__16_1(int index, int type)
	{
	}

	// Token: 0x06002B24 RID: 11044 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600245A")]
	[Address(RVA = "0x1DABA80", Offset = "0x1DABB81", VA = "0x1DABA80")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2960", Offset = "0x1A2A61")]
	private void <CreateWaitAction>b__17_0()
	{
	}

	// Token: 0x06002B25 RID: 11045 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600245B")]
	[Address(RVA = "0x1DABAE0", Offset = "0x1DABBE1", VA = "0x1DABAE0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2970", Offset = "0x1A2A71")]
	private void <CreateWaitAction>b__17_1(int index, int type)
	{
	}

	// Token: 0x06002B26 RID: 11046 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600245C")]
	[Address(RVA = "0x1DABD30", Offset = "0x1DABE31", VA = "0x1DABD30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2980", Offset = "0x1A2A81")]
	private void <CreateStrippingAttackAction>b__18_0()
	{
	}

	// Token: 0x06002B27 RID: 11047 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600245D")]
	[Address(RVA = "0x1DABDA0", Offset = "0x1DABEA1", VA = "0x1DABDA0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2990", Offset = "0x1A2A91")]
	private void <CreateBurrBarrierAction>b__19_0()
	{
	}

	// Token: 0x06002B28 RID: 11048 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600245E")]
	[Address(RVA = "0x1DABDF0", Offset = "0x1DABEF1", VA = "0x1DABDF0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A29A0", Offset = "0x1A2AA1")]
	private void <CreateBurrBombAction>b__20_0()
	{
	}

	// Token: 0x06002B29 RID: 11049 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600245F")]
	[Address(RVA = "0x1DABE60", Offset = "0x1DABF61", VA = "0x1DABE60")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A29B0", Offset = "0x1A2AB1")]
	private void <CreateNoiseofTreeAttackAction>b__21_0()
	{
	}

	// Token: 0x06002B2A RID: 11050 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002460")]
	[Address(RVA = "0x1DABEB0", Offset = "0x1DABFB1", VA = "0x1DABEB0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A29C0", Offset = "0x1A2AC1")]
	private void <CreateCureAction>b__22_0()
	{
	}

	// Token: 0x06002B2B RID: 11051 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002461")]
	[Address(RVA = "0x1DABF00", Offset = "0x1DAC001", VA = "0x1DABF00")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A29D0", Offset = "0x1A2AD1")]
	private void <CreateLeaveRespawnBurrAction>b__23_0()
	{
	}

	// Token: 0x040072AB RID: 29355
	[Token(Token = "0x4006A1E")]
	private const float HoldMushroomTime = 0.66f;

	// Token: 0x040072AC RID: 29356
	[Token(Token = "0x4006A1F")]
	private const float ReleseMushroomTime = 2.66f;

	// Token: 0x040072AD RID: 29357
	[Token(Token = "0x4006A20")]
	private const string BoneName = "MashRoomPos";

	// Token: 0x040072AE RID: 29358
	[Token(Token = "0x4006A21")]
	[FieldOffset(Offset = "0x1C0")]
	private DeadtreeController _DeadTreeController;

	// Token: 0x040072AF RID: 29359
	[Token(Token = "0x4006A22")]
	[FieldOffset(Offset = "0x1C8")]
	private bool IsDamage;

	// Token: 0x040072B0 RID: 29360
	[Token(Token = "0x4006A23")]
	[FieldOffset(Offset = "0x1C9")]
	private bool IsExistBurr;

	// Token: 0x040072B1 RID: 29361
	[Token(Token = "0x4006A24")]
	[FieldOffset(Offset = "0x1CA")]
	public bool IsMashHeal;

	// Token: 0x040072B2 RID: 29362
	[Token(Token = "0x4006A25")]
	[FieldOffset(Offset = "0x1CC")]
	private int healCount;

	// Token: 0x040072B3 RID: 29363
	[Token(Token = "0x4006A26")]
	[FieldOffset(Offset = "0x1D0")]
	public bool IsJump;

	// Token: 0x020006DC RID: 1756
	[Token(Token = "0x2001189")]
	private enum StateType
	{
		// Token: 0x040072B5 RID: 29365
		[Token(Token = "0x40194FC")]
		Stripping,
		// Token: 0x040072B6 RID: 29366
		[Token(Token = "0x40194FD")]
		EatMashroom
	}
}
