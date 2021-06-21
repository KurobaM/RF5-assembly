using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001EA RID: 490
[Token(Token = "0x2000188")]
public class StepMotionObserve : CharaMotionBehaviour
{
	// Token: 0x060009E9 RID: 2537 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600089A")]
	[Address(RVA = "0x238B570", Offset = "0x238B671", VA = "0x238B570", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x060009EA RID: 2538 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600089B")]
	[Address(RVA = "0x238B920", Offset = "0x238BA21", VA = "0x238B920", Slot = "5")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x060009EB RID: 2539 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600089C")]
	[Address(RVA = "0x238B6B0", Offset = "0x238B7B1", VA = "0x238B6B0")]
	private void CheckNormalizeTime(float normalizeTime, float locomotion)
	{
	}

	// Token: 0x060009EC RID: 2540 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600089D")]
	[Address(RVA = "0x238B9C0", Offset = "0x238BAC1", VA = "0x238B9C0")]
	public StepMotionObserve()
	{
	}

	// Token: 0x0400064D RID: 1613
	[Token(Token = "0x40004F6")]
	[FieldOffset(Offset = "0x28")]
	public StepEventSetting[] m_WalkStepEvents;

	// Token: 0x0400064E RID: 1614
	[Token(Token = "0x40004F7")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public StepEventSetting[] m_StepEvents;

	// Token: 0x0400064F RID: 1615
	[Token(Token = "0x40004F8")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private string m_ParameterName;

	// Token: 0x04000650 RID: 1616
	[Token(Token = "0x40004F9")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float m_Threshold;

	// Token: 0x04000651 RID: 1617
	[Token(Token = "0x40004FA")]
	[FieldOffset(Offset = "0x44")]
	private float m_NormalizedTime;
}
