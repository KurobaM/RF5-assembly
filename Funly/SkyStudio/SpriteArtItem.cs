using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x02000DD9 RID: 3545
	[Token(Token = "0x2000905")]
	public class SpriteArtItem : ScriptableObject
	{
		// Token: 0x06005B9A RID: 23450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BB5")]
		[Address(RVA = "0x23E4670", Offset = "0x23E4771", VA = "0x23E4670")]
		public SpriteArtItem()
		{
		}

		// Token: 0x0400BB19 RID: 47897
		[Token(Token = "0x4008B98")]
		[FieldOffset(Offset = "0x18")]
		public Mesh mesh;

		// Token: 0x0400BB1A RID: 47898
		[Token(Token = "0x4008B99")]
		[FieldOffset(Offset = "0x20")]
		public Material material;

		// Token: 0x0400BB1B RID: 47899
		[Token(Token = "0x4008B9A")]
		[FieldOffset(Offset = "0x28")]
		public Texture spriteSheetTexture;

		// Token: 0x0400BB1C RID: 47900
		[Token(Token = "0x4008B9B")]
		[FieldOffset(Offset = "0x30")]
		public int rows;

		// Token: 0x0400BB1D RID: 47901
		[Token(Token = "0x4008B9C")]
		[FieldOffset(Offset = "0x34")]
		public int columns;

		// Token: 0x0400BB1E RID: 47902
		[Token(Token = "0x4008B9D")]
		[FieldOffset(Offset = "0x38")]
		public int totalFrames;

		// Token: 0x0400BB1F RID: 47903
		[Token(Token = "0x4008B9E")]
		[FieldOffset(Offset = "0x3C")]
		public int animateSpeed;

		// Token: 0x0400BB20 RID: 47904
		[Token(Token = "0x4008B9F")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17D090", Offset = "0x17D191")]
		public Color tintColor;
	}
}
