using System;
using Il2CppDummyDll;
using nn.util;

namespace nn.irsensor
{
	// Token: 0x02001515 RID: 5397
	[Token(Token = "0x2000ED0")]
	public struct Palm : IEquatable<Palm>
	{
		// Token: 0x06007AA4 RID: 31396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600671A")]
		[Address(RVA = "0x39FBA0", Offset = "0x39FCA1", VA = "0x39FBA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007AA5 RID: 31397 RVA: 0x0002AFC0 File Offset: 0x000291C0
		[Token(Token = "0x600671B")]
		[Address(RVA = "0x34E0080", Offset = "0x34E0181", VA = "0x34E0080")]
		public static bool operator ==(Palm lhs, Palm rhs)
		{
			return default(bool);
		}

		// Token: 0x06007AA6 RID: 31398 RVA: 0x0002AFD8 File Offset: 0x000291D8
		[Token(Token = "0x600671C")]
		[Address(RVA = "0x34E00B0", Offset = "0x34E01B1", VA = "0x34E00B0")]
		public static bool operator !=(Palm lhs, Palm rhs)
		{
			return default(bool);
		}

		// Token: 0x06007AA7 RID: 31399 RVA: 0x0002AFF0 File Offset: 0x000291F0
		[Token(Token = "0x600671D")]
		[Address(RVA = "0x39FBB0", Offset = "0x39FCB1", VA = "0x39FBB0", Slot = "0")]
		public override bool Equals(object right)
		{
			return default(bool);
		}

		// Token: 0x06007AA8 RID: 31400 RVA: 0x0002B008 File Offset: 0x00029208
		[Token(Token = "0x600671E")]
		[Address(RVA = "0x39FC90", Offset = "0x39FD91", VA = "0x39FC90", Slot = "4")]
		public bool Equals(Palm other)
		{
			return default(bool);
		}

		// Token: 0x06007AA9 RID: 31401 RVA: 0x0002B020 File Offset: 0x00029220
		[Token(Token = "0x600671F")]
		[Address(RVA = "0x39FCD0", Offset = "0x39FDD1", VA = "0x39FCD0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0401BDB0 RID: 114096
		[Token(Token = "0x4018759")]
		[FieldOffset(Offset = "0x0")]
		public Float2 center;

		// Token: 0x0401BDB1 RID: 114097
		[Token(Token = "0x401875A")]
		[FieldOffset(Offset = "0x8")]
		public float area;

		// Token: 0x0401BDB2 RID: 114098
		[Token(Token = "0x401875B")]
		[FieldOffset(Offset = "0xC")]
		public float depthFactor;
	}
}
