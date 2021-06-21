using System;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;

namespace nn.ngc
{
	// Token: 0x02001506 RID: 5382
	[Token(Token = "0x2000EC3")]
	public static class ProfanityFilterForPlatformRegionChina
	{
		// Token: 0x06007A62 RID: 31330
		[Token(Token = "0x60066EE")]
		[Address(RVA = "0x34E1510", Offset = "0x34E1611", VA = "0x34E1510")]
		[PreserveSig]
		public static extern Result CheckProfanityWords(ref bool pOutCheckResult, [In] string pText);

		// Token: 0x06007A63 RID: 31331
		[Token(Token = "0x60066EF")]
		[Address(RVA = "0x34E1560", Offset = "0x34E1661", VA = "0x34E1560")]
		[PreserveSig]
		public static extern Result CheckProfanityWords(ref bool pOutCheckResult, [In] StringBuilder pText);

		// Token: 0x06007A64 RID: 31332
		[Token(Token = "0x60066F0")]
		[Address(RVA = "0x34E15B0", Offset = "0x34E16B1", VA = "0x34E15B0")]
		[PreserveSig]
		public static extern Result MaskProfanityWords([In] [Out] StringBuilder pOutText);
	}
}
