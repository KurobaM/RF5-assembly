using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace SplineMesh
{
	// Token: 0x02000E3D RID: 3645
	[Token(Token = "0x2000952")]
	public class ListChangedEventArgs<T> : EventArgs
	{
		// Token: 0x06005FF0 RID: 24560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F61")]
		public ListChangedEventArgs()
		{
		}

		// Token: 0x0400BEF5 RID: 48885
		[Token(Token = "0x4008ED0")]
		[FieldOffset(Offset = "0x0")]
		public ListChangeType type;

		// Token: 0x0400BEF6 RID: 48886
		[Token(Token = "0x4008ED1")]
		[FieldOffset(Offset = "0x0")]
		public List<T> newItems;

		// Token: 0x0400BEF7 RID: 48887
		[Token(Token = "0x4008ED2")]
		[FieldOffset(Offset = "0x0")]
		public List<T> removedItems;

		// Token: 0x0400BEF8 RID: 48888
		[Token(Token = "0x4008ED3")]
		[FieldOffset(Offset = "0x0")]
		public int insertIndex;

		// Token: 0x0400BEF9 RID: 48889
		[Token(Token = "0x4008ED4")]
		[FieldOffset(Offset = "0x0")]
		public int removeIndex;
	}
}
