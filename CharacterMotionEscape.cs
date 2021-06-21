using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001CA RID: 458
[Token(Token = "0x2000168")]
public class CharacterMotionEscape : CharaMotionBehaviour
{
	// Token: 0x06000983 RID: 2435 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000834")]
	[Address(RVA = "0x1E8F1C0", Offset = "0x1E8F2C1", VA = "0x1E8F1C0", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x06000984 RID: 2436 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000835")]
	[Address(RVA = "0x1E8F350", Offset = "0x1E8F451", VA = "0x1E8F350", Slot = "5")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x06000985 RID: 2437 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000836")]
	[Address(RVA = "0x1E8F460", Offset = "0x1E8F561", VA = "0x1E8F460", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x06000986 RID: 2438 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000837")]
	[Address(RVA = "0x1E8F1F0", Offset = "0x1E8F2F1", VA = "0x1E8F1F0")]
	private void CheckNormalizeTime(float normalizeTime)
	{
	}

	// Token: 0x06000987 RID: 2439 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000838")]
	[Address(RVA = "0x1E8F490", Offset = "0x1E8F591", VA = "0x1E8F490")]
	public CharacterMotionEscape()
	{
	}

	// Token: 0x04000606 RID: 1542
	[Token(Token = "0x40004AF")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AnimationCurve m_Alpha;

	// Token: 0x04000607 RID: 1543
	[Token(Token = "0x40004B0")]
	[FieldOffset(Offset = "0x30")]
	private bool isTakeOff;
}
