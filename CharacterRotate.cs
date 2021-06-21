using System;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000115 RID: 277
[Token(Token = "0x20000D9")]
[Attribute(Name = "TaskCategoryAttribute", RVA = "0x144D40", Offset = "0x144E41")]
public class CharacterRotate : BehaviorDesigner.Runtime.Tasks.Action
{
	// Token: 0x060005F8 RID: 1528 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000514")]
	[Address(RVA = "0x1E963B0", Offset = "0x1E964B1", VA = "0x1E963B0", Slot = "4")]
	public override void OnAwake()
	{
	}

	// Token: 0x060005F9 RID: 1529 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000515")]
	[Address(RVA = "0x1E96480", Offset = "0x1E96581", VA = "0x1E96480", Slot = "5")]
	public override void OnStart()
	{
	}

	// Token: 0x060005FA RID: 1530 RVA: 0x00004278 File Offset: 0x00002478
	[Token(Token = "0x6000516")]
	[Address(RVA = "0x1E96850", Offset = "0x1E96951", VA = "0x1E96850", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x060005FB RID: 1531 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000517")]
	[Address(RVA = "0x1E96A10", Offset = "0x1E96B11", VA = "0x1E96A10", Slot = "9")]
	public override void OnEnd()
	{
	}

	// Token: 0x060005FC RID: 1532 RVA: 0x00004290 File Offset: 0x00002490
	[Token(Token = "0x6000518")]
	[Address(RVA = "0x1E966A0", Offset = "0x1E967A1", VA = "0x1E966A0")]
	private Quaternion Target()
	{
		return default(Quaternion);
	}

	// Token: 0x060005FD RID: 1533 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000519")]
	[Address(RVA = "0x1E96B70", Offset = "0x1E96C71", VA = "0x1E96B70")]
	public CharacterRotate()
	{
	}

	// Token: 0x04000341 RID: 833
	[Token(Token = "0x400028A")]
	[FieldOffset(Offset = "0x50")]
	public SharedFloat rotationEpsilon;

	// Token: 0x04000342 RID: 834
	[Token(Token = "0x400028B")]
	[FieldOffset(Offset = "0x58")]
	public SharedGameObject target;

	// Token: 0x04000343 RID: 835
	[Token(Token = "0x400028C")]
	[FieldOffset(Offset = "0x60")]
	public SharedVector3 targetPosition;

	// Token: 0x04000344 RID: 836
	[Token(Token = "0x400028D")]
	[FieldOffset(Offset = "0x68")]
	public bool UseRotateAnimation;

	// Token: 0x04000345 RID: 837
	[Token(Token = "0x400028E")]
	[FieldOffset(Offset = "0x70")]
	private AIInput AIInput;

	// Token: 0x04000346 RID: 838
	[Token(Token = "0x400028F")]
	[FieldOffset(Offset = "0x78")]
	private bool IsHoldRotateAnimation;
}
