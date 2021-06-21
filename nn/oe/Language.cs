using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace nn.oe
{
	// Token: 0x020014FD RID: 5373
	[Token(Token = "0x2000EBE")]
	public static class Language
	{
		// Token: 0x06007A46 RID: 31302
		[Token(Token = "0x60066D2")]
		[Address(RVA = "0x34E1640", Offset = "0x34E1741", VA = "0x34E1640")]
		[PreserveSig]
		private static extern Language._LanguageCode _GetDesired();

		// Token: 0x06007A47 RID: 31303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066D3")]
		[Address(RVA = "0x34E1720", Offset = "0x34E1821", VA = "0x34E1720")]
		public static string GetDesired()
		{
			return null;
		}

		// Token: 0x020014FE RID: 5374
		[Token(Token = "0x20015AA")]
		private struct _LanguageCode
		{
			// Token: 0x0401BD44 RID: 113988
			[Token(Token = "0x401C233")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal char[] _string;
		}
	}
}
