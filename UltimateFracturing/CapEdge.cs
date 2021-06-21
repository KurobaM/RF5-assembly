using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UltimateFracturing
{
	// Token: 0x02000C4B RID: 3147
	[Token(Token = "0x2000803")]
	public struct CapEdge
	{
		// Token: 0x06004FD1 RID: 20433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004210")]
		[Address(RVA = "0x2EB320", Offset = "0x2EB421", VA = "0x2EB320")]
		public CapEdge(int nHash1, int nHash2, Vector3 v1, Vector3 v2, float fLength)
		{
		}

		// Token: 0x06004FD2 RID: 20434 RVA: 0x00019A70 File Offset: 0x00017C70
		[Token(Token = "0x6004211")]
		[Address(RVA = "0x2EB350", Offset = "0x2EB451", VA = "0x2EB350")]
		public int SharesVertex1Of(CapEdge edge)
		{
			return 0;
		}

		// Token: 0x06004FD3 RID: 20435 RVA: 0x00019A88 File Offset: 0x00017C88
		[Token(Token = "0x6004212")]
		[Address(RVA = "0x2EB380", Offset = "0x2EB481", VA = "0x2EB380")]
		public int SharesVertex2Of(CapEdge edge)
		{
			return 0;
		}

		// Token: 0x0400B095 RID: 45205
		[Token(Token = "0x400846B")]
		[FieldOffset(Offset = "0x0")]
		public Vector3 v1;

		// Token: 0x0400B096 RID: 45206
		[Token(Token = "0x400846C")]
		[FieldOffset(Offset = "0xC")]
		public Vector3 v2;

		// Token: 0x0400B097 RID: 45207
		[Token(Token = "0x400846D")]
		[FieldOffset(Offset = "0x18")]
		public int nHash1;

		// Token: 0x0400B098 RID: 45208
		[Token(Token = "0x400846E")]
		[FieldOffset(Offset = "0x1C")]
		public int nHash2;

		// Token: 0x0400B099 RID: 45209
		[Token(Token = "0x400846F")]
		[FieldOffset(Offset = "0x20")]
		public float fLength;
	}
}
