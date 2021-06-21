using System;
using Il2CppDummyDll;
using nn.util;

namespace nn.irsensor
{
	// Token: 0x0200151C RID: 5404
	[Token(Token = "0x2000ED3")]
	public struct Shape : IEquatable<Shape>
	{
		// Token: 0x06007AE1 RID: 31457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600672B")]
		[Address(RVA = "0x3A0180", Offset = "0x3A0281", VA = "0x3A0180", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007AE2 RID: 31458 RVA: 0x0002B2D8 File Offset: 0x000294D8
		[Token(Token = "0x600672C")]
		[Address(RVA = "0x34DB050", Offset = "0x34DB151", VA = "0x34DB050")]
		public static bool operator ==(Shape lhs, Shape rhs)
		{
			return default(bool);
		}

		// Token: 0x06007AE3 RID: 31459 RVA: 0x0002B2F0 File Offset: 0x000294F0
		[Token(Token = "0x600672D")]
		[Address(RVA = "0x34E0AE0", Offset = "0x34E0BE1", VA = "0x34E0AE0")]
		public static bool operator !=(Shape lhs, Shape rhs)
		{
			return default(bool);
		}

		// Token: 0x06007AE4 RID: 31460 RVA: 0x0002B308 File Offset: 0x00029508
		[Token(Token = "0x600672E")]
		[Address(RVA = "0x3A0190", Offset = "0x3A0291", VA = "0x3A0190", Slot = "0")]
		public override bool Equals(object right)
		{
			return default(bool);
		}

		// Token: 0x06007AE5 RID: 31461 RVA: 0x0002B320 File Offset: 0x00029520
		[Token(Token = "0x600672F")]
		[Address(RVA = "0x3A0280", Offset = "0x3A0381", VA = "0x3A0280", Slot = "4")]
		public bool Equals(Shape other)
		{
			return default(bool);
		}

		// Token: 0x06007AE6 RID: 31462 RVA: 0x0002B338 File Offset: 0x00029538
		[Token(Token = "0x6006730")]
		[Address(RVA = "0x3A02E0", Offset = "0x3A03E1", VA = "0x3A02E0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0401BDD6 RID: 114134
		[Token(Token = "0x401876A")]
		[FieldOffset(Offset = "0x0")]
		public int firstPointIndex;

		// Token: 0x0401BDD7 RID: 114135
		[Token(Token = "0x401876B")]
		[FieldOffset(Offset = "0x4")]
		public int pointCount;

		// Token: 0x0401BDD8 RID: 114136
		[Token(Token = "0x401876C")]
		[FieldOffset(Offset = "0x8")]
		public float intensityAverage;

		// Token: 0x0401BDD9 RID: 114137
		[Token(Token = "0x401876D")]
		[FieldOffset(Offset = "0xC")]
		public Float2 intensityCentroid;
	}
}
