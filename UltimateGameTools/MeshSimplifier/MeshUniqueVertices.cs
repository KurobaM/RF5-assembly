using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace UltimateGameTools.MeshSimplifier
{
	// Token: 0x02000C28 RID: 3112
	[Token(Token = "0x20007F8")]
	[Serializable]
	public class MeshUniqueVertices
	{
		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x06004F0A RID: 20234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000801")]
		public MeshUniqueVertices.ListIndices[] SubmeshesFaceList
		{
			[Token(Token = "0x60041AC")]
			[Address(RVA = "0x20FD890", Offset = "0x20FD991", VA = "0x20FD890")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x06004F0B RID: 20235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000802")]
		public List<Vector3> ListVertices
		{
			[Token(Token = "0x60041AD")]
			[Address(RVA = "0x20FD8A0", Offset = "0x20FD9A1", VA = "0x20FD8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x06004F0C RID: 20236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000803")]
		public List<Vector3> ListVerticesWorld
		{
			[Token(Token = "0x60041AE")]
			[Address(RVA = "0x20FD8B0", Offset = "0x20FD9B1", VA = "0x20FD8B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x06004F0D RID: 20237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000804")]
		public List<MeshUniqueVertices.SerializableBoneWeight> ListBoneWeights
		{
			[Token(Token = "0x60041AF")]
			[Address(RVA = "0x20FD8C0", Offset = "0x20FD9C1", VA = "0x20FD8C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004F0E RID: 20238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041B0")]
		[Address(RVA = "0x20FD8D0", Offset = "0x20FD9D1", VA = "0x20FD8D0")]
		public void BuildData(Mesh sourceMesh, Vector3[] av3VerticesWorld)
		{
		}

		// Token: 0x06004F0F RID: 20239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041B1")]
		[Address(RVA = "0x20FE2E0", Offset = "0x20FE3E1", VA = "0x20FE2E0")]
		public MeshUniqueVertices()
		{
		}

		// Token: 0x0400AFD7 RID: 45015
		[Token(Token = "0x4008432")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private List<Vector3> m_listVertices;

		// Token: 0x0400AFD8 RID: 45016
		[Token(Token = "0x4008433")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<Vector3> m_listVerticesWorld;

		// Token: 0x0400AFD9 RID: 45017
		[Token(Token = "0x4008434")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<MeshUniqueVertices.SerializableBoneWeight> m_listBoneWeights;

		// Token: 0x0400AFDA RID: 45018
		[Token(Token = "0x4008435")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MeshUniqueVertices.ListIndices[] m_aFaceList;

		// Token: 0x02000C29 RID: 3113
		[Token(Token = "0x20013AB")]
		[Serializable]
		public class ListIndices
		{
			// Token: 0x06004F10 RID: 20240 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600782C")]
			[Address(RVA = "0x20FE000", Offset = "0x20FE101", VA = "0x20FE000")]
			public ListIndices()
			{
			}

			// Token: 0x0400AFDB RID: 45019
			[Token(Token = "0x401B7EF")]
			[FieldOffset(Offset = "0x10")]
			public List<int> m_listIndices;
		}

		// Token: 0x02000C2A RID: 3114
		[Token(Token = "0x20013AC")]
		[Serializable]
		public class SerializableBoneWeight
		{
			// Token: 0x06004F11 RID: 20241 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600782D")]
			[Address(RVA = "0x20FE230", Offset = "0x20FE331", VA = "0x20FE230")]
			public SerializableBoneWeight(BoneWeight boneWeight)
			{
			}

			// Token: 0x06004F12 RID: 20242 RVA: 0x000193F8 File Offset: 0x000175F8
			[Token(Token = "0x600782E")]
			[Address(RVA = "0x20FE320", Offset = "0x20FE421", VA = "0x20FE320")]
			public BoneWeight ToBoneWeight()
			{
				return default(BoneWeight);
			}

			// Token: 0x0400AFDC RID: 45020
			[Token(Token = "0x401B7F0")]
			[FieldOffset(Offset = "0x10")]
			public int _boneIndex0;

			// Token: 0x0400AFDD RID: 45021
			[Token(Token = "0x401B7F1")]
			[FieldOffset(Offset = "0x14")]
			public int _boneIndex1;

			// Token: 0x0400AFDE RID: 45022
			[Token(Token = "0x401B7F2")]
			[FieldOffset(Offset = "0x18")]
			public int _boneIndex2;

			// Token: 0x0400AFDF RID: 45023
			[Token(Token = "0x401B7F3")]
			[FieldOffset(Offset = "0x1C")]
			public int _boneIndex3;

			// Token: 0x0400AFE0 RID: 45024
			[Token(Token = "0x401B7F4")]
			[FieldOffset(Offset = "0x20")]
			public float _boneWeight0;

			// Token: 0x0400AFE1 RID: 45025
			[Token(Token = "0x401B7F5")]
			[FieldOffset(Offset = "0x24")]
			public float _boneWeight1;

			// Token: 0x0400AFE2 RID: 45026
			[Token(Token = "0x401B7F6")]
			[FieldOffset(Offset = "0x28")]
			public float _boneWeight2;

			// Token: 0x0400AFE3 RID: 45027
			[Token(Token = "0x401B7F7")]
			[FieldOffset(Offset = "0x2C")]
			public float _boneWeight3;
		}

		// Token: 0x02000C2B RID: 3115
		[Token(Token = "0x20013AD")]
		public class UniqueVertex
		{
			// Token: 0x06004F13 RID: 20243 RVA: 0x00019410 File Offset: 0x00017610
			[Token(Token = "0x600782F")]
			[Address(RVA = "0x20FE3E0", Offset = "0x20FE4E1", VA = "0x20FE3E0", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			// Token: 0x06004F14 RID: 20244 RVA: 0x00019428 File Offset: 0x00017628
			[Token(Token = "0x6007830")]
			[Address(RVA = "0x20FE4C0", Offset = "0x20FE5C1", VA = "0x20FE4C0", Slot = "2")]
			public override int GetHashCode()
			{
				return 0;
			}

			// Token: 0x06004F15 RID: 20245 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007831")]
			[Address(RVA = "0x20FE080", Offset = "0x20FE181", VA = "0x20FE080")]
			public UniqueVertex(Vector3 v3Vertex)
			{
			}

			// Token: 0x06004F16 RID: 20246 RVA: 0x00019440 File Offset: 0x00017640
			[Token(Token = "0x6007832")]
			[Address(RVA = "0x20FE660", Offset = "0x20FE761", VA = "0x20FE660")]
			public Vector3 ToVertex()
			{
				return default(Vector3);
			}

			// Token: 0x06004F17 RID: 20247 RVA: 0x00019458 File Offset: 0x00017658
			[Token(Token = "0x6007833")]
			[Address(RVA = "0x20FE720", Offset = "0x20FE821", VA = "0x20FE720")]
			public static bool operator ==(MeshUniqueVertices.UniqueVertex a, MeshUniqueVertices.UniqueVertex b)
			{
				return default(bool);
			}

			// Token: 0x06004F18 RID: 20248 RVA: 0x00019470 File Offset: 0x00017670
			[Token(Token = "0x6007834")]
			[Address(RVA = "0x20FE740", Offset = "0x20FE841", VA = "0x20FE740")]
			public static bool operator !=(MeshUniqueVertices.UniqueVertex a, MeshUniqueVertices.UniqueVertex b)
			{
				return default(bool);
			}

			// Token: 0x06004F19 RID: 20249 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007835")]
			[Address(RVA = "0x20FE4E0", Offset = "0x20FE5E1", VA = "0x20FE4E0")]
			private void FromVertex(Vector3 vertex)
			{
			}

			// Token: 0x06004F1A RID: 20250 RVA: 0x00019488 File Offset: 0x00017688
			[Token(Token = "0x6007836")]
			[Address(RVA = "0x20FE770", Offset = "0x20FE871", VA = "0x20FE770")]
			private int CoordToFixed(float fCoord)
			{
				return 0;
			}

			// Token: 0x06004F1B RID: 20251 RVA: 0x000194A0 File Offset: 0x000176A0
			[Token(Token = "0x6007837")]
			[Address(RVA = "0x20FE6F0", Offset = "0x20FE7F1", VA = "0x20FE6F0")]
			private float FixedToCoord(int nFixed)
			{
				return 0f;
			}

			// Token: 0x0400AFE4 RID: 45028
			[Token(Token = "0x401B7F8")]
			[FieldOffset(Offset = "0x10")]
			private int m_nFixedX;

			// Token: 0x0400AFE5 RID: 45029
			[Token(Token = "0x401B7F9")]
			[FieldOffset(Offset = "0x14")]
			private int m_nFixedY;

			// Token: 0x0400AFE6 RID: 45030
			[Token(Token = "0x401B7FA")]
			[FieldOffset(Offset = "0x18")]
			private int m_nFixedZ;

			// Token: 0x0400AFE7 RID: 45031
			[Token(Token = "0x401B7FB")]
			private const float fDecimalMultiplier = 100000f;
		}

		// Token: 0x02000C2C RID: 3116
		[Token(Token = "0x20013AE")]
		private class RepeatedVertex
		{
			// Token: 0x17000A22 RID: 2594
			// (get) Token: 0x06004F1C RID: 20252 RVA: 0x000194B8 File Offset: 0x000176B8
			[Token(Token = "0x17000DDA")]
			public int FaceIndex
			{
				[Token(Token = "0x6007838")]
				[Address(RVA = "0x20FE2F0", Offset = "0x20FE3F1", VA = "0x20FE2F0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000A23 RID: 2595
			// (get) Token: 0x06004F1D RID: 20253 RVA: 0x000194D0 File Offset: 0x000176D0
			[Token(Token = "0x17000DDB")]
			public int OriginalVertexIndex
			{
				[Token(Token = "0x6007839")]
				[Address(RVA = "0x20FE300", Offset = "0x20FE401", VA = "0x20FE300")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06004F1E RID: 20254 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600783A")]
			[Address(RVA = "0x20FE0D0", Offset = "0x20FE1D1", VA = "0x20FE0D0")]
			public RepeatedVertex(int nFaceIndex, int nOriginalVertexIndex)
			{
			}

			// Token: 0x0400AFE8 RID: 45032
			[Token(Token = "0x401B7FC")]
			[FieldOffset(Offset = "0x10")]
			private int _nFaceIndex;

			// Token: 0x0400AFE9 RID: 45033
			[Token(Token = "0x401B7FD")]
			[FieldOffset(Offset = "0x14")]
			private int _nOriginalVertexIndex;
		}

		// Token: 0x02000C2D RID: 3117
		[Token(Token = "0x20013AF")]
		private class RepeatedVertexList
		{
			// Token: 0x17000A24 RID: 2596
			// (get) Token: 0x06004F1F RID: 20255 RVA: 0x000194E8 File Offset: 0x000176E8
			[Token(Token = "0x17000DDC")]
			public int UniqueIndex
			{
				[Token(Token = "0x600783B")]
				[Address(RVA = "0x20FE310", Offset = "0x20FE411", VA = "0x20FE310")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06004F20 RID: 20256 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600783C")]
			[Address(RVA = "0x20FE180", Offset = "0x20FE281", VA = "0x20FE180")]
			public RepeatedVertexList(int nUniqueIndex, MeshUniqueVertices.RepeatedVertex repeatedVertex)
			{
			}

			// Token: 0x06004F21 RID: 20257 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600783D")]
			[Address(RVA = "0x20FE110", Offset = "0x20FE211", VA = "0x20FE110")]
			public void Add(MeshUniqueVertices.RepeatedVertex repeatedVertex)
			{
			}

			// Token: 0x0400AFEA RID: 45034
			[Token(Token = "0x401B7FE")]
			[FieldOffset(Offset = "0x10")]
			private int m_nUniqueIndex;

			// Token: 0x0400AFEB RID: 45035
			[Token(Token = "0x401B7FF")]
			[FieldOffset(Offset = "0x18")]
			private List<MeshUniqueVertices.RepeatedVertex> m_listRepeatedVertices;
		}
	}
}
