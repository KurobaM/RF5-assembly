using System;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

// Token: 0x0200011E RID: 286
[Token(Token = "0x20000E2")]
[Attribute(Name = "TaskCategoryAttribute", RVA = "0x144E00", Offset = "0x144F01")]
public class MonsterSetMoveAttackRange : BehaviorDesigner.Runtime.Tasks.Action
{
	// Token: 0x0600061A RID: 1562 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000536")]
	[Address(RVA = "0x1E71C80", Offset = "0x1E71D81", VA = "0x1E71C80", Slot = "4")]
	public override void OnAwake()
	{
	}

	// Token: 0x0600061B RID: 1563 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000537")]
	[Address(RVA = "0x1E71D40", Offset = "0x1E71E41", VA = "0x1E71D40", Slot = "5")]
	public override void OnStart()
	{
	}

	// Token: 0x0600061C RID: 1564 RVA: 0x00004368 File Offset: 0x00002568
	[Token(Token = "0x6000538")]
	[Address(RVA = "0x1E71DB0", Offset = "0x1E71EB1", VA = "0x1E71DB0", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x0600061D RID: 1565 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000539")]
	[Address(RVA = "0x1E71E50", Offset = "0x1E71F51", VA = "0x1E71E50")]
	public MonsterSetMoveAttackRange()
	{
	}

	// Token: 0x04000357 RID: 855
	[Token(Token = "0x40002A0")]
	[FieldOffset(Offset = "0x50")]
	public SharedFloat MinAttackRange;

	// Token: 0x04000358 RID: 856
	[Token(Token = "0x40002A1")]
	[FieldOffset(Offset = "0x58")]
	public SharedFloat MaxAttackRange;

	// Token: 0x04000359 RID: 857
	[Token(Token = "0x40002A2")]
	[FieldOffset(Offset = "0x60")]
	private MonsterBehaviorController MonsterBehaviorController;
}
