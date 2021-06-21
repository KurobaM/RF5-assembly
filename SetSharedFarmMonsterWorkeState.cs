using System;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

// Token: 0x02000160 RID: 352
[Token(Token = "0x2000114")]
[Attribute(Name = "TaskCategoryAttribute", RVA = "0x145680", Offset = "0x145781")]
public class SetSharedFarmMonsterWorkeState : BehaviorDesigner.Runtime.Tasks.Action
{
	// Token: 0x06000753 RID: 1875 RVA: 0x000049F8 File Offset: 0x00002BF8
	[Token(Token = "0x6000632")]
	[Address(RVA = "0x1E35BA0", Offset = "0x1E35CA1", VA = "0x1E35BA0", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x06000754 RID: 1876 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000633")]
	[Address(RVA = "0x1E35C20", Offset = "0x1E35D21", VA = "0x1E35C20", Slot = "16")]
	public override void OnReset()
	{
	}

	// Token: 0x06000755 RID: 1877 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000634")]
	[Address(RVA = "0x1E35C60", Offset = "0x1E35D61", VA = "0x1E35C60")]
	public SetSharedFarmMonsterWorkeState()
	{
	}

	// Token: 0x04000437 RID: 1079
	[Token(Token = "0x4000342")]
	[FieldOffset(Offset = "0x50")]
	public SharedFarmMonsterWorkState targetValue;

	// Token: 0x04000438 RID: 1080
	[Token(Token = "0x4000343")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "RequiredFieldAttribute", RVA = "0x15BFE0", Offset = "0x15C0E1")]
	public SharedFarmMonsterWorkState targetVariable;
}
