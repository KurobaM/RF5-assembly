using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B42 RID: 2882
[Token(Token = "0x2000785")]
[Attribute(Name = "AddComponentMenu", RVA = "0x1472B0", Offset = "0x1473B1")]
public class DynamicBoneCollider : DynamicBoneColliderBase
{
	// Token: 0x06004A4B RID: 19019 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E38")]
	[Address(RVA = "0x22A8860", Offset = "0x22A8961", VA = "0x22A8860")]
	private void OnValidate()
	{
	}

	// Token: 0x06004A4C RID: 19020 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E39")]
	[Address(RVA = "0x22A8900", Offset = "0x22A8A01", VA = "0x22A8900", Slot = "4")]
	public override void Collide(ref Vector3 particlePosition, float particleRadius)
	{
	}

	// Token: 0x06004A4D RID: 19021 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E3A")]
	[Address(RVA = "0x22A8B60", Offset = "0x22A8C61", VA = "0x22A8B60")]
	private static void OutsideSphere(ref Vector3 particlePosition, float particleRadius, Vector3 sphereCenter, float sphereRadius)
	{
	}

	// Token: 0x06004A4E RID: 19022 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E3B")]
	[Address(RVA = "0x22A8D10", Offset = "0x22A8E11", VA = "0x22A8D10")]
	private static void InsideSphere(ref Vector3 particlePosition, float particleRadius, Vector3 sphereCenter, float sphereRadius)
	{
	}

	// Token: 0x06004A4F RID: 19023 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E3C")]
	[Address(RVA = "0x22A8EB0", Offset = "0x22A8FB1", VA = "0x22A8EB0")]
	private static void OutsideCapsule(ref Vector3 particlePosition, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius)
	{
	}

	// Token: 0x06004A50 RID: 19024 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E3D")]
	[Address(RVA = "0x22A92F0", Offset = "0x22A93F1", VA = "0x22A92F0")]
	private static void InsideCapsule(ref Vector3 particlePosition, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius)
	{
	}

	// Token: 0x06004A51 RID: 19025 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E3E")]
	[Address(RVA = "0x22A9710", Offset = "0x22A9811", VA = "0x22A9710")]
	private void OnDrawGizmosSelected()
	{
	}

	// Token: 0x06004A52 RID: 19026 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E3F")]
	[Address(RVA = "0x22A9910", Offset = "0x22A9A11", VA = "0x22A9910")]
	public DynamicBoneCollider()
	{
	}

	// Token: 0x0400AA87 RID: 43655
	[Token(Token = "0x4008097")]
	[FieldOffset(Offset = "0x2C")]
	public float m_Radius;

	// Token: 0x0400AA88 RID: 43656
	[Token(Token = "0x4008098")]
	[FieldOffset(Offset = "0x30")]
	public float m_Height;
}
