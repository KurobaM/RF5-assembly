using System;
using Il2CppDummyDll;

namespace nn.fs
{
	// Token: 0x020015AE RID: 5550
	[Token(Token = "0x2000F39")]
	public struct DirectoryEntry
	{
		// Token: 0x17000F1C RID: 3868
		// (get) Token: 0x06007DDF RID: 32223 RVA: 0x0002CCB8 File Offset: 0x0002AEB8
		// (set) Token: 0x06007DE0 RID: 32224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B56")]
		public EntryType entryType
		{
			[Token(Token = "0x6006845")]
			[Address(RVA = "0x366000", Offset = "0x366101", VA = "0x366000")]
			get
			{
				return EntryType.Directory;
			}
			[Token(Token = "0x6006846")]
			[Address(RVA = "0x366010", Offset = "0x366111", VA = "0x366010")]
			set
			{
			}
		}

		// Token: 0x06007DE1 RID: 32225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006847")]
		[Address(RVA = "0x366020", Offset = "0x366121", VA = "0x366020", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0401C0DB RID: 114907
		[Token(Token = "0x4018937")]
		[FieldOffset(Offset = "0x0")]
		public string name;

		// Token: 0x0401C0DC RID: 114908
		[Token(Token = "0x4018938")]
		[FieldOffset(Offset = "0x8")]
		private byte _reserved0;

		// Token: 0x0401C0DD RID: 114909
		[Token(Token = "0x4018939")]
		[FieldOffset(Offset = "0x9")]
		private byte _reserved1;

		// Token: 0x0401C0DE RID: 114910
		[Token(Token = "0x401893A")]
		[FieldOffset(Offset = "0xA")]
		private byte _reserved2;

		// Token: 0x0401C0DF RID: 114911
		[Token(Token = "0x401893B")]
		[FieldOffset(Offset = "0xB")]
		private sbyte _entryType;

		// Token: 0x0401C0E0 RID: 114912
		[Token(Token = "0x401893C")]
		[FieldOffset(Offset = "0xC")]
		private byte _reserved3;

		// Token: 0x0401C0E1 RID: 114913
		[Token(Token = "0x401893D")]
		[FieldOffset(Offset = "0xD")]
		private byte _reserved4;

		// Token: 0x0401C0E2 RID: 114914
		[Token(Token = "0x401893E")]
		[FieldOffset(Offset = "0xE")]
		private byte _reserved5;

		// Token: 0x0401C0E3 RID: 114915
		[Token(Token = "0x401893F")]
		[FieldOffset(Offset = "0x10")]
		private long fileSize;
	}
}
