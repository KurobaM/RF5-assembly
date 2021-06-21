using System;
using BehaviorDesigner.Runtime;
using Il2CppDummyDll;

// Token: 0x02000031 RID: 49
[Token(Token = "0x2000030")]
public class CounterAttackCommand : NPCActionBehaviorCommandBase
{
	// Token: 0x0600008E RID: 142 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600008E")]
	[Address(RVA = "0x20E2100", Offset = "0x20E2201", VA = "0x20E2100")]
	public CounterAttackCommand(NPCActionBehaviorController controller, ActionBehaviorCommandInformation info)
	{
	}

	// Token: 0x0600008F RID: 143 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600008F")]
	[Address(RVA = "0x20E2110", Offset = "0x20E2211", VA = "0x20E2110", Slot = "4")]
	public override void OnSetupParameter(BehaviorTree behaviorTree)
	{
	}

	// Token: 0x06000090 RID: 144 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000090")]
	[Address(RVA = "0x20E21D0", Offset = "0x20E22D1", VA = "0x20E21D0", Slot = "5")]
	public override void OnExecute()
	{
	}

	// Token: 0x04000086 RID: 134
	[Token(Token = "0x4000081")]
	[FieldOffset(Offset = "0x28")]
	private SharedBool CanUseCounter;
}
