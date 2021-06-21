using System;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

// Token: 0x02000149 RID: 329
[Token(Token = "0x20000FD")]
[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1452C0", Offset = "0x1453C1")]
public class EndChangeAnimatorState : BehaviorDesigner.Runtime.Tasks.Action
{
	// Token: 0x06000704 RID: 1796 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005E3")]
	[Address(RVA = "0x22B1B70", Offset = "0x22B1C71", VA = "0x22B1B70", Slot = "4")]
	public override void OnAwake()
	{
	}

	// Token: 0x06000705 RID: 1797 RVA: 0x000047E8 File Offset: 0x000029E8
	[Token(Token = "0x60005E4")]
	[Address(RVA = "0x22B1C40", Offset = "0x22B1D41", VA = "0x22B1C40", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x06000706 RID: 1798 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005E5")]
	[Address(RVA = "0x22B1C50", Offset = "0x22B1D51", VA = "0x22B1C50", Slot = "9")]
	public override void OnEnd()
	{
	}

	// Token: 0x06000707 RID: 1799 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005E6")]
	[Address(RVA = "0x22B1DA0", Offset = "0x22B1EA1", VA = "0x22B1DA0")]
	public EndChangeAnimatorState()
	{
	}

	// Token: 0x040003FF RID: 1023
	[Token(Token = "0x400030A")]
	[FieldOffset(Offset = "0x50")]
	public SharedInt StateLayerIndex;

	// Token: 0x04000400 RID: 1024
	[Token(Token = "0x400030B")]
	[FieldOffset(Offset = "0x58")]
	public SharedString AnimationStateName;

	// Token: 0x04000401 RID: 1025
	[Token(Token = "0x400030C")]
	[FieldOffset(Offset = "0x60")]
	public SharedFloat ClossFadeTime;

	// Token: 0x04000402 RID: 1026
	[Token(Token = "0x400030D")]
	[FieldOffset(Offset = "0x68")]
	private AIInput AIInput;
}
