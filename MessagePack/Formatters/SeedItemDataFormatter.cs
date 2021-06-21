using System;
using Il2CppDummyDll;

namespace MessagePack.Formatters
{
	// Token: 0x02000FD6 RID: 4054
	[Token(Token = "0x2000A2E")]
	public sealed class SeedItemDataFormatter : IMessagePackFormatter<SeedItemData>, IMessagePackFormatter
	{
		// Token: 0x0600666E RID: 26222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005508")]
		[Address(RVA = "0x22F0690", Offset = "0x22F0791", VA = "0x22F0690", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, SeedItemData value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x0600666F RID: 26223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005509")]
		[Address(RVA = "0x22F0870", Offset = "0x22F0971", VA = "0x22F0870", Slot = "5")]
		public SeedItemData Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return null;
		}

		// Token: 0x06006670 RID: 26224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600550A")]
		[Address(RVA = "0x22F0B70", Offset = "0x22F0C71", VA = "0x22F0B70")]
		public SeedItemDataFormatter()
		{
		}
	}
}
