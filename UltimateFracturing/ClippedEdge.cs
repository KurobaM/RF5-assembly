using System;
using Il2CppDummyDll;

namespace UltimateFracturing
{
	// Token: 0x02000C4A RID: 3146
	[Token(Token = "0x2000802")]
	public struct ClippedEdge
	{
		// Token: 0x06004FCE RID: 20430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600420D")]
		[Address(RVA = "0x2EB3B0", Offset = "0x2EB4B1", VA = "0x2EB3B0")]
		public ClippedEdge(int nOldIndexA, int nOldIndexB, int nNewIndexA, int nNewIndexB, int nClippedIndex)
		{
		}

		// Token: 0x06004FCF RID: 20431 RVA: 0x00019A40 File Offset: 0x00017C40
		[Token(Token = "0x600420E")]
		[Address(RVA = "0x2EB3C0", Offset = "0x2EB4C1", VA = "0x2EB3C0")]
		public int GetFirstIndex(int nOldIndexA)
		{
			return 0;
		}

		// Token: 0x06004FD0 RID: 20432 RVA: 0x00019A58 File Offset: 0x00017C58
		[Token(Token = "0x600420F")]
		[Address(RVA = "0x2EB3E0", Offset = "0x2EB4E1", VA = "0x2EB3E0")]
		public int GetSecondIndex(int nOldIndexB)
		{
			return 0;
		}

		// Token: 0x0400B090 RID: 45200
		[Token(Token = "0x4008466")]
		[FieldOffset(Offset = "0x0")]
		public int nOldIndexA;

		// Token: 0x0400B091 RID: 45201
		[Token(Token = "0x4008467")]
		[FieldOffset(Offset = "0x4")]
		public int nOldIndexB;

		// Token: 0x0400B092 RID: 45202
		[Token(Token = "0x4008468")]
		[FieldOffset(Offset = "0x8")]
		public int nNewIndexA;

		// Token: 0x0400B093 RID: 45203
		[Token(Token = "0x4008469")]
		[FieldOffset(Offset = "0xC")]
		public int nNewIndexB;

		// Token: 0x0400B094 RID: 45204
		[Token(Token = "0x400846A")]
		[FieldOffset(Offset = "0x10")]
		public int nClippedIndex;
	}
}
