using System;
using Il2CppDummyDll;

namespace Poly2Tri
{
	// Token: 0x02000C7C RID: 3196
	[Token(Token = "0x200082B")]
	public class TriangulationUtil
	{
		// Token: 0x060051CC RID: 20940 RVA: 0x0001A7F0 File Offset: 0x000189F0
		[Token(Token = "0x60043FD")]
		[Address(RVA = "0x2808150", Offset = "0x2808251", VA = "0x2808150")]
		public static bool SmartIncircle(Point2D pa, Point2D pb, Point2D pc, Point2D pd)
		{
			return default(bool);
		}

		// Token: 0x060051CD RID: 20941 RVA: 0x0001A808 File Offset: 0x00018A08
		[Token(Token = "0x60043FE")]
		[Address(RVA = "0x28082E0", Offset = "0x28083E1", VA = "0x28082E0")]
		public static bool InScanArea(Point2D pa, Point2D pb, Point2D pc, Point2D pd)
		{
			return default(bool);
		}

		// Token: 0x060051CE RID: 20942 RVA: 0x0001A820 File Offset: 0x00018A20
		[Token(Token = "0x60043FF")]
		[Address(RVA = "0x27F5980", Offset = "0x27F5A81", VA = "0x27F5980")]
		public static Orientation Orient2d(Point2D pa, Point2D pb, Point2D pc)
		{
			return Orientation.CW;
		}

		// Token: 0x060051CF RID: 20943 RVA: 0x0001A838 File Offset: 0x00018A38
		[Token(Token = "0x6004400")]
		[Address(RVA = "0x2808420", Offset = "0x2808521", VA = "0x2808420")]
		public static bool PointInBoundingBox(double xmin, double xmax, double ymin, double ymax, Point2D p)
		{
			return default(bool);
		}

		// Token: 0x060051D0 RID: 20944 RVA: 0x0001A850 File Offset: 0x00018A50
		[Token(Token = "0x6004401")]
		[Address(RVA = "0x28084D0", Offset = "0x28085D1", VA = "0x28084D0")]
		public static bool PointOnLineSegment2D(Point2D lineStart, Point2D lineEnd, Point2D p, double epsilon)
		{
			return default(bool);
		}

		// Token: 0x060051D1 RID: 20945 RVA: 0x0001A868 File Offset: 0x00018A68
		[Token(Token = "0x6004402")]
		[Address(RVA = "0x28085C0", Offset = "0x28086C1", VA = "0x28085C0")]
		public static bool PointOnLineSegment2D(double x1, double y1, double x2, double y2, double x, double y, double epsilon)
		{
			return default(bool);
		}

		// Token: 0x060051D2 RID: 20946 RVA: 0x0001A880 File Offset: 0x00018A80
		[Token(Token = "0x6004403")]
		[Address(RVA = "0x28060C0", Offset = "0x28061C1", VA = "0x28060C0")]
		public static bool RectsIntersect(Rect2D r1, Rect2D r2)
		{
			return default(bool);
		}

		// Token: 0x060051D3 RID: 20947 RVA: 0x0001A898 File Offset: 0x00018A98
		[Token(Token = "0x6004404")]
		[Address(RVA = "0x28042F0", Offset = "0x28043F1", VA = "0x28042F0")]
		public static bool LinesIntersect2D(Point2D ptStart0, Point2D ptEnd0, Point2D ptStart1, Point2D ptEnd1, bool firstIsSegment, bool secondIsSegment, bool coincidentEndPointCollisions, ref Point2D pIntersectionPt, double epsilon)
		{
			return default(bool);
		}

		// Token: 0x060051D4 RID: 20948 RVA: 0x0001A8B0 File Offset: 0x00018AB0
		[Token(Token = "0x6004405")]
		[Address(RVA = "0x27F6190", Offset = "0x27F6291", VA = "0x27F6190")]
		public static bool LinesIntersect2D(Point2D ptStart0, Point2D ptEnd0, Point2D ptStart1, Point2D ptEnd1, ref Point2D pIntersectionPt, double epsilon)
		{
			return default(bool);
		}

		// Token: 0x060051D5 RID: 20949 RVA: 0x0001A8C8 File Offset: 0x00018AC8
		[Token(Token = "0x6004406")]
		[Address(RVA = "0x2808750", Offset = "0x2808851", VA = "0x2808750")]
		public static double LI2DDotProduct(Point2D v0, Point2D v1)
		{
			return 0.0;
		}

		// Token: 0x060051D6 RID: 20950 RVA: 0x0001A8E0 File Offset: 0x00018AE0
		[Token(Token = "0x6004407")]
		[Address(RVA = "0x2800410", Offset = "0x2800511", VA = "0x2800410")]
		public static bool RaysIntersect2D(Point2D ptRayOrigin0, Point2D ptRayVector0, Point2D ptRayOrigin1, Point2D ptRayVector1, ref Point2D ptIntersection)
		{
			return default(bool);
		}

		// Token: 0x060051D7 RID: 20951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004408")]
		[Address(RVA = "0x28087E0", Offset = "0x28088E1", VA = "0x28087E0")]
		public TriangulationUtil()
		{
		}
	}
}
