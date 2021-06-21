using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001BD RID: 445
[Token(Token = "0x200015D")]
public class ArmIKBlender : CharaMotionBehaviour
{
	// Token: 0x06000958 RID: 2392 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600080B")]
	[Address(RVA = "0x2443160", Offset = "0x2443261", VA = "0x2443160")]
	private void Awake()
	{
	}

	// Token: 0x06000959 RID: 2393 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600080C")]
	[Address(RVA = "0x2443190", Offset = "0x2443291", VA = "0x2443190", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x0600095A RID: 2394 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600080D")]
	[Address(RVA = "0x2443330", Offset = "0x2443431", VA = "0x2443330", Slot = "5")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x0600095B RID: 2395 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600080E")]
	[Address(RVA = "0x2443250", Offset = "0x2443351", VA = "0x2443250")]
	private void OvserveBlendParamater(Animator animator)
	{
	}

	// Token: 0x0600095C RID: 2396 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600080F")]
	[Address(RVA = "0x2443340", Offset = "0x2443441", VA = "0x2443340")]
	public ArmIKBlender()
	{
	}

	// Token: 0x040005BF RID: 1471
	[Token(Token = "0x400046C")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool isLeftArmIK;

	// Token: 0x040005C0 RID: 1472
	[Token(Token = "0x400046D")]
	[FieldOffset(Offset = "0x29")]
	[SerializeField]
	private bool isRightArmIK;

	// Token: 0x040005C1 RID: 1473
	[Token(Token = "0x400046E")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private string blendParamName;

	// Token: 0x040005C2 RID: 1474
	[Token(Token = "0x400046F")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private AnimationCurve weightCurve;

	// Token: 0x040005C3 RID: 1475
	[Token(Token = "0x4000470")]
	[FieldOffset(Offset = "0x40")]
	private int hashBlendParam;
}
