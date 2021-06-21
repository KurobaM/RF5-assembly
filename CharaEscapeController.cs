using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001FD RID: 509
[Token(Token = "0x200019A")]
public abstract class CharaEscapeController<T> : EscapeController where T : Character
{
	// Token: 0x170001E0 RID: 480
	// (get) Token: 0x06000A75 RID: 2677 RVA: 0x00005340 File Offset: 0x00003540
	[Token(Token = "0x170001C3")]
	public override bool IsPlaying
	{
		[Token(Token = "0x6000925")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000A76 RID: 2678 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000926")]
	protected virtual void Awake()
	{
	}

	// Token: 0x06000A77 RID: 2679 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000927")]
	protected virtual void OnDestroy()
	{
	}

	// Token: 0x06000A78 RID: 2680 RVA: 0x00005358 File Offset: 0x00003558
	[Token(Token = "0x6000928")]
	public override bool DoRise([Optional] Action callback)
	{
		return default(bool);
	}

	// Token: 0x06000A79 RID: 2681 RVA: 0x00005370 File Offset: 0x00003570
	[Token(Token = "0x6000929")]
	public override bool DoFall([Optional] Action callback)
	{
		return default(bool);
	}

	// Token: 0x06000A7A RID: 2682 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600092A")]
	public override void DoEnd()
	{
	}

	// Token: 0x06000A7B RID: 2683 RVA: 0x00005388 File Offset: 0x00003588
	[Token(Token = "0x600092B")]
	public override bool DoTakeOff()
	{
		return default(bool);
	}

	// Token: 0x06000A7C RID: 2684 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600092C")]
	protected virtual void OnEndRise()
	{
	}

	// Token: 0x06000A7D RID: 2685 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600092D")]
	protected virtual void OnEndFall()
	{
	}

	// Token: 0x06000A7E RID: 2686 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600092E")]
	protected CharaEscapeController()
	{
	}

	// Token: 0x04000685 RID: 1669
	[Token(Token = "0x400052E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected CharaEscapeController<T>.State m_State;

	// Token: 0x04000686 RID: 1670
	[Token(Token = "0x400052F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected ParticleSystem m_AuraEffect;

	// Token: 0x04000687 RID: 1671
	[Token(Token = "0x4000530")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected EscapeShineBall m_ShineBall;

	// Token: 0x04000688 RID: 1672
	[Token(Token = "0x4000531")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected Transform m_AuraAttachPoint;

	// Token: 0x04000689 RID: 1673
	[Token(Token = "0x4000532")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected T m_chara;

	// Token: 0x020001FE RID: 510
	[Token(Token = "0x2000FEC")]
	protected enum State
	{
		// Token: 0x0400068B RID: 1675
		[Token(Token = "0x4018DCB")]
		None,
		// Token: 0x0400068C RID: 1676
		[Token(Token = "0x4018DCC")]
		Rise,
		// Token: 0x0400068D RID: 1677
		[Token(Token = "0x4018DCD")]
		Fall
	}
}
