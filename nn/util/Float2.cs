using System;
using Il2CppDummyDll;

namespace nn.util
{
	// Token: 0x020014E7 RID: 5351
	[Token(Token = "0x2000EAA")]
	public struct Float2 : IEquatable<Float2>
	{
		// Token: 0x060079EC RID: 31212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600668E")]
		[Address(RVA = "0x3A1580", Offset = "0x3A1681", VA = "0x3A1580")]
		public Float2(float x, float y)
		{
		}

		// Token: 0x060079ED RID: 31213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600668F")]
		[Address(RVA = "0x3A1590", Offset = "0x3A1691", VA = "0x3A1590")]
		public void Set(float x, float y)
		{
		}

		// Token: 0x060079EE RID: 31214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006690")]
		[Address(RVA = "0x3A15A0", Offset = "0x3A16A1", VA = "0x3A15A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060079EF RID: 31215 RVA: 0x0002A8B8 File Offset: 0x00028AB8
		[Token(Token = "0x6006691")]
		[Address(RVA = "0x34DFDD0", Offset = "0x34DFED1", VA = "0x34DFDD0")]
		public static bool operator ==(Float2 lhs, Float2 rhs)
		{
			return default(bool);
		}

		// Token: 0x060079F0 RID: 31216 RVA: 0x0002A8D0 File Offset: 0x00028AD0
		[Token(Token = "0x6006692")]
		[Address(RVA = "0x34E5BA0", Offset = "0x34E5CA1", VA = "0x34E5BA0")]
		public static bool operator !=(Float2 lhs, Float2 rhs)
		{
			return default(bool);
		}

		// Token: 0x060079F1 RID: 31217 RVA: 0x0002A8E8 File Offset: 0x00028AE8
		[Token(Token = "0x6006693")]
		[Address(RVA = "0x3A1640", Offset = "0x3A1741", VA = "0x3A1640", Slot = "0")]
		public override bool Equals(object right)
		{
			return default(bool);
		}

		// Token: 0x060079F2 RID: 31218 RVA: 0x0002A900 File Offset: 0x00028B00
		[Token(Token = "0x6006694")]
		[Address(RVA = "0x3A1700", Offset = "0x3A1801", VA = "0x3A1700", Slot = "4")]
		public bool Equals(Float2 other)
		{
			return default(bool);
		}

		// Token: 0x060079F3 RID: 31219 RVA: 0x0002A918 File Offset: 0x00028B18
		[Token(Token = "0x6006695")]
		[Address(RVA = "0x3A1720", Offset = "0x3A1821", VA = "0x3A1720", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0401BCA3 RID: 113827
		[Token(Token = "0x4018695")]
		[FieldOffset(Offset = "0x0")]
		public float x;

		// Token: 0x0401BCA4 RID: 113828
		[Token(Token = "0x4018696")]
		[FieldOffset(Offset = "0x4")]
		public float y;
	}
}
