using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Poly2Tri
{
	// Token: 0x02000C58 RID: 3160
	[Token(Token = "0x2000809")]
	public class DelaunayTriangle
	{
		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x06005009 RID: 20489 RVA: 0x00019BF0 File Offset: 0x00017DF0
		[Token(Token = "0x1700080C")]
		public FixedBitArray3 EdgeIsConstrained
		{
			[Token(Token = "0x600423A")]
			[Address(RVA = "0x24AD080", Offset = "0x24AD181", VA = "0x24AD080")]
			get
			{
				return default(FixedBitArray3);
			}
		}

		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x0600500A RID: 20490 RVA: 0x00019C08 File Offset: 0x00017E08
		// (set) Token: 0x0600500B RID: 20491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700080D")]
		public bool IsInterior
		{
			[Token(Token = "0x600423B")]
			[Address(RVA = "0x24AD090", Offset = "0x24AD191", VA = "0x24AD090")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9240", Offset = "0x1A9341")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600423C")]
			[Address(RVA = "0x24AD0A0", Offset = "0x24AD1A1", VA = "0x24AD0A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9250", Offset = "0x1A9351")]
			set
			{
			}
		}

		// Token: 0x0600500C RID: 20492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600423D")]
		[Address(RVA = "0x24A8A20", Offset = "0x24A8B21", VA = "0x24A8A20")]
		public DelaunayTriangle(TriangulationPoint p1, TriangulationPoint p2, TriangulationPoint p3)
		{
		}

		// Token: 0x0600500D RID: 20493 RVA: 0x00019C20 File Offset: 0x00017E20
		[Token(Token = "0x600423E")]
		[Address(RVA = "0x24ABC50", Offset = "0x24ABD51", VA = "0x24ABC50")]
		public int IndexOf(TriangulationPoint p)
		{
			return 0;
		}

		// Token: 0x0600500E RID: 20494 RVA: 0x00019C38 File Offset: 0x00017E38
		[Token(Token = "0x600423F")]
		[Address(RVA = "0x24AD0B0", Offset = "0x24AD1B1", VA = "0x24AD0B0")]
		public int IndexCWFrom(TriangulationPoint p)
		{
			return 0;
		}

		// Token: 0x0600500F RID: 20495 RVA: 0x00019C50 File Offset: 0x00017E50
		[Token(Token = "0x6004240")]
		[Address(RVA = "0x24AD180", Offset = "0x24AD281", VA = "0x24AD180")]
		public int IndexCCWFrom(TriangulationPoint p)
		{
			return 0;
		}

		// Token: 0x06005010 RID: 20496 RVA: 0x00019C68 File Offset: 0x00017E68
		[Token(Token = "0x6004241")]
		[Address(RVA = "0x24A7600", Offset = "0x24A7701", VA = "0x24A7600")]
		public bool Contains(TriangulationPoint p)
		{
			return default(bool);
		}

		// Token: 0x06005011 RID: 20497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004242")]
		[Address(RVA = "0x24AD250", Offset = "0x24AD351", VA = "0x24AD250")]
		private void MarkNeighbor(TriangulationPoint p1, TriangulationPoint p2, DelaunayTriangle t)
		{
		}

		// Token: 0x06005012 RID: 20498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004243")]
		[Address(RVA = "0x24A8AD0", Offset = "0x24A8BD1", VA = "0x24A8AD0")]
		public void MarkNeighbor(DelaunayTriangle t)
		{
		}

		// Token: 0x06005013 RID: 20499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004244")]
		[Address(RVA = "0x24AD3C0", Offset = "0x24AD4C1", VA = "0x24AD3C0")]
		public void ClearNeighbors()
		{
		}

		// Token: 0x06005014 RID: 20500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004245")]
		[Address(RVA = "0x24AD450", Offset = "0x24AD551", VA = "0x24AD450")]
		public void ClearNeighbor(DelaunayTriangle triangle)
		{
		}

		// Token: 0x06005015 RID: 20501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004246")]
		[Address(RVA = "0x24A7E90", Offset = "0x24A7F91", VA = "0x24A7E90")]
		public void Clear()
		{
		}

		// Token: 0x06005016 RID: 20502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004247")]
		[Address(RVA = "0x24A76E0", Offset = "0x24A77E1", VA = "0x24A76E0")]
		public TriangulationPoint OppositePoint(DelaunayTriangle t, TriangulationPoint p)
		{
			return null;
		}

		// Token: 0x06005017 RID: 20503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004248")]
		[Address(RVA = "0x24A8100", Offset = "0x24A8201", VA = "0x24A8100")]
		public DelaunayTriangle NeighborCWFrom(TriangulationPoint point)
		{
			return null;
		}

		// Token: 0x06005018 RID: 20504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004249")]
		[Address(RVA = "0x24A7DF0", Offset = "0x24A7EF1", VA = "0x24A7DF0")]
		public DelaunayTriangle NeighborCCWFrom(TriangulationPoint point)
		{
			return null;
		}

		// Token: 0x06005019 RID: 20505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600424A")]
		[Address(RVA = "0x24A7660", Offset = "0x24A7761", VA = "0x24A7660")]
		public DelaunayTriangle NeighborAcrossFrom(TriangulationPoint point)
		{
			return null;
		}

		// Token: 0x0600501A RID: 20506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600424B")]
		[Address(RVA = "0x24A7CE0", Offset = "0x24A7DE1", VA = "0x24A7CE0")]
		public TriangulationPoint PointCCWFrom(TriangulationPoint point)
		{
			return null;
		}

		// Token: 0x0600501B RID: 20507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600424C")]
		[Address(RVA = "0x24A7FF0", Offset = "0x24A80F1", VA = "0x24A7FF0")]
		public TriangulationPoint PointCWFrom(TriangulationPoint point)
		{
			return null;
		}

		// Token: 0x0600501C RID: 20508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600424D")]
		[Address(RVA = "0x24AD550", Offset = "0x24AD651", VA = "0x24AD550")]
		private void RotateCW()
		{
		}

		// Token: 0x0600501D RID: 20509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600424E")]
		[Address(RVA = "0x24ABF80", Offset = "0x24AC081", VA = "0x24ABF80")]
		public void Legalize(TriangulationPoint oPoint, TriangulationPoint nPoint)
		{
		}

		// Token: 0x0600501E RID: 20510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600424F")]
		[Address(RVA = "0x24AD620", Offset = "0x24AD721", VA = "0x24AD620", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600501F RID: 20511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004250")]
		[Address(RVA = "0x24AD830", Offset = "0x24AD931", VA = "0x24AD830")]
		public void MarkNeighborEdges()
		{
		}

		// Token: 0x06005020 RID: 20512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004251")]
		[Address(RVA = "0x24ADCB0", Offset = "0x24ADDB1", VA = "0x24ADCB0")]
		public void MarkEdge(DelaunayTriangle triangle)
		{
		}

		// Token: 0x06005021 RID: 20513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004252")]
		[Address(RVA = "0x24AE130", Offset = "0x24AE231", VA = "0x24AE130")]
		public void MarkEdge(List<DelaunayTriangle> tList)
		{
		}

		// Token: 0x06005022 RID: 20514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004253")]
		[Address(RVA = "0x24A73F0", Offset = "0x24A74F1", VA = "0x24A73F0")]
		public void MarkConstrainedEdge(int index)
		{
		}

		// Token: 0x06005023 RID: 20515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004254")]
		[Address(RVA = "0x24AE5E0", Offset = "0x24AE6E1", VA = "0x24AE5E0")]
		public void MarkConstrainedEdge(DTSweepConstraint edge)
		{
		}

		// Token: 0x06005024 RID: 20516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004255")]
		[Address(RVA = "0x24AA840", Offset = "0x24AA941", VA = "0x24AA840")]
		public void MarkConstrainedEdge(TriangulationPoint p, TriangulationPoint q)
		{
		}

		// Token: 0x06005025 RID: 20517 RVA: 0x00019C80 File Offset: 0x00017E80
		[Token(Token = "0x6004256")]
		[Address(RVA = "0x24AE720", Offset = "0x24AE821", VA = "0x24AE720")]
		public double Area()
		{
			return 0.0;
		}

		// Token: 0x06005026 RID: 20518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004257")]
		[Address(RVA = "0x24AE850", Offset = "0x24AE951", VA = "0x24AE850")]
		public TriangulationPoint Centroid()
		{
			return null;
		}

		// Token: 0x06005027 RID: 20519 RVA: 0x00019C98 File Offset: 0x00017E98
		[Token(Token = "0x6004258")]
		[Address(RVA = "0x24AA730", Offset = "0x24AA831", VA = "0x24AA730")]
		public int EdgeIndex(TriangulationPoint p1, TriangulationPoint p2)
		{
			return 0;
		}

		// Token: 0x06005028 RID: 20520 RVA: 0x00019CB0 File Offset: 0x00017EB0
		[Token(Token = "0x6004259")]
		[Address(RVA = "0x24A7220", Offset = "0x24A7321", VA = "0x24A7220")]
		public bool GetConstrainedEdgeCCW(TriangulationPoint p)
		{
			return default(bool);
		}

		// Token: 0x06005029 RID: 20521 RVA: 0x00019CC8 File Offset: 0x00017EC8
		[Token(Token = "0x600425A")]
		[Address(RVA = "0x24A83D0", Offset = "0x24A84D1", VA = "0x24A83D0")]
		public bool GetConstrainedEdgeCW(TriangulationPoint p)
		{
			return default(bool);
		}

		// Token: 0x0600502A RID: 20522 RVA: 0x00019CE0 File Offset: 0x00017EE0
		[Token(Token = "0x600425B")]
		[Address(RVA = "0x24AE9D0", Offset = "0x24AEAD1", VA = "0x24AE9D0")]
		public bool GetConstrainedEdgeAcross(TriangulationPoint p)
		{
			return default(bool);
		}

		// Token: 0x0600502B RID: 20523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600425C")]
		[Address(RVA = "0x24AEAA0", Offset = "0x24AEBA1", VA = "0x24AEAA0")]
		protected void SetConstrainedEdge(int idx, bool ce)
		{
		}

		// Token: 0x0600502C RID: 20524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600425D")]
		[Address(RVA = "0x24AC260", Offset = "0x24AC361", VA = "0x24AC260")]
		public void SetConstrainedEdgeCCW(TriangulationPoint p, bool ce)
		{
		}

		// Token: 0x0600502D RID: 20525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600425E")]
		[Address(RVA = "0x24AC340", Offset = "0x24AC441", VA = "0x24AC340")]
		public void SetConstrainedEdgeCW(TriangulationPoint p, bool ce)
		{
		}

		// Token: 0x0600502E RID: 20526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600425F")]
		[Address(RVA = "0x24ABD00", Offset = "0x24ABE01", VA = "0x24ABD00")]
		public void SetConstrainedEdgeAcross(TriangulationPoint p, bool ce)
		{
		}

		// Token: 0x0600502F RID: 20527 RVA: 0x00019CF8 File Offset: 0x00017EF8
		[Token(Token = "0x6004260")]
		[Address(RVA = "0x24ABDC0", Offset = "0x24ABEC1", VA = "0x24ABDC0")]
		public bool GetDelaunayEdgeCCW(TriangulationPoint p)
		{
			return default(bool);
		}

		// Token: 0x06005030 RID: 20528 RVA: 0x00019D10 File Offset: 0x00017F10
		[Token(Token = "0x6004261")]
		[Address(RVA = "0x24ABEA0", Offset = "0x24ABFA1", VA = "0x24ABEA0")]
		public bool GetDelaunayEdgeCW(TriangulationPoint p)
		{
			return default(bool);
		}

		// Token: 0x06005031 RID: 20529 RVA: 0x00019D28 File Offset: 0x00017F28
		[Token(Token = "0x6004262")]
		[Address(RVA = "0x24AEAB0", Offset = "0x24AEBB1", VA = "0x24AEAB0")]
		public bool GetDelaunayEdgeAcross(TriangulationPoint p)
		{
			return default(bool);
		}

		// Token: 0x06005032 RID: 20530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004263")]
		[Address(RVA = "0x24AC0A0", Offset = "0x24AC1A1", VA = "0x24AC0A0")]
		public void SetDelaunayEdgeCCW(TriangulationPoint p, bool ce)
		{
		}

		// Token: 0x06005033 RID: 20531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004264")]
		[Address(RVA = "0x24AC180", Offset = "0x24AC281", VA = "0x24AC180")]
		public void SetDelaunayEdgeCW(TriangulationPoint p, bool ce)
		{
		}

		// Token: 0x06005034 RID: 20532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004265")]
		[Address(RVA = "0x24AEB70", Offset = "0x24AEC71", VA = "0x24AEB70")]
		public void SetDelaunayEdgeAcross(TriangulationPoint p, bool ce)
		{
		}

		// Token: 0x06005035 RID: 20533 RVA: 0x00019D40 File Offset: 0x00017F40
		[Token(Token = "0x6004266")]
		[Address(RVA = "0x24AEC30", Offset = "0x24AED31", VA = "0x24AEC30")]
		public bool GetEdge(int idx, out DTSweepConstraint edge)
		{
			return default(bool);
		}

		// Token: 0x06005036 RID: 20534 RVA: 0x00019D58 File Offset: 0x00017F58
		[Token(Token = "0x6004267")]
		[Address(RVA = "0x24A7310", Offset = "0x24A7411", VA = "0x24A7310")]
		public bool GetEdgeCCW(TriangulationPoint p, out DTSweepConstraint edge)
		{
			return default(bool);
		}

		// Token: 0x06005037 RID: 20535 RVA: 0x00019D70 File Offset: 0x00017F70
		[Token(Token = "0x6004268")]
		[Address(RVA = "0x24AED60", Offset = "0x24AEE61", VA = "0x24AED60")]
		public bool GetEdgeCW(TriangulationPoint p, out DTSweepConstraint edge)
		{
			return default(bool);
		}

		// Token: 0x06005038 RID: 20536 RVA: 0x00019D88 File Offset: 0x00017F88
		[Token(Token = "0x6004269")]
		[Address(RVA = "0x24AEE40", Offset = "0x24AEF41", VA = "0x24AEE40")]
		public bool GetEdgeAcross(TriangulationPoint p, out DTSweepConstraint edge)
		{
			return default(bool);
		}

		// Token: 0x0400B0CF RID: 45263
		[Token(Token = "0x400848F")]
		[FieldOffset(Offset = "0x10")]
		public FixedArray3<TriangulationPoint> Points;

		// Token: 0x0400B0D0 RID: 45264
		[Token(Token = "0x4008490")]
		[FieldOffset(Offset = "0x28")]
		public FixedArray3<DelaunayTriangle> Neighbors;

		// Token: 0x0400B0D1 RID: 45265
		[Token(Token = "0x4008491")]
		[FieldOffset(Offset = "0x40")]
		private FixedBitArray3 mEdgeIsConstrained;

		// Token: 0x0400B0D2 RID: 45266
		[Token(Token = "0x4008492")]
		[FieldOffset(Offset = "0x43")]
		public FixedBitArray3 EdgeIsDelaunay;

		// Token: 0x0400B0D3 RID: 45267
		[Token(Token = "0x4008493")]
		[FieldOffset(Offset = "0x46")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x177190", Offset = "0x177291")]
		private bool <IsInterior>k__BackingField;
	}
}
