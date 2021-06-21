using System;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000156 RID: 342
[Token(Token = "0x200010A")]
public class DestroyBehavior : BehaviorDesigner.Runtime.Tasks.Action
{
	// Token: 0x06000738 RID: 1848 RVA: 0x00004938 File Offset: 0x00002B38
	[Token(Token = "0x6000617")]
	[Address(RVA = "0x1DFA690", Offset = "0x1DFA791", VA = "0x1DFA690", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x06000739 RID: 1849 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000618")]
	[Address(RVA = "0x1DFA720", Offset = "0x1DFA821", VA = "0x1DFA720")]
	public DestroyBehavior()
	{
	}

	// Token: 0x04000421 RID: 1057
	[Token(Token = "0x400032C")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private SharedGameObject _targetGameObject;
}
