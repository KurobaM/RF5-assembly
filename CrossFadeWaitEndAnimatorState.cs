using System;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

// Token: 0x02000153 RID: 339
[Token(Token = "0x2000107")]
[Attribute(Name = "TaskCategoryAttribute", RVA = "0x145440", Offset = "0x145541")]
public class CrossFadeWaitEndAnimatorState : BehaviorDesigner.Runtime.Tasks.Action
{
	// Token: 0x0600072D RID: 1837 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600060C")]
	[Address(RVA = "0x20EA4F0", Offset = "0x20EA5F1", VA = "0x20EA4F0", Slot = "4")]
	public override void OnAwake()
	{
	}

	// Token: 0x0600072E RID: 1838 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600060D")]
	[Address(RVA = "0x20EA5C0", Offset = "0x20EA6C1", VA = "0x20EA5C0", Slot = "5")]
	public override void OnStart()
	{
	}

	// Token: 0x0600072F RID: 1839 RVA: 0x000048F0 File Offset: 0x00002AF0
	[Token(Token = "0x600060E")]
	[Address(RVA = "0x20EA6A0", Offset = "0x20EA7A1", VA = "0x20EA6A0", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x06000730 RID: 1840 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600060F")]
	[Address(RVA = "0x20EA880", Offset = "0x20EA981", VA = "0x20EA880")]
	public CrossFadeWaitEndAnimatorState()
	{
	}

	// Token: 0x04000416 RID: 1046
	[Token(Token = "0x4000321")]
	[FieldOffset(Offset = "0x50")]
	public SharedInt StateLayerIndex;

	// Token: 0x04000417 RID: 1047
	[Token(Token = "0x4000322")]
	[FieldOffset(Offset = "0x58")]
	public SharedString AnimationStateName;

	// Token: 0x04000418 RID: 1048
	[Token(Token = "0x4000323")]
	[FieldOffset(Offset = "0x60")]
	public SharedFloat ClossFadeTime;

	// Token: 0x04000419 RID: 1049
	[Token(Token = "0x4000324")]
	[FieldOffset(Offset = "0x68")]
	private AIInput AIInput;

	// Token: 0x0400041A RID: 1050
	[Token(Token = "0x4000325")]
	[FieldOffset(Offset = "0x70")]
	private int NameHash;

	// Token: 0x0400041B RID: 1051
	[Token(Token = "0x4000326")]
	[FieldOffset(Offset = "0x74")]
	private bool isWaitOneFrame;

	// Token: 0x0400041C RID: 1052
	[Token(Token = "0x4000327")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string StateLayerIndexKeyName;

	// Token: 0x0400041D RID: 1053
	[Token(Token = "0x4000328")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string CrossFadeAnimatorStateKeyName;

	// Token: 0x0400041E RID: 1054
	[Token(Token = "0x4000329")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string CrossFadeTimeKeyName;
}
