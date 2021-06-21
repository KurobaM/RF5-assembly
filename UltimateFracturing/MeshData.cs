using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace UltimateFracturing
{
	// Token: 0x02000C53 RID: 3155
	[Token(Token = "0x2000806")]
	public class MeshData
	{
		// Token: 0x06004FE9 RID: 20457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600421E")]
		[Address(RVA = "0x20F27D0", Offset = "0x20F28D1", VA = "0x20F27D0")]
		private MeshData()
		{
		}

		// Token: 0x06004FEA RID: 20458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600421F")]
		[Address(RVA = "0x20F29C0", Offset = "0x20F2AC1", VA = "0x20F29C0")]
		public MeshData(Material[] aMaterials, List<int>[] alistIndices, List<VertexData> listVertexData, int nSplitCloseSubMesh, Vector3 v3Position, Quaternion qRotation, Vector3 v3Scale, Matrix4x4 mtxTransformVertices, bool bUseTransform, bool bBuildVertexHashData)
		{
		}

		// Token: 0x06004FEB RID: 20459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004220")]
		[Address(RVA = "0x20F3860", Offset = "0x20F3961", VA = "0x20F3860")]
		public MeshData(Transform transform, Mesh mesh, Material[] aMaterials, Matrix4x4 mtxLocalToWorld, bool bTransformVerticesToWorld, int nSplitCloseSubMesh, bool bBuildVertexHashData)
		{
		}

		// Token: 0x06004FEC RID: 20460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004221")]
		[Address(RVA = "0x20F3990", Offset = "0x20F3A91", VA = "0x20F3990")]
		public MeshData(Vector3 v3Position, Quaternion qRotation, Vector3 v3Scale, Mesh mesh, Material[] aMaterials, Matrix4x4 mtxLocalToWorld, bool bTransformVerticesToWorld, int nSplitCloseSubMesh, bool bBuildVertexHashData)
		{
		}

		// Token: 0x06004FED RID: 20461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004222")]
		[Address(RVA = "0x20F4360", Offset = "0x20F4461", VA = "0x20F4360")]
		public static MeshData CreateBoxMeshData(Vector3 v3Pos, Quaternion qRot, Vector3 v3Scale, Vector3 v3Min, Vector3 v3Max)
		{
			return null;
		}

		// Token: 0x06004FEE RID: 20462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004223")]
		[Address(RVA = "0x20F4950", Offset = "0x20F4A51", VA = "0x20F4950")]
		public MeshData GetDeepCopy()
		{
			return null;
		}

		// Token: 0x06004FEF RID: 20463 RVA: 0x00019B18 File Offset: 0x00017D18
		[Token(Token = "0x6004224")]
		[Address(RVA = "0x20F5480", Offset = "0x20F5581", VA = "0x20F5480")]
		public bool FillMeshFilter(MeshFilter meshFilter, bool bTransformVerticesToLocal)
		{
			return default(bool);
		}

		// Token: 0x06004FF0 RID: 20464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004225")]
		[Address(RVA = "0x20F2CF0", Offset = "0x20F2DF1", VA = "0x20F2CF0")]
		public static void ComputeMinMax(IEnumerable<VertexData> VertexData, ref Vector3 v3Min, ref Vector3 v3Max)
		{
		}

		// Token: 0x06004FF1 RID: 20465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004226")]
		[Address(RVA = "0x20F30D0", Offset = "0x20F31D1", VA = "0x20F30D0")]
		private void BuildVertexHashData()
		{
		}

		// Token: 0x06004FF2 RID: 20466 RVA: 0x00019B30 File Offset: 0x00017D30
		[Token(Token = "0x6004227")]
		[Address(RVA = "0x20F5B90", Offset = "0x20F5C91", VA = "0x20F5B90")]
		public bool GetSharedFacesArea(FracturedObject fracturedComponent, MeshData meshData2, out float fSharedArea)
		{
			return default(bool);
		}

		// Token: 0x06004FF3 RID: 20467 RVA: 0x00019B48 File Offset: 0x00017D48
		[Token(Token = "0x6004228")]
		[Address(RVA = "0x20F66C0", Offset = "0x20F67C1", VA = "0x20F66C0")]
		private static bool Face2InsideFace1(FracturedObject fracturedComponent, MeshData meshData1, MeshData meshData2, MeshDataConnectivity.Face face1, MeshDataConnectivity.Face face2)
		{
			return default(bool);
		}

		// Token: 0x06004FF4 RID: 20468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004229")]
		[Address(RVA = "0x20F7070", Offset = "0x20F7171", VA = "0x20F7070")]
		public static List<MeshData> PostProcessConnectivity(MeshData meshDataSource, MeshFaceConnectivity connectivity, MeshDataConnectivity meshConnectivity, List<int>[] alistIndices, List<VertexData> listVertexData, int nSplitCloseSubMesh, int nCurrentVertexHash, bool bTransformToLocal)
		{
			return null;
		}

		// Token: 0x06004FF5 RID: 20469 RVA: 0x00019B60 File Offset: 0x00017D60
		[Token(Token = "0x600422A")]
		[Address(RVA = "0x20F7EE0", Offset = "0x20F7FE1", VA = "0x20F7EE0")]
		private static bool StillHasFacesToProcess(List<int>[] alistFacesRemaining)
		{
			return default(bool);
		}

		// Token: 0x06004FF6 RID: 20470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600422B")]
		[Address(RVA = "0x20F7730", Offset = "0x20F7831", VA = "0x20F7730")]
		private static void LookForClosedObjectRecursive(MeshFaceConnectivity connectivity, MeshDataConnectivity meshConnectivity, int nSubMeshStart, int nFaceSubMeshStart, List<int>[] alistIndicesIn, List<VertexData> listVertexDataIn, List<int>[] alistFacesRemainingInOut, int[] aLinearFaceIndexStart, List<int>[] alistIndicesOut, List<VertexData> listVertexDataOut, Dictionary<int, int> dicVertexRemap, MeshDataConnectivity meshConnectivityOut)
		{
		}

		// Token: 0x0400B0B8 RID: 45240
		[Token(Token = "0x400847A")]
		[FieldOffset(Offset = "0x10")]
		public int nSubMeshCount;

		// Token: 0x0400B0B9 RID: 45241
		[Token(Token = "0x400847B")]
		[FieldOffset(Offset = "0x18")]
		public int[][] aaIndices;

		// Token: 0x0400B0BA RID: 45242
		[Token(Token = "0x400847C")]
		[FieldOffset(Offset = "0x20")]
		public int nSplitCloseSubMesh;

		// Token: 0x0400B0BB RID: 45243
		[Token(Token = "0x400847D")]
		[FieldOffset(Offset = "0x28")]
		public VertexData[] aVertexData;

		// Token: 0x0400B0BC RID: 45244
		[Token(Token = "0x400847E")]
		[FieldOffset(Offset = "0x30")]
		public Vector3 v3Position;

		// Token: 0x0400B0BD RID: 45245
		[Token(Token = "0x400847F")]
		[FieldOffset(Offset = "0x3C")]
		public Quaternion qRotation;

		// Token: 0x0400B0BE RID: 45246
		[Token(Token = "0x4008480")]
		[FieldOffset(Offset = "0x4C")]
		public Vector3 v3Scale;

		// Token: 0x0400B0BF RID: 45247
		[Token(Token = "0x4008481")]
		[FieldOffset(Offset = "0x58")]
		public Vector3 v3Min;

		// Token: 0x0400B0C0 RID: 45248
		[Token(Token = "0x4008482")]
		[FieldOffset(Offset = "0x64")]
		public Vector3 v3Max;

		// Token: 0x0400B0C1 RID: 45249
		[Token(Token = "0x4008483")]
		[FieldOffset(Offset = "0x70")]
		public int nCurrentVertexHash;

		// Token: 0x0400B0C2 RID: 45250
		[Token(Token = "0x4008484")]
		[FieldOffset(Offset = "0x78")]
		public Material[] aMaterials;

		// Token: 0x0400B0C3 RID: 45251
		[Token(Token = "0x4008485")]
		[FieldOffset(Offset = "0x80")]
		public MeshDataConnectivity meshDataConnectivity;

		// Token: 0x02000C54 RID: 3156
		[Token(Token = "0x20013C6")]
		public class IncreasingSizeComparer : IComparer<MeshData>
		{
			// Token: 0x06004FF7 RID: 20471 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007895")]
			[Address(RVA = "0x20F8710", Offset = "0x20F8811", VA = "0x20F8710")]
			public IncreasingSizeComparer(int nSplitAxis)
			{
			}

			// Token: 0x06004FF8 RID: 20472 RVA: 0x00019B78 File Offset: 0x00017D78
			[Token(Token = "0x6007896")]
			[Address(RVA = "0x20F8740", Offset = "0x20F8841", VA = "0x20F8740", Slot = "4")]
			public int Compare(MeshData a, MeshData b)
			{
				return 0;
			}

			// Token: 0x0400B0C4 RID: 45252
			[Token(Token = "0x401B882")]
			[FieldOffset(Offset = "0x10")]
			private int nSplitAxis;
		}

		// Token: 0x02000C55 RID: 3157
		[Token(Token = "0x20013C7")]
		public class DecreasingSizeComparer : IComparer<MeshData>
		{
			// Token: 0x06004FF9 RID: 20473 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007897")]
			[Address(RVA = "0x20F84F0", Offset = "0x20F85F1", VA = "0x20F84F0")]
			public DecreasingSizeComparer(int nSplitAxis)
			{
			}

			// Token: 0x06004FFA RID: 20474 RVA: 0x00019B90 File Offset: 0x00017D90
			[Token(Token = "0x6007898")]
			[Address(RVA = "0x20F8520", Offset = "0x20F8621", VA = "0x20F8520", Slot = "4")]
			public int Compare(MeshData a, MeshData b)
			{
				return 0;
			}

			// Token: 0x0400B0C5 RID: 45253
			[Token(Token = "0x401B883")]
			[FieldOffset(Offset = "0x10")]
			private int nSplitAxis;
		}
	}
}
