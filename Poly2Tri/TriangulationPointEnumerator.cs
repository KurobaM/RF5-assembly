using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Poly2Tri
{
	// Token: 0x02000C78 RID: 3192
	[Token(Token = "0x2000827")]
	public class TriangulationPointEnumerator : IEnumerator<TriangulationPoint>, IEnumerator, IDisposable
	{
		// Token: 0x060051BD RID: 20925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043EE")]
		[Address(RVA = "0x27F8DA0", Offset = "0x27F8EA1", VA = "0x27F8DA0")]
		public TriangulationPointEnumerator(IList<Point2D> points)
		{
		}

		// Token: 0x060051BE RID: 20926 RVA: 0x0001A7D8 File Offset: 0x000189D8
		[Token(Token = "0x60043EF")]
		[Address(RVA = "0x2807E10", Offset = "0x2807F11", VA = "0x2807E10", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x060051BF RID: 20927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043F0")]
		[Address(RVA = "0x2807EE0", Offset = "0x2807FE1", VA = "0x2807EE0", Slot = "8")]
		public void Reset()
		{
		}

		// Token: 0x060051C0 RID: 20928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043F1")]
		[Address(RVA = "0x2807EF0", Offset = "0x2807FF1", VA = "0x2807EF0", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x060051C1 RID: 20929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700086F")]
		private object Current
		{
			[Token(Token = "0x60043F2")]
			[Address(RVA = "0x2807F00", Offset = "0x2808001", VA = "0x2807F00", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x060051C2 RID: 20930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000870")]
		public TriangulationPoint Current
		{
			[Token(Token = "0x60043F3")]
			[Address(RVA = "0x2807F10", Offset = "0x2808011", VA = "0x2807F10", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400B13F RID: 45375
		[Token(Token = "0x40084F5")]
		[FieldOffset(Offset = "0x10")]
		protected IList<Point2D> mPoints;

		// Token: 0x0400B140 RID: 45376
		[Token(Token = "0x40084F6")]
		[FieldOffset(Offset = "0x18")]
		protected int position;
	}
}
