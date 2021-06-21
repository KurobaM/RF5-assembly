using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001CE RID: 462
[Token(Token = "0x200016C")]
public class ConstraintWeight : CharaMotionBehaviour
{
	// Token: 0x06000992 RID: 2450 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000843")]
	[Address(RVA = "0x20E17A0", Offset = "0x20E18A1", VA = "0x20E17A0", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x06000993 RID: 2451 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000844")]
	[Address(RVA = "0x20E18D0", Offset = "0x20E19D1", VA = "0x20E18D0")]
	public ConstraintWeight()
	{
	}

	// Token: 0x04000611 RID: 1553
	[Token(Token = "0x40004BA")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private ConstraintPresetID presetId;
}
