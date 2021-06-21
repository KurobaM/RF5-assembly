using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x02000DE1 RID: 3553
	[Token(Token = "0x200090D")]
	[Serializable]
	public class TextureKeyframeGroup : KeyframeGroup<TextureKeyframe>
	{
		// Token: 0x06005BCE RID: 23502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BE9")]
		[Address(RVA = "0x23EB220", Offset = "0x23EB321", VA = "0x23EB220")]
		public TextureKeyframeGroup(string name, TextureKeyframe keyframe)
		{
		}

		// Token: 0x06005BCF RID: 23503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BEA")]
		[Address(RVA = "0x23EB2A0", Offset = "0x23EB3A1", VA = "0x23EB2A0")]
		public Texture TextureForTime(float time)
		{
			return null;
		}
	}
}
