using System;
using Il2CppDummyDll;

namespace nn.swkbd
{
	// Token: 0x020014EF RID: 5359
	[Token(Token = "0x2000EB2")]
	[Flags]
	public enum InvalidChar
	{
		// Token: 0x0401BCED RID: 113901
		[Token(Token = "0x40186DF")]
		Space = 2,
		// Token: 0x0401BCEE RID: 113902
		[Token(Token = "0x40186E0")]
		AtMark = 4,
		// Token: 0x0401BCEF RID: 113903
		[Token(Token = "0x40186E1")]
		Percent = 8,
		// Token: 0x0401BCF0 RID: 113904
		[Token(Token = "0x40186E2")]
		Slash = 16,
		// Token: 0x0401BCF1 RID: 113905
		[Token(Token = "0x40186E3")]
		BackSlash = 32,
		// Token: 0x0401BCF2 RID: 113906
		[Token(Token = "0x40186E4")]
		Numeric = 64,
		// Token: 0x0401BCF3 RID: 113907
		[Token(Token = "0x40186E5")]
		OutsideOfDownloadCode = 128,
		// Token: 0x0401BCF4 RID: 113908
		[Token(Token = "0x40186E6")]
		OutsideOfMiiNickName = 256,
		// Token: 0x0401BCF5 RID: 113909
		[Token(Token = "0x40186E7")]
		Force32 = -1
	}
}
