using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B3C RID: 2876
[Token(Token = "0x2000782")]
[Attribute(Name = "ExecuteInEditMode", RVA = "0x147220", Offset = "0x147321")]
[Attribute(Name = "AddComponentMenu", RVA = "0x147220", Offset = "0x147321")]
public class CameraFilterPack_Glow_Glow_Color : MonoBehaviour
{
	// Token: 0x170009D3 RID: 2515
	// (get) Token: 0x06004A29 RID: 18985 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007D5")]
	private Material material
	{
		[Token(Token = "0x6003E17")]
		[Address(RVA = "0x1E763A0", Offset = "0x1E764A1", VA = "0x1E763A0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06004A2A RID: 18986 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E18")]
	[Address(RVA = "0x1E76480", Offset = "0x1E76581", VA = "0x1E76480")]
	private void Start()
	{
	}

	// Token: 0x06004A2B RID: 18987 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E19")]
	[Address(RVA = "0x1E76510", Offset = "0x1E76611", VA = "0x1E76510")]
	private void OnRenderImage(RenderTexture sourceTexture, RenderTexture destTexture)
	{
	}

	// Token: 0x06004A2C RID: 18988 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E1A")]
	[Address(RVA = "0x1E769A0", Offset = "0x1E76AA1", VA = "0x1E769A0")]
	private void Update()
	{
	}

	// Token: 0x06004A2D RID: 18989 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E1B")]
	[Address(RVA = "0x1E769B0", Offset = "0x1E76AB1", VA = "0x1E769B0")]
	private void OnDisable()
	{
	}

	// Token: 0x06004A2E RID: 18990 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E1C")]
	[Address(RVA = "0x1E76A70", Offset = "0x1E76B71", VA = "0x1E76A70")]
	public CameraFilterPack_Glow_Glow_Color()
	{
	}

	// Token: 0x0400AA47 RID: 43591
	[Token(Token = "0x400806D")]
	[FieldOffset(Offset = "0x18")]
	public Shader SCShader;

	// Token: 0x0400AA48 RID: 43592
	[Token(Token = "0x400806E")]
	[FieldOffset(Offset = "0x20")]
	private float TimeX;

	// Token: 0x0400AA49 RID: 43593
	[Token(Token = "0x400806F")]
	[FieldOffset(Offset = "0x28")]
	private Material SCMaterial;

	// Token: 0x0400AA4A RID: 43594
	[Token(Token = "0x4008070")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "RangeAttribute", RVA = "0x1748E0", Offset = "0x1749E1")]
	public float Amount;

	// Token: 0x0400AA4B RID: 43595
	[Token(Token = "0x4008071")]
	[FieldOffset(Offset = "0x34")]
	[Attribute(Name = "RangeAttribute", RVA = "0x174900", Offset = "0x174A01")]
	public int FastFilter;

	// Token: 0x0400AA4C RID: 43596
	[Token(Token = "0x4008072")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "RangeAttribute", RVA = "0x174920", Offset = "0x174A21")]
	public float Threshold;

	// Token: 0x0400AA4D RID: 43597
	[Token(Token = "0x4008073")]
	[FieldOffset(Offset = "0x3C")]
	[Attribute(Name = "RangeAttribute", RVA = "0x174940", Offset = "0x174A41")]
	public float Intensity;

	// Token: 0x0400AA4E RID: 43598
	[Token(Token = "0x4008074")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "RangeAttribute", RVA = "0x174960", Offset = "0x174A61")]
	public float Precision;

	// Token: 0x0400AA4F RID: 43599
	[Token(Token = "0x4008075")]
	[FieldOffset(Offset = "0x44")]
	public Color GlowColor;
}
