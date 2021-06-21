using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001DF RID: 479
[Token(Token = "0x200017D")]
public class LandingMotionObserve : CharaMotionBehaviour
{
	// Token: 0x060009C4 RID: 2500 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000875")]
	[Address(RVA = "0x2300E70", Offset = "0x2300F71", VA = "0x2300E70", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x060009C5 RID: 2501 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000876")]
	[Address(RVA = "0x2300FF0", Offset = "0x23010F1", VA = "0x2300FF0", Slot = "5")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x060009C6 RID: 2502 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000877")]
	[Address(RVA = "0x2301020", Offset = "0x2301121", VA = "0x2301020")]
	private void CheckNormalizeTime(float normalizeTime)
	{
	}

	// Token: 0x060009C7 RID: 2503 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000878")]
	[Address(RVA = "0x23010D0", Offset = "0x23011D1", VA = "0x23010D0")]
	public LandingMotionObserve()
	{
	}

	// Token: 0x0400062C RID: 1580
	[Token(Token = "0x40004D5")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private string m_ParameterName;

	// Token: 0x0400062D RID: 1581
	[Token(Token = "0x40004D6")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float m_SoundPlayThreshold;

	// Token: 0x0400062E RID: 1582
	[Token(Token = "0x40004D7")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float m_EffectPlayThreshold;

	// Token: 0x0400062F RID: 1583
	[Token(Token = "0x40004D8")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float m_MoveNormalizedTime;
}
