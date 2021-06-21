using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x02000DD4 RID: 3540
	[Token(Token = "0x2000901")]
	[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x148B70", Offset = "0x148C71")]
	public class LightningArtItem : SpriteArtItem
	{
		// Token: 0x06005B96 RID: 23446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BB1")]
		[Address(RVA = "0x23D6B30", Offset = "0x23D6C31", VA = "0x23D6B30")]
		public LightningArtItem()
		{
		}

		// Token: 0x0400BB0D RID: 47885
		[Token(Token = "0x4008B8F")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17CE70", Offset = "0x17CF71")]
		public LightningArtItem.Alignment alignment;

		// Token: 0x0400BB0E RID: 47886
		[Token(Token = "0x4008B90")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17CEB0", Offset = "0x17CFB1")]
		public AudioClip thunderSound;

		// Token: 0x0400BB0F RID: 47887
		[Token(Token = "0x4008B91")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17CEF0", Offset = "0x17CFF1")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17CEF0", Offset = "0x17CFF1")]
		public float strikeProbability;

		// Token: 0x0400BB10 RID: 47888
		[Token(Token = "0x4008B92")]
		[FieldOffset(Offset = "0x64")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17CF50", Offset = "0x17D051")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17CF50", Offset = "0x17D051")]
		public float size;

		// Token: 0x0400BB11 RID: 47889
		[Token(Token = "0x4008B93")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17CFB0", Offset = "0x17D0B1")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17CFB0", Offset = "0x17D0B1")]
		public float intensity;

		// Token: 0x02000DD5 RID: 3541
		[Token(Token = "0x2001440")]
		public enum Alignment
		{
			// Token: 0x0400BB13 RID: 47891
			[Token(Token = "0x401BB96")]
			ScaleToFit,
			// Token: 0x0400BB14 RID: 47892
			[Token(Token = "0x401BB97")]
			TopAlign
		}
	}
}
