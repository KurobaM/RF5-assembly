using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001C6 RID: 454
[Token(Token = "0x2000164")]
public class CharacterMotionAddForce : CharaMotionBehaviour
{
	// Token: 0x06000977 RID: 2423 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000828")]
	[Address(RVA = "0x1E8E9E0", Offset = "0x1E8EAE1", VA = "0x1E8E9E0", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x06000978 RID: 2424 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000829")]
	[Address(RVA = "0x1E8EBC0", Offset = "0x1E8ECC1", VA = "0x1E8EBC0")]
	public CharacterMotionAddForce()
	{
	}

	// Token: 0x040005FE RID: 1534
	[Token(Token = "0x40004A7")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Vector3 m_Force;

	// Token: 0x040005FF RID: 1535
	[Token(Token = "0x40004A8")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private ForceMode m_ForceMode;
}
