using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001D5 RID: 469
[Token(Token = "0x2000173")]
public class FootIKSwitcher : CharaMotionBehaviour
{
	// Token: 0x060009AB RID: 2475 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600085C")]
	[Address(RVA = "0x1ECD6A0", Offset = "0x1ECD7A1", VA = "0x1ECD6A0", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x060009AC RID: 2476 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600085D")]
	[Address(RVA = "0x1ECD7D0", Offset = "0x1ECD8D1", VA = "0x1ECD7D0")]
	public FootIKSwitcher()
	{
	}

	// Token: 0x0400061D RID: 1565
	[Token(Token = "0x40004C6")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool isFootIK;
}
