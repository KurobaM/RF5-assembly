using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001CC RID: 460
[Token(Token = "0x200016A")]
public class CharacterMotionQueue : CharaMotionBehaviour
{
	// Token: 0x0600098B RID: 2443 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600083C")]
	[Address(RVA = "0x1E8F740", Offset = "0x1E8F841", VA = "0x1E8F740", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x0600098C RID: 2444 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600083D")]
	[Address(RVA = "0x1E8F800", Offset = "0x1E8F901", VA = "0x1E8F800", Slot = "5")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x0600098D RID: 2445 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600083E")]
	[Address(RVA = "0x1E8F900", Offset = "0x1E8FA01", VA = "0x1E8F900")]
	public CharacterMotionQueue()
	{
	}

	// Token: 0x0400060D RID: 1549
	[Token(Token = "0x40004B6")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private string m_QueueMotionName;

	// Token: 0x0400060E RID: 1550
	[Token(Token = "0x40004B7")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float m_CrossFadeTime;

	// Token: 0x0400060F RID: 1551
	[Token(Token = "0x40004B8")]
	[FieldOffset(Offset = "0x34")]
	private bool m_IsQueued;
}
