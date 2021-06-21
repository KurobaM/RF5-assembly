using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x02000DEA RID: 3562
	[Token(Token = "0x2000916")]
	[Serializable]
	public class TextureKeyframe : BaseKeyframe
	{
		// Token: 0x06005BE9 RID: 23529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C04")]
		[Address(RVA = "0x23EB180", Offset = "0x23EB281", VA = "0x23EB180")]
		public TextureKeyframe(Texture texture, float time)
		{
		}

		// Token: 0x06005BEA RID: 23530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C05")]
		[Address(RVA = "0x23EB1C0", Offset = "0x23EB2C1", VA = "0x23EB1C0")]
		public TextureKeyframe(TextureKeyframe keyframe)
		{
		}

		// Token: 0x0400BB3B RID: 47931
		[Token(Token = "0x4008BBA")]
		[FieldOffset(Offset = "0x28")]
		public Texture texture;
	}
}
