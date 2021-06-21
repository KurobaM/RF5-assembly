using System;
using Il2CppDummyDll;
using nn.util;

namespace nn.irsensor
{
	// Token: 0x02001514 RID: 5396
	[Token(Token = "0x2000ECF")]
	public struct Finger : IEquatable<Finger>
	{
		// Token: 0x06007A9E RID: 31390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006714")]
		[Address(RVA = "0x388B80", Offset = "0x388C81", VA = "0x388B80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007A9F RID: 31391 RVA: 0x0002AF48 File Offset: 0x00029148
		[Token(Token = "0x6006715")]
		[Address(RVA = "0x2D7D070", Offset = "0x2D7D171", VA = "0x2D7D070")]
		public static bool operator ==(Finger lhs, Finger rhs)
		{
			return default(bool);
		}

		// Token: 0x06007AA0 RID: 31392 RVA: 0x0002AF60 File Offset: 0x00029160
		[Token(Token = "0x6006716")]
		[Address(RVA = "0x2D7D140", Offset = "0x2D7D241", VA = "0x2D7D140")]
		public static bool operator !=(Finger lhs, Finger rhs)
		{
			return default(bool);
		}

		// Token: 0x06007AA1 RID: 31393 RVA: 0x0002AF78 File Offset: 0x00029178
		[Token(Token = "0x6006717")]
		[Address(RVA = "0x388B90", Offset = "0x388C91", VA = "0x388B90", Slot = "0")]
		public override bool Equals(object right)
		{
			return default(bool);
		}

		// Token: 0x06007AA2 RID: 31394 RVA: 0x0002AF90 File Offset: 0x00029190
		[Token(Token = "0x6006718")]
		[Address(RVA = "0x388BA0", Offset = "0x388CA1", VA = "0x388BA0", Slot = "4")]
		public bool Equals(Finger other)
		{
			return default(bool);
		}

		// Token: 0x06007AA3 RID: 31395 RVA: 0x0002AFA8 File Offset: 0x000291A8
		[Token(Token = "0x6006719")]
		[Address(RVA = "0x388C60", Offset = "0x388D61", VA = "0x388C60", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0401BDAB RID: 114091
		[Token(Token = "0x4018754")]
		[FieldOffset(Offset = "0x0")]
		public bool isValid;

		// Token: 0x0401BDAC RID: 114092
		[Token(Token = "0x4018755")]
		[FieldOffset(Offset = "0x4")]
		public Float2 tip;

		// Token: 0x0401BDAD RID: 114093
		[Token(Token = "0x4018756")]
		[FieldOffset(Offset = "0xC")]
		public float tipDepthFactor;

		// Token: 0x0401BDAE RID: 114094
		[Token(Token = "0x4018757")]
		[FieldOffset(Offset = "0x10")]
		public Float2 root;

		// Token: 0x0401BDAF RID: 114095
		[Token(Token = "0x4018758")]
		[FieldOffset(Offset = "0x18")]
		public int protrusionIndex;
	}
}
