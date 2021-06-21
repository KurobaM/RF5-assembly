using System;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;

namespace nn.swkbd
{
	// Token: 0x020014EA RID: 5354
	[Token(Token = "0x2000EAD")]
	public static class Swkbd
	{
		// Token: 0x06007A04 RID: 31236 RVA: 0x0002AA20 File Offset: 0x00028C20
		[Token(Token = "0x60066A6")]
		[Address(RVA = "0x34E30C0", Offset = "0x34E31C1", VA = "0x34E30C0")]
		public static Result ShowKeyboard(StringBuilder pOutResultString, ShowKeyboardArg showKeyboardArg, bool suspendUnityThreads)
		{
			return default(Result);
		}

		// Token: 0x06007A05 RID: 31237 RVA: 0x0002AA38 File Offset: 0x00028C38
		[Token(Token = "0x60066A7")]
		[Address(RVA = "0x34E33C0", Offset = "0x34E34C1", VA = "0x34E33C0")]
		public static Result ShowKeyboard(byte[] pOutResultString, ShowKeyboardArg showKeyboardArg, bool suspendUnityThreads)
		{
			return default(Result);
		}

		// Token: 0x06007A06 RID: 31238 RVA: 0x0002AA50 File Offset: 0x00028C50
		[Token(Token = "0x60066A8")]
		[Address(RVA = "0x34E3630", Offset = "0x34E3731", VA = "0x34E3630")]
		public static Result ShowKeyboard(StringBuilder pOutResultString, ShowKeyboardArg showKeyboardArg)
		{
			return default(Result);
		}

		// Token: 0x06007A07 RID: 31239 RVA: 0x0002AA68 File Offset: 0x00028C68
		[Token(Token = "0x60066A9")]
		[Address(RVA = "0x34E3740", Offset = "0x34E3841", VA = "0x34E3740")]
		public static Result ShowKeyboard(byte[] pOutResultString, ShowKeyboardArg showKeyboardArg)
		{
			return default(Result);
		}

		// Token: 0x06007A08 RID: 31240
		[Token(Token = "0x60066AA")]
		[Address(RVA = "0x34E32E0", Offset = "0x34E33E1", VA = "0x34E32E0")]
		[PreserveSig]
		private static extern Result ShowKeyboard([In] [Out] StringBuilder pOutResultString, long bufSize, ShowKeyboardArg showKeyboardArg);

		// Token: 0x06007A09 RID: 31241
		[Token(Token = "0x60066AB")]
		[Address(RVA = "0x34E3560", Offset = "0x34E3661", VA = "0x34E3560")]
		[PreserveSig]
		private static extern Result ShowKeyboard([In] [Out] byte[] pOutResultString, long bufSize, ShowKeyboardArg showKeyboardArg);

		// Token: 0x06007A0A RID: 31242
		[Token(Token = "0x60066AC")]
		[Address(RVA = "0x34E3820", Offset = "0x34E3921", VA = "0x34E3820")]
		[PreserveSig]
		public static extern void InitializeKeyboardConfig(ref KeyboardConfig pOutKeyboardConfig);

		// Token: 0x06007A0B RID: 31243
		[Token(Token = "0x60066AD")]
		[Address(RVA = "0x34E38C0", Offset = "0x34E39C1", VA = "0x34E38C0")]
		[PreserveSig]
		public static extern void MakePreset(ref KeyboardConfig pOutKeyboardConfig, Preset preset);

		// Token: 0x06007A0C RID: 31244
		[Token(Token = "0x60066AE")]
		[Address(RVA = "0x34E3970", Offset = "0x34E3A71", VA = "0x34E3970")]
		[PreserveSig]
		public static extern long GetRequiredStringBufferSize();

		// Token: 0x06007A0D RID: 31245
		[Token(Token = "0x60066AF")]
		[Address(RVA = "0x34E3980", Offset = "0x34E3A81", VA = "0x34E3980")]
		[PreserveSig]
		public static extern void SetLeftOptionalSymbolKey(ref KeyboardConfig pOutKeyboardConfig, char code);

		// Token: 0x06007A0E RID: 31246
		[Token(Token = "0x60066B0")]
		[Address(RVA = "0x34E3A30", Offset = "0x34E3B31", VA = "0x34E3A30")]
		[PreserveSig]
		public static extern void SetLeftOptionalSymbolKeyUtf8(ref KeyboardConfig pOutKeyboardConfig, [In] byte[] code);

		// Token: 0x06007A0F RID: 31247
		[Token(Token = "0x60066B1")]
		[Address(RVA = "0x34E3AE0", Offset = "0x34E3BE1", VA = "0x34E3AE0")]
		[PreserveSig]
		public static extern void SetRightOptionalSymbolKey(ref KeyboardConfig pOutKeyboardConfig, char code);

		// Token: 0x06007A10 RID: 31248
		[Token(Token = "0x60066B2")]
		[Address(RVA = "0x34E3B90", Offset = "0x34E3C91", VA = "0x34E3B90")]
		[PreserveSig]
		public static extern void SetRightOptionalSymbolKeyUtf8(ref KeyboardConfig pOutKeyboardConfig, [In] byte[] code);

		// Token: 0x06007A11 RID: 31249
		[Token(Token = "0x60066B3")]
		[Address(RVA = "0x34E3C40", Offset = "0x34E3D41", VA = "0x34E3C40")]
		[PreserveSig]
		public static extern void SetOkText(ref KeyboardConfig pOutKeyboardConfig, [In] string pStr);

		// Token: 0x06007A12 RID: 31250
		[Token(Token = "0x60066B4")]
		[Address(RVA = "0x34E3CF0", Offset = "0x34E3DF1", VA = "0x34E3CF0")]
		[PreserveSig]
		public static extern void SetOkTextUtf8(ref KeyboardConfig pOutKeyboardConfig, [In] byte[] pStr);

		// Token: 0x06007A13 RID: 31251
		[Token(Token = "0x60066B5")]
		[Address(RVA = "0x34E3DA0", Offset = "0x34E3EA1", VA = "0x34E3DA0")]
		[PreserveSig]
		public static extern void SetHeaderText(ref KeyboardConfig pOutKeyboardConfig, [In] string pStr);

		// Token: 0x06007A14 RID: 31252
		[Token(Token = "0x60066B6")]
		[Address(RVA = "0x34E3E50", Offset = "0x34E3F51", VA = "0x34E3E50")]
		[PreserveSig]
		public static extern void SetHeaderTextUtf8(ref KeyboardConfig pOutKeyboardConfig, [In] byte[] pStr);

		// Token: 0x06007A15 RID: 31253
		[Token(Token = "0x60066B7")]
		[Address(RVA = "0x34E3F00", Offset = "0x34E4001", VA = "0x34E3F00")]
		[PreserveSig]
		public static extern void SetSubText(ref KeyboardConfig pOutKeyboardConfig, [In] string pStr);

		// Token: 0x06007A16 RID: 31254
		[Token(Token = "0x60066B8")]
		[Address(RVA = "0x34E3FB0", Offset = "0x34E40B1", VA = "0x34E3FB0")]
		[PreserveSig]
		public static extern void SetSubTextUtf8(ref KeyboardConfig pOutKeyboardConfig, [In] byte[] pStr);

		// Token: 0x06007A17 RID: 31255
		[Token(Token = "0x60066B9")]
		[Address(RVA = "0x34E4060", Offset = "0x34E4161", VA = "0x34E4060")]
		[PreserveSig]
		public static extern void SetGuideText(ref KeyboardConfig pOutKeyboardConfig, [In] string pStr);

		// Token: 0x06007A18 RID: 31256
		[Token(Token = "0x60066BA")]
		[Address(RVA = "0x34E4110", Offset = "0x34E4211", VA = "0x34E4110")]
		[PreserveSig]
		public static extern void SetGuideTextUtf8(ref KeyboardConfig pOutKeyboardConfig, [In] byte[] pStr);

		// Token: 0x06007A19 RID: 31257
		[Token(Token = "0x60066BB")]
		[Address(RVA = "0x34E41C0", Offset = "0x34E42C1", VA = "0x34E41C0")]
		[PreserveSig]
		public static extern void SetInitialText(ref ShowKeyboardArg pOutShowKeyboardArg, [In] string pStr);

		// Token: 0x06007A1A RID: 31258
		[Token(Token = "0x60066BC")]
		[Address(RVA = "0x34E4330", Offset = "0x34E4431", VA = "0x34E4330")]
		[PreserveSig]
		public static extern void SetInitialTextUtf8(ref ShowKeyboardArg pOutShowKeyboardArg, [In] byte[] pStr);

		// Token: 0x06007A1B RID: 31259
		[Token(Token = "0x60066BD")]
		[Address(RVA = "0x34E44A0", Offset = "0x34E45A1", VA = "0x34E44A0")]
		[PreserveSig]
		public static extern void SetUserWordList(ref ShowKeyboardArg pOutShowKeyboardArg, [In] UserWord[] pUserWord, int userWordNum);

		// Token: 0x06007A1C RID: 31260
		[Token(Token = "0x60066BE")]
		[Address(RVA = "0x34E46A0", Offset = "0x34E47A1", VA = "0x34E46A0")]
		[PreserveSig]
		public static extern void SetTextCheckCallback(ref ShowKeyboardArg pOutShowKeyboardArg, [In] TextCheckCallback pCallback);

		// Token: 0x06007A1D RID: 31261
		[Token(Token = "0x60066BF")]
		[Address(RVA = "0x34E4810", Offset = "0x34E4911", VA = "0x34E4810")]
		[PreserveSig]
		public static extern void SetCustomizedDictionaries(ref ShowKeyboardArg pOutShowKeyboardArg, CustomizedDictionarySet dicSet);

		// Token: 0x06007A1E RID: 31262
		[Token(Token = "0x60066C0")]
		[Address(RVA = "0x34E4990", Offset = "0x34E4A91", VA = "0x34E4990")]
		[PreserveSig]
		public static extern void Initialize(ref ShowKeyboardArg pOutShowKeyboardArg, bool useDirectory, bool useTextCheck);

		// Token: 0x06007A1F RID: 31263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066C1")]
		[Address(RVA = "0x34E4B00", Offset = "0x34E4C01", VA = "0x34E4B00")]
		public static void Initialize(ref ShowKeyboardArg pOutShowKeyboardArg, bool useDirectory)
		{
		}

		// Token: 0x06007A20 RID: 31264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066C2")]
		[Address(RVA = "0x34E4C70", Offset = "0x34E4D71", VA = "0x34E4C70")]
		public static void Initialize(ref ShowKeyboardArg pOutShowKeyboardArg)
		{
		}

		// Token: 0x06007A21 RID: 31265
		[Token(Token = "0x60066C3")]
		[Address(RVA = "0x34E4DD0", Offset = "0x34E4ED1", VA = "0x34E4DD0")]
		[PreserveSig]
		public static extern void Initialize(ref ShowKeyboardArg pOutShowKeyboardArg, int userWordNum, bool useTextCheck);

		// Token: 0x06007A22 RID: 31266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066C4")]
		[Address(RVA = "0x34E4F40", Offset = "0x34E5041", VA = "0x34E4F40")]
		public static void Initialize(ref ShowKeyboardArg pOutShowKeyboardArg, int userWordNum)
		{
		}

		// Token: 0x06007A23 RID: 31267
		[Token(Token = "0x60066C5")]
		[Address(RVA = "0x34E50B0", Offset = "0x34E51B1", VA = "0x34E50B0")]
		[PreserveSig]
		public static extern void Destroy(ref ShowKeyboardArg pOutShowKeyboardArg);

		// Token: 0x06007A24 RID: 31268 RVA: 0x0002AA80 File Offset: 0x00028C80
		[Token(Token = "0x60066C6")]
		[Address(RVA = "0x34E32B0", Offset = "0x34E33B1", VA = "0x34E32B0")]
		private static int GetByteSize(StringBuilder sb)
		{
			return 0;
		}

		// Token: 0x17000E61 RID: 3681
		// (get) Token: 0x06007A25 RID: 31269 RVA: 0x0002AA98 File Offset: 0x00028C98
		[Token(Token = "0x17000B37")]
		public static ErrorRange ResultCanceled
		{
			[Token(Token = "0x60066C7")]
			[Address(RVA = "0x34E5210", Offset = "0x34E5311", VA = "0x34E5210")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x0401BCAC RID: 113836
		[Token(Token = "0x401869E")]
		public const int TextMaxLength = 500;

		// Token: 0x0401BCAD RID: 113837
		[Token(Token = "0x401869F")]
		public const int SeparateModeTextMaxLength = 24;

		// Token: 0x0401BCAE RID: 113838
		[Token(Token = "0x40186A0")]
		public const int HeaderTextMaxLength = 64;

		// Token: 0x0401BCAF RID: 113839
		[Token(Token = "0x40186A1")]
		public const int SubTextMaxLength = 128;

		// Token: 0x0401BCB0 RID: 113840
		[Token(Token = "0x40186A2")]
		public const int GuideTextMaxLength = 256;

		// Token: 0x0401BCB1 RID: 113841
		[Token(Token = "0x40186A3")]
		public const int OkTextMaxLength = 8;

		// Token: 0x0401BCB2 RID: 113842
		[Token(Token = "0x40186A4")]
		public const int UnfixedStringLengthMax = 24;

		// Token: 0x0401BCB3 RID: 113843
		[Token(Token = "0x40186A5")]
		public const int UserWordMax = 5000;

		// Token: 0x0401BCB4 RID: 113844
		[Token(Token = "0x40186A6")]
		public const int DialogTextMaxLength = 500;

		// Token: 0x0401BCB5 RID: 113845
		[Token(Token = "0x40186A7")]
		public const int SepareteTextPosMax = 8;

		// Token: 0x0401BCB6 RID: 113846
		[Token(Token = "0x40186A8")]
		public const int CustomizedDicionarySetMax = 24;
	}
}
