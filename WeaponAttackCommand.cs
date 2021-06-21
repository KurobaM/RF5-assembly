using System;
using BehaviorDesigner.Runtime;
using Il2CppDummyDll;

// Token: 0x02000036 RID: 54
[Token(Token = "0x2000035")]
public class WeaponAttackCommand : NPCActionBehaviorCommandBase
{
	// Token: 0x0600009D RID: 157 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600009D")]
	[Address(RVA = "0x1E509F0", Offset = "0x1E50AF1", VA = "0x1E509F0")]
	public WeaponAttackCommand(NPCActionBehaviorController controller, ActionBehaviorCommandInformation info)
	{
	}

	// Token: 0x0600009E RID: 158 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600009E")]
	[Address(RVA = "0x1E50A00", Offset = "0x1E50B01", VA = "0x1E50A00", Slot = "4")]
	public override void OnSetupParameter(BehaviorTree behaviorTree)
	{
	}

	// Token: 0x0600009F RID: 159 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600009F")]
	[Address(RVA = "0x1E50AC0", Offset = "0x1E50BC1", VA = "0x1E50AC0", Slot = "5")]
	public override void OnExecute()
	{
	}

	// Token: 0x04000089 RID: 137
	[Token(Token = "0x4000084")]
	[FieldOffset(Offset = "0x28")]
	private SharedInt WeaponComboCount;
}
