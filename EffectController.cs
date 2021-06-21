using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003FF RID: 1023
[Token(Token = "0x2000320")]
public class EffectController : MonoBehaviour
{
	// Token: 0x060017A0 RID: 6048 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001503")]
	[Address(RVA = "0x22AC0D0", Offset = "0x22AC1D1", VA = "0x22AC0D0")]
	public void Reset()
	{
	}

	// Token: 0x1700041F RID: 1055
	// (get) Token: 0x060017A1 RID: 6049 RVA: 0x0000A488 File Offset: 0x00008688
	[Token(Token = "0x170003B5")]
	public bool IsLoop
	{
		[Token(Token = "0x6001504")]
		[Address(RVA = "0x22AC220", Offset = "0x22AC321", VA = "0x22AC220")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000420 RID: 1056
	// (get) Token: 0x060017A2 RID: 6050 RVA: 0x0000A4A0 File Offset: 0x000086A0
	[Token(Token = "0x170003B6")]
	public bool Active
	{
		[Token(Token = "0x6001505")]
		[Address(RVA = "0x22AC270", Offset = "0x22AC371", VA = "0x22AC270")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060017A3 RID: 6051 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001506")]
	[Address(RVA = "0x22AC290", Offset = "0x22AC391", VA = "0x22AC290")]
	public void SetSpeed(float speed)
	{
	}

	// Token: 0x060017A4 RID: 6052 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001507")]
	[Address(RVA = "0x22AC370", Offset = "0x22AC471", VA = "0x22AC370")]
	private void Start()
	{
	}

	// Token: 0x060017A5 RID: 6053 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001508")]
	[Address(RVA = "0x22AC400", Offset = "0x22AC501", VA = "0x22AC400")]
	private void Update()
	{
	}

	// Token: 0x060017A6 RID: 6054 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001509")]
	[Address(RVA = "0x22AC410", Offset = "0x22AC511", VA = "0x22AC410")]
	public EffectController()
	{
	}

	// Token: 0x04005BAF RID: 23471
	[Token(Token = "0x400584A")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ParticleSystem ParticleRoot;

	// Token: 0x04005BB0 RID: 23472
	[Token(Token = "0x400584B")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<ParticleSystem> Particles;
}
