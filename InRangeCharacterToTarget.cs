using System;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

// Token: 0x02000124 RID: 292
[Token(Token = "0x20000E8")]
[Attribute(Name = "TaskCategoryAttribute", RVA = "0x144E80", Offset = "0x144F81")]
public class InRangeCharacterToTarget : Conditional
{
	// Token: 0x06000632 RID: 1586 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600054E")]
	[Address(RVA = "0x222C540", Offset = "0x222C641", VA = "0x222C540", Slot = "4")]
	public override void OnAwake()
	{
	}

	// Token: 0x06000633 RID: 1587 RVA: 0x00004410 File Offset: 0x00002610
	[Token(Token = "0x600054F")]
	[Address(RVA = "0x222C610", Offset = "0x222C711", VA = "0x222C610", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x06000634 RID: 1588 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000550")]
	[Address(RVA = "0x222C7C0", Offset = "0x222C8C1", VA = "0x222C7C0")]
	public InRangeCharacterToTarget()
	{
	}

	// Token: 0x04000374 RID: 884
	[Token(Token = "0x40002BD")]
	[FieldOffset(Offset = "0x50")]
	public SharedGameObject Target;

	// Token: 0x04000375 RID: 885
	[Token(Token = "0x40002BE")]
	[FieldOffset(Offset = "0x58")]
	public SharedFloat Range;

	// Token: 0x04000376 RID: 886
	[Token(Token = "0x40002BF")]
	[FieldOffset(Offset = "0x60")]
	private AIInput AIInput;
}
