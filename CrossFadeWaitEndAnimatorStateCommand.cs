using System;
using BehaviorDesigner.Runtime;
using Il2CppDummyDll;

// Token: 0x02000029 RID: 41
[Token(Token = "0x2000028")]
public class CrossFadeWaitEndAnimatorStateCommand : ActionBehaviorCommandBase
{
	// Token: 0x0600007A RID: 122 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600007A")]
	[Address(RVA = "0x20EA930", Offset = "0x20EAA31", VA = "0x20EA930")]
	public CrossFadeWaitEndAnimatorStateCommand(ActionBehaviorController controller, ActionBehaviorCommandInformation info)
	{
	}

	// Token: 0x0600007B RID: 123 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600007B")]
	[Address(RVA = "0x20EA940", Offset = "0x20EAA41", VA = "0x20EA940", Slot = "4")]
	public override void OnSetupParameter(BehaviorTree behaviorTree)
	{
	}

	// Token: 0x0600007C RID: 124 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600007C")]
	[Address(RVA = "0x20EAA20", Offset = "0x20EAB21", VA = "0x20EAA20", Slot = "5")]
	public override void OnExecute()
	{
	}

	// Token: 0x0400007D RID: 125
	[Token(Token = "0x4000078")]
	[FieldOffset(Offset = "0x20")]
	private SharedString CrossFadeAnimatorStateName;
}
