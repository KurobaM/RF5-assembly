using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UltimateFracturing
{
	// Token: 0x02000C45 RID: 3141
	[Token(Token = "0x20007FF")]
	public class VertexData
	{
		// Token: 0x06004FBB RID: 20411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004200")]
		[Address(RVA = "0x20F4820", Offset = "0x20F4921", VA = "0x20F4820")]
		public VertexData(int nVertexHash)
		{
		}

		// Token: 0x06004FBC RID: 20412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004201")]
		[Address(RVA = "0x20FC590", Offset = "0x20FC691", VA = "0x20FC590")]
		public VertexData(int nVertexHash, Vector3 v3Vertex, Vector3 v3Normal, Vector3 v4Tangent, Color32 color32, Vector2 v2Mapping1, Vector2 v2Mapping2, bool bHasNormal, bool bHasTangent, bool bHasColor32, bool bHasMapping1, bool bHasMapping2)
		{
		}

		// Token: 0x06004FBD RID: 20413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004202")]
		[Address(RVA = "0x20F8400", Offset = "0x20F8501", VA = "0x20F8400")]
		public VertexData Copy()
		{
			return null;
		}

		// Token: 0x06004FBE RID: 20414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004203")]
		[Address(RVA = "0x20FC730", Offset = "0x20FC831", VA = "0x20FC730")]
		public static VertexData Lerp(int nVertexHash, VertexData vd1, VertexData vd2, float fT)
		{
			return null;
		}

		// Token: 0x06004FBF RID: 20415 RVA: 0x00019998 File Offset: 0x00017B98
		[Token(Token = "0x6004204")]
		[Address(RVA = "0x20FCA50", Offset = "0x20FCB51", VA = "0x20FCA50")]
		public static bool ClipAgainstPlane(VertexData[] aVertexDataInput, int nIndexA, int nIndexB, Vector3 v3A, Vector3 v3B, Plane planeSplit, ref VertexData clippedVertexDataOut)
		{
			return default(bool);
		}

		// Token: 0x06004FC0 RID: 20416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004205")]
		[Address(RVA = "0x20F3CA0", Offset = "0x20F3DA1", VA = "0x20F3CA0")]
		public static VertexData[] BuildVertexDataArray(Mesh mesh, Matrix4x4 mtxLocalToWorld, bool bTransformVerticesToWorld)
		{
			return null;
		}

		// Token: 0x06004FC1 RID: 20417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004206")]
		[Address(RVA = "0x20F5600", Offset = "0x20F5701", VA = "0x20F5600")]
		public static void SetMeshDataFromVertexDataArray(MeshFilter meshFilter, MeshData meshData, bool bTransformVertexToLocal)
		{
		}

		// Token: 0x0400B080 RID: 45184
		[Token(Token = "0x4008456")]
		[FieldOffset(Offset = "0x10")]
		public int nVertexHash;

		// Token: 0x0400B081 RID: 45185
		[Token(Token = "0x4008457")]
		[FieldOffset(Offset = "0x14")]
		public Vector3 v3Vertex;

		// Token: 0x0400B082 RID: 45186
		[Token(Token = "0x4008458")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 v3Normal;

		// Token: 0x0400B083 RID: 45187
		[Token(Token = "0x4008459")]
		[FieldOffset(Offset = "0x2C")]
		public Vector4 v4Tangent;

		// Token: 0x0400B084 RID: 45188
		[Token(Token = "0x400845A")]
		[FieldOffset(Offset = "0x3C")]
		public Color32 color32;

		// Token: 0x0400B085 RID: 45189
		[Token(Token = "0x400845B")]
		[FieldOffset(Offset = "0x40")]
		public Vector2 v2Mapping1;

		// Token: 0x0400B086 RID: 45190
		[Token(Token = "0x400845C")]
		[FieldOffset(Offset = "0x48")]
		public Vector2 v2Mapping2;

		// Token: 0x0400B087 RID: 45191
		[Token(Token = "0x400845D")]
		[FieldOffset(Offset = "0x50")]
		public bool bHasNormal;

		// Token: 0x0400B088 RID: 45192
		[Token(Token = "0x400845E")]
		[FieldOffset(Offset = "0x51")]
		public bool bHasTangent;

		// Token: 0x0400B089 RID: 45193
		[Token(Token = "0x400845F")]
		[FieldOffset(Offset = "0x52")]
		public bool bHasColor32;

		// Token: 0x0400B08A RID: 45194
		[Token(Token = "0x4008460")]
		[FieldOffset(Offset = "0x53")]
		public bool bHasMapping1;

		// Token: 0x0400B08B RID: 45195
		[Token(Token = "0x4008461")]
		[FieldOffset(Offset = "0x54")]
		public bool bHasMapping2;
	}
}
