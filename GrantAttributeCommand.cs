using System;
using BehaviorDesigner.Runtime;
using Il2CppDummyDll;

// Token: 0x02000032 RID: 50
[Token(Token = "0x2000031")]
public class GrantAttributeCommand : NPCActionBehaviorCommandBase
{
	// Token: 0x06000091 RID: 145 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000091")]
	[Address(RVA = "0x1FF4100", Offset = "0x1FF4201", VA = "0x1FF4100")]
	public GrantAttributeCommand(NPCActionBehaviorController controller, ActionBehaviorCommandInformation info)
	{
	}

	// Token: 0x06000092 RID: 146 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000092")]
	[Address(RVA = "0x1FF4110", Offset = "0x1FF4211", VA = "0x1FF4110", Slot = "4")]
	public override void OnSetupParameter(BehaviorTree behaviorTree)
	{
	}

	// Token: 0x06000093 RID: 147 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000093")]
	[Address(RVA = "0x1FF4230", Offset = "0x1FF4331", VA = "0x1FF4230", Slot = "5")]
	public override void OnExecute()
	{
	}

	// Token: 0x04000087 RID: 135
	[Token(Token = "0x4000082")]
	[FieldOffset(Offset = "0x28")]
	private SharedAttackAttribute SharedAttackAttribute;

	// Token: 0x04000088 RID: 136
	[Token(Token = "0x4000083")]
	[FieldOffset(Offset = "0x30")]
	private SharedFloat Duration;
}
