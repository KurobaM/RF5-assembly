using System;
using Il2CppDummyDll;

namespace Poly2Tri
{
	// Token: 0x02000C5B RID: 3163
	[Token(Token = "0x200080C")]
	public static class DTSweep
	{
		// Token: 0x06005044 RID: 20548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004275")]
		[Address(RVA = "0x24A5B30", Offset = "0x24A5C31", VA = "0x24A5B30")]
		public static void Triangulate(DTSweepContext tcx)
		{
		}

		// Token: 0x06005045 RID: 20549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004276")]
		[Address(RVA = "0x24A5EC0", Offset = "0x24A5FC1", VA = "0x24A5EC0")]
		private static void Sweep(DTSweepContext tcx)
		{
		}

		// Token: 0x06005046 RID: 20550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004277")]
		[Address(RVA = "0x24A6160", Offset = "0x24A6261", VA = "0x24A6160")]
		private static void FixupConstrainedEdges(DTSweepContext tcx)
		{
		}

		// Token: 0x06005047 RID: 20551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004278")]
		[Address(RVA = "0x24A64E0", Offset = "0x24A65E1", VA = "0x24A64E0")]
		private static void FinalizationConvexHull(DTSweepContext tcx)
		{
		}

		// Token: 0x06005048 RID: 20552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004279")]
		[Address(RVA = "0x24A7400", Offset = "0x24A7501", VA = "0x24A7400")]
		private static void TurnAdvancingFrontConvex(DTSweepContext tcx, AdvancingFrontNode b, AdvancingFrontNode c)
		{
		}

		// Token: 0x06005049 RID: 20553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600427A")]
		[Address(RVA = "0x24A63E0", Offset = "0x24A64E1", VA = "0x24A63E0")]
		private static void FinalizationPolygon(DTSweepContext tcx)
		{
		}

		// Token: 0x0600504A RID: 20554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600427B")]
		[Address(RVA = "0x24A84D0", Offset = "0x24A85D1", VA = "0x24A84D0")]
		private static void FinalizationConstraints(DTSweepContext tcx)
		{
		}

		// Token: 0x0600504B RID: 20555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600427C")]
		[Address(RVA = "0x24A6C30", Offset = "0x24A6D31", VA = "0x24A6C30")]
		private static AdvancingFrontNode PointEvent(DTSweepContext tcx, TriangulationPoint point)
		{
			return null;
		}

		// Token: 0x0600504C RID: 20556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600427D")]
		[Address(RVA = "0x24A8680", Offset = "0x24A8781", VA = "0x24A8680")]
		private static AdvancingFrontNode NewFrontTriangle(DTSweepContext tcx, TriangulationPoint point, AdvancingFrontNode node)
		{
			return null;
		}

		// Token: 0x0600504D RID: 20557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600427E")]
		[Address(RVA = "0x24A6E50", Offset = "0x24A6F51", VA = "0x24A6E50")]
		private static void EdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
		{
		}

		// Token: 0x0600504E RID: 20558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600427F")]
		[Address(RVA = "0x24A95C0", Offset = "0x24A96C1", VA = "0x24A95C0")]
		private static void FillEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
		{
		}

		// Token: 0x0600504F RID: 20559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004280")]
		[Address(RVA = "0x24A9F40", Offset = "0x24AA041", VA = "0x24A9F40")]
		private static void FillRightConcaveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
		{
		}

		// Token: 0x06005050 RID: 20560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004281")]
		[Address(RVA = "0x24AA030", Offset = "0x24AA131", VA = "0x24AA030")]
		private static void FillRightConvexEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
		{
		}

		// Token: 0x06005051 RID: 20561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004282")]
		[Address(RVA = "0x24AA150", Offset = "0x24AA251", VA = "0x24AA150")]
		private static void FillRightBelowEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
		{
		}

		// Token: 0x06005052 RID: 20562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004283")]
		[Address(RVA = "0x24A9BF0", Offset = "0x24A9CF1", VA = "0x24A9BF0")]
		private static void FillRightAboveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
		{
		}

		// Token: 0x06005053 RID: 20563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004284")]
		[Address(RVA = "0x24AA340", Offset = "0x24AA441", VA = "0x24AA340")]
		private static void FillLeftConvexEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
		{
		}

		// Token: 0x06005054 RID: 20564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004285")]
		[Address(RVA = "0x24AA460", Offset = "0x24AA561", VA = "0x24AA460")]
		private static void FillLeftConcaveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
		{
		}

		// Token: 0x06005055 RID: 20565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004286")]
		[Address(RVA = "0x24AA550", Offset = "0x24AA651", VA = "0x24AA550")]
		private static void FillLeftBelowEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
		{
		}

		// Token: 0x06005056 RID: 20566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004287")]
		[Address(RVA = "0x24A9DA0", Offset = "0x24A9EA1", VA = "0x24A9DA0")]
		private static void FillLeftAboveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node)
		{
		}

		// Token: 0x06005057 RID: 20567 RVA: 0x00019DD0 File Offset: 0x00017FD0
		[Token(Token = "0x6004288")]
		[Address(RVA = "0x24A9370", Offset = "0x24A9471", VA = "0x24A9370")]
		private static bool IsEdgeSideOfTriangle(DelaunayTriangle triangle, TriangulationPoint ep, TriangulationPoint eq)
		{
			return default(bool);
		}

		// Token: 0x06005058 RID: 20568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004289")]
		[Address(RVA = "0x24A95F0", Offset = "0x24A96F1", VA = "0x24A95F0")]
		private static void EdgeEvent(DTSweepContext tcx, TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle triangle, TriangulationPoint point)
		{
		}

		// Token: 0x06005059 RID: 20569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600428A")]
		[Address(RVA = "0x24AA960", Offset = "0x24AAA61", VA = "0x24AA960")]
		private static void FlipEdgeEvent(DTSweepContext tcx, TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle t, TriangulationPoint p)
		{
		}

		// Token: 0x0600505A RID: 20570 RVA: 0x00019DE8 File Offset: 0x00017FE8
		[Token(Token = "0x600428B")]
		[Address(RVA = "0x24AB160", Offset = "0x24AB261", VA = "0x24AB160")]
		private static bool NextFlipPoint(TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle ot, TriangulationPoint op, out TriangulationPoint newP)
		{
			return default(bool);
		}

		// Token: 0x0600505B RID: 20571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600428C")]
		[Address(RVA = "0x24AAF10", Offset = "0x24AB011", VA = "0x24AAF10")]
		private static DelaunayTriangle NextFlipTriangle(DTSweepContext tcx, Orientation o, DelaunayTriangle t, DelaunayTriangle ot, TriangulationPoint p, TriangulationPoint op)
		{
			return null;
		}

		// Token: 0x0600505C RID: 20572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600428D")]
		[Address(RVA = "0x24AB280", Offset = "0x24AB381", VA = "0x24AB280")]
		private static void FlipScanEdgeEvent(DTSweepContext tcx, TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle flipTriangle, DelaunayTriangle t, TriangulationPoint p)
		{
		}

		// Token: 0x0600505D RID: 20573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600428E")]
		[Address(RVA = "0x24A8910", Offset = "0x24A8A11", VA = "0x24A8910")]
		private static void FillAdvancingFront(DTSweepContext tcx, AdvancingFrontNode n)
		{
		}

		// Token: 0x0600505E RID: 20574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600428F")]
		[Address(RVA = "0x24AB790", Offset = "0x24AB891", VA = "0x24AB790")]
		private static void FillBasin(DTSweepContext tcx, AdvancingFrontNode node)
		{
		}

		// Token: 0x0600505F RID: 20575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004290")]
		[Address(RVA = "0x24ABA50", Offset = "0x24ABB51", VA = "0x24ABA50")]
		private static void FillBasinReq(DTSweepContext tcx, AdvancingFrontNode node)
		{
		}

		// Token: 0x06005060 RID: 20576 RVA: 0x00019E00 File Offset: 0x00018000
		[Token(Token = "0x6004291")]
		[Address(RVA = "0x24ABB90", Offset = "0x24ABC91", VA = "0x24ABB90")]
		private static bool IsShallow(DTSweepContext tcx, AdvancingFrontNode node)
		{
			return default(bool);
		}

		// Token: 0x06005061 RID: 20577 RVA: 0x00019E18 File Offset: 0x00018018
		[Token(Token = "0x6004292")]
		[Address(RVA = "0x24AB530", Offset = "0x24AB631", VA = "0x24AB530")]
		private static double HoleAngle(AdvancingFrontNode node)
		{
			return 0.0;
		}

		// Token: 0x06005062 RID: 20578 RVA: 0x00019E30 File Offset: 0x00018030
		[Token(Token = "0x6004293")]
		[Address(RVA = "0x24AB680", Offset = "0x24AB781", VA = "0x24AB680")]
		private static double BasinAngle(AdvancingFrontNode node)
		{
			return 0.0;
		}

		// Token: 0x06005063 RID: 20579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004294")]
		[Address(RVA = "0x24A8220", Offset = "0x24A8321", VA = "0x24A8220")]
		private static void Fill(DTSweepContext tcx, AdvancingFrontNode node)
		{
		}

		// Token: 0x06005064 RID: 20580 RVA: 0x00019E48 File Offset: 0x00018048
		[Token(Token = "0x6004295")]
		[Address(RVA = "0x24A8D40", Offset = "0x24A8E41", VA = "0x24A8D40")]
		private static bool Legalize(DTSweepContext tcx, DelaunayTriangle t)
		{
			return default(bool);
		}

		// Token: 0x06005065 RID: 20581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004296")]
		[Address(RVA = "0x24A7720", Offset = "0x24A7821", VA = "0x24A7720")]
		private static void RotateTrianglePair(DelaunayTriangle t, TriangulationPoint p, DelaunayTriangle ot, TriangulationPoint op)
		{
		}

		// Token: 0x0400B0DC RID: 45276
		[Token(Token = "0x400849C")]
		private const double PI_div2 = 1.5707963267948966;

		// Token: 0x0400B0DD RID: 45277
		[Token(Token = "0x400849D")]
		private const double PI_3div4 = 2.3561944901923448;
	}
}
