using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001D9 RID: 473
[Token(Token = "0x2000177")]
public class GrapplePoundObserve : NormalizedTimeObserve
{
	// Token: 0x060009B4 RID: 2484 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000865")]
	[Address(RVA = "0x1FF6BD0", Offset = "0x1FF6CD1", VA = "0x1FF6BD0", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x060009B5 RID: 2485 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000866")]
	[Address(RVA = "0x1FF6D60", Offset = "0x1FF6E61", VA = "0x1FF6D60", Slot = "19")]
	public override void DoEvent()
	{
	}

	// Token: 0x060009B6 RID: 2486 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000867")]
	[Address(RVA = "0x1FF6C30", Offset = "0x1FF6D31", VA = "0x1FF6C30")]
	public void OnEnd()
	{
	}

	// Token: 0x060009B7 RID: 2487 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000868")]
	[Address(RVA = "0x1FF6FF0", Offset = "0x1FF70F1", VA = "0x1FF6FF0")]
	public void Setup(ActorID actorID, MagicParamID id)
	{
	}

	// Token: 0x060009B8 RID: 2488 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000869")]
	[Address(RVA = "0x1FF7000", Offset = "0x1FF7101", VA = "0x1FF7000")]
	public GrapplePoundObserve()
	{
	}

	// Token: 0x04000621 RID: 1569
	[Token(Token = "0x40004CA")]
	[FieldOffset(Offset = "0x24")]
	private ActorID m_ActorID;

	// Token: 0x04000622 RID: 1570
	[Token(Token = "0x40004CB")]
	[FieldOffset(Offset = "0x28")]
	private MagicParamID m_ParamID;
}
