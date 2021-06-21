using System;
using Il2CppDummyDll;

namespace Common
{
	// Token: 0x020011BF RID: 4543
	[Token(Token = "0x2000B95")]
	public class ComparisonOperatorsUtility
	{
		// Token: 0x06007100 RID: 28928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DBF")]
		public static Func<T, T, bool> GetComparisonOperator<T>(ComparisonOperatorsType type) where T : IComparable
		{
			return null;
		}

		// Token: 0x06007101 RID: 28929 RVA: 0x00026E50 File Offset: 0x00025050
		[Token(Token = "0x6005DC0")]
		public static bool Equality<T>(T value1, T value2) where T : IComparable
		{
			return default(bool);
		}

		// Token: 0x06007102 RID: 28930 RVA: 0x00026E68 File Offset: 0x00025068
		[Token(Token = "0x6005DC1")]
		public static bool Inequality<T>(T value1, T value2) where T : IComparable
		{
			return default(bool);
		}

		// Token: 0x06007103 RID: 28931 RVA: 0x00026E80 File Offset: 0x00025080
		[Token(Token = "0x6005DC2")]
		public static bool Greaterthan<T>(T value1, T value2)
		{
			return default(bool);
		}

		// Token: 0x06007104 RID: 28932 RVA: 0x00026E98 File Offset: 0x00025098
		[Token(Token = "0x6005DC3")]
		public static bool Greaterthanorequal<T>(T value1, T value2)
		{
			return default(bool);
		}

		// Token: 0x06007105 RID: 28933 RVA: 0x00026EB0 File Offset: 0x000250B0
		[Token(Token = "0x6005DC4")]
		public static bool Lessthan<T>(T value1, T value2)
		{
			return default(bool);
		}

		// Token: 0x06007106 RID: 28934 RVA: 0x00026EC8 File Offset: 0x000250C8
		[Token(Token = "0x6005DC5")]
		public static bool Lessthanorequal<T>(T value1, T value2)
		{
			return default(bool);
		}

		// Token: 0x06007107 RID: 28935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DC6")]
		[Address(RVA = "0x20DB6C0", Offset = "0x20DB7C1", VA = "0x20DB6C0")]
		public ComparisonOperatorsUtility()
		{
		}

		// Token: 0x020011C0 RID: 4544
		[Token(Token = "0x2001596")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15A2E0", Offset = "0x15A3E1")]
		[Serializable]
		private sealed class <>c__0<T> where T : IComparable
		{
			// Token: 0x06007109 RID: 28937 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DF1")]
			public <>c__0()
			{
			}

			// Token: 0x0600710A RID: 28938 RVA: 0x00026EE0 File Offset: 0x000250E0
			[Token(Token = "0x6007DF2")]
			internal bool <GetComparisonOperator>b__0_0(T value1, T value2)
			{
				return default(bool);
			}

			// Token: 0x040182EF RID: 99055
			[Token(Token = "0x401C19E")]
			[FieldOffset(Offset = "0x0")]
			public static readonly ComparisonOperatorsUtility.<>c__0<T> <>9;

			// Token: 0x040182F0 RID: 99056
			[Token(Token = "0x401C19F")]
			[FieldOffset(Offset = "0x0")]
			public static Func<T, T, bool> <>9__0_0;
		}
	}
}
