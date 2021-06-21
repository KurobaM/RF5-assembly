using System;
using Il2CppDummyDll;

namespace nn.account
{
	// Token: 0x020015EE RID: 5614
	[Token(Token = "0x2000F71")]
	public struct Uid : IEquatable<Uid>
	{
		// Token: 0x17000F82 RID: 3970
		// (get) Token: 0x06008002 RID: 32770 RVA: 0x0002DF48 File Offset: 0x0002C148
		[Token(Token = "0x17000BB6")]
		public static Uid Invalid
		{
			[Token(Token = "0x6006A40")]
			[Address(RVA = "0x2850AE0", Offset = "0x2850BE1", VA = "0x2850AE0")]
			get
			{
				return default(Uid);
			}
		}

		// Token: 0x06008003 RID: 32771 RVA: 0x0002DF60 File Offset: 0x0002C160
		[Token(Token = "0x6006A41")]
		[Address(RVA = "0x363CF0", Offset = "0x363DF1", VA = "0x363CF0")]
		public bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06008004 RID: 32772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A42")]
		[Address(RVA = "0x363D10", Offset = "0x363E11", VA = "0x363D10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06008005 RID: 32773 RVA: 0x0002DF78 File Offset: 0x0002C178
		[Token(Token = "0x6006A43")]
		[Address(RVA = "0x363DB0", Offset = "0x363EB1", VA = "0x363DB0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06008006 RID: 32774 RVA: 0x0002DF90 File Offset: 0x0002C190
		[Token(Token = "0x6006A44")]
		[Address(RVA = "0x363E70", Offset = "0x363F71", VA = "0x363E70", Slot = "4")]
		public bool Equals(Uid other)
		{
			return default(bool);
		}

		// Token: 0x06008007 RID: 32775 RVA: 0x0002DFA8 File Offset: 0x0002C1A8
		[Token(Token = "0x6006A45")]
		[Address(RVA = "0x363E90", Offset = "0x363F91", VA = "0x363E90", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06008008 RID: 32776 RVA: 0x0002DFC0 File Offset: 0x0002C1C0
		[Token(Token = "0x6006A46")]
		[Address(RVA = "0x2850C90", Offset = "0x2850D91", VA = "0x2850C90")]
		public static bool operator ==(Uid lhs, Uid rhs)
		{
			return default(bool);
		}

		// Token: 0x06008009 RID: 32777 RVA: 0x0002DFD8 File Offset: 0x0002C1D8
		[Token(Token = "0x6006A47")]
		[Address(RVA = "0x2850D30", Offset = "0x2850E31", VA = "0x2850D30")]
		public static bool operator !=(Uid lhs, Uid rhs)
		{
			return default(bool);
		}

		// Token: 0x0401C17C RID: 115068
		[Token(Token = "0x40189AD")]
		[FieldOffset(Offset = "0x0")]
		public ulong _data0;

		// Token: 0x0401C17D RID: 115069
		[Token(Token = "0x40189AE")]
		[FieldOffset(Offset = "0x8")]
		public ulong _data1;
	}
}
