using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001D4 RID: 468
[Token(Token = "0x2000172")]
public class FishingThrowObserve : CharaMotionBehaviour
{
	// Token: 0x060009A6 RID: 2470 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000857")]
	[Address(RVA = "0x1EC8510", Offset = "0x1EC8611", VA = "0x1EC8510", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x060009A7 RID: 2471 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000858")]
	[Address(RVA = "0x1EC8540", Offset = "0x1EC8641", VA = "0x1EC8540", Slot = "5")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x060009A8 RID: 2472 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000859")]
	[Address(RVA = "0x1EC85F0", Offset = "0x1EC86F1", VA = "0x1EC85F0")]
	protected void CheckNormalizedTime(float motionNormalizedTime, float eventNormalizedTime, Action onEvent)
	{
	}

	// Token: 0x060009A9 RID: 2473 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600085A")]
	[Address(RVA = "0x1EC86F0", Offset = "0x1EC87F1", VA = "0x1EC86F0", Slot = "18")]
	public virtual void DoEvent()
	{
	}

	// Token: 0x060009AA RID: 2474 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600085B")]
	[Address(RVA = "0x1EC87C0", Offset = "0x1EC88C1", VA = "0x1EC87C0")]
	public FishingThrowObserve()
	{
	}

	// Token: 0x0400061B RID: 1563
	[Token(Token = "0x40004C4")]
	[FieldOffset(Offset = "0x28")]
	protected float m_currentNormalizedTime;

	// Token: 0x0400061C RID: 1564
	[Token(Token = "0x40004C5")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x15CDA0", Offset = "0x15CEA1")]
	public float m_eventNormalizedTime;
}
