using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001E8 RID: 488
[Token(Token = "0x2000186")]
public class SetAnimatorSpeedBehavior : StateMachineBehaviour
{
	// Token: 0x060009E4 RID: 2532 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000895")]
	[Address(RVA = "0x1E31EA0", Offset = "0x1E31FA1", VA = "0x1E31EA0", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x060009E5 RID: 2533 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000896")]
	[Address(RVA = "0x1E31EC0", Offset = "0x1E31FC1", VA = "0x1E31EC0")]
	public SetAnimatorSpeedBehavior()
	{
	}

	// Token: 0x04000648 RID: 1608
	[Token(Token = "0x40004F1")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float AnimatorSpeed;
}
