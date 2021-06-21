using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000110 RID: 272
[Token(Token = "0x20000D5")]
public class PlayEffectAnimMonitor : StateMachineBehaviour
{
	// Token: 0x060005E1 RID: 1505 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004FD")]
	[Address(RVA = "0x2142C80", Offset = "0x2142D81", VA = "0x2142C80", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x060005E2 RID: 1506 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004FE")]
	[Address(RVA = "0x2142CA0", Offset = "0x2142DA1", VA = "0x2142CA0", Slot = "5")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x060005E3 RID: 1507 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004FF")]
	[Address(RVA = "0x2142D30", Offset = "0x2142E31", VA = "0x2142D30")]
	public void PlayAnimEffect()
	{
	}

	// Token: 0x060005E4 RID: 1508 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000500")]
	[Address(RVA = "0x2143170", Offset = "0x2143271", VA = "0x2143170")]
	public PlayEffectAnimMonitor()
	{
	}

	// Token: 0x0400031F RID: 799
	[Token(Token = "0x400026D")]
	[FieldOffset(Offset = "0x18")]
	public bool m_RightHand;

	// Token: 0x04000320 RID: 800
	[Token(Token = "0x400026E")]
	[FieldOffset(Offset = "0x19")]
	public bool m_LeftHand;

	// Token: 0x04000321 RID: 801
	[Token(Token = "0x400026F")]
	[FieldOffset(Offset = "0x1C")]
	public float m_offsetX;

	// Token: 0x04000322 RID: 802
	[Token(Token = "0x4000270")]
	[FieldOffset(Offset = "0x20")]
	public float m_offsetY;

	// Token: 0x04000323 RID: 803
	[Token(Token = "0x4000271")]
	[FieldOffset(Offset = "0x24")]
	public float m_offsetZ;

	// Token: 0x04000324 RID: 804
	[Token(Token = "0x4000272")]
	[FieldOffset(Offset = "0x28")]
	public float m_Scale;

	// Token: 0x04000325 RID: 805
	[Token(Token = "0x4000273")]
	[FieldOffset(Offset = "0x2C")]
	public float m_DispTime;

	// Token: 0x04000326 RID: 806
	[Token(Token = "0x4000274")]
	[FieldOffset(Offset = "0x30")]
	public float m_Wait;

	// Token: 0x04000327 RID: 807
	[Token(Token = "0x4000275")]
	[FieldOffset(Offset = "0x34")]
	public EffectID m_EffectID;

	// Token: 0x04000328 RID: 808
	[Token(Token = "0x4000276")]
	[FieldOffset(Offset = "0x38")]
	public SoundID m_SoundID;

	// Token: 0x04000329 RID: 809
	[Token(Token = "0x4000277")]
	[FieldOffset(Offset = "0x40")]
	private Animator m_Animator;

	// Token: 0x0400032A RID: 810
	[Token(Token = "0x4000278")]
	[FieldOffset(Offset = "0x48")]
	private bool IsCalled;

	// Token: 0x0400032B RID: 811
	[Token(Token = "0x4000279")]
	[FieldOffset(Offset = "0x4C")]
	private float WaitNormalizedTime;
}
