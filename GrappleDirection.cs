using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001D6 RID: 470
[Token(Token = "0x2000174")]
public class GrappleDirection : StateMachineBehaviour
{
	// Token: 0x060009AD RID: 2477 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600085E")]
	[Address(RVA = "0x1FF6680", Offset = "0x1FF6781", VA = "0x1FF6680", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x060009AE RID: 2478 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600085F")]
	[Address(RVA = "0x1FF6870", Offset = "0x1FF6971", VA = "0x1FF6870", Slot = "5")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x060009AF RID: 2479 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000860")]
	[Address(RVA = "0x1FF69B0", Offset = "0x1FF6AB1", VA = "0x1FF69B0")]
	public GrappleDirection()
	{
	}

	// Token: 0x0400061E RID: 1566
	[Token(Token = "0x40004C7")]
	[FieldOffset(Offset = "0x18")]
	public ActorID actorID;

	// Token: 0x0400061F RID: 1567
	[Token(Token = "0x40004C8")]
	[FieldOffset(Offset = "0x20")]
	public AnimationCurve GrappleDirectionCurve;
}
