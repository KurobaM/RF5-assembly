using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Poly2Tri
{
	// Token: 0x02000C68 RID: 3176
	[Token(Token = "0x2000819")]
	public class PolygonSet
	{
		// Token: 0x06005108 RID: 20744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004339")]
		[Address(RVA = "0x27FE5E0", Offset = "0x27FE6E1", VA = "0x27FE5E0")]
		public PolygonSet()
		{
		}

		// Token: 0x06005109 RID: 20745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600433A")]
		[Address(RVA = "0x27FE660", Offset = "0x27FE761", VA = "0x27FE660")]
		public PolygonSet(Polygon poly)
		{
		}

		// Token: 0x0600510A RID: 20746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600433B")]
		[Address(RVA = "0x27FE710", Offset = "0x27FE811", VA = "0x27FE710")]
		public void Add(Polygon p)
		{
		}

		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x0600510B RID: 20747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000845")]
		public IEnumerable<Polygon> Polygons
		{
			[Token(Token = "0x600433C")]
			[Address(RVA = "0x27FE780", Offset = "0x27FE881", VA = "0x27FE780")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400B107 RID: 45319
		[Token(Token = "0x40084C7")]
		[FieldOffset(Offset = "0x10")]
		protected List<Polygon> _polygons;
	}
}
