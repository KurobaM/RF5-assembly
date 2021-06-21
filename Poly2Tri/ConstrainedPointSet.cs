using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Poly2Tri
{
	// Token: 0x02000C6F RID: 3183
	[Token(Token = "0x200081E")]
	public class ConstrainedPointSet : PointSet
	{
		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x06005144 RID: 20804 RVA: 0x0001A3B8 File Offset: 0x000185B8
		[Token(Token = "0x1700084F")]
		public override TriangulationMode TriangulationMode
		{
			[Token(Token = "0x6004375")]
			[Address(RVA = "0x24A0380", Offset = "0x24A0481", VA = "0x24A0380", Slot = "61")]
			get
			{
				return TriangulationMode.Unconstrained;
			}
		}

		// Token: 0x06005145 RID: 20805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004376")]
		[Address(RVA = "0x24A0390", Offset = "0x24A0491", VA = "0x24A0390")]
		public ConstrainedPointSet(List<TriangulationPoint> bounds)
		{
		}

		// Token: 0x06005146 RID: 20806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004377")]
		[Address(RVA = "0x24A07F0", Offset = "0x24A08F1", VA = "0x24A07F0")]
		public ConstrainedPointSet(List<TriangulationPoint> bounds, List<TriangulationConstraint> constraints)
		{
		}

		// Token: 0x06005147 RID: 20807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004378")]
		[Address(RVA = "0x24A0B00", Offset = "0x24A0C01", VA = "0x24A0B00")]
		public ConstrainedPointSet(List<TriangulationPoint> bounds, int[] indices)
		{
		}

		// Token: 0x06005148 RID: 20808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004379")]
		[Address(RVA = "0x24A0460", Offset = "0x24A0561", VA = "0x24A0460")]
		protected void AddBoundaryConstraints()
		{
		}

		// Token: 0x06005149 RID: 20809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600437A")]
		[Address(RVA = "0x24A0FB0", Offset = "0x24A10B1", VA = "0x24A0FB0", Slot = "19")]
		public override void Add(Point2D p)
		{
		}

		// Token: 0x0600514A RID: 20810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600437B")]
		[Address(RVA = "0x24A1050", Offset = "0x24A1151", VA = "0x24A1050", Slot = "62")]
		public override void Add(TriangulationPoint p)
		{
		}

		// Token: 0x0600514B RID: 20811 RVA: 0x0001A3D0 File Offset: 0x000185D0
		[Token(Token = "0x600437C")]
		[Address(RVA = "0x24A1060", Offset = "0x24A1161", VA = "0x24A1060", Slot = "63")]
		public override bool AddRange(List<TriangulationPoint> points)
		{
			return default(bool);
		}

		// Token: 0x0600514C RID: 20812 RVA: 0x0001A3E8 File Offset: 0x000185E8
		[Token(Token = "0x600437D")]
		[Address(RVA = "0x24A1180", Offset = "0x24A1281", VA = "0x24A1180")]
		public bool AddHole(List<TriangulationPoint> points, string name)
		{
			return default(bool);
		}

		// Token: 0x0600514D RID: 20813 RVA: 0x0001A400 File Offset: 0x00018600
		[Token(Token = "0x600437E")]
		[Address(RVA = "0x24A08D0", Offset = "0x24A09D1", VA = "0x24A08D0")]
		public bool AddConstraints(List<TriangulationConstraint> constraints)
		{
			return default(bool);
		}

		// Token: 0x0600514E RID: 20814 RVA: 0x0001A418 File Offset: 0x00018618
		[Token(Token = "0x600437F")]
		[Address(RVA = "0x24A0DA0", Offset = "0x24A0EA1", VA = "0x24A0DA0")]
		public bool AddConstraint(TriangulationConstraint tc)
		{
			return default(bool);
		}

		// Token: 0x0600514F RID: 20815 RVA: 0x0001A430 File Offset: 0x00018630
		[Token(Token = "0x6004380")]
		[Address(RVA = "0x24A1DE0", Offset = "0x24A1EE1", VA = "0x24A1DE0")]
		public bool TryGetConstraint(uint constraintCode, out TriangulationConstraint tc)
		{
			return default(bool);
		}

		// Token: 0x06005150 RID: 20816 RVA: 0x0001A448 File Offset: 0x00018648
		[Token(Token = "0x6004381")]
		[Address(RVA = "0x24A1E50", Offset = "0x24A1F51", VA = "0x24A1E50")]
		public int GetNumConstraints()
		{
			return 0;
		}

		// Token: 0x06005151 RID: 20817 RVA: 0x0001A460 File Offset: 0x00018660
		[Token(Token = "0x6004382")]
		[Address(RVA = "0x24A1EB0", Offset = "0x24A1FB1", VA = "0x24A1EB0")]
		public Dictionary<uint, TriangulationConstraint>.Enumerator GetConstraintEnumerator()
		{
			return default(Dictionary<uint, TriangulationConstraint>.Enumerator);
		}

		// Token: 0x06005152 RID: 20818 RVA: 0x0001A478 File Offset: 0x00018678
		[Token(Token = "0x6004383")]
		[Address(RVA = "0x24A1F20", Offset = "0x24A2021", VA = "0x24A1F20")]
		public int GetNumHoles()
		{
			return 0;
		}

		// Token: 0x06005153 RID: 20819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004384")]
		[Address(RVA = "0x24A2170", Offset = "0x24A2271", VA = "0x24A2170")]
		public Contour GetHole(int idx)
		{
			return null;
		}

		// Token: 0x06005154 RID: 20820 RVA: 0x0001A490 File Offset: 0x00018690
		[Token(Token = "0x6004385")]
		[Address(RVA = "0x24A2220", Offset = "0x24A2321", VA = "0x24A2220")]
		public int GetActualHoles(out List<Contour> holes)
		{
			return 0;
		}

		// Token: 0x06005155 RID: 20821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004386")]
		[Address(RVA = "0x24A24D0", Offset = "0x24A25D1", VA = "0x24A24D0")]
		protected void InitializeHoles()
		{
		}

		// Token: 0x06005156 RID: 20822 RVA: 0x0001A4A8 File Offset: 0x000186A8
		[Token(Token = "0x6004387")]
		[Address(RVA = "0x24A3E60", Offset = "0x24A3F61", VA = "0x24A3E60", Slot = "65")]
		public override bool Initialize()
		{
			return default(bool);
		}

		// Token: 0x06005157 RID: 20823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004388")]
		[Address(RVA = "0x24A3E90", Offset = "0x24A3F91", VA = "0x24A3E90", Slot = "66")]
		public override void Prepare(TriangulationContext tcx)
		{
		}

		// Token: 0x06005158 RID: 20824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004389")]
		[Address(RVA = "0x24A3FD0", Offset = "0x24A40D1", VA = "0x24A3FD0", Slot = "64")]
		public override void AddTriangle(DelaunayTriangle t)
		{
		}

		// Token: 0x0400B122 RID: 45346
		[Token(Token = "0x40084D8")]
		[FieldOffset(Offset = "0x58")]
		protected Dictionary<uint, TriangulationConstraint> mConstraintMap;

		// Token: 0x0400B123 RID: 45347
		[Token(Token = "0x40084D9")]
		[FieldOffset(Offset = "0x60")]
		protected List<Contour> mHoles;
	}
}
