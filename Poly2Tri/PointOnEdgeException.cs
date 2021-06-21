using System;
using Il2CppDummyDll;

namespace Poly2Tri
{
	// Token: 0x02000C62 RID: 3170
	[Token(Token = "0x2000813")]
	public class PointOnEdgeException : NotImplementedException
	{
		// Token: 0x0600508C RID: 20620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042BD")]
		[Address(RVA = "0x27F86E0", Offset = "0x27F87E1", VA = "0x27F86E0")]
		public PointOnEdgeException(string message, TriangulationPoint a, TriangulationPoint b, TriangulationPoint c)
		{
		}

		// Token: 0x0400B0F1 RID: 45297
		[Token(Token = "0x40084B1")]
		[FieldOffset(Offset = "0x88")]
		public readonly TriangulationPoint A;

		// Token: 0x0400B0F2 RID: 45298
		[Token(Token = "0x40084B2")]
		[FieldOffset(Offset = "0x90")]
		public readonly TriangulationPoint B;

		// Token: 0x0400B0F3 RID: 45299
		[Token(Token = "0x40084B3")]
		[FieldOffset(Offset = "0x98")]
		public readonly TriangulationPoint C;
	}
}
