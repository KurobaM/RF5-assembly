using System;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

// Token: 0x0200012F RID: 303
[Token(Token = "0x20000F3")]
[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1450C0", Offset = "0x1451C1")]
public class SetPartnerBehaviorType : BehaviorDesigner.Runtime.Tasks.Action
{
	// Token: 0x06000668 RID: 1640 RVA: 0x000045D8 File Offset: 0x000027D8
	[Token(Token = "0x6000584")]
	[Address(RVA = "0x1E34D40", Offset = "0x1E34E41", VA = "0x1E34D40", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x06000669 RID: 1641 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000585")]
	[Address(RVA = "0x1E34DC0", Offset = "0x1E34EC1", VA = "0x1E34DC0")]
	public SetPartnerBehaviorType()
	{
	}

	// Token: 0x04000397 RID: 919
	[Token(Token = "0x40002E0")]
	[FieldOffset(Offset = "0x50")]
	public SharedPartnerNPCBehaviorController SharedPartnerBehaviorController;

	// Token: 0x04000398 RID: 920
	[Token(Token = "0x40002E1")]
	[FieldOffset(Offset = "0x58")]
	public PartnerBehaviorType PartnerBehaviorType;
}
