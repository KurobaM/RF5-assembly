using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001E9 RID: 489
[Token(Token = "0x2000187")]
public class SetEnterAnimatorFloatParameter : StateMachineBehaviour
{
	// Token: 0x060009E6 RID: 2534 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000897")]
	[Address(RVA = "0x1E34490", Offset = "0x1E34591", VA = "0x1E34490", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x060009E7 RID: 2535 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000898")]
	[Address(RVA = "0x1E345A0", Offset = "0x1E346A1", VA = "0x1E345A0")]
	public SetEnterAnimatorFloatParameter()
	{
	}

	// Token: 0x060009E8 RID: 2536 RVA: 0x00004FF8 File Offset: 0x000031F8
	[Token(Token = "0x6000899")]
	[Address(RVA = "0x1E345B0", Offset = "0x1E346B1", VA = "0x1E345B0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AF50", Offset = "0x19B051")]
	private bool <OnStateEnter>b__4_0(AnimatorControllerParameter x)
	{
		return default(bool);
	}

	// Token: 0x04000649 RID: 1609
	[Token(Token = "0x40004F2")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string ParameterName;

	// Token: 0x0400064A RID: 1610
	[Token(Token = "0x40004F3")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float Value;

	// Token: 0x0400064B RID: 1611
	[Token(Token = "0x40004F4")]
	[FieldOffset(Offset = "0x24")]
	private int ParameterHash;

	// Token: 0x0400064C RID: 1612
	[Token(Token = "0x40004F5")]
	[FieldOffset(Offset = "0x28")]
	private bool IsCheck;
}
