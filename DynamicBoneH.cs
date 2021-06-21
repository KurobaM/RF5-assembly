using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000102 RID: 258
[Token(Token = "0x20000CA")]
public class DynamicBoneH : MonoBehaviour
{
	// Token: 0x06000590 RID: 1424 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004AF")]
	[Address(RVA = "0x22A9ED0", Offset = "0x22A9FD1", VA = "0x22A9ED0")]
	public void Setup()
	{
	}

	// Token: 0x06000591 RID: 1425 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004B0")]
	[Address(RVA = "0x22AA090", Offset = "0x22AA191", VA = "0x22AA090")]
	private void AppendParticles(Transform a_Transform, int a_ParentIndex, float a_BoneLength)
	{
	}

	// Token: 0x06000592 RID: 1426 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004B1")]
	[Address(RVA = "0x22AA360", Offset = "0x22AA461", VA = "0x22AA360")]
	public void InitTransforms()
	{
	}

	// Token: 0x06000593 RID: 1427 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004B2")]
	[Address(RVA = "0x22AA430", Offset = "0x22AA531", VA = "0x22AA430")]
	public void ResetParticlesPosition()
	{
	}

	// Token: 0x06000594 RID: 1428 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004B3")]
	[Address(RVA = "0x22AA4F0", Offset = "0x22AA5F1", VA = "0x22AA4F0")]
	public void UpdateParticles()
	{
	}

	// Token: 0x06000595 RID: 1429 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004B4")]
	[Address(RVA = "0x22AAC30", Offset = "0x22AAD31", VA = "0x22AAC30")]
	public DynamicBoneH()
	{
	}

	// Token: 0x040002D9 RID: 729
	[Token(Token = "0x4000234")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "RangeAttribute", RVA = "0x15BBF0", Offset = "0x15BCF1")]
	public float m_Damping;

	// Token: 0x040002DA RID: 730
	[Token(Token = "0x4000235")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "RangeAttribute", RVA = "0x15BC10", Offset = "0x15BD11")]
	public float m_Elasticity;

	// Token: 0x040002DB RID: 731
	[Token(Token = "0x4000236")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "RangeAttribute", RVA = "0x15BC30", Offset = "0x15BD31")]
	public float m_Stiffness;

	// Token: 0x040002DC RID: 732
	[Token(Token = "0x4000237")]
	[FieldOffset(Offset = "0x28")]
	public AnimationCurve m_StiffnessDistrib;

	// Token: 0x040002DD RID: 733
	[Token(Token = "0x4000238")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 m_Force;

	// Token: 0x040002DE RID: 734
	[Token(Token = "0x4000239")]
	[FieldOffset(Offset = "0x3C")]
	public Vector3 m_Wind;

	// Token: 0x040002DF RID: 735
	[Token(Token = "0x400023A")]
	[FieldOffset(Offset = "0x48")]
	private float m_BoneTotalLength;

	// Token: 0x040002E0 RID: 736
	[Token(Token = "0x400023B")]
	[FieldOffset(Offset = "0x50")]
	public List<DynamicBoneH.Particle> m_Particles;

	// Token: 0x040002E1 RID: 737
	[Token(Token = "0x400023C")]
	[FieldOffset(Offset = "0x58")]
	public int m_ParticlesCount;

	// Token: 0x02000103 RID: 259
	[Token(Token = "0x2000FC2")]
	public class Particle
	{
		// Token: 0x06000596 RID: 1430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BCC")]
		[Address(RVA = "0x22AA350", Offset = "0x22AA451", VA = "0x22AA350")]
		public Particle()
		{
		}

		// Token: 0x040002E2 RID: 738
		[Token(Token = "0x4018D1D")]
		[FieldOffset(Offset = "0x10")]
		public Transform m_Transform;

		// Token: 0x040002E3 RID: 739
		[Token(Token = "0x4018D1E")]
		[FieldOffset(Offset = "0x18")]
		public float m_Stiffness;

		// Token: 0x040002E4 RID: 740
		[Token(Token = "0x4018D1F")]
		[FieldOffset(Offset = "0x1C")]
		public float m_BoneLength;

		// Token: 0x040002E5 RID: 741
		[Token(Token = "0x4018D20")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 m_NowPosition;

		// Token: 0x040002E6 RID: 742
		[Token(Token = "0x4018D21")]
		[FieldOffset(Offset = "0x2C")]
		public Vector3 m_NowLocalPosition;

		// Token: 0x040002E7 RID: 743
		[Token(Token = "0x4018D22")]
		[FieldOffset(Offset = "0x38")]
		public Matrix4x4 m_NowLocalToWorldMatrix;

		// Token: 0x040002E8 RID: 744
		[Token(Token = "0x4018D23")]
		[FieldOffset(Offset = "0x78")]
		public Vector3 m_PrevPosition;

		// Token: 0x040002E9 RID: 745
		[Token(Token = "0x4018D24")]
		[FieldOffset(Offset = "0x84")]
		public Vector3 m_Position;

		// Token: 0x040002EA RID: 746
		[Token(Token = "0x4018D25")]
		[FieldOffset(Offset = "0x90")]
		public Vector3 m_InitLocalPosition;

		// Token: 0x040002EB RID: 747
		[Token(Token = "0x4018D26")]
		[FieldOffset(Offset = "0x9C")]
		public Quaternion m_InitLocalRotation;
	}
}
