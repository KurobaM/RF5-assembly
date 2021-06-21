using System;
using Il2CppDummyDll;

namespace MessagePack.Formatters
{
	// Token: 0x02000FE1 RID: 4065
	[Token(Token = "0x2000A39")]
	public sealed class IntArrayFormatter : IMessagePackFormatter<IntArray>, IMessagePackFormatter
	{
		// Token: 0x060066EC RID: 26348 RVA: 0x00022D88 File Offset: 0x00020F88
		[Token(Token = "0x6005586")]
		[Address(RVA = "0x2614BA0", Offset = "0x2614CA1", VA = "0x2614BA0")]
		private static System.ReadOnlySpan<byte> GetSpan_datas()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x060066ED RID: 26349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005587")]
		[Address(RVA = "0x2614C10", Offset = "0x2614D11", VA = "0x2614C10", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, IntArray value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x060066EE RID: 26350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005588")]
		[Address(RVA = "0x2614DE0", Offset = "0x2614EE1", VA = "0x2614DE0", Slot = "5")]
		public IntArray Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return null;
		}

		// Token: 0x060066EF RID: 26351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005589")]
		[Address(RVA = "0x2615080", Offset = "0x2615181", VA = "0x2615080")]
		public IntArrayFormatter()
		{
		}
	}
}
