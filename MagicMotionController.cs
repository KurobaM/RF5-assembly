using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200020A RID: 522
[Token(Token = "0x20001A6")]
public abstract class MagicMotionController : MonoBehaviour
{
	// Token: 0x170001F0 RID: 496
	// (get) Token: 0x06000AE0 RID: 2784 RVA: 0x00005598 File Offset: 0x00003798
	[Token(Token = "0x170001D3")]
	public virtual bool IsPlaying
	{
		[Token(Token = "0x6000990")]
		[Address(RVA = "0x1F14420", Offset = "0x1F14521", VA = "0x1F14420", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000AE1 RID: 2785
	[Token(Token = "0x6000991")]
	public abstract void Setup();

	// Token: 0x06000AE2 RID: 2786
	[Token(Token = "0x6000992")]
	public abstract bool DoPlay(int no, MagicID magicId, int level);

	// Token: 0x06000AE3 RID: 2787
	[Token(Token = "0x6000993")]
	public abstract void DoStop();

	// Token: 0x06000AE4 RID: 2788
	[Token(Token = "0x6000994")]
	public abstract void DoCancel();

	// Token: 0x06000AE5 RID: 2789
	[Token(Token = "0x6000995")]
	public abstract bool DoShot();

	// Token: 0x06000AE6 RID: 2790 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000996")]
	[Address(RVA = "0x1F14430", Offset = "0x1F14531", VA = "0x1F14430")]
	protected MagicMotionController()
	{
	}
}
