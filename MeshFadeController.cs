using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002EA RID: 746
[Token(Token = "0x2000248")]
public class MeshFadeController : MonoBehaviour
{
	// Token: 0x17000382 RID: 898
	// (get) Token: 0x060013BD RID: 5053 RVA: 0x00008F58 File Offset: 0x00007158
	[Token(Token = "0x1700034A")]
	public float FadeAlpha
	{
		[Token(Token = "0x60011EF")]
		[Address(RVA = "0x1F23AE0", Offset = "0x1F23BE1", VA = "0x1F23AE0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000383 RID: 899
	// (get) Token: 0x060013BE RID: 5054 RVA: 0x00008F70 File Offset: 0x00007170
	// (set) Token: 0x060013BF RID: 5055 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700034B")]
	public float MeshAlpha
	{
		[Token(Token = "0x60011F0")]
		[Address(RVA = "0x1F23AF0", Offset = "0x1F23BF1", VA = "0x1F23AF0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19CAE0", Offset = "0x19CBE1")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60011F1")]
		[Address(RVA = "0x1F23B00", Offset = "0x1F23C01", VA = "0x1F23B00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19CAF0", Offset = "0x19CBF1")]
		private set
		{
		}
	}

	// Token: 0x060013C0 RID: 5056 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011F2")]
	[Address(RVA = "0x1F23B10", Offset = "0x1F23C11", VA = "0x1F23B10")]
	private void Awake()
	{
	}

	// Token: 0x060013C1 RID: 5057 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011F3")]
	[Address(RVA = "0x1F23B80", Offset = "0x1F23C81", VA = "0x1F23B80")]
	public void Reset()
	{
	}

	// Token: 0x060013C2 RID: 5058 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011F4")]
	[Address(RVA = "0x1F23C70", Offset = "0x1F23D71", VA = "0x1F23C70")]
	public void SetRenderer(Renderer[] renderers)
	{
	}

	// Token: 0x060013C3 RID: 5059 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011F5")]
	[Address(RVA = "0x1F23C80", Offset = "0x1F23D81", VA = "0x1F23C80")]
	public void OnUpdate()
	{
	}

	// Token: 0x060013C4 RID: 5060 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011F6")]
	[Address(RVA = "0x1F23DB0", Offset = "0x1F23EB1", VA = "0x1F23DB0")]
	public void SetFadeAlpha(float alpha)
	{
	}

	// Token: 0x060013C5 RID: 5061 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011F7")]
	[Address(RVA = "0x1F23E60", Offset = "0x1F23F61", VA = "0x1F23E60")]
	public MeshFadeController()
	{
	}

	// Token: 0x04000B11 RID: 2833
	[Token(Token = "0x40008A9")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x15F530", Offset = "0x15F631")]
	private float m_FadeAlpha;

	// Token: 0x04000B12 RID: 2834
	[Token(Token = "0x40008AA")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public Renderer[] Renderers;

	// Token: 0x04000B13 RID: 2835
	[Token(Token = "0x40008AB")]
	[FieldOffset(Offset = "0x28")]
	protected MaterialPropertyBlock materialPropertyBlock;

	// Token: 0x04000B14 RID: 2836
	[Token(Token = "0x40008AC")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15F580", Offset = "0x15F681")]
	private float <MeshAlpha>k__BackingField;
}
