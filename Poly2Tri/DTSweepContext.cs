using System;
using Il2CppDummyDll;

namespace Poly2Tri
{
	// Token: 0x02000C5E RID: 3166
	[Token(Token = "0x200080F")]
	public class DTSweepContext : TriangulationContext
	{
		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x06005068 RID: 20584 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005069 RID: 20585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000810")]
		public TriangulationPoint Head
		{
			[Token(Token = "0x6004299")]
			[Address(RVA = "0x24AC470", Offset = "0x24AC571", VA = "0x24AC470")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9260", Offset = "0x1A9361")]
			get
			{
				return null;
			}
			[Token(Token = "0x600429A")]
			[Address(RVA = "0x24AC480", Offset = "0x24AC581", VA = "0x24AC480")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9270", Offset = "0x1A9371")]
			set
			{
			}
		}

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x0600506A RID: 20586 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600506B RID: 20587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000811")]
		public TriangulationPoint Tail
		{
			[Token(Token = "0x600429B")]
			[Address(RVA = "0x24AC490", Offset = "0x24AC591", VA = "0x24AC490")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9280", Offset = "0x1A9381")]
			get
			{
				return null;
			}
			[Token(Token = "0x600429C")]
			[Address(RVA = "0x24AC4A0", Offset = "0x24AC5A1", VA = "0x24AC4A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9290", Offset = "0x1A9391")]
			set
			{
			}
		}

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x0600506C RID: 20588 RVA: 0x00019E60 File Offset: 0x00018060
		[Token(Token = "0x17000812")]
		public override TriangulationAlgorithm Algorithm
		{
			[Token(Token = "0x600429D")]
			[Address(RVA = "0x24AC4B0", Offset = "0x24AC5B1", VA = "0x24AC4B0", Slot = "4")]
			get
			{
				return TriangulationAlgorithm.DTSweep;
			}
		}

		// Token: 0x0600506D RID: 20589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600429E")]
		[Address(RVA = "0x24AC4C0", Offset = "0x24AC5C1", VA = "0x24AC4C0")]
		public DTSweepContext()
		{
		}

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x0600506E RID: 20590 RVA: 0x00019E78 File Offset: 0x00018078
		// (set) Token: 0x0600506F RID: 20591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000813")]
		public override bool IsDebugEnabled
		{
			[Token(Token = "0x600429F")]
			[Address(RVA = "0x24AC5D0", Offset = "0x24AC6D1", VA = "0x24AC5D0", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60042A0")]
			[Address(RVA = "0x24AC5E0", Offset = "0x24AC6E1", VA = "0x24AC5E0", Slot = "9")]
			protected set
			{
			}
		}

		// Token: 0x06005070 RID: 20592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042A1")]
		[Address(RVA = "0x24A7C70", Offset = "0x24A7D71", VA = "0x24A7C70")]
		public void RemoveFromList(DelaunayTriangle triangle)
		{
		}

		// Token: 0x06005071 RID: 20593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042A2")]
		[Address(RVA = "0x24A84C0", Offset = "0x24A85C1", VA = "0x24A84C0")]
		public void MeshClean(DelaunayTriangle triangle)
		{
		}

		// Token: 0x06005072 RID: 20594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042A3")]
		[Address(RVA = "0x24AC690", Offset = "0x24AC791", VA = "0x24AC690")]
		private void MeshCleanReq(DelaunayTriangle triangle)
		{
		}

		// Token: 0x06005073 RID: 20595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042A4")]
		[Address(RVA = "0x24AC850", Offset = "0x24AC951", VA = "0x24AC850", Slot = "7")]
		public override void Clear()
		{
		}

		// Token: 0x06005074 RID: 20596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042A5")]
		[Address(RVA = "0x24A88F0", Offset = "0x24A89F1", VA = "0x24A88F0")]
		public void AddNode(AdvancingFrontNode node)
		{
		}

		// Token: 0x06005075 RID: 20597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042A6")]
		[Address(RVA = "0x24ABC30", Offset = "0x24ABD31", VA = "0x24ABC30")]
		public void RemoveNode(AdvancingFrontNode node)
		{
		}

		// Token: 0x06005076 RID: 20598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042A7")]
		[Address(RVA = "0x24A85D0", Offset = "0x24A86D1", VA = "0x24A85D0")]
		public AdvancingFrontNode LocateNode(TriangulationPoint point)
		{
			return null;
		}

		// Token: 0x06005077 RID: 20599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042A8")]
		[Address(RVA = "0x24A5BA0", Offset = "0x24A5CA1", VA = "0x24A5BA0")]
		public void CreateAdvancingFront()
		{
		}

		// Token: 0x06005078 RID: 20600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042A9")]
		[Address(RVA = "0x24A7AE0", Offset = "0x24A7BE1", VA = "0x24A7AE0")]
		public void MapTriangleToNodes(DelaunayTriangle t)
		{
		}

		// Token: 0x06005079 RID: 20601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042AA")]
		[Address(RVA = "0x24AC8C0", Offset = "0x24AC9C1", VA = "0x24AC8C0", Slot = "5")]
		public override void PrepareTriangulation(ITriangulatable t)
		{
		}

		// Token: 0x0600507A RID: 20602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042AB")]
		[Address(RVA = "0x24A6B50", Offset = "0x24A6C51", VA = "0x24A6B50")]
		public void FinalizeTriangulation()
		{
		}

		// Token: 0x0600507B RID: 20603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042AC")]
		[Address(RVA = "0x24ACC20", Offset = "0x24ACD21", VA = "0x24ACC20", Slot = "6")]
		public override TriangulationConstraint NewConstraint(TriangulationPoint a, TriangulationPoint b)
		{
			return null;
		}

		// Token: 0x0400B0E3 RID: 45283
		[Token(Token = "0x40084A3")]
		[FieldOffset(Offset = "0x40")]
		private readonly float ALPHA;

		// Token: 0x0400B0E4 RID: 45284
		[Token(Token = "0x40084A4")]
		[FieldOffset(Offset = "0x48")]
		public AdvancingFront Front;

		// Token: 0x0400B0E5 RID: 45285
		[Token(Token = "0x40084A5")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1771A0", Offset = "0x1772A1")]
		private TriangulationPoint <Head>k__BackingField;

		// Token: 0x0400B0E6 RID: 45286
		[Token(Token = "0x40084A6")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1771B0", Offset = "0x1772B1")]
		private TriangulationPoint <Tail>k__BackingField;

		// Token: 0x0400B0E7 RID: 45287
		[Token(Token = "0x40084A7")]
		[FieldOffset(Offset = "0x60")]
		public DTSweepBasin Basin;

		// Token: 0x0400B0E8 RID: 45288
		[Token(Token = "0x40084A8")]
		[FieldOffset(Offset = "0x68")]
		public DTSweepEdgeEvent EdgeEvent;

		// Token: 0x0400B0E9 RID: 45289
		[Token(Token = "0x40084A9")]
		[FieldOffset(Offset = "0x70")]
		private DTSweepPointComparator _comparator;
	}
}
