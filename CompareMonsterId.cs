using System;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

// Token: 0x0200011A RID: 282
[Token(Token = "0x20000DE")]
public class CompareMonsterId : Conditional
{
	// Token: 0x0600060B RID: 1547 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000527")]
	[Address(RVA = "0x20DCA60", Offset = "0x20DCB61", VA = "0x20DCA60", Slot = "5")]
	public override void OnStart()
	{
	}

	// Token: 0x0600060C RID: 1548 RVA: 0x00004308 File Offset: 0x00002508
	[Token(Token = "0x6000528")]
	[Address(RVA = "0x20DCB30", Offset = "0x20DCC31", VA = "0x20DCB30", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x0600060D RID: 1549 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000529")]
	[Address(RVA = "0x20DCBF0", Offset = "0x20DCCF1", VA = "0x20DCBF0")]
	public CompareMonsterId()
	{
	}

	// Token: 0x0400034F RID: 847
	[Token(Token = "0x4000298")]
	[FieldOffset(Offset = "0x50")]
	private MonsterControllerBase Monster;

	// Token: 0x04000350 RID: 848
	[Token(Token = "0x4000299")]
	[FieldOffset(Offset = "0x58")]
	public MonsterID CompareId;
}
