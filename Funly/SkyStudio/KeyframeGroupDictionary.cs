using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x02000E0B RID: 3595
	[Token(Token = "0x2000931")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x148E60", Offset = "0x148F61")]
	[Serializable]
	public class KeyframeGroupDictionary : ISerializationCallbackReceiver, IEnumerable<string>, IEnumerable
	{
		// Token: 0x17000C48 RID: 3144
		// (get) Token: 0x06005D64 RID: 23908 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005D65 RID: 23909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009AC")]
		public IKeyframeGroup Item
		{
			[Token(Token = "0x6004D7B")]
			[Address(RVA = "0x23D5B60", Offset = "0x23D5C61", VA = "0x23D5B60")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004D7C")]
			[Address(RVA = "0x23D5BD0", Offset = "0x23D5CD1", VA = "0x23D5BD0")]
			set
			{
			}
		}

		// Token: 0x06005D66 RID: 23910 RVA: 0x0001EF00 File Offset: 0x0001D100
		[Token(Token = "0x6004D7D")]
		[Address(RVA = "0x23D5C40", Offset = "0x23D5D41", VA = "0x23D5C40")]
		public bool ContainsKey(string key)
		{
			return default(bool);
		}

		// Token: 0x06005D67 RID: 23911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D7E")]
		[Address(RVA = "0x23D5CB0", Offset = "0x23D5DB1", VA = "0x23D5CB0")]
		public void Clear()
		{
		}

		// Token: 0x06005D68 RID: 23912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D7F")]
		public T GetGroup<T>(string propertyName) where T : class
		{
			return null;
		}

		// Token: 0x06005D69 RID: 23913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D80")]
		[Address(RVA = "0x23D5D10", Offset = "0x23D5E11", VA = "0x23D5D10", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		// Token: 0x06005D6A RID: 23914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D81")]
		[Address(RVA = "0x23D6100", Offset = "0x23D6201", VA = "0x23D6100", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		// Token: 0x06005D6B RID: 23915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D82")]
		[Address(RVA = "0x23D67B0", Offset = "0x23D68B1", VA = "0x23D67B0", Slot = "6")]
		public IEnumerator<string> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06005D6C RID: 23916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D83")]
		[Address(RVA = "0x23D6850", Offset = "0x23D6951", VA = "0x23D6850", Slot = "7")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06005D6D RID: 23917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D84")]
		[Address(RVA = "0x23D6860", Offset = "0x23D6961", VA = "0x23D6860")]
		public KeyframeGroupDictionary()
		{
		}

		// Token: 0x0400BD95 RID: 48533
		[Token(Token = "0x4008DFE")]
		[FieldOffset(Offset = "0x10")]
		[NonSerialized]
		private Dictionary<string, IKeyframeGroup> m_Groups;

		// Token: 0x0400BD96 RID: 48534
		[Token(Token = "0x4008DFF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ColorGroupDictionary m_ColorGroup;

		// Token: 0x0400BD97 RID: 48535
		[Token(Token = "0x4008E00")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private NumberGroupDictionary m_NumberGroup;

		// Token: 0x0400BD98 RID: 48536
		[Token(Token = "0x4008E01")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextureGroupDictionary m_TextureGroup;

		// Token: 0x0400BD99 RID: 48537
		[Token(Token = "0x4008E02")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SpherePointGroupDictionary m_SpherePointGroup;

		// Token: 0x0400BD9A RID: 48538
		[Token(Token = "0x4008E03")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private BoolGroupDictionary m_BoolGroup;
	}
}
