using System;
using Il2CppDummyDll;

namespace Poly2Tri
{
	// Token: 0x02000C5A RID: 3162
	[Token(Token = "0x200080B")]
	public class AdvancingFrontNode
	{
		// Token: 0x06005041 RID: 20545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004272")]
		[Address(RVA = "0x24A0300", Offset = "0x24A0401", VA = "0x24A0300")]
		public AdvancingFrontNode(TriangulationPoint point)
		{
		}

		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x06005042 RID: 20546 RVA: 0x00019DA0 File Offset: 0x00017FA0
		[Token(Token = "0x1700080E")]
		public bool HasNext
		{
			[Token(Token = "0x6004273")]
			[Address(RVA = "0x24A0360", Offset = "0x24A0461", VA = "0x24A0360")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x06005043 RID: 20547 RVA: 0x00019DB8 File Offset: 0x00017FB8
		[Token(Token = "0x1700080F")]
		public bool HasPrev
		{
			[Token(Token = "0x6004274")]
			[Address(RVA = "0x24A0370", Offset = "0x24A0471", VA = "0x24A0370")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0400B0D7 RID: 45271
		[Token(Token = "0x4008497")]
		[FieldOffset(Offset = "0x10")]
		public AdvancingFrontNode Next;

		// Token: 0x0400B0D8 RID: 45272
		[Token(Token = "0x4008498")]
		[FieldOffset(Offset = "0x18")]
		public AdvancingFrontNode Prev;

		// Token: 0x0400B0D9 RID: 45273
		[Token(Token = "0x4008499")]
		[FieldOffset(Offset = "0x20")]
		public double Value;

		// Token: 0x0400B0DA RID: 45274
		[Token(Token = "0x400849A")]
		[FieldOffset(Offset = "0x28")]
		public TriangulationPoint Point;

		// Token: 0x0400B0DB RID: 45275
		[Token(Token = "0x400849B")]
		[FieldOffset(Offset = "0x30")]
		public DelaunayTriangle Triangle;
	}
}
