using System;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

// Token: 0x02000116 RID: 278
[Token(Token = "0x20000DA")]
[Attribute(Name = "TaskCategoryAttribute", RVA = "0x144D80", Offset = "0x144E81")]
public class EnemySetReturnPatrolPoint : BehaviorDesigner.Runtime.Tasks.Action
{
	// Token: 0x060005FE RID: 1534 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600051A")]
	[Address(RVA = "0x22B4600", Offset = "0x22B4701", VA = "0x22B4600", Slot = "4")]
	public override void OnAwake()
	{
	}

	// Token: 0x060005FF RID: 1535 RVA: 0x000042A8 File Offset: 0x000024A8
	[Token(Token = "0x600051B")]
	[Address(RVA = "0x22B46D0", Offset = "0x22B47D1", VA = "0x22B46D0", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x06000600 RID: 1536 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600051C")]
	[Address(RVA = "0x22B4760", Offset = "0x22B4861", VA = "0x22B4760")]
	public EnemySetReturnPatrolPoint()
	{
	}

	// Token: 0x04000347 RID: 839
	[Token(Token = "0x4000290")]
	[FieldOffset(Offset = "0x50")]
	private EnemyBehaviorController Controller;

	// Token: 0x04000348 RID: 840
	[Token(Token = "0x4000291")]
	[FieldOffset(Offset = "0x58")]
	public SharedFloat MoveSpeedScale;

	// Token: 0x04000349 RID: 841
	[Token(Token = "0x4000292")]
	[FieldOffset(Offset = "0x60")]
	public SharedVector3 TargetPosition;
}
