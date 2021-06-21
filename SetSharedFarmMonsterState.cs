using System;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

// Token: 0x0200015F RID: 351
[Token(Token = "0x2000113")]
[Attribute(Name = "TaskCategoryAttribute", RVA = "0x145640", Offset = "0x145741")]
public class SetSharedFarmMonsterState : BehaviorDesigner.Runtime.Tasks.Action
{
	// Token: 0x06000750 RID: 1872 RVA: 0x000049E0 File Offset: 0x00002BE0
	[Token(Token = "0x600062F")]
	[Address(RVA = "0x1E35AD0", Offset = "0x1E35BD1", VA = "0x1E35AD0", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x06000751 RID: 1873 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000630")]
	[Address(RVA = "0x1E35B50", Offset = "0x1E35C51", VA = "0x1E35B50", Slot = "16")]
	public override void OnReset()
	{
	}

	// Token: 0x06000752 RID: 1874 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000631")]
	[Address(RVA = "0x1E35B90", Offset = "0x1E35C91", VA = "0x1E35B90")]
	public SetSharedFarmMonsterState()
	{
	}

	// Token: 0x04000435 RID: 1077
	[Token(Token = "0x4000340")]
	[FieldOffset(Offset = "0x50")]
	public SharedFarmMonsterState targetValue;

	// Token: 0x04000436 RID: 1078
	[Token(Token = "0x4000341")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "RequiredFieldAttribute", RVA = "0x15BFD0", Offset = "0x15C0D1")]
	public SharedFarmMonsterState targetVariable;
}
