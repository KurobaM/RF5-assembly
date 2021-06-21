using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Common
{
	// Token: 0x020011CC RID: 4556
	[Token(Token = "0x2000BA1")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x14A210", Offset = "0x14A311")]
	public abstract class DictionaryForSaveData<TKey, TValue> : ISerializationCallbackReceiver
	{
		// Token: 0x0600712B RID: 28971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DE7")]
		public void Init()
		{
		}

		// Token: 0x0600712C RID: 28972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DE8")]
		public void OnBeforeSerialize()
		{
		}

		// Token: 0x0600712D RID: 28973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DE9")]
		public void OnAfterDeserialize()
		{
		}

		// Token: 0x17000E4E RID: 3662
		// (get) Token: 0x0600712E RID: 28974 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600712F RID: 28975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B2A")]
		[Attribute(Name = "IgnoreMemberAttribute", RVA = "0x1B8880", Offset = "0x1B8981")]
		public TValue Item
		{
			[Token(Token = "0x6005DEA")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005DEB")]
			set
			{
			}
		}

		// Token: 0x06007130 RID: 28976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DEC")]
		public void Add(TKey key, TValue value)
		{
		}

		// Token: 0x06007131 RID: 28977 RVA: 0x00027018 File Offset: 0x00025218
		[Token(Token = "0x6005DED")]
		public bool CheckValue(params TKey[] keys)
		{
			return default(bool);
		}

		// Token: 0x06007132 RID: 28978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DEE")]
		public TValue[] GetValues(params TKey[] keys)
		{
			return null;
		}

		// Token: 0x06007133 RID: 28979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DEF")]
		public void SetValues(TKey[] keys, TValue value)
		{
		}

		// Token: 0x06007134 RID: 28980 RVA: 0x00027030 File Offset: 0x00025230
		[Token(Token = "0x6005DF0")]
		private bool CheckValue(TKey key)
		{
			return default(bool);
		}

		// Token: 0x06007135 RID: 28981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DF1")]
		public void SetValue(TKey key, TValue value)
		{
		}

		// Token: 0x06007136 RID: 28982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DF2")]
		public void Debug_Log()
		{
		}

		// Token: 0x06007137 RID: 28983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DF3")]
		protected DictionaryForSaveData()
		{
		}

		// Token: 0x040182F7 RID: 99063
		[Token(Token = "0x4014D63")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "KeyAttribute", RVA = "0x1818E0", Offset = "0x1819E1")]
		public List<TKey> KeyList;

		// Token: 0x040182F8 RID: 99064
		[Token(Token = "0x4014D64")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "KeyAttribute", RVA = "0x181900", Offset = "0x181A01")]
		public List<TValue> ValueList;

		// Token: 0x040182F9 RID: 99065
		[Token(Token = "0x4014D65")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		protected Dictionary<TKey, TValue> dic;
	}
}
