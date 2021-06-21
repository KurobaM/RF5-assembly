using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Poly2Tri
{
	// Token: 0x02000C70 RID: 3184
	[Token(Token = "0x200081F")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x147720", Offset = "0x147821")]
	public class PointSet : Point2DList, ITriangulatable, IEnumerable<TriangulationPoint>, IEnumerable, IList<TriangulationPoint>, ICollection<TriangulationPoint>
	{
		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x06005159 RID: 20825 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600515A RID: 20826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000850")]
		public IList<TriangulationPoint> Points
		{
			[Token(Token = "0x600438A")]
			[Address(RVA = "0x27F8750", Offset = "0x27F8851", VA = "0x27F8750")]
			get
			{
				return null;
			}
			[Token(Token = "0x600438B")]
			[Address(RVA = "0x27F8760", Offset = "0x27F8861", VA = "0x27F8760")]
			private set
			{
			}
		}

		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x0600515B RID: 20827 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600515C RID: 20828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000851")]
		public IList<DelaunayTriangle> Triangles
		{
			[Token(Token = "0x600438C")]
			[Address(RVA = "0x27F8770", Offset = "0x27F8871", VA = "0x27F8770", Slot = "27")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A93C0", Offset = "0x1A94C1")]
			get
			{
				return null;
			}
			[Token(Token = "0x600438D")]
			[Address(RVA = "0x27F8780", Offset = "0x27F8881", VA = "0x27F8780")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A93D0", Offset = "0x1A94D1")]
			private set
			{
			}
		}

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x0600515D RID: 20829 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600515E RID: 20830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000852")]
		public string FileName
		{
			[Token(Token = "0x600438E")]
			[Address(RVA = "0x27F8790", Offset = "0x27F8891", VA = "0x27F8790", Slot = "29")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A93E0", Offset = "0x1A94E1")]
			get
			{
				return null;
			}
			[Token(Token = "0x600438F")]
			[Address(RVA = "0x27F87A0", Offset = "0x27F88A1", VA = "0x27F87A0", Slot = "30")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A93F0", Offset = "0x1A94F1")]
			set
			{
			}
		}

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x0600515F RID: 20831 RVA: 0x0001A4C0 File Offset: 0x000186C0
		// (set) Token: 0x06005160 RID: 20832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000853")]
		public bool DisplayFlipX
		{
			[Token(Token = "0x6004390")]
			[Address(RVA = "0x27F87B0", Offset = "0x27F88B1", VA = "0x27F87B0", Slot = "31")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9400", Offset = "0x1A9501")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004391")]
			[Address(RVA = "0x27F87C0", Offset = "0x27F88C1", VA = "0x27F87C0", Slot = "32")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9410", Offset = "0x1A9511")]
			set
			{
			}
		}

		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x06005161 RID: 20833 RVA: 0x0001A4D8 File Offset: 0x000186D8
		// (set) Token: 0x06005162 RID: 20834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000854")]
		public bool DisplayFlipY
		{
			[Token(Token = "0x6004392")]
			[Address(RVA = "0x27F87D0", Offset = "0x27F88D1", VA = "0x27F87D0", Slot = "33")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9420", Offset = "0x1A9521")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004393")]
			[Address(RVA = "0x27F87E0", Offset = "0x27F88E1", VA = "0x27F87E0", Slot = "34")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9430", Offset = "0x1A9531")]
			set
			{
			}
		}

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x06005163 RID: 20835 RVA: 0x0001A4F0 File Offset: 0x000186F0
		// (set) Token: 0x06005164 RID: 20836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000855")]
		public float DisplayRotate
		{
			[Token(Token = "0x6004394")]
			[Address(RVA = "0x27F87F0", Offset = "0x27F88F1", VA = "0x27F87F0", Slot = "35")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9440", Offset = "0x1A9541")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004395")]
			[Address(RVA = "0x27F8800", Offset = "0x27F8901", VA = "0x27F8800", Slot = "36")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9450", Offset = "0x1A9551")]
			set
			{
			}
		}

		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x06005165 RID: 20837 RVA: 0x0001A508 File Offset: 0x00018708
		// (set) Token: 0x06005166 RID: 20838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000856")]
		public double Precision
		{
			[Token(Token = "0x6004396")]
			[Address(RVA = "0x27F8810", Offset = "0x27F8911", VA = "0x27F8810", Slot = "37")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6004397")]
			[Address(RVA = "0x27F8820", Offset = "0x27F8921", VA = "0x27F8820", Slot = "38")]
			set
			{
			}
		}

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x06005167 RID: 20839 RVA: 0x0001A520 File Offset: 0x00018720
		[Token(Token = "0x17000857")]
		public double MinX
		{
			[Token(Token = "0x6004398")]
			[Address(RVA = "0x27F8830", Offset = "0x27F8931", VA = "0x27F8830", Slot = "39")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x06005168 RID: 20840 RVA: 0x0001A538 File Offset: 0x00018738
		[Token(Token = "0x17000858")]
		public double MaxX
		{
			[Token(Token = "0x6004399")]
			[Address(RVA = "0x27F8850", Offset = "0x27F8951", VA = "0x27F8850", Slot = "40")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x06005169 RID: 20841 RVA: 0x0001A550 File Offset: 0x00018750
		[Token(Token = "0x17000859")]
		public double MinY
		{
			[Token(Token = "0x600439A")]
			[Address(RVA = "0x27F8870", Offset = "0x27F8971", VA = "0x27F8870", Slot = "41")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x0600516A RID: 20842 RVA: 0x0001A568 File Offset: 0x00018768
		[Token(Token = "0x1700085A")]
		public double MaxY
		{
			[Token(Token = "0x600439B")]
			[Address(RVA = "0x27F8890", Offset = "0x27F8991", VA = "0x27F8890", Slot = "42")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x0600516B RID: 20843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700085B")]
		public Rect2D Bounds
		{
			[Token(Token = "0x600439C")]
			[Address(RVA = "0x27F88B0", Offset = "0x27F89B1", VA = "0x27F88B0", Slot = "43")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x0600516C RID: 20844 RVA: 0x0001A580 File Offset: 0x00018780
		[Token(Token = "0x1700085C")]
		public virtual TriangulationMode TriangulationMode
		{
			[Token(Token = "0x600439D")]
			[Address(RVA = "0x27F88C0", Offset = "0x27F89C1", VA = "0x27F88C0", Slot = "61")]
			get
			{
				return TriangulationMode.Unconstrained;
			}
		}

		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x0600516D RID: 20845 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600516E RID: 20846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700085D")]
		public new TriangulationPoint Item
		{
			[Token(Token = "0x600439E")]
			[Address(RVA = "0x27F88D0", Offset = "0x27F89D1", VA = "0x27F88D0", Slot = "49")]
			get
			{
				return null;
			}
			[Token(Token = "0x600439F")]
			[Address(RVA = "0x27F89B0", Offset = "0x27F8AB1", VA = "0x27F89B0", Slot = "50")]
			set
			{
			}
		}

		// Token: 0x0600516F RID: 20847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043A0")]
		[Address(RVA = "0x27F8A20", Offset = "0x27F8B21", VA = "0x27F8A20")]
		public PointSet(List<TriangulationPoint> bounds)
		{
		}

		// Token: 0x06005170 RID: 20848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043A1")]
		[Address(RVA = "0x27F8D20", Offset = "0x27F8E21", VA = "0x27F8D20", Slot = "48")]
		private IEnumerator<TriangulationPoint> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06005171 RID: 20849 RVA: 0x0001A598 File Offset: 0x00018798
		[Token(Token = "0x60043A2")]
		[Address(RVA = "0x27F8DE0", Offset = "0x27F8EE1", VA = "0x27F8DE0", Slot = "51")]
		public int IndexOf(TriangulationPoint p)
		{
			return 0;
		}

		// Token: 0x06005172 RID: 20850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043A3")]
		[Address(RVA = "0x27F8E50", Offset = "0x27F8F51", VA = "0x27F8E50", Slot = "19")]
		public override void Add(Point2D p)
		{
		}

		// Token: 0x06005173 RID: 20851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043A4")]
		[Address(RVA = "0x27F8EF0", Offset = "0x27F8FF1", VA = "0x27F8EF0", Slot = "62")]
		public virtual void Add(TriangulationPoint p)
		{
		}

		// Token: 0x06005174 RID: 20852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043A5")]
		[Address(RVA = "0x27F8F00", Offset = "0x27F9001", VA = "0x27F8F00", Slot = "20")]
		protected override void Add(Point2D p, int idx, bool constrainToBounds)
		{
		}

		// Token: 0x06005175 RID: 20853 RVA: 0x0001A5B0 File Offset: 0x000187B0
		[Token(Token = "0x60043A6")]
		[Address(RVA = "0x27F8C20", Offset = "0x27F8D21", VA = "0x27F8C20")]
		protected bool Add(TriangulationPoint p, int idx, bool constrainToBounds)
		{
			return default(bool);
		}

		// Token: 0x06005176 RID: 20854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043A7")]
		[Address(RVA = "0x27F9190", Offset = "0x27F9291", VA = "0x27F9190", Slot = "22")]
		public override void AddRange(IEnumerator<Point2D> iter, Point2DList.WindingOrderType windingOrder)
		{
		}

		// Token: 0x06005177 RID: 20855 RVA: 0x0001A5C8 File Offset: 0x000187C8
		[Token(Token = "0x60043A8")]
		[Address(RVA = "0x27F9360", Offset = "0x27F9461", VA = "0x27F9360", Slot = "63")]
		public virtual bool AddRange(List<TriangulationPoint> points)
		{
			return default(bool);
		}

		// Token: 0x06005178 RID: 20856 RVA: 0x0001A5E0 File Offset: 0x000187E0
		[Token(Token = "0x60043A9")]
		[Address(RVA = "0x27F9480", Offset = "0x27F9581", VA = "0x27F9480")]
		public bool TryGetPoint(double x, double y, out TriangulationPoint p)
		{
			return default(bool);
		}

		// Token: 0x06005179 RID: 20857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043AA")]
		[Address(RVA = "0x27F9790", Offset = "0x27F9891", VA = "0x27F9790", Slot = "52")]
		public void Insert(int idx, TriangulationPoint item)
		{
		}

		// Token: 0x0600517A RID: 20858 RVA: 0x0001A5F8 File Offset: 0x000187F8
		[Token(Token = "0x60043AB")]
		[Address(RVA = "0x27F9800", Offset = "0x27F9901", VA = "0x27F9800", Slot = "24")]
		public override bool Remove(Point2D p)
		{
			return default(bool);
		}

		// Token: 0x0600517B RID: 20859 RVA: 0x0001A610 File Offset: 0x00018810
		[Token(Token = "0x60043AC")]
		[Address(RVA = "0x27F9870", Offset = "0x27F9971", VA = "0x27F9870", Slot = "60")]
		public bool Remove(TriangulationPoint p)
		{
			return default(bool);
		}

		// Token: 0x0600517C RID: 20860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043AD")]
		[Address(RVA = "0x27F98E0", Offset = "0x27F99E1", VA = "0x27F98E0", Slot = "25")]
		public override void RemoveAt(int idx)
		{
		}

		// Token: 0x0600517D RID: 20861 RVA: 0x0001A628 File Offset: 0x00018828
		[Token(Token = "0x60043AE")]
		[Address(RVA = "0x27F9990", Offset = "0x27F9A91", VA = "0x27F9990", Slot = "58")]
		public bool Contains(TriangulationPoint p)
		{
			return default(bool);
		}

		// Token: 0x0600517E RID: 20862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043AF")]
		[Address(RVA = "0x27F9A00", Offset = "0x27F9B01", VA = "0x27F9A00", Slot = "59")]
		public void CopyTo(TriangulationPoint[] array, int arrayIndex)
		{
		}

		// Token: 0x0600517F RID: 20863 RVA: 0x0001A640 File Offset: 0x00018840
		[Token(Token = "0x60043B0")]
		[Address(RVA = "0x27F9C20", Offset = "0x27F9D21", VA = "0x27F9C20")]
		protected bool ConstrainPointToBounds(Point2D p)
		{
			return default(bool);
		}

		// Token: 0x06005180 RID: 20864 RVA: 0x0001A658 File Offset: 0x00018858
		[Token(Token = "0x60043B1")]
		[Address(RVA = "0x27F8FB0", Offset = "0x27F90B1", VA = "0x27F8FB0")]
		protected bool ConstrainPointToBounds(TriangulationPoint p)
		{
			return default(bool);
		}

		// Token: 0x06005181 RID: 20865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043B2")]
		[Address(RVA = "0x27F9E00", Offset = "0x27F9F01", VA = "0x27F9E00", Slot = "64")]
		public virtual void AddTriangle(DelaunayTriangle t)
		{
		}

		// Token: 0x06005182 RID: 20866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043B3")]
		[Address(RVA = "0x27F9ED0", Offset = "0x27F9FD1", VA = "0x27F9ED0", Slot = "46")]
		public void AddTriangles(IEnumerable<DelaunayTriangle> list)
		{
		}

		// Token: 0x06005183 RID: 20867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043B4")]
		[Address(RVA = "0x27FA150", Offset = "0x27FA251", VA = "0x27FA150", Slot = "47")]
		public void ClearTriangles()
		{
		}

		// Token: 0x06005184 RID: 20868 RVA: 0x0001A670 File Offset: 0x00018870
		[Token(Token = "0x60043B5")]
		[Address(RVA = "0x27FA210", Offset = "0x27FA311", VA = "0x27FA210", Slot = "65")]
		public virtual bool Initialize()
		{
			return default(bool);
		}

		// Token: 0x06005185 RID: 20869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043B6")]
		[Address(RVA = "0x27FA220", Offset = "0x27FA321", VA = "0x27FA220", Slot = "66")]
		public virtual void Prepare(TriangulationContext tcx)
		{
		}

		// Token: 0x0400B124 RID: 45348
		[Token(Token = "0x40084DA")]
		[FieldOffset(Offset = "0x30")]
		protected Dictionary<uint, TriangulationPoint> mPointMap;

		// Token: 0x0400B125 RID: 45349
		[Token(Token = "0x40084DB")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x177250", Offset = "0x177351")]
		private IList<DelaunayTriangle> <Triangles>k__BackingField;

		// Token: 0x0400B126 RID: 45350
		[Token(Token = "0x40084DC")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x177260", Offset = "0x177361")]
		private string <FileName>k__BackingField;

		// Token: 0x0400B127 RID: 45351
		[Token(Token = "0x40084DD")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x177270", Offset = "0x177371")]
		private bool <DisplayFlipX>k__BackingField;

		// Token: 0x0400B128 RID: 45352
		[Token(Token = "0x40084DE")]
		[FieldOffset(Offset = "0x49")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x177280", Offset = "0x177381")]
		private bool <DisplayFlipY>k__BackingField;

		// Token: 0x0400B129 RID: 45353
		[Token(Token = "0x40084DF")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x177290", Offset = "0x177391")]
		private float <DisplayRotate>k__BackingField;

		// Token: 0x0400B12A RID: 45354
		[Token(Token = "0x40084E0")]
		[FieldOffset(Offset = "0x50")]
		protected double mPrecision;
	}
}
