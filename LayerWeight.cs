using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001E0 RID: 480
[Token(Token = "0x200017E")]
public class LayerWeight : StateMachineBehaviour
{
	// Token: 0x060009C8 RID: 2504 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000879")]
	[Address(RVA = "0x230B940", Offset = "0x230BA41", VA = "0x230B940", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x060009C9 RID: 2505 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600087A")]
	[Address(RVA = "0x230B990", Offset = "0x230BA91", VA = "0x230B990", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x060009CA RID: 2506 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600087B")]
	[Address(RVA = "0x230B9E0", Offset = "0x230BAE1", VA = "0x230B9E0")]
	public LayerWeight()
	{
	}

	// Token: 0x04000630 RID: 1584
	[Token(Token = "0x40004D9")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string LayerName;

	// Token: 0x04000631 RID: 1585
	[Token(Token = "0x40004DA")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float EnterWeight;

	// Token: 0x04000632 RID: 1586
	[Token(Token = "0x40004DB")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float ExitWeight;

	// Token: 0x04000633 RID: 1587
	[Token(Token = "0x40004DC")]
	[FieldOffset(Offset = "0x28")]
	private int LayerIndex;
}
