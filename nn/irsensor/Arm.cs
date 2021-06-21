using System;
using Il2CppDummyDll;
using nn.util;

namespace nn.irsensor
{
	// Token: 0x02001516 RID: 5398
	[Token(Token = "0x2000ED1")]
	public struct Arm : IEquatable<Arm>
	{
		// Token: 0x06007AAA RID: 31402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006720")]
		[Address(RVA = "0x388520", Offset = "0x388621", VA = "0x388520", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007AAB RID: 31403 RVA: 0x0002B038 File Offset: 0x00029238
		[Token(Token = "0x6006721")]
		[Address(RVA = "0x2D7A6F0", Offset = "0x2D7A7F1", VA = "0x2D7A6F0")]
		public static bool operator ==(Arm lhs, Arm rhs)
		{
			return default(bool);
		}

		// Token: 0x06007AAC RID: 31404 RVA: 0x0002B050 File Offset: 0x00029250
		[Token(Token = "0x6006722")]
		[Address(RVA = "0x2D7A7A0", Offset = "0x2D7A8A1", VA = "0x2D7A7A0")]
		public static bool operator !=(Arm lhs, Arm rhs)
		{
			return default(bool);
		}

		// Token: 0x06007AAD RID: 31405 RVA: 0x0002B068 File Offset: 0x00029268
		[Token(Token = "0x6006723")]
		[Address(RVA = "0x388530", Offset = "0x388631", VA = "0x388530", Slot = "0")]
		public override bool Equals(object right)
		{
			return default(bool);
		}

		// Token: 0x06007AAE RID: 31406 RVA: 0x0002B080 File Offset: 0x00029280
		[Token(Token = "0x6006724")]
		[Address(RVA = "0x388540", Offset = "0x388641", VA = "0x388540", Slot = "4")]
		public bool Equals(Arm other)
		{
			return default(bool);
		}

		// Token: 0x06007AAF RID: 31407 RVA: 0x0002B098 File Offset: 0x00029298
		[Token(Token = "0x6006725")]
		[Address(RVA = "0x3885E0", Offset = "0x3886E1", VA = "0x3885E0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0401BDB3 RID: 114099
		[Token(Token = "0x401875C")]
		[FieldOffset(Offset = "0x0")]
		public bool isValid;

		// Token: 0x0401BDB4 RID: 114100
		[Token(Token = "0x401875D")]
		[FieldOffset(Offset = "0x4")]
		public Float2 wristPosition;

		// Token: 0x0401BDB5 RID: 114101
		[Token(Token = "0x401875E")]
		[FieldOffset(Offset = "0xC")]
		public Float2 armDirection;

		// Token: 0x0401BDB6 RID: 114102
		[Token(Token = "0x401875F")]
		[FieldOffset(Offset = "0x14")]
		public int protrusionIndex;
	}
}
