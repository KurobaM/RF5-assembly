using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace nn.ngc
{
	// Token: 0x02001502 RID: 5378
	[Token(Token = "0x2000EC2")]
	public sealed class ProfanityFilter : IDisposable
	{
		// Token: 0x06007A51 RID: 31313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066DD")]
		[Address(RVA = "0x34E0E50", Offset = "0x34E0F51", VA = "0x34E0E50")]
		public ProfanityFilter()
		{
		}

		// Token: 0x06007A52 RID: 31314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066DE")]
		[Address(RVA = "0x34E0F00", Offset = "0x34E1001", VA = "0x34E0F00")]
		public ProfanityFilter(bool checkDesiredLanguage)
		{
		}

		// Token: 0x06007A53 RID: 31315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066DF")]
		[Address(RVA = "0x34E0F90", Offset = "0x34E1091", VA = "0x34E0F90", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06007A54 RID: 31316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066E0")]
		[Address(RVA = "0x34E10D0", Offset = "0x34E11D1", VA = "0x34E10D0", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06007A55 RID: 31317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066E1")]
		[Address(RVA = "0x34E1050", Offset = "0x34E1151", VA = "0x34E1050")]
		private void Dispose(bool disposing)
		{
		}

		// Token: 0x06007A56 RID: 31318 RVA: 0x0002AC78 File Offset: 0x00028E78
		[Token(Token = "0x60066E2")]
		[Address(RVA = "0x34E11B0", Offset = "0x34E12B1", VA = "0x34E11B0")]
		public uint GetContentVersion()
		{
			return 0U;
		}

		// Token: 0x06007A57 RID: 31319 RVA: 0x0002AC90 File Offset: 0x00028E90
		[Token(Token = "0x60066E3")]
		[Address(RVA = "0x34E11D0", Offset = "0x34E12D1", VA = "0x34E11D0")]
		public Result CheckProfanityWords([Out] ProfanityFilter.PatternList[] checkResults, ProfanityFilter.PatternList patterns, string[] words)
		{
			return default(Result);
		}

		// Token: 0x06007A58 RID: 31320 RVA: 0x0002ACA8 File Offset: 0x00028EA8
		[Token(Token = "0x60066E4")]
		[Address(RVA = "0x34E13B0", Offset = "0x34E14B1", VA = "0x34E13B0")]
		public Result MaskProfanityWordsInText(ref int profanityWordCount, string inText, out string outText, ProfanityFilter.PatternList patterns)
		{
			return default(Result);
		}

		// Token: 0x06007A59 RID: 31321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066E5")]
		[Address(RVA = "0x34E14D0", Offset = "0x34E15D1", VA = "0x34E14D0")]
		public void SetMaskMode(ProfanityFilter.MaskMode mode)
		{
		}

		// Token: 0x06007A5A RID: 31322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066E6")]
		[Address(RVA = "0x34E14F0", Offset = "0x34E15F1", VA = "0x34E14F0")]
		public void SkipAtSignCheck(ProfanityFilter.SkipMode skipMode)
		{
		}

		// Token: 0x06007A5B RID: 31323
		[Token(Token = "0x60066E7")]
		[Address(RVA = "0x34E11A0", Offset = "0x34E12A1", VA = "0x34E11A0")]
		[PreserveSig]
		private static extern void Destroy(IntPtr profanityFilter, IntPtr ngcWorkBuffer);

		// Token: 0x06007A5C RID: 31324
		[Token(Token = "0x60066E8")]
		[Address(RVA = "0x34E0EE0", Offset = "0x34E0FE1", VA = "0x34E0EE0")]
		[PreserveSig]
		private static extern Result Initialize(ref IntPtr profanityFilter, ref IntPtr ngcWorkBuffer, bool checkDesiredLanguage);

		// Token: 0x06007A5D RID: 31325
		[Token(Token = "0x60066E9")]
		[Address(RVA = "0x34E11C0", Offset = "0x34E12C1", VA = "0x34E11C0")]
		[PreserveSig]
		private static extern uint GetContentVersion(IntPtr profanityFilter);

		// Token: 0x06007A5E RID: 31326
		[Token(Token = "0x60066EA")]
		[Address(RVA = "0x34E1200", Offset = "0x34E1301", VA = "0x34E1200")]
		[PreserveSig]
		private static extern Result CheckProfanityWords(IntPtr profanityFilter, [Out] ProfanityFilter.PatternList[] checkResults, ProfanityFilter.PatternList patterns, string[] words, long wordCount);

		// Token: 0x06007A5F RID: 31327
		[Token(Token = "0x60066EB")]
		[Address(RVA = "0x34E14A0", Offset = "0x34E15A1", VA = "0x34E14A0")]
		[PreserveSig]
		private static extern Result MaskProfanityWordsInText(IntPtr profanityFilter, ref int profanityWordCount, string text, ProfanityFilter.PatternList patterns);

		// Token: 0x06007A60 RID: 31328
		[Token(Token = "0x60066EC")]
		[Address(RVA = "0x34E14E0", Offset = "0x34E15E1", VA = "0x34E14E0")]
		[PreserveSig]
		private static extern void SetMaskMode(IntPtr profanityFilter, ProfanityFilter.MaskMode mode);

		// Token: 0x06007A61 RID: 31329
		[Token(Token = "0x60066ED")]
		[Address(RVA = "0x34E1500", Offset = "0x34E1601", VA = "0x34E1500")]
		[PreserveSig]
		private static extern void SkipAtSignCheck(IntPtr profanityFilter, ProfanityFilter.SkipMode skipMode);

		// Token: 0x0401BD45 RID: 113989
		[Token(Token = "0x401871A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr _profanityFilter;

		// Token: 0x0401BD46 RID: 113990
		[Token(Token = "0x401871B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IntPtr _ngcWorkBuffer;

		// Token: 0x02001503 RID: 5379
		[Token(Token = "0x20015AB")]
		public enum MaskMode
		{
			// Token: 0x0401BD48 RID: 113992
			[Token(Token = "0x401C235")]
			OverWrite,
			// Token: 0x0401BD49 RID: 113993
			[Token(Token = "0x401C236")]
			ReplaceByOneCharacter
		}

		// Token: 0x02001504 RID: 5380
		[Token(Token = "0x20015AC")]
		public enum SkipMode
		{
			// Token: 0x0401BD4B RID: 113995
			[Token(Token = "0x401C238")]
			NotSkip,
			// Token: 0x0401BD4C RID: 113996
			[Token(Token = "0x401C239")]
			SkipAtSign
		}

		// Token: 0x02001505 RID: 5381
		[Token(Token = "0x20015AD")]
		[Flags]
		public enum PatternList
		{
			// Token: 0x0401BD4E RID: 113998
			[Token(Token = "0x401C23B")]
			Japanese = 1,
			// Token: 0x0401BD4F RID: 113999
			[Token(Token = "0x401C23C")]
			AmericanEnglish = 2,
			// Token: 0x0401BD50 RID: 114000
			[Token(Token = "0x401C23D")]
			CanadianFrench = 4,
			// Token: 0x0401BD51 RID: 114001
			[Token(Token = "0x401C23E")]
			LatinAmericanSpanish = 8,
			// Token: 0x0401BD52 RID: 114002
			[Token(Token = "0x401C23F")]
			BritishEnglish = 16,
			// Token: 0x0401BD53 RID: 114003
			[Token(Token = "0x401C240")]
			French = 32,
			// Token: 0x0401BD54 RID: 114004
			[Token(Token = "0x401C241")]
			German = 64,
			// Token: 0x0401BD55 RID: 114005
			[Token(Token = "0x401C242")]
			Italian = 128,
			// Token: 0x0401BD56 RID: 114006
			[Token(Token = "0x401C243")]
			Spanish = 256,
			// Token: 0x0401BD57 RID: 114007
			[Token(Token = "0x401C244")]
			Dutch = 512,
			// Token: 0x0401BD58 RID: 114008
			[Token(Token = "0x401C245")]
			Korean = 1024,
			// Token: 0x0401BD59 RID: 114009
			[Token(Token = "0x401C246")]
			SimplifiedChinese = 2048,
			// Token: 0x0401BD5A RID: 114010
			[Token(Token = "0x401C247")]
			Portuguese = 4096,
			// Token: 0x0401BD5B RID: 114011
			[Token(Token = "0x401C248")]
			Russian = 8192,
			// Token: 0x0401BD5C RID: 114012
			[Token(Token = "0x401C249")]
			SouthAmericanPortuguese = 16384,
			// Token: 0x0401BD5D RID: 114013
			[Token(Token = "0x401C24A")]
			TraditionalChinese = 32768,
			// Token: 0x0401BD5E RID: 114014
			[Token(Token = "0x401C24B")]
			Max = 16
		}
	}
}
