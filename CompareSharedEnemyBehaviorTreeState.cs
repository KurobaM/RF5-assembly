using System;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

// Token: 0x02000157 RID: 343
[Token(Token = "0x200010B")]
[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1454C0", Offset = "0x1455C1")]
public class CompareSharedEnemyBehaviorTreeState : Conditional
{
	// Token: 0x0600073A RID: 1850 RVA: 0x00004950 File Offset: 0x00002B50
	[Token(Token = "0x6000619")]
	[Address(RVA = "0x20DCD30", Offset = "0x20DCE31", VA = "0x20DCD30", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x0600073B RID: 1851 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600061A")]
	[Address(RVA = "0x20DCDC0", Offset = "0x20DCEC1", VA = "0x20DCDC0", Slot = "16")]
	public override void OnReset()
	{
	}

	// Token: 0x0600073C RID: 1852 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600061B")]
	[Address(RVA = "0x20DCE00", Offset = "0x20DCF01", VA = "0x20DCE00")]
	public CompareSharedEnemyBehaviorTreeState()
	{
	}

	// Token: 0x04000422 RID: 1058
	[Token(Token = "0x400032D")]
	[FieldOffset(Offset = "0x50")]
	public SharedEnemyBehaviorTreeState variable;

	// Token: 0x04000423 RID: 1059
	[Token(Token = "0x400032E")]
	[FieldOffset(Offset = "0x58")]
	public SharedEnemyBehaviorTreeState compareTo;
}
