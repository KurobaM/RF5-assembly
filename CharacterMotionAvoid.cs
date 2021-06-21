using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001C7 RID: 455
[Token(Token = "0x2000165")]
public class CharacterMotionAvoid : CharaMotionBehaviour
{
	// Token: 0x06000979 RID: 2425 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600082A")]
	[Address(RVA = "0x1E8EC40", Offset = "0x1E8ED41", VA = "0x1E8EC40", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x0600097A RID: 2426 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600082B")]
	[Address(RVA = "0x1E8EE40", Offset = "0x1E8EF41", VA = "0x1E8EE40", Slot = "5")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x0600097B RID: 2427 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600082C")]
	[Address(RVA = "0x1E8EEC0", Offset = "0x1E8EFC1", VA = "0x1E8EEC0", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x0600097C RID: 2428 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600082D")]
	[Address(RVA = "0x1E8ED70", Offset = "0x1E8EE71", VA = "0x1E8ED70")]
	private void CheckNormalizeTime(float normalizeTime)
	{
	}

	// Token: 0x0600097D RID: 2429 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600082E")]
	[Address(RVA = "0x1E8EF90", Offset = "0x1E8F091", VA = "0x1E8EF90")]
	public CharacterMotionAvoid()
	{
	}

	// Token: 0x04000600 RID: 1536
	[Token(Token = "0x40004A9")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float m_FootStepNormalizeTime;

	// Token: 0x04000601 RID: 1537
	[Token(Token = "0x40004AA")]
	[FieldOffset(Offset = "0x2C")]
	private float m_NormalizedTime;

	// Token: 0x04000602 RID: 1538
	[Token(Token = "0x40004AB")]
	[FieldOffset(Offset = "0x30")]
	private FootSteps m_FootSteps;
}
