using System;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

// Token: 0x02000120 RID: 288
[Token(Token = "0x20000E4")]
public class SetupMonsterAction : BehaviorDesigner.Runtime.Tasks.Action
{
	// Token: 0x06000625 RID: 1573 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000541")]
	[Address(RVA = "0x1E35DF0", Offset = "0x1E35EF1", VA = "0x1E35DF0", Slot = "4")]
	public override void OnAwake()
	{
	}

	// Token: 0x06000626 RID: 1574 RVA: 0x000043B0 File Offset: 0x000025B0
	[Token(Token = "0x6000542")]
	[Address(RVA = "0x1E35EC0", Offset = "0x1E35FC1", VA = "0x1E35EC0", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x06000627 RID: 1575 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000543")]
	[Address(RVA = "0x1E35EF0", Offset = "0x1E35FF1", VA = "0x1E35EF0")]
	public SetupMonsterAction()
	{
	}

	// Token: 0x0400036A RID: 874
	[Token(Token = "0x40002B3")]
	[FieldOffset(Offset = "0x50")]
	private MonsterBehaviorController MonsterBehaviorController;
}
