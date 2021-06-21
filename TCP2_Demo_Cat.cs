using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000B4D RID: 2893
[Token(Token = "0x200078C")]
public class TCP2_Demo_Cat : MonoBehaviour
{
	// Token: 0x170009D4 RID: 2516
	// (get) Token: 0x06004A73 RID: 19059 RVA: 0x00017D48 File Offset: 0x00015F48
	// (set) Token: 0x06004A74 RID: 19060 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170007D6")]
	public bool animate
	{
		[Token(Token = "0x6003E58")]
		[Address(RVA = "0x1FB99B0", Offset = "0x1FB9AB1", VA = "0x1FB99B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8BF0", Offset = "0x1A8CF1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003E59")]
		[Address(RVA = "0x1FB99C0", Offset = "0x1FB9AC1", VA = "0x1FB99C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8C00", Offset = "0x1A8D01")]
		set
		{
		}
	}

	// Token: 0x170009D5 RID: 2517
	// (get) Token: 0x06004A75 RID: 19061 RVA: 0x00017D60 File Offset: 0x00015F60
	// (set) Token: 0x06004A76 RID: 19062 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170007D7")]
	public bool rotateLights
	{
		[Token(Token = "0x6003E5A")]
		[Address(RVA = "0x1FB99D0", Offset = "0x1FB9AD1", VA = "0x1FB99D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8C10", Offset = "0x1A8D11")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003E5B")]
		[Address(RVA = "0x1FB99E0", Offset = "0x1FB9AE1", VA = "0x1FB99E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8C20", Offset = "0x1A8D21")]
		set
		{
		}
	}

	// Token: 0x170009D6 RID: 2518
	// (get) Token: 0x06004A77 RID: 19063 RVA: 0x00017D78 File Offset: 0x00015F78
	// (set) Token: 0x06004A78 RID: 19064 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170007D8")]
	public bool rotatePointLights
	{
		[Token(Token = "0x6003E5C")]
		[Address(RVA = "0x1FB99F0", Offset = "0x1FB9AF1", VA = "0x1FB99F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8C30", Offset = "0x1A8D31")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003E5D")]
		[Address(RVA = "0x1FB9A00", Offset = "0x1FB9B01", VA = "0x1FB9A00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8C40", Offset = "0x1A8D41")]
		set
		{
		}
	}

	// Token: 0x06004A79 RID: 19065 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E5E")]
	[Address(RVA = "0x1FB9A10", Offset = "0x1FB9B11", VA = "0x1FB9A10")]
	private void Awake()
	{
	}

	// Token: 0x06004A7A RID: 19066 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E5F")]
	[Address(RVA = "0x1FBA6E0", Offset = "0x1FBA7E1", VA = "0x1FBA6E0")]
	private void Update()
	{
	}

	// Token: 0x06004A7B RID: 19067 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E60")]
	[Address(RVA = "0x1FBA970", Offset = "0x1FBAA71", VA = "0x1FBA970")]
	private void UpdateAnimation()
	{
	}

	// Token: 0x06004A7C RID: 19068 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E61")]
	[Address(RVA = "0x1FB9A70", Offset = "0x1FB9B71", VA = "0x1FB9A70")]
	public void SetAmbience(int index)
	{
	}

	// Token: 0x06004A7D RID: 19069 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E62")]
	[Address(RVA = "0x1FB9D00", Offset = "0x1FB9E01", VA = "0x1FB9D00")]
	public void SetStyle(int index)
	{
	}

	// Token: 0x06004A7E RID: 19070 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E63")]
	[Address(RVA = "0x1FBA270", Offset = "0x1FBA371", VA = "0x1FBA270")]
	public void SetFlat(bool flat)
	{
	}

	// Token: 0x06004A7F RID: 19071 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E64")]
	[Address(RVA = "0x1FB9F40", Offset = "0x1FBA041", VA = "0x1FB9F40")]
	public void SetCat(bool cat)
	{
	}

	// Token: 0x06004A80 RID: 19072 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E65")]
	[Address(RVA = "0x1FBAAB0", Offset = "0x1FBABB1", VA = "0x1FBAAB0")]
	public void SetLightShadows(bool on)
	{
	}

	// Token: 0x06004A81 RID: 19073 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E66")]
	[Address(RVA = "0x1FBA510", Offset = "0x1FBA611", VA = "0x1FBA510")]
	public void SetAnimation(int index)
	{
	}

	// Token: 0x06004A82 RID: 19074 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E67")]
	[Address(RVA = "0x1FBAC10", Offset = "0x1FBAD11", VA = "0x1FBAC10")]
	public TCP2_Demo_Cat()
	{
	}

	// Token: 0x0400AAB7 RID: 43703
	[Token(Token = "0x40080C0")]
	[FieldOffset(Offset = "0x18")]
	public TCP2_Demo_Cat.Ambience[] ambiences;

	// Token: 0x0400AAB8 RID: 43704
	[Token(Token = "0x40080C1")]
	[FieldOffset(Offset = "0x20")]
	public int amb;

	// Token: 0x0400AAB9 RID: 43705
	[Token(Token = "0x40080C2")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "SpaceAttribute", RVA = "0x174B40", Offset = "0x174C41")]
	public TCP2_Demo_Cat.ShaderStyle[] styles;

	// Token: 0x0400AABA RID: 43706
	[Token(Token = "0x40080C3")]
	[FieldOffset(Offset = "0x30")]
	public int style;

	// Token: 0x0400AABB RID: 43707
	[Token(Token = "0x40080C4")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "SpaceAttribute", RVA = "0x174B50", Offset = "0x174C51")]
	public GameObject shadedGroup;

	// Token: 0x0400AABC RID: 43708
	[Token(Token = "0x40080C5")]
	[FieldOffset(Offset = "0x40")]
	public GameObject flatGroup;

	// Token: 0x0400AABD RID: 43709
	[Token(Token = "0x40080C6")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "SpaceAttribute", RVA = "0x174B60", Offset = "0x174C61")]
	public GameObject[] cats;

	// Token: 0x0400AABE RID: 43710
	[Token(Token = "0x40080C7")]
	[FieldOffset(Offset = "0x50")]
	public GameObject[] unityChans;

	// Token: 0x0400AABF RID: 43711
	[Token(Token = "0x40080C8")]
	[FieldOffset(Offset = "0x58")]
	public GameObject unityChanCopyright;

	// Token: 0x0400AAC0 RID: 43712
	[Token(Token = "0x40080C9")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "SpaceAttribute", RVA = "0x174B70", Offset = "0x174C71")]
	public AnimationClip[] catAnimations;

	// Token: 0x0400AAC1 RID: 43713
	[Token(Token = "0x40080CA")]
	[FieldOffset(Offset = "0x68")]
	private int catAnim;

	// Token: 0x0400AAC2 RID: 43714
	[Token(Token = "0x40080CB")]
	[FieldOffset(Offset = "0x70")]
	public AnimationClip[] unityChanAnimations;

	// Token: 0x0400AAC3 RID: 43715
	[Token(Token = "0x40080CC")]
	[FieldOffset(Offset = "0x78")]
	private int uchanAnim;

	// Token: 0x0400AAC4 RID: 43716
	[Token(Token = "0x40080CD")]
	[FieldOffset(Offset = "0x7C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x174B80", Offset = "0x174C81")]
	private bool <animate>k__BackingField;

	// Token: 0x0400AAC5 RID: 43717
	[Token(Token = "0x40080CE")]
	[FieldOffset(Offset = "0x80")]
	private float animTime;

	// Token: 0x0400AAC6 RID: 43718
	[Token(Token = "0x40080CF")]
	[FieldOffset(Offset = "0x88")]
	[Attribute(Name = "SpaceAttribute", RVA = "0x174B90", Offset = "0x174C91")]
	public Light[] dirLights;

	// Token: 0x0400AAC7 RID: 43719
	[Token(Token = "0x40080D0")]
	[FieldOffset(Offset = "0x90")]
	public Light[] otherLights;

	// Token: 0x0400AAC8 RID: 43720
	[Token(Token = "0x40080D1")]
	[FieldOffset(Offset = "0x98")]
	public Transform rotatingPointLights;

	// Token: 0x0400AAC9 RID: 43721
	[Token(Token = "0x40080D2")]
	[FieldOffset(Offset = "0xA0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x174BA0", Offset = "0x174CA1")]
	private bool <rotateLights>k__BackingField;

	// Token: 0x0400AACA RID: 43722
	[Token(Token = "0x40080D3")]
	[FieldOffset(Offset = "0xA1")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x174BB0", Offset = "0x174CB1")]
	private bool <rotatePointLights>k__BackingField;

	// Token: 0x0400AACB RID: 43723
	[Token(Token = "0x40080D4")]
	[FieldOffset(Offset = "0xA8")]
	[Attribute(Name = "SpaceAttribute", RVA = "0x174BC0", Offset = "0x174CC1")]
	public Button[] ambiencesButtons;

	// Token: 0x0400AACC RID: 43724
	[Token(Token = "0x40080D5")]
	[FieldOffset(Offset = "0xB0")]
	public Button[] stylesButtons;

	// Token: 0x0400AACD RID: 43725
	[Token(Token = "0x40080D6")]
	[FieldOffset(Offset = "0xB8")]
	public Button[] characterButtons;

	// Token: 0x0400AACE RID: 43726
	[Token(Token = "0x40080D7")]
	[FieldOffset(Offset = "0xC0")]
	public Button[] textureButtons;

	// Token: 0x0400AACF RID: 43727
	[Token(Token = "0x40080D8")]
	[FieldOffset(Offset = "0xC8")]
	public Button[] animationButtons;

	// Token: 0x0400AAD0 RID: 43728
	[Token(Token = "0x40080D9")]
	[FieldOffset(Offset = "0xD0")]
	[Attribute(Name = "SpaceAttribute", RVA = "0x174BD0", Offset = "0x174CD1")]
	public Canvas canvas;

	// Token: 0x02000B4E RID: 2894
	[Token(Token = "0x2001343")]
	[Serializable]
	public class Ambience
	{
		// Token: 0x06004A83 RID: 19075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076FF")]
		[Address(RVA = "0x1FBAC20", Offset = "0x1FBAD21", VA = "0x1FBAC20")]
		public Ambience()
		{
		}

		// Token: 0x0400AAD1 RID: 43729
		[Token(Token = "0x401B65A")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x0400AAD2 RID: 43730
		[Token(Token = "0x401B65B")]
		[FieldOffset(Offset = "0x18")]
		public GameObject[] activate;

		// Token: 0x0400AAD3 RID: 43731
		[Token(Token = "0x401B65C")]
		[FieldOffset(Offset = "0x20")]
		public Material skybox;
	}

	// Token: 0x02000B4F RID: 2895
	[Token(Token = "0x2001344")]
	[Serializable]
	public class ShaderStyle
	{
		// Token: 0x06004A84 RID: 19076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007700")]
		[Address(RVA = "0x1FBAC30", Offset = "0x1FBAD31", VA = "0x1FBAC30")]
		public ShaderStyle()
		{
		}

		// Token: 0x0400AAD4 RID: 43732
		[Token(Token = "0x401B65D")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x0400AAD5 RID: 43733
		[Token(Token = "0x401B65E")]
		[FieldOffset(Offset = "0x18")]
		public TCP2_Demo_Cat.ShaderStyle.CharacterSettings[] settings;

		// Token: 0x02000B50 RID: 2896
		[Token(Token = "0x2001651")]
		[Serializable]
		public class CharacterSettings
		{
			// Token: 0x06004A85 RID: 19077 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60080A3")]
			[Address(RVA = "0x1FBAC40", Offset = "0x1FBAD41", VA = "0x1FBAC40")]
			public CharacterSettings()
			{
			}

			// Token: 0x0400AAD6 RID: 43734
			[Token(Token = "0x401C400")]
			[FieldOffset(Offset = "0x10")]
			public Material material;

			// Token: 0x0400AAD7 RID: 43735
			[Token(Token = "0x401C401")]
			[FieldOffset(Offset = "0x18")]
			public Renderer[] renderers;
		}
	}
}
