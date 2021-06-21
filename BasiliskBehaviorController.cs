using System;
using BehaviorDesigner.Runtime.Tasks;
using BossData;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020006C1 RID: 1729
[Token(Token = "0x20004D3")]
public class BasiliskBehaviorController : BossBehaviorController
{
	// Token: 0x06002A3A RID: 10810 RVA: 0x00010530 File Offset: 0x0000E730
	[Token(Token = "0x6002395")]
	[Address(RVA = "0x22A2050", Offset = "0x22A2151", VA = "0x22A2050")]
	private TaskStatus CheckTargetInRange_Update()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x06002A3B RID: 10811 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002396")]
	[Address(RVA = "0x22A2060", Offset = "0x22A2161", VA = "0x22A2060")]
	private MonsterBehaviorController.BehaviorActionParam CreateForwardMoveAction()
	{
		return null;
	}

	// Token: 0x06002A3C RID: 10812 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002397")]
	[Address(RVA = "0x22A2180", Offset = "0x22A2281", VA = "0x22A2180")]
	private MonsterBehaviorController.BehaviorActionParam CreateLeftMoveAction()
	{
		return null;
	}

	// Token: 0x06002A3D RID: 10813 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002398")]
	[Address(RVA = "0x22A22E0", Offset = "0x22A23E1", VA = "0x22A22E0")]
	private MonsterBehaviorController.BehaviorActionParam CreateRightMoveAction()
	{
		return null;
	}

	// Token: 0x06002A3E RID: 10814 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002399")]
	[Address(RVA = "0x22A2440", Offset = "0x22A2541", VA = "0x22A2440")]
	private MonsterBehaviorController.BehaviorActionParam CreateFallBackAction()
	{
		return null;
	}

	// Token: 0x06002A3F RID: 10815 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600239A")]
	[Address(RVA = "0x22A2590", Offset = "0x22A2691", VA = "0x22A2590")]
	private MonsterBehaviorController.BehaviorActionParam CreateBite11AttackAction()
	{
		return null;
	}

	// Token: 0x06002A40 RID: 10816 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600239B")]
	[Address(RVA = "0x22A2690", Offset = "0x22A2791", VA = "0x22A2690")]
	private MonsterBehaviorController.BehaviorActionParam CreateBite12AttackAction()
	{
		return null;
	}

	// Token: 0x06002A41 RID: 10817 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600239C")]
	[Address(RVA = "0x22A2790", Offset = "0x22A2891", VA = "0x22A2790")]
	private MonsterBehaviorController.BehaviorActionParam CreateMoveBiteAttackAction()
	{
		return null;
	}

	// Token: 0x06002A42 RID: 10818 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600239D")]
	[Address(RVA = "0x22A2890", Offset = "0x22A2991", VA = "0x22A2890")]
	private MonsterBehaviorController.BehaviorActionParam CreateRotation2AttackAction()
	{
		return null;
	}

	// Token: 0x06002A43 RID: 10819 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600239E")]
	[Address(RVA = "0x22A2990", Offset = "0x22A2A91", VA = "0x22A2990")]
	private MonsterBehaviorController.BehaviorActionParam CreateRotation3AttackAction()
	{
		return null;
	}

	// Token: 0x06002A44 RID: 10820 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600239F")]
	[Address(RVA = "0x22A2A90", Offset = "0x22A2B91", VA = "0x22A2A90")]
	private MonsterBehaviorController.BehaviorActionParam CreateFireShotAction()
	{
		return null;
	}

	// Token: 0x06002A45 RID: 10821 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023A0")]
	[Address(RVA = "0x22A2B90", Offset = "0x22A2C91", VA = "0x22A2B90")]
	private MonsterBehaviorController.BehaviorActionParam CreateFireShotMultiAction()
	{
		return null;
	}

	// Token: 0x06002A46 RID: 10822 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023A1")]
	[Address(RVA = "0x22A2C90", Offset = "0x22A2D91", VA = "0x22A2C90")]
	private MonsterBehaviorController.BehaviorActionParam CreateNapalmAction()
	{
		return null;
	}

	// Token: 0x06002A47 RID: 10823 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023A2")]
	[Address(RVA = "0x22A2D90", Offset = "0x22A2E91", VA = "0x22A2D90")]
	private MonsterBehaviorController.BehaviorActionParam CreateFireShotOldMultiAction()
	{
		return null;
	}

	// Token: 0x06002A48 RID: 10824 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023A3")]
	[Address(RVA = "0x22A2E90", Offset = "0x22A2F91", VA = "0x22A2E90", Slot = "10")]
	protected override void OnSetup()
	{
	}

	// Token: 0x06002A49 RID: 10825 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023A4")]
	[Address(RVA = "0x22A30F0", Offset = "0x22A31F1", VA = "0x22A30F0", Slot = "82")]
	public override void SetBossDataAsset(BossDataAssetBase bossData)
	{
	}

	// Token: 0x06002A4A RID: 10826 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023A5")]
	[Address(RVA = "0x22A3130", Offset = "0x22A3231", VA = "0x22A3130", Slot = "92")]
	protected override void UpdateRestraintBehaviorTiming()
	{
	}

	// Token: 0x06002A4B RID: 10827 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023A6")]
	[Address(RVA = "0x22A3170", Offset = "0x22A3271", VA = "0x22A3170", Slot = "88")]
	public override void OnUpdateBossDataBitArray()
	{
	}

	// Token: 0x06002A4C RID: 10828 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023A7")]
	[Address(RVA = "0x22A3340", Offset = "0x22A3441", VA = "0x22A3340", Slot = "63")]
	public override void OnEndActionScript()
	{
	}

	// Token: 0x06002A4D RID: 10829 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023A8")]
	[Address(RVA = "0x22A3350", Offset = "0x22A3451", VA = "0x22A3350")]
	public BasiliskBehaviorController()
	{
	}

	// Token: 0x06002A4E RID: 10830 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023A9")]
	[Address(RVA = "0x22A33D0", Offset = "0x22A34D1", VA = "0x22A33D0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2670", Offset = "0x1A2771")]
	private void <CreateForwardMoveAction>b__3_0(int index, int type)
	{
	}

	// Token: 0x06002A4F RID: 10831 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023AA")]
	[Address(RVA = "0x22A3680", Offset = "0x22A3781", VA = "0x22A3680")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2680", Offset = "0x1A2781")]
	private void <CreateLeftMoveAction>b__4_0()
	{
	}

	// Token: 0x06002A50 RID: 10832 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023AB")]
	[Address(RVA = "0x22A36E0", Offset = "0x22A37E1", VA = "0x22A36E0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2690", Offset = "0x1A2791")]
	private void <CreateLeftMoveAction>b__4_1(int index, int type)
	{
	}

	// Token: 0x06002A51 RID: 10833 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023AC")]
	[Address(RVA = "0x22A3900", Offset = "0x22A3A01", VA = "0x22A3900")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A26A0", Offset = "0x1A27A1")]
	private void <CreateRightMoveAction>b__5_0()
	{
	}

	// Token: 0x06002A52 RID: 10834 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023AD")]
	[Address(RVA = "0x22A3960", Offset = "0x22A3A61", VA = "0x22A3960")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A26B0", Offset = "0x1A27B1")]
	private void <CreateRightMoveAction>b__5_1(int index, int type)
	{
	}

	// Token: 0x06002A53 RID: 10835 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023AE")]
	[Address(RVA = "0x22A3B80", Offset = "0x22A3C81", VA = "0x22A3B80")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A26C0", Offset = "0x1A27C1")]
	private void <CreateFallBackAction>b__6_0()
	{
	}

	// Token: 0x06002A54 RID: 10836 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023AF")]
	[Address(RVA = "0x22A3BE0", Offset = "0x22A3CE1", VA = "0x22A3BE0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A26D0", Offset = "0x1A27D1")]
	private void <CreateFallBackAction>b__6_1(int index, int type)
	{
	}

	// Token: 0x06002A55 RID: 10837 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023B0")]
	[Address(RVA = "0x22A3ED0", Offset = "0x22A3FD1", VA = "0x22A3ED0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A26E0", Offset = "0x1A27E1")]
	private void <CreateBite11AttackAction>b__7_0()
	{
	}

	// Token: 0x06002A56 RID: 10838 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023B1")]
	[Address(RVA = "0x22A3F20", Offset = "0x22A4021", VA = "0x22A3F20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A26F0", Offset = "0x1A27F1")]
	private void <CreateBite12AttackAction>b__8_0()
	{
	}

	// Token: 0x06002A57 RID: 10839 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023B2")]
	[Address(RVA = "0x22A3F70", Offset = "0x22A4071", VA = "0x22A3F70")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2700", Offset = "0x1A2801")]
	private void <CreateMoveBiteAttackAction>b__9_0()
	{
	}

	// Token: 0x06002A58 RID: 10840 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023B3")]
	[Address(RVA = "0x22A3FC0", Offset = "0x22A40C1", VA = "0x22A3FC0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2710", Offset = "0x1A2811")]
	private void <CreateRotation2AttackAction>b__10_0()
	{
	}

	// Token: 0x06002A59 RID: 10841 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023B4")]
	[Address(RVA = "0x22A4010", Offset = "0x22A4111", VA = "0x22A4010")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2720", Offset = "0x1A2821")]
	private void <CreateRotation3AttackAction>b__11_0()
	{
	}

	// Token: 0x06002A5A RID: 10842 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023B5")]
	[Address(RVA = "0x22A4060", Offset = "0x22A4161", VA = "0x22A4060")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2730", Offset = "0x1A2831")]
	private void <CreateFireShotAction>b__12_0()
	{
	}

	// Token: 0x06002A5B RID: 10843 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023B6")]
	[Address(RVA = "0x22A40B0", Offset = "0x22A41B1", VA = "0x22A40B0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2740", Offset = "0x1A2841")]
	private void <CreateFireShotMultiAction>b__13_0()
	{
	}

	// Token: 0x06002A5C RID: 10844 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023B7")]
	[Address(RVA = "0x22A4100", Offset = "0x22A4201", VA = "0x22A4100")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2750", Offset = "0x1A2851")]
	private void <CreateNapalmAction>b__14_0()
	{
	}

	// Token: 0x06002A5D RID: 10845 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60023B8")]
	[Address(RVA = "0x22A4150", Offset = "0x22A4251", VA = "0x22A4150")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2760", Offset = "0x1A2861")]
	private void <CreateFireShotOldMultiAction>b__15_0()
	{
	}

	// Token: 0x04007221 RID: 29217
	[Token(Token = "0x40069DB")]
	private const float StageCenterRange = 10f;

	// Token: 0x04007222 RID: 29218
	[Token(Token = "0x40069DC")]
	[FieldOffset(Offset = "0x1C0")]
	private Vector3 StageCenterPosition;

	// Token: 0x020006C2 RID: 1730
	[Token(Token = "0x2001177")]
	private enum StateType
	{
		// Token: 0x04007224 RID: 29220
		[Token(Token = "0x40194BA")]
		WaitLocomotionState
	}
}
