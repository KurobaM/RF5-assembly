using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B49 RID: 2889
[Token(Token = "0x200078A")]
public abstract class BaseStarDataRenderer
{
	// Token: 0x14000005 RID: 5
	// (add) Token: 0x06004A5D RID: 19037 RVA: 0x00002053 File Offset: 0x00000253
	// (remove) Token: 0x06004A5E RID: 19038 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x14000005")]
	public event BaseStarDataRenderer.StarDataProgress progressCallback
	{
		[Token(Token = "0x6003E4A")]
		[Address(RVA = "0x22A12C0", Offset = "0x22A13C1", VA = "0x22A12C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8BB0", Offset = "0x1A8CB1")]
		add
		{
		}
		[Token(Token = "0x6003E4B")]
		[Address(RVA = "0x22A1370", Offset = "0x22A1471", VA = "0x22A1370")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8BC0", Offset = "0x1A8CC1")]
		remove
		{
		}
	}

	// Token: 0x14000006 RID: 6
	// (add) Token: 0x06004A5F RID: 19039 RVA: 0x00002053 File Offset: 0x00000253
	// (remove) Token: 0x06004A60 RID: 19040 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x14000006")]
	public event BaseStarDataRenderer.StarDataComplete completionCallback
	{
		[Token(Token = "0x6003E4C")]
		[Address(RVA = "0x22A1420", Offset = "0x22A1521", VA = "0x22A1420")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8BD0", Offset = "0x1A8CD1")]
		add
		{
		}
		[Token(Token = "0x6003E4D")]
		[Address(RVA = "0x22A14D0", Offset = "0x22A15D1", VA = "0x22A14D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8BE0", Offset = "0x1A8CE1")]
		remove
		{
		}
	}

	// Token: 0x06004A61 RID: 19041
	[Token(Token = "0x6003E4E")]
	public abstract IEnumerator ComputeStarData();

	// Token: 0x06004A62 RID: 19042 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E4F")]
	[Address(RVA = "0x22A1580", Offset = "0x22A1681", VA = "0x22A1580", Slot = "5")]
	public virtual void Cancel()
	{
	}

	// Token: 0x06004A63 RID: 19043 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E50")]
	[Address(RVA = "0x22A15C0", Offset = "0x22A16C1", VA = "0x22A15C0")]
	protected void SendProgress(float progress)
	{
	}

	// Token: 0x06004A64 RID: 19044 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E51")]
	[Address(RVA = "0x22A1A20", Offset = "0x22A1B21", VA = "0x22A1A20")]
	protected void SendCompletion(Texture2D texture, bool success)
	{
	}

	// Token: 0x06004A65 RID: 19045 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E52")]
	[Address(RVA = "0x22A1E90", Offset = "0x22A1F91", VA = "0x22A1E90")]
	protected BaseStarDataRenderer()
	{
	}

	// Token: 0x0400AA97 RID: 43671
	[Token(Token = "0x40080A0")]
	[FieldOffset(Offset = "0x20")]
	public float density;

	// Token: 0x0400AA98 RID: 43672
	[Token(Token = "0x40080A1")]
	[FieldOffset(Offset = "0x24")]
	public float imageSize;

	// Token: 0x0400AA99 RID: 43673
	[Token(Token = "0x40080A2")]
	[FieldOffset(Offset = "0x28")]
	public string layerId;

	// Token: 0x0400AA9A RID: 43674
	[Token(Token = "0x40080A3")]
	[FieldOffset(Offset = "0x30")]
	public float maxRadius;

	// Token: 0x0400AA9B RID: 43675
	[Token(Token = "0x40080A4")]
	[FieldOffset(Offset = "0x34")]
	protected float sphereRadius;

	// Token: 0x0400AA9C RID: 43676
	[Token(Token = "0x40080A5")]
	[FieldOffset(Offset = "0x38")]
	protected bool isCancelled;

	// Token: 0x02000B4A RID: 2890
	// (Invoke) Token: 0x06004A67 RID: 19047
	[Token(Token = "0x2001341")]
	public delegate void StarDataProgress(BaseStarDataRenderer renderer, float progress);

	// Token: 0x02000B4B RID: 2891
	// (Invoke) Token: 0x06004A6B RID: 19051
	[Token(Token = "0x2001342")]
	public delegate void StarDataComplete(BaseStarDataRenderer renderer, Texture2D texture, bool success);
}
