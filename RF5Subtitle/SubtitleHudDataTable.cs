using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace RF5Subtitle
{
	// Token: 0x02000E5D RID: 3677
	[Token(Token = "0x200096A")]
	[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x149640", Offset = "0x149741")]
	[Serializable]
	public class SubtitleHudDataTable : ScriptableObject
	{
		// Token: 0x0600609F RID: 24735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FFB")]
		[Address(RVA = "0x217E450", Offset = "0x217E551", VA = "0x217E450")]
		public SubtitleHudDataTable()
		{
		}

		// Token: 0x0400BF93 RID: 49043
		[Token(Token = "0x4008F54")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public List<SubtitleHudDataTable.Data> datas;

		// Token: 0x02000E5E RID: 3678
		[Token(Token = "0x200145F")]
		[Serializable]
		public struct Data
		{
			// Token: 0x0400BF94 RID: 49044
			[Token(Token = "0x401BC4B")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public int soundId;

			// Token: 0x0400BF95 RID: 49045
			[Token(Token = "0x401BC4C")]
			[FieldOffset(Offset = "0x4")]
			[SerializeField]
			public int textId;

			// Token: 0x0400BF96 RID: 49046
			[Token(Token = "0x401BC4D")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			public int charactorId;
		}
	}
}
