using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Poly2Tri
{
	// Token: 0x02000C69 RID: 3177
	[Token(Token = "0x200081A")]
	public class PolygonUtil
	{
		// Token: 0x0600510C RID: 20748 RVA: 0x0001A178 File Offset: 0x00018378
		[Token(Token = "0x600433D")]
		[Address(RVA = "0x27FE790", Offset = "0x27FE891", VA = "0x27FE790")]
		public static Point2DList.WindingOrderType CalculateWindingOrder(IList<Point2D> l)
		{
			return Point2DList.WindingOrderType.CW;
		}

		// Token: 0x0600510D RID: 20749 RVA: 0x0001A190 File Offset: 0x00018390
		[Token(Token = "0x600433E")]
		[Address(RVA = "0x27FEB10", Offset = "0x27FEC11", VA = "0x27FEB10")]
		public static bool PolygonsAreSame2D(IList<Point2D> poly1, IList<Point2D> poly2)
		{
			return default(bool);
		}

		// Token: 0x0600510E RID: 20750 RVA: 0x0001A1A8 File Offset: 0x000183A8
		[Token(Token = "0x600433F")]
		[Address(RVA = "0x27FBBE0", Offset = "0x27FBCE1", VA = "0x27FBBE0")]
		public static bool PointInPolygon2D(IList<Point2D> polygon, Point2D p)
		{
			return default(bool);
		}

		// Token: 0x0600510F RID: 20751 RVA: 0x0001A1C0 File Offset: 0x000183C0
		[Token(Token = "0x6004340")]
		[Address(RVA = "0x27FF0B0", Offset = "0x27FF1B1", VA = "0x27FF0B0")]
		public static bool PolygonsIntersect2D(IList<Point2D> poly1, Rect2D boundRect1, IList<Point2D> poly2, Rect2D boundRect2)
		{
			return default(bool);
		}

		// Token: 0x06005110 RID: 20752 RVA: 0x0001A1D8 File Offset: 0x000183D8
		[Token(Token = "0x6004341")]
		[Address(RVA = "0x27FF660", Offset = "0x27FF761", VA = "0x27FF660")]
		public bool PolygonContainsPolygon(IList<Point2D> poly1, Rect2D boundRect1, IList<Point2D> poly2, Rect2D boundRect2)
		{
			return default(bool);
		}

		// Token: 0x06005111 RID: 20753 RVA: 0x0001A1F0 File Offset: 0x000183F0
		[Token(Token = "0x6004342")]
		[Address(RVA = "0x27FF680", Offset = "0x27FF781", VA = "0x27FF680")]
		public static bool PolygonContainsPolygon(IList<Point2D> poly1, Rect2D boundRect1, IList<Point2D> poly2, Rect2D boundRect2, bool runIntersectionTest)
		{
			return default(bool);
		}

		// Token: 0x06005112 RID: 20754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004343")]
		[Address(RVA = "0x27FF960", Offset = "0x27FFA61", VA = "0x27FF960")]
		public static void ClipPolygonToEdge2D(Point2D edgeBegin, Point2D edgeEnd, IList<Point2D> poly, out List<Point2D> outPoly)
		{
		}

		// Token: 0x06005113 RID: 20755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004344")]
		[Address(RVA = "0x28007B0", Offset = "0x28008B1", VA = "0x28007B0")]
		public static void ClipPolygonToPolygon(IList<Point2D> poly, IList<Point2D> clipPoly, out List<Point2D> outPoly)
		{
		}

		// Token: 0x06005114 RID: 20756 RVA: 0x0001A208 File Offset: 0x00018408
		[Token(Token = "0x6004345")]
		[Address(RVA = "0x2800B00", Offset = "0x2800C01", VA = "0x2800B00")]
		public static PolygonUtil.PolyUnionError PolygonUnion(Point2DList polygon1, Point2DList polygon2, out Point2DList union)
		{
			return PolygonUtil.PolyUnionError.None;
		}

		// Token: 0x06005115 RID: 20757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004346")]
		[Address(RVA = "0x2800C10", Offset = "0x2800D11", VA = "0x2800C10")]
		protected static void PolygonUnionInternal(PolygonOperationContext ctx)
		{
		}

		// Token: 0x06005116 RID: 20758 RVA: 0x0001A220 File Offset: 0x00018420
		[Token(Token = "0x6004347")]
		[Address(RVA = "0x28013F0", Offset = "0x28014F1", VA = "0x28013F0")]
		public static PolygonUtil.PolyUnionError PolygonIntersect(Point2DList polygon1, Point2DList polygon2, out Point2DList intersectOut)
		{
			return PolygonUtil.PolyUnionError.None;
		}

		// Token: 0x06005117 RID: 20759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004348")]
		[Address(RVA = "0x2801500", Offset = "0x2801601", VA = "0x2801500")]
		protected static void PolygonIntersectInternal(PolygonOperationContext ctx)
		{
		}

		// Token: 0x06005118 RID: 20760 RVA: 0x0001A238 File Offset: 0x00018438
		[Token(Token = "0x6004349")]
		[Address(RVA = "0x2801E30", Offset = "0x2801F31", VA = "0x2801E30")]
		public static PolygonUtil.PolyUnionError PolygonSubtract(Point2DList polygon1, Point2DList polygon2, out Point2DList subtract)
		{
			return PolygonUtil.PolyUnionError.None;
		}

		// Token: 0x06005119 RID: 20761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600434A")]
		[Address(RVA = "0x2801F40", Offset = "0x2802041", VA = "0x2801F40")]
		public static void PolygonSubtractInternal(PolygonOperationContext ctx)
		{
		}

		// Token: 0x0600511A RID: 20762 RVA: 0x0001A250 File Offset: 0x00018450
		[Token(Token = "0x600434B")]
		[Address(RVA = "0x2802930", Offset = "0x2802A31", VA = "0x2802930")]
		public static PolygonUtil.PolyUnionError PolygonOperation(PolygonUtil.PolyOperation operations, Point2DList polygon1, Point2DList polygon2, out Dictionary<uint, Point2DList> results)
		{
			return PolygonUtil.PolyUnionError.None;
		}

		// Token: 0x0600511B RID: 20763 RVA: 0x0001A268 File Offset: 0x00018468
		[Token(Token = "0x600434C")]
		[Address(RVA = "0x2802A70", Offset = "0x2802B71", VA = "0x2802A70")]
		public static PolygonUtil.PolyUnionError PolygonOperation(PolygonOperationContext ctx)
		{
			return PolygonUtil.PolyUnionError.None;
		}

		// Token: 0x0600511C RID: 20764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600434D")]
		[Address(RVA = "0x2802AE0", Offset = "0x2802BE1", VA = "0x2802AE0")]
		public static List<Point2DList> SplitComplexPolygon(Point2DList verts, double epsilon)
		{
			return null;
		}

		// Token: 0x0600511D RID: 20765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600434E")]
		[Address(RVA = "0x2804A20", Offset = "0x2804B21", VA = "0x2804A20")]
		private static List<Point2DList> SplitComplexPolygonCleanup(IList<Point2D> orig)
		{
			return null;
		}

		// Token: 0x0600511E RID: 20766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600434F")]
		[Address(RVA = "0x2805410", Offset = "0x2805511", VA = "0x2805410")]
		public PolygonUtil()
		{
		}

		// Token: 0x02000C6A RID: 3178
		[Token(Token = "0x20013C8")]
		public enum PolyUnionError
		{
			// Token: 0x0400B109 RID: 45321
			[Token(Token = "0x401B885")]
			None,
			// Token: 0x0400B10A RID: 45322
			[Token(Token = "0x401B886")]
			NoIntersections,
			// Token: 0x0400B10B RID: 45323
			[Token(Token = "0x401B887")]
			Poly1InsidePoly2,
			// Token: 0x0400B10C RID: 45324
			[Token(Token = "0x401B888")]
			InfiniteLoop
		}

		// Token: 0x02000C6B RID: 3179
		[Token(Token = "0x20013C9")]
		[Flags]
		public enum PolyOperation : uint
		{
			// Token: 0x0400B10E RID: 45326
			[Token(Token = "0x401B88A")]
			None = 0U,
			// Token: 0x0400B10F RID: 45327
			[Token(Token = "0x401B88B")]
			Union = 1U,
			// Token: 0x0400B110 RID: 45328
			[Token(Token = "0x401B88C")]
			Intersect = 2U,
			// Token: 0x0400B111 RID: 45329
			[Token(Token = "0x401B88D")]
			Subtract = 4U
		}
	}
}
