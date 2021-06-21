using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000B55 RID: 2901
[Token(Token = "0x200078F")]
public class TCP2_Demo_PBS : MonoBehaviour
{
	// Token: 0x170009D7 RID: 2519
	// (set) Token: 0x06004A94 RID: 19092 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170007D9")]
	public bool ShowPointLights
	{
		[Token(Token = "0x6003E74")]
		[Address(RVA = "0x1FBAC80", Offset = "0x1FBAD81", VA = "0x1FBAC80")]
		set
		{
		}
	}

	// Token: 0x170009D8 RID: 2520
	// (set) Token: 0x06004A95 RID: 19093 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170007DA")]
	public bool ShowDirLight
	{
		[Token(Token = "0x6003E75")]
		[Address(RVA = "0x1FBACA0", Offset = "0x1FBADA1", VA = "0x1FBACA0")]
		set
		{
		}
	}

	// Token: 0x170009D9 RID: 2521
	// (get) Token: 0x06004A96 RID: 19094 RVA: 0x00017D90 File Offset: 0x00015F90
	// (set) Token: 0x06004A97 RID: 19095 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170007DB")]
	public bool RotatePointLights
	{
		[Token(Token = "0x6003E76")]
		[Address(RVA = "0x1FBACC0", Offset = "0x1FBADC1", VA = "0x1FBACC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003E77")]
		[Address(RVA = "0x1FBACD0", Offset = "0x1FBADD1", VA = "0x1FBACD0")]
		set
		{
		}
	}

	// Token: 0x170009DA RID: 2522
	// (get) Token: 0x06004A98 RID: 19096 RVA: 0x00017DA8 File Offset: 0x00015FA8
	// (set) Token: 0x06004A99 RID: 19097 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170007DC")]
	public bool UseOutline
	{
		[Token(Token = "0x6003E78")]
		[Address(RVA = "0x1FBACE0", Offset = "0x1FBADE1", VA = "0x1FBACE0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003E79")]
		[Address(RVA = "0x1FBACF0", Offset = "0x1FBADF1", VA = "0x1FBACF0")]
		set
		{
		}
	}

	// Token: 0x170009DB RID: 2523
	// (set) Token: 0x06004A9A RID: 19098 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170007DD")]
	public bool UseRampTexture
	{
		[Token(Token = "0x6003E7A")]
		[Address(RVA = "0x1FBAE60", Offset = "0x1FBAF61", VA = "0x1FBAE60")]
		set
		{
		}
	}

	// Token: 0x170009DC RID: 2524
	// (set) Token: 0x06004A9B RID: 19099 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170007DE")]
	public bool UseStylizedFresnel
	{
		[Token(Token = "0x6003E7B")]
		[Address(RVA = "0x1FBAF10", Offset = "0x1FBB011", VA = "0x1FBAF10")]
		set
		{
		}
	}

	// Token: 0x170009DD RID: 2525
	// (set) Token: 0x06004A9C RID: 19100 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170007DF")]
	public bool UseStylizedSpecular
	{
		[Token(Token = "0x6003E7C")]
		[Address(RVA = "0x1FBAFC0", Offset = "0x1FBB0C1", VA = "0x1FBAFC0")]
		set
		{
		}
	}

	// Token: 0x06004A9D RID: 19101 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E7D")]
	[Address(RVA = "0x1FBB070", Offset = "0x1FBB171", VA = "0x1FBB070")]
	private void Awake()
	{
	}

	// Token: 0x06004A9E RID: 19102 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E7E")]
	[Address(RVA = "0x1FBB580", Offset = "0x1FBB681", VA = "0x1FBB580")]
	private void Update()
	{
	}

	// Token: 0x06004A9F RID: 19103 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E7F")]
	[Address(RVA = "0x1FBB7A0", Offset = "0x1FBB8A1", VA = "0x1FBB7A0")]
	public void ToggleShader()
	{
	}

	// Token: 0x06004AA0 RID: 19104 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E80")]
	[Address(RVA = "0x1FBB720", Offset = "0x1FBB821", VA = "0x1FBB720")]
	public void NextSky()
	{
	}

	// Token: 0x06004AA1 RID: 19105 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E81")]
	[Address(RVA = "0x1FBB760", Offset = "0x1FBB861", VA = "0x1FBB760")]
	public void PrevSky()
	{
	}

	// Token: 0x06004AA2 RID: 19106 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E82")]
	[Address(RVA = "0x1FBB920", Offset = "0x1FBBA21", VA = "0x1FBB920")]
	public void NextRamp()
	{
	}

	// Token: 0x06004AA3 RID: 19107 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E83")]
	[Address(RVA = "0x1FBB960", Offset = "0x1FBBA61", VA = "0x1FBB960")]
	public void PrevRamp()
	{
	}

	// Token: 0x06004AA4 RID: 19108 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E84")]
	[Address(RVA = "0x1FBB9A0", Offset = "0x1FBBAA1", VA = "0x1FBB9A0")]
	public void SetMetallic(float f)
	{
	}

	// Token: 0x06004AA5 RID: 19109 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E85")]
	[Address(RVA = "0x1FBBA50", Offset = "0x1FBBB51", VA = "0x1FBBA50")]
	public void SetSmoothness(float f)
	{
	}

	// Token: 0x06004AA6 RID: 19110 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E86")]
	[Address(RVA = "0x1FBBB00", Offset = "0x1FBBC01", VA = "0x1FBBB00")]
	public void SetBumpScale(float f)
	{
	}

	// Token: 0x06004AA7 RID: 19111 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E87")]
	[Address(RVA = "0x1FBBBB0", Offset = "0x1FBBCB1", VA = "0x1FBBBB0")]
	public void SetRampThreshold(float f)
	{
	}

	// Token: 0x06004AA8 RID: 19112 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E88")]
	[Address(RVA = "0x1FBBC60", Offset = "0x1FBBD61", VA = "0x1FBBC60")]
	public void SetRampSmooth(float f)
	{
	}

	// Token: 0x06004AA9 RID: 19113 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E89")]
	[Address(RVA = "0x1FBBD10", Offset = "0x1FBBE11", VA = "0x1FBBD10")]
	public void SetRampSmoothAdd(float f)
	{
	}

	// Token: 0x06004AAA RID: 19114 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E8A")]
	[Address(RVA = "0x1FBB430", Offset = "0x1FBB531", VA = "0x1FBB430")]
	private void UpdateRamp()
	{
	}

	// Token: 0x06004AAB RID: 19115 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E8B")]
	[Address(RVA = "0x1FBB240", Offset = "0x1FBB341", VA = "0x1FBB240")]
	private void UpdateSky()
	{
	}

	// Token: 0x06004AAC RID: 19116 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E8C")]
	[Address(RVA = "0x1FBB8B0", Offset = "0x1FBB9B1", VA = "0x1FBB8B0")]
	private void ShowUnityStandardShader()
	{
	}

	// Token: 0x06004AAD RID: 19117 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E8D")]
	[Address(RVA = "0x1FBADA0", Offset = "0x1FBAEA1", VA = "0x1FBADA0")]
	public void ShowTCP2Shader()
	{
	}

	// Token: 0x06004AAE RID: 19118 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E8E")]
	[Address(RVA = "0x1FBBDC0", Offset = "0x1FBBEC1", VA = "0x1FBBDC0")]
	private void ToggleKeyword(Material m, bool enabled, string keyword)
	{
	}

	// Token: 0x06004AAF RID: 19119 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E8F")]
	[Address(RVA = "0x1FBBDF0", Offset = "0x1FBBEF1", VA = "0x1FBBDF0")]
	public TCP2_Demo_PBS()
	{
	}

	// Token: 0x0400AAF8 RID: 43768
	[Token(Token = "0x40080F4")]
	[FieldOffset(Offset = "0x18")]
	public Light DirLight;

	// Token: 0x0400AAF9 RID: 43769
	[Token(Token = "0x40080F5")]
	[FieldOffset(Offset = "0x20")]
	public GameObject PointLights;

	// Token: 0x0400AAFA RID: 43770
	[Token(Token = "0x40080F6")]
	[FieldOffset(Offset = "0x28")]
	public MeshRenderer Robot;

	// Token: 0x0400AAFB RID: 43771
	[Token(Token = "0x40080F7")]
	[FieldOffset(Offset = "0x30")]
	public GameObject Canvas;

	// Token: 0x0400AAFC RID: 43772
	[Token(Token = "0x40080F8")]
	[FieldOffset(Offset = "0x38")]
	public TCP2_Demo_PBS.SkyboxSetting[] SkySettings;

	// Token: 0x0400AAFD RID: 43773
	[Token(Token = "0x40080F9")]
	[FieldOffset(Offset = "0x40")]
	public bool FlipLight;

	// Token: 0x0400AAFE RID: 43774
	[Token(Token = "0x40080FA")]
	[FieldOffset(Offset = "0x48")]
	public Texture2D[] RampTextures;

	// Token: 0x0400AAFF RID: 43775
	[Token(Token = "0x40080FB")]
	[FieldOffset(Offset = "0x50")]
	public Slider SmoothnessSlider;

	// Token: 0x0400AB00 RID: 43776
	[Token(Token = "0x40080FC")]
	[FieldOffset(Offset = "0x58")]
	public Text SmoothnessValue;

	// Token: 0x0400AB01 RID: 43777
	[Token(Token = "0x40080FD")]
	[FieldOffset(Offset = "0x60")]
	public Slider MetallicSlider;

	// Token: 0x0400AB02 RID: 43778
	[Token(Token = "0x40080FE")]
	[FieldOffset(Offset = "0x68")]
	public Text MetallicValue;

	// Token: 0x0400AB03 RID: 43779
	[Token(Token = "0x40080FF")]
	[FieldOffset(Offset = "0x70")]
	public Text BumpScaleValue;

	// Token: 0x0400AB04 RID: 43780
	[Token(Token = "0x4008100")]
	[FieldOffset(Offset = "0x78")]
	public Text ShaderText;

	// Token: 0x0400AB05 RID: 43781
	[Token(Token = "0x4008101")]
	[FieldOffset(Offset = "0x80")]
	public Text SkyboxValue;

	// Token: 0x0400AB06 RID: 43782
	[Token(Token = "0x4008102")]
	[FieldOffset(Offset = "0x88")]
	public Text RampValue;

	// Token: 0x0400AB07 RID: 43783
	[Token(Token = "0x4008103")]
	[FieldOffset(Offset = "0x90")]
	public Slider RampThresholdSlider;

	// Token: 0x0400AB08 RID: 43784
	[Token(Token = "0x4008104")]
	[FieldOffset(Offset = "0x98")]
	public Text RampThresholdValue;

	// Token: 0x0400AB09 RID: 43785
	[Token(Token = "0x4008105")]
	[FieldOffset(Offset = "0xA0")]
	public Slider RampSmoothSlider;

	// Token: 0x0400AB0A RID: 43786
	[Token(Token = "0x4008106")]
	[FieldOffset(Offset = "0xA8")]
	public Text RampSmoothValue;

	// Token: 0x0400AB0B RID: 43787
	[Token(Token = "0x4008107")]
	[FieldOffset(Offset = "0xB0")]
	public Slider RampSmoothAddSlider;

	// Token: 0x0400AB0C RID: 43788
	[Token(Token = "0x4008108")]
	[FieldOffset(Offset = "0xB8")]
	public Text RampSmoothAddValue;

	// Token: 0x0400AB0D RID: 43789
	[Token(Token = "0x4008109")]
	[FieldOffset(Offset = "0xC0")]
	public RawImage RampImage;

	// Token: 0x0400AB0E RID: 43790
	[Token(Token = "0x400810A")]
	[FieldOffset(Offset = "0xC8")]
	private int currentSky;

	// Token: 0x0400AB0F RID: 43791
	[Token(Token = "0x400810B")]
	[FieldOffset(Offset = "0xCC")]
	private int currentRamp;

	// Token: 0x0400AB10 RID: 43792
	[Token(Token = "0x400810C")]
	[FieldOffset(Offset = "0xD0")]
	private Material robotMaterial;

	// Token: 0x0400AB11 RID: 43793
	[Token(Token = "0x400810D")]
	[FieldOffset(Offset = "0xD8")]
	private bool mUseOutline;

	// Token: 0x0400AB12 RID: 43794
	[Token(Token = "0x400810E")]
	[FieldOffset(Offset = "0xD9")]
	private bool mRotatePointLights;

	// Token: 0x02000B56 RID: 2902
	[Token(Token = "0x2001347")]
	[Serializable]
	public class SkyboxSetting
	{
		// Token: 0x06004AB0 RID: 19120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007703")]
		[Address(RVA = "0x1FBBE10", Offset = "0x1FBBF11", VA = "0x1FBBE10")]
		public SkyboxSetting()
		{
		}

		// Token: 0x0400AB13 RID: 43795
		[Token(Token = "0x401B665")]
		[FieldOffset(Offset = "0x10")]
		public Material SkyMaterial;

		// Token: 0x0400AB14 RID: 43796
		[Token(Token = "0x401B666")]
		[FieldOffset(Offset = "0x18")]
		public Color lightColor;

		// Token: 0x0400AB15 RID: 43797
		[Token(Token = "0x401B667")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 DirLightEuler;
	}
}
