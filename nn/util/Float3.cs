using System;
using Il2CppDummyDll;

namespace nn.util
{
	// Token: 0x020014E8 RID: 5352
	[Token(Token = "0x2000EAB")]
	public struct Float3 : IEquatable<Float3>
	{
		// Token: 0x060079F4 RID: 31220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006696")]
		[Address(RVA = "0x3A17A0", Offset = "0x3A18A1", VA = "0x3A17A0")]
		public Float3(float x, float y, float z)
		{
		}

		// Token: 0x060079F5 RID: 31221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006697")]
		[Address(RVA = "0x3A17B0", Offset = "0x3A18B1", VA = "0x3A17B0")]
		public void Set(float x, float y, float z)
		{
		}

		// Token: 0x060079F6 RID: 31222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006698")]
		[Address(RVA = "0x3A17C0", Offset = "0x3A18C1", VA = "0x3A17C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060079F7 RID: 31223 RVA: 0x0002A930 File Offset: 0x00028B30
		[Token(Token = "0x6006699")]
		[Address(RVA = "0x34E5E00", Offset = "0x34E5F01", VA = "0x34E5E00")]
		public static bool operator ==(Float3 lhs, Float3 rhs)
		{
			return default(bool);
		}

		// Token: 0x060079F8 RID: 31224 RVA: 0x0002A948 File Offset: 0x00028B48
		[Token(Token = "0x600669A")]
		[Address(RVA = "0x34E5E30", Offset = "0x34E5F31", VA = "0x34E5E30")]
		public static bool operator !=(Float3 lhs, Float3 rhs)
		{
			return default(bool);
		}

		// Token: 0x060079F9 RID: 31225 RVA: 0x0002A960 File Offset: 0x00028B60
		[Token(Token = "0x600669B")]
		[Address(RVA = "0x3A17D0", Offset = "0x3A18D1", VA = "0x3A17D0", Slot = "0")]
		public override bool Equals(object right)
		{
			return default(bool);
		}

		// Token: 0x060079FA RID: 31226 RVA: 0x0002A978 File Offset: 0x00028B78
		[Token(Token = "0x600669C")]
		[Address(RVA = "0x3A18B0", Offset = "0x3A19B1", VA = "0x3A18B0", Slot = "4")]
		public bool Equals(Float3 other)
		{
			return default(bool);
		}

		// Token: 0x060079FB RID: 31227 RVA: 0x0002A990 File Offset: 0x00028B90
		[Token(Token = "0x600669D")]
		[Address(RVA = "0x3A18E0", Offset = "0x3A19E1", VA = "0x3A18E0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0401BCA5 RID: 113829
		[Token(Token = "0x4018697")]
		[FieldOffset(Offset = "0x0")]
		public float x;

		// Token: 0x0401BCA6 RID: 113830
		[Token(Token = "0x4018698")]
		[FieldOffset(Offset = "0x4")]
		public float y;

		// Token: 0x0401BCA7 RID: 113831
		[Token(Token = "0x4018699")]
		[FieldOffset(Offset = "0x8")]
		public float z;
	}
}
