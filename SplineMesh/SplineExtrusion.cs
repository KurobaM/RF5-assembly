using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace SplineMesh
{
	// Token: 0x02000E53 RID: 3667
	[Token(Token = "0x2000963")]
	[Attribute(Name = "ExecuteInEditMode", RVA = "0x149560", Offset = "0x149661")]
	[Attribute(Name = "RequireComponent", RVA = "0x149560", Offset = "0x149661")]
	public class SplineExtrusion : MonoBehaviour
	{
		// Token: 0x06006080 RID: 24704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FDF")]
		[Address(RVA = "0x2382A50", Offset = "0x2382B51", VA = "0x2382A50")]
		private void Reset()
		{
		}

		// Token: 0x06006081 RID: 24705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FE0")]
		[Address(RVA = "0x2382F00", Offset = "0x2383001", VA = "0x2382F00")]
		private void OnValidate()
		{
		}

		// Token: 0x06006082 RID: 24706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FE1")]
		[Address(RVA = "0x2382C70", Offset = "0x2382D71", VA = "0x2382C70")]
		private void OnEnable()
		{
		}

		// Token: 0x06006083 RID: 24707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FE2")]
		[Address(RVA = "0x2382F10", Offset = "0x2383011", VA = "0x2382F10")]
		private void Update()
		{
		}

		// Token: 0x06006084 RID: 24708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FE3")]
		[Address(RVA = "0x2382F40", Offset = "0x2383041", VA = "0x2382F40")]
		private void GenerateMesh()
		{
		}

		// Token: 0x06006085 RID: 24709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FE4")]
		[Address(RVA = "0x23836A0", Offset = "0x23837A1", VA = "0x23836A0")]
		public void SetToUpdate()
		{
		}

		// Token: 0x06006086 RID: 24710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FE5")]
		[Address(RVA = "0x23836B0", Offset = "0x23837B1", VA = "0x23836B0")]
		public SplineExtrusion()
		{
		}

		// Token: 0x06006087 RID: 24711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FE6")]
		[Address(RVA = "0x2383750", Offset = "0x2383851", VA = "0x2383750")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC6F0", Offset = "0x1AC7F1")]
		private void <OnEnable>b__9_0(object s, ListChangedEventArgs<SplineNode> e)
		{
		}

		// Token: 0x0400BF74 RID: 49012
		[Token(Token = "0x4008F3B")]
		[FieldOffset(Offset = "0x18")]
		private Spline spline;

		// Token: 0x0400BF75 RID: 49013
		[Token(Token = "0x4008F3C")]
		[FieldOffset(Offset = "0x20")]
		private bool toUpdate;

		// Token: 0x0400BF76 RID: 49014
		[Token(Token = "0x4008F3D")]
		[FieldOffset(Offset = "0x28")]
		private GameObject generated;

		// Token: 0x0400BF77 RID: 49015
		[Token(Token = "0x4008F3E")]
		[FieldOffset(Offset = "0x30")]
		public List<ExtrusionSegment.Vertex> shapeVertices;

		// Token: 0x0400BF78 RID: 49016
		[Token(Token = "0x4008F3F")]
		[FieldOffset(Offset = "0x38")]
		public Material material;

		// Token: 0x0400BF79 RID: 49017
		[Token(Token = "0x4008F40")]
		[FieldOffset(Offset = "0x40")]
		public float textureScale;

		// Token: 0x0400BF7A RID: 49018
		[Token(Token = "0x4008F41")]
		[FieldOffset(Offset = "0x44")]
		public float sampleSpacing;
	}
}
