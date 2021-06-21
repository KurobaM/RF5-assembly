using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace SplineMesh
{
	// Token: 0x02000E4B RID: 3659
	[Token(Token = "0x200095F")]
	[Attribute(Name = "ExecuteInEditMode", RVA = "0x149420", Offset = "0x149521")]
	[Attribute(Name = "DisallowMultipleComponent", RVA = "0x149420", Offset = "0x149521")]
	[Attribute(Name = "RequireComponent", RVA = "0x149420", Offset = "0x149521")]
	[Attribute(Name = "RequireComponent", RVA = "0x149420", Offset = "0x149521")]
	public class ExtrusionSegment : MonoBehaviour
	{
		// Token: 0x17000C96 RID: 3222
		// (get) Token: 0x0600603C RID: 24636 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600603D RID: 24637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009D8")]
		public List<ExtrusionSegment.Vertex> ShapeVertices
		{
			[Token(Token = "0x6004FAA")]
			[Address(RVA = "0x2269830", Offset = "0x2269931", VA = "0x2269830")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004FAB")]
			[Address(RVA = "0x2269840", Offset = "0x2269941", VA = "0x2269840")]
			set
			{
			}
		}

		// Token: 0x17000C97 RID: 3223
		// (get) Token: 0x0600603E RID: 24638 RVA: 0x000202E0 File Offset: 0x0001E4E0
		// (set) Token: 0x0600603F RID: 24639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009D9")]
		public float TextureScale
		{
			[Token(Token = "0x6004FAC")]
			[Address(RVA = "0x2269880", Offset = "0x2269981", VA = "0x2269880")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004FAD")]
			[Address(RVA = "0x2269890", Offset = "0x2269991", VA = "0x2269890")]
			set
			{
			}
		}

		// Token: 0x17000C98 RID: 3224
		// (get) Token: 0x06006040 RID: 24640 RVA: 0x000202F8 File Offset: 0x0001E4F8
		// (set) Token: 0x06006041 RID: 24641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009DA")]
		public float TextureOffset
		{
			[Token(Token = "0x6004FAE")]
			[Address(RVA = "0x22698B0", Offset = "0x22699B1", VA = "0x22698B0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004FAF")]
			[Address(RVA = "0x22698C0", Offset = "0x22699C1", VA = "0x22698C0")]
			set
			{
			}
		}

		// Token: 0x17000C99 RID: 3225
		// (get) Token: 0x06006042 RID: 24642 RVA: 0x00020310 File Offset: 0x0001E510
		// (set) Token: 0x06006043 RID: 24643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009DB")]
		public float SampleSpacing
		{
			[Token(Token = "0x6004FB0")]
			[Address(RVA = "0x22698E0", Offset = "0x22699E1", VA = "0x22698E0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004FB1")]
			[Address(RVA = "0x22698F0", Offset = "0x22699F1", VA = "0x22698F0")]
			set
			{
			}
		}

		// Token: 0x06006044 RID: 24644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FB2")]
		[Address(RVA = "0x22699C0", Offset = "0x2269AC1", VA = "0x22699C0")]
		private void OnEnable()
		{
		}

		// Token: 0x06006045 RID: 24645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FB3")]
		[Address(RVA = "0x2269AB0", Offset = "0x2269BB1", VA = "0x2269AB0")]
		public void SetInterval(CubicBezierCurve curve)
		{
		}

		// Token: 0x06006046 RID: 24646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FB4")]
		[Address(RVA = "0x2269C10", Offset = "0x2269D11", VA = "0x2269C10")]
		public void SetInterval(Spline spline, float intervalStart, float intervalEnd = 0f)
		{
		}

		// Token: 0x06006047 RID: 24647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FB5")]
		[Address(RVA = "0x2269870", Offset = "0x2269971", VA = "0x2269870")]
		private void SetDirty()
		{
		}

		// Token: 0x06006048 RID: 24648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FB6")]
		[Address(RVA = "0x2269F00", Offset = "0x226A001", VA = "0x2269F00")]
		private void Update()
		{
		}

		// Token: 0x06006049 RID: 24649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FB7")]
		[Address(RVA = "0x2269F30", Offset = "0x226A031", VA = "0x2269F30")]
		public void ComputeIfNeeded()
		{
		}

		// Token: 0x0600604A RID: 24650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FB8")]
		[Address(RVA = "0x226A910", Offset = "0x226AA11", VA = "0x226A910")]
		private List<CurveSample> GetPath()
		{
			return null;
		}

		// Token: 0x0600604B RID: 24651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FB9")]
		[Address(RVA = "0x2269F60", Offset = "0x226A061", VA = "0x2269F60")]
		public void Compute()
		{
		}

		// Token: 0x0600604C RID: 24652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FBA")]
		[Address(RVA = "0x226AB80", Offset = "0x226AC81", VA = "0x226AB80")]
		public ExtrusionSegment()
		{
		}

		// Token: 0x0400BF41 RID: 48961
		[Token(Token = "0x4008F1A")]
		[FieldOffset(Offset = "0x18")]
		private bool isDirty;

		// Token: 0x0400BF42 RID: 48962
		[Token(Token = "0x4008F1B")]
		[FieldOffset(Offset = "0x20")]
		private MeshFilter mf;

		// Token: 0x0400BF43 RID: 48963
		[Token(Token = "0x4008F1C")]
		[FieldOffset(Offset = "0x28")]
		private Mesh result;

		// Token: 0x0400BF44 RID: 48964
		[Token(Token = "0x4008F1D")]
		[FieldOffset(Offset = "0x30")]
		private bool useSpline;

		// Token: 0x0400BF45 RID: 48965
		[Token(Token = "0x4008F1E")]
		[FieldOffset(Offset = "0x38")]
		private CubicBezierCurve curve;

		// Token: 0x0400BF46 RID: 48966
		[Token(Token = "0x4008F1F")]
		[FieldOffset(Offset = "0x40")]
		private Spline spline;

		// Token: 0x0400BF47 RID: 48967
		[Token(Token = "0x4008F20")]
		[FieldOffset(Offset = "0x48")]
		private float intervalStart;

		// Token: 0x0400BF48 RID: 48968
		[Token(Token = "0x4008F21")]
		[FieldOffset(Offset = "0x4C")]
		private float intervalEnd;

		// Token: 0x0400BF49 RID: 48969
		[Token(Token = "0x4008F22")]
		[FieldOffset(Offset = "0x50")]
		private List<ExtrusionSegment.Vertex> shapeVertices;

		// Token: 0x0400BF4A RID: 48970
		[Token(Token = "0x4008F23")]
		[FieldOffset(Offset = "0x58")]
		private float textureScale;

		// Token: 0x0400BF4B RID: 48971
		[Token(Token = "0x4008F24")]
		[FieldOffset(Offset = "0x5C")]
		private float textureOffset;

		// Token: 0x0400BF4C RID: 48972
		[Token(Token = "0x4008F25")]
		[FieldOffset(Offset = "0x60")]
		private float sampleSpacing;

		// Token: 0x02000E4C RID: 3660
		[Token(Token = "0x2001458")]
		[Serializable]
		public class Vertex
		{
			// Token: 0x0600604D RID: 24653 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B41")]
			[Address(RVA = "0x237A980", Offset = "0x237AA81", VA = "0x237A980")]
			public Vertex(Vector2 point, Vector2 normal, float uCoord)
			{
			}

			// Token: 0x0600604E RID: 24654 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B42")]
			[Address(RVA = "0x237A9F0", Offset = "0x237AAF1", VA = "0x237A9F0")]
			public Vertex(ExtrusionSegment.Vertex other)
			{
			}

			// Token: 0x0400BF4D RID: 48973
			[Token(Token = "0x401BC33")]
			[FieldOffset(Offset = "0x10")]
			public Vector2 point;

			// Token: 0x0400BF4E RID: 48974
			[Token(Token = "0x401BC34")]
			[FieldOffset(Offset = "0x18")]
			public Vector2 normal;

			// Token: 0x0400BF4F RID: 48975
			[Token(Token = "0x401BC35")]
			[FieldOffset(Offset = "0x20")]
			public float uCoord;
		}

		// Token: 0x02000E4D RID: 3661
		[Token(Token = "0x2001459")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159910", Offset = "0x159A11")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06006050 RID: 24656 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B44")]
			[Address(RVA = "0x237A910", Offset = "0x237AA11", VA = "0x237A910")]
			public <>c()
			{
			}

			// Token: 0x06006051 RID: 24657 RVA: 0x00020328 File Offset: 0x0001E528
			[Token(Token = "0x6007B45")]
			[Address(RVA = "0x237A920", Offset = "0x237AA21", VA = "0x237A920")]
			internal Vector3 <Compute>b__31_0(MeshVertex b)
			{
				return default(Vector3);
			}

			// Token: 0x06006052 RID: 24658 RVA: 0x00020340 File Offset: 0x0001E540
			[Token(Token = "0x6007B46")]
			[Address(RVA = "0x237A940", Offset = "0x237AA41", VA = "0x237A940")]
			internal Vector3 <Compute>b__31_1(MeshVertex b)
			{
				return default(Vector3);
			}

			// Token: 0x06006053 RID: 24659 RVA: 0x00020358 File Offset: 0x0001E558
			[Token(Token = "0x6007B47")]
			[Address(RVA = "0x237A960", Offset = "0x237AA61", VA = "0x237A960")]
			internal Vector2 <Compute>b__31_2(MeshVertex b)
			{
				return default(Vector2);
			}

			// Token: 0x0400BF50 RID: 48976
			[Token(Token = "0x401BC36")]
			[FieldOffset(Offset = "0x0")]
			public static readonly ExtrusionSegment.<>c <>9;

			// Token: 0x0400BF51 RID: 48977
			[Token(Token = "0x401BC37")]
			[FieldOffset(Offset = "0x8")]
			public static Func<MeshVertex, Vector3> <>9__31_0;

			// Token: 0x0400BF52 RID: 48978
			[Token(Token = "0x401BC38")]
			[FieldOffset(Offset = "0x10")]
			public static Func<MeshVertex, Vector3> <>9__31_1;

			// Token: 0x0400BF53 RID: 48979
			[Token(Token = "0x401BC39")]
			[FieldOffset(Offset = "0x18")]
			public static Func<MeshVertex, Vector2> <>9__31_2;
		}
	}
}
