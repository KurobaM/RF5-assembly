using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001BE RID: 446
[Token(Token = "0x200015E")]
public class ArmIKSwitcher : CharaMotionBehaviour
{
	// Token: 0x0600095D RID: 2397 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000810")]
	[Address(RVA = "0x24433D0", Offset = "0x24434D1", VA = "0x24433D0", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x0600095E RID: 2398 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000811")]
	[Address(RVA = "0x24434D0", Offset = "0x24435D1", VA = "0x24434D0")]
	public ArmIKSwitcher()
	{
	}

	// Token: 0x040005C4 RID: 1476
	[Token(Token = "0x4000471")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool isLeftArmIK;
}
