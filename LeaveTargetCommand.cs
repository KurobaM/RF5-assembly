using System;
using BehaviorDesigner.Runtime;
using Il2CppDummyDll;

// Token: 0x0200002E RID: 46
[Token(Token = "0x200002D")]
public class LeaveTargetCommand : ActionBehaviorCommandBase
{
	// Token: 0x06000086 RID: 134 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000086")]
	[Address(RVA = "0x230BAC0", Offset = "0x230BBC1", VA = "0x230BAC0")]
	public LeaveTargetCommand(ActionBehaviorController controller, ActionBehaviorCommandInformation info)
	{
	}

	// Token: 0x06000087 RID: 135 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000087")]
	[Address(RVA = "0x230BAD0", Offset = "0x230BBD1", VA = "0x230BAD0", Slot = "4")]
	public override void OnSetupParameter(BehaviorTree behaviorTree)
	{
	}

	// Token: 0x06000088 RID: 136 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000088")]
	[Address(RVA = "0x230BC90", Offset = "0x230BD91", VA = "0x230BC90", Slot = "5")]
	public override void OnExecute()
	{
	}

	// Token: 0x0400007E RID: 126
	[Token(Token = "0x4000079")]
	[FieldOffset(Offset = "0x20")]
	public SharedFloat LeaveRange;

	// Token: 0x0400007F RID: 127
	[Token(Token = "0x400007A")]
	[FieldOffset(Offset = "0x28")]
	public SharedFloat MoveSpeedScale;

	// Token: 0x04000080 RID: 128
	[Token(Token = "0x400007B")]
	[FieldOffset(Offset = "0x30")]
	public SharedMovementBehaviorType SharedMovementBehaviorType;
}
