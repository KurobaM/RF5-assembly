using System;
using Il2CppDummyDll;

namespace Define
{
	// Token: 0x0200123A RID: 4666
	[Token(Token = "0x2000C09")]
	public enum LoaderPriority
	{
		// Token: 0x04019B90 RID: 105360
		[Token(Token = "0x40165D3")]
		DEFAULT,
		// Token: 0x04019B91 RID: 105361
		[Token(Token = "0x40165D4")]
		ACTOR_CHAR = 2000,
		// Token: 0x04019B92 RID: 105362
		[Token(Token = "0x40165D5")]
		ACTOR_BASE = 2500,
		// Token: 0x04019B93 RID: 105363
		[Token(Token = "0x40165D6")]
		LIFECYCLE_BIN = 7000,
		// Token: 0x04019B94 RID: 105364
		[Token(Token = "0x40165D7")]
		EVENT_SCRIPT = 8000,
		// Token: 0x04019B95 RID: 105365
		[Token(Token = "0x40165D8")]
		REMOVE = 9999,
		// Token: 0x04019B96 RID: 105366
		[Token(Token = "0x40165D9")]
		TITLE_BGM_VOICE,
		// Token: 0x04019B97 RID: 105367
		[Token(Token = "0x40165DA")]
		FADE_LOADINGTEXT,
		// Token: 0x04019B98 RID: 105368
		[Token(Token = "0x40165DB")]
		SUBTITLE_TITLE
	}
}
