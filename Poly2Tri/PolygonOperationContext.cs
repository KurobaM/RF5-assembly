using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Poly2Tri
{
	// Token: 0x02000C6E RID: 3182
	[Token(Token = "0x200081D")]
	public class PolygonOperationContext
	{
		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x0600513B RID: 20795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700084C")]
		public Point2DList Union
		{
			[Token(Token = "0x600436C")]
			[Address(RVA = "0x27FCF50", Offset = "0x27FD051", VA = "0x27FCF50")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x0600513C RID: 20796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700084D")]
		public Point2DList Intersect
		{
			[Token(Token = "0x600436D")]
			[Address(RVA = "0x27FD010", Offset = "0x27FD111", VA = "0x27FD010")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x0600513D RID: 20797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700084E")]
		public Point2DList Subtract
		{
			[Token(Token = "0x600436E")]
			[Address(RVA = "0x27FD0D0", Offset = "0x27FD1D1", VA = "0x27FD0D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600513E RID: 20798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600436F")]
		[Address(RVA = "0x27FD190", Offset = "0x27FD291", VA = "0x27FD190")]
		public PolygonOperationContext()
		{
		}

		// Token: 0x0600513F RID: 20799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004370")]
		[Address(RVA = "0x27FD210", Offset = "0x27FD311", VA = "0x27FD210")]
		public void Clear()
		{
		}

		// Token: 0x06005140 RID: 20800 RVA: 0x0001A358 File Offset: 0x00018558
		[Token(Token = "0x6004371")]
		[Address(RVA = "0x27FD300", Offset = "0x27FD401", VA = "0x27FD300")]
		public bool Init(PolygonUtil.PolyOperation operations, Point2DList polygon1, Point2DList polygon2)
		{
			return default(bool);
		}

		// Token: 0x06005141 RID: 20801 RVA: 0x0001A370 File Offset: 0x00018570
		[Token(Token = "0x6004372")]
		[Address(RVA = "0x27FDDD0", Offset = "0x27FDED1", VA = "0x27FDDD0")]
		private bool VerticesIntersect(Point2DList polygon1, Point2DList polygon2, out List<EdgeIntersectInfo> intersections)
		{
			return default(bool);
		}

		// Token: 0x06005142 RID: 20802 RVA: 0x0001A388 File Offset: 0x00018588
		[Token(Token = "0x6004373")]
		[Address(RVA = "0x27FE260", Offset = "0x27FE361", VA = "0x27FE260")]
		public bool PointInPolygonAngle(Point2D point, Point2DList polygon)
		{
			return default(bool);
		}

		// Token: 0x06005143 RID: 20803 RVA: 0x0001A3A0 File Offset: 0x000185A0
		[Token(Token = "0x6004374")]
		[Address(RVA = "0x27FE440", Offset = "0x27FE541", VA = "0x27FE440")]
		public double VectorAngle(Point2D p1, Point2D p2)
		{
			return 0.0;
		}

		// Token: 0x0400B117 RID: 45335
		[Token(Token = "0x40084CD")]
		[FieldOffset(Offset = "0x10")]
		public PolygonUtil.PolyOperation mOperations;

		// Token: 0x0400B118 RID: 45336
		[Token(Token = "0x40084CE")]
		[FieldOffset(Offset = "0x18")]
		public Point2DList mOriginalPolygon1;

		// Token: 0x0400B119 RID: 45337
		[Token(Token = "0x40084CF")]
		[FieldOffset(Offset = "0x20")]
		public Point2DList mOriginalPolygon2;

		// Token: 0x0400B11A RID: 45338
		[Token(Token = "0x40084D0")]
		[FieldOffset(Offset = "0x28")]
		public Point2DList mPoly1;

		// Token: 0x0400B11B RID: 45339
		[Token(Token = "0x40084D1")]
		[FieldOffset(Offset = "0x30")]
		public Point2DList mPoly2;

		// Token: 0x0400B11C RID: 45340
		[Token(Token = "0x40084D2")]
		[FieldOffset(Offset = "0x38")]
		public List<EdgeIntersectInfo> mIntersections;

		// Token: 0x0400B11D RID: 45341
		[Token(Token = "0x40084D3")]
		[FieldOffset(Offset = "0x40")]
		public int mStartingIndex;

		// Token: 0x0400B11E RID: 45342
		[Token(Token = "0x40084D4")]
		[FieldOffset(Offset = "0x44")]
		public PolygonUtil.PolyUnionError mError;

		// Token: 0x0400B11F RID: 45343
		[Token(Token = "0x40084D5")]
		[FieldOffset(Offset = "0x48")]
		public List<int> mPoly1VectorAngles;

		// Token: 0x0400B120 RID: 45344
		[Token(Token = "0x40084D6")]
		[FieldOffset(Offset = "0x50")]
		public List<int> mPoly2VectorAngles;

		// Token: 0x0400B121 RID: 45345
		[Token(Token = "0x40084D7")]
		[FieldOffset(Offset = "0x58")]
		public Dictionary<uint, Point2DList> mOutput;
	}
}
