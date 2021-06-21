using System;
using BehaviorDesigner.Runtime;
using Il2CppDummyDll;

// Token: 0x0200003A RID: 58
[Token(Token = "0x2000039")]
public class WaitCommand : ActionBehaviorCommandBase
{
	// Token: 0x060000A9 RID: 169 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x1E4BA80", Offset = "0x1E4BB81", VA = "0x1E4BA80")]
	public WaitCommand(ActionBehaviorController controller, ActionBehaviorCommandInformation info, float timeRate = 1f)
	{
	}

	// Token: 0x060000AA RID: 170 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x1E4BAC0", Offset = "0x1E4BBC1", VA = "0x1E4BAC0", Slot = "4")]
	public override void OnSetupParameter(BehaviorTree behaviorTree)
	{
	}

	// Token: 0x060000AB RID: 171 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x1E4BCC0", Offset = "0x1E4BDC1", VA = "0x1E4BCC0", Slot = "5")]
	public override void OnExecute()
	{
	}

	// Token: 0x04000092 RID: 146
	[Token(Token = "0x400008D")]
	[FieldOffset(Offset = "0x20")]
	public SharedMovementBehaviorType SharedMovementBehaviorType;

	// Token: 0x04000093 RID: 147
	[Token(Token = "0x400008E")]
	[FieldOffset(Offset = "0x28")]
	public SharedFloat MaxWaitInterval;

	// Token: 0x04000094 RID: 148
	[Token(Token = "0x400008F")]
	[FieldOffset(Offset = "0x30")]
	public SharedFloat MinWaitInterval;

	// Token: 0x04000095 RID: 149
	[Token(Token = "0x4000090")]
	[FieldOffset(Offset = "0x38")]
	public SharedBool IsReleseEyes;

	// Token: 0x04000096 RID: 150
	[Token(Token = "0x4000091")]
	[FieldOffset(Offset = "0x40")]
	public float TimeRate;
}
