using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B51 RID: 2897
[Token(Token = "0x200078D")]
[Attribute(Name = "ExecuteInEditMode", RVA = "0x147330", Offset = "0x147431")]
public class TCP2_Demo_GammaLinear : MonoBehaviour
{
	// Token: 0x06004A86 RID: 19078 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E68")]
	[Address(RVA = "0x1FBAC50", Offset = "0x1FBAD51", VA = "0x1FBAC50")]
	public TCP2_Demo_GammaLinear()
	{
	}

	// Token: 0x0400AAD8 RID: 43736
	[Token(Token = "0x40080DA")]
	[FieldOffset(Offset = "0x18")]
	public TCP2_Demo_GammaLinear.LightSettings[] lights;

	// Token: 0x0400AAD9 RID: 43737
	[Token(Token = "0x40080DB")]
	[FieldOffset(Offset = "0x20")]
	public TCP2_Demo_GammaLinear.MaterialSettings[] materials;

	// Token: 0x0400AADA RID: 43738
	[Token(Token = "0x40080DC")]
	[FieldOffset(Offset = "0x28")]
	private ColorSpace lastColorSpace;

	// Token: 0x02000B52 RID: 2898
	[Token(Token = "0x2001345")]
	[Serializable]
	public class LightSettings
	{
		// Token: 0x06004A87 RID: 19079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007701")]
		[Address(RVA = "0x1FBAC60", Offset = "0x1FBAD61", VA = "0x1FBAC60")]
		public LightSettings()
		{
		}

		// Token: 0x0400AADB RID: 43739
		[Token(Token = "0x401B65F")]
		[FieldOffset(Offset = "0x10")]
		public Light light;

		// Token: 0x0400AADC RID: 43740
		[Token(Token = "0x401B660")]
		[FieldOffset(Offset = "0x18")]
		public float gammaIntensity;

		// Token: 0x0400AADD RID: 43741
		[Token(Token = "0x401B661")]
		[FieldOffset(Offset = "0x1C")]
		public float linearIntensity;
	}

	// Token: 0x02000B53 RID: 2899
	[Token(Token = "0x2001346")]
	[Serializable]
	public class MaterialSettings
	{
		// Token: 0x06004A88 RID: 19080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007702")]
		[Address(RVA = "0x1FBAC70", Offset = "0x1FBAD71", VA = "0x1FBAC70")]
		public MaterialSettings()
		{
		}

		// Token: 0x0400AADE RID: 43742
		[Token(Token = "0x401B662")]
		[FieldOffset(Offset = "0x10")]
		public Material material;

		// Token: 0x0400AADF RID: 43743
		[Token(Token = "0x401B663")]
		[FieldOffset(Offset = "0x18")]
		public Color gammaColor;

		// Token: 0x0400AAE0 RID: 43744
		[Token(Token = "0x401B664")]
		[FieldOffset(Offset = "0x28")]
		public Color linearColor;
	}
}
