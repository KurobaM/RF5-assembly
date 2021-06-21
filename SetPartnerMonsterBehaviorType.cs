using System;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

// Token: 0x02000130 RID: 304
[Token(Token = "0x20000F4")]
[Attribute(Name = "TaskCategoryAttribute", RVA = "0x145100", Offset = "0x145201")]
public class SetPartnerMonsterBehaviorType : BehaviorDesigner.Runtime.Tasks.Action
{
	// Token: 0x0600066A RID: 1642 RVA: 0x000045F0 File Offset: 0x000027F0
	[Token(Token = "0x6000586")]
	[Address(RVA = "0x1E34DD0", Offset = "0x1E34ED1", VA = "0x1E34DD0", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x0600066B RID: 1643 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000587")]
	[Address(RVA = "0x1E34E50", Offset = "0x1E34F51", VA = "0x1E34E50")]
	public SetPartnerMonsterBehaviorType()
	{
	}

	// Token: 0x04000399 RID: 921
	[Token(Token = "0x40002E2")]
	[FieldOffset(Offset = "0x50")]
	public SharedPartnerMonsterBehaviorController SharedPartnerMonsterBehaviorController;

	// Token: 0x0400039A RID: 922
	[Token(Token = "0x40002E3")]
	[FieldOffset(Offset = "0x58")]
	public PartnerBehaviorType PartnerBehaviorType;
}
