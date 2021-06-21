using System;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

// Token: 0x0200015E RID: 350
[Token(Token = "0x2000112")]
[Attribute(Name = "TaskCategoryAttribute", RVA = "0x145600", Offset = "0x145701")]
public class SetSharedFarmMonsterHutState : BehaviorDesigner.Runtime.Tasks.Action
{
	// Token: 0x0600074D RID: 1869 RVA: 0x000049C8 File Offset: 0x00002BC8
	[Token(Token = "0x600062C")]
	[Address(RVA = "0x1E35A00", Offset = "0x1E35B01", VA = "0x1E35A00", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x0600074E RID: 1870 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600062D")]
	[Address(RVA = "0x1E35A80", Offset = "0x1E35B81", VA = "0x1E35A80", Slot = "16")]
	public override void OnReset()
	{
	}

	// Token: 0x0600074F RID: 1871 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600062E")]
	[Address(RVA = "0x1E35AC0", Offset = "0x1E35BC1", VA = "0x1E35AC0")]
	public SetSharedFarmMonsterHutState()
	{
	}

	// Token: 0x04000433 RID: 1075
	[Token(Token = "0x400033E")]
	[FieldOffset(Offset = "0x50")]
	public SharedFarmMonsterHutState targetValue;

	// Token: 0x04000434 RID: 1076
	[Token(Token = "0x400033F")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "RequiredFieldAttribute", RVA = "0x15BFC0", Offset = "0x15C0C1")]
	public SharedFarmMonsterHutState targetVariable;
}
