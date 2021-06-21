using System;
using Il2CppDummyDll;

namespace nn
{
	// Token: 0x020014E4 RID: 5348
	[Token(Token = "0x2000EA7")]
	public struct Result : IEquatable<Result>
	{
		// Token: 0x060079D5 RID: 31189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006677")]
		[Address(RVA = "0x363900", Offset = "0x363A01", VA = "0x363900")]
		public Result(int module, int description)
		{
		}

		// Token: 0x060079D6 RID: 31190 RVA: 0x0002A720 File Offset: 0x00028920
		[Token(Token = "0x6006678")]
		[Address(RVA = "0x363910", Offset = "0x363A11", VA = "0x363910")]
		public bool IsSuccess()
		{
			return default(bool);
		}

		// Token: 0x060079D7 RID: 31191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006679")]
		[Address(RVA = "0x363920", Offset = "0x363A21", VA = "0x363920")]
		public void abortUnlessSuccess()
		{
		}

		// Token: 0x060079D8 RID: 31192 RVA: 0x0002A738 File Offset: 0x00028938
		[Token(Token = "0x600667A")]
		[Address(RVA = "0x363960", Offset = "0x363A61", VA = "0x363960")]
		public int GetModule()
		{
			return 0;
		}

		// Token: 0x060079D9 RID: 31193 RVA: 0x0002A750 File Offset: 0x00028950
		[Token(Token = "0x600667B")]
		[Address(RVA = "0x363970", Offset = "0x363A71", VA = "0x363970")]
		public int GetDescription()
		{
			return 0;
		}

		// Token: 0x060079DA RID: 31194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600667C")]
		[Address(RVA = "0x363980", Offset = "0x363A81", VA = "0x363980", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060079DB RID: 31195 RVA: 0x0002A768 File Offset: 0x00028968
		[Token(Token = "0x600667D")]
		[Address(RVA = "0x363990", Offset = "0x363A91", VA = "0x363990", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060079DC RID: 31196 RVA: 0x0002A780 File Offset: 0x00028980
		[Token(Token = "0x600667E")]
		[Address(RVA = "0x363A40", Offset = "0x363B41", VA = "0x363A40", Slot = "4")]
		public bool Equals(Result other)
		{
			return default(bool);
		}

		// Token: 0x060079DD RID: 31197 RVA: 0x0002A798 File Offset: 0x00028998
		[Token(Token = "0x600667F")]
		[Address(RVA = "0x363A50", Offset = "0x363B51", VA = "0x363A50", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060079DE RID: 31198 RVA: 0x0002A7B0 File Offset: 0x000289B0
		[Token(Token = "0x6006680")]
		[Address(RVA = "0x284FB70", Offset = "0x284FC71", VA = "0x284FB70")]
		public static bool operator ==(Result lhs, Result rhs)
		{
			return default(bool);
		}

		// Token: 0x060079DF RID: 31199 RVA: 0x0002A7C8 File Offset: 0x000289C8
		[Token(Token = "0x6006681")]
		[Address(RVA = "0x284FC00", Offset = "0x284FD01", VA = "0x284FC00")]
		public static bool operator !=(Result lhs, Result rhs)
		{
			return default(bool);
		}

		// Token: 0x0401BC95 RID: 113813
		[Token(Token = "0x4018687")]
		public const int ModuleBitsOffset = 0;

		// Token: 0x0401BC96 RID: 113814
		[Token(Token = "0x4018688")]
		public const int ModuleBitsCount = 9;

		// Token: 0x0401BC97 RID: 113815
		[Token(Token = "0x4018689")]
		public const int ModuleBitsMask = 511;

		// Token: 0x0401BC98 RID: 113816
		[Token(Token = "0x401868A")]
		public const int DescriptionBitsOffset = 9;

		// Token: 0x0401BC99 RID: 113817
		[Token(Token = "0x401868B")]
		public const int DescriptionBitsCount = 13;

		// Token: 0x0401BC9A RID: 113818
		[Token(Token = "0x401868C")]
		public const int DescriptionBitsMask = 8191;

		// Token: 0x0401BC9B RID: 113819
		[Token(Token = "0x401868D")]
		[FieldOffset(Offset = "0x0")]
		public uint innerValue;
	}
}
