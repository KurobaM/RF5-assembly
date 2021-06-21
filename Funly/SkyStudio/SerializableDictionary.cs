using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x02000E0C RID: 3596
	[Token(Token = "0x2000932")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x148EA0", Offset = "0x148FA1")]
	[Serializable]
	public class SerializableDictionary<K, V> : ISerializationCallbackReceiver
	{
		// Token: 0x06005D6E RID: 23918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D85")]
		public void Clear()
		{
		}

		// Token: 0x17000C49 RID: 3145
		// (get) Token: 0x06005D6F RID: 23919 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005D70 RID: 23920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009AD")]
		public V Item
		{
			[Token(Token = "0x6004D86")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004D87")]
			set
			{
			}
		}

		// Token: 0x06005D71 RID: 23921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D88")]
		public void OnBeforeSerialize()
		{
		}

		// Token: 0x06005D72 RID: 23922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D89")]
		public void OnAfterDeserialize()
		{
		}

		// Token: 0x06005D73 RID: 23923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D8A")]
		public SerializableDictionary()
		{
		}

		// Token: 0x0400BD9B RID: 48539
		[Token(Token = "0x4008E04")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		public Dictionary<K, V> dict;

		// Token: 0x0400BD9C RID: 48540
		[Token(Token = "0x4008E05")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		public List<K> m_Keys;

		// Token: 0x0400BD9D RID: 48541
		[Token(Token = "0x4008E06")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		public List<V> m_Values;
	}
}
