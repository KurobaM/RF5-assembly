using System;
using Il2CppDummyDll;

namespace Funly.SkyStudio
{
	// Token: 0x02000DD7 RID: 3543
	[Token(Token = "0x2000903")]
	[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x148C30", Offset = "0x148D31")]
	public class RainSplashArtItem : SpriteArtItem
	{
		// Token: 0x06005B98 RID: 23448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BB3")]
		[Address(RVA = "0x23DB6B0", Offset = "0x23DB7B1", VA = "0x23DB6B0")]
		public RainSplashArtItem()
		{
		}

		// Token: 0x0400BB16 RID: 47894
		[Token(Token = "0x4008B95")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17D050", Offset = "0x17D151")]
		public float intensityMultiplier;

		// Token: 0x0400BB17 RID: 47895
		[Token(Token = "0x4008B96")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17D070", Offset = "0x17D171")]
		public float scaleMultiplier;
	}
}
