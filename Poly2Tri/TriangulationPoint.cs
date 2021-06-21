using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Poly2Tri
{
	// Token: 0x02000C77 RID: 3191
	[Token(Token = "0x2000826")]
	public class TriangulationPoint : Point2D
	{
		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x060051A9 RID: 20905 RVA: 0x0001A700 File Offset: 0x00018900
		// (set) Token: 0x060051AA RID: 20906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700086A")]
		public override double X
		{
			[Token(Token = "0x60043DA")]
			[Address(RVA = "0x2807440", Offset = "0x2807541", VA = "0x2807440", Slot = "5")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x60043DB")]
			[Address(RVA = "0x2807450", Offset = "0x2807551", VA = "0x2807450", Slot = "6")]
			set
			{
			}
		}

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x060051AB RID: 20907 RVA: 0x0001A718 File Offset: 0x00018918
		// (set) Token: 0x060051AC RID: 20908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700086B")]
		public override double Y
		{
			[Token(Token = "0x60043DC")]
			[Address(RVA = "0x28074F0", Offset = "0x28075F1", VA = "0x28074F0", Slot = "7")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x60043DD")]
			[Address(RVA = "0x2807500", Offset = "0x2807601", VA = "0x2807500", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x060051AD RID: 20909 RVA: 0x0001A730 File Offset: 0x00018930
		[Token(Token = "0x1700086C")]
		public uint VertexCode
		{
			[Token(Token = "0x60043DE")]
			[Address(RVA = "0x28075A0", Offset = "0x28076A1", VA = "0x28075A0")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x060051AE RID: 20910 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060051AF RID: 20911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700086D")]
		public List<DTSweepConstraint> Edges
		{
			[Token(Token = "0x60043DF")]
			[Address(RVA = "0x28075B0", Offset = "0x28076B1", VA = "0x28075B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9500", Offset = "0x1A9601")]
			get
			{
				return null;
			}
			[Token(Token = "0x60043E0")]
			[Address(RVA = "0x28075C0", Offset = "0x28076C1", VA = "0x28075C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9510", Offset = "0x1A9611")]
			private set
			{
			}
		}

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x060051B0 RID: 20912 RVA: 0x0001A748 File Offset: 0x00018948
		[Token(Token = "0x1700086E")]
		public bool HasEdges
		{
			[Token(Token = "0x60043E1")]
			[Address(RVA = "0x28075D0", Offset = "0x28076D1", VA = "0x28075D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060051B1 RID: 20913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043E2")]
		[Address(RVA = "0x27F8410", Offset = "0x27F8511", VA = "0x27F8410")]
		public TriangulationPoint(double x, double y)
		{
		}

		// Token: 0x060051B2 RID: 20914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043E3")]
		[Address(RVA = "0x28075E0", Offset = "0x28076E1", VA = "0x28075E0")]
		public TriangulationPoint(double x, double y, double precision)
		{
		}

		// Token: 0x060051B3 RID: 20915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043E4")]
		[Address(RVA = "0x2807680", Offset = "0x2807781", VA = "0x2807680", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060051B4 RID: 20916 RVA: 0x0001A760 File Offset: 0x00018960
		[Token(Token = "0x60043E5")]
		[Address(RVA = "0x2807700", Offset = "0x2807801", VA = "0x2807700", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060051B5 RID: 20917 RVA: 0x0001A778 File Offset: 0x00018978
		[Token(Token = "0x60043E6")]
		[Address(RVA = "0x2807710", Offset = "0x2807811", VA = "0x2807710", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060051B6 RID: 20918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043E7")]
		[Address(RVA = "0x2807840", Offset = "0x2807941", VA = "0x2807840", Slot = "9")]
		public override void Set(double x, double y)
		{
		}

		// Token: 0x060051B7 RID: 20919 RVA: 0x0001A790 File Offset: 0x00018990
		[Token(Token = "0x60043E8")]
		[Address(RVA = "0x27F9540", Offset = "0x27F9641", VA = "0x27F9540")]
		public static uint CreateVertexCode(double x, double y, double precision)
		{
			return 0U;
		}

		// Token: 0x060051B8 RID: 20920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043E9")]
		[Address(RVA = "0x28078F0", Offset = "0x28079F1", VA = "0x28078F0")]
		public void AddEdge(DTSweepConstraint e)
		{
		}

		// Token: 0x060051B9 RID: 20921 RVA: 0x0001A7A8 File Offset: 0x000189A8
		[Token(Token = "0x60043EA")]
		[Address(RVA = "0x28079A0", Offset = "0x2807AA1", VA = "0x28079A0")]
		public bool HasEdge(TriangulationPoint p)
		{
			return default(bool);
		}

		// Token: 0x060051BA RID: 20922 RVA: 0x0001A7C0 File Offset: 0x000189C0
		[Token(Token = "0x60043EB")]
		[Address(RVA = "0x28079D0", Offset = "0x2807AD1", VA = "0x28079D0")]
		public bool GetEdge(TriangulationPoint p, out DTSweepConstraint edge)
		{
			return default(bool);
		}

		// Token: 0x060051BB RID: 20923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043EC")]
		[Address(RVA = "0x2807DA0", Offset = "0x2807EA1", VA = "0x2807DA0")]
		public static Point2D ToPoint2D(TriangulationPoint p)
		{
			return null;
		}

		// Token: 0x0400B13C RID: 45372
		[Token(Token = "0x40084F2")]
		[FieldOffset(Offset = "0x0")]
		public static readonly double kVertexCodeDefaultPrecision;

		// Token: 0x0400B13D RID: 45373
		[Token(Token = "0x40084F3")]
		[FieldOffset(Offset = "0x20")]
		protected uint mVertexCode;

		// Token: 0x0400B13E RID: 45374
		[Token(Token = "0x40084F4")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1772F0", Offset = "0x1773F1")]
		private List<DTSweepConstraint> <Edges>k__BackingField;
	}
}
