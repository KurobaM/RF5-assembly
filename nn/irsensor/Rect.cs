using System;
using Il2CppDummyDll;

namespace nn.irsensor
{
	// Token: 0x02001526 RID: 5414
	[Token(Token = "0x2000ED9")]
	public struct Rect : IEquatable<Rect>
	{
		// Token: 0x06007B1B RID: 31515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006739")]
		[Address(RVA = "0x39FF50", Offset = "0x3A0051", VA = "0x39FF50")]
		public Rect(short x, short y, short width, short height)
		{
		}

		// Token: 0x06007B1C RID: 31516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600673A")]
		[Address(RVA = "0x39FF70", Offset = "0x3A0071", VA = "0x39FF70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007B1D RID: 31517 RVA: 0x0002B500 File Offset: 0x00029700
		[Token(Token = "0x600673B")]
		[Address(RVA = "0x34DD6C0", Offset = "0x34DD7C1", VA = "0x34DD6C0")]
		public static bool operator ==(Rect lhs, Rect rhs)
		{
			return default(bool);
		}

		// Token: 0x06007B1E RID: 31518 RVA: 0x0002B518 File Offset: 0x00029718
		[Token(Token = "0x600673C")]
		[Address(RVA = "0x34E06A0", Offset = "0x34E07A1", VA = "0x34E06A0")]
		public static bool operator !=(Rect lhs, Rect rhs)
		{
			return default(bool);
		}

		// Token: 0x06007B1F RID: 31519 RVA: 0x0002B530 File Offset: 0x00029730
		[Token(Token = "0x600673D")]
		[Address(RVA = "0x39FF80", Offset = "0x3A0081", VA = "0x39FF80", Slot = "0")]
		public override bool Equals(object right)
		{
			return default(bool);
		}

		// Token: 0x06007B20 RID: 31520 RVA: 0x0002B548 File Offset: 0x00029748
		[Token(Token = "0x600673E")]
		[Address(RVA = "0x3A00A0", Offset = "0x3A01A1", VA = "0x3A00A0", Slot = "4")]
		public bool Equals(Rect other)
		{
			return default(bool);
		}

		// Token: 0x06007B21 RID: 31521 RVA: 0x0002B560 File Offset: 0x00029760
		[Token(Token = "0x600673F")]
		[Address(RVA = "0x3A0100", Offset = "0x3A0201", VA = "0x3A0100", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0401BE04 RID: 114180
		[Token(Token = "0x401877E")]
		[FieldOffset(Offset = "0x0")]
		public short x;

		// Token: 0x0401BE05 RID: 114181
		[Token(Token = "0x401877F")]
		[FieldOffset(Offset = "0x2")]
		public short y;

		// Token: 0x0401BE06 RID: 114182
		[Token(Token = "0x4018780")]
		[FieldOffset(Offset = "0x4")]
		public short width;

		// Token: 0x0401BE07 RID: 114183
		[Token(Token = "0x4018781")]
		[FieldOffset(Offset = "0x6")]
		public short height;
	}
}
