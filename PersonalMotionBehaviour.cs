using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001E5 RID: 485
[Token(Token = "0x2000183")]
public class PersonalMotionBehaviour : CharaMotionBehaviour
{
	// Token: 0x060009DB RID: 2523 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600088C")]
	[Address(RVA = "0x213D4E0", Offset = "0x213D5E1", VA = "0x213D4E0", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x060009DC RID: 2524 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600088D")]
	[Address(RVA = "0x213D610", Offset = "0x213D711", VA = "0x213D610", Slot = "5")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x060009DD RID: 2525 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600088E")]
	[Address(RVA = "0x213D770", Offset = "0x213D871", VA = "0x213D770")]
	public PersonalMotionBehaviour()
	{
	}

	// Token: 0x0400063C RID: 1596
	[Token(Token = "0x40004E5")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x15CF40", Offset = "0x15D041")]
	private int m_no;

	// Token: 0x0400063D RID: 1597
	[Token(Token = "0x40004E6")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_isTransitioned;
}
