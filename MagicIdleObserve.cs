using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001E3 RID: 483
[Token(Token = "0x2000181")]
public class MagicIdleObserve : CharaMotionBehaviour
{
	// Token: 0x060009D1 RID: 2513 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000882")]
	[Address(RVA = "0x1F128A0", Offset = "0x1F129A1", VA = "0x1F128A0", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x060009D2 RID: 2514 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000883")]
	[Address(RVA = "0x1F128F0", Offset = "0x1F129F1", VA = "0x1F128F0", Slot = "5")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x060009D3 RID: 2515 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000884")]
	[Address(RVA = "0x1F12BB0", Offset = "0x1F12CB1", VA = "0x1F12BB0")]
	public MagicIdleObserve()
	{
	}

	// Token: 0x04000638 RID: 1592
	[Token(Token = "0x40004E1")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private string nextStateName;
}
