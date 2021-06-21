using System;
using Il2CppDummyDll;

namespace Poly2Tri
{
	// Token: 0x02000C57 RID: 3159
	[Token(Token = "0x2000808")]
	public static class P2T
	{
		// Token: 0x06005000 RID: 20480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004231")]
		[Address(RVA = "0x27EFE10", Offset = "0x27EFF11", VA = "0x27EFE10")]
		public static void Triangulate(PolygonSet ps)
		{
		}

		// Token: 0x06005001 RID: 20481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004232")]
		[Address(RVA = "0x27F0100", Offset = "0x27F0201", VA = "0x27F0100")]
		public static void Triangulate(Polygon p)
		{
		}

		// Token: 0x06005002 RID: 20482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004233")]
		[Address(RVA = "0x27F02C0", Offset = "0x27F03C1", VA = "0x27F02C0")]
		public static void Triangulate(ConstrainedPointSet cps)
		{
		}

		// Token: 0x06005003 RID: 20483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004234")]
		[Address(RVA = "0x27F0330", Offset = "0x27F0431", VA = "0x27F0330")]
		public static void Triangulate(PointSet ps)
		{
		}

		// Token: 0x06005004 RID: 20484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004235")]
		[Address(RVA = "0x27F03A0", Offset = "0x27F04A1", VA = "0x27F03A0")]
		public static TriangulationContext CreateContext(TriangulationAlgorithm algorithm)
		{
			return null;
		}

		// Token: 0x06005005 RID: 20485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004236")]
		[Address(RVA = "0x27F0170", Offset = "0x27F0271", VA = "0x27F0170")]
		public static void Triangulate(TriangulationAlgorithm algorithm, ITriangulatable t)
		{
		}

		// Token: 0x06005006 RID: 20486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004237")]
		[Address(RVA = "0x27F0400", Offset = "0x27F0501", VA = "0x27F0400")]
		public static void Triangulate(TriangulationContext tcx)
		{
		}

		// Token: 0x06005007 RID: 20487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004238")]
		[Address(RVA = "0x27F04A0", Offset = "0x27F05A1", VA = "0x27F04A0")]
		public static void Warmup()
		{
		}

		// Token: 0x0400B0CE RID: 45262
		[Token(Token = "0x400848E")]
		[FieldOffset(Offset = "0x0")]
		private static TriangulationAlgorithm _defaultAlgorithm;
	}
}
