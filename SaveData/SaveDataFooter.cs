using System;
using BinaryStream;
using Il2CppDummyDll;

namespace SaveData
{
	// Token: 0x02000EED RID: 3821
	[Token(Token = "0x20009C8")]
	public class SaveDataFooter
	{
		// Token: 0x060063FD RID: 25597 RVA: 0x000217B0 File Offset: 0x0001F9B0
		[Token(Token = "0x6005309")]
		[Address(RVA = "0x21D01D0", Offset = "0x21D02D1", VA = "0x21D01D0")]
		private bool ReadCheck(BinaryReader reader)
		{
			return default(bool);
		}

		// Token: 0x060063FE RID: 25598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600530A")]
		[Address(RVA = "0x21CF560", Offset = "0x21CF661", VA = "0x21CF560")]
		public void Write(BinaryWriter writer)
		{
		}

		// Token: 0x060063FF RID: 25599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600530B")]
		[Address(RVA = "0x21CF880", Offset = "0x21CF981", VA = "0x21CF880")]
		public void Read(BinaryReader reader)
		{
		}

		// Token: 0x06006400 RID: 25600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600530C")]
		[Address(RVA = "0x21CEF30", Offset = "0x21CF031", VA = "0x21CEF30")]
		public SaveDataFooter()
		{
		}

		// Token: 0x0400C3DD RID: 50141
		[Token(Token = "0x40092BC")]
		public const int SIZE = 16;

		// Token: 0x0400C3DE RID: 50142
		[Token(Token = "0x40092BD")]
		[FieldOffset(Offset = "0x10")]
		public int BodyLength;

		// Token: 0x0400C3DF RID: 50143
		[Token(Token = "0x40092BE")]
		[FieldOffset(Offset = "0x14")]
		public int Length;

		// Token: 0x0400C3E0 RID: 50144
		[Token(Token = "0x40092BF")]
		[FieldOffset(Offset = "0x18")]
		public uint Sum;

		// Token: 0x0400C3E1 RID: 50145
		[Token(Token = "0x40092C0")]
		[FieldOffset(Offset = "0x1C")]
		public int Blank;
	}
}
