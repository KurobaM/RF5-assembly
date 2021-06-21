using System;
using Il2CppDummyDll;

namespace Poly2Tri
{
	// Token: 0x02000C60 RID: 3168
	[Token(Token = "0x2000811")]
	public class DTSweepEdgeEvent
	{
		// Token: 0x06005089 RID: 20617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042BA")]
		[Address(RVA = "0x24AC5B0", Offset = "0x24AC6B1", VA = "0x24AC5B0")]
		public DTSweepEdgeEvent()
		{
		}

		// Token: 0x0400B0EF RID: 45295
		[Token(Token = "0x40084AF")]
		[FieldOffset(Offset = "0x10")]
		public DTSweepConstraint ConstrainedEdge;

		// Token: 0x0400B0F0 RID: 45296
		[Token(Token = "0x40084B0")]
		[FieldOffset(Offset = "0x18")]
		public bool Right;
	}
}
