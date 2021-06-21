using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001C9 RID: 457
[Token(Token = "0x2000167")]
public class CharacterMotionCollapseStart : CharaMotionBehaviour
{
	// Token: 0x0600097F RID: 2431 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000830")]
	[Address(RVA = "0x1E8EFC0", Offset = "0x1E8F0C1", VA = "0x1E8EFC0", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x06000980 RID: 2432 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000831")]
	[Address(RVA = "0x1E8F170", Offset = "0x1E8F271", VA = "0x1E8F170", Slot = "5")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x06000981 RID: 2433 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000832")]
	[Address(RVA = "0x1E8F0A0", Offset = "0x1E8F1A1", VA = "0x1E8F0A0")]
	private void CheckNormalizeTime(float normalizeTime)
	{
	}

	// Token: 0x06000982 RID: 2434 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000833")]
	[Address(RVA = "0x1E8F1A0", Offset = "0x1E8F2A1", VA = "0x1E8F1A0")]
	public CharacterMotionCollapseStart()
	{
	}

	// Token: 0x04000603 RID: 1539
	[Token(Token = "0x40004AC")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float m_EffectPlayNomalizeTime;

	// Token: 0x04000604 RID: 1540
	[Token(Token = "0x40004AD")]
	[FieldOffset(Offset = "0x2C")]
	private float m_NormalizedTime;

	// Token: 0x04000605 RID: 1541
	[Token(Token = "0x40004AE")]
	[FieldOffset(Offset = "0x30")]
	private bool m_isPlayedSE;
}
