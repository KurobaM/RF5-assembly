using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace UltimateFracturing
{
	// Token: 0x02000C4C RID: 3148
	[Token(Token = "0x2000804")]
	public class MeshFaceConnectivity
	{
		// Token: 0x06004FD4 RID: 20436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004213")]
		[Address(RVA = "0x20F90E0", Offset = "0x20F91E1", VA = "0x20F90E0")]
		public MeshFaceConnectivity()
		{
		}

		// Token: 0x06004FD5 RID: 20437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004214")]
		[Address(RVA = "0x20F9260", Offset = "0x20F9361", VA = "0x20F9260")]
		public void Clear()
		{
		}

		// Token: 0x06004FD6 RID: 20438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004215")]
		[Address(RVA = "0x20F9320", Offset = "0x20F9421", VA = "0x20F9320")]
		public void ResetVisited()
		{
		}

		// Token: 0x06004FD7 RID: 20439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004216")]
		[Address(RVA = "0x20F93C0", Offset = "0x20F94C1", VA = "0x20F93C0")]
		public void AddEdge(int nSubMesh, Vector3 v1, Vector3 v2, int nVertex1Hash, int nVertex2Hash, int nVertexDataIndex1, int nVertexDataIndex2)
		{
		}

		// Token: 0x0400B09A RID: 45210
		[Token(Token = "0x4008470")]
		[FieldOffset(Offset = "0x10")]
		public List<MeshFaceConnectivity.TriangleData> listTriangles;

		// Token: 0x0400B09B RID: 45211
		[Token(Token = "0x4008471")]
		[FieldOffset(Offset = "0x18")]
		private List<MeshFaceConnectivity.EdgeData> listEdges;

		// Token: 0x0400B09C RID: 45212
		[Token(Token = "0x4008472")]
		[FieldOffset(Offset = "0x20")]
		private List<int> listEdgeIndices;

		// Token: 0x0400B09D RID: 45213
		[Token(Token = "0x4008473")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<EdgeKeyByHash, MeshFaceConnectivity.EdgeData> dicEdges;

		// Token: 0x0400B09E RID: 45214
		[Token(Token = "0x4008474")]
		[FieldOffset(Offset = "0x30")]
		private int nEdgeCount;

		// Token: 0x0400B09F RID: 45215
		[Token(Token = "0x4008475")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<int, int> dicSubMeshTriangleCount;

		// Token: 0x02000C4D RID: 3149
		[Token(Token = "0x20013C3")]
		public struct EdgeData
		{
			// Token: 0x06004FD8 RID: 20440 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600788F")]
			[Address(RVA = "0x2E1270", Offset = "0x2E1371", VA = "0x2E1270")]
			public EdgeData(int nEdgeIndex, int nFace, int nSubMesh, int nSubMeshFace, int nEdgePos, Vector3 v1, Vector3 v2, int nVertex1Hash, int nVertex2Hash, int nVertexDataV1, int nVertexDataV2)
			{
			}

			// Token: 0x06004FD9 RID: 20441 RVA: 0x00019AA0 File Offset: 0x00017CA0
			[Token(Token = "0x6007890")]
			[Address(RVA = "0x2E1290", Offset = "0x2E1391", VA = "0x2E1290")]
			public bool Compare(int nVertex1Hash, int nVertex2Hash)
			{
				return default(bool);
			}

			// Token: 0x06004FDA RID: 20442 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007891")]
			[Address(RVA = "0x2E12E0", Offset = "0x2E13E1", VA = "0x2E12E0")]
			public void AddSideData(int nFace, int nSubMesh, int nSubMeshFace, int nEdgePos, int nVertexDataV1, int nVertexDataV2)
			{
			}

			// Token: 0x06004FDB RID: 20443 RVA: 0x00019AB8 File Offset: 0x00017CB8
			[Token(Token = "0x6007892")]
			[Address(RVA = "0x2E12F0", Offset = "0x2E13F1", VA = "0x2E12F0")]
			public bool HasMoreThanOneSide()
			{
				return default(bool);
			}

			// Token: 0x0400B0A0 RID: 45216
			[Token(Token = "0x401B874")]
			[FieldOffset(Offset = "0x0")]
			public int nEdgeIndex;

			// Token: 0x0400B0A1 RID: 45217
			[Token(Token = "0x401B875")]
			[FieldOffset(Offset = "0x4")]
			private int nVertex1Hash;

			// Token: 0x0400B0A2 RID: 45218
			[Token(Token = "0x401B876")]
			[FieldOffset(Offset = "0x8")]
			private int nVertex2Hash;

			// Token: 0x0400B0A3 RID: 45219
			[Token(Token = "0x401B877")]
			[FieldOffset(Offset = "0xC")]
			public Vector3 v1;

			// Token: 0x0400B0A4 RID: 45220
			[Token(Token = "0x401B878")]
			[FieldOffset(Offset = "0x18")]
			public Vector3 v2;

			// Token: 0x0400B0A5 RID: 45221
			[Token(Token = "0x401B879")]
			[FieldOffset(Offset = "0x28")]
			public List<MeshFaceConnectivity.EdgeData.SideData> listSides;

			// Token: 0x02000C4E RID: 3150
			[Token(Token = "0x2001658")]
			public struct SideData
			{
				// Token: 0x06004FDC RID: 20444 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60080B9")]
				[Address(RVA = "0x2E1360", Offset = "0x2E1461", VA = "0x2E1360")]
				public SideData(int nFace, int nSubMesh, int nSubMeshFace, int nEdgePos, int nVertexDataV1, int nVertexDataV2)
				{
				}

				// Token: 0x0400B0A6 RID: 45222
				[Token(Token = "0x401C419")]
				[FieldOffset(Offset = "0x0")]
				public int nFace;

				// Token: 0x0400B0A7 RID: 45223
				[Token(Token = "0x401C41A")]
				[FieldOffset(Offset = "0x4")]
				public int nSubMesh;

				// Token: 0x0400B0A8 RID: 45224
				[Token(Token = "0x401C41B")]
				[FieldOffset(Offset = "0x8")]
				public int nSubMeshFace;

				// Token: 0x0400B0A9 RID: 45225
				[Token(Token = "0x401C41C")]
				[FieldOffset(Offset = "0xC")]
				public int nEdgePos;

				// Token: 0x0400B0AA RID: 45226
				[Token(Token = "0x401C41D")]
				[FieldOffset(Offset = "0x10")]
				public int nVertexDataV1;

				// Token: 0x0400B0AB RID: 45227
				[Token(Token = "0x401C41E")]
				[FieldOffset(Offset = "0x14")]
				public int nVertexDataV2;
			}
		}

		// Token: 0x02000C4F RID: 3151
		[Token(Token = "0x20013C4")]
		public class TriangleData
		{
			// Token: 0x06004FDD RID: 20445 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007893")]
			[Address(RVA = "0x20FA420", Offset = "0x20FA521", VA = "0x20FA420")]
			public TriangleData(int nSubMesh, int nTriangle)
			{
			}

			// Token: 0x0400B0AC RID: 45228
			[Token(Token = "0x401B87A")]
			[FieldOffset(Offset = "0x10")]
			public int nSubMesh;

			// Token: 0x0400B0AD RID: 45229
			[Token(Token = "0x401B87B")]
			[FieldOffset(Offset = "0x14")]
			public int nTriangle;

			// Token: 0x0400B0AE RID: 45230
			[Token(Token = "0x401B87C")]
			[FieldOffset(Offset = "0x18")]
			public int[] anEdges;

			// Token: 0x0400B0AF RID: 45231
			[Token(Token = "0x401B87D")]
			[FieldOffset(Offset = "0x20")]
			public List<int>[] alistNeighborSubMeshes;

			// Token: 0x0400B0B0 RID: 45232
			[Token(Token = "0x401B87E")]
			[FieldOffset(Offset = "0x28")]
			public List<int>[] alistNeighborTriangles;

			// Token: 0x0400B0B1 RID: 45233
			[Token(Token = "0x401B87F")]
			[FieldOffset(Offset = "0x30")]
			public bool bVisited;
		}
	}
}
