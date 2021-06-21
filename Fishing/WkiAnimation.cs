using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Fishing
{
	// Token: 0x02001070 RID: 4208
	[Token(Token = "0x2000AAA")]
	public class WkiAnimation : MonoBehaviour
	{
		// Token: 0x06006A36 RID: 27190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600587C")]
		[Address(RVA = "0x1EC57A0", Offset = "0x1EC58A1", VA = "0x1EC57A0")]
		public void SetAnime(WkiAnimation.FishAnime anime)
		{
		}

		// Token: 0x06006A37 RID: 27191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600587D")]
		[Address(RVA = "0x1EC5810", Offset = "0x1EC5911", VA = "0x1EC5810")]
		public WkiAnimation()
		{
		}

		// Token: 0x04017250 RID: 94800
		[Token(Token = "0x4013E61")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Animator m_Animator;

		// Token: 0x02001071 RID: 4209
		[Token(Token = "0x2001532")]
		public enum FishAnime
		{
			// Token: 0x04017252 RID: 94802
			[Token(Token = "0x401BFFC")]
			Wait,
			// Token: 0x04017253 RID: 94803
			[Token(Token = "0x401BFFD")]
			UpDown,
			// Token: 0x04017254 RID: 94804
			[Token(Token = "0x401BFFE")]
			Max
		}
	}
}
