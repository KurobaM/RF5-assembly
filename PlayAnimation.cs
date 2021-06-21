using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001E6 RID: 486
[Token(Token = "0x2000184")]
public class PlayAnimation : StateMachineBehaviour
{
	// Token: 0x060009DE RID: 2526 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600088F")]
	[Address(RVA = "0x2142B90", Offset = "0x2142C91", VA = "0x2142B90", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x060009DF RID: 2527 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000890")]
	[Address(RVA = "0x2142C10", Offset = "0x2142D11", VA = "0x2142C10")]
	public PlayAnimation()
	{
	}

	// Token: 0x0400063E RID: 1598
	[Token(Token = "0x40004E7")]
	[FieldOffset(Offset = "0x18")]
	public string m_AnimatiorLayer;

	// Token: 0x0400063F RID: 1599
	[Token(Token = "0x40004E8")]
	[FieldOffset(Offset = "0x20")]
	public string m_AnimatorStateName;
}
