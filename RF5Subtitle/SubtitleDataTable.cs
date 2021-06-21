using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace RF5Subtitle
{
	// Token: 0x02000E59 RID: 3673
	[Token(Token = "0x2000968")]
	[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x149630", Offset = "0x149731")]
	[Serializable]
	public class SubtitleDataTable : ScriptableObject
	{
		// Token: 0x0600609B RID: 24731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FF7")]
		[Address(RVA = "0x217E2F0", Offset = "0x217E3F1", VA = "0x217E2F0")]
		public SubtitleDataTable()
		{
		}

		// Token: 0x0400BF8A RID: 49034
		[Token(Token = "0x4008F4F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public List<SubtitleDataTable.DataList> datas;

		// Token: 0x02000E5A RID: 3674
		[Token(Token = "0x200145D")]
		[Serializable]
		public struct Data
		{
			// Token: 0x0400BF8B RID: 49035
			[Token(Token = "0x401BC47")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public int textId;

			// Token: 0x0400BF8C RID: 49036
			[Token(Token = "0x401BC48")]
			[FieldOffset(Offset = "0x4")]
			[SerializeField]
			public int startTime;

			// Token: 0x0400BF8D RID: 49037
			[Token(Token = "0x401BC49")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			public int endTime;
		}

		// Token: 0x02000E5B RID: 3675
		[Token(Token = "0x200145E")]
		[Serializable]
		public struct DataList
		{
			// Token: 0x0400BF8E RID: 49038
			[Token(Token = "0x401BC4A")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public List<SubtitleDataTable.Data> datas;
		}
	}
}
