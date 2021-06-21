using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Field
{
	// Token: 0x02001101 RID: 4353
	[Token(Token = "0x2000AF5")]
	[Serializable]
	public class RendererMaterial
	{
		// Token: 0x17000DF7 RID: 3575
		// (get) Token: 0x06006E10 RID: 28176 RVA: 0x00025E90 File Offset: 0x00024090
		// (set) Token: 0x06006E11 RID: 28177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AF1")]
		private bool CanUse
		{
			[Token(Token = "0x6005B55")]
			[Address(RVA = "0x202F420", Offset = "0x202F521", VA = "0x202F420")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005B56")]
			[Address(RVA = "0x202F5E0", Offset = "0x202F6E1", VA = "0x202F5E0")]
			set
			{
			}
		}

		// Token: 0x06006E12 RID: 28178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B57")]
		[Address(RVA = "0x202F460", Offset = "0x202F561", VA = "0x202F460")]
		public void Init()
		{
		}

		// Token: 0x06006E13 RID: 28179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B58")]
		[Address(RVA = "0x202AD50", Offset = "0x202AE51", VA = "0x202AD50")]
		public Material GetRendererMaterial()
		{
			return null;
		}

		// Token: 0x06006E14 RID: 28180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B59")]
		[Address(RVA = "0x202C380", Offset = "0x202C481", VA = "0x202C380")]
		public MaterialPropertyBlock GetMaterialPropertyBlock()
		{
			return null;
		}

		// Token: 0x06006E15 RID: 28181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B5A")]
		[Address(RVA = "0x202F5F0", Offset = "0x202F6F1", VA = "0x202F5F0")]
		public void SetMaterialPropertyBlock(MaterialPropertyBlock propertyBlock)
		{
		}

		// Token: 0x06006E16 RID: 28182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B5B")]
		[Address(RVA = "0x202F310", Offset = "0x202F411", VA = "0x202F310")]
		public void SetMaterial(Material material)
		{
		}

		// Token: 0x06006E17 RID: 28183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B5C")]
		[Address(RVA = "0x202C3D0", Offset = "0x202C4D1", VA = "0x202C3D0")]
		public void UpdateMaterialPropertyBlock()
		{
		}

		// Token: 0x06006E18 RID: 28184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B5D")]
		[Address(RVA = "0x202F680", Offset = "0x202F781", VA = "0x202F680")]
		public RendererMaterial()
		{
		}

		// Token: 0x040180D1 RID: 98513
		[Token(Token = "0x4014BAE")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Renderer Renderer;

		// Token: 0x040180D2 RID: 98514
		[Token(Token = "0x4014BAF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int MaterialIndex;

		// Token: 0x040180D3 RID: 98515
		[Token(Token = "0x4014BB0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Material Material;

		// Token: 0x040180D4 RID: 98516
		[Token(Token = "0x4014BB1")]
		[FieldOffset(Offset = "0x28")]
		private MaterialPropertyBlock PropertyBlock;

		// Token: 0x040180D5 RID: 98517
		[Token(Token = "0x4014BB2")]
		[FieldOffset(Offset = "0x30")]
		private Material[] SharedMaterials;

		// Token: 0x040180D6 RID: 98518
		[Token(Token = "0x4014BB3")]
		[FieldOffset(Offset = "0x38")]
		private bool _IsInit;

		// Token: 0x040180D7 RID: 98519
		[Token(Token = "0x4014BB4")]
		[FieldOffset(Offset = "0x39")]
		private bool _CanUse;
	}
}
