using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001E1 RID: 481
[Token(Token = "0x200017F")]
public class LookIKWight : CharaMotionBehaviour
{
	// Token: 0x060009CB RID: 2507 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600087C")]
	[Address(RVA = "0x1F0F530", Offset = "0x1F0F631", VA = "0x1F0F530", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x060009CC RID: 2508 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600087D")]
	[Address(RVA = "0x1F0F650", Offset = "0x1F0F751", VA = "0x1F0F650")]
	public LookIKWight()
	{
	}

	// Token: 0x04000634 RID: 1588
	[Token(Token = "0x40004DD")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x15CE80", Offset = "0x15CF81")]
	private float m_Weight;
}
