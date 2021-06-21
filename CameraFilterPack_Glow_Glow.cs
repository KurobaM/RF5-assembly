using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B3B RID: 2875
[Token(Token = "0x2000781")]
[Attribute(Name = "ExecuteInEditMode", RVA = "0x1471D0", Offset = "0x1472D1")]
[Attribute(Name = "AddComponentMenu", RVA = "0x1471D0", Offset = "0x1472D1")]
public class CameraFilterPack_Glow_Glow : MonoBehaviour
{
	// Token: 0x170009D2 RID: 2514
	// (get) Token: 0x06004A23 RID: 18979 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007D4")]
	private Material material
	{
		[Token(Token = "0x6003E11")]
		[Address(RVA = "0x1E75CD0", Offset = "0x1E75DD1", VA = "0x1E75CD0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06004A24 RID: 18980 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E12")]
	[Address(RVA = "0x1E75DB0", Offset = "0x1E75EB1", VA = "0x1E75DB0")]
	private void Start()
	{
	}

	// Token: 0x06004A25 RID: 18981 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E13")]
	[Address(RVA = "0x1E75E40", Offset = "0x1E75F41", VA = "0x1E75E40")]
	private void OnRenderImage(RenderTexture sourceTexture, RenderTexture destTexture)
	{
	}

	// Token: 0x06004A26 RID: 18982 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E14")]
	[Address(RVA = "0x1E762A0", Offset = "0x1E763A1", VA = "0x1E762A0")]
	private void Update()
	{
	}

	// Token: 0x06004A27 RID: 18983 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E15")]
	[Address(RVA = "0x1E762B0", Offset = "0x1E763B1", VA = "0x1E762B0")]
	private void OnDisable()
	{
	}

	// Token: 0x06004A28 RID: 18984 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E16")]
	[Address(RVA = "0x1E76370", Offset = "0x1E76471", VA = "0x1E76370")]
	public CameraFilterPack_Glow_Glow()
	{
	}

	// Token: 0x0400AA3F RID: 43583
	[Token(Token = "0x4008065")]
	[FieldOffset(Offset = "0x18")]
	public Shader SCShader;

	// Token: 0x0400AA40 RID: 43584
	[Token(Token = "0x4008066")]
	[FieldOffset(Offset = "0x20")]
	private float TimeX;

	// Token: 0x0400AA41 RID: 43585
	[Token(Token = "0x4008067")]
	[FieldOffset(Offset = "0x28")]
	private Material SCMaterial;

	// Token: 0x0400AA42 RID: 43586
	[Token(Token = "0x4008068")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "RangeAttribute", RVA = "0x174840", Offset = "0x174941")]
	public float Amount;

	// Token: 0x0400AA43 RID: 43587
	[Token(Token = "0x4008069")]
	[FieldOffset(Offset = "0x34")]
	[Attribute(Name = "RangeAttribute", RVA = "0x174860", Offset = "0x174961")]
	public int FastFilter;

	// Token: 0x0400AA44 RID: 43588
	[Token(Token = "0x400806A")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "RangeAttribute", RVA = "0x174880", Offset = "0x174981")]
	public float Threshold;

	// Token: 0x0400AA45 RID: 43589
	[Token(Token = "0x400806B")]
	[FieldOffset(Offset = "0x3C")]
	[Attribute(Name = "RangeAttribute", RVA = "0x1748A0", Offset = "0x1749A1")]
	public float Intensity;

	// Token: 0x0400AA46 RID: 43590
	[Token(Token = "0x400806C")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "RangeAttribute", RVA = "0x1748C0", Offset = "0x1749C1")]
	public float Precision;
}
