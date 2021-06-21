using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001E7 RID: 487
[Token(Token = "0x2000185")]
public class PlaySEObserve : NormalizedTimeObserve
{
	// Token: 0x170001CB RID: 459
	// (get) Token: 0x060009E0 RID: 2528 RVA: 0x00004FE0 File Offset: 0x000031E0
	[Token(Token = "0x170001AE")]
	protected override bool IsUseClamp
	{
		[Token(Token = "0x6000891")]
		[Address(RVA = "0x2143190", Offset = "0x2143291", VA = "0x2143190", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060009E1 RID: 2529 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000892")]
	[Address(RVA = "0x21431A0", Offset = "0x21432A1", VA = "0x21431A0", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x060009E2 RID: 2530 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000893")]
	[Address(RVA = "0x2143360", Offset = "0x2143461", VA = "0x2143360", Slot = "19")]
	public override void DoEvent()
	{
	}

	// Token: 0x060009E3 RID: 2531 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000894")]
	[Address(RVA = "0x2143420", Offset = "0x2143521", VA = "0x2143420")]
	public PlaySEObserve()
	{
	}

	// Token: 0x04000640 RID: 1600
	[Token(Token = "0x40004E9")]
	[FieldOffset(Offset = "0x24")]
	public SoundID SoundID;

	// Token: 0x04000641 RID: 1601
	[Token(Token = "0x40004EA")]
	[FieldOffset(Offset = "0x28")]
	private Animator Animator;

	// Token: 0x04000642 RID: 1602
	[Token(Token = "0x40004EB")]
	[FieldOffset(Offset = "0x30")]
	public string ParameterNameFloat;

	// Token: 0x04000643 RID: 1603
	[Token(Token = "0x40004EC")]
	[FieldOffset(Offset = "0x38")]
	public float ParamMinFloat;

	// Token: 0x04000644 RID: 1604
	[Token(Token = "0x40004ED")]
	[FieldOffset(Offset = "0x3C")]
	public float ParamMaxFloat;

	// Token: 0x04000645 RID: 1605
	[Token(Token = "0x40004EE")]
	[FieldOffset(Offset = "0x40")]
	public bool IsRepeat;

	// Token: 0x04000646 RID: 1606
	[Token(Token = "0x40004EF")]
	[FieldOffset(Offset = "0x48")]
	public string TargetTransformName;

	// Token: 0x04000647 RID: 1607
	[Token(Token = "0x40004F0")]
	[FieldOffset(Offset = "0x50")]
	private Transform TargetTransform;
}
