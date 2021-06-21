using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Funly.SkyStudio
{
	// Token: 0x02000DD8 RID: 3544
	[Token(Token = "0x2000904")]
	[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x148C90", Offset = "0x148D91")]
	public class RainSplashArtSet : SpriteArtSet
	{
		// Token: 0x06005B99 RID: 23449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BB4")]
		[Address(RVA = "0x23DB6C0", Offset = "0x23DB7C1", VA = "0x23DB6C0")]
		public RainSplashArtSet()
		{
		}

		// Token: 0x0400BB18 RID: 47896
		[Token(Token = "0x4008B97")]
		[FieldOffset(Offset = "0x18")]
		public List<RainSplashArtItem> rainSplashArtItems;
	}
}
