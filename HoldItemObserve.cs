using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001DE RID: 478
[Token(Token = "0x200017C")]
public class HoldItemObserve : NormalizedTimeObserve
{
	// Token: 0x060009C1 RID: 2497 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000872")]
	[Address(RVA = "0x2092DE0", Offset = "0x2092EE1", VA = "0x2092DE0", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x060009C2 RID: 2498 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000873")]
	[Address(RVA = "0x2092EB0", Offset = "0x2092FB1", VA = "0x2092EB0", Slot = "19")]
	public override void DoEvent()
	{
	}

	// Token: 0x060009C3 RID: 2499 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000874")]
	[Address(RVA = "0x2092FB0", Offset = "0x20930B1", VA = "0x2092FB0")]
	public HoldItemObserve()
	{
	}

	// Token: 0x0400062A RID: 1578
	[Token(Token = "0x40004D3")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private HumanItemHold.AnimEvent ItemHoldEvent;

	// Token: 0x0400062B RID: 1579
	[Token(Token = "0x40004D4")]
	[FieldOffset(Offset = "0x28")]
	private HumanItemHold HumanItemHold;
}
