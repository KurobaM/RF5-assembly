using System;
using BehaviorDesigner.Runtime;
using Il2CppDummyDll;

// Token: 0x02000037 RID: 55
[Token(Token = "0x2000036")]
public class WeaponChargeAttackCommand : NPCActionBehaviorCommandBase
{
	// Token: 0x060000A0 RID: 160 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x1E50B80", Offset = "0x1E50C81", VA = "0x1E50B80")]
	public WeaponChargeAttackCommand(NPCActionBehaviorController controller, ActionBehaviorCommandInformation info)
	{
	}

	// Token: 0x060000A1 RID: 161 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x1E50B90", Offset = "0x1E50C91", VA = "0x1E50B90", Slot = "4")]
	public override void OnSetupParameter(BehaviorTree behaviorTree)
	{
	}

	// Token: 0x060000A2 RID: 162 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x1E50C50", Offset = "0x1E50D51", VA = "0x1E50C50", Slot = "5")]
	public override void OnExecute()
	{
	}

	// Token: 0x0400008A RID: 138
	[Token(Token = "0x4000085")]
	[FieldOffset(Offset = "0x28")]
	private SharedToolChargeLevel ToolChargeLevel;
}
