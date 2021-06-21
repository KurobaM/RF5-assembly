using System;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

// Token: 0x0200012E RID: 302
[Token(Token = "0x20000F2")]
[Attribute(Name = "TaskCategoryAttribute", RVA = "0x145080", Offset = "0x145181")]
public class SetupPartnerNPCAction : BehaviorDesigner.Runtime.Tasks.Action
{
	// Token: 0x06000665 RID: 1637 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000581")]
	[Address(RVA = "0x1E35F00", Offset = "0x1E36001", VA = "0x1E35F00", Slot = "4")]
	public override void OnAwake()
	{
	}

	// Token: 0x06000666 RID: 1638 RVA: 0x000045C0 File Offset: 0x000027C0
	[Token(Token = "0x6000582")]
	[Address(RVA = "0x1E35FD0", Offset = "0x1E360D1", VA = "0x1E35FD0", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x06000667 RID: 1639 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000583")]
	[Address(RVA = "0x1E36000", Offset = "0x1E36101", VA = "0x1E36000")]
	public SetupPartnerNPCAction()
	{
	}

	// Token: 0x04000396 RID: 918
	[Token(Token = "0x40002DF")]
	[FieldOffset(Offset = "0x50")]
	private PartnerNPCBehaviorController PartnerNPCBehaviorController;
}
