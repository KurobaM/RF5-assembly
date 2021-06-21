using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001E4 RID: 484
[Token(Token = "0x2000182")]
public class NormalizedTimeObserve : StateMachineBehaviour
{
	// Token: 0x170001CA RID: 458
	// (get) Token: 0x060009D4 RID: 2516 RVA: 0x00004FC8 File Offset: 0x000031C8
	[Token(Token = "0x170001AD")]
	protected virtual bool IsUseClamp
	{
		[Token(Token = "0x6000885")]
		[Address(RVA = "0x1E24F10", Offset = "0x1E25011", VA = "0x1E24F10", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060009D5 RID: 2517 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000886")]
	[Address(RVA = "0x1E24F20", Offset = "0x1E25021", VA = "0x1E24F20", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x060009D6 RID: 2518 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000887")]
	[Address(RVA = "0x1E24F50", Offset = "0x1E25051", VA = "0x1E24F50", Slot = "5")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x060009D7 RID: 2519 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000888")]
	[Address(RVA = "0x1E25150", Offset = "0x1E25251", VA = "0x1E25150", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x060009D8 RID: 2520 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000889")]
	[Address(RVA = "0x1E25000", Offset = "0x1E25101", VA = "0x1E25000")]
	protected void CheckNormalizedTime(float motionNormalizedTime, float eventNormalizedTime, Action onEvent)
	{
	}

	// Token: 0x060009D9 RID: 2521 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600088A")]
	[Address(RVA = "0x1E251F0", Offset = "0x1E252F1", VA = "0x1E251F0", Slot = "19")]
	public virtual void DoEvent()
	{
	}

	// Token: 0x060009DA RID: 2522 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600088B")]
	[Address(RVA = "0x1E25200", Offset = "0x1E25301", VA = "0x1E25200")]
	public NormalizedTimeObserve()
	{
	}

	// Token: 0x04000639 RID: 1593
	[Token(Token = "0x40004E2")]
	[FieldOffset(Offset = "0x18")]
	protected float m_currentNormalizedTime;

	// Token: 0x0400063A RID: 1594
	[Token(Token = "0x40004E3")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x15CEF0", Offset = "0x15CFF1")]
	public float m_eventNormalizedTime;

	// Token: 0x0400063B RID: 1595
	[Token(Token = "0x40004E4")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected bool m_isExitCall;
}
