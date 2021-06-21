using System;
using Il2CppDummyDll;

namespace nn.irsensor
{
	// Token: 0x02001512 RID: 5394
	[Token(Token = "0x2000ECD")]
	public struct HandAnalysisConfig : IEquatable<HandAnalysisConfig>
	{
		// Token: 0x06007A92 RID: 31378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006708")]
		[Address(RVA = "0x39E7D0", Offset = "0x39E8D1", VA = "0x39E7D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007A93 RID: 31379 RVA: 0x0002AE58 File Offset: 0x00029058
		[Token(Token = "0x6006709")]
		[Address(RVA = "0x34D9EA0", Offset = "0x34D9FA1", VA = "0x34D9EA0")]
		public static bool operator ==(HandAnalysisConfig lhs, HandAnalysisConfig rhs)
		{
			return default(bool);
		}

		// Token: 0x06007A94 RID: 31380 RVA: 0x0002AE70 File Offset: 0x00029070
		[Token(Token = "0x600670A")]
		[Address(RVA = "0x34D9EB0", Offset = "0x34D9FB1", VA = "0x34D9EB0")]
		public static bool operator !=(HandAnalysisConfig lhs, HandAnalysisConfig rhs)
		{
			return default(bool);
		}

		// Token: 0x06007A95 RID: 31381 RVA: 0x0002AE88 File Offset: 0x00029088
		[Token(Token = "0x600670B")]
		[Address(RVA = "0x39E850", Offset = "0x39E951", VA = "0x39E850", Slot = "0")]
		public override bool Equals(object right)
		{
			return default(bool);
		}

		// Token: 0x06007A96 RID: 31382 RVA: 0x0002AEA0 File Offset: 0x000290A0
		[Token(Token = "0x600670C")]
		[Address(RVA = "0x39E900", Offset = "0x39EA01", VA = "0x39E900", Slot = "4")]
		public bool Equals(HandAnalysisConfig other)
		{
			return default(bool);
		}

		// Token: 0x06007A97 RID: 31383 RVA: 0x0002AEB8 File Offset: 0x000290B8
		[Token(Token = "0x600670D")]
		[Address(RVA = "0x39E910", Offset = "0x39EA11", VA = "0x39E910", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0401BDA8 RID: 114088
		[Token(Token = "0x4018751")]
		[FieldOffset(Offset = "0x0")]
		public HandAnalysisMode mode;
	}
}
