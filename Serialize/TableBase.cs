using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Serialize
{
	// Token: 0x020011BD RID: 4541
	[Token(Token = "0x2000B93")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x14A1B0", Offset = "0x14A2B1")]
	[Serializable]
	public class TableBase<TKey, TValue, Type> where Type : KeyAndValue<TKey, TValue>
	{
		// Token: 0x060070F7 RID: 28919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DB6")]
		public Dictionary<TKey, TValue> GetTable()
		{
			return null;
		}

		// Token: 0x060070F8 RID: 28920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DB7")]
		public List<Type> GetList()
		{
			return null;
		}

		// Token: 0x060070F9 RID: 28921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DB8")]
		private static Dictionary<TKey, TValue> ConvertListToDictionary(List<Type> list)
		{
			return null;
		}

		// Token: 0x17000E4B RID: 3659
		// (get) Token: 0x060070FA RID: 28922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B27")]
		public TValue Item
		{
			[Token(Token = "0x6005DB9")]
			get
			{
				return null;
			}
		}

		// Token: 0x060070FB RID: 28923 RVA: 0x00026E20 File Offset: 0x00025020
		[Token(Token = "0x6005DBA")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		// Token: 0x17000E4C RID: 3660
		// (get) Token: 0x060070FC RID: 28924 RVA: 0x00026E38 File Offset: 0x00025038
		[Token(Token = "0x17000B28")]
		public int Count
		{
			[Token(Token = "0x6005DBB")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060070FD RID: 28925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DBC")]
		public TableBase()
		{
		}

		// Token: 0x040182EB RID: 99051
		[Token(Token = "0x4014D59")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<Type> list;

		// Token: 0x040182EC RID: 99052
		[Token(Token = "0x4014D5A")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<TKey, TValue> table;
	}
}
