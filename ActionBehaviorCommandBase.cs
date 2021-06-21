using System;
using BehaviorDesigner.Runtime;
using Il2CppDummyDll;

// Token: 0x02000024 RID: 36
[Token(Token = "0x2000023")]
public abstract class ActionBehaviorCommandBase
{
	// Token: 0x0600006E RID: 110 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600006E")]
	[Address(RVA = "0x1FD4930", Offset = "0x1FD4A31", VA = "0x1FD4930")]
	public ActionBehaviorCommandBase(ActionBehaviorController controller, ActionBehaviorCommandInformation info)
	{
	}

	// Token: 0x0600006F RID: 111 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600006F")]
	[Address(RVA = "0x1FD4980", Offset = "0x1FD4A81", VA = "0x1FD4980", Slot = "4")]
	public virtual void OnSetupParameter(BehaviorTree behaviorTree)
	{
	}

	// Token: 0x06000070 RID: 112 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000070")]
	[Address(RVA = "0x1FD4990", Offset = "0x1FD4A91", VA = "0x1FD4990", Slot = "5")]
	public virtual void OnExecute()
	{
	}

	// Token: 0x04000072 RID: 114
	[Token(Token = "0x400006D")]
	[FieldOffset(Offset = "0x10")]
	protected ActionBehaviorController Controller;

	// Token: 0x04000073 RID: 115
	[Token(Token = "0x400006E")]
	[FieldOffset(Offset = "0x18")]
	protected ActionBehaviorCommandInformation Info;
}
