using System;
using Il2CppDummyDll;

namespace MessagePack.Formatters
{
	// Token: 0x02000FD4 RID: 4052
	[Token(Token = "0x2000A2C")]
	public sealed class PotToolItemDataFormatter : IMessagePackFormatter<PotToolItemData>, IMessagePackFormatter
	{
		// Token: 0x06006668 RID: 26216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005502")]
		[Address(RVA = "0x22ED790", Offset = "0x22ED891", VA = "0x22ED790", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, PotToolItemData value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x06006669 RID: 26217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005503")]
		[Address(RVA = "0x22EDCA0", Offset = "0x22EDDA1", VA = "0x22EDCA0", Slot = "5")]
		public PotToolItemData Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return null;
		}

		// Token: 0x0600666A RID: 26218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005504")]
		[Address(RVA = "0x22EE4F0", Offset = "0x22EE5F1", VA = "0x22EE4F0")]
		public PotToolItemDataFormatter()
		{
		}
	}
}
