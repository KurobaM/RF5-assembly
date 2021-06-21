using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Poly2Tri
{
	// Token: 0x02000C84 RID: 3204
	[Token(Token = "0x2000831")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x1477E0", Offset = "0x1478E1")]
	public class Point2DList : IEnumerable<Point2D>, IEnumerable, IList<Point2D>, ICollection<Point2D>
	{
		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x0600524A RID: 21066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000879")]
		public Rect2D BoundingBox
		{
			[Token(Token = "0x600446B")]
			[Address(RVA = "0x27F3070", Offset = "0x27F3171", VA = "0x27F3070")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x0600524B RID: 21067 RVA: 0x0001AC40 File Offset: 0x00018E40
		// (set) Token: 0x0600524C RID: 21068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700087A")]
		public Point2DList.WindingOrderType WindingOrder
		{
			[Token(Token = "0x600446C")]
			[Address(RVA = "0x27F3080", Offset = "0x27F3181", VA = "0x27F3080")]
			get
			{
				return Point2DList.WindingOrderType.CW;
			}
			[Token(Token = "0x600446D")]
			[Address(RVA = "0x27F3090", Offset = "0x27F3191", VA = "0x27F3090")]
			set
			{
			}
		}

		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x0600524D RID: 21069 RVA: 0x0001AC58 File Offset: 0x00018E58
		[Token(Token = "0x1700087B")]
		public double Epsilon
		{
			[Token(Token = "0x600446E")]
			[Address(RVA = "0x27F3180", Offset = "0x27F3281", VA = "0x27F3180")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x0600524E RID: 21070 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600524F RID: 21071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700087C")]
		public Point2D Item
		{
			[Token(Token = "0x600446F")]
			[Address(RVA = "0x27F3190", Offset = "0x27F3291", VA = "0x27F3190", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004470")]
			[Address(RVA = "0x27F3210", Offset = "0x27F3311", VA = "0x27F3210", Slot = "7")]
			set
			{
			}
		}

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x06005250 RID: 21072 RVA: 0x0001AC70 File Offset: 0x00018E70
		[Token(Token = "0x1700087D")]
		public int Count
		{
			[Token(Token = "0x6004471")]
			[Address(RVA = "0x27F3280", Offset = "0x27F3381", VA = "0x27F3280", Slot = "11")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x06005251 RID: 21073 RVA: 0x0001AC88 File Offset: 0x00018E88
		[Token(Token = "0x1700087E")]
		public virtual bool IsReadOnly
		{
			[Token(Token = "0x6004472")]
			[Address(RVA = "0x27F32D0", Offset = "0x27F33D1", VA = "0x27F32D0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06005252 RID: 21074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004473")]
		[Address(RVA = "0x27F32E0", Offset = "0x27F33E1", VA = "0x27F32E0")]
		public Point2DList()
		{
		}

		// Token: 0x06005253 RID: 21075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004474")]
		[Address(RVA = "0x27F3420", Offset = "0x27F3521", VA = "0x27F3420")]
		public Point2DList(int capacity)
		{
		}

		// Token: 0x06005254 RID: 21076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004475")]
		[Address(RVA = "0x27F3540", Offset = "0x27F3641", VA = "0x27F3540")]
		public Point2DList(IList<Point2D> l)
		{
		}

		// Token: 0x06005255 RID: 21077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004476")]
		[Address(RVA = "0x27F36D0", Offset = "0x27F37D1", VA = "0x27F36D0")]
		public Point2DList(Point2DList l)
		{
		}

		// Token: 0x06005256 RID: 21078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004477")]
		[Address(RVA = "0x27F3950", Offset = "0x27F3A51", VA = "0x27F3950", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005257 RID: 21079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004478")]
		[Address(RVA = "0x27F3B70", Offset = "0x27F3C71", VA = "0x27F3B70", Slot = "5")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06005258 RID: 21080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004479")]
		[Address(RVA = "0x27F3C00", Offset = "0x27F3D01", VA = "0x27F3C00", Slot = "4")]
		private IEnumerator<Point2D> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06005259 RID: 21081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600447A")]
		[Address(RVA = "0x27F3C80", Offset = "0x27F3D81", VA = "0x27F3C80", Slot = "14")]
		public void Clear()
		{
		}

		// Token: 0x0600525A RID: 21082 RVA: 0x0001ACA0 File Offset: 0x00018EA0
		[Token(Token = "0x600447B")]
		[Address(RVA = "0x27F3D50", Offset = "0x27F3E51", VA = "0x27F3D50", Slot = "8")]
		public int IndexOf(Point2D p)
		{
			return 0;
		}

		// Token: 0x0600525B RID: 21083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600447C")]
		[Address(RVA = "0x27F3DC0", Offset = "0x27F3EC1", VA = "0x27F3DC0", Slot = "19")]
		public virtual void Add(Point2D p)
		{
		}

		// Token: 0x0600525C RID: 21084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600447D")]
		[Address(RVA = "0x27F3DE0", Offset = "0x27F3EE1", VA = "0x27F3DE0", Slot = "20")]
		protected virtual void Add(Point2D p, int idx, bool bCalcWindingOrderAndEpsilon)
		{
		}

		// Token: 0x0600525D RID: 21085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600447E")]
		[Address(RVA = "0x27F40D0", Offset = "0x27F41D1", VA = "0x27F40D0", Slot = "21")]
		public virtual void AddRange(Point2DList l)
		{
		}

		// Token: 0x0600525E RID: 21086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600447F")]
		[Address(RVA = "0x27F4190", Offset = "0x27F4291", VA = "0x27F4190", Slot = "22")]
		public virtual void AddRange(IEnumerator<Point2D> iter, Point2DList.WindingOrderType windingOrder)
		{
		}

		// Token: 0x0600525F RID: 21087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004480")]
		[Address(RVA = "0x27F4500", Offset = "0x27F4601", VA = "0x27F4500", Slot = "23")]
		public virtual void Insert(int idx, Point2D item)
		{
		}

		// Token: 0x06005260 RID: 21088 RVA: 0x0001ACB8 File Offset: 0x00018EB8
		[Token(Token = "0x6004481")]
		[Address(RVA = "0x27F4520", Offset = "0x27F4621", VA = "0x27F4520", Slot = "24")]
		public virtual bool Remove(Point2D p)
		{
			return default(bool);
		}

		// Token: 0x06005261 RID: 21089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004482")]
		[Address(RVA = "0x27F46E0", Offset = "0x27F47E1", VA = "0x27F46E0", Slot = "25")]
		public virtual void RemoveAt(int idx)
		{
		}

		// Token: 0x06005262 RID: 21090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004483")]
		[Address(RVA = "0x27F47A0", Offset = "0x27F48A1", VA = "0x27F47A0", Slot = "26")]
		public virtual void RemoveRange(int idxStart, int count)
		{
		}

		// Token: 0x06005263 RID: 21091 RVA: 0x0001ACD0 File Offset: 0x00018ED0
		[Token(Token = "0x6004484")]
		[Address(RVA = "0x27F4860", Offset = "0x27F4961", VA = "0x27F4860", Slot = "15")]
		public bool Contains(Point2D p)
		{
			return default(bool);
		}

		// Token: 0x06005264 RID: 21092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004485")]
		[Address(RVA = "0x27F48D0", Offset = "0x27F49D1", VA = "0x27F48D0", Slot = "16")]
		public void CopyTo(Point2D[] array, int arrayIndex)
		{
		}

		// Token: 0x06005265 RID: 21093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004486")]
		[Address(RVA = "0x27F45C0", Offset = "0x27F46C1", VA = "0x27F45C0")]
		public void CalculateBounds()
		{
		}

		// Token: 0x06005266 RID: 21094 RVA: 0x0001ACE8 File Offset: 0x00018EE8
		[Token(Token = "0x6004487")]
		[Address(RVA = "0x27F3FF0", Offset = "0x27F40F1", VA = "0x27F3FF0")]
		public double CalculateEpsilon()
		{
			return 0.0;
		}

		// Token: 0x06005267 RID: 21095 RVA: 0x0001AD00 File Offset: 0x00018F00
		[Token(Token = "0x6004488")]
		[Address(RVA = "0x27F3150", Offset = "0x27F3251", VA = "0x27F3150")]
		public Point2DList.WindingOrderType CalculateWindingOrder()
		{
			return Point2DList.WindingOrderType.CW;
		}

		// Token: 0x06005268 RID: 21096 RVA: 0x0001AD18 File Offset: 0x00018F18
		[Token(Token = "0x6004489")]
		[Address(RVA = "0x27F4CB0", Offset = "0x27F4DB1", VA = "0x27F4CB0")]
		public int NextIndex(int index)
		{
			return 0;
		}

		// Token: 0x06005269 RID: 21097 RVA: 0x0001AD30 File Offset: 0x00018F30
		[Token(Token = "0x600448A")]
		[Address(RVA = "0x27F4D20", Offset = "0x27F4E21", VA = "0x27F4D20")]
		public int PreviousIndex(int index)
		{
			return 0;
		}

		// Token: 0x0600526A RID: 21098 RVA: 0x0001AD48 File Offset: 0x00018F48
		[Token(Token = "0x600448B")]
		[Address(RVA = "0x27F4A80", Offset = "0x27F4B81", VA = "0x27F4A80")]
		public double GetSignedArea()
		{
			return 0.0;
		}

		// Token: 0x0600526B RID: 21099 RVA: 0x0001AD60 File Offset: 0x00018F60
		[Token(Token = "0x600448C")]
		[Address(RVA = "0x27F4D90", Offset = "0x27F4E91", VA = "0x27F4D90")]
		public double GetArea()
		{
			return 0.0;
		}

		// Token: 0x0600526C RID: 21100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600448D")]
		[Address(RVA = "0x27F4FD0", Offset = "0x27F50D1", VA = "0x27F4FD0")]
		public Point2D GetCentroid()
		{
			return null;
		}

		// Token: 0x0600526D RID: 21101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600448E")]
		[Address(RVA = "0x27F52B0", Offset = "0x27F53B1", VA = "0x27F52B0")]
		public void Translate(Point2D vector)
		{
		}

		// Token: 0x0600526E RID: 21102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600448F")]
		[Address(RVA = "0x27F53F0", Offset = "0x27F54F1", VA = "0x27F53F0")]
		public void Scale(Point2D value)
		{
		}

		// Token: 0x0600526F RID: 21103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004490")]
		[Address(RVA = "0x27F5530", Offset = "0x27F5631", VA = "0x27F5530")]
		public void Rotate(double radians)
		{
		}

		// Token: 0x06005270 RID: 21104 RVA: 0x0001AD78 File Offset: 0x00018F78
		[Token(Token = "0x6004491")]
		[Address(RVA = "0x27F5720", Offset = "0x27F5821", VA = "0x27F5720")]
		public bool IsDegenerate()
		{
			return default(bool);
		}

		// Token: 0x06005271 RID: 21105 RVA: 0x0001AD90 File Offset: 0x00018F90
		[Token(Token = "0x6004492")]
		[Address(RVA = "0x27F5B30", Offset = "0x27F5C31", VA = "0x27F5B30")]
		public bool IsConvex()
		{
			return default(bool);
		}

		// Token: 0x06005272 RID: 21106 RVA: 0x0001ADA8 File Offset: 0x00018FA8
		[Token(Token = "0x6004493")]
		[Address(RVA = "0x27F5F10", Offset = "0x27F6011", VA = "0x27F5F10")]
		public bool IsSimple()
		{
			return default(bool);
		}

		// Token: 0x06005273 RID: 21107 RVA: 0x0001ADC0 File Offset: 0x00018FC0
		[Token(Token = "0x6004494")]
		[Address(RVA = "0x27F61C0", Offset = "0x27F62C1", VA = "0x27F61C0")]
		public Point2DList.PolygonError CheckPolygon()
		{
			return Point2DList.PolygonError.None;
		}

		// Token: 0x06005274 RID: 21108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004495")]
		[Address(RVA = "0x27F6AE0", Offset = "0x27F6BE1", VA = "0x27F6AE0")]
		public static string GetErrorString(Point2DList.PolygonError error)
		{
			return null;
		}

		// Token: 0x06005275 RID: 21109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004496")]
		[Address(RVA = "0x27F7130", Offset = "0x27F7231", VA = "0x27F7130")]
		public void RemoveDuplicateNeighborPoints()
		{
		}

		// Token: 0x06005276 RID: 21110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004497")]
		[Address(RVA = "0x27F7340", Offset = "0x27F7441", VA = "0x27F7340")]
		public void Simplify()
		{
		}

		// Token: 0x06005277 RID: 21111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004498")]
		[Address(RVA = "0x27F7350", Offset = "0x27F7451", VA = "0x27F7350")]
		public void Simplify(double bias)
		{
		}

		// Token: 0x06005278 RID: 21112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004499")]
		[Address(RVA = "0x27F7660", Offset = "0x27F7761", VA = "0x27F7660")]
		public void MergeParallelEdges(double tolerance)
		{
		}

		// Token: 0x06005279 RID: 21113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600449A")]
		[Address(RVA = "0x27F7F60", Offset = "0x27F8061", VA = "0x27F7F60")]
		public void ProjectToAxis(Point2D axis, out double min, out double max)
		{
		}

		// Token: 0x0400B15B RID: 45403
		[Token(Token = "0x4008505")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int kMaxPolygonVertices;

		// Token: 0x0400B15C RID: 45404
		[Token(Token = "0x4008506")]
		[FieldOffset(Offset = "0x8")]
		public static readonly double kLinearSlop;

		// Token: 0x0400B15D RID: 45405
		[Token(Token = "0x4008507")]
		[FieldOffset(Offset = "0x10")]
		public static readonly double kAngularSlop;

		// Token: 0x0400B15E RID: 45406
		[Token(Token = "0x4008508")]
		[FieldOffset(Offset = "0x10")]
		protected List<Point2D> mPoints;

		// Token: 0x0400B15F RID: 45407
		[Token(Token = "0x4008509")]
		[FieldOffset(Offset = "0x18")]
		protected Rect2D mBoundingBox;

		// Token: 0x0400B160 RID: 45408
		[Token(Token = "0x400850A")]
		[FieldOffset(Offset = "0x20")]
		protected Point2DList.WindingOrderType mWindingOrder;

		// Token: 0x0400B161 RID: 45409
		[Token(Token = "0x400850B")]
		[FieldOffset(Offset = "0x28")]
		protected double mEpsilon;

		// Token: 0x02000C85 RID: 3205
		[Token(Token = "0x20013CC")]
		public enum WindingOrderType
		{
			// Token: 0x0400B163 RID: 45411
			[Token(Token = "0x401B89B")]
			CW,
			// Token: 0x0400B164 RID: 45412
			[Token(Token = "0x401B89C")]
			CCW,
			// Token: 0x0400B165 RID: 45413
			[Token(Token = "0x401B89D")]
			Unknown,
			// Token: 0x0400B166 RID: 45414
			[Token(Token = "0x401B89E")]
			Default = 1
		}

		// Token: 0x02000C86 RID: 3206
		[Token(Token = "0x20013CD")]
		[Flags]
		public enum PolygonError : uint
		{
			// Token: 0x0400B168 RID: 45416
			[Token(Token = "0x401B8A0")]
			None = 0U,
			// Token: 0x0400B169 RID: 45417
			[Token(Token = "0x401B8A1")]
			NotEnoughVertices = 1U,
			// Token: 0x0400B16A RID: 45418
			[Token(Token = "0x401B8A2")]
			NotConvex = 2U,
			// Token: 0x0400B16B RID: 45419
			[Token(Token = "0x401B8A3")]
			NotSimple = 4U,
			// Token: 0x0400B16C RID: 45420
			[Token(Token = "0x401B8A4")]
			AreaTooSmall = 8U,
			// Token: 0x0400B16D RID: 45421
			[Token(Token = "0x401B8A5")]
			SidesTooCloseToParallel = 16U,
			// Token: 0x0400B16E RID: 45422
			[Token(Token = "0x401B8A6")]
			TooThin = 32U,
			// Token: 0x0400B16F RID: 45423
			[Token(Token = "0x401B8A7")]
			Degenerate = 64U,
			// Token: 0x0400B170 RID: 45424
			[Token(Token = "0x401B8A8")]
			Unknown = 1073741824U
		}
	}
}
