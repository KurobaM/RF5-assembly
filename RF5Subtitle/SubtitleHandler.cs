using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

namespace RF5Subtitle
{
	// Token: 0x02000E5C RID: 3676
	[Token(Token = "0x2000969")]
	public class SubtitleHandler
	{
		// Token: 0x0600609C RID: 24732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FF8")]
		[Address(RVA = "0x217E300", Offset = "0x217E401", VA = "0x217E300")]
		public void EndVoice()
		{
		}

		// Token: 0x0600609D RID: 24733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FF9")]
		[Address(RVA = "0x217E3C0", Offset = "0x217E4C1", VA = "0x217E3C0")]
		public SubtitleHandler(int _soundId, AudioSource _audioSource)
		{
		}

		// Token: 0x0600609E RID: 24734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FFA")]
		[Address(RVA = "0x217E410", Offset = "0x217E511", VA = "0x217E410")]
		public SubtitleHandler(SkillID _skillID)
		{
		}

		// Token: 0x0400BF8F RID: 49039
		[Token(Token = "0x4008F50")]
		[FieldOffset(Offset = "0x10")]
		public AudioSource audioSource;

		// Token: 0x0400BF90 RID: 49040
		[Token(Token = "0x4008F51")]
		[FieldOffset(Offset = "0x18")]
		public int soundID;

		// Token: 0x0400BF91 RID: 49041
		[Token(Token = "0x4008F52")]
		[FieldOffset(Offset = "0x20")]
		public UISubtitleHUDBlock playBlock;

		// Token: 0x0400BF92 RID: 49042
		[Token(Token = "0x4008F53")]
		[FieldOffset(Offset = "0x28")]
		public SkillID skillID;
	}
}
