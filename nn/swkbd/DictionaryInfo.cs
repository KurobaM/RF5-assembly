using System;
using Il2CppDummyDll;

namespace nn.swkbd
{
	// Token: 0x020014F8 RID: 5368
	[Token(Token = "0x2000EBB")]
	public struct DictionaryInfo
	{
		// Token: 0x06007A2A RID: 31274 RVA: 0x0002AAB0 File Offset: 0x00028CB0
		[Token(Token = "0x60066CC")]
		[Address(RVA = "0x34E1C00", Offset = "0x34E1D01", VA = "0x34E1C00")]
		public static bool operator ==(DictionaryInfo lhs, DictionaryInfo rhs)
		{
			return default(bool);
		}

		// Token: 0x06007A2B RID: 31275 RVA: 0x0002AAC8 File Offset: 0x00028CC8
		[Token(Token = "0x60066CD")]
		[Address(RVA = "0x34E2ED0", Offset = "0x34E2FD1", VA = "0x34E2ED0")]
		public static bool operator !=(DictionaryInfo lhs, DictionaryInfo rhs)
		{
			return default(bool);
		}

		// Token: 0x06007A2C RID: 31276 RVA: 0x0002AAE0 File Offset: 0x00028CE0
		[Token(Token = "0x60066CE")]
		[Address(RVA = "0x3A07E0", Offset = "0x3A08E1", VA = "0x3A07E0", Slot = "0")]
		public override bool Equals(object right)
		{
			return default(bool);
		}

		// Token: 0x06007A2D RID: 31277 RVA: 0x0002AAF8 File Offset: 0x00028CF8
		[Token(Token = "0x60066CF")]
		[Address(RVA = "0x3A08D0", Offset = "0x3A09D1", VA = "0x3A08D0")]
		public bool Equals(DictionaryInfo other)
		{
			return default(bool);
		}

		// Token: 0x06007A2E RID: 31278 RVA: 0x0002AB10 File Offset: 0x00028D10
		[Token(Token = "0x60066D0")]
		[Address(RVA = "0x3A0910", Offset = "0x3A0A11", VA = "0x3A0910", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0401BD21 RID: 113953
		[Token(Token = "0x4018713")]
		[FieldOffset(Offset = "0x0")]
		public uint offset;

		// Token: 0x0401BD22 RID: 113954
		[Token(Token = "0x4018714")]
		[FieldOffset(Offset = "0x4")]
		public ushort size;

		// Token: 0x0401BD23 RID: 113955
		[Token(Token = "0x4018715")]
		[FieldOffset(Offset = "0x6")]
		public DictionaryLang lang;
	}
}
