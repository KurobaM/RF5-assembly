using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Fishing
{
	// Token: 0x02001056 RID: 4182
	[Token(Token = "0x2000A9F")]
	public class FishAnimation : MonoBehaviour
	{
		// Token: 0x06006961 RID: 26977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057D3")]
		[Address(RVA = "0x2034A50", Offset = "0x2034B51", VA = "0x2034A50")]
		public void SetAnime(FishAnimation.FishAnime anime)
		{
		}

		// Token: 0x06006962 RID: 26978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057D4")]
		[Address(RVA = "0x2034AC0", Offset = "0x2034BC1", VA = "0x2034AC0")]
		public FishAnimation()
		{
		}

		// Token: 0x0401715B RID: 94555
		[Token(Token = "0x4013DBE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Animator m_Animator;

		// Token: 0x02001057 RID: 4183
		[Token(Token = "0x2001523")]
		public enum FishAnime
		{
			// Token: 0x0401715D RID: 94557
			[Token(Token = "0x401BFAA")]
			Swim,
			// Token: 0x0401715E RID: 94558
			[Token(Token = "0x401BFAB")]
			SwimSplash,
			// Token: 0x0401715F RID: 94559
			[Token(Token = "0x401BFAC")]
			Max
		}
	}
}
