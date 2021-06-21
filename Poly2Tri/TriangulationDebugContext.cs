using System;
using Il2CppDummyDll;

namespace Poly2Tri
{
	// Token: 0x02000C75 RID: 3189
	[Token(Token = "0x2000824")]
	public abstract class TriangulationDebugContext
	{
		// Token: 0x060051A7 RID: 20903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043D8")]
		[Address(RVA = "0x2807400", Offset = "0x2807501", VA = "0x2807400")]
		public TriangulationDebugContext(TriangulationContext tcx)
		{
		}

		// Token: 0x060051A8 RID: 20904
		[Token(Token = "0x60043D9")]
		public abstract void Clear();

		// Token: 0x0400B137 RID: 45367
		[Token(Token = "0x40084ED")]
		[FieldOffset(Offset = "0x10")]
		protected TriangulationContext _tcx;
	}
}
