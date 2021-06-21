using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Poly2Tri
{
	// Token: 0x02000C7A RID: 3194
	[Token(Token = "0x2000829")]
	public class PointGenerator
	{
		// Token: 0x060051C4 RID: 20932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043F5")]
		[Address(RVA = "0x27F8220", Offset = "0x27F8321", VA = "0x27F8220")]
		public static List<TriangulationPoint> UniformDistribution(int n, double scale)
		{
			return null;
		}

		// Token: 0x060051C5 RID: 20933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043F6")]
		[Address(RVA = "0x27F8500", Offset = "0x27F8601", VA = "0x27F8500")]
		public static List<TriangulationPoint> UniformGrid(int n, double scale)
		{
			return null;
		}

		// Token: 0x060051C6 RID: 20934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043F7")]
		[Address(RVA = "0x27F8660", Offset = "0x27F8761", VA = "0x27F8660")]
		public PointGenerator()
		{
		}

		// Token: 0x0400B141 RID: 45377
		[Token(Token = "0x40084F7")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Random RNG;
	}
}
