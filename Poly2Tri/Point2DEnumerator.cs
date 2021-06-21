using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Poly2Tri
{
	// Token: 0x02000C83 RID: 3203
	[Token(Token = "0x2000830")]
	public class Point2DEnumerator : IEnumerator<Point2D>, IEnumerator, IDisposable
	{
		// Token: 0x06005244 RID: 21060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004465")]
		[Address(RVA = "0x27F2DD0", Offset = "0x27F2ED1", VA = "0x27F2DD0")]
		public Point2DEnumerator(IList<Point2D> points)
		{
		}

		// Token: 0x06005245 RID: 21061 RVA: 0x0001AC28 File Offset: 0x00018E28
		[Token(Token = "0x6004466")]
		[Address(RVA = "0x27F2E10", Offset = "0x27F2F11", VA = "0x27F2E10", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x06005246 RID: 21062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004467")]
		[Address(RVA = "0x27F2EE0", Offset = "0x27F2FE1", VA = "0x27F2EE0", Slot = "8")]
		public void Reset()
		{
		}

		// Token: 0x06005247 RID: 21063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004468")]
		[Address(RVA = "0x27F2EF0", Offset = "0x27F2FF1", VA = "0x27F2EF0", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x17000AAD RID: 2733
		// (get) Token: 0x06005248 RID: 21064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000877")]
		private object Current
		{
			[Token(Token = "0x6004469")]
			[Address(RVA = "0x27F2F00", Offset = "0x27F3001", VA = "0x27F2F00", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AAE RID: 2734
		// (get) Token: 0x06005249 RID: 21065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000878")]
		public Point2D Current
		{
			[Token(Token = "0x600446A")]
			[Address(RVA = "0x27F2F10", Offset = "0x27F3011", VA = "0x27F2F10", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400B159 RID: 45401
		[Token(Token = "0x4008503")]
		[FieldOffset(Offset = "0x10")]
		protected IList<Point2D> mPoints;

		// Token: 0x0400B15A RID: 45402
		[Token(Token = "0x4008504")]
		[FieldOffset(Offset = "0x18")]
		protected int position;
	}
}
