using System;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using Define;
using Il2CppDummyDll;

// Token: 0x02000126 RID: 294
[Token(Token = "0x20000EA")]
[Attribute(Name = "TaskCategoryAttribute", RVA = "0x144EC0", Offset = "0x144FC1")]
public class PartnerNPCChargeAttack : BehaviorDesigner.Runtime.Tasks.Action
{
	// Token: 0x17000164 RID: 356
	// (get) Token: 0x06000639 RID: 1593 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700015E")]
	private PartnerNPCController PartnerNPCController
	{
		[Token(Token = "0x6000555")]
		[Address(RVA = "0x2135EF0", Offset = "0x2135FF1", VA = "0x2135EF0")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600063A RID: 1594 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000556")]
	[Address(RVA = "0x2135F50", Offset = "0x2136051", VA = "0x2135F50", Slot = "5")]
	public override void OnStart()
	{
	}

	// Token: 0x0600063B RID: 1595 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000557")]
	[Address(RVA = "0x21366A0", Offset = "0x21367A1", VA = "0x21366A0", Slot = "9")]
	public override void OnEnd()
	{
	}

	// Token: 0x0600063C RID: 1596 RVA: 0x00004440 File Offset: 0x00002640
	[Token(Token = "0x6000558")]
	[Address(RVA = "0x2136720", Offset = "0x2136821", VA = "0x2136720", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x0600063D RID: 1597 RVA: 0x00004458 File Offset: 0x00002658
	[Token(Token = "0x6000559")]
	[Address(RVA = "0x2136BC0", Offset = "0x2136CC1", VA = "0x2136BC0")]
	public bool CheckTarget()
	{
		return default(bool);
	}

	// Token: 0x0600063E RID: 1598 RVA: 0x00004470 File Offset: 0x00002670
	[Token(Token = "0x600055A")]
	[Address(RVA = "0x2136560", Offset = "0x2136661", VA = "0x2136560")]
	public bool JudgeContinue()
	{
		return default(bool);
	}

	// Token: 0x0600063F RID: 1599 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600055B")]
	[Address(RVA = "0x2136DB0", Offset = "0x2136EB1", VA = "0x2136DB0")]
	public PartnerNPCChargeAttack()
	{
	}

	// Token: 0x04000379 RID: 889
	[Token(Token = "0x40002C2")]
	[FieldOffset(Offset = "0x50")]
	public SharedPartnerNPCBehaviorController SharedPartnerBehaviorController;

	// Token: 0x0400037A RID: 890
	[Token(Token = "0x40002C3")]
	[FieldOffset(Offset = "0x58")]
	public SharedGameObject Target;

	// Token: 0x0400037B RID: 891
	[Token(Token = "0x40002C4")]
	[FieldOffset(Offset = "0x60")]
	public SharedToolChargeLevel ChargeLevel;

	// Token: 0x0400037C RID: 892
	[Token(Token = "0x40002C5")]
	[FieldOffset(Offset = "0x68")]
	public SharedFloat MaxWeaponRange;

	// Token: 0x0400037D RID: 893
	[Token(Token = "0x40002C6")]
	[FieldOffset(Offset = "0x70")]
	public SharedBool IsArrivedChargeRange;

	// Token: 0x0400037E RID: 894
	[Token(Token = "0x40002C7")]
	[FieldOffset(Offset = "0x78")]
	public SharedBool SharedIsMoveChargeAttackRange;

	// Token: 0x0400037F RID: 895
	[Token(Token = "0x40002C8")]
	[FieldOffset(Offset = "0x80")]
	private TaskStatus CurrentTaskStatus;

	// Token: 0x04000380 RID: 896
	[Token(Token = "0x40002C9")]
	[FieldOffset(Offset = "0x84")]
	private ToolChargeLevel DoActionChargeLevel;

	// Token: 0x04000381 RID: 897
	[Token(Token = "0x40002CA")]
	[FieldOffset(Offset = "0x88")]
	private bool IsChargeStart;
}
