using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000114 RID: 276
[Token(Token = "0x20000D8")]
public class ShortplayAnimMonitor : StateMachineBehaviour
{
	// Token: 0x060005F6 RID: 1526 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000512")]
	[Address(RVA = "0x1DE3A70", Offset = "0x1DE3B71", VA = "0x1DE3A70", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x060005F7 RID: 1527 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000513")]
	[Address(RVA = "0x1DE3C40", Offset = "0x1DE3D41", VA = "0x1DE3C40")]
	public ShortplayAnimMonitor()
	{
	}

	// Token: 0x0400033E RID: 830
	[Token(Token = "0x4000287")]
	[FieldOffset(Offset = "0x18")]
	public bool m_IKOnOff;

	// Token: 0x0400033F RID: 831
	[Token(Token = "0x4000288")]
	[FieldOffset(Offset = "0x19")]
	public bool m_IsWakeupAnim;

	// Token: 0x04000340 RID: 832
	[Token(Token = "0x4000289")]
	[FieldOffset(Offset = "0x1A")]
	public bool m_IsSleepAnim;
}
