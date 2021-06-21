using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Poly2Tri
{
	// Token: 0x02000C65 RID: 3173
	[Token(Token = "0x2000816")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x147660", Offset = "0x147761")]
	public class Contour : Point2DList, ITriangulatable, IEnumerable<TriangulationPoint>, IEnumerable, IList<TriangulationPoint>, ICollection<TriangulationPoint>
	{
		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x060050A2 RID: 20642 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060050A3 RID: 20643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000826")]
		public new TriangulationPoint Item
		{
			[Token(Token = "0x60042D3")]
			[Address(RVA = "0x24A1C20", Offset = "0x24A1D21", VA = "0x24A1C20", Slot = "49")]
			get
			{
				return null;
			}
			[Token(Token = "0x60042D4")]
			[Address(RVA = "0x24A40A0", Offset = "0x24A41A1", VA = "0x24A40A0", Slot = "50")]
			set
			{
			}
		}

		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x060050A4 RID: 20644 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060050A5 RID: 20645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000827")]
		public string Name
		{
			[Token(Token = "0x60042D5")]
			[Address(RVA = "0x24A4110", Offset = "0x24A4211", VA = "0x24A4110")]
			get
			{
				return null;
			}
			[Token(Token = "0x60042D6")]
			[Address(RVA = "0x24A4120", Offset = "0x24A4221", VA = "0x24A4120")]
			set
			{
			}
		}

		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x060050A6 RID: 20646 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060050A7 RID: 20647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000828")]
		public IList<DelaunayTriangle> Triangles
		{
			[Token(Token = "0x60042D7")]
			[Address(RVA = "0x24A4130", Offset = "0x24A4231", VA = "0x24A4130", Slot = "27")]
			get
			{
				return null;
			}
			[Token(Token = "0x60042D8")]
			[Address(RVA = "0x24A41A0", Offset = "0x24A42A1", VA = "0x24A41A0")]
			private set
			{
			}
		}

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x060050A8 RID: 20648 RVA: 0x00019EC0 File Offset: 0x000180C0
		[Token(Token = "0x17000829")]
		public TriangulationMode TriangulationMode
		{
			[Token(Token = "0x60042D9")]
			[Address(RVA = "0x24A41B0", Offset = "0x24A42B1", VA = "0x24A41B0", Slot = "28")]
			get
			{
				return TriangulationMode.Unconstrained;
			}
		}

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x060050A9 RID: 20649 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060050AA RID: 20650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700082A")]
		public string FileName
		{
			[Token(Token = "0x60042DA")]
			[Address(RVA = "0x24A4270", Offset = "0x24A4371", VA = "0x24A4270", Slot = "29")]
			get
			{
				return null;
			}
			[Token(Token = "0x60042DB")]
			[Address(RVA = "0x24A4330", Offset = "0x24A4431", VA = "0x24A4330", Slot = "30")]
			set
			{
			}
		}

		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x060050AB RID: 20651 RVA: 0x00019ED8 File Offset: 0x000180D8
		// (set) Token: 0x060050AC RID: 20652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700082B")]
		public bool DisplayFlipX
		{
			[Token(Token = "0x60042DC")]
			[Address(RVA = "0x24A4340", Offset = "0x24A4441", VA = "0x24A4340", Slot = "31")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60042DD")]
			[Address(RVA = "0x24A4400", Offset = "0x24A4501", VA = "0x24A4400", Slot = "32")]
			set
			{
			}
		}

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x060050AD RID: 20653 RVA: 0x00019EF0 File Offset: 0x000180F0
		// (set) Token: 0x060050AE RID: 20654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700082C")]
		public bool DisplayFlipY
		{
			[Token(Token = "0x60042DE")]
			[Address(RVA = "0x24A4410", Offset = "0x24A4511", VA = "0x24A4410", Slot = "33")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60042DF")]
			[Address(RVA = "0x24A44D0", Offset = "0x24A45D1", VA = "0x24A44D0", Slot = "34")]
			set
			{
			}
		}

		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x060050AF RID: 20655 RVA: 0x00019F08 File Offset: 0x00018108
		// (set) Token: 0x060050B0 RID: 20656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700082D")]
		public float DisplayRotate
		{
			[Token(Token = "0x60042E0")]
			[Address(RVA = "0x24A44E0", Offset = "0x24A45E1", VA = "0x24A44E0", Slot = "35")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60042E1")]
			[Address(RVA = "0x24A45A0", Offset = "0x24A46A1", VA = "0x24A45A0", Slot = "36")]
			set
			{
			}
		}

		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x060050B1 RID: 20657 RVA: 0x00019F20 File Offset: 0x00018120
		// (set) Token: 0x060050B2 RID: 20658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700082E")]
		public double Precision
		{
			[Token(Token = "0x60042E2")]
			[Address(RVA = "0x24A45B0", Offset = "0x24A46B1", VA = "0x24A45B0", Slot = "37")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x60042E3")]
			[Address(RVA = "0x24A4670", Offset = "0x24A4771", VA = "0x24A4670", Slot = "38")]
			set
			{
			}
		}

		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x060050B3 RID: 20659 RVA: 0x00019F38 File Offset: 0x00018138
		[Token(Token = "0x1700082F")]
		public double MinX
		{
			[Token(Token = "0x60042E4")]
			[Address(RVA = "0x24A4680", Offset = "0x24A4781", VA = "0x24A4680", Slot = "39")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x060050B4 RID: 20660 RVA: 0x00019F50 File Offset: 0x00018150
		[Token(Token = "0x17000830")]
		public double MaxX
		{
			[Token(Token = "0x60042E5")]
			[Address(RVA = "0x24A46A0", Offset = "0x24A47A1", VA = "0x24A46A0", Slot = "40")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x060050B5 RID: 20661 RVA: 0x00019F68 File Offset: 0x00018168
		[Token(Token = "0x17000831")]
		public double MinY
		{
			[Token(Token = "0x60042E6")]
			[Address(RVA = "0x24A46C0", Offset = "0x24A47C1", VA = "0x24A46C0", Slot = "41")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x060050B6 RID: 20662 RVA: 0x00019F80 File Offset: 0x00018180
		[Token(Token = "0x17000832")]
		public double MaxY
		{
			[Token(Token = "0x60042E7")]
			[Address(RVA = "0x24A46E0", Offset = "0x24A47E1", VA = "0x24A46E0", Slot = "42")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x060050B7 RID: 20663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000833")]
		public Rect2D Bounds
		{
			[Token(Token = "0x60042E8")]
			[Address(RVA = "0x24A4700", Offset = "0x24A4801", VA = "0x24A4700", Slot = "43")]
			get
			{
				return null;
			}
		}

		// Token: 0x060050B8 RID: 20664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042E9")]
		[Address(RVA = "0x24A1D00", Offset = "0x24A1E01", VA = "0x24A1D00")]
		public Contour(ITriangulatable parent)
		{
		}

		// Token: 0x060050B9 RID: 20665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042EA")]
		[Address(RVA = "0x24A1B20", Offset = "0x24A1C21", VA = "0x24A1B20")]
		public Contour(ITriangulatable parent, IList<TriangulationPoint> points, Point2DList.WindingOrderType windingOrder)
		{
		}

		// Token: 0x060050BA RID: 20666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042EB")]
		[Address(RVA = "0x24A4A80", Offset = "0x24A4B81", VA = "0x24A4A80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060050BB RID: 20667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042EC")]
		[Address(RVA = "0x24A4AF0", Offset = "0x24A4BF1", VA = "0x24A4AF0", Slot = "48")]
		private IEnumerator<TriangulationPoint> GetEnumerator()
		{
			return null;
		}

		// Token: 0x060050BC RID: 20668 RVA: 0x00019F98 File Offset: 0x00018198
		[Token(Token = "0x60042ED")]
		[Address(RVA = "0x24A4B60", Offset = "0x24A4C61", VA = "0x24A4B60", Slot = "51")]
		public int IndexOf(TriangulationPoint p)
		{
			return 0;
		}

		// Token: 0x060050BD RID: 20669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042EE")]
		[Address(RVA = "0x24A4BD0", Offset = "0x24A4CD1", VA = "0x24A4BD0", Slot = "56")]
		public void Add(TriangulationPoint p)
		{
		}

		// Token: 0x060050BE RID: 20670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042EF")]
		[Address(RVA = "0x24A4BF0", Offset = "0x24A4CF1", VA = "0x24A4BF0", Slot = "20")]
		protected override void Add(Point2D p, int idx, bool bCalcWindingOrderAndEpsilon)
		{
		}

		// Token: 0x060050BF RID: 20671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042F0")]
		[Address(RVA = "0x24A4D60", Offset = "0x24A4E61", VA = "0x24A4D60", Slot = "22")]
		public override void AddRange(IEnumerator<Point2D> iter, Point2DList.WindingOrderType windingOrder)
		{
		}

		// Token: 0x060050C0 RID: 20672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042F1")]
		[Address(RVA = "0x24A4710", Offset = "0x24A4811", VA = "0x24A4710")]
		public void AddRange(IList<TriangulationPoint> points, Point2DList.WindingOrderType windingOrder)
		{
		}

		// Token: 0x060050C1 RID: 20673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042F2")]
		[Address(RVA = "0x24A5260", Offset = "0x24A5361", VA = "0x24A5260", Slot = "52")]
		public void Insert(int idx, TriangulationPoint p)
		{
		}

		// Token: 0x060050C2 RID: 20674 RVA: 0x00019FB0 File Offset: 0x000181B0
		[Token(Token = "0x60042F3")]
		[Address(RVA = "0x24A5280", Offset = "0x24A5381", VA = "0x24A5280", Slot = "60")]
		public bool Remove(TriangulationPoint p)
		{
			return default(bool);
		}

		// Token: 0x060050C3 RID: 20675 RVA: 0x00019FC8 File Offset: 0x000181C8
		[Token(Token = "0x60042F4")]
		[Address(RVA = "0x24A5290", Offset = "0x24A5391", VA = "0x24A5290", Slot = "58")]
		public bool Contains(TriangulationPoint p)
		{
			return default(bool);
		}

		// Token: 0x060050C4 RID: 20676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042F5")]
		[Address(RVA = "0x24A5300", Offset = "0x24A5401", VA = "0x24A5300", Slot = "59")]
		public void CopyTo(TriangulationPoint[] array, int arrayIndex)
		{
		}

		// Token: 0x060050C5 RID: 20677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042F6")]
		[Address(RVA = "0x24A54F0", Offset = "0x24A55F1", VA = "0x24A54F0")]
		protected void AddHole(Contour c)
		{
		}

		// Token: 0x060050C6 RID: 20678 RVA: 0x00019FE0 File Offset: 0x000181E0
		[Token(Token = "0x60042F7")]
		[Address(RVA = "0x24A2040", Offset = "0x24A2141", VA = "0x24A2040")]
		public int GetNumHoles(bool parentIsHole)
		{
			return 0;
		}

		// Token: 0x060050C7 RID: 20679 RVA: 0x00019FF8 File Offset: 0x000181F8
		[Token(Token = "0x60042F8")]
		[Address(RVA = "0x24A5570", Offset = "0x24A5671", VA = "0x24A5570")]
		public int GetNumHoles()
		{
			return 0;
		}

		// Token: 0x060050C8 RID: 20680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042F9")]
		[Address(RVA = "0x24A55C0", Offset = "0x24A56C1", VA = "0x24A55C0")]
		public Contour GetHole(int idx)
		{
			return null;
		}

		// Token: 0x060050C9 RID: 20681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042FA")]
		[Address(RVA = "0x24A2380", Offset = "0x24A2481", VA = "0x24A2380")]
		public void GetActualHoles(bool parentIsHole, ref List<Contour> holes)
		{
		}

		// Token: 0x060050CA RID: 20682 RVA: 0x0001A010 File Offset: 0x00018210
		[Token(Token = "0x60042FB")]
		[Address(RVA = "0x24A5670", Offset = "0x24A5771", VA = "0x24A5670")]
		public List<Contour>.Enumerator GetHoleEnumerator()
		{
			return default(List<Contour>.Enumerator);
		}

		// Token: 0x060050CB RID: 20683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042FC")]
		[Address(RVA = "0x24A3D30", Offset = "0x24A3E31", VA = "0x24A3D30")]
		public void InitializeHoles(ConstrainedPointSet cps)
		{
		}

		// Token: 0x060050CC RID: 20684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042FD")]
		[Address(RVA = "0x24A25F0", Offset = "0x24A26F1", VA = "0x24A25F0")]
		public static void InitializeHoles(List<Contour> holes, ITriangulatable parent, ConstrainedPointSet cps)
		{
		}

		// Token: 0x060050CD RID: 20685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042FE")]
		[Address(RVA = "0x24A56E0", Offset = "0x24A57E1", VA = "0x24A56E0", Slot = "44")]
		public void Prepare(TriangulationContext tcx)
		{
		}

		// Token: 0x060050CE RID: 20686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042FF")]
		[Address(RVA = "0x24A5750", Offset = "0x24A5851", VA = "0x24A5750", Slot = "45")]
		public void AddTriangle(DelaunayTriangle t)
		{
		}

		// Token: 0x060050CF RID: 20687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004300")]
		[Address(RVA = "0x24A57C0", Offset = "0x24A58C1", VA = "0x24A57C0", Slot = "46")]
		public void AddTriangles(IEnumerable<DelaunayTriangle> list)
		{
		}

		// Token: 0x060050D0 RID: 20688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004301")]
		[Address(RVA = "0x24A5830", Offset = "0x24A5931", VA = "0x24A5830", Slot = "47")]
		public void ClearTriangles()
		{
		}

		// Token: 0x060050D1 RID: 20689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004302")]
		[Address(RVA = "0x24A58A0", Offset = "0x24A59A1", VA = "0x24A58A0")]
		public Point2D FindPointInContour()
		{
			return null;
		}

		// Token: 0x060050D2 RID: 20690 RVA: 0x0001A028 File Offset: 0x00018228
		[Token(Token = "0x6004303")]
		[Address(RVA = "0x24A59E0", Offset = "0x24A5AE1", VA = "0x24A59E0")]
		public bool IsPointInsideContour(Point2D p)
		{
			return default(bool);
		}

		// Token: 0x0400B0F8 RID: 45304
		[Token(Token = "0x40084B8")]
		[FieldOffset(Offset = "0x30")]
		private List<Contour> mHoles;

		// Token: 0x0400B0F9 RID: 45305
		[Token(Token = "0x40084B9")]
		[FieldOffset(Offset = "0x38")]
		private ITriangulatable mParent;

		// Token: 0x0400B0FA RID: 45306
		[Token(Token = "0x40084BA")]
		[FieldOffset(Offset = "0x40")]
		private string mName;
	}
}
