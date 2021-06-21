using System;
using System.Collections.Generic;
using FxProNS;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200001E RID: 30
[Token(Token = "0x200001D")]
[Attribute(Name = "ExecuteInEditMode", RVA = "0x144BD0", Offset = "0x144CD1")]
[Attribute(Name = "RequireComponent", RVA = "0x144BD0", Offset = "0x144CD1")]
[Attribute(Name = "AddComponentMenu", RVA = "0x144BD0", Offset = "0x144CD1")]
public class FxPro : MonoBehaviour
{
	// Token: 0x17000009 RID: 9
	// (get) Token: 0x0600004F RID: 79 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000009")]
	public static Material Mat
	{
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x23F1390", Offset = "0x23F1491", VA = "0x23F1390")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x06000050 RID: 80 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700000A")]
	private static Material TapMat
	{
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x23F1490", Offset = "0x23F1591", VA = "0x23F1490")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x06000051 RID: 81 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700000B")]
	private Camera EffectCamera
	{
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x23F1590", Offset = "0x23F1691", VA = "0x23F1590")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000052 RID: 82 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000052")]
	[Address(RVA = "0x23F1640", Offset = "0x23F1741", VA = "0x23F1640")]
	public void Start()
	{
	}

	// Token: 0x06000053 RID: 83 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000053")]
	[Address(RVA = "0x23F1B40", Offset = "0x23F1C41", VA = "0x23F1B40")]
	public void Init(bool searchForNonDepthmapAlphaObjects = false)
	{
	}

	// Token: 0x06000054 RID: 84 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000054")]
	[Address(RVA = "0x23F2FD0", Offset = "0x23F30D1", VA = "0x23F2FD0")]
	public void OnEnable()
	{
	}

	// Token: 0x06000055 RID: 85 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000055")]
	[Address(RVA = "0x23F2FE0", Offset = "0x23F30E1", VA = "0x23F2FE0")]
	public void OnDisable()
	{
	}

	// Token: 0x06000056 RID: 86 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000056")]
	[Address(RVA = "0x23F3550", Offset = "0x23F3651", VA = "0x23F3550")]
	public void OnValidate()
	{
	}

	// Token: 0x06000057 RID: 87 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000057")]
	[Address(RVA = "0x23F3560", Offset = "0x23F3661", VA = "0x23F3560")]
	public static RenderTexture DownsampleTex(RenderTexture input, float downsampleBy)
	{
		return null;
	}

	// Token: 0x06000058 RID: 88 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000058")]
	[Address(RVA = "0x23F3BD0", Offset = "0x23F3CD1", VA = "0x23F3BD0")]
	private RenderTexture ApplyColorEffects(RenderTexture input)
	{
		return null;
	}

	// Token: 0x06000059 RID: 89 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000059")]
	[Address(RVA = "0x23F3D50", Offset = "0x23F3E51", VA = "0x23F3D50")]
	private RenderTexture ApplyLensCurvature(RenderTexture input)
	{
		return null;
	}

	// Token: 0x0600005A RID: 90 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600005A")]
	[Address(RVA = "0x23F3EE0", Offset = "0x23F3FE1", VA = "0x23F3EE0")]
	private RenderTexture ApplyChromaticAberration(RenderTexture input)
	{
		return null;
	}

	// Token: 0x0600005B RID: 91 RVA: 0x000022C8 File Offset: 0x000004C8
	[Token(Token = "0x600005B")]
	[Address(RVA = "0x23F4090", Offset = "0x23F4191", VA = "0x23F4090")]
	private Vector2 ApplyLensCurvature(Vector2 uv, float barrelPower, bool precise)
	{
		return default(Vector2);
	}

	// Token: 0x0600005C RID: 92 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600005C")]
	[Address(RVA = "0x23F2F20", Offset = "0x23F3021", VA = "0x23F2F20")]
	private void UpdateLensCurvatureZoom()
	{
	}

	// Token: 0x0600005D RID: 93 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600005D")]
	[Address(RVA = "0x23F4400", Offset = "0x23F4501", VA = "0x23F4400")]
	private void UpdateFilmGrain()
	{
	}

	// Token: 0x0600005E RID: 94 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600005E")]
	[Address(RVA = "0x23F45E0", Offset = "0x23F46E1", VA = "0x23F45E0")]
	private void RenderEffects(RenderTexture source, RenderTexture destination)
	{
	}

	// Token: 0x0600005F RID: 95 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600005F")]
	[Address(RVA = "0x23F6240", Offset = "0x23F6341", VA = "0x23F6240")]
	[Attribute(Name = "ImageEffectTransformsToLDR", RVA = "0x199BA0", Offset = "0x199CA1")]
	public void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	// Token: 0x06000060 RID: 96 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000060")]
	[Address(RVA = "0x23F6410", Offset = "0x23F6511", VA = "0x23F6410")]
	public FxPro()
	{
	}

	// Token: 0x0400003D RID: 61
	[Token(Token = "0x4000038")]
	[FieldOffset(Offset = "0x18")]
	public EffectsQuality Quality;

	// Token: 0x0400003E RID: 62
	[Token(Token = "0x4000039")]
	[FieldOffset(Offset = "0x0")]
	private static Material _mat;

	// Token: 0x0400003F RID: 63
	[Token(Token = "0x400003A")]
	[FieldOffset(Offset = "0x8")]
	private static Material _tapMat;

	// Token: 0x04000040 RID: 64
	[Token(Token = "0x400003B")]
	[FieldOffset(Offset = "0x20")]
	private Camera _effectCamera;

	// Token: 0x04000041 RID: 65
	[Token(Token = "0x400003C")]
	[FieldOffset(Offset = "0x28")]
	public bool BloomEnabled;

	// Token: 0x04000042 RID: 66
	[Token(Token = "0x400003D")]
	[FieldOffset(Offset = "0x30")]
	public BloomHelperParams BloomParams;

	// Token: 0x04000043 RID: 67
	[Token(Token = "0x400003E")]
	[FieldOffset(Offset = "0x38")]
	public bool VisualizeBloom;

	// Token: 0x04000044 RID: 68
	[Token(Token = "0x400003F")]
	[FieldOffset(Offset = "0x40")]
	public Texture2D LensDirtTexture;

	// Token: 0x04000045 RID: 69
	[Token(Token = "0x4000040")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "RangeAttribute", RVA = "0x15B080", Offset = "0x15B181")]
	public float LensDirtIntensity;

	// Token: 0x04000046 RID: 70
	[Token(Token = "0x4000041")]
	[FieldOffset(Offset = "0x4C")]
	public bool ChromaticAberration;

	// Token: 0x04000047 RID: 71
	[Token(Token = "0x4000042")]
	[FieldOffset(Offset = "0x4D")]
	public bool ChromaticAberrationPrecise;

	// Token: 0x04000048 RID: 72
	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "RangeAttribute", RVA = "0x15B0A0", Offset = "0x15B1A1")]
	public float ChromaticAberrationOffset;

	// Token: 0x04000049 RID: 73
	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x54")]
	[Attribute(Name = "RangeAttribute", RVA = "0x15B0C0", Offset = "0x15B1C1")]
	public float SCurveIntensity;

	// Token: 0x0400004A RID: 74
	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x58")]
	public bool LensCurvatureEnabled;

	// Token: 0x0400004B RID: 75
	[Token(Token = "0x4000046")]
	[FieldOffset(Offset = "0x5C")]
	[Attribute(Name = "RangeAttribute", RVA = "0x15B0E0", Offset = "0x15B1E1")]
	public float LensCurvaturePower;

	// Token: 0x0400004C RID: 76
	[Token(Token = "0x4000047")]
	[FieldOffset(Offset = "0x60")]
	public bool LensCurvaturePrecise;

	// Token: 0x0400004D RID: 77
	[Token(Token = "0x4000048")]
	[FieldOffset(Offset = "0x64")]
	[Attribute(Name = "RangeAttribute", RVA = "0x15B100", Offset = "0x15B201")]
	public float FilmGrainIntensity;

	// Token: 0x0400004E RID: 78
	[Token(Token = "0x4000049")]
	[FieldOffset(Offset = "0x68")]
	[Attribute(Name = "RangeAttribute", RVA = "0x15B120", Offset = "0x15B221")]
	public float FilmGrainTiling;

	// Token: 0x0400004F RID: 79
	[Token(Token = "0x400004A")]
	[FieldOffset(Offset = "0x6C")]
	[Attribute(Name = "RangeAttribute", RVA = "0x15B140", Offset = "0x15B241")]
	public float VignettingIntensity;

	// Token: 0x04000050 RID: 80
	[Token(Token = "0x400004B")]
	[FieldOffset(Offset = "0x70")]
	public bool DOFEnabled;

	// Token: 0x04000051 RID: 81
	[Token(Token = "0x400004C")]
	[FieldOffset(Offset = "0x71")]
	public bool BlurCOCTexture;

	// Token: 0x04000052 RID: 82
	[Token(Token = "0x400004D")]
	[FieldOffset(Offset = "0x78")]
	public DOFHelperParams DOFParams;

	// Token: 0x04000053 RID: 83
	[Token(Token = "0x400004E")]
	[FieldOffset(Offset = "0x80")]
	public bool VisualizeCOC;

	// Token: 0x04000054 RID: 84
	[Token(Token = "0x400004F")]
	[FieldOffset(Offset = "0x88")]
	private List<Texture2D> _filmGrainTextures;

	// Token: 0x04000055 RID: 85
	[Token(Token = "0x4000050")]
	[FieldOffset(Offset = "0x90")]
	public bool ColorEffectsEnabled;

	// Token: 0x04000056 RID: 86
	[Token(Token = "0x4000051")]
	[FieldOffset(Offset = "0x94")]
	public Color CloseTint;

	// Token: 0x04000057 RID: 87
	[Token(Token = "0x4000052")]
	[FieldOffset(Offset = "0xA4")]
	public Color FarTint;

	// Token: 0x04000058 RID: 88
	[Token(Token = "0x4000053")]
	[FieldOffset(Offset = "0xB4")]
	[Attribute(Name = "RangeAttribute", RVA = "0x15B160", Offset = "0x15B261")]
	public float CloseTintStrength;

	// Token: 0x04000059 RID: 89
	[Token(Token = "0x4000054")]
	[FieldOffset(Offset = "0xB8")]
	[Attribute(Name = "RangeAttribute", RVA = "0x15B180", Offset = "0x15B281")]
	public float FarTintStrength;

	// Token: 0x0400005A RID: 90
	[Token(Token = "0x4000055")]
	[FieldOffset(Offset = "0xBC")]
	[Attribute(Name = "RangeAttribute", RVA = "0x15B1A0", Offset = "0x15B2A1")]
	public float DesaturateDarksStrength;

	// Token: 0x0400005B RID: 91
	[Token(Token = "0x4000056")]
	[FieldOffset(Offset = "0xC0")]
	[Attribute(Name = "RangeAttribute", RVA = "0x15B1C0", Offset = "0x15B2C1")]
	public float DesaturateFarObjsStrength;

	// Token: 0x0400005C RID: 92
	[Token(Token = "0x4000057")]
	[FieldOffset(Offset = "0xC4")]
	public Color FogTint;

	// Token: 0x0400005D RID: 93
	[Token(Token = "0x4000058")]
	[FieldOffset(Offset = "0xD4")]
	[Attribute(Name = "RangeAttribute", RVA = "0x15B1E0", Offset = "0x15B2E1")]
	public float FogStrength;

	// Token: 0x0400005E RID: 94
	[Token(Token = "0x4000059")]
	[FieldOffset(Offset = "0xD8")]
	public bool HalfResolution;
}
