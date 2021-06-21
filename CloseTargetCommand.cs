using System;
using BehaviorDesigner.Runtime;
using Il2CppDummyDll;

// Token: 0x02000028 RID: 40
[Token(Token = "0x2000027")]
public class CloseTargetCommand : ActionBehaviorCommandBase
{
	// Token: 0x06000077 RID: 119 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000077")]
	[Address(RVA = "0x1EA19F0", Offset = "0x1EA1AF1", VA = "0x1EA19F0")]
	public CloseTargetCommand(ActionBehaviorController controller, ActionBehaviorCommandInformation info)
	{
	}

	// Token: 0x06000078 RID: 120 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000078")]
	[Address(RVA = "0x1EA1A00", Offset = "0x1EA1B01", VA = "0x1EA1A00", Slot = "4")]
	public override void OnSetupParameter(BehaviorTree behaviorTree)
	{
	}

	// Token: 0x06000079 RID: 121 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000079")]
	[Address(RVA = "0x1EA1BC0", Offset = "0x1EA1CC1", VA = "0x1EA1BC0", Slot = "5")]
	public override void OnExecute()
	{
	}

	// Token: 0x0400007A RID: 122
	[Token(Token = "0x4000075")]
	[FieldOffset(Offset = "0x20")]
	public SharedMovementBehaviorType SharedMovementBehaviorType;

	// Token: 0x0400007B RID: 123
	[Token(Token = "0x4000076")]
	[FieldOffset(Offset = "0x28")]
	public SharedFloat MoveSpeedScale;

	// Token: 0x0400007C RID: 124
	[Token(Token = "0x4000077")]
	[FieldOffset(Offset = "0x30")]
	public SharedFloat CloseRange;
}
