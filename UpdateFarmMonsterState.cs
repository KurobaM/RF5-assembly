using System;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

// Token: 0x02000164 RID: 356
[Token(Token = "0x2000118")]
[Attribute(Name = "TaskCategoryAttribute", RVA = "0x145780", Offset = "0x145881")]
public class UpdateFarmMonsterState : BehaviorDesigner.Runtime.Tasks.Action
{
	// Token: 0x0600075F RID: 1887 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600063E")]
	[Address(RVA = "0x1E46210", Offset = "0x1E46311", VA = "0x1E46210", Slot = "4")]
	public override void OnAwake()
	{
	}

	// Token: 0x06000760 RID: 1888 RVA: 0x00004A10 File Offset: 0x00002C10
	[Token(Token = "0x600063F")]
	[Address(RVA = "0x1E462E0", Offset = "0x1E463E1", VA = "0x1E462E0", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x06000761 RID: 1889 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000640")]
	[Address(RVA = "0x1E46310", Offset = "0x1E46411", VA = "0x1E46310")]
	public UpdateFarmMonsterState()
	{
	}

	// Token: 0x04000439 RID: 1081
	[Token(Token = "0x4000344")]
	[FieldOffset(Offset = "0x50")]
	private FarmMonsterBehaviorController FarmMonsterBehaviorController;
}
