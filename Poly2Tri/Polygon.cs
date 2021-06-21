using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Poly2Tri
{
	// Token: 0x02000C66 RID: 3174
	[Token(Token = "0x2000817")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x1476A0", Offset = "0x1477A1")]
	public class Polygon : Point2DList, ITriangulatable, IEnumerable<TriangulationPoint>, IEnumerable, IList<TriangulationPoint>, ICollection<TriangulationPoint>
	{
		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x060050D3 RID: 20691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000834")]
		public IList<TriangulationPoint> Points
		{
			[Token(Token = "0x6004304")]
			[Address(RVA = "0x27FA3D0", Offset = "0x27FA4D1", VA = "0x27FA3D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x060050D4 RID: 20692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000835")]
		public IList<DelaunayTriangle> Triangles
		{
			[Token(Token = "0x6004305")]
			[Address(RVA = "0x27FA3E0", Offset = "0x27FA4E1", VA = "0x27FA3E0", Slot = "27")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x060050D5 RID: 20693 RVA: 0x0001A040 File Offset: 0x00018240
		[Token(Token = "0x17000836")]
		public TriangulationMode TriangulationMode
		{
			[Token(Token = "0x6004306")]
			[Address(RVA = "0x27FA3F0", Offset = "0x27FA4F1", VA = "0x27FA3F0", Slot = "28")]
			get
			{
				return TriangulationMode.Unconstrained;
			}
		}

		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x060050D6 RID: 20694 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060050D7 RID: 20695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000837")]
		public string FileName
		{
			[Token(Token = "0x6004307")]
			[Address(RVA = "0x27FA400", Offset = "0x27FA501", VA = "0x27FA400", Slot = "29")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A92A0", Offset = "0x1A93A1")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004308")]
			[Address(RVA = "0x27FA410", Offset = "0x27FA511", VA = "0x27FA410", Slot = "30")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A92B0", Offset = "0x1A93B1")]
			set
			{
			}
		}

		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x060050D8 RID: 20696 RVA: 0x0001A058 File Offset: 0x00018258
		// (set) Token: 0x060050D9 RID: 20697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000838")]
		public bool DisplayFlipX
		{
			[Token(Token = "0x6004309")]
			[Address(RVA = "0x27FA420", Offset = "0x27FA521", VA = "0x27FA420", Slot = "31")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A92C0", Offset = "0x1A93C1")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600430A")]
			[Address(RVA = "0x27FA430", Offset = "0x27FA531", VA = "0x27FA430", Slot = "32")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A92D0", Offset = "0x1A93D1")]
			set
			{
			}
		}

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x060050DA RID: 20698 RVA: 0x0001A070 File Offset: 0x00018270
		// (set) Token: 0x060050DB RID: 20699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000839")]
		public bool DisplayFlipY
		{
			[Token(Token = "0x600430B")]
			[Address(RVA = "0x27FA440", Offset = "0x27FA541", VA = "0x27FA440", Slot = "33")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A92E0", Offset = "0x1A93E1")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600430C")]
			[Address(RVA = "0x27FA450", Offset = "0x27FA551", VA = "0x27FA450", Slot = "34")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A92F0", Offset = "0x1A93F1")]
			set
			{
			}
		}

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x060050DC RID: 20700 RVA: 0x0001A088 File Offset: 0x00018288
		// (set) Token: 0x060050DD RID: 20701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700083A")]
		public float DisplayRotate
		{
			[Token(Token = "0x600430D")]
			[Address(RVA = "0x27FA460", Offset = "0x27FA561", VA = "0x27FA460", Slot = "35")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9300", Offset = "0x1A9401")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600430E")]
			[Address(RVA = "0x27FA470", Offset = "0x27FA571", VA = "0x27FA470", Slot = "36")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9310", Offset = "0x1A9411")]
			set
			{
			}
		}

		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x060050DE RID: 20702 RVA: 0x0001A0A0 File Offset: 0x000182A0
		// (set) Token: 0x060050DF RID: 20703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700083B")]
		public double Precision
		{
			[Token(Token = "0x600430F")]
			[Address(RVA = "0x27FA480", Offset = "0x27FA581", VA = "0x27FA480", Slot = "37")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6004310")]
			[Address(RVA = "0x27FA490", Offset = "0x27FA591", VA = "0x27FA490", Slot = "38")]
			set
			{
			}
		}

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x060050E0 RID: 20704 RVA: 0x0001A0B8 File Offset: 0x000182B8
		[Token(Token = "0x1700083C")]
		public double MinX
		{
			[Token(Token = "0x6004311")]
			[Address(RVA = "0x27FA4A0", Offset = "0x27FA5A1", VA = "0x27FA4A0", Slot = "39")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x060050E1 RID: 20705 RVA: 0x0001A0D0 File Offset: 0x000182D0
		[Token(Token = "0x1700083D")]
		public double MaxX
		{
			[Token(Token = "0x6004312")]
			[Address(RVA = "0x27FA4C0", Offset = "0x27FA5C1", VA = "0x27FA4C0", Slot = "40")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x060050E2 RID: 20706 RVA: 0x0001A0E8 File Offset: 0x000182E8
		[Token(Token = "0x1700083E")]
		public double MinY
		{
			[Token(Token = "0x6004313")]
			[Address(RVA = "0x27FA4E0", Offset = "0x27FA5E1", VA = "0x27FA4E0", Slot = "41")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x060050E3 RID: 20707 RVA: 0x0001A100 File Offset: 0x00018300
		[Token(Token = "0x1700083F")]
		public double MaxY
		{
			[Token(Token = "0x6004314")]
			[Address(RVA = "0x27FA500", Offset = "0x27FA601", VA = "0x27FA500", Slot = "42")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x060050E4 RID: 20708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000840")]
		public Rect2D Bounds
		{
			[Token(Token = "0x6004315")]
			[Address(RVA = "0x27FA520", Offset = "0x27FA621", VA = "0x27FA520", Slot = "43")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x060050E5 RID: 20709 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060050E6 RID: 20710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000841")]
		public new TriangulationPoint Item
		{
			[Token(Token = "0x6004316")]
			[Address(RVA = "0x27FA530", Offset = "0x27FA631", VA = "0x27FA530", Slot = "49")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004317")]
			[Address(RVA = "0x27FA610", Offset = "0x27FA711", VA = "0x27FA610", Slot = "50")]
			set
			{
			}
		}

		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x060050E7 RID: 20711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000842")]
		public IList<Polygon> Holes
		{
			[Token(Token = "0x6004318")]
			[Address(RVA = "0x27FA680", Offset = "0x27FA781", VA = "0x27FA680")]
			get
			{
				return null;
			}
		}

		// Token: 0x060050E8 RID: 20712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004319")]
		[Address(RVA = "0x27FA690", Offset = "0x27FA791", VA = "0x27FA690")]
		public Polygon(IList<PolygonPoint> points)
		{
		}

		// Token: 0x060050E9 RID: 20713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600431A")]
		[Address(RVA = "0x27FABE0", Offset = "0x27FACE1", VA = "0x27FABE0")]
		public Polygon(IEnumerable<PolygonPoint> points)
		{
		}

		// Token: 0x060050EA RID: 20714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600431B")]
		[Address(RVA = "0x27FAC70", Offset = "0x27FAD71", VA = "0x27FAC70")]
		public Polygon(params PolygonPoint[] points)
		{
		}

		// Token: 0x060050EB RID: 20715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600431C")]
		[Address(RVA = "0x27FAC80", Offset = "0x27FAD81", VA = "0x27FAC80", Slot = "48")]
		private IEnumerator<TriangulationPoint> GetEnumerator()
		{
			return null;
		}

		// Token: 0x060050EC RID: 20716 RVA: 0x0001A118 File Offset: 0x00018318
		[Token(Token = "0x600431D")]
		[Address(RVA = "0x27FAD00", Offset = "0x27FAE01", VA = "0x27FAD00", Slot = "51")]
		public int IndexOf(TriangulationPoint p)
		{
			return 0;
		}

		// Token: 0x060050ED RID: 20717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600431E")]
		[Address(RVA = "0x27FAD70", Offset = "0x27FAE71", VA = "0x27FAD70", Slot = "19")]
		public override void Add(Point2D p)
		{
		}

		// Token: 0x060050EE RID: 20718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600431F")]
		[Address(RVA = "0x27FAD90", Offset = "0x27FAE91", VA = "0x27FAD90", Slot = "56")]
		public void Add(TriangulationPoint p)
		{
		}

		// Token: 0x060050EF RID: 20719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004320")]
		[Address(RVA = "0x27FADB0", Offset = "0x27FAEB1", VA = "0x27FADB0")]
		public void Add(PolygonPoint p)
		{
		}

		// Token: 0x060050F0 RID: 20720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004321")]
		[Address(RVA = "0x27FADD0", Offset = "0x27FAED1", VA = "0x27FADD0", Slot = "20")]
		protected override void Add(Point2D p, int idx, bool bCalcWindingOrderAndEpsilon)
		{
		}

		// Token: 0x060050F1 RID: 20721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004322")]
		[Address(RVA = "0x27FA840", Offset = "0x27FA941", VA = "0x27FA840")]
		public void AddRange(IList<PolygonPoint> points, Point2DList.WindingOrderType windingOrder)
		{
		}

		// Token: 0x060050F2 RID: 20722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004323")]
		[Address(RVA = "0x27FAF60", Offset = "0x27FB061", VA = "0x27FAF60")]
		public void AddRange(IList<TriangulationPoint> points, Point2DList.WindingOrderType windingOrder)
		{
		}

		// Token: 0x060050F3 RID: 20723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004324")]
		[Address(RVA = "0x27FB300", Offset = "0x27FB401", VA = "0x27FB300", Slot = "52")]
		public void Insert(int idx, TriangulationPoint p)
		{
		}

		// Token: 0x060050F4 RID: 20724 RVA: 0x0001A130 File Offset: 0x00018330
		[Token(Token = "0x6004325")]
		[Address(RVA = "0x27FB320", Offset = "0x27FB421", VA = "0x27FB320", Slot = "60")]
		public bool Remove(TriangulationPoint p)
		{
			return default(bool);
		}

		// Token: 0x060050F5 RID: 20725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004326")]
		[Address(RVA = "0x27FB3C0", Offset = "0x27FB4C1", VA = "0x27FB3C0")]
		public void RemovePoint(PolygonPoint p)
		{
		}

		// Token: 0x060050F6 RID: 20726 RVA: 0x0001A148 File Offset: 0x00018348
		[Token(Token = "0x6004327")]
		[Address(RVA = "0x27FB590", Offset = "0x27FB691", VA = "0x27FB590", Slot = "58")]
		public bool Contains(TriangulationPoint p)
		{
			return default(bool);
		}

		// Token: 0x060050F7 RID: 20727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004328")]
		[Address(RVA = "0x27FB600", Offset = "0x27FB701", VA = "0x27FB600", Slot = "59")]
		public void CopyTo(TriangulationPoint[] array, int arrayIndex)
		{
		}

		// Token: 0x060050F8 RID: 20728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004329")]
		[Address(RVA = "0x27FB820", Offset = "0x27FB921", VA = "0x27FB820")]
		public void AddSteinerPoint(TriangulationPoint point)
		{
		}

		// Token: 0x060050F9 RID: 20729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600432A")]
		[Address(RVA = "0x27FB8D0", Offset = "0x27FB9D1", VA = "0x27FB8D0")]
		public void AddSteinerPoints(List<TriangulationPoint> points)
		{
		}

		// Token: 0x060050FA RID: 20730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600432B")]
		[Address(RVA = "0x27FB980", Offset = "0x27FBA81", VA = "0x27FB980")]
		public void ClearSteinerPoints()
		{
		}

		// Token: 0x060050FB RID: 20731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600432C")]
		[Address(RVA = "0x27FB9E0", Offset = "0x27FBAE1", VA = "0x27FB9E0")]
		public void AddHole(Polygon poly)
		{
		}

		// Token: 0x060050FC RID: 20732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600432D")]
		[Address(RVA = "0x27FBA90", Offset = "0x27FBB91", VA = "0x27FBA90", Slot = "45")]
		public void AddTriangle(DelaunayTriangle t)
		{
		}

		// Token: 0x060050FD RID: 20733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600432E")]
		[Address(RVA = "0x27FBB00", Offset = "0x27FBC01", VA = "0x27FBB00", Slot = "46")]
		public void AddTriangles(IEnumerable<DelaunayTriangle> list)
		{
		}

		// Token: 0x060050FE RID: 20734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600432F")]
		[Address(RVA = "0x27FBB70", Offset = "0x27FBC71", VA = "0x27FBB70", Slot = "47")]
		public void ClearTriangles()
		{
		}

		// Token: 0x060050FF RID: 20735 RVA: 0x0001A160 File Offset: 0x00018360
		[Token(Token = "0x6004330")]
		[Address(RVA = "0x27FBBD0", Offset = "0x27FBCD1", VA = "0x27FBBD0")]
		public bool IsPointInside(TriangulationPoint p)
		{
			return default(bool);
		}

		// Token: 0x06005100 RID: 20736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004331")]
		[Address(RVA = "0x27FBF80", Offset = "0x27FC081", VA = "0x27FBF80", Slot = "44")]
		public void Prepare(TriangulationContext tcx)
		{
		}

		// Token: 0x0400B0FB RID: 45307
		[Token(Token = "0x40084BB")]
		[FieldOffset(Offset = "0x30")]
		protected Dictionary<uint, TriangulationPoint> mPointMap;

		// Token: 0x0400B0FC RID: 45308
		[Token(Token = "0x40084BC")]
		[FieldOffset(Offset = "0x38")]
		protected List<DelaunayTriangle> mTriangles;

		// Token: 0x0400B0FD RID: 45309
		[Token(Token = "0x40084BD")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1771C0", Offset = "0x1772C1")]
		private string <FileName>k__BackingField;

		// Token: 0x0400B0FE RID: 45310
		[Token(Token = "0x40084BE")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1771D0", Offset = "0x1772D1")]
		private bool <DisplayFlipX>k__BackingField;

		// Token: 0x0400B0FF RID: 45311
		[Token(Token = "0x40084BF")]
		[FieldOffset(Offset = "0x49")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1771E0", Offset = "0x1772E1")]
		private bool <DisplayFlipY>k__BackingField;

		// Token: 0x0400B100 RID: 45312
		[Token(Token = "0x40084C0")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1771F0", Offset = "0x1772F1")]
		private float <DisplayRotate>k__BackingField;

		// Token: 0x0400B101 RID: 45313
		[Token(Token = "0x40084C1")]
		[FieldOffset(Offset = "0x50")]
		private double mPrecision;

		// Token: 0x0400B102 RID: 45314
		[Token(Token = "0x40084C2")]
		[FieldOffset(Offset = "0x58")]
		protected List<Polygon> mHoles;

		// Token: 0x0400B103 RID: 45315
		[Token(Token = "0x40084C3")]
		[FieldOffset(Offset = "0x60")]
		protected List<TriangulationPoint> mSteinerPoints;

		// Token: 0x0400B104 RID: 45316
		[Token(Token = "0x40084C4")]
		[FieldOffset(Offset = "0x68")]
		protected PolygonPoint _last;
	}
}
