using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace SplineMesh
{
	// Token: 0x02000E4E RID: 3662
	[Token(Token = "0x2000960")]
	[Attribute(Name = "DisallowMultipleComponent", RVA = "0x1494D0", Offset = "0x1495D1")]
	[Attribute(Name = "RequireComponent", RVA = "0x1494D0", Offset = "0x1495D1")]
	[Attribute(Name = "ExecuteInEditMode", RVA = "0x1494D0", Offset = "0x1495D1")]
	public class MeshBender : MonoBehaviour
	{
		// Token: 0x17000C9A RID: 3226
		// (get) Token: 0x06006054 RID: 24660 RVA: 0x00020370 File Offset: 0x0001E570
		// (set) Token: 0x06006055 RID: 24661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009DC")]
		public SourceMesh Source
		{
			[Token(Token = "0x6004FBB")]
			[Address(RVA = "0x237AA40", Offset = "0x237AB41", VA = "0x237AA40")]
			get
			{
				return default(SourceMesh);
			}
			[Token(Token = "0x6004FBC")]
			[Address(RVA = "0x237AA70", Offset = "0x237AB71", VA = "0x237AA70")]
			set
			{
			}
		}

		// Token: 0x17000C9B RID: 3227
		// (get) Token: 0x06006056 RID: 24662 RVA: 0x00020388 File Offset: 0x0001E588
		// (set) Token: 0x06006057 RID: 24663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009DD")]
		public MeshBender.FillingMode Mode
		{
			[Token(Token = "0x6004FBD")]
			[Address(RVA = "0x237AC40", Offset = "0x237AD41", VA = "0x237AC40")]
			get
			{
				return MeshBender.FillingMode.Once;
			}
			[Token(Token = "0x6004FBE")]
			[Address(RVA = "0x237AC50", Offset = "0x237AD51", VA = "0x237AC50")]
			set
			{
			}
		}

		// Token: 0x06006058 RID: 24664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FBF")]
		[Address(RVA = "0x237AC70", Offset = "0x237AD71", VA = "0x237AC70")]
		public void SetInterval(CubicBezierCurve curve)
		{
		}

		// Token: 0x06006059 RID: 24665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FC0")]
		[Address(RVA = "0x237ADD0", Offset = "0x237AED1", VA = "0x237ADD0")]
		public void SetInterval(Spline spline, float intervalStart, float intervalEnd = 0f)
		{
		}

		// Token: 0x0600605A RID: 24666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FC1")]
		[Address(RVA = "0x237B0C0", Offset = "0x237B1C1", VA = "0x237B0C0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600605B RID: 24667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FC2")]
		[Address(RVA = "0x237B230", Offset = "0x237B331", VA = "0x237B230")]
		private void Update()
		{
		}

		// Token: 0x0600605C RID: 24668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FC3")]
		[Address(RVA = "0x237B270", Offset = "0x237B371", VA = "0x237B270")]
		public void ComputeIfNeeded()
		{
		}

		// Token: 0x0600605D RID: 24669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FC4")]
		[Address(RVA = "0x237AC30", Offset = "0x237AD31", VA = "0x237AC30")]
		private void SetDirty()
		{
		}

		// Token: 0x0600605E RID: 24670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FC5")]
		[Address(RVA = "0x237B2B0", Offset = "0x237B3B1", VA = "0x237B2B0")]
		private void Compute()
		{
		}

		// Token: 0x0600605F RID: 24671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FC6")]
		[Address(RVA = "0x237D010", Offset = "0x237D111", VA = "0x237D010")]
		private void OnDestroy()
		{
		}

		// Token: 0x06006060 RID: 24672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FC7")]
		[Address(RVA = "0x237B2E0", Offset = "0x237B3E1", VA = "0x237B2E0")]
		private void FillOnce()
		{
		}

		// Token: 0x06006061 RID: 24673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FC8")]
		[Address(RVA = "0x237BAF0", Offset = "0x237BBF1", VA = "0x237BAF0")]
		private void FillRepeat()
		{
		}

		// Token: 0x06006062 RID: 24674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FC9")]
		[Address(RVA = "0x237C700", Offset = "0x237C801", VA = "0x237C700")]
		private void FillStretch()
		{
		}

		// Token: 0x06006063 RID: 24675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FCA")]
		[Address(RVA = "0x237D810", Offset = "0x237D911", VA = "0x237D810")]
		public MeshBender()
		{
		}

		// Token: 0x0400BF54 RID: 48980
		[Token(Token = "0x4008F26")]
		[FieldOffset(Offset = "0x18")]
		private bool isDirty;

		// Token: 0x0400BF55 RID: 48981
		[Token(Token = "0x4008F27")]
		[FieldOffset(Offset = "0x20")]
		private Mesh result;

		// Token: 0x0400BF56 RID: 48982
		[Token(Token = "0x4008F28")]
		[FieldOffset(Offset = "0x28")]
		private bool useSpline;

		// Token: 0x0400BF57 RID: 48983
		[Token(Token = "0x4008F29")]
		[FieldOffset(Offset = "0x30")]
		private Spline spline;

		// Token: 0x0400BF58 RID: 48984
		[Token(Token = "0x4008F2A")]
		[FieldOffset(Offset = "0x38")]
		private float intervalStart;

		// Token: 0x0400BF59 RID: 48985
		[Token(Token = "0x4008F2B")]
		[FieldOffset(Offset = "0x3C")]
		private float intervalEnd;

		// Token: 0x0400BF5A RID: 48986
		[Token(Token = "0x4008F2C")]
		[FieldOffset(Offset = "0x40")]
		private CubicBezierCurve curve;

		// Token: 0x0400BF5B RID: 48987
		[Token(Token = "0x4008F2D")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<float, CurveSample> sampleCache;

		// Token: 0x0400BF5C RID: 48988
		[Token(Token = "0x4008F2E")]
		[FieldOffset(Offset = "0x50")]
		private SourceMesh source;

		// Token: 0x0400BF5D RID: 48989
		[Token(Token = "0x4008F2F")]
		[FieldOffset(Offset = "0x98")]
		private MeshBender.FillingMode mode;

		// Token: 0x02000E4F RID: 3663
		[Token(Token = "0x200145A")]
		public enum FillingMode
		{
			// Token: 0x0400BF5F RID: 48991
			[Token(Token = "0x401BC3B")]
			Once,
			// Token: 0x0400BF60 RID: 48992
			[Token(Token = "0x401BC3C")]
			Repeat,
			// Token: 0x0400BF61 RID: 48993
			[Token(Token = "0x401BC3D")]
			StretchToInterval
		}

		// Token: 0x02000E50 RID: 3664
		[Token(Token = "0x200145B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159920", Offset = "0x159A21")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06006065 RID: 24677 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B49")]
			[Address(RVA = "0x237D910", Offset = "0x237DA11", VA = "0x237D910")]
			public <>c()
			{
			}

			// Token: 0x06006066 RID: 24678 RVA: 0x000203A0 File Offset: 0x0001E5A0
			[Token(Token = "0x6007B4A")]
			[Address(RVA = "0x237D920", Offset = "0x237DA21", VA = "0x237D920")]
			internal Vector3 <FillOnce>b__25_0(MeshVertex b)
			{
				return default(Vector3);
			}

			// Token: 0x06006067 RID: 24679 RVA: 0x000203B8 File Offset: 0x0001E5B8
			[Token(Token = "0x6007B4B")]
			[Address(RVA = "0x237D940", Offset = "0x237DA41", VA = "0x237D940")]
			internal Vector3 <FillOnce>b__25_1(MeshVertex b)
			{
				return default(Vector3);
			}

			// Token: 0x06006068 RID: 24680 RVA: 0x000203D0 File Offset: 0x0001E5D0
			[Token(Token = "0x6007B4C")]
			[Address(RVA = "0x237D960", Offset = "0x237DA61", VA = "0x237D960")]
			internal Vector3 <FillRepeat>b__26_0(MeshVertex b)
			{
				return default(Vector3);
			}

			// Token: 0x06006069 RID: 24681 RVA: 0x000203E8 File Offset: 0x0001E5E8
			[Token(Token = "0x6007B4D")]
			[Address(RVA = "0x237D980", Offset = "0x237DA81", VA = "0x237D980")]
			internal Vector3 <FillRepeat>b__26_1(MeshVertex b)
			{
				return default(Vector3);
			}

			// Token: 0x0600606A RID: 24682 RVA: 0x00020400 File Offset: 0x0001E600
			[Token(Token = "0x6007B4E")]
			[Address(RVA = "0x237D9A0", Offset = "0x237DAA1", VA = "0x237D9A0")]
			internal Vector3 <FillStretch>b__27_0(MeshVertex b)
			{
				return default(Vector3);
			}

			// Token: 0x0600606B RID: 24683 RVA: 0x00020418 File Offset: 0x0001E618
			[Token(Token = "0x6007B4F")]
			[Address(RVA = "0x237D9C0", Offset = "0x237DAC1", VA = "0x237D9C0")]
			internal Vector3 <FillStretch>b__27_1(MeshVertex b)
			{
				return default(Vector3);
			}

			// Token: 0x0400BF62 RID: 48994
			[Token(Token = "0x401BC3E")]
			[FieldOffset(Offset = "0x0")]
			public static readonly MeshBender.<>c <>9;

			// Token: 0x0400BF63 RID: 48995
			[Token(Token = "0x401BC3F")]
			[FieldOffset(Offset = "0x8")]
			public static Func<MeshVertex, Vector3> <>9__25_0;

			// Token: 0x0400BF64 RID: 48996
			[Token(Token = "0x401BC40")]
			[FieldOffset(Offset = "0x10")]
			public static Func<MeshVertex, Vector3> <>9__25_1;

			// Token: 0x0400BF65 RID: 48997
			[Token(Token = "0x401BC41")]
			[FieldOffset(Offset = "0x18")]
			public static Func<MeshVertex, Vector3> <>9__26_0;

			// Token: 0x0400BF66 RID: 48998
			[Token(Token = "0x401BC42")]
			[FieldOffset(Offset = "0x20")]
			public static Func<MeshVertex, Vector3> <>9__26_1;

			// Token: 0x0400BF67 RID: 48999
			[Token(Token = "0x401BC43")]
			[FieldOffset(Offset = "0x28")]
			public static Func<MeshVertex, Vector3> <>9__27_0;

			// Token: 0x0400BF68 RID: 49000
			[Token(Token = "0x401BC44")]
			[FieldOffset(Offset = "0x30")]
			public static Func<MeshVertex, Vector3> <>9__27_1;
		}
	}
}
