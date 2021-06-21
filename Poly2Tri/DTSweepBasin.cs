using System;
using Il2CppDummyDll;

namespace Poly2Tri
{
	// Token: 0x02000C5C RID: 3164
	[Token(Token = "0x200080D")]
	public class DTSweepBasin
	{
		// Token: 0x06005066 RID: 20582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004297")]
		[Address(RVA = "0x24AC420", Offset = "0x24AC521", VA = "0x24AC420")]
		public DTSweepBasin()
		{
		}

		// Token: 0x0400B0DE RID: 45278
		[Token(Token = "0x400849E")]
		[FieldOffset(Offset = "0x10")]
		public AdvancingFrontNode leftNode;

		// Token: 0x0400B0DF RID: 45279
		[Token(Token = "0x400849F")]
		[FieldOffset(Offset = "0x18")]
		public AdvancingFrontNode bottomNode;

		// Token: 0x0400B0E0 RID: 45280
		[Token(Token = "0x40084A0")]
		[FieldOffset(Offset = "0x20")]
		public AdvancingFrontNode rightNode;

		// Token: 0x0400B0E1 RID: 45281
		[Token(Token = "0x40084A1")]
		[FieldOffset(Offset = "0x28")]
		public double width;

		// Token: 0x0400B0E2 RID: 45282
		[Token(Token = "0x40084A2")]
		[FieldOffset(Offset = "0x30")]
		public bool leftHighest;
	}
}
