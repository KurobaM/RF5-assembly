using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Funly.SkyStudio
{
	// Token: 0x02000DD6 RID: 3542
	[Token(Token = "0x2000902")]
	[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x148BD0", Offset = "0x148CD1")]
	public class LightningArtSet : SpriteArtSet
	{
		// Token: 0x06005B97 RID: 23447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BB2")]
		[Address(RVA = "0x23D6B50", Offset = "0x23D6C51", VA = "0x23D6B50")]
		public LightningArtSet()
		{
		}

		// Token: 0x0400BB15 RID: 47893
		[Token(Token = "0x4008B94")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17D010", Offset = "0x17D111")]
		public List<LightningArtItem> lightingStyleItems;
	}
}
