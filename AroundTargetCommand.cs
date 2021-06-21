using System;
using BehaviorDesigner.Runtime;
using Il2CppDummyDll;

// Token: 0x02000027 RID: 39
[Token(Token = "0x2000026")]
public class AroundTargetCommand : ActionBehaviorCommandBase
{
	// Token: 0x06000074 RID: 116 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000074")]
	[Address(RVA = "0x2443A10", Offset = "0x2443B11", VA = "0x2443A10")]
	public AroundTargetCommand(ActionBehaviorController controller, ActionBehaviorCommandInformation info)
	{
	}

	// Token: 0x06000075 RID: 117 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000075")]
	[Address(RVA = "0x2443A20", Offset = "0x2443B21", VA = "0x2443A20", Slot = "4")]
	public override void OnSetupParameter(BehaviorTree behaviorTree)
	{
	}

	// Token: 0x06000076 RID: 118 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000076")]
	[Address(RVA = "0x2443C30", Offset = "0x2443D31", VA = "0x2443C30", Slot = "5")]
	public override void OnExecute()
	{
	}

	// Token: 0x04000076 RID: 118
	[Token(Token = "0x4000071")]
	[FieldOffset(Offset = "0x20")]
	public SharedFloat MoveAroundRange;

	// Token: 0x04000077 RID: 119
	[Token(Token = "0x4000072")]
	[FieldOffset(Offset = "0x28")]
	public SharedFloat MoveAroundAngle;

	// Token: 0x04000078 RID: 120
	[Token(Token = "0x4000073")]
	[FieldOffset(Offset = "0x30")]
	public SharedFloat MoveSpeedScale;

	// Token: 0x04000079 RID: 121
	[Token(Token = "0x4000074")]
	[FieldOffset(Offset = "0x38")]
	public SharedMovementBehaviorType SharedMovementBehaviorType;
}
