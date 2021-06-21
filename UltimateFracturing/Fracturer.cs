using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Poly2Tri;
using UnityEngine;

namespace UltimateFracturing
{
	// Token: 0x02000C3E RID: 3134
	[Token(Token = "0x20007FC")]
	public static class Fracturer
	{
		// Token: 0x06004F93 RID: 20371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041E3")]
		[Address(RVA = "0x23B9A60", Offset = "0x23B9B61", VA = "0x23B9A60")]
		public static void CancelFracturing()
		{
		}

		// Token: 0x06004F94 RID: 20372 RVA: 0x00019848 File Offset: 0x00017A48
		[Token(Token = "0x60041E4")]
		[Address(RVA = "0x23B9B80", Offset = "0x23B9C81", VA = "0x23B9B80")]
		public static bool IsFracturingCancelled()
		{
			return default(bool);
		}

		// Token: 0x06004F95 RID: 20373 RVA: 0x00019860 File Offset: 0x00017A60
		[Token(Token = "0x60041E5")]
		[Address(RVA = "0x23B9CA0", Offset = "0x23B9DA1", VA = "0x23B9CA0")]
		public static bool FractureToChunks(FracturedObject fracturedComponent, bool bPositionOnSourceAndHideOriginal, out List<GameObject> listGameObjectsOut, [Optional] Fracturer.ProgressDelegate progress)
		{
			return default(bool);
		}

		// Token: 0x06004F96 RID: 20374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041E6")]
		[Address(RVA = "0x23BA2C0", Offset = "0x23BA3C1", VA = "0x23BA2C0")]
		private static Mesh CopyMesh(MeshFilter meshfIn)
		{
			return null;
		}

		// Token: 0x06004F97 RID: 20375 RVA: 0x00019878 File Offset: 0x00017A78
		[Token(Token = "0x60041E7")]
		[Address(RVA = "0x23BA6D0", Offset = "0x23BA7D1", VA = "0x23BA6D0")]
		private static bool FractureToChunksBSP(FracturedObject fracturedComponent, bool bPositionOnSourceAndHideOriginal, out List<GameObject> listGameObjectsOut, [Optional] Fracturer.ProgressDelegate progress)
		{
			return default(bool);
		}

		// Token: 0x06004F98 RID: 20376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041E8")]
		[Address(RVA = "0x23BC390", Offset = "0x23BC491", VA = "0x23BC390")]
		public static List<MeshData> ComputeMeshDataIslands(MeshData meshDataIn, bool bVerticesAreLocal, FracturedObject fracturedComponent, Fracturer.ProgressDelegate progress)
		{
			return null;
		}

		// Token: 0x06004F99 RID: 20377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041E9")]
		[Address(RVA = "0x23C6A00", Offset = "0x23C6B01", VA = "0x23C6A00")]
		public static void ComputeChunkColliders(FracturedObject fracturedComponent, Fracturer.ProgressDelegate progress)
		{
		}

		// Token: 0x06004F9A RID: 20378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041EA")]
		[Address(RVA = "0x23C7D80", Offset = "0x23C7E81", VA = "0x23C7D80")]
		public static void DeleteChunkColliders(FracturedObject fracturedComponent)
		{
		}

		// Token: 0x06004F9B RID: 20379 RVA: 0x00019890 File Offset: 0x00017A90
		[Token(Token = "0x60041EB")]
		[Address(RVA = "0x23BDA50", Offset = "0x23BDB51", VA = "0x23BDA50")]
		private static Matrix4x4 GetRandomPlaneSplitMatrix(MeshData meshDataIn, FracturedObject fracturedComponent, out int nSplitAxisPerformed)
		{
			return default(Matrix4x4);
		}

		// Token: 0x06004F9C RID: 20380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041EC")]
		[Address(RVA = "0x23C62E0", Offset = "0x23C63E1", VA = "0x23C62E0")]
		private static GameObject CreateNewSplitGameObject(GameObject gameObjectIn, FracturedObject fracturedComponent, string strName, bool bTransformVerticesBackToLocal, MeshData meshData)
		{
			return null;
		}

		// Token: 0x06004F9D RID: 20381 RVA: 0x000198A8 File Offset: 0x00017AA8
		[Token(Token = "0x60041ED")]
		[Address(RVA = "0x23C80C0", Offset = "0x23C81C1", VA = "0x23C80C0")]
		private static int CreateMeshConnectivityVoronoiHash(int nCell1, int nCell2)
		{
			return 0;
		}

		// Token: 0x06004F9E RID: 20382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041EE")]
		[Address(RVA = "0x23C66C0", Offset = "0x23C67C1", VA = "0x23C66C0")]
		private static void ComputeChunkConnections(FracturedObject fracturedObject, List<GameObject> listGameObjects, List<MeshData> listMeshDatas, [Optional] Fracturer.ProgressDelegate progress)
		{
		}

		// Token: 0x06004F9F RID: 20383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041EF")]
		[Address(RVA = "0x23C7A00", Offset = "0x23C7B01", VA = "0x23C7A00")]
		private static void RemoveEmptySubmeshes(FracturedChunk fracturedChunk)
		{
		}

		// Token: 0x06004FA0 RID: 20384 RVA: 0x000198C0 File Offset: 0x00017AC0
		[Token(Token = "0x60041F0")]
		[Address(RVA = "0x23C8160", Offset = "0x23C8261", VA = "0x23C8160")]
		public static bool SplitMeshUsingPlane(GameObject gameObjectIn, FracturedObject fracturedComponent, Fracturer.SplitOptions splitOptions, Transform transformPlaneSplit, out List<GameObject> listGameObjectsPosOut, out List<GameObject> listGameObjectsNegOut, [Optional] Fracturer.ProgressDelegate progress)
		{
			return default(bool);
		}

		// Token: 0x06004FA1 RID: 20385 RVA: 0x000198D8 File Offset: 0x00017AD8
		[Token(Token = "0x60041F1")]
		[Address(RVA = "0x23BE580", Offset = "0x23BE681", VA = "0x23BE580")]
		private static bool SplitMeshUsingPlane(MeshData meshDataIn, FracturedObject fracturedComponent, Fracturer.SplitOptions splitOptions, Vector3 v3PlaneNormal, Vector3 v3PlaneRight, Vector3 v3PlanePoint, out List<MeshData> listMeshDatasPosOut, out List<MeshData> listMeshDatasNegOut, [Optional] Fracturer.ProgressDelegate progress)
		{
			return default(bool);
		}

		// Token: 0x06004FA2 RID: 20386 RVA: 0x000198F0 File Offset: 0x00017AF0
		[Token(Token = "0x60041F2")]
		[Address(RVA = "0x23BCAA0", Offset = "0x23BCBA1", VA = "0x23BCAA0")]
		private static bool ComputeIslandsMeshDataConnectivity(FracturedObject fracturedComponent, bool bVerticesAreLocal, MeshData meshData1, MeshData meshData2)
		{
			return default(bool);
		}

		// Token: 0x06004FA3 RID: 20387 RVA: 0x00019908 File Offset: 0x00017B08
		[Token(Token = "0x60041F3")]
		[Address(RVA = "0x23CB8E0", Offset = "0x23CB9E1", VA = "0x23CB8E0")]
		public static bool IntersectEdges2D(float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4)
		{
			return default(bool);
		}

		// Token: 0x06004FA4 RID: 20388 RVA: 0x00019920 File Offset: 0x00017B20
		[Token(Token = "0x60041F4")]
		[Address(RVA = "0x23CBB20", Offset = "0x23CBC21", VA = "0x23CBB20")]
		private static float CrossProduct2D(Vector2 a, Vector2 b)
		{
			return 0f;
		}

		// Token: 0x06004FA5 RID: 20389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041F5")]
		[Address(RVA = "0x23C95A0", Offset = "0x23C96A1", VA = "0x23C95A0")]
		private static void TriangulateConstrainedDelaunay(List<List<Vector3>> listlistPointsConstrainedDelaunay, List<List<int>> listlistHashValuesConstrainedDelaunay, bool bForceVertexSoup, FracturedObject fracturedComponent, bool bConnectivityPostprocess, MeshFaceConnectivity faceConnectivityPos, MeshFaceConnectivity faceConnectivityNeg, MeshDataConnectivity meshConnectivityPos, MeshDataConnectivity meshConnectivityNeg, int nForceMeshConnectivityHash, int nSplitCloseSubMesh, Matrix4x4 mtxPlane, Matrix4x4 mtxToLocalPos, Matrix4x4 mtxToLocalNeg, Vector3 v3CenterPos, Vector3 v3CenterNeg, List<int>[] aListIndicesPosInOut, List<VertexData> listVertexDataPosInOut, List<int>[] aListIndicesNegInOut, List<VertexData> listVertexDataNegInOut)
		{
		}

		// Token: 0x06004FA6 RID: 20390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041F6")]
		[Address(RVA = "0x23CBB30", Offset = "0x23CBC31", VA = "0x23CBB30")]
		private static void CreateIndexedMesh(IList<DelaunayTriangle> listTriangles, List<Vector3> listVerticesOut, List<int> listIndicesOut, Matrix4x4 mtxTransform, bool bTransform)
		{
		}

		// Token: 0x06004FA7 RID: 20391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041F7")]
		[Address(RVA = "0x23CC230", Offset = "0x23CC331", VA = "0x23CC230")]
		private static void Triangulate(List<Vector3> listVertices, List<int> listIndices, FracturedObject fracturedComponent, List<List<Vector3>> listlistPointsConstrainedDelaunay, List<List<int>> listlistHashValuesConstrainedDelaunay, bool bConnectivityPostprocess, MeshFaceConnectivity faceConnectivityPos, MeshFaceConnectivity faceConnectivityNeg, MeshDataConnectivity meshConnectivityPos, MeshDataConnectivity meshConnectivityNeg, int nForceMeshConnectivityHash, int nSplitCloseSubMesh, Matrix4x4 mtxPlane, Matrix4x4 mtxToLocalPos, Matrix4x4 mtxToLocalNeg, Vector3 v3CenterPos, Vector3 v3CenterNeg, List<int>[] aListIndicesPosInOut, List<VertexData> listVertexDataPosInOut, List<int>[] aListIndicesNegInOut, List<VertexData> listVertexDataNegInOut)
		{
		}

		// Token: 0x06004FA8 RID: 20392 RVA: 0x00019938 File Offset: 0x00017B38
		[Token(Token = "0x60041F8")]
		[Address(RVA = "0x23CD1E0", Offset = "0x23CD2E1", VA = "0x23CD1E0")]
		private static int ComputeVertexHash(Vector3 v3Vertex, List<List<Vector3>> listlistPointsConstrainedDelaunay, List<List<int>> listlistHashValuesConstrainedDelaunay)
		{
			return 0;
		}

		// Token: 0x06004FA9 RID: 20393 RVA: 0x00019950 File Offset: 0x00017B50
		[Token(Token = "0x60041F9")]
		[Address(RVA = "0x23C8A80", Offset = "0x23C8B81", VA = "0x23C8A80")]
		private static bool AddCapEdge(Dictionary<EdgeKeyByHash, CapEdge> dicCapEdges, int nVertexHash1, int nVertexHash2, Vector3 v3Vertex1, Vector3 v3Vertex2)
		{
			return default(bool);
		}

		// Token: 0x06004FAA RID: 20394 RVA: 0x00019968 File Offset: 0x00017B68
		[Token(Token = "0x60041FA")]
		[Address(RVA = "0x23C8BC0", Offset = "0x23C8CC1", VA = "0x23C8BC0")]
		private static bool ResolveCap(Dictionary<EdgeKeyByHash, CapEdge> dicCapEdges, List<List<Vector3>> listlistResolvedCapVertices, List<List<int>> listlistResolvedCapHashValues, FracturedObject fracturedComponent)
		{
			return default(bool);
		}

		// Token: 0x0400B05F RID: 45151
		[Token(Token = "0x400844C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Fracturer.FracturingStats s_FracturingStats;

		// Token: 0x02000C3F RID: 3135
		[Token(Token = "0x20013BD")]
		private class FracturingStats
		{
			// Token: 0x06004FAC RID: 20396 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600787E")]
			[Address(RVA = "0x20F1550", Offset = "0x20F1651", VA = "0x20F1550")]
			public FracturingStats()
			{
			}

			// Token: 0x0400B060 RID: 45152
			[Token(Token = "0x401B85D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int nChunkCount;

			// Token: 0x0400B061 RID: 45153
			[Token(Token = "0x401B85E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int nTotalChunks;

			// Token: 0x0400B062 RID: 45154
			[Token(Token = "0x401B85F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int nSplitCount;

			// Token: 0x0400B063 RID: 45155
			[Token(Token = "0x401B860")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool bCancelFracturing;
		}

		// Token: 0x02000C40 RID: 3136
		// (Invoke) Token: 0x06004FAE RID: 20398
		[Token(Token = "0x20013BE")]
		public delegate void ProgressDelegate(string strTitle, string message, float fT);

		// Token: 0x02000C41 RID: 3137
		[Token(Token = "0x20013BF")]
		private class SpaceTreeNode
		{
			// Token: 0x06004FB1 RID: 20401 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007883")]
			[Address(RVA = "0x20F1AA0", Offset = "0x20F1BA1", VA = "0x20F1AA0")]
			public SpaceTreeNode()
			{
			}

			// Token: 0x06004FB2 RID: 20402 RVA: 0x00019980 File Offset: 0x00017B80
			[Token(Token = "0x6007884")]
			[Address(RVA = "0x20F1B50", Offset = "0x20F1C51", VA = "0x20F1B50")]
			public bool ContainsCompletely(Vector3 v3Min, Vector3 v3Max)
			{
				return default(bool);
			}

			// Token: 0x06004FB3 RID: 20403 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007885")]
			[Address(RVA = "0x20F1BD0", Offset = "0x20F1CD1", VA = "0x20F1BD0")]
			public static List<MeshData> GetSmallestPossibleMeshData(Fracturer.SpaceTreeNode root, Vector3 v3Min, Vector3 v3Max)
			{
				return null;
			}

			// Token: 0x06004FB4 RID: 20404 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007886")]
			[Address(RVA = "0x20F1D40", Offset = "0x20F1E41", VA = "0x20F1D40")]
			public static Fracturer.SpaceTreeNode BuildSpaceTree(MeshData meshDataIn, int nSubdivisionLevels, FracturedObject fracturedComponent, [Optional] Fracturer.ProgressDelegate progress)
			{
				return null;
			}

			// Token: 0x0400B064 RID: 45156
			[Token(Token = "0x401B861")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Fracturer.SpaceTreeNode nodeOneSide;

			// Token: 0x0400B065 RID: 45157
			[Token(Token = "0x401B862")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Fracturer.SpaceTreeNode nodeOtherSide;

			// Token: 0x0400B066 RID: 45158
			[Token(Token = "0x401B863")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int nLevel;

			// Token: 0x0400B067 RID: 45159
			[Token(Token = "0x401B864")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private int nSplitsX;

			// Token: 0x0400B068 RID: 45160
			[Token(Token = "0x401B865")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int nSplitsY;

			// Token: 0x0400B069 RID: 45161
			[Token(Token = "0x401B866")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private int nSplitsZ;

			// Token: 0x0400B06A RID: 45162
			[Token(Token = "0x401B867")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 v3Min;

			// Token: 0x0400B06B RID: 45163
			[Token(Token = "0x401B868")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 v3Max;

			// Token: 0x0400B06C RID: 45164
			[Token(Token = "0x401B869")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private List<MeshData> listMeshDatasSpace;
		}

		// Token: 0x02000C42 RID: 3138
		[Token(Token = "0x20013C0")]
		public class SplitOptions
		{
			// Token: 0x06004FB5 RID: 20405 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007887")]
			[Address(RVA = "0x20F2720", Offset = "0x20F2821", VA = "0x20F2720")]
			public SplitOptions()
			{
			}

			// Token: 0x0400B06D RID: 45165
			[Token(Token = "0x401B86A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Fracturer.SplitOptions Default;

			// Token: 0x0400B06E RID: 45166
			[Token(Token = "0x401B86B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool bForceNoProgressInfo;

			// Token: 0x0400B06F RID: 45167
			[Token(Token = "0x401B86C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			public bool bForceNoIslandGeneration;

			// Token: 0x0400B070 RID: 45168
			[Token(Token = "0x401B86D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
			public bool bForceNoChunkConnectionInfo;

			// Token: 0x0400B071 RID: 45169
			[Token(Token = "0x401B86E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
			public bool bForceNoIslandConnectionInfo;

			// Token: 0x0400B072 RID: 45170
			[Token(Token = "0x401B86F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool bForceNoCap;

			// Token: 0x0400B073 RID: 45171
			[Token(Token = "0x401B870")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			public bool bForceCapVertexSoup;

			// Token: 0x0400B074 RID: 45172
			[Token(Token = "0x401B871")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
			public bool bIgnoreNegativeSide;

			// Token: 0x0400B075 RID: 45173
			[Token(Token = "0x401B872")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17")]
			public bool bVerticesAreLocal;

			// Token: 0x0400B076 RID: 45174
			[Token(Token = "0x401B873")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int nForceMeshConnectivityHash;
		}
	}
}
