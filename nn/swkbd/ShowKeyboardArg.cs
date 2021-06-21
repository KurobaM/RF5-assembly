using System;
using Il2CppDummyDll;

namespace nn.swkbd
{
	// Token: 0x020014EC RID: 5356
	[Token(Token = "0x2000EAF")]
	public struct ShowKeyboardArg
	{
		// Token: 0x0401BCD2 RID: 113874
		[Token(Token = "0x40186C4")]
		[FieldOffset(Offset = "0x0")]
		public KeyboardConfig keyboardConfig;

		// Token: 0x0401BCD3 RID: 113875
		[Token(Token = "0x40186C5")]
		[FieldOffset(Offset = "0x88")]
		public IntPtr workBuf;

		// Token: 0x0401BCD4 RID: 113876
		[Token(Token = "0x40186C6")]
		[FieldOffset(Offset = "0x90")]
		public long workBufSize;

		// Token: 0x0401BCD5 RID: 113877
		[Token(Token = "0x40186C7")]
		[FieldOffset(Offset = "0x98")]
		public IntPtr textCheckWorkBuf;

		// Token: 0x0401BCD6 RID: 113878
		[Token(Token = "0x40186C8")]
		[FieldOffset(Offset = "0xA0")]
		public long textCheckWorkBufSize;

		// Token: 0x0401BCD7 RID: 113879
		[Token(Token = "0x40186C9")]
		[FieldOffset(Offset = "0xA8")]
		private IntPtr _customizeDicBuf;

		// Token: 0x0401BCD8 RID: 113880
		[Token(Token = "0x40186CA")]
		[FieldOffset(Offset = "0xB0")]
		private long _customizeDicBufSize;
	}
}
