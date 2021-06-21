using System;
using Il2CppDummyDll;

namespace nn.hid
{
	// Token: 0x0200154A RID: 5450
	[Token(Token = "0x2000EF9")]
	public struct GesturePoint : IEquatable<GesturePoint>
	{
		// Token: 0x06007BA3 RID: 31651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006795")]
		[Address(RVA = "0x366990", Offset = "0x366A91", VA = "0x366990", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007BA4 RID: 31652 RVA: 0x0002BB48 File Offset: 0x00029D48
		[Token(Token = "0x6006796")]
		[Address(RVA = "0x285C360", Offset = "0x285C461", VA = "0x285C360")]
		public static bool operator ==(GesturePoint lhs, GesturePoint rhs)
		{
			return default(bool);
		}

		// Token: 0x06007BA5 RID: 31653 RVA: 0x0002BB60 File Offset: 0x00029D60
		[Token(Token = "0x6006797")]
		[Address(RVA = "0x285C380", Offset = "0x285C481", VA = "0x285C380")]
		public static bool operator !=(GesturePoint lhs, GesturePoint rhs)
		{
			return default(bool);
		}

		// Token: 0x06007BA6 RID: 31654 RVA: 0x0002BB78 File Offset: 0x00029D78
		[Token(Token = "0x6006798")]
		[Address(RVA = "0x366A30", Offset = "0x366B31", VA = "0x366A30", Slot = "0")]
		public override bool Equals(object right)
		{
			return default(bool);
		}

		// Token: 0x06007BA7 RID: 31655 RVA: 0x0002BB90 File Offset: 0x00029D90
		[Token(Token = "0x6006799")]
		[Address(RVA = "0x366AF0", Offset = "0x366BF1", VA = "0x366AF0", Slot = "4")]
		public bool Equals(GesturePoint other)
		{
			return default(bool);
		}

		// Token: 0x06007BA8 RID: 31656 RVA: 0x0002BBA8 File Offset: 0x00029DA8
		[Token(Token = "0x600679A")]
		[Address(RVA = "0x366B10", Offset = "0x366C11", VA = "0x366B10", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0401BEE5 RID: 114405
		[Token(Token = "0x401881F")]
		[FieldOffset(Offset = "0x0")]
		public int x;

		// Token: 0x0401BEE6 RID: 114406
		[Token(Token = "0x4018820")]
		[FieldOffset(Offset = "0x4")]
		public int y;
	}
}
