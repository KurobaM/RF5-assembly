using System;
using BehaviorDesigner.Runtime;
using Il2CppDummyDll;

// Token: 0x02000039 RID: 57
[Token(Token = "0x2000038")]
public class TargetDirectionMoveCommand : ActionBehaviorCommandBase
{
	// Token: 0x060000A6 RID: 166 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x1FC3210", Offset = "0x1FC3311", VA = "0x1FC3210")]
	public TargetDirectionMoveCommand(ActionBehaviorController controller, ActionBehaviorCommandInformation info)
	{
	}

	// Token: 0x060000A7 RID: 167 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x1FC3220", Offset = "0x1FC3321", VA = "0x1FC3220", Slot = "4")]
	public override void OnSetupParameter(BehaviorTree behaviorTree)
	{
	}

	// Token: 0x060000A8 RID: 168 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x1FC3420", Offset = "0x1FC3521", VA = "0x1FC3420", Slot = "5")]
	public override void OnExecute()
	{
	}

	// Token: 0x0400008E RID: 142
	[Token(Token = "0x4000089")]
	[FieldOffset(Offset = "0x20")]
	public SharedGameObject Target;

	// Token: 0x0400008F RID: 143
	[Token(Token = "0x400008A")]
	[FieldOffset(Offset = "0x28")]
	public SharedVector3 MovePosition;

	// Token: 0x04000090 RID: 144
	[Token(Token = "0x400008B")]
	[FieldOffset(Offset = "0x30")]
	public SharedFloat MoveSpeedScale;

	// Token: 0x04000091 RID: 145
	[Token(Token = "0x400008C")]
	[FieldOffset(Offset = "0x38")]
	public SharedMovementBehaviorType SharedMovementBehaviorType;
}
