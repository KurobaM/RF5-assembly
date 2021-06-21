using System;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000147 RID: 327
[Token(Token = "0x20000FB")]
[Attribute(Name = "TaskCategoryAttribute", RVA = "0x145240", Offset = "0x145341")]
public class CharacterRotateTowards : BehaviorDesigner.Runtime.Tasks.Action
{
	// Token: 0x060006FB RID: 1787 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005DA")]
	[Address(RVA = "0x1E96BC0", Offset = "0x1E96CC1", VA = "0x1E96BC0", Slot = "4")]
	public override void OnAwake()
	{
	}

	// Token: 0x060006FC RID: 1788 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005DB")]
	[Address(RVA = "0x1E96C90", Offset = "0x1E96D91", VA = "0x1E96C90", Slot = "5")]
	public override void OnStart()
	{
	}

	// Token: 0x060006FD RID: 1789 RVA: 0x000047A0 File Offset: 0x000029A0
	[Token(Token = "0x60005DC")]
	[Address(RVA = "0x1E96CA0", Offset = "0x1E96DA1", VA = "0x1E96CA0", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x060006FE RID: 1790 RVA: 0x000047B8 File Offset: 0x000029B8
	[Token(Token = "0x60005DD")]
	[Address(RVA = "0x1E96E80", Offset = "0x1E96F81", VA = "0x1E96E80")]
	private Quaternion Target()
	{
		return default(Quaternion);
	}

	// Token: 0x060006FF RID: 1791 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005DE")]
	[Address(RVA = "0x1E970B0", Offset = "0x1E971B1", VA = "0x1E970B0")]
	public CharacterRotateTowards()
	{
	}

	// Token: 0x040003F7 RID: 1015
	[Token(Token = "0x4000302")]
	[FieldOffset(Offset = "0x50")]
	private AIInput AIInput;

	// Token: 0x040003F8 RID: 1016
	[Token(Token = "0x4000303")]
	[FieldOffset(Offset = "0x58")]
	public SharedFloat rotationEpsilon;

	// Token: 0x040003F9 RID: 1017
	[Token(Token = "0x4000304")]
	[FieldOffset(Offset = "0x60")]
	public SharedFloat maxLookAtRotationDelta;

	// Token: 0x040003FA RID: 1018
	[Token(Token = "0x4000305")]
	[FieldOffset(Offset = "0x68")]
	public SharedBool onlyY;

	// Token: 0x040003FB RID: 1019
	[Token(Token = "0x4000306")]
	[FieldOffset(Offset = "0x70")]
	public SharedGameObject target;

	// Token: 0x040003FC RID: 1020
	[Token(Token = "0x4000307")]
	[FieldOffset(Offset = "0x78")]
	public SharedVector3 targetRotation;
}
