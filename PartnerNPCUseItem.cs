using System;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

// Token: 0x0200012D RID: 301
[Token(Token = "0x20000F1")]
[Attribute(Name = "TaskCategoryAttribute", RVA = "0x145040", Offset = "0x145141")]
public class PartnerNPCUseItem : BehaviorDesigner.Runtime.Tasks.Action
{
	// Token: 0x06000661 RID: 1633 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600057D")]
	[Address(RVA = "0x2139AB0", Offset = "0x2139BB1", VA = "0x2139AB0", Slot = "4")]
	public override void OnAwake()
	{
	}

	// Token: 0x06000662 RID: 1634 RVA: 0x000045A8 File Offset: 0x000027A8
	[Token(Token = "0x600057E")]
	[Address(RVA = "0x2139B70", Offset = "0x2139C71", VA = "0x2139B70", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x06000663 RID: 1635 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600057F")]
	[Address(RVA = "0x2139C00", Offset = "0x2139D01", VA = "0x2139C00", Slot = "9")]
	public override void OnEnd()
	{
	}

	// Token: 0x06000664 RID: 1636 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000580")]
	[Address(RVA = "0x2139C60", Offset = "0x2139D61", VA = "0x2139C60")]
	public PartnerNPCUseItem()
	{
	}

	// Token: 0x04000395 RID: 917
	[Token(Token = "0x40002DE")]
	[FieldOffset(Offset = "0x50")]
	private PartnerNPCBehaviorController PartnerNPCBehaviorController;
}
