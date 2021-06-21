using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace UTJ
{
	// Token: 0x02000C0A RID: 3082
	[Token(Token = "0x20007ED")]
	public static class CSVUtilities
	{
		// Token: 0x06004E78 RID: 20088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004153")]
		[Address(RVA = "0x2125C50", Offset = "0x2125D51", VA = "0x2125C50")]
		public static string BuildCSVItem(string source)
		{
			return null;
		}

		// Token: 0x06004E79 RID: 20089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004154")]
		[Address(RVA = "0x2126D60", Offset = "0x2126E61", VA = "0x2126D60")]
		public static string BuildCSVItem(string source, string separatorCharacters)
		{
			return null;
		}

		// Token: 0x06004E7A RID: 20090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004155")]
		[Address(RVA = "0x2126EC0", Offset = "0x2126FC1", VA = "0x2126EC0")]
		public static IList<string> ReadNextCSVRow(TextReader reader)
		{
			return null;
		}

		// Token: 0x06004E7B RID: 20091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004156")]
		[Address(RVA = "0x2126F10", Offset = "0x2127011", VA = "0x2126F10")]
		public static IList<string> ReadNextCSVRow(TextReader reader, string separatorCharacters)
		{
			return null;
		}

		// Token: 0x0400AFAE RID: 44974
		[Token(Token = "0x400842D")]
		private const string DefaultSeparators = ",\t";

		// Token: 0x02000C0B RID: 3083
		[Token(Token = "0x2001398")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1595A0", Offset = "0x1596A1")]
		private sealed class <>c__DisplayClass1_0
		{
			// Token: 0x06004E7C RID: 20092 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60077F3")]
			[Address(RVA = "0x2126EB0", Offset = "0x2126FB1", VA = "0x2126EB0")]
			public <>c__DisplayClass1_0()
			{
			}

			// Token: 0x06004E7D RID: 20093 RVA: 0x000190C8 File Offset: 0x000172C8
			[Token(Token = "0x60077F4")]
			[Address(RVA = "0x21271A0", Offset = "0x21272A1", VA = "0x21271A0")]
			internal bool <BuildCSVItem>b__0(char token)
			{
				return default(bool);
			}

			// Token: 0x0400AFAF RID: 44975
			[Token(Token = "0x401B7CB")]
			[FieldOffset(Offset = "0x10")]
			public string source;
		}
	}
}
