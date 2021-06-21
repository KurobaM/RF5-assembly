using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000977 RID: 2423
[Token(Token = "0x2000659")]
public class TextPaneDatas : ScriptableObject
{
	// Token: 0x06003F95 RID: 16277 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034E9")]
	[Address(RVA = "0x205AB30", Offset = "0x205AC31", VA = "0x205AB30")]
	public TextPaneDatas()
	{
	}

	// Token: 0x04008427 RID: 33831
	[Token(Token = "0x400770C")]
	[FieldOffset(Offset = "0x18")]
	public TextPaneDatas.TextPaneData[] datas;

	// Token: 0x02000978 RID: 2424
	[Token(Token = "0x20012A0")]
	[Serializable]
	public struct TextPaneData
	{
		// Token: 0x04008428 RID: 33832
		[Token(Token = "0x401997E")]
		[FieldOffset(Offset = "0x0")]
		public int ID;

		// Token: 0x04008429 RID: 33833
		[Token(Token = "0x401997F")]
		[FieldOffset(Offset = "0x8")]
		public string TextPaneName;

		// Token: 0x0400842A RID: 33834
		[Token(Token = "0x4019980")]
		[FieldOffset(Offset = "0x10")]
		public string FontFileName;

		// Token: 0x0400842B RID: 33835
		[Token(Token = "0x4019981")]
		[FieldOffset(Offset = "0x18")]
		public bool Bold;

		// Token: 0x0400842C RID: 33836
		[Token(Token = "0x4019982")]
		[FieldOffset(Offset = "0x19")]
		public bool Italic;

		// Token: 0x0400842D RID: 33837
		[Token(Token = "0x4019983")]
		[FieldOffset(Offset = "0x1C")]
		public int FontSize;

		// Token: 0x0400842E RID: 33838
		[Token(Token = "0x4019984")]
		[FieldOffset(Offset = "0x20")]
		public float LineSpacing;

		// Token: 0x0400842F RID: 33839
		[Token(Token = "0x4019985")]
		[FieldOffset(Offset = "0x24")]
		public int TextNumW;

		// Token: 0x04008430 RID: 33840
		[Token(Token = "0x4019986")]
		[FieldOffset(Offset = "0x28")]
		public int TextNumH;
	}
}
