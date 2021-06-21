using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001E2 RID: 482
[Token(Token = "0x2000180")]
public class LookIKWightObserve : CharaMotionBehaviour
{
	// Token: 0x060009CD RID: 2509 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600087E")]
	[Address(RVA = "0x1F0F660", Offset = "0x1F0F761", VA = "0x1F0F660", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x060009CE RID: 2510 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600087F")]
	[Address(RVA = "0x1F0F810", Offset = "0x1F0F911", VA = "0x1F0F810", Slot = "5")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x060009CF RID: 2511 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000880")]
	[Address(RVA = "0x1F0F740", Offset = "0x1F0F841", VA = "0x1F0F740")]
	private void OnUpdateWeight(float locomotion)
	{
	}

	// Token: 0x060009D0 RID: 2512 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000881")]
	[Address(RVA = "0x1F0F850", Offset = "0x1F0F951", VA = "0x1F0F850")]
	public LookIKWightObserve()
	{
	}

	// Token: 0x04000635 RID: 1589
	[Token(Token = "0x40004DE")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private string m_ParamName;

	// Token: 0x04000636 RID: 1590
	[Token(Token = "0x40004DF")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AnimationCurve m_Weight;

	// Token: 0x04000637 RID: 1591
	[Token(Token = "0x40004E0")]
	[FieldOffset(Offset = "0x38")]
	private int m_ParamHash;
}
