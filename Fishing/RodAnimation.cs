using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Fishing
{
	// Token: 0x0200106E RID: 4206
	[Token(Token = "0x2000AA9")]
	public class RodAnimation : MonoBehaviour
	{
		// Token: 0x06006A34 RID: 27188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600587A")]
		[Address(RVA = "0x1EC5720", Offset = "0x1EC5821", VA = "0x1EC5720")]
		public void SetAnime(RodAnimation.RodAnime anime)
		{
		}

		// Token: 0x06006A35 RID: 27189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600587B")]
		[Address(RVA = "0x1EC5790", Offset = "0x1EC5891", VA = "0x1EC5790")]
		public RodAnimation()
		{
		}

		// Token: 0x04017247 RID: 94791
		[Token(Token = "0x4013E60")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Animator m_Animator;

		// Token: 0x0200106F RID: 4207
		[Token(Token = "0x2001531")]
		public enum RodAnime
		{
			// Token: 0x04017249 RID: 94793
			[Token(Token = "0x401BFF4")]
			Wait,
			// Token: 0x0401724A RID: 94794
			[Token(Token = "0x401BFF5")]
			SinariAStart,
			// Token: 0x0401724B RID: 94795
			[Token(Token = "0x401BFF6")]
			SinariAEnd,
			// Token: 0x0401724C RID: 94796
			[Token(Token = "0x401BFF7")]
			SinariBStart,
			// Token: 0x0401724D RID: 94797
			[Token(Token = "0x401BFF8")]
			SinariBEnd,
			// Token: 0x0401724E RID: 94798
			[Token(Token = "0x401BFF9")]
			SinariCStart,
			// Token: 0x0401724F RID: 94799
			[Token(Token = "0x401BFFA")]
			Max
		}
	}
}
