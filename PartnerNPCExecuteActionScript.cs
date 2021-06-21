using System;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

// Token: 0x02000128 RID: 296
[Token(Token = "0x20000EC")]
[Attribute(Name = "TaskCategoryAttribute", RVA = "0x144F40", Offset = "0x145041")]
public class PartnerNPCExecuteActionScript : BehaviorDesigner.Runtime.Tasks.Action
{
	// Token: 0x06000648 RID: 1608 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000564")]
	[Address(RVA = "0x2138B90", Offset = "0x2138C91", VA = "0x2138B90", Slot = "4")]
	public override void OnAwake()
	{
	}

	// Token: 0x06000649 RID: 1609 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000565")]
	[Address(RVA = "0x2138C50", Offset = "0x2138D51", VA = "0x2138C50", Slot = "5")]
	public override void OnStart()
	{
	}

	// Token: 0x0600064A RID: 1610 RVA: 0x000044D0 File Offset: 0x000026D0
	[Token(Token = "0x6000566")]
	[Address(RVA = "0x2138C60", Offset = "0x2138D61", VA = "0x2138C60", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x0600064B RID: 1611 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000567")]
	[Address(RVA = "0x2138DC0", Offset = "0x2138EC1", VA = "0x2138DC0")]
	public PartnerNPCExecuteActionScript()
	{
	}

	// Token: 0x0400038A RID: 906
	[Token(Token = "0x40002D3")]
	[FieldOffset(Offset = "0x50")]
	private PartnerNPCBehaviorController PartnerNPCBehaviorController;

	// Token: 0x0400038B RID: 907
	[Token(Token = "0x40002D4")]
	[FieldOffset(Offset = "0x58")]
	private bool IsAction;
}
