using System;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000132 RID: 306
[Token(Token = "0x20000F6")]
[Attribute(Name = "TaskCategoryAttribute", RVA = "0x145140", Offset = "0x145241")]
public class SetRotateAroundPosition : BehaviorDesigner.Runtime.Tasks.Action
{
	// Token: 0x06000670 RID: 1648 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600058C")]
	[Address(RVA = "0x1E34F30", Offset = "0x1E35031", VA = "0x1E34F30", Slot = "4")]
	public override void OnAwake()
	{
	}

	// Token: 0x06000671 RID: 1649 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600058D")]
	[Address(RVA = "0x1E35000", Offset = "0x1E35101", VA = "0x1E35000", Slot = "5")]
	public override void OnStart()
	{
	}

	// Token: 0x06000672 RID: 1650 RVA: 0x00004620 File Offset: 0x00002820
	[Token(Token = "0x600058E")]
	[Address(RVA = "0x1E35010", Offset = "0x1E35111", VA = "0x1E35010", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x06000673 RID: 1651 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600058F")]
	[Address(RVA = "0x1E351C0", Offset = "0x1E352C1", VA = "0x1E351C0")]
	public SetRotateAroundPosition()
	{
	}

	// Token: 0x0400039E RID: 926
	[Token(Token = "0x40002E7")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private SharedVector3 AroundPosition;

	// Token: 0x0400039F RID: 927
	[Token(Token = "0x40002E8")]
	[FieldOffset(Offset = "0x58")]
	private AIInput AIInput;
}
