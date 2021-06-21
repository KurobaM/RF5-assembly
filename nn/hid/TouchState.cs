using System;
using Il2CppDummyDll;

namespace nn.hid
{
	// Token: 0x0200156F RID: 5487
	[Token(Token = "0x2000F1C")]
	public struct TouchState : IEquatable<TouchState>
	{
		// Token: 0x06007C21 RID: 31777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067FD")]
		[Address(RVA = "0x387E50", Offset = "0x387F51", VA = "0x387E50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007C22 RID: 31778 RVA: 0x0002BDB8 File Offset: 0x00029FB8
		[Token(Token = "0x60067FE")]
		[Address(RVA = "0x2D64550", Offset = "0x2D64651", VA = "0x2D64550")]
		public static bool operator ==(TouchState lhs, TouchState rhs)
		{
			return default(bool);
		}

		// Token: 0x06007C23 RID: 31779 RVA: 0x0002BDD0 File Offset: 0x00029FD0
		[Token(Token = "0x60067FF")]
		[Address(RVA = "0x2D785B0", Offset = "0x2D786B1", VA = "0x2D785B0")]
		public static bool operator !=(TouchState lhs, TouchState rhs)
		{
			return default(bool);
		}

		// Token: 0x06007C24 RID: 31780 RVA: 0x0002BDE8 File Offset: 0x00029FE8
		[Token(Token = "0x6006800")]
		[Address(RVA = "0x387E60", Offset = "0x387F61", VA = "0x387E60", Slot = "0")]
		public override bool Equals(object right)
		{
			return default(bool);
		}

		// Token: 0x06007C25 RID: 31781 RVA: 0x0002BE00 File Offset: 0x0002A000
		[Token(Token = "0x6006801")]
		[Address(RVA = "0x387F80", Offset = "0x388081", VA = "0x387F80", Slot = "4")]
		public bool Equals(TouchState other)
		{
			return default(bool);
		}

		// Token: 0x06007C26 RID: 31782 RVA: 0x0002BE18 File Offset: 0x0002A018
		[Token(Token = "0x6006802")]
		[Address(RVA = "0x388010", Offset = "0x388111", VA = "0x388010", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0401BF8A RID: 114570
		[Token(Token = "0x40188BC")]
		[FieldOffset(Offset = "0x0")]
		public long deltaTimeNanoSeconds;

		// Token: 0x0401BF8B RID: 114571
		[Token(Token = "0x40188BD")]
		[FieldOffset(Offset = "0x8")]
		public TouchAttribute attributes;

		// Token: 0x0401BF8C RID: 114572
		[Token(Token = "0x40188BE")]
		[FieldOffset(Offset = "0xC")]
		public int fingerId;

		// Token: 0x0401BF8D RID: 114573
		[Token(Token = "0x40188BF")]
		[FieldOffset(Offset = "0x10")]
		public int x;

		// Token: 0x0401BF8E RID: 114574
		[Token(Token = "0x40188C0")]
		[FieldOffset(Offset = "0x14")]
		public int y;

		// Token: 0x0401BF8F RID: 114575
		[Token(Token = "0x40188C1")]
		[FieldOffset(Offset = "0x18")]
		public int diameterX;

		// Token: 0x0401BF90 RID: 114576
		[Token(Token = "0x40188C2")]
		[FieldOffset(Offset = "0x1C")]
		public int diameterY;

		// Token: 0x0401BF91 RID: 114577
		[Token(Token = "0x40188C3")]
		[FieldOffset(Offset = "0x20")]
		public int rotationAngle;

		// Token: 0x0401BF92 RID: 114578
		[Token(Token = "0x40188C4")]
		[FieldOffset(Offset = "0x24")]
		private int _reserved;
	}
}
