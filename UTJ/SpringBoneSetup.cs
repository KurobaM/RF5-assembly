using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace UTJ
{
	// Token: 0x02000BEE RID: 3054
	[Token(Token = "0x20007E5")]
	public static class SpringBoneSetup
	{
		// Token: 0x06004DD0 RID: 19920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040FE")]
		[Address(RVA = "0x23A5B10", Offset = "0x23A5C11", VA = "0x23A5B10")]
		public static void DestroyUnityObject(UnityEngine.Object objectToDestroy)
		{
		}

		// Token: 0x06004DD1 RID: 19921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040FF")]
		[Address(RVA = "0x23A5B80", Offset = "0x23A5C81", VA = "0x23A5B80")]
		public static void DestroySpringManagersAndBones(GameObject rootObject)
		{
		}

		// Token: 0x06004DD2 RID: 19922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004100")]
		[Address(RVA = "0x23A6170", Offset = "0x23A6271", VA = "0x23A6170")]
		public static void FindAndAssignSpringBones(SpringManager springManager, bool includeInactive = false)
		{
		}

		// Token: 0x06004DD3 RID: 19923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004101")]
		[Address(RVA = "0x23A6510", Offset = "0x23A6611", VA = "0x23A6510")]
		public static void AssignSpringBonesRecursively(Transform rootObject)
		{
		}

		// Token: 0x06004DD4 RID: 19924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004102")]
		[Address(RVA = "0x23A6630", Offset = "0x23A6731", VA = "0x23A6630")]
		public static Dictionary<Transform, List<SpringBone>> GetPivotToSpringBoneMap(GameObject rootObject)
		{
			return null;
		}

		// Token: 0x06004DD5 RID: 19925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004103")]
		[Address(RVA = "0x23A6B80", Offset = "0x23A6C81", VA = "0x23A6B80")]
		public static void FixAllPivotNodePositions(GameObject rootObject)
		{
		}

		// Token: 0x06004DD6 RID: 19926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004104")]
		[Address(RVA = "0x23A6F40", Offset = "0x23A7041", VA = "0x23A6F40")]
		public static GameObject CreateSpringPivotNode(SpringBone springBone)
		{
			return null;
		}

		// Token: 0x06004DD7 RID: 19927 RVA: 0x00018D38 File Offset: 0x00016F38
		[Token(Token = "0x6004105")]
		[Address(RVA = "0x23A75B0", Offset = "0x23A76B1", VA = "0x23A75B0")]
		public static bool IsPivotProbablySafeToDestroy(Transform pivot, IEnumerable<Transform> skinBones)
		{
			return default(bool);
		}

		// Token: 0x06004DD8 RID: 19928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004106")]
		[Address(RVA = "0x23A5D40", Offset = "0x23A5E41", VA = "0x23A5D40")]
		private static void DestroyPivotObjects(GameObject rootObject)
		{
		}

		// Token: 0x06004DD9 RID: 19929 RVA: 0x00018D50 File Offset: 0x00016F50
		[Token(Token = "0x6004107")]
		[Address(RVA = "0x23A7730", Offset = "0x23A7831", VA = "0x23A7730")]
		private static bool IsPivotSideDirectionValid(Vector3 lookDirection, Vector3 sideDirection)
		{
			return default(bool);
		}

		// Token: 0x06004DDA RID: 19930 RVA: 0x00018D68 File Offset: 0x00016F68
		[Token(Token = "0x6004108")]
		[Address(RVA = "0x23A7850", Offset = "0x23A7951", VA = "0x23A7850")]
		private static Vector3 FindClosestMeshNormalToPoint(Transform rootObject, Vector3 sourcePoint)
		{
			return default(Vector3);
		}

		// Token: 0x06004DDB RID: 19931 RVA: 0x00018D80 File Offset: 0x00016F80
		[Token(Token = "0x6004109")]
		[Address(RVA = "0x23A7F00", Offset = "0x23A8001", VA = "0x23A7F00")]
		private static bool TryToGetPivotSideDirection(SpringBone springBone, Vector3 lookDirection, out Vector3 sideDirection)
		{
			return default(bool);
		}

		// Token: 0x06004DDC RID: 19932 RVA: 0x00018D98 File Offset: 0x00016F98
		[Token(Token = "0x600410A")]
		[Address(RVA = "0x23A7220", Offset = "0x23A7321", VA = "0x23A7220")]
		private static Quaternion GetPivotRotation(SpringBone springBone)
		{
			return default(Quaternion);
		}

		// Token: 0x06004DDD RID: 19933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600410B")]
		[Address(RVA = "0x23A6240", Offset = "0x23A6341", VA = "0x23A6240")]
		private static List<SpringBone> GetSpringBonesSortedByDepth(GameObject rootObject, bool includeInactive)
		{
			return null;
		}

		// Token: 0x02000BEF RID: 3055
		[Token(Token = "0x2001385")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159500", Offset = "0x159601")]
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x06004DDE RID: 19934 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60077A5")]
			[Address(RVA = "0x23A6B70", Offset = "0x23A6C71", VA = "0x23A6B70")]
			public <>c__DisplayClass4_0()
			{
			}

			// Token: 0x06004DDF RID: 19935 RVA: 0x00018DB0 File Offset: 0x00016FB0
			[Token(Token = "0x60077A6")]
			[Address(RVA = "0x23A8400", Offset = "0x23A8501", VA = "0x23A8400")]
			internal bool <GetPivotToSpringBoneMap>b__0(SpringBone bone)
			{
				return default(bool);
			}

			// Token: 0x0400AF3D RID: 44861
			[Token(Token = "0x401B78C")]
			[FieldOffset(Offset = "0x10")]
			public IEnumerable<Transform> skinBones;
		}

		// Token: 0x02000BF0 RID: 3056
		[Token(Token = "0x2001386")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159510", Offset = "0x159611")]
		private sealed class <>c__DisplayClass8_0
		{
			// Token: 0x06004DE0 RID: 19936 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60077A7")]
			[Address(RVA = "0x23A7720", Offset = "0x23A7821", VA = "0x23A7720")]
			public <>c__DisplayClass8_0()
			{
			}

			// Token: 0x06004DE1 RID: 19937 RVA: 0x00018DC8 File Offset: 0x00016FC8
			[Token(Token = "0x60077A8")]
			[Address(RVA = "0x23A84C0", Offset = "0x23A85C1", VA = "0x23A84C0")]
			internal bool <DestroyPivotObjects>b__2(Transform pivot)
			{
				return default(bool);
			}

			// Token: 0x0400AF3E RID: 44862
			[Token(Token = "0x401B78D")]
			[FieldOffset(Offset = "0x10")]
			public IEnumerable<Transform> skinBones;
		}

		// Token: 0x02000BF1 RID: 3057
		[Token(Token = "0x2001387")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159520", Offset = "0x159621")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004DE3 RID: 19939 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60077AA")]
			[Address(RVA = "0x23A8100", Offset = "0x23A8201", VA = "0x23A8100")]
			public <>c()
			{
			}

			// Token: 0x06004DE4 RID: 19940 RVA: 0x00018DE0 File Offset: 0x00016FE0
			[Token(Token = "0x60077AB")]
			[Address(RVA = "0x23A8110", Offset = "0x23A8211", VA = "0x23A8110")]
			internal bool <DestroyPivotObjects>b__8_0(SpringBone springBone)
			{
				return default(bool);
			}

			// Token: 0x06004DE5 RID: 19941 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60077AC")]
			[Address(RVA = "0x23A8190", Offset = "0x23A8291", VA = "0x23A8190")]
			internal Transform <DestroyPivotObjects>b__8_1(SpringBone springBone)
			{
				return null;
			}

			// Token: 0x06004DE6 RID: 19942 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60077AD")]
			[Address(RVA = "0x23A81B0", Offset = "0x23A82B1", VA = "0x23A81B0")]
			internal GameObject <DestroyPivotObjects>b__8_3(Transform pivot)
			{
				return null;
			}

			// Token: 0x06004DE7 RID: 19943 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60077AE")]
			[Address(RVA = "0x23A81D0", Offset = "0x23A82D1", VA = "0x23A81D0")]
			internal Mesh <FindClosestMeshNormalToPoint>b__10_0(SkinnedMeshRenderer renderer)
			{
				return null;
			}

			// Token: 0x06004DE8 RID: 19944 RVA: 0x00018DF8 File Offset: 0x00016FF8
			[Token(Token = "0x60077AF")]
			[Address(RVA = "0x23A81F0", Offset = "0x23A82F1", VA = "0x23A81F0")]
			internal bool <FindClosestMeshNormalToPoint>b__10_1(Mesh mesh)
			{
				return default(bool);
			}

			// Token: 0x06004DE9 RID: 19945 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60077B0")]
			[Address(RVA = "0x23A8290", Offset = "0x23A8391", VA = "0x23A8290")]
			internal <>f__AnonymousType0<SpringBone, int> <GetSpringBonesSortedByDepth>b__13_0(SpringBone bone)
			{
				return null;
			}

			// Token: 0x06004DEA RID: 19946 RVA: 0x00018E10 File Offset: 0x00017010
			[Token(Token = "0x60077B1")]
			[Address(RVA = "0x23A8330", Offset = "0x23A8431", VA = "0x23A8330")]
			internal int <GetSpringBonesSortedByDepth>b__13_1(<>f__AnonymousType0<SpringBone, int> a, <>f__AnonymousType0<SpringBone, int> b)
			{
				return 0;
			}

			// Token: 0x06004DEB RID: 19947 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60077B2")]
			[Address(RVA = "0x23A83B0", Offset = "0x23A84B1", VA = "0x23A83B0")]
			internal SpringBone <GetSpringBonesSortedByDepth>b__13_2(<>f__AnonymousType0<SpringBone, int> item)
			{
				return null;
			}

			// Token: 0x0400AF3F RID: 44863
			[Token(Token = "0x401B78E")]
			[FieldOffset(Offset = "0x0")]
			public static readonly SpringBoneSetup.<>c <>9;

			// Token: 0x0400AF40 RID: 44864
			[Token(Token = "0x401B78F")]
			[FieldOffset(Offset = "0x8")]
			public static Func<SpringBone, bool> <>9__8_0;

			// Token: 0x0400AF41 RID: 44865
			[Token(Token = "0x401B790")]
			[FieldOffset(Offset = "0x10")]
			public static Func<SpringBone, Transform> <>9__8_1;

			// Token: 0x0400AF42 RID: 44866
			[Token(Token = "0x401B791")]
			[FieldOffset(Offset = "0x18")]
			public static Func<Transform, GameObject> <>9__8_3;

			// Token: 0x0400AF43 RID: 44867
			[Token(Token = "0x401B792")]
			[FieldOffset(Offset = "0x20")]
			public static Func<SkinnedMeshRenderer, Mesh> <>9__10_0;

			// Token: 0x0400AF44 RID: 44868
			[Token(Token = "0x401B793")]
			[FieldOffset(Offset = "0x28")]
			public static Func<Mesh, bool> <>9__10_1;

			// Token: 0x0400AF45 RID: 44869
			[Token(Token = "0x401B794")]
			[FieldOffset(Offset = "0x30")]
			public static Func<SpringBone, <>f__AnonymousType0<SpringBone, int>> <>9__13_0;

			// Token: 0x0400AF46 RID: 44870
			[Token(Token = "0x401B795")]
			[FieldOffset(Offset = "0x38")]
			public static Comparison<<>f__AnonymousType0<SpringBone, int>> <>9__13_1;

			// Token: 0x0400AF47 RID: 44871
			[Token(Token = "0x401B796")]
			[FieldOffset(Offset = "0x40")]
			public static Func<<>f__AnonymousType0<SpringBone, int>, SpringBone> <>9__13_2;
		}
	}
}
