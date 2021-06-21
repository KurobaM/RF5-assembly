using System;
using Il2CppDummyDll;
using MessagePack.Formatters;

namespace MessagePack.Resolvers
{
	// Token: 0x02001013 RID: 4115
	[Token(Token = "0x2000A6B")]
	public class GeneratedResolver : IFormatterResolver
	{
		// Token: 0x060067CB RID: 26571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005665")]
		[Address(RVA = "0x22F37F0", Offset = "0x22F38F1", VA = "0x22F37F0")]
		private GeneratedResolver()
		{
		}

		// Token: 0x060067CC RID: 26572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005666")]
		public IMessagePackFormatter<T> GetFormatter<T>()
		{
			return null;
		}

		// Token: 0x0400C736 RID: 50998
		[Token(Token = "0x40093CF")]
		[FieldOffset(Offset = "0x0")]
		public static readonly IFormatterResolver Instance;

		// Token: 0x02001014 RID: 4116
		[Token(Token = "0x2001514")]
		private static class FormatterCache<T>
		{
			// Token: 0x0400C737 RID: 50999
			[Token(Token = "0x401BF73")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly IMessagePackFormatter<T> Formatter;
		}
	}
}
