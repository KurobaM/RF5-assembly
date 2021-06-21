using System;
using Il2CppDummyDll;
using nn.util;

namespace nn.irsensor
{
	// Token: 0x02001535 RID: 5429
	[Token(Token = "0x2000EE8")]
	public struct MomentStatistic : IEquatable<MomentStatistic>
	{
		// Token: 0x06007B4E RID: 31566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600676C")]
		[Address(RVA = "0x39F970", Offset = "0x39FA71", VA = "0x39F970", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007B4F RID: 31567 RVA: 0x0002B728 File Offset: 0x00029928
		[Token(Token = "0x600676D")]
		[Address(RVA = "0x34DE240", Offset = "0x34DE341", VA = "0x34DE240")]
		public static bool operator ==(MomentStatistic lhs, MomentStatistic rhs)
		{
			return default(bool);
		}

		// Token: 0x06007B50 RID: 31568 RVA: 0x0002B740 File Offset: 0x00029940
		[Token(Token = "0x600676E")]
		[Address(RVA = "0x34DFDF0", Offset = "0x34DFEF1", VA = "0x34DFDF0")]
		public static bool operator !=(MomentStatistic lhs, MomentStatistic rhs)
		{
			return default(bool);
		}

		// Token: 0x06007B51 RID: 31569 RVA: 0x0002B758 File Offset: 0x00029958
		[Token(Token = "0x600676F")]
		[Address(RVA = "0x39FA10", Offset = "0x39FB11", VA = "0x39FA10", Slot = "0")]
		public override bool Equals(object right)
		{
			return default(bool);
		}

		// Token: 0x06007B52 RID: 31570 RVA: 0x0002B770 File Offset: 0x00029970
		[Token(Token = "0x6006770")]
		[Address(RVA = "0x39FAF0", Offset = "0x39FBF1", VA = "0x39FAF0", Slot = "4")]
		public bool Equals(MomentStatistic other)
		{
			return default(bool);
		}

		// Token: 0x06007B53 RID: 31571 RVA: 0x0002B788 File Offset: 0x00029988
		[Token(Token = "0x6006771")]
		[Address(RVA = "0x39FB20", Offset = "0x39FC21", VA = "0x39FB20", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0401BE55 RID: 114261
		[Token(Token = "0x40187CF")]
		[FieldOffset(Offset = "0x0")]
		public float averageIntensity;

		// Token: 0x0401BE56 RID: 114262
		[Token(Token = "0x40187D0")]
		[FieldOffset(Offset = "0x4")]
		public Float2 centroid;
	}
}
