using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001D3 RID: 467
[Token(Token = "0x2000171")]
public class FishingStateBehaviour : CharaMotionBehaviour
{
	// Token: 0x060009A2 RID: 2466 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000853")]
	[Address(RVA = "0x1EC8140", Offset = "0x1EC8241", VA = "0x1EC8140", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x060009A3 RID: 2467 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000854")]
	[Address(RVA = "0x1EC8250", Offset = "0x1EC8351", VA = "0x1EC8250", Slot = "5")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x060009A4 RID: 2468 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000855")]
	[Address(RVA = "0x1EC8360", Offset = "0x1EC8461", VA = "0x1EC8360", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x060009A5 RID: 2469 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000856")]
	[Address(RVA = "0x1EC84B0", Offset = "0x1EC85B1", VA = "0x1EC84B0")]
	public FishingStateBehaviour()
	{
	}

	// Token: 0x04000618 RID: 1560
	[Token(Token = "0x40004C1")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private FishingState m_FishingState;

	// Token: 0x04000619 RID: 1561
	[Token(Token = "0x40004C2")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private bool m_ExitCall;

	// Token: 0x0400061A RID: 1562
	[Token(Token = "0x40004C3")]
	[FieldOffset(Offset = "0x2D")]
	private bool m_isCalled;
}
