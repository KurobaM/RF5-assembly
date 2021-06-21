using System;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

// Token: 0x0200012B RID: 299
[Token(Token = "0x20000EF")]
public class PartnerNPCSetupActionBehavior : BehaviorDesigner.Runtime.Tasks.Action
{
	// Token: 0x17000167 RID: 359
	// (get) Token: 0x06000657 RID: 1623 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000161")]
	private PartnerNPCController Character
	{
		[Token(Token = "0x6000573")]
		[Address(RVA = "0x21395D0", Offset = "0x21396D1", VA = "0x21395D0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000658 RID: 1624 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000574")]
	[Address(RVA = "0x21395F0", Offset = "0x21396F1", VA = "0x21395F0", Slot = "4")]
	public override void OnAwake()
	{
	}

	// Token: 0x06000659 RID: 1625 RVA: 0x00004548 File Offset: 0x00002748
	[Token(Token = "0x6000575")]
	[Address(RVA = "0x21396B0", Offset = "0x21397B1", VA = "0x21396B0", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x0600065A RID: 1626 RVA: 0x00004560 File Offset: 0x00002760
	[Token(Token = "0x6000576")]
	[Address(RVA = "0x2139770", Offset = "0x2139871", VA = "0x2139770")]
	private bool EnableAttack()
	{
		return default(bool);
	}

	// Token: 0x0600065B RID: 1627 RVA: 0x00004578 File Offset: 0x00002778
	[Token(Token = "0x6000577")]
	[Address(RVA = "0x21397A0", Offset = "0x21398A1", VA = "0x21397A0")]
	private bool UseItem()
	{
		return default(bool);
	}

	// Token: 0x0600065C RID: 1628 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000578")]
	[Address(RVA = "0x21397D0", Offset = "0x21398D1", VA = "0x21397D0")]
	public PartnerNPCSetupActionBehavior()
	{
	}

	// Token: 0x04000393 RID: 915
	[Token(Token = "0x40002DC")]
	[FieldOffset(Offset = "0x50")]
	private PartnerNPCBehaviorController PartnerNPCBehaviorController;
}
