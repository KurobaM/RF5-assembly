using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020006E6 RID: 1766
[Token(Token = "0x20004E0")]
public class DragonSisterEffect
{
	// Token: 0x06002B75 RID: 11125 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60024A2")]
	[Address(RVA = "0x1E00E30", Offset = "0x1E00F31", VA = "0x1E00E30")]
	public void Create(EffectID effect_id)
	{
	}

	// Token: 0x06002B76 RID: 11126 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60024A3")]
	[Address(RVA = "0x1E00F20", Offset = "0x1E01021", VA = "0x1E00F20")]
	public void Destroy()
	{
	}

	// Token: 0x06002B77 RID: 11127 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60024A4")]
	[Address(RVA = "0x1E01210", Offset = "0x1E01311", VA = "0x1E01210")]
	public void Update()
	{
	}

	// Token: 0x06002B78 RID: 11128 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60024A5")]
	[Address(RVA = "0x1E019C0", Offset = "0x1E01AC1", VA = "0x1E019C0")]
	public void Play(Transform oya, Vector3 pos, Quaternion rot, Vector3 scale, float time)
	{
	}

	// Token: 0x06002B79 RID: 11129 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60024A6")]
	[Address(RVA = "0x1E01BA0", Offset = "0x1E01CA1", VA = "0x1E01BA0")]
	public void Stop(bool faststop = true)
	{
	}

	// Token: 0x06002B7A RID: 11130 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60024A7")]
	[Address(RVA = "0x1E00E20", Offset = "0x1E00F21", VA = "0x1E00E20")]
	public DragonSisterEffect()
	{
	}

	// Token: 0x06002B7B RID: 11131 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60024A8")]
	[Address(RVA = "0x1E01E70", Offset = "0x1E01F71", VA = "0x1E01E70")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2AC0", Offset = "0x1A2BC1")]
	private void <Create>b__2_0(ParticleSystem particle)
	{
	}

	// Token: 0x040072DB RID: 29403
	[Token(Token = "0x4006A3F")]
	[FieldOffset(Offset = "0x10")]
	private ParticleSystem effect;

	// Token: 0x040072DC RID: 29404
	[Token(Token = "0x4006A40")]
	[FieldOffset(Offset = "0x18")]
	private float Count;
}
