using System;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

// Token: 0x02000122 RID: 290
[Token(Token = "0x20000E6")]
public class PartnerMonsterUpdateAttackAction : BehaviorDesigner.Runtime.Tasks.Action
{
	// Token: 0x0600062C RID: 1580 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000548")]
	[Address(RVA = "0x2329090", Offset = "0x2329191", VA = "0x2329090", Slot = "5")]
	public override void OnStart()
	{
	}

	// Token: 0x0600062D RID: 1581 RVA: 0x000043E0 File Offset: 0x000025E0
	[Token(Token = "0x6000549")]
	[Address(RVA = "0x2329100", Offset = "0x2329201", VA = "0x2329100", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x0600062E RID: 1582 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600054A")]
	[Address(RVA = "0x23294E0", Offset = "0x23295E1", VA = "0x23294E0")]
	public PartnerMonsterUpdateAttackAction()
	{
	}

	// Token: 0x0400036C RID: 876
	[Token(Token = "0x40002B5")]
	[FieldOffset(Offset = "0x50")]
	public SharedPartnerMonsterBehaviorController SharedPartnerMonsterBehaviorController;

	// Token: 0x0400036D RID: 877
	[Token(Token = "0x40002B6")]
	[FieldOffset(Offset = "0x58")]
	public SharedGameObject Target;

	// Token: 0x0400036E RID: 878
	[Token(Token = "0x40002B7")]
	[FieldOffset(Offset = "0x60")]
	public SharedMovementBehaviorType ReturnReadyToAttackBehaviorType;

	// Token: 0x0400036F RID: 879
	[Token(Token = "0x40002B8")]
	[FieldOffset(Offset = "0x68")]
	public SharedFloat ReturnMoveSpeedScale;

	// Token: 0x04000370 RID: 880
	[Token(Token = "0x40002B9")]
	[FieldOffset(Offset = "0x70")]
	public SharedFloat ReturnLeaveRange;
}
