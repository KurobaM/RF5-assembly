using System;
using Il2CppDummyDll;

namespace nn.util
{
	// Token: 0x020014E6 RID: 5350
	[Token(Token = "0x2000EA9")]
	public struct Color4u8 : IEquatable<Color4u8>
	{
		// Token: 0x060079E5 RID: 31205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006687")]
		[Address(RVA = "0x3A1350", Offset = "0x3A1451", VA = "0x3A1350")]
		public void Set(byte r, byte g, byte b, byte a)
		{
		}

		// Token: 0x060079E6 RID: 31206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006688")]
		[Address(RVA = "0x3A1370", Offset = "0x3A1471", VA = "0x3A1370", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060079E7 RID: 31207 RVA: 0x0002A840 File Offset: 0x00028A40
		[Token(Token = "0x6006689")]
		[Address(RVA = "0x34E5850", Offset = "0x34E5951", VA = "0x34E5850")]
		public static bool operator ==(Color4u8 lhs, Color4u8 rhs)
		{
			return default(bool);
		}

		// Token: 0x060079E8 RID: 31208 RVA: 0x0002A858 File Offset: 0x00028A58
		[Token(Token = "0x600668A")]
		[Address(RVA = "0x34E5890", Offset = "0x34E5991", VA = "0x34E5890")]
		public static bool operator !=(Color4u8 lhs, Color4u8 rhs)
		{
			return default(bool);
		}

		// Token: 0x060079E9 RID: 31209 RVA: 0x0002A870 File Offset: 0x00028A70
		[Token(Token = "0x600668B")]
		[Address(RVA = "0x3A1380", Offset = "0x3A1481", VA = "0x3A1380", Slot = "0")]
		public override bool Equals(object right)
		{
			return default(bool);
		}

		// Token: 0x060079EA RID: 31210 RVA: 0x0002A888 File Offset: 0x00028A88
		[Token(Token = "0x600668C")]
		[Address(RVA = "0x3A14A0", Offset = "0x3A15A1", VA = "0x3A14A0", Slot = "4")]
		public bool Equals(Color4u8 other)
		{
			return default(bool);
		}

		// Token: 0x060079EB RID: 31211 RVA: 0x0002A8A0 File Offset: 0x00028AA0
		[Token(Token = "0x600668D")]
		[Address(RVA = "0x3A1500", Offset = "0x3A1601", VA = "0x3A1500", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0401BC9F RID: 113823
		[Token(Token = "0x4018691")]
		[FieldOffset(Offset = "0x0")]
		public byte r;

		// Token: 0x0401BCA0 RID: 113824
		[Token(Token = "0x4018692")]
		[FieldOffset(Offset = "0x1")]
		public byte g;

		// Token: 0x0401BCA1 RID: 113825
		[Token(Token = "0x4018693")]
		[FieldOffset(Offset = "0x2")]
		public byte b;

		// Token: 0x0401BCA2 RID: 113826
		[Token(Token = "0x4018694")]
		[FieldOffset(Offset = "0x3")]
		public byte a;
	}
}
