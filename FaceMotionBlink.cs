using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001D2 RID: 466
[Token(Token = "0x2000170")]
public class FaceMotionBlink : StateMachineBehaviour
{
	// Token: 0x0600099F RID: 2463 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000850")]
	[Address(RVA = "0x21C02E0", Offset = "0x21C03E1", VA = "0x21C02E0", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x060009A0 RID: 2464 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000851")]
	[Address(RVA = "0x21C0310", Offset = "0x21C0411", VA = "0x21C0310", Slot = "5")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x060009A1 RID: 2465 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000852")]
	[Address(RVA = "0x21C0380", Offset = "0x21C0481", VA = "0x21C0380")]
	public FaceMotionBlink()
	{
	}

	// Token: 0x04000613 RID: 1555
	[Token(Token = "0x40004BC")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float m_MinTime;

	// Token: 0x04000614 RID: 1556
	[Token(Token = "0x40004BD")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float m_MaxTime;

	// Token: 0x04000615 RID: 1557
	[Token(Token = "0x40004BE")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string m_StateName;

	// Token: 0x04000616 RID: 1558
	[Token(Token = "0x40004BF")]
	[FieldOffset(Offset = "0x28")]
	private float m_Elapsed;

	// Token: 0x04000617 RID: 1559
	[Token(Token = "0x40004C0")]
	[FieldOffset(Offset = "0x2C")]
	private float m_NextTime;
}
