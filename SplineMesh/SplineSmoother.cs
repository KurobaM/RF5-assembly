using System;
using Il2CppDummyDll;
using UnityEngine;

namespace SplineMesh
{
	// Token: 0x02000E40 RID: 3648
	[Token(Token = "0x2000955")]
	[Attribute(Name = "DisallowMultipleComponent", RVA = "0x1490E0", Offset = "0x1491E1")]
	[Attribute(Name = "ExecuteInEditMode", RVA = "0x1490E0", Offset = "0x1491E1")]
	[Attribute(Name = "RequireComponent", RVA = "0x1490E0", Offset = "0x1491E1")]
	public class SplineSmoother : MonoBehaviour
	{
		// Token: 0x17000C94 RID: 3220
		// (get) Token: 0x06006002 RID: 24578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009D6")]
		private Spline Spline
		{
			[Token(Token = "0x6004F73")]
			[Address(RVA = "0x2384C00", Offset = "0x2384D01", VA = "0x2384C00")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006003 RID: 24579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F74")]
		[Address(RVA = "0x2384CB0", Offset = "0x2384DB1", VA = "0x2384CB0")]
		private void OnValidate()
		{
		}

		// Token: 0x06006004 RID: 24580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F75")]
		[Address(RVA = "0x2384E50", Offset = "0x2384F51", VA = "0x2384E50")]
		private void OnEnable()
		{
		}

		// Token: 0x06006005 RID: 24581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F76")]
		[Address(RVA = "0x23851E0", Offset = "0x23852E1", VA = "0x23851E0")]
		private void OnDisable()
		{
		}

		// Token: 0x06006006 RID: 24582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F77")]
		[Address(RVA = "0x2385570", Offset = "0x2385671", VA = "0x2385570")]
		private void Spline_NodeListChanged(object sender, ListChangedEventArgs<SplineNode> args)
		{
		}

		// Token: 0x06006007 RID: 24583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F78")]
		[Address(RVA = "0x23858E0", Offset = "0x23859E1", VA = "0x23858E0")]
		private void OnNodeChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06006008 RID: 24584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F79")]
		[Address(RVA = "0x2385C50", Offset = "0x2385D51", VA = "0x2385C50")]
		private void SmoothNode(SplineNode node)
		{
		}

		// Token: 0x06006009 RID: 24585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F7A")]
		[Address(RVA = "0x2384CC0", Offset = "0x2384DC1", VA = "0x2384CC0")]
		private void SmoothAll()
		{
		}

		// Token: 0x0600600A RID: 24586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F7B")]
		[Address(RVA = "0x2386220", Offset = "0x2386321", VA = "0x2386220")]
		public SplineSmoother()
		{
		}

		// Token: 0x0400BF00 RID: 48896
		[Token(Token = "0x4008EDB")]
		[FieldOffset(Offset = "0x18")]
		private Spline spline;

		// Token: 0x0400BF01 RID: 48897
		[Token(Token = "0x4008EDC")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17E790", Offset = "0x17E891")]
		public float curvature;
	}
}
