using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace nn
{
	// Token: 0x020014E3 RID: 5347
	[Token(Token = "0x2000EA6")]
	public static class Nn
	{
		// Token: 0x060079D1 RID: 31185
		[Token(Token = "0x6006673")]
		[Address(RVA = "0x284F8A0", Offset = "0x284F9A1", VA = "0x284F8A0")]
		[PreserveSig]
		public static extern void Abort(string message);

		// Token: 0x060079D2 RID: 31186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006674")]
		[Address(RVA = "0x284F8D0", Offset = "0x284F9D1", VA = "0x284F8D0")]
		public static void Abort(string message, params object[] args)
		{
		}

		// Token: 0x060079D3 RID: 31187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006675")]
		[Address(RVA = "0x284F900", Offset = "0x284FA01", VA = "0x284F900")]
		public static void Abort(bool condition, string message)
		{
		}

		// Token: 0x060079D4 RID: 31188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006676")]
		[Address(RVA = "0x284F940", Offset = "0x284FA41", VA = "0x284F940")]
		public static void Abort(bool condition, string message, params object[] args)
		{
		}

		// Token: 0x0401BC94 RID: 113812
		[Token(Token = "0x4018686")]
		internal const string DllName = "__Internal";
	}
}
