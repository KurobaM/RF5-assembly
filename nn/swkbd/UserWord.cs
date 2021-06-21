using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace nn.swkbd
{
	// Token: 0x020014F7 RID: 5367
	[Token(Token = "0x2000EBA")]
	[StructLayout(0, CharSet = CharSet.Unicode)]
	public struct UserWord
	{
		// Token: 0x0401BD1F RID: 113951
		[Token(Token = "0x4018711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string reading;

		// Token: 0x0401BD20 RID: 113952
		[Token(Token = "0x4018712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string word;
	}
}
