using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001CB RID: 459
[Token(Token = "0x2000169")]
public class CharacterMotionPersonal : CharaMotionBehaviour
{
	// Token: 0x06000988 RID: 2440 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000839")]
	[Address(RVA = "0x1E8F4A0", Offset = "0x1E8F5A1", VA = "0x1E8F4A0", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x06000989 RID: 2441 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600083A")]
	[Address(RVA = "0x1E8F560", Offset = "0x1E8F661", VA = "0x1E8F560", Slot = "5")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x0600098A RID: 2442 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600083B")]
	[Address(RVA = "0x1E8F6C0", Offset = "0x1E8F7C1", VA = "0x1E8F6C0")]
	public CharacterMotionPersonal()
	{
	}

	// Token: 0x04000608 RID: 1544
	[Token(Token = "0x40004B1")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public bool enabled;

	// Token: 0x04000609 RID: 1545
	[Token(Token = "0x40004B2")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float m_Time;

	// Token: 0x0400060A RID: 1546
	[Token(Token = "0x40004B3")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private string m_NamePersonal;

	// Token: 0x0400060B RID: 1547
	[Token(Token = "0x40004B4")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float m_FadeDuration;

	// Token: 0x0400060C RID: 1548
	[Token(Token = "0x40004B5")]
	[FieldOffset(Offset = "0x3C")]
	private float m_Elapsed;
}
