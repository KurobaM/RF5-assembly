using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DataTable
{
	// Token: 0x0200115C RID: 4444
	[Token(Token = "0x2000B34")]
	public abstract class DataTableElementBase<E, T> where T : new()
	{
		// Token: 0x0600706C RID: 28780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D33")]
		public DataTableElementBase(E id, T body)
		{
		}

		// Token: 0x040182C7 RID: 99015
		[Token(Token = "0x4014D3B")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		public E ID;

		// Token: 0x040182C8 RID: 99016
		[Token(Token = "0x4014D3C")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		public T Body;
	}
}
