using System;
using System.Collections.ObjectModel;
using Il2CppDummyDll;
using UnityEngine;

namespace DataTable
{
	// Token: 0x0200115D RID: 4445
	[Token(Token = "0x2000B35")]
	public abstract class DataTableArrayBase<E, T, S> : ScriptableObject where T : new() where S : DataTableElementBase<E, T>
	{
		// Token: 0x0600706D RID: 28781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D34")]
		private void Awake()
		{
		}

		// Token: 0x0600706E RID: 28782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D35")]
		public T GetDataTableByDictionary(E id)
		{
			return null;
		}

		// Token: 0x0600706F RID: 28783 RVA: 0x00026CE8 File Offset: 0x00024EE8
		[Token(Token = "0x6005D36")]
		public bool HasDataTableByDictionary(E id)
		{
			return default(bool);
		}

		// Token: 0x06007070 RID: 28784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D37")]
		public virtual void Init()
		{
		}

		// Token: 0x06007071 RID: 28785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D38")]
		protected DataTableArrayBase()
		{
		}

		// Token: 0x040182C9 RID: 99017
		[Token(Token = "0x4014D3D")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		public S[] DataTables;

		// Token: 0x040182CA RID: 99018
		[Token(Token = "0x4014D3E")]
		[FieldOffset(Offset = "0x0")]
		private ReadOnlyDictionary<int, T> DataTableDic;
	}
}
