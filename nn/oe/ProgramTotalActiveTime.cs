using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace nn.oe
{
	// Token: 0x02001500 RID: 5376
	[Token(Token = "0x2000EC0")]
	public static class ProgramTotalActiveTime
	{
		// Token: 0x06007A4A RID: 31306 RVA: 0x0002AC00 File Offset: 0x00028E00
		[Token(Token = "0x60066D6")]
		[Address(RVA = "0x34E1800", Offset = "0x34E1901", VA = "0x34E1800")]
		public static TimeSpan Get()
		{
			return default(TimeSpan);
		}

		// Token: 0x06007A4B RID: 31307
		[Token(Token = "0x60066D7")]
		[Address(RVA = "0x34E1880", Offset = "0x34E1981", VA = "0x34E1880")]
		[PreserveSig]
		public static extern long GetNanoseconds();
	}
}
