using System;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

// Token: 0x02000127 RID: 295
[Token(Token = "0x20000EB")]
[Attribute(Name = "TaskCategoryAttribute", RVA = "0x144F00", Offset = "0x145001")]
public class PartnerNPCWeaponAttack : BehaviorDesigner.Runtime.Tasks.Action
{
	// Token: 0x17000165 RID: 357
	// (get) Token: 0x06000640 RID: 1600 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700015F")]
	private HumanController HumanController
	{
		[Token(Token = "0x600055C")]
		[Address(RVA = "0x2139C70", Offset = "0x2139D71", VA = "0x2139C70")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000641 RID: 1601 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600055D")]
	[Address(RVA = "0x2139CD0", Offset = "0x2139DD1", VA = "0x2139CD0", Slot = "5")]
	public override void OnStart()
	{
	}

	// Token: 0x06000642 RID: 1602 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600055E")]
	[Address(RVA = "0x2139FE0", Offset = "0x213A0E1", VA = "0x2139FE0", Slot = "9")]
	public override void OnEnd()
	{
	}

	// Token: 0x06000643 RID: 1603 RVA: 0x00004488 File Offset: 0x00002688
	[Token(Token = "0x600055F")]
	[Address(RVA = "0x213A070", Offset = "0x213A171", VA = "0x213A070", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x06000644 RID: 1604 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000560")]
	[Address(RVA = "0x213A0B0", Offset = "0x213A1B1", VA = "0x213A0B0")]
	private void UpdateTaskStatus()
	{
	}

	// Token: 0x06000645 RID: 1605 RVA: 0x000044A0 File Offset: 0x000026A0
	[Token(Token = "0x6000561")]
	[Address(RVA = "0x213A380", Offset = "0x213A481", VA = "0x213A380")]
	private bool IsContinueAttack()
	{
		return default(bool);
	}

	// Token: 0x06000646 RID: 1606 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000562")]
	[Address(RVA = "0x213A4D0", Offset = "0x213A5D1", VA = "0x213A4D0")]
	public PartnerNPCWeaponAttack()
	{
	}

	// Token: 0x06000647 RID: 1607 RVA: 0x000044B8 File Offset: 0x000026B8
	[Token(Token = "0x6000563")]
	[Address(RVA = "0x213A4E0", Offset = "0x213A5E1", VA = "0x213A4E0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A540", Offset = "0x19A641")]
	private bool <OnStart>b__10_0()
	{
		return default(bool);
	}

	// Token: 0x04000382 RID: 898
	[Token(Token = "0x40002CB")]
	[FieldOffset(Offset = "0x50")]
	public SharedPartnerNPCBehaviorController SharedPartnerBehaviorController;

	// Token: 0x04000383 RID: 899
	[Token(Token = "0x40002CC")]
	[FieldOffset(Offset = "0x58")]
	public SharedInt WeaponComboCount;

	// Token: 0x04000384 RID: 900
	[Token(Token = "0x40002CD")]
	[FieldOffset(Offset = "0x60")]
	public SharedGameObject Target;

	// Token: 0x04000385 RID: 901
	[Token(Token = "0x40002CE")]
	[FieldOffset(Offset = "0x68")]
	public SharedFloat UpdateTime;

	// Token: 0x04000386 RID: 902
	[Token(Token = "0x40002CF")]
	[FieldOffset(Offset = "0x70")]
	public float Timer;

	// Token: 0x04000387 RID: 903
	[Token(Token = "0x40002D0")]
	[FieldOffset(Offset = "0x74")]
	public bool IsAttackContinue;

	// Token: 0x04000388 RID: 904
	[Token(Token = "0x40002D1")]
	[FieldOffset(Offset = "0x78")]
	private int CurrentComboCount;

	// Token: 0x04000389 RID: 905
	[Token(Token = "0x40002D2")]
	[FieldOffset(Offset = "0x7C")]
	private TaskStatus CurrentTaskStatus;
}
