using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace SplineMesh
{
	// Token: 0x02000E39 RID: 3641
	[Token(Token = "0x200094E")]
	[Serializable]
	public class CubicBezierCurve
	{
		// Token: 0x17000C8C RID: 3212
		// (get) Token: 0x06005FC1 RID: 24513 RVA: 0x00020058 File Offset: 0x0001E258
		// (set) Token: 0x06005FC2 RID: 24514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009CE")]
		public float Length
		{
			[Token(Token = "0x6004F32")]
			[Address(RVA = "0x22632E0", Offset = "0x22633E1", VA = "0x22632E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC640", Offset = "0x1AC741")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004F33")]
			[Address(RVA = "0x22632F0", Offset = "0x22633F1", VA = "0x22632F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC650", Offset = "0x1AC751")]
			private set
			{
			}
		}

		// Token: 0x06005FC3 RID: 24515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F34")]
		[Address(RVA = "0x2263300", Offset = "0x2263401", VA = "0x2263300")]
		public CubicBezierCurve(SplineNode n1, SplineNode n2)
		{
		}

		// Token: 0x06005FC4 RID: 24516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F35")]
		[Address(RVA = "0x22636C0", Offset = "0x22637C1", VA = "0x22636C0")]
		public void ConnectStart(SplineNode n1)
		{
		}

		// Token: 0x06005FC5 RID: 24517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F36")]
		[Address(RVA = "0x22637B0", Offset = "0x22638B1", VA = "0x22637B0")]
		public void ConnectEnd(SplineNode n2)
		{
		}

		// Token: 0x06005FC6 RID: 24518 RVA: 0x00020070 File Offset: 0x0001E270
		[Token(Token = "0x6004F37")]
		[Address(RVA = "0x22638A0", Offset = "0x22639A1", VA = "0x22638A0")]
		public Vector3 GetInverseDirection()
		{
			return default(Vector3);
		}

		// Token: 0x06005FC7 RID: 24519 RVA: 0x00020088 File Offset: 0x0001E288
		[Token(Token = "0x6004F38")]
		[Address(RVA = "0x2263950", Offset = "0x2263A51", VA = "0x2263950")]
		private Vector3 GetLocation(float t)
		{
			return default(Vector3);
		}

		// Token: 0x06005FC8 RID: 24520 RVA: 0x000200A0 File Offset: 0x0001E2A0
		[Token(Token = "0x6004F39")]
		[Address(RVA = "0x2263AF0", Offset = "0x2263BF1", VA = "0x2263AF0")]
		private Vector3 GetTangent(float t)
		{
			return default(Vector3);
		}

		// Token: 0x06005FC9 RID: 24521 RVA: 0x000200B8 File Offset: 0x0001E2B8
		[Token(Token = "0x6004F3A")]
		[Address(RVA = "0x2263CC0", Offset = "0x2263DC1", VA = "0x2263CC0")]
		private Vector3 GetUp(float t)
		{
			return default(Vector3);
		}

		// Token: 0x06005FCA RID: 24522 RVA: 0x000200D0 File Offset: 0x0001E2D0
		[Token(Token = "0x6004F3B")]
		[Address(RVA = "0x2263D90", Offset = "0x2263E91", VA = "0x2263D90")]
		private Vector2 GetScale(float t)
		{
			return default(Vector2);
		}

		// Token: 0x06005FCB RID: 24523 RVA: 0x000200E8 File Offset: 0x0001E2E8
		[Token(Token = "0x6004F3C")]
		[Address(RVA = "0x2263E40", Offset = "0x2263F41", VA = "0x2263E40")]
		private float GetRoll(float t)
		{
			return 0f;
		}

		// Token: 0x06005FCC RID: 24524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F3D")]
		[Address(RVA = "0x2263460", Offset = "0x2263561", VA = "0x2263460")]
		private void ComputeSamples(object sender, EventArgs e)
		{
		}

		// Token: 0x06005FCD RID: 24525 RVA: 0x00020100 File Offset: 0x0001E300
		[Token(Token = "0x6004F3E")]
		[Address(RVA = "0x2263EE0", Offset = "0x2263FE1", VA = "0x2263EE0")]
		private CurveSample CreateSample(float distance, float time)
		{
			return default(CurveSample);
		}

		// Token: 0x06005FCE RID: 24526 RVA: 0x00020118 File Offset: 0x0001E318
		[Token(Token = "0x6004F3F")]
		[Address(RVA = "0x2264190", Offset = "0x2264291", VA = "0x2264190")]
		public CurveSample GetSample(float time)
		{
			return default(CurveSample);
		}

		// Token: 0x06005FCF RID: 24527 RVA: 0x00020130 File Offset: 0x0001E330
		[Token(Token = "0x6004F40")]
		[Address(RVA = "0x2264970", Offset = "0x2264A71", VA = "0x2264970")]
		public CurveSample GetSampleAtDistance(float d)
		{
			return default(CurveSample);
		}

		// Token: 0x06005FD0 RID: 24528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F41")]
		[Address(RVA = "0x22645C0", Offset = "0x22646C1", VA = "0x22645C0")]
		private static void AssertTimeInBounds(float time)
		{
		}

		// Token: 0x06005FD1 RID: 24529 RVA: 0x00020148 File Offset: 0x0001E348
		[Token(Token = "0x6004F42")]
		[Address(RVA = "0x2264EF0", Offset = "0x2264FF1", VA = "0x2264EF0")]
		public CurveSample GetProjectionSample(Vector3 pointToProject)
		{
			return default(CurveSample);
		}

		// Token: 0x0400BED9 RID: 48857
		[Token(Token = "0x4008EB4")]
		private const int STEP_COUNT = 30;

		// Token: 0x0400BEDA RID: 48858
		[Token(Token = "0x4008EB5")]
		private const float T_STEP = 0.0333333351f;

		// Token: 0x0400BEDB RID: 48859
		[Token(Token = "0x4008EB6")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<CurveSample> samples;

		// Token: 0x0400BEDC RID: 48860
		[Token(Token = "0x4008EB7")]
		[FieldOffset(Offset = "0x18")]
		public SplineNode n1;

		// Token: 0x0400BEDD RID: 48861
		[Token(Token = "0x4008EB8")]
		[FieldOffset(Offset = "0x20")]
		public SplineNode n2;

		// Token: 0x0400BEDE RID: 48862
		[Token(Token = "0x4008EB9")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17E6E0", Offset = "0x17E7E1")]
		private float <Length>k__BackingField;

		// Token: 0x0400BEDF RID: 48863
		[Token(Token = "0x4008EBA")]
		[FieldOffset(Offset = "0x30")]
		public UnityEvent Changed;
	}
}
