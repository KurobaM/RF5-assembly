using System;
using Il2CppDummyDll;
using Serialize;

namespace MessagePack.Formatters.Serialize
{
	// Token: 0x02000FEA RID: 4074
	[Token(Token = "0x2000A42")]
	public sealed class KeyAndValueFormatter<TKey, TValue> : IMessagePackFormatter<KeyAndValue<TKey, TValue>>, IMessagePackFormatter
	{
		// Token: 0x06006750 RID: 26448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055EA")]
		public void Serialize(ref MessagePackWriter writer, KeyAndValue<TKey, TValue> value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x06006751 RID: 26449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055EB")]
		public KeyAndValue<TKey, TValue> Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return null;
		}

		// Token: 0x06006752 RID: 26450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055EC")]
		public KeyAndValueFormatter()
		{
		}
	}
}
