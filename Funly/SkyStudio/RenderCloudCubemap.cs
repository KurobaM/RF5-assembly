using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x02000E09 RID: 3593
	[Token(Token = "0x2000930")]
	[Attribute(Name = "RequireComponent", RVA = "0x148DF0", Offset = "0x148EF1")]
	public class RenderCloudCubemap : MonoBehaviour
	{
		// Token: 0x06005D63 RID: 23907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D7A")]
		[Address(RVA = "0x23DC990", Offset = "0x23DCA91", VA = "0x23DC990")]
		public RenderCloudCubemap()
		{
		}

		// Token: 0x0400BD8C RID: 48524
		[Token(Token = "0x4008DF9")]
		public const string kDefaultFilenamePrefix = "CloudCubemap";

		// Token: 0x0400BD8D RID: 48525
		[Token(Token = "0x4008DFA")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17E2F0", Offset = "0x17E3F1")]
		public string filenamePrefix;

		// Token: 0x0400BD8E RID: 48526
		[Token(Token = "0x4008DFB")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17E330", Offset = "0x17E431")]
		public int faceWidth;

		// Token: 0x0400BD8F RID: 48527
		[Token(Token = "0x4008DFC")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17E370", Offset = "0x17E471")]
		public RenderCloudCubemap.CubemapTextureFormat textureFormat;

		// Token: 0x0400BD90 RID: 48528
		[Token(Token = "0x4008DFD")]
		[FieldOffset(Offset = "0x28")]
		public bool exportFaces;

		// Token: 0x02000E0A RID: 3594
		[Token(Token = "0x2001446")]
		public enum CubemapTextureFormat
		{
			// Token: 0x0400BD92 RID: 48530
			[Token(Token = "0x401BBAB")]
			RGBColor,
			// Token: 0x0400BD93 RID: 48531
			[Token(Token = "0x401BBAC")]
			RGBAColor,
			// Token: 0x0400BD94 RID: 48532
			[Token(Token = "0x401BBAD")]
			RGBALit
		}
	}
}
