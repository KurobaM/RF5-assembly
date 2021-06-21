using System;
using BehaviorDesigner.Runtime;
using Il2CppDummyDll;

// Token: 0x02000030 RID: 48
[Token(Token = "0x200002F")]
public class NPCMoveAttackRangeCommand : NPCActionBehaviorCommandBase
{
	// Token: 0x0600008B RID: 139 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600008B")]
	[Address(RVA = "0x1E1E980", Offset = "0x1E1EA81", VA = "0x1E1E980")]
	public NPCMoveAttackRangeCommand(NPCActionBehaviorController controller, ActionBehaviorCommandInformation info)
	{
	}

	// Token: 0x0600008C RID: 140 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600008C")]
	[Address(RVA = "0x1E22470", Offset = "0x1E22571", VA = "0x1E22470", Slot = "4")]
	public override void OnSetupParameter(BehaviorTree behaviorTree)
	{
	}

	// Token: 0x0600008D RID: 141 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600008D")]
	[Address(RVA = "0x1E226B0", Offset = "0x1E227B1", VA = "0x1E226B0", Slot = "5")]
	public override void OnExecute()
	{
	}

	// Token: 0x04000081 RID: 129
	[Token(Token = "0x400007C")]
	[FieldOffset(Offset = "0x28")]
	private SharedFloat MinAttackRange;

	// Token: 0x04000082 RID: 130
	[Token(Token = "0x400007D")]
	[FieldOffset(Offset = "0x30")]
	private SharedFloat MaxAttackRange;

	// Token: 0x04000083 RID: 131
	[Token(Token = "0x400007E")]
	[FieldOffset(Offset = "0x38")]
	private SharedFloat SphereCastHeight;

	// Token: 0x04000084 RID: 132
	[Token(Token = "0x400007F")]
	[FieldOffset(Offset = "0x40")]
	private SharedFloat SphereCastInterval;

	// Token: 0x04000085 RID: 133
	[Token(Token = "0x4000080")]
	[FieldOffset(Offset = "0x48")]
	public SharedFloat MoveSpeedScale;
}
