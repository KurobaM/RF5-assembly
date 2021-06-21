using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace nn.swkbd
{
	// Token: 0x020014EB RID: 5355
	[Token(Token = "0x2000EAE")]
	[StructLayout(0, CharSet = CharSet.Unicode)]
	public struct KeyboardConfig
	{
		// Token: 0x0401BCB7 RID: 113847
		[Token(Token = "0x40186A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public KeyboardMode keyboardMode;

		// Token: 0x0401BCB8 RID: 113848
		[Token(Token = "0x40186AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string okText;

		// Token: 0x0401BCB9 RID: 113849
		[Token(Token = "0x40186AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public char leftOptionalSymbolKey;

		// Token: 0x0401BCBA RID: 113850
		[Token(Token = "0x40186AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public char rightOptionalSymbolKey;

		// Token: 0x0401BCBB RID: 113851
		[Token(Token = "0x40186AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool isPredictionEnabled;

		// Token: 0x0401BCBC RID: 113852
		[Token(Token = "0x40186AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InvalidChar invalidCharFlag;

		// Token: 0x0401BCBD RID: 113853
		[Token(Token = "0x40186AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public InitialCursorPos initialCursorPos;

		// Token: 0x0401BCBE RID: 113854
		[Token(Token = "0x40186B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string headerText;

		// Token: 0x0401BCBF RID: 113855
		[Token(Token = "0x40186B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string subText;

		// Token: 0x0401BCC0 RID: 113856
		[Token(Token = "0x40186B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string guideText;

		// Token: 0x0401BCC1 RID: 113857
		[Token(Token = "0x40186B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int textMaxLength;

		// Token: 0x0401BCC2 RID: 113858
		[Token(Token = "0x40186B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int textMinLength;

		// Token: 0x0401BCC3 RID: 113859
		[Token(Token = "0x40186B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public PasswordMode passwordMode;

		// Token: 0x0401BCC4 RID: 113860
		[Token(Token = "0x40186B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public InputFormMode inputFormMode;

		// Token: 0x0401BCC5 RID: 113861
		[Token(Token = "0x40186B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool isUseNewLine;

		// Token: 0x0401BCC6 RID: 113862
		[Token(Token = "0x40186B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool isUseUtf8;

		// Token: 0x0401BCC7 RID: 113863
		[Token(Token = "0x40186B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		public bool isUseBlurBackground;

		// Token: 0x0401BCC8 RID: 113864
		[Token(Token = "0x40186BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int _initialStringOffset;

		// Token: 0x0401BCC9 RID: 113865
		[Token(Token = "0x40186BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _initialStringLength;

		// Token: 0x0401BCCA RID: 113866
		[Token(Token = "0x40186BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int _userDictionaryOffset;

		// Token: 0x0401BCCB RID: 113867
		[Token(Token = "0x40186BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int _userDictionaryNum;

		// Token: 0x0401BCCC RID: 113868
		[Token(Token = "0x40186BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool _isUseTextCheck;

		// Token: 0x0401BCCD RID: 113869
		[Token(Token = "0x40186BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IntPtr _textCheckCallback;

		// Token: 0x0401BCCE RID: 113870
		[Token(Token = "0x40186C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public int[] separateTextPos;

		// Token: 0x0401BCCF RID: 113871
		[Token(Token = "0x40186C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private DictionaryInfo[] _customizedDicInfoList;

		// Token: 0x0401BCD0 RID: 113872
		[Token(Token = "0x40186C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private byte _customizedDicCount;

		// Token: 0x0401BCD1 RID: 113873
		[Token(Token = "0x40186C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private byte[] _reserved;
	}
}
