using System;
using Il2CppDummyDll;

namespace nn.util
{
	// Token: 0x020014E9 RID: 5353
	[Token(Token = "0x2000EAC")]
	public struct Float4 : IEquatable<Float4>
	{
		// Token: 0x060079FC RID: 31228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600669E")]
		[Address(RVA = "0x3A1960", Offset = "0x3A1A61", VA = "0x3A1960")]
		public Float4(float x, float y, float z, float w)
		{
		}

		// Token: 0x060079FD RID: 31229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600669F")]
		[Address(RVA = "0x3A1980", Offset = "0x3A1A81", VA = "0x3A1980")]
		public void Set(float x, float y, float z, float w)
		{
		}

		// Token: 0x060079FE RID: 31230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066A0")]
		[Address(RVA = "0x3A19A0", Offset = "0x3A1AA1", VA = "0x3A19A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060079FF RID: 31231 RVA: 0x0002A9A8 File Offset: 0x00028BA8
		[Token(Token = "0x60066A1")]
		[Address(RVA = "0x34E6210", Offset = "0x34E6311", VA = "0x34E6210")]
		public static bool operator ==(Float4 lhs, Float4 rhs)
		{
			return default(bool);
		}

		// Token: 0x06007A00 RID: 31232 RVA: 0x0002A9C0 File Offset: 0x00028BC0
		[Token(Token = "0x60066A2")]
		[Address(RVA = "0x34E6240", Offset = "0x34E6341", VA = "0x34E6240")]
		public static bool operator !=(Float4 lhs, Float4 rhs)
		{
			return default(bool);
		}

		// Token: 0x06007A01 RID: 31233 RVA: 0x0002A9D8 File Offset: 0x00028BD8
		[Token(Token = "0x60066A3")]
		[Address(RVA = "0x3A19B0", Offset = "0x3A1AB1", VA = "0x3A19B0", Slot = "0")]
		public override bool Equals(object right)
		{
			return default(bool);
		}

		// Token: 0x06007A02 RID: 31234 RVA: 0x0002A9F0 File Offset: 0x00028BF0
		[Token(Token = "0x60066A4")]
		[Address(RVA = "0x3A1A90", Offset = "0x3A1B91", VA = "0x3A1A90", Slot = "4")]
		public bool Equals(Float4 other)
		{
			return default(bool);
		}

		// Token: 0x06007A03 RID: 31235 RVA: 0x0002AA08 File Offset: 0x00028C08
		[Token(Token = "0x60066A5")]
		[Address(RVA = "0x3A1AD0", Offset = "0x3A1BD1", VA = "0x3A1AD0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0401BCA8 RID: 113832
		[Token(Token = "0x401869A")]
		[FieldOffset(Offset = "0x0")]
		public float x;

		// Token: 0x0401BCA9 RID: 113833
		[Token(Token = "0x401869B")]
		[FieldOffset(Offset = "0x4")]
		public float y;

		// Token: 0x0401BCAA RID: 113834
		[Token(Token = "0x401869C")]
		[FieldOffset(Offset = "0x8")]
		public float z;

		// Token: 0x0401BCAB RID: 113835
		[Token(Token = "0x401869D")]
		[FieldOffset(Offset = "0xC")]
		public float w;
	}
}
