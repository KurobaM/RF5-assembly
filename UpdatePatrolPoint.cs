using System;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

// Token: 0x02000117 RID: 279
[Token(Token = "0x20000DB")]
[Attribute(Name = "TaskCategoryAttribute", RVA = "0x144DC0", Offset = "0x144EC1")]
public class UpdatePatrolPoint : BehaviorDesigner.Runtime.Tasks.Action
{
	// Token: 0x06000601 RID: 1537 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600051D")]
	[Address(RVA = "0x1E46660", Offset = "0x1E46761", VA = "0x1E46660", Slot = "4")]
	public override void OnAwake()
	{
	}

	// Token: 0x06000602 RID: 1538 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600051E")]
	[Address(RVA = "0x1E46730", Offset = "0x1E46831", VA = "0x1E46730", Slot = "5")]
	public override void OnStart()
	{
	}

	// Token: 0x06000603 RID: 1539 RVA: 0x000042C0 File Offset: 0x000024C0
	[Token(Token = "0x600051F")]
	[Address(RVA = "0x1E467A0", Offset = "0x1E468A1", VA = "0x1E467A0", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x06000604 RID: 1540 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000520")]
	[Address(RVA = "0x1E46850", Offset = "0x1E46951", VA = "0x1E46850")]
	public UpdatePatrolPoint()
	{
	}

	// Token: 0x0400034A RID: 842
	[Token(Token = "0x4000293")]
	[FieldOffset(Offset = "0x50")]
	private EnemyBehaviorController Controller;

	// Token: 0x0400034B RID: 843
	[Token(Token = "0x4000294")]
	[FieldOffset(Offset = "0x58")]
	public SharedBool IsMoveEnd;

	// Token: 0x0400034C RID: 844
	[Token(Token = "0x4000295")]
	[FieldOffset(Offset = "0x60")]
	public SharedVector3 ReturnPatrolPoint;
}
