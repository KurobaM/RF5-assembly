using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UltimateFracturing
{
	// Token: 0x02000C3A RID: 3130
	[Token(Token = "0x20007FB")]
	public static class ConcaveColliderInterface
	{
		// Token: 0x06004F84 RID: 20356
		[Token(Token = "0x60041D8")]
		[Address(RVA = "0x23B8420", Offset = "0x23B8521", VA = "0x23B8420")]
		[PreserveSig]
		private static extern void DllInit(bool bUseMultithreading);

		// Token: 0x06004F85 RID: 20357
		[Token(Token = "0x60041D9")]
		[Address(RVA = "0x23B84A0", Offset = "0x23B85A1", VA = "0x23B84A0")]
		[PreserveSig]
		private static extern void DllClose();

		// Token: 0x06004F86 RID: 20358
		[Token(Token = "0x60041DA")]
		[Address(RVA = "0x23B8510", Offset = "0x23B8611", VA = "0x23B8510")]
		[PreserveSig]
		private static extern void SetLogFunctionPointer(IntPtr pfnUnity3DLog);

		// Token: 0x06004F87 RID: 20359
		[Token(Token = "0x60041DB")]
		[Address(RVA = "0x23B8590", Offset = "0x23B8691", VA = "0x23B8590")]
		[PreserveSig]
		private static extern void SetProgressFunctionPointer(IntPtr pfnUnity3DProgress);

		// Token: 0x06004F88 RID: 20360
		[Token(Token = "0x60041DC")]
		[Address(RVA = "0x23B8610", Offset = "0x23B8711", VA = "0x23B8610")]
		[PreserveSig]
		private static extern void CancelConvexDecomposition();

		// Token: 0x06004F89 RID: 20361
		[Token(Token = "0x60041DD")]
		[Address(RVA = "0x23B8680", Offset = "0x23B8781", VA = "0x23B8680")]
		[PreserveSig]
		private static extern bool DoConvexDecomposition(ref ConcaveColliderInterface.SConvexDecompositionInfoInOut infoInOut, Vector3[] pfVertices, int[] puIndices);

		// Token: 0x06004F8A RID: 20362
		[Token(Token = "0x60041DE")]
		[Address(RVA = "0x23B8730", Offset = "0x23B8831", VA = "0x23B8730")]
		[PreserveSig]
		private static extern bool GetHullInfo(uint uHullIndex, ref ConcaveColliderInterface.SConvexDecompositionHullInfo infoOut);

		// Token: 0x06004F8B RID: 20363
		[Token(Token = "0x60041DF")]
		[Address(RVA = "0x23B87D0", Offset = "0x23B88D1", VA = "0x23B87D0")]
		[PreserveSig]
		private static extern bool FillHullMeshData(uint uHullIndex, ref float pfVolumeOut, int[] pnIndicesOut, Vector3[] pfVerticesOut);

		// Token: 0x06004F8C RID: 20364 RVA: 0x00019818 File Offset: 0x00017A18
		[Token(Token = "0x60041E0")]
		[Address(RVA = "0x23B8890", Offset = "0x23B8991", VA = "0x23B8890")]
		public static int ComputeHull(GameObject gameObject, FracturedObject fracturedObject)
		{
			return 0;
		}

		// Token: 0x06004F8D RID: 20365 RVA: 0x00019830 File Offset: 0x00017A30
		[Token(Token = "0x60041E1")]
		[Address(RVA = "0x23B8A30", Offset = "0x23B8B31", VA = "0x23B8A30")]
		private static bool ComputeHull(GameObject gameObject, bool isTrigger, FracturedObject.ECCAlgorithm eAlgorithm, int nMaxHulls, int nMaxHullVertices, int nLegacySteps, bool bVerbose, out int nTotalTrianglesOut)
		{
			return default(bool);
		}

		// Token: 0x06004F8E RID: 20366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041E2")]
		[Address(RVA = "0x23B92F0", Offset = "0x23B93F1", VA = "0x23B92F0")]
		private static void Log(string message)
		{
		}

		// Token: 0x02000C3B RID: 3131
		[Token(Token = "0x20013BA")]
		private struct SConvexDecompositionInfoInOut
		{
			// Token: 0x0400B053 RID: 45139
			[Token(Token = "0x401B851")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public uint uMaxHullVertices;

			// Token: 0x0400B054 RID: 45140
			[Token(Token = "0x401B852")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public uint uMaxHulls;

			// Token: 0x0400B055 RID: 45141
			[Token(Token = "0x401B853")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float fPrecision;

			// Token: 0x0400B056 RID: 45142
			[Token(Token = "0x401B854")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float fBackFaceDistanceFactor;

			// Token: 0x0400B057 RID: 45143
			[Token(Token = "0x401B855")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public uint uLegacyDepth;

			// Token: 0x0400B058 RID: 45144
			[Token(Token = "0x401B856")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public uint uNormalizeInputMesh;

			// Token: 0x0400B059 RID: 45145
			[Token(Token = "0x401B857")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public uint uUseFastVersion;

			// Token: 0x0400B05A RID: 45146
			[Token(Token = "0x401B858")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public uint uTriangleCount;

			// Token: 0x0400B05B RID: 45147
			[Token(Token = "0x401B859")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public uint uVertexCount;

			// Token: 0x0400B05C RID: 45148
			[Token(Token = "0x401B85A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int nHullsOut;
		}

		// Token: 0x02000C3C RID: 3132
		[Token(Token = "0x20013BB")]
		private struct SConvexDecompositionHullInfo
		{
			// Token: 0x0400B05D RID: 45149
			[Token(Token = "0x401B85B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int nVertexCount;

			// Token: 0x0400B05E RID: 45150
			[Token(Token = "0x401B85C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int nTriangleCount;
		}

		// Token: 0x02000C3D RID: 3133
		// (Invoke) Token: 0x06004F90 RID: 20368
		[Token(Token = "0x20013BC")]
		public delegate void LogDelegate(string message);
	}
}
