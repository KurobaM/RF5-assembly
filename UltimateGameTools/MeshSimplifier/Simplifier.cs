using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UltimateGameTools.MeshSimplifier
{
	// Token: 0x02000C2F RID: 3119
	[Token(Token = "0x20007FA")]
	public class Simplifier : MonoBehaviour
	{
		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x06004F24 RID: 20260 RVA: 0x00019500 File Offset: 0x00017700
		// (set) Token: 0x06004F25 RID: 20261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000805")]
		public static bool Cancelled
		{
			[Token(Token = "0x60041B4")]
			[Address(RVA = "0x20FE9C0", Offset = "0x20FEAC1", VA = "0x20FE9C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9040", Offset = "0x1A9141")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60041B5")]
			[Address(RVA = "0x20FEA30", Offset = "0x20FEB31", VA = "0x20FEA30")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9050", Offset = "0x1A9151")]
			set
			{
			}
		}

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x06004F26 RID: 20262 RVA: 0x00019518 File Offset: 0x00017718
		// (set) Token: 0x06004F27 RID: 20263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000806")]
		public static int CoroutineFrameMiliseconds
		{
			[Token(Token = "0x60041B6")]
			[Address(RVA = "0x20FEAA0", Offset = "0x20FEBA1", VA = "0x20FEAA0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60041B7")]
			[Address(RVA = "0x20FEB10", Offset = "0x20FEC11", VA = "0x20FEB10")]
			set
			{
			}
		}

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x06004F28 RID: 20264 RVA: 0x00019530 File Offset: 0x00017730
		// (set) Token: 0x06004F29 RID: 20265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000807")]
		public bool CoroutineEnded
		{
			[Token(Token = "0x60041B8")]
			[Address(RVA = "0x20FEB80", Offset = "0x20FEC81", VA = "0x20FEB80")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9060", Offset = "0x1A9161")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60041B9")]
			[Address(RVA = "0x20FEB90", Offset = "0x20FEC91", VA = "0x20FEB90")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9070", Offset = "0x1A9171")]
			set
			{
			}
		}

		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x06004F2A RID: 20266 RVA: 0x00019548 File Offset: 0x00017748
		// (set) Token: 0x06004F2B RID: 20267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000808")]
		public bool UseEdgeLength
		{
			[Token(Token = "0x60041BA")]
			[Address(RVA = "0x20FEBA0", Offset = "0x20FECA1", VA = "0x20FEBA0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60041BB")]
			[Address(RVA = "0x20FEBB0", Offset = "0x20FECB1", VA = "0x20FEBB0")]
			set
			{
			}
		}

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x06004F2C RID: 20268 RVA: 0x00019560 File Offset: 0x00017760
		// (set) Token: 0x06004F2D RID: 20269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000809")]
		public bool UseCurvature
		{
			[Token(Token = "0x60041BC")]
			[Address(RVA = "0x20FEBC0", Offset = "0x20FECC1", VA = "0x20FEBC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60041BD")]
			[Address(RVA = "0x20FEBD0", Offset = "0x20FECD1", VA = "0x20FEBD0")]
			set
			{
			}
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x06004F2E RID: 20270 RVA: 0x00019578 File Offset: 0x00017778
		// (set) Token: 0x06004F2F RID: 20271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700080A")]
		public bool ProtectTexture
		{
			[Token(Token = "0x60041BE")]
			[Address(RVA = "0x20FEBE0", Offset = "0x20FECE1", VA = "0x20FEBE0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60041BF")]
			[Address(RVA = "0x20FEBF0", Offset = "0x20FECF1", VA = "0x20FEBF0")]
			set
			{
			}
		}

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x06004F30 RID: 20272 RVA: 0x00019590 File Offset: 0x00017790
		// (set) Token: 0x06004F31 RID: 20273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700080B")]
		public bool LockBorder
		{
			[Token(Token = "0x60041C0")]
			[Address(RVA = "0x20FEC00", Offset = "0x20FED01", VA = "0x20FEC00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60041C1")]
			[Address(RVA = "0x20FEC10", Offset = "0x20FED11", VA = "0x20FEC10")]
			set
			{
			}
		}

		// Token: 0x06004F32 RID: 20274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041C2")]
		[Address(RVA = "0x20FEC20", Offset = "0x20FED21", VA = "0x20FEC20")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A9080", Offset = "0x1A9181")]
		public IEnumerator ProgressiveMesh(GameObject gameObject, Mesh sourceMesh, RelevanceSphere[] aRelevanceSpheres, string strProgressDisplayObjectName = "", [Optional] Simplifier.ProgressDelegate progress)
		{
			return null;
		}

		// Token: 0x06004F33 RID: 20275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041C3")]
		[Address(RVA = "0x20FED50", Offset = "0x20FEE51", VA = "0x20FED50")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A90F0", Offset = "0x1A91F1")]
		public IEnumerator ComputeMeshWithVertexCount(GameObject gameObject, Mesh meshOut, int nVertices, string strProgressDisplayObjectName = "", [Optional] Simplifier.ProgressDelegate progress)
		{
			return null;
		}

		// Token: 0x06004F34 RID: 20276 RVA: 0x000195A8 File Offset: 0x000177A8
		[Token(Token = "0x60041C4")]
		[Address(RVA = "0x20FEE70", Offset = "0x20FEF71", VA = "0x20FEE70")]
		public int GetOriginalMeshUniqueVertexCount()
		{
			return 0;
		}

		// Token: 0x06004F35 RID: 20277 RVA: 0x000195C0 File Offset: 0x000177C0
		[Token(Token = "0x60041C5")]
		[Address(RVA = "0x20FEE80", Offset = "0x20FEF81", VA = "0x20FEE80")]
		public int GetOriginalMeshTriangleCount()
		{
			return 0;
		}

		// Token: 0x06004F36 RID: 20278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041C6")]
		[Address(RVA = "0x20FEED0", Offset = "0x20FEFD1", VA = "0x20FEED0")]
		public static Vector3[] GetWorldVertices(GameObject gameObject)
		{
			return null;
		}

		// Token: 0x06004F37 RID: 20279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041C7")]
		[Address(RVA = "0x20FF860", Offset = "0x20FF961", VA = "0x20FF860")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A9160", Offset = "0x1A9261")]
		private IEnumerator ConsolidateMesh(GameObject gameObject, Mesh meshIn, Mesh meshOut, Simplifier.TriangleList[] aListTriangles, Vector3[] av3Vertices, string strProgressDisplayObjectName = "", [Optional] Simplifier.ProgressDelegate progress)
		{
			return null;
		}

		// Token: 0x06004F38 RID: 20280 RVA: 0x000195D8 File Offset: 0x000177D8
		[Token(Token = "0x60041C8")]
		[Address(RVA = "0x20FF990", Offset = "0x20FFA91", VA = "0x20FF990")]
		private int MapVertex(int nVertex, int nMax)
		{
			return 0;
		}

		// Token: 0x06004F39 RID: 20281 RVA: 0x000195F0 File Offset: 0x000177F0
		[Token(Token = "0x60041C9")]
		[Address(RVA = "0x20FFA40", Offset = "0x20FFB41", VA = "0x20FFA40")]
		private float ComputeEdgeCollapseCost(Simplifier.Vertex u, Simplifier.Vertex v, float fRelevanceBias)
		{
			return 0f;
		}

		// Token: 0x06004F3A RID: 20282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041CA")]
		[Address(RVA = "0x2100240", Offset = "0x2100341", VA = "0x2100240")]
		private void ComputeEdgeCostAtVertex(Simplifier.Vertex v, Transform transform, RelevanceSphere[] aRelevanceSpheres)
		{
		}

		// Token: 0x06004F3B RID: 20283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041CB")]
		[Address(RVA = "0x21005B0", Offset = "0x21006B1", VA = "0x21005B0")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A91D0", Offset = "0x1A92D1")]
		private IEnumerator ComputeAllEdgeCollapseCosts(string strProgressDisplayObjectName, Transform transform, RelevanceSphere[] aRelevanceSpheres, [Optional] Simplifier.ProgressDelegate progress)
		{
			return null;
		}

		// Token: 0x06004F3C RID: 20284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041CC")]
		[Address(RVA = "0x21006C0", Offset = "0x21007C1", VA = "0x21006C0")]
		private void Collapse(Simplifier.Vertex u, Simplifier.Vertex v, bool bRecompute, Transform transform, RelevanceSphere[] aRelevanceSpheres)
		{
		}

		// Token: 0x06004F3D RID: 20285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041CD")]
		[Address(RVA = "0x2101870", Offset = "0x2101971", VA = "0x2101870")]
		private void AddVertices(List<Vector3> listVertices, List<Vector3> listVerticesWorld, List<MeshUniqueVertices.SerializableBoneWeight> listBoneWeights)
		{
		}

		// Token: 0x06004F3E RID: 20286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041CE")]
		[Address(RVA = "0x2101C20", Offset = "0x2101D21", VA = "0x2101C20")]
		private void AddFaceListSubMesh(int nSubMesh, List<int> listTriangles, int[] anIndices, Vector2[] v2Mapping)
		{
		}

		// Token: 0x06004F3F RID: 20287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041CF")]
		[Address(RVA = "0x2102340", Offset = "0x2102441", VA = "0x2102340")]
		private void ShareUV(Vector2[] aMapping, Simplifier.Triangle t)
		{
		}

		// Token: 0x06004F40 RID: 20288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041D0")]
		[Address(RVA = "0x2102550", Offset = "0x2102651", VA = "0x2102550")]
		private Simplifier.Vertex MinimumCostEdge()
		{
			return null;
		}

		// Token: 0x06004F41 RID: 20289 RVA: 0x00019608 File Offset: 0x00017808
		[Token(Token = "0x60041D1")]
		[Address(RVA = "0x2102600", Offset = "0x2102701", VA = "0x2102600")]
		private float HeapValue(int i)
		{
			return 0f;
		}

		// Token: 0x06004F42 RID: 20290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041D2")]
		[Address(RVA = "0x21014A0", Offset = "0x21015A1", VA = "0x21014A0")]
		private void HeapSortUp(int k)
		{
		}

		// Token: 0x06004F43 RID: 20291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041D3")]
		[Address(RVA = "0x2101670", Offset = "0x2101771", VA = "0x2101670")]
		private void HeapSortDown(int k)
		{
		}

		// Token: 0x06004F44 RID: 20292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041D4")]
		[Address(RVA = "0x21026D0", Offset = "0x21027D1", VA = "0x21026D0")]
		private void HeapAdd(Simplifier.Vertex v)
		{
		}

		// Token: 0x06004F45 RID: 20293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041D5")]
		[Address(RVA = "0x2102560", Offset = "0x2102661", VA = "0x2102560")]
		private Simplifier.Vertex HeapPop()
		{
			return null;
		}

		// Token: 0x06004F46 RID: 20294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041D6")]
		[Address(RVA = "0x2102750", Offset = "0x2102851", VA = "0x2102750")]
		public Simplifier()
		{
		}

		// Token: 0x0400AFF1 RID: 45041
		[Token(Token = "0x400843B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x176EF0", Offset = "0x176FF1")]
		private static bool <Cancelled>k__BackingField;

		// Token: 0x0400AFF2 RID: 45042
		[Token(Token = "0x400843C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x176F00", Offset = "0x177001")]
		private bool <CoroutineEnded>k__BackingField;

		// Token: 0x0400AFF3 RID: 45043
		[Token(Token = "0x400843D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static int m_nCoroutineFrameMiliseconds;

		// Token: 0x0400AFF4 RID: 45044
		[Token(Token = "0x400843E")]
		private const float MAX_VERTEX_COLLAPSE_COST = 1E+07f;

		// Token: 0x0400AFF5 RID: 45045
		[Token(Token = "0x400843F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<Simplifier.Vertex> m_listVertices;

		// Token: 0x0400AFF6 RID: 45046
		[Token(Token = "0x4008440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<Simplifier.Vertex> m_listHeap;

		// Token: 0x0400AFF7 RID: 45047
		[Token(Token = "0x4008441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Simplifier.TriangleList[] m_aListTriangles;

		// Token: 0x0400AFF8 RID: 45048
		[Token(Token = "0x4008442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Attribute(Name = "HideInInspector", RVA = "0x176F10", Offset = "0x177011")]
		private int m_nOriginalMeshVertexCount;

		// Token: 0x0400AFF9 RID: 45049
		[Token(Token = "0x4008443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[Attribute(Name = "HideInInspector", RVA = "0x176F50", Offset = "0x177051")]
		private float m_fOriginalMeshSize;

		// Token: 0x0400AFFA RID: 45050
		[Token(Token = "0x4008444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Attribute(Name = "HideInInspector", RVA = "0x176F90", Offset = "0x177091")]
		private List<int> m_listVertexMap;

		// Token: 0x0400AFFB RID: 45051
		[Token(Token = "0x4008445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Attribute(Name = "HideInInspector", RVA = "0x176FD0", Offset = "0x1770D1")]
		private List<int> m_listVertexPermutationBack;

		// Token: 0x0400AFFC RID: 45052
		[Token(Token = "0x4008446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Attribute(Name = "HideInInspector", RVA = "0x177010", Offset = "0x177111")]
		private MeshUniqueVertices m_meshUniqueVertices;

		// Token: 0x0400AFFD RID: 45053
		[Token(Token = "0x4008447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Attribute(Name = "HideInInspector", RVA = "0x177050", Offset = "0x177151")]
		private Mesh m_meshOriginal;

		// Token: 0x0400AFFE RID: 45054
		[Token(Token = "0x4008448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Attribute(Name = "HideInInspector", RVA = "0x177090", Offset = "0x177191")]
		private bool m_bUseEdgeLength;

		// Token: 0x0400AFFF RID: 45055
		[Token(Token = "0x4008449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		[SerializeField]
		[Attribute(Name = "HideInInspector", RVA = "0x1770D0", Offset = "0x1771D1")]
		private bool m_bUseCurvature;

		// Token: 0x0400B000 RID: 45056
		[Token(Token = "0x400844A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		[SerializeField]
		[Attribute(Name = "HideInInspector", RVA = "0x177110", Offset = "0x177211")]
		private bool m_bProtectTexture;

		// Token: 0x0400B001 RID: 45057
		[Token(Token = "0x400844B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		[SerializeField]
		[Attribute(Name = "HideInInspector", RVA = "0x177150", Offset = "0x177251")]
		private bool m_bLockBorder;

		// Token: 0x02000C30 RID: 3120
		// (Invoke) Token: 0x06004F49 RID: 20297
		[Token(Token = "0x20013B0")]
		public delegate void ProgressDelegate(string strTitle, string strProgressMessage, float fT);

		// Token: 0x02000C31 RID: 3121
		[Token(Token = "0x20013B1")]
		private class Triangle
		{
			// Token: 0x17000A2C RID: 2604
			// (get) Token: 0x06004F4C RID: 20300 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000DDD")]
			public Simplifier.Vertex[] Vertices
			{
				[Token(Token = "0x6007842")]
				[Address(RVA = "0x2105ED0", Offset = "0x2105FD1", VA = "0x2105ED0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000A2D RID: 2605
			// (get) Token: 0x06004F4D RID: 20301 RVA: 0x00019620 File Offset: 0x00017820
			[Token(Token = "0x17000DDE")]
			public bool HasUVData
			{
				[Token(Token = "0x6007843")]
				[Address(RVA = "0x2105EE0", Offset = "0x2105FE1", VA = "0x2105EE0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000A2E RID: 2606
			// (get) Token: 0x06004F4E RID: 20302 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000DDF")]
			public int[] IndicesUV
			{
				[Token(Token = "0x6007844")]
				[Address(RVA = "0x2105EF0", Offset = "0x2105FF1", VA = "0x2105EF0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000A2F RID: 2607
			// (get) Token: 0x06004F4F RID: 20303 RVA: 0x00019638 File Offset: 0x00017838
			[Token(Token = "0x17000DE0")]
			public Vector3 Normal
			{
				[Token(Token = "0x6007845")]
				[Address(RVA = "0x2105F00", Offset = "0x2106001", VA = "0x2105F00")]
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x17000A30 RID: 2608
			// (get) Token: 0x06004F50 RID: 20304 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000DE1")]
			public int[] Indices
			{
				[Token(Token = "0x6007846")]
				[Address(RVA = "0x2105F10", Offset = "0x2106011", VA = "0x2105F10")]
				get
				{
					return null;
				}
			}

			// Token: 0x06004F51 RID: 20305 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007847")]
			[Address(RVA = "0x2101EB0", Offset = "0x2101FB1", VA = "0x2101EB0")]
			public Triangle(Simplifier simplifier, int nSubMesh, Simplifier.Vertex v0, Simplifier.Vertex v1, Simplifier.Vertex v2, bool bUVData, int nIndex1, int nIndex2, int nIndex3)
			{
			}

			// Token: 0x06004F52 RID: 20306 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007848")]
			[Address(RVA = "0x2100E80", Offset = "0x2100F81", VA = "0x2100E80")]
			public void Destructor(Simplifier simplifier)
			{
			}

			// Token: 0x06004F53 RID: 20307 RVA: 0x00019650 File Offset: 0x00017850
			[Token(Token = "0x6007849")]
			[Address(RVA = "0x20FFF80", Offset = "0x2100081", VA = "0x20FFF80")]
			public bool HasVertex(Simplifier.Vertex v)
			{
				return default(bool);
			}

			// Token: 0x06004F54 RID: 20308 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600784A")]
			[Address(RVA = "0x2105F20", Offset = "0x2106021", VA = "0x2105F20")]
			public void ComputeNormal()
			{
			}

			// Token: 0x06004F55 RID: 20309 RVA: 0x00019668 File Offset: 0x00017868
			[Token(Token = "0x600784B")]
			[Address(RVA = "0x2100110", Offset = "0x2100211", VA = "0x2100110")]
			public int TexAt(Simplifier.Vertex vertex)
			{
				return 0;
			}

			// Token: 0x06004F56 RID: 20310 RVA: 0x00019680 File Offset: 0x00017880
			[Token(Token = "0x600784C")]
			[Address(RVA = "0x21061A0", Offset = "0x21062A1", VA = "0x21061A0")]
			public int TexAt(int i)
			{
				return 0;
			}

			// Token: 0x06004F57 RID: 20311 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600784D")]
			[Address(RVA = "0x2100D50", Offset = "0x2100E51", VA = "0x2100D50")]
			public void SetTexAt(Simplifier.Vertex vertex, int uv)
			{
			}

			// Token: 0x06004F58 RID: 20312 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600784E")]
			[Address(RVA = "0x21061E0", Offset = "0x21062E1", VA = "0x21061E0")]
			public void SetTexAt(int i, int uv)
			{
			}

			// Token: 0x06004F59 RID: 20313 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600784F")]
			[Address(RVA = "0x21010D0", Offset = "0x21011D1", VA = "0x21010D0")]
			public void ReplaceVertex(Simplifier.Vertex vold, Simplifier.Vertex vnew)
			{
			}

			// Token: 0x0400B002 RID: 45058
			[Token(Token = "0x401B800")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Simplifier.Vertex[] m_aVertices;

			// Token: 0x0400B003 RID: 45059
			[Token(Token = "0x401B801")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private bool m_bUVData;

			// Token: 0x0400B004 RID: 45060
			[Token(Token = "0x401B802")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int[] m_aUV;

			// Token: 0x0400B005 RID: 45061
			[Token(Token = "0x401B803")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int[] m_aIndices;

			// Token: 0x0400B006 RID: 45062
			[Token(Token = "0x401B804")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 m_v3Normal;

			// Token: 0x0400B007 RID: 45063
			[Token(Token = "0x401B805")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int m_nSubMesh;
		}

		// Token: 0x02000C32 RID: 3122
		[Token(Token = "0x20013B2")]
		private class TriangleList
		{
			// Token: 0x06004F5A RID: 20314 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007850")]
			[Address(RVA = "0x2103D70", Offset = "0x2103E71", VA = "0x2103D70")]
			public TriangleList()
			{
			}

			// Token: 0x0400B008 RID: 45064
			[Token(Token = "0x401B806")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<Simplifier.Triangle> m_listTriangles;
		}

		// Token: 0x02000C33 RID: 3123
		[Token(Token = "0x20013B3")]
		private class Vertex
		{
			// Token: 0x06004F5B RID: 20315 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007851")]
			[Address(RVA = "0x2101AC0", Offset = "0x2101BC1", VA = "0x2101AC0")]
			public Vertex(Simplifier simplifier, Vector3 v, Vector3 v3World, bool bHasBoneWeight, BoneWeight boneWeight, int nID)
			{
			}

			// Token: 0x06004F5C RID: 20316 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007852")]
			[Address(RVA = "0x2100C70", Offset = "0x2100D71", VA = "0x2100C70")]
			public void Destructor(Simplifier simplifier)
			{
			}

			// Token: 0x06004F5D RID: 20317 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007853")]
			[Address(RVA = "0x21060B0", Offset = "0x21061B1", VA = "0x21060B0")]
			public void RemoveIfNonNeighbor(Simplifier.Vertex n)
			{
			}

			// Token: 0x06004F5E RID: 20318 RVA: 0x00019698 File Offset: 0x00017898
			[Token(Token = "0x6007854")]
			[Address(RVA = "0x2100000", Offset = "0x2100101", VA = "0x2100000")]
			public bool IsBorder()
			{
				return default(bool);
			}

			// Token: 0x0400B009 RID: 45065
			[Token(Token = "0x401B807")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 m_v3Position;

			// Token: 0x0400B00A RID: 45066
			[Token(Token = "0x401B808")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 m_v3PositionWorld;

			// Token: 0x0400B00B RID: 45067
			[Token(Token = "0x401B809")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool m_bHasBoneWeight;

			// Token: 0x0400B00C RID: 45068
			[Token(Token = "0x401B80A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public BoneWeight m_boneWeight;

			// Token: 0x0400B00D RID: 45069
			[Token(Token = "0x401B80B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public int m_nID;

			// Token: 0x0400B00E RID: 45070
			[Token(Token = "0x401B80C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public List<Simplifier.Vertex> m_listNeighbors;

			// Token: 0x0400B00F RID: 45071
			[Token(Token = "0x401B80D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public List<Simplifier.Triangle> m_listFaces;

			// Token: 0x0400B010 RID: 45072
			[Token(Token = "0x401B80E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public float m_fObjDist;

			// Token: 0x0400B011 RID: 45073
			[Token(Token = "0x401B80F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Simplifier.Vertex m_collapse;

			// Token: 0x0400B012 RID: 45074
			[Token(Token = "0x401B810")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public int m_nHeapSpot;
		}

		// Token: 0x02000C34 RID: 3124
		[Token(Token = "0x20013B4")]
		private class VertexDataHashComparer : IEqualityComparer<Simplifier.VertexDataHash>
		{
			// Token: 0x06004F5F RID: 20319 RVA: 0x000196B0 File Offset: 0x000178B0
			[Token(Token = "0x6007855")]
			[Address(RVA = "0x21064A0", Offset = "0x21065A1", VA = "0x21064A0", Slot = "4")]
			public bool Equals(Simplifier.VertexDataHash a, Simplifier.VertexDataHash b)
			{
				return default(bool);
			}

			// Token: 0x06004F60 RID: 20320 RVA: 0x000196C8 File Offset: 0x000178C8
			[Token(Token = "0x6007856")]
			[Address(RVA = "0x2106630", Offset = "0x2106731", VA = "0x2106630", Slot = "5")]
			public int GetHashCode(Simplifier.VertexDataHash vdata)
			{
				return 0;
			}

			// Token: 0x06004F61 RID: 20321 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007857")]
			[Address(RVA = "0x2105030", Offset = "0x2105131", VA = "0x2105030")]
			public VertexDataHashComparer()
			{
			}
		}

		// Token: 0x02000C35 RID: 3125
		[Token(Token = "0x20013B5")]
		private class VertexDataHash
		{
			// Token: 0x17000A31 RID: 2609
			// (get) Token: 0x06004F62 RID: 20322 RVA: 0x000196E0 File Offset: 0x000178E0
			[Token(Token = "0x17000DE2")]
			public Vector3 Vertex
			{
				[Token(Token = "0x6007858")]
				[Address(RVA = "0x2106220", Offset = "0x2106321", VA = "0x2106220")]
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x17000A32 RID: 2610
			// (get) Token: 0x06004F63 RID: 20323 RVA: 0x000196F8 File Offset: 0x000178F8
			[Token(Token = "0x17000DE3")]
			public Vector3 Normal
			{
				[Token(Token = "0x6007859")]
				[Address(RVA = "0x2106230", Offset = "0x2106331", VA = "0x2106230")]
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x17000A33 RID: 2611
			// (get) Token: 0x06004F64 RID: 20324 RVA: 0x00019710 File Offset: 0x00017910
			[Token(Token = "0x17000DE4")]
			public Vector2 UV1
			{
				[Token(Token = "0x600785A")]
				[Address(RVA = "0x2106240", Offset = "0x2106341", VA = "0x2106240")]
				get
				{
					return default(Vector2);
				}
			}

			// Token: 0x17000A34 RID: 2612
			// (get) Token: 0x06004F65 RID: 20325 RVA: 0x00019728 File Offset: 0x00017928
			[Token(Token = "0x17000DE5")]
			public Vector2 UV2
			{
				[Token(Token = "0x600785B")]
				[Address(RVA = "0x2106250", Offset = "0x2106351", VA = "0x2106250")]
				get
				{
					return default(Vector2);
				}
			}

			// Token: 0x17000A35 RID: 2613
			// (get) Token: 0x06004F66 RID: 20326 RVA: 0x00019740 File Offset: 0x00017940
			[Token(Token = "0x17000DE6")]
			public Color32 Color
			{
				[Token(Token = "0x600785C")]
				[Address(RVA = "0x2106260", Offset = "0x2106361", VA = "0x2106260")]
				get
				{
					return default(Color32);
				}
			}

			// Token: 0x06004F67 RID: 20327 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600785D")]
			[Address(RVA = "0x2105040", Offset = "0x2105141", VA = "0x2105040")]
			public VertexDataHash(Vector3 v3Vertex, Vector3 v3Normal, Vector2 v2Mapping1, Vector2 v2Mapping2, Color32 color)
			{
			}

			// Token: 0x06004F68 RID: 20328 RVA: 0x00019758 File Offset: 0x00017958
			[Token(Token = "0x600785E")]
			[Address(RVA = "0x2106270", Offset = "0x2106371", VA = "0x2106270", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			// Token: 0x06004F69 RID: 20329 RVA: 0x00019770 File Offset: 0x00017970
			[Token(Token = "0x600785F")]
			[Address(RVA = "0x2106430", Offset = "0x2106531", VA = "0x2106430", Slot = "2")]
			public override int GetHashCode()
			{
				return 0;
			}

			// Token: 0x06004F6A RID: 20330 RVA: 0x00019788 File Offset: 0x00017988
			[Token(Token = "0x6007860")]
			[Address(RVA = "0x2106450", Offset = "0x2106551", VA = "0x2106450")]
			public static bool operator ==(Simplifier.VertexDataHash a, Simplifier.VertexDataHash b)
			{
				return default(bool);
			}

			// Token: 0x06004F6B RID: 20331 RVA: 0x000197A0 File Offset: 0x000179A0
			[Token(Token = "0x6007861")]
			[Address(RVA = "0x2106470", Offset = "0x2106571", VA = "0x2106470")]
			public static bool operator !=(Simplifier.VertexDataHash a, Simplifier.VertexDataHash b)
			{
				return default(bool);
			}

			// Token: 0x0400B013 RID: 45075
			[Token(Token = "0x401B811")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Vector3 _v3Vertex;

			// Token: 0x0400B014 RID: 45076
			[Token(Token = "0x401B812")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Vector3 _v3Normal;

			// Token: 0x0400B015 RID: 45077
			[Token(Token = "0x401B813")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector2 _v2Mapping1;

			// Token: 0x0400B016 RID: 45078
			[Token(Token = "0x401B814")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector2 _v2Mapping2;

			// Token: 0x0400B017 RID: 45079
			[Token(Token = "0x401B815")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Color32 _color;

			// Token: 0x0400B018 RID: 45080
			[Token(Token = "0x401B816")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private MeshUniqueVertices.UniqueVertex _uniqueVertex;
		}

		// Token: 0x02000C36 RID: 3126
		[Token(Token = "0x20013B6")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1596B0", Offset = "0x1597B1")]
		private sealed class <ProgressiveMesh>d__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06004F6C RID: 20332 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007862")]
			[Address(RVA = "0x20FED20", Offset = "0x20FEE21", VA = "0x20FED20")]
			[DebuggerHidden]
			public <ProgressiveMesh>d__24(int <>1__state)
			{
			}

			// Token: 0x06004F6D RID: 20333 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007863")]
			[Address(RVA = "0x21051D0", Offset = "0x21052D1", VA = "0x21051D0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06004F6E RID: 20334 RVA: 0x000197B8 File Offset: 0x000179B8
			[Token(Token = "0x6007864")]
			[Address(RVA = "0x21051E0", Offset = "0x21052E1", VA = "0x21051E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000A36 RID: 2614
			// (get) Token: 0x06004F6F RID: 20335 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000DE7")]
			private object Current
			{
				[Token(Token = "0x6007865")]
				[Address(RVA = "0x2105D80", Offset = "0x2105E81", VA = "0x2105D80", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06004F70 RID: 20336 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007866")]
			[Address(RVA = "0x2105D90", Offset = "0x2105E91", VA = "0x2105D90", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000A37 RID: 2615
			// (get) Token: 0x06004F71 RID: 20337 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000DE8")]
			private object Current
			{
				[Token(Token = "0x6007867")]
				[Address(RVA = "0x2105DF0", Offset = "0x2105EF1", VA = "0x2105DF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400B019 RID: 45081
			[Token(Token = "0x401B817")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400B01A RID: 45082
			[Token(Token = "0x401B818")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400B01B RID: 45083
			[Token(Token = "0x401B819")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Simplifier <>4__this;

			// Token: 0x0400B01C RID: 45084
			[Token(Token = "0x401B81A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Mesh sourceMesh;

			// Token: 0x0400B01D RID: 45085
			[Token(Token = "0x401B81B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GameObject gameObject;

			// Token: 0x0400B01E RID: 45086
			[Token(Token = "0x401B81C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Simplifier.ProgressDelegate progress;

			// Token: 0x0400B01F RID: 45087
			[Token(Token = "0x401B81D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string strProgressDisplayObjectName;

			// Token: 0x0400B020 RID: 45088
			[Token(Token = "0x401B81E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public RelevanceSphere[] aRelevanceSpheres;

			// Token: 0x0400B021 RID: 45089
			[Token(Token = "0x401B81F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private int <nVertices>5__2;
		}

		// Token: 0x02000C37 RID: 3127
		[Token(Token = "0x20013B7")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1596C0", Offset = "0x1597C1")]
		private sealed class <ComputeMeshWithVertexCount>d__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06004F72 RID: 20338 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007868")]
			[Address(RVA = "0x20FEE40", Offset = "0x20FEF41", VA = "0x20FEE40")]
			[DebuggerHidden]
			public <ComputeMeshWithVertexCount>d__25(int <>1__state)
			{
			}

			// Token: 0x06004F73 RID: 20339 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007869")]
			[Address(RVA = "0x21030A0", Offset = "0x21031A1", VA = "0x21030A0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06004F74 RID: 20340 RVA: 0x000197D0 File Offset: 0x000179D0
			[Token(Token = "0x600786A")]
			[Address(RVA = "0x21030B0", Offset = "0x21031B1", VA = "0x21030B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000A38 RID: 2616
			// (get) Token: 0x06004F75 RID: 20341 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000DE9")]
			private object Current
			{
				[Token(Token = "0x600786B")]
				[Address(RVA = "0x2103DF0", Offset = "0x2103EF1", VA = "0x2103DF0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06004F76 RID: 20342 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600786C")]
			[Address(RVA = "0x2103E00", Offset = "0x2103F01", VA = "0x2103E00", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000A39 RID: 2617
			// (get) Token: 0x06004F77 RID: 20343 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000DEA")]
			private object Current
			{
				[Token(Token = "0x600786D")]
				[Address(RVA = "0x2103E60", Offset = "0x2103F61", VA = "0x2103E60", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400B022 RID: 45090
			[Token(Token = "0x401B820")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400B023 RID: 45091
			[Token(Token = "0x401B821")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400B024 RID: 45092
			[Token(Token = "0x401B822")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Simplifier <>4__this;

			// Token: 0x0400B025 RID: 45093
			[Token(Token = "0x401B823")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int nVertices;

			// Token: 0x0400B026 RID: 45094
			[Token(Token = "0x401B824")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Mesh meshOut;

			// Token: 0x0400B027 RID: 45095
			[Token(Token = "0x401B825")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public GameObject gameObject;

			// Token: 0x0400B028 RID: 45096
			[Token(Token = "0x401B826")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Simplifier.ProgressDelegate progress;

			// Token: 0x0400B029 RID: 45097
			[Token(Token = "0x401B827")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string strProgressDisplayObjectName;

			// Token: 0x0400B02A RID: 45098
			[Token(Token = "0x401B828")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private List<Simplifier.Vertex> <listVertices>5__2;

			// Token: 0x0400B02B RID: 45099
			[Token(Token = "0x401B829")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private int <nTotalVertices>5__3;
		}

		// Token: 0x02000C38 RID: 3128
		[Token(Token = "0x20013B8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1596D0", Offset = "0x1597D1")]
		private sealed class <ConsolidateMesh>d__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06004F78 RID: 20344 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600786E")]
			[Address(RVA = "0x20FF960", Offset = "0x20FFA61", VA = "0x20FF960")]
			[DebuggerHidden]
			public <ConsolidateMesh>d__29(int <>1__state)
			{
			}

			// Token: 0x06004F79 RID: 20345 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600786F")]
			[Address(RVA = "0x2103E70", Offset = "0x2103F71", VA = "0x2103E70", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06004F7A RID: 20346 RVA: 0x000197E8 File Offset: 0x000179E8
			[Token(Token = "0x6007870")]
			[Address(RVA = "0x2103E80", Offset = "0x2103F81", VA = "0x2103E80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000A3A RID: 2618
			// (get) Token: 0x06004F7B RID: 20347 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000DEB")]
			private object Current
			{
				[Token(Token = "0x6007871")]
				[Address(RVA = "0x2105150", Offset = "0x2105251", VA = "0x2105150", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06004F7C RID: 20348 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007872")]
			[Address(RVA = "0x2105160", Offset = "0x2105261", VA = "0x2105160", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000A3B RID: 2619
			// (get) Token: 0x06004F7D RID: 20349 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000DEC")]
			private object Current
			{
				[Token(Token = "0x6007873")]
				[Address(RVA = "0x21051C0", Offset = "0x21052C1", VA = "0x21051C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400B02C RID: 45100
			[Token(Token = "0x401B82A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400B02D RID: 45101
			[Token(Token = "0x401B82B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400B02E RID: 45102
			[Token(Token = "0x401B82C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Mesh meshIn;

			// Token: 0x0400B02F RID: 45103
			[Token(Token = "0x401B82D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Simplifier.TriangleList[] aListTriangles;

			// Token: 0x0400B030 RID: 45104
			[Token(Token = "0x401B82E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Simplifier.ProgressDelegate progress;

			// Token: 0x0400B031 RID: 45105
			[Token(Token = "0x401B82F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string strProgressDisplayObjectName;

			// Token: 0x0400B032 RID: 45106
			[Token(Token = "0x401B830")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Mesh meshOut;

			// Token: 0x0400B033 RID: 45107
			[Token(Token = "0x401B831")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public GameObject gameObject;

			// Token: 0x0400B034 RID: 45108
			[Token(Token = "0x401B832")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private Vector3[] <av3NormalsIn>5__2;

			// Token: 0x0400B035 RID: 45109
			[Token(Token = "0x401B833")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Vector4[] <av4TangentsIn>5__3;

			// Token: 0x0400B036 RID: 45110
			[Token(Token = "0x401B834")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Vector2[] <av2Mapping1In>5__4;

			// Token: 0x0400B037 RID: 45111
			[Token(Token = "0x401B835")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private Vector2[] <av2Mapping2In>5__5;

			// Token: 0x0400B038 RID: 45112
			[Token(Token = "0x401B836")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private Color[] <acolColorsIn>5__6;

			// Token: 0x0400B039 RID: 45113
			[Token(Token = "0x401B837")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private Color32[] <aColors32In>5__7;

			// Token: 0x0400B03A RID: 45114
			[Token(Token = "0x401B838")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private List<List<int>> <listlistIndicesOut>5__8;

			// Token: 0x0400B03B RID: 45115
			[Token(Token = "0x401B839")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private List<Vector3> <listVerticesOut>5__9;

			// Token: 0x0400B03C RID: 45116
			[Token(Token = "0x401B83A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private List<Vector3> <listNormalsOut>5__10;

			// Token: 0x0400B03D RID: 45117
			[Token(Token = "0x401B83B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private List<Vector4> <listTangentsOut>5__11;

			// Token: 0x0400B03E RID: 45118
			[Token(Token = "0x401B83C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private List<Vector2> <listMapping1Out>5__12;

			// Token: 0x0400B03F RID: 45119
			[Token(Token = "0x401B83D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private List<Vector2> <listMapping2Out>5__13;

			// Token: 0x0400B040 RID: 45120
			[Token(Token = "0x401B83E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private List<Color32> <listColors32Out>5__14;

			// Token: 0x0400B041 RID: 45121
			[Token(Token = "0x401B83F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private List<BoneWeight> <listBoneWeightsOut>5__15;

			// Token: 0x0400B042 RID: 45122
			[Token(Token = "0x401B840")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Dictionary<Simplifier.VertexDataHash, int> <dicVertexDataHash2Index>5__16;

			// Token: 0x0400B043 RID: 45123
			[Token(Token = "0x401B841")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private bool <bUV1>5__17;

			// Token: 0x0400B044 RID: 45124
			[Token(Token = "0x401B842")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
			private bool <bUV2>5__18;

			// Token: 0x0400B045 RID: 45125
			[Token(Token = "0x401B843")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCA")]
			private bool <bNormal>5__19;

			// Token: 0x0400B046 RID: 45126
			[Token(Token = "0x401B844")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCB")]
			private bool <bTangent>5__20;

			// Token: 0x0400B047 RID: 45127
			[Token(Token = "0x401B845")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int <nSubMesh>5__21;

			// Token: 0x0400B048 RID: 45128
			[Token(Token = "0x401B846")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			private List<int> <listIndicesOut>5__22;

			// Token: 0x0400B049 RID: 45129
			[Token(Token = "0x401B847")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			private string <strMesh>5__23;

			// Token: 0x0400B04A RID: 45130
			[Token(Token = "0x401B848")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			private int <i>5__24;
		}

		// Token: 0x02000C39 RID: 3129
		[Token(Token = "0x20013B9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1596E0", Offset = "0x1597E1")]
		private sealed class <ComputeAllEdgeCollapseCosts>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06004F7E RID: 20350 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007874")]
			[Address(RVA = "0x2100690", Offset = "0x2100791", VA = "0x2100690")]
			[DebuggerHidden]
			public <ComputeAllEdgeCollapseCosts>d__33(int <>1__state)
			{
			}

			// Token: 0x06004F7F RID: 20351 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007875")]
			[Address(RVA = "0x2102780", Offset = "0x2102881", VA = "0x2102780", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06004F80 RID: 20352 RVA: 0x00019800 File Offset: 0x00017A00
			[Token(Token = "0x6007876")]
			[Address(RVA = "0x2102790", Offset = "0x2102891", VA = "0x2102790", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000A3C RID: 2620
			// (get) Token: 0x06004F81 RID: 20353 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000DED")]
			private object Current
			{
				[Token(Token = "0x6007877")]
				[Address(RVA = "0x2103020", Offset = "0x2103121", VA = "0x2103020", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06004F82 RID: 20354 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007878")]
			[Address(RVA = "0x2103030", Offset = "0x2103131", VA = "0x2103030", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000A3D RID: 2621
			// (get) Token: 0x06004F83 RID: 20355 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000DEE")]
			private object Current
			{
				[Token(Token = "0x6007879")]
				[Address(RVA = "0x2103090", Offset = "0x2103191", VA = "0x2103090", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400B04B RID: 45131
			[Token(Token = "0x401B849")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400B04C RID: 45132
			[Token(Token = "0x401B84A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400B04D RID: 45133
			[Token(Token = "0x401B84B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Simplifier.ProgressDelegate progress;

			// Token: 0x0400B04E RID: 45134
			[Token(Token = "0x401B84C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string strProgressDisplayObjectName;

			// Token: 0x0400B04F RID: 45135
			[Token(Token = "0x401B84D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Simplifier <>4__this;

			// Token: 0x0400B050 RID: 45136
			[Token(Token = "0x401B84E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform transform;

			// Token: 0x0400B051 RID: 45137
			[Token(Token = "0x401B84F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public RelevanceSphere[] aRelevanceSpheres;

			// Token: 0x0400B052 RID: 45138
			[Token(Token = "0x401B850")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private int <i>5__2;
		}
	}
}
