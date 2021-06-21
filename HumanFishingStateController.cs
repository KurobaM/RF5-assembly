using System;
using Fishing;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200023B RID: 571
[Token(Token = "0x20001CB")]
public class HumanFishingStateController : CharaFishingStateController<HumanController>
{
	// Token: 0x06000D90 RID: 3472 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C2F")]
	[Address(RVA = "0x20A4E60", Offset = "0x20A4F61", VA = "0x20A4E60", Slot = "4")]
	public override void OnExit()
	{
	}

	// Token: 0x06000D91 RID: 3473 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C30")]
	[Address(RVA = "0x20A4FB0", Offset = "0x20A50B1", VA = "0x20A4FB0")]
	private void PlayMotion(string stateName)
	{
	}

	// Token: 0x06000D92 RID: 3474 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C31")]
	[Address(RVA = "0x20A50A0", Offset = "0x20A51A1", VA = "0x20A50A0")]
	public void PlayRodAnime(RodAnimation.RodAnime anime)
	{
	}

	// Token: 0x06000D93 RID: 3475 RVA: 0x00006528 File Offset: 0x00004728
	[Token(Token = "0x6000C32")]
	[Address(RVA = "0x20A5190", Offset = "0x20A5291", VA = "0x20A5190", Slot = "5")]
	public override bool DoWkiCast()
	{
		return default(bool);
	}

	// Token: 0x06000D94 RID: 3476 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C33")]
	[Address(RVA = "0x20A5330", Offset = "0x20A5431", VA = "0x20A5330")]
	public HumanFishingStateController()
	{
	}

	// Token: 0x040007D2 RID: 2002
	[Token(Token = "0x400065B")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool m_WkiCast;
}
