using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace nn.ngc
{
	// Token: 0x02001501 RID: 5377
	[Token(Token = "0x2000EC1")]
	public static class Ngc
	{
		// Token: 0x06007A4C RID: 31308
		[Token(Token = "0x60066D8")]
		[Address(RVA = "0x34E0D10", Offset = "0x34E0E11", VA = "0x34E0D10")]
		[PreserveSig]
		public static extern int CountNumbers(string str);

		// Token: 0x17000E68 RID: 3688
		// (get) Token: 0x06007A4D RID: 31309 RVA: 0x0002AC18 File Offset: 0x00028E18
		[Token(Token = "0x17000B38")]
		public static ErrorRange ResultNotInitialized
		{
			[Token(Token = "0x60066D9")]
			[Address(RVA = "0x34E0D50", Offset = "0x34E0E51", VA = "0x34E0D50")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000E69 RID: 3689
		// (get) Token: 0x06007A4E RID: 31310 RVA: 0x0002AC30 File Offset: 0x00028E30
		[Token(Token = "0x17000B39")]
		public static ErrorRange ResultAlreadyInitialized
		{
			[Token(Token = "0x60066DA")]
			[Address(RVA = "0x34E0D90", Offset = "0x34E0E91", VA = "0x34E0D90")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000E6A RID: 3690
		// (get) Token: 0x06007A4F RID: 31311 RVA: 0x0002AC48 File Offset: 0x00028E48
		[Token(Token = "0x17000B3A")]
		public static ErrorRange ResultInvalidPointer
		{
			[Token(Token = "0x60066DB")]
			[Address(RVA = "0x34E0DD0", Offset = "0x34E0ED1", VA = "0x34E0DD0")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000E6B RID: 3691
		// (get) Token: 0x06007A50 RID: 31312 RVA: 0x0002AC60 File Offset: 0x00028E60
		[Token(Token = "0x17000B3B")]
		public static ErrorRange ResultInvalidSize
		{
			[Token(Token = "0x60066DC")]
			[Address(RVA = "0x34E0E10", Offset = "0x34E0F11", VA = "0x34E0E10")]
			get
			{
				return default(ErrorRange);
			}
		}
	}
}
