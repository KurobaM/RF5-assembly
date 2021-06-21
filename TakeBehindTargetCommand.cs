using System;
using BehaviorDesigner.Runtime;
using Il2CppDummyDll;

// Token: 0x02000038 RID: 56
[Token(Token = "0x2000037")]
public class TakeBehindTargetCommand : ActionBehaviorCommandBase
{
	// Token: 0x060000A3 RID: 163 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x1FC0AA0", Offset = "0x1FC0BA1", VA = "0x1FC0AA0")]
	public TakeBehindTargetCommand(ActionBehaviorController controller, ActionBehaviorCommandInformation info)
	{
	}

	// Token: 0x060000A4 RID: 164 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x1FC0AB0", Offset = "0x1FC0BB1", VA = "0x1FC0AB0", Slot = "4")]
	public override void OnSetupParameter(BehaviorTree behaviorTree)
	{
	}

	// Token: 0x060000A5 RID: 165 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x1FC0C50", Offset = "0x1FC0D51", VA = "0x1FC0C50", Slot = "5")]
	public override void OnExecute()
	{
	}

	// Token: 0x0400008B RID: 139
	[Token(Token = "0x4000086")]
	[FieldOffset(Offset = "0x20")]
	public SharedFloat TakebehindRange;

	// Token: 0x0400008C RID: 140
	[Token(Token = "0x4000087")]
	[FieldOffset(Offset = "0x28")]
	public SharedFloat MoveSpeedScale;

	// Token: 0x0400008D RID: 141
	[Token(Token = "0x4000088")]
	[FieldOffset(Offset = "0x30")]
	public SharedMovementBehaviorType SharedMovementBehaviorType;
}
