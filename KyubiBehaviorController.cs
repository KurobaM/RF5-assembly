using System;
using BehaviorDesigner.Runtime.Tasks;
using BossData;
using Il2CppDummyDll;

// Token: 0x02000732 RID: 1842
[Token(Token = "0x2000500")]
public class KyubiBehaviorController : BossBehaviorController
{
	// Token: 0x06002EC9 RID: 11977 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002765")]
	[Address(RVA = "0x224EF90", Offset = "0x224F091", VA = "0x224EF90")]
	private void JumpRotate(bool JumpMove)
	{
	}

	// Token: 0x06002ECA RID: 11978 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002766")]
	[Address(RVA = "0x224F260", Offset = "0x224F361", VA = "0x224F260")]
	private MonsterBehaviorController.BehaviorActionParam CreateRushAttack1()
	{
		return null;
	}

	// Token: 0x06002ECB RID: 11979 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002767")]
	[Address(RVA = "0x224F3E0", Offset = "0x224F4E1", VA = "0x224F3E0")]
	private MonsterBehaviorController.BehaviorActionParam CreateRushAttack2()
	{
		return null;
	}

	// Token: 0x06002ECC RID: 11980 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002768")]
	[Address(RVA = "0x224F560", Offset = "0x224F661", VA = "0x224F560")]
	private MonsterBehaviorController.BehaviorActionParam CreateDropAttack()
	{
		return null;
	}

	// Token: 0x06002ECD RID: 11981 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002769")]
	[Address(RVA = "0x224F6C0", Offset = "0x224F7C1", VA = "0x224F6C0")]
	private MonsterBehaviorController.BehaviorActionParam CreateKyubiFireAttack()
	{
		return null;
	}

	// Token: 0x06002ECE RID: 11982 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600276A")]
	[Address(RVA = "0x224F840", Offset = "0x224F941", VA = "0x224F840")]
	private MonsterBehaviorController.BehaviorActionParam CreateRoarAttack()
	{
		return null;
	}

	// Token: 0x06002ECF RID: 11983 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600276B")]
	[Address(RVA = "0x224F9C0", Offset = "0x224FAC1", VA = "0x224F9C0")]
	private MonsterBehaviorController.BehaviorActionParam CreateJumpAttack()
	{
		return null;
	}

	// Token: 0x06002ED0 RID: 11984 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600276C")]
	[Address(RVA = "0x224FB40", Offset = "0x224FC41", VA = "0x224FB40")]
	private MonsterBehaviorController.BehaviorActionParam CreateFireBallAttack()
	{
		return null;
	}

	// Token: 0x06002ED1 RID: 11985 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600276D")]
	[Address(RVA = "0x224FCB0", Offset = "0x224FDB1", VA = "0x224FCB0")]
	private MonsterBehaviorController.BehaviorActionParam CreateMultiFireBallAttack()
	{
		return null;
	}

	// Token: 0x06002ED2 RID: 11986 RVA: 0x00010D88 File Offset: 0x0000EF88
	[Token(Token = "0x600276E")]
	[Address(RVA = "0x224FE20", Offset = "0x224FF21", VA = "0x224FE20")]
	private TaskStatus SelectMove_Update()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x06002ED3 RID: 11987 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600276F")]
	[Address(RVA = "0x2250210", Offset = "0x2250311", VA = "0x2250210")]
	private MonsterBehaviorController.BehaviorActionParam CreateAroundMove()
	{
		return null;
	}

	// Token: 0x06002ED4 RID: 11988 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002770")]
	[Address(RVA = "0x2250320", Offset = "0x2250421", VA = "0x2250320")]
	private MonsterBehaviorController.BehaviorActionParam CreateJumpMove()
	{
		return null;
	}

	// Token: 0x06002ED5 RID: 11989 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002771")]
	[Address(RVA = "0x2250430", Offset = "0x2250531", VA = "0x2250430", Slot = "10")]
	protected override void OnSetup()
	{
	}

	// Token: 0x06002ED6 RID: 11990 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002772")]
	[Address(RVA = "0x2250630", Offset = "0x2250731", VA = "0x2250630", Slot = "82")]
	public override void SetBossDataAsset(BossDataAssetBase bossData)
	{
	}

	// Token: 0x06002ED7 RID: 11991 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002773")]
	[Address(RVA = "0x22507A0", Offset = "0x22508A1", VA = "0x22507A0", Slot = "92")]
	protected override void UpdateRestraintBehaviorTiming()
	{
	}

	// Token: 0x06002ED8 RID: 11992 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002774")]
	[Address(RVA = "0x22507E0", Offset = "0x22508E1", VA = "0x22507E0", Slot = "93")]
	protected override void UpdateReciveItemBehaviorTiming()
	{
	}

	// Token: 0x06002ED9 RID: 11993 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002775")]
	[Address(RVA = "0x2250860", Offset = "0x2250961", VA = "0x2250860")]
	public KyubiBehaviorController()
	{
	}

	// Token: 0x06002EDA RID: 11994 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002776")]
	[Address(RVA = "0x2250870", Offset = "0x2250971", VA = "0x2250870")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3B10", Offset = "0x1A3C11")]
	private void <CreateRushAttack1>b__10_0()
	{
	}

	// Token: 0x06002EDB RID: 11995 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002777")]
	[Address(RVA = "0x22508C0", Offset = "0x22509C1", VA = "0x22508C0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3B20", Offset = "0x1A3C21")]
	private void <CreateRushAttack1>b__10_1(int index, int type)
	{
	}

	// Token: 0x06002EDC RID: 11996 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002778")]
	[Address(RVA = "0x22509B0", Offset = "0x2250AB1", VA = "0x22509B0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3B30", Offset = "0x1A3C31")]
	private void <CreateRushAttack2>b__11_0()
	{
	}

	// Token: 0x06002EDD RID: 11997 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002779")]
	[Address(RVA = "0x2250A00", Offset = "0x2250B01", VA = "0x2250A00")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3B40", Offset = "0x1A3C41")]
	private void <CreateRushAttack2>b__11_1(int index, int type)
	{
	}

	// Token: 0x06002EDE RID: 11998 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600277A")]
	[Address(RVA = "0x2250AF0", Offset = "0x2250BF1", VA = "0x2250AF0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3B50", Offset = "0x1A3C51")]
	private void <CreateDropAttack>b__12_0()
	{
	}

	// Token: 0x06002EDF RID: 11999 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600277B")]
	[Address(RVA = "0x2250B40", Offset = "0x2250C41", VA = "0x2250B40")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3B60", Offset = "0x1A3C61")]
	private void <CreateDropAttack>b__12_1(int index, int type)
	{
	}

	// Token: 0x06002EE0 RID: 12000 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600277C")]
	[Address(RVA = "0x2250BD0", Offset = "0x2250CD1", VA = "0x2250BD0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3B70", Offset = "0x1A3C71")]
	private void <CreateKyubiFireAttack>b__13_0()
	{
	}

	// Token: 0x06002EE1 RID: 12001 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600277D")]
	[Address(RVA = "0x2250C20", Offset = "0x2250D21", VA = "0x2250C20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3B80", Offset = "0x1A3C81")]
	private void <CreateKyubiFireAttack>b__13_1(int index, int type)
	{
	}

	// Token: 0x06002EE2 RID: 12002 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600277E")]
	[Address(RVA = "0x2250D10", Offset = "0x2250E11", VA = "0x2250D10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3B90", Offset = "0x1A3C91")]
	private void <CreateRoarAttack>b__14_0()
	{
	}

	// Token: 0x06002EE3 RID: 12003 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600277F")]
	[Address(RVA = "0x2250D60", Offset = "0x2250E61", VA = "0x2250D60")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3BA0", Offset = "0x1A3CA1")]
	private void <CreateRoarAttack>b__14_1(int index, int type)
	{
	}

	// Token: 0x06002EE4 RID: 12004 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002780")]
	[Address(RVA = "0x2250E50", Offset = "0x2250F51", VA = "0x2250E50")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3BB0", Offset = "0x1A3CB1")]
	private void <CreateJumpAttack>b__15_0()
	{
	}

	// Token: 0x06002EE5 RID: 12005 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002781")]
	[Address(RVA = "0x2250EA0", Offset = "0x2250FA1", VA = "0x2250EA0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3BC0", Offset = "0x1A3CC1")]
	private void <CreateJumpAttack>b__15_1(int index, int type)
	{
	}

	// Token: 0x06002EE6 RID: 12006 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002782")]
	[Address(RVA = "0x2250F90", Offset = "0x2251091", VA = "0x2250F90")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3BD0", Offset = "0x1A3CD1")]
	private void <CreateFireBallAttack>b__16_0()
	{
	}

	// Token: 0x06002EE7 RID: 12007 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002783")]
	[Address(RVA = "0x2250FE0", Offset = "0x22510E1", VA = "0x2250FE0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3BE0", Offset = "0x1A3CE1")]
	private void <CreateFireBallAttack>b__16_1(int index, int type)
	{
	}

	// Token: 0x06002EE8 RID: 12008 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002784")]
	[Address(RVA = "0x22510D0", Offset = "0x22511D1", VA = "0x22510D0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3BF0", Offset = "0x1A3CF1")]
	private void <CreateMultiFireBallAttack>b__18_0()
	{
	}

	// Token: 0x06002EE9 RID: 12009 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002785")]
	[Address(RVA = "0x2251130", Offset = "0x2251231", VA = "0x2251130")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3C00", Offset = "0x1A3D01")]
	private void <CreateMultiFireBallAttack>b__18_1(int index, int type)
	{
	}

	// Token: 0x06002EEA RID: 12010 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002786")]
	[Address(RVA = "0x2251220", Offset = "0x2251321", VA = "0x2251220")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3C10", Offset = "0x1A3D11")]
	private void <CreateAroundMove>b__20_0(int index, int type)
	{
	}

	// Token: 0x06002EEB RID: 12011 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002787")]
	[Address(RVA = "0x2251440", Offset = "0x2251541", VA = "0x2251440")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3C20", Offset = "0x1A3D21")]
	private void <CreateJumpMove>b__21_0(int index, int type)
	{
	}

	// Token: 0x040074A7 RID: 29863
	[Token(Token = "0x4006B3A")]
	[FieldOffset(Offset = "0x1C0")]
	private float ChangeMoveDefaultTargetLength;

	// Token: 0x040074A8 RID: 29864
	[Token(Token = "0x4006B3B")]
	[FieldOffset(Offset = "0x1C4")]
	private float ChangeMoveMadnessTargetLength;

	// Token: 0x040074A9 RID: 29865
	[Token(Token = "0x4006B3C")]
	[FieldOffset(Offset = "0x1C8")]
	private float JumpLength;

	// Token: 0x040074AA RID: 29866
	[Token(Token = "0x4006B3D")]
	[FieldOffset(Offset = "0x1CC")]
	private float BeforeRushWaitTime;

	// Token: 0x040074AB RID: 29867
	[Token(Token = "0x4006B3E")]
	[FieldOffset(Offset = "0x1D0")]
	private float BeforeJumpAttackWaitTime;

	// Token: 0x040074AC RID: 29868
	[Token(Token = "0x4006B3F")]
	[FieldOffset(Offset = "0x1D4")]
	private float BeforeFireBallWaitTime;

	// Token: 0x040074AD RID: 29869
	[Token(Token = "0x4006B40")]
	[FieldOffset(Offset = "0x1D8")]
	private float BeforeRoarAttackWaitTime;

	// Token: 0x040074AE RID: 29870
	[Token(Token = "0x4006B41")]
	[FieldOffset(Offset = "0x1DC")]
	private float BeforeKyubiFireWaitTime;

	// Token: 0x040074AF RID: 29871
	[Token(Token = "0x4006B42")]
	[FieldOffset(Offset = "0x1E0")]
	private int FireBallCount;

	// Token: 0x02000733 RID: 1843
	[Token(Token = "0x20011B9")]
	private enum FunctionState
	{
		// Token: 0x040074B1 RID: 29873
		[Token(Token = "0x40195D7")]
		SelectMove,
		// Token: 0x040074B2 RID: 29874
		[Token(Token = "0x40195D8")]
		SelectFireBall
	}
}
