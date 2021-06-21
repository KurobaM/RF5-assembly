using System;
using Il2CppDummyDll;

namespace nn.irsensor
{
	// Token: 0x02001513 RID: 5395
	[Token(Token = "0x2000ECE")]
	public struct Protrusion : IEquatable<Protrusion>
	{
		// Token: 0x06007A98 RID: 31384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600670E")]
		[Address(RVA = "0x39FD50", Offset = "0x39FE51", VA = "0x39FD50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007A99 RID: 31385 RVA: 0x0002AED0 File Offset: 0x000290D0
		[Token(Token = "0x600670F")]
		[Address(RVA = "0x34D9040", Offset = "0x34D9141", VA = "0x34D9040")]
		public static bool operator ==(Protrusion lhs, Protrusion rhs)
		{
			return default(bool);
		}

		// Token: 0x06007A9A RID: 31386 RVA: 0x0002AEE8 File Offset: 0x000290E8
		[Token(Token = "0x6006710")]
		[Address(RVA = "0x34E0320", Offset = "0x34E0421", VA = "0x34E0320")]
		public static bool operator !=(Protrusion lhs, Protrusion rhs)
		{
			return default(bool);
		}

		// Token: 0x06007A9B RID: 31387 RVA: 0x0002AF00 File Offset: 0x00029100
		[Token(Token = "0x6006711")]
		[Address(RVA = "0x39FDF0", Offset = "0x39FEF1", VA = "0x39FDF0", Slot = "0")]
		public override bool Equals(object right)
		{
			return default(bool);
		}

		// Token: 0x06007A9C RID: 31388 RVA: 0x0002AF18 File Offset: 0x00029118
		[Token(Token = "0x6006712")]
		[Address(RVA = "0x39FEB0", Offset = "0x39FFB1", VA = "0x39FEB0", Slot = "4")]
		public bool Equals(Protrusion other)
		{
			return default(bool);
		}

		// Token: 0x06007A9D RID: 31389 RVA: 0x0002AF30 File Offset: 0x00029130
		[Token(Token = "0x6006713")]
		[Address(RVA = "0x39FED0", Offset = "0x39FFD1", VA = "0x39FED0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0401BDA9 RID: 114089
		[Token(Token = "0x4018752")]
		[FieldOffset(Offset = "0x0")]
		public int firstPointIndex;

		// Token: 0x0401BDAA RID: 114090
		[Token(Token = "0x4018753")]
		[FieldOffset(Offset = "0x4")]
		public int pointCount;
	}
}
