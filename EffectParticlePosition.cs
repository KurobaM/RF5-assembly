using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000406 RID: 1030
[Token(Token = "0x2000324")]
public class EffectParticlePosition : MonoBehaviour
{
	// Token: 0x060017C0 RID: 6080 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600151D")]
	[Address(RVA = "0x22AE5B0", Offset = "0x22AE6B1", VA = "0x22AE5B0")]
	private void Awake()
	{
	}

	// Token: 0x060017C1 RID: 6081 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600151E")]
	[Address(RVA = "0x22AE730", Offset = "0x22AE831", VA = "0x22AE730")]
	private void LateUpdate()
	{
	}

	// Token: 0x060017C2 RID: 6082 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600151F")]
	[Address(RVA = "0x22AE670", Offset = "0x22AE771", VA = "0x22AE670")]
	private void InitializeIfNeeded()
	{
	}

	// Token: 0x060017C3 RID: 6083 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001520")]
	[Address(RVA = "0x22AE970", Offset = "0x22AEA71", VA = "0x22AE970")]
	public EffectParticlePosition()
	{
	}

	// Token: 0x04005BCA RID: 23498
	[Token(Token = "0x4005856")]
	[FieldOffset(Offset = "0x18")]
	private ParticleSystem targetParticleSystem;

	// Token: 0x04005BCB RID: 23499
	[Token(Token = "0x4005857")]
	[FieldOffset(Offset = "0x20")]
	private ParticleSystem.Particle[] targetParticles;

	// Token: 0x04005BCC RID: 23500
	[Token(Token = "0x4005858")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 Pos;
}
