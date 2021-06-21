using System;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

// Token: 0x0200012A RID: 298
[Token(Token = "0x20000EE")]
[Attribute(Name = "TaskCategoryAttribute", RVA = "0x144FC0", Offset = "0x1450C1")]
public class PartnerNPCMagicRAAttack : BehaviorDesigner.Runtime.Tasks.Action
{
	// Token: 0x06000650 RID: 1616 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600056C")]
	[Address(RVA = "0x2139080", Offset = "0x2139181", VA = "0x2139080", Slot = "4")]
	public override void OnAwake()
	{
	}

	// Token: 0x06000651 RID: 1617 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600056D")]
	[Address(RVA = "0x2139140", Offset = "0x2139241", VA = "0x2139140", Slot = "5")]
	public override void OnStart()
	{
	}

	// Token: 0x06000652 RID: 1618 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600056E")]
	[Address(RVA = "0x21393F0", Offset = "0x21394F1", VA = "0x21393F0", Slot = "9")]
	public override void OnEnd()
	{
	}

	// Token: 0x06000653 RID: 1619 RVA: 0x00004500 File Offset: 0x00002700
	[Token(Token = "0x600056F")]
	[Address(RVA = "0x2139410", Offset = "0x2139511", VA = "0x2139410", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x06000654 RID: 1620 RVA: 0x00004518 File Offset: 0x00002718
	[Token(Token = "0x6000570")]
	[Address(RVA = "0x2139290", Offset = "0x2139391", VA = "0x2139290")]
	public bool CheckTarget()
	{
		return default(bool);
	}

	// Token: 0x06000655 RID: 1621 RVA: 0x00004530 File Offset: 0x00002730
	[Token(Token = "0x6000571")]
	[Address(RVA = "0x21394F0", Offset = "0x21395F1", VA = "0x21394F0")]
	public bool JudgeContinue()
	{
		return default(bool);
	}

	// Token: 0x06000656 RID: 1622 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000572")]
	[Address(RVA = "0x21395C0", Offset = "0x21396C1", VA = "0x21395C0")]
	public PartnerNPCMagicRAAttack()
	{
	}

	// Token: 0x0400038F RID: 911
	[Token(Token = "0x40002D8")]
	[FieldOffset(Offset = "0x50")]
	private PartnerNPCBehaviorController PartnerNPCBehaviorController;

	// Token: 0x04000390 RID: 912
	[Token(Token = "0x40002D9")]
	[FieldOffset(Offset = "0x58")]
	public PlayerCharacterController.Action Action;

	// Token: 0x04000391 RID: 913
	[Token(Token = "0x40002DA")]
	[FieldOffset(Offset = "0x60")]
	private MagicController MagicController;

	// Token: 0x04000392 RID: 914
	[Token(Token = "0x40002DB")]
	[FieldOffset(Offset = "0x68")]
	private TaskStatus CurrentTaskStatus;
}
