using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace nn.hid
{
	// Token: 0x02001540 RID: 5440
	[Token(Token = "0x2000EEF")]
	public static class ControllerSupport
	{
		// Token: 0x06007B92 RID: 31634
		[Token(Token = "0x6006784")]
		[Address(RVA = "0x2859EA0", Offset = "0x2859FA1", VA = "0x2859EA0")]
		[PreserveSig]
		public static extern Result Show(ControllerSupportArg showControllerSupportArg);

		// Token: 0x06007B93 RID: 31635
		[Token(Token = "0x6006785")]
		[Address(RVA = "0x2859FA0", Offset = "0x285A0A1", VA = "0x2859FA0")]
		[PreserveSig]
		public static extern Result Show(ref ControllerSupportResultInfo pOutValue, ControllerSupportArg showControllerSupportArg);

		// Token: 0x06007B94 RID: 31636
		[Token(Token = "0x6006786")]
		[Address(RVA = "0x285A0B0", Offset = "0x285A1B1", VA = "0x285A0B0")]
		[PreserveSig]
		public static extern void SetExplainText(ref ControllerSupportArg pOutControllerSupportArg, string pStr, NpadId npadId);

		// Token: 0x06007B95 RID: 31637 RVA: 0x0002BA70 File Offset: 0x00029C70
		[Token(Token = "0x6006787")]
		[Address(RVA = "0x285A220", Offset = "0x285A321", VA = "0x285A220")]
		public static Result Show(ControllerSupportArg showControllerSupportArg, bool suspendUnityThreads)
		{
			return default(Result);
		}

		// Token: 0x06007B96 RID: 31638 RVA: 0x0002BA88 File Offset: 0x00029C88
		[Token(Token = "0x6006788")]
		[Address(RVA = "0x285A430", Offset = "0x285A531", VA = "0x285A430")]
		public static Result Show(ref ControllerSupportResultInfo pOutValue, ControllerSupportArg showControllerSupportArg, bool suspendUnityThreads)
		{
			return default(Result);
		}

		// Token: 0x17000EA4 RID: 3748
		// (get) Token: 0x06007B97 RID: 31639 RVA: 0x0002BAA0 File Offset: 0x00029CA0
		[Token(Token = "0x17000B4A")]
		public static ErrorRange ResultCanceled
		{
			[Token(Token = "0x6006789")]
			[Address(RVA = "0x285A640", Offset = "0x285A741", VA = "0x285A640")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000EA5 RID: 3749
		// (get) Token: 0x06007B98 RID: 31640 RVA: 0x0002BAB8 File Offset: 0x00029CB8
		[Token(Token = "0x17000B4B")]
		public static ErrorRange ResultNotSupportedNpadStyle
		{
			[Token(Token = "0x600678A")]
			[Address(RVA = "0x285A650", Offset = "0x285A751", VA = "0x285A650")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x0401BEB6 RID: 114358
		[Token(Token = "0x40187F0")]
		public const int ExplainTextMaxLength = 32;

		// Token: 0x0401BEB7 RID: 114359
		[Token(Token = "0x40187F1")]
		public const int Utf8ByteSize = 4;

		// Token: 0x0401BEB8 RID: 114360
		[Token(Token = "0x40187F2")]
		public const int ExplainTextMaxBufferSize = 129;

		// Token: 0x0401BEB9 RID: 114361
		[Token(Token = "0x40187F3")]
		public const int ControllerSupportPlayerCountMax = 8;
	}
}
