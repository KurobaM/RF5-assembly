using System;
using Il2CppDummyDll;

namespace MessagePack.Formatters
{
	// Token: 0x02000FCE RID: 4046
	[Token(Token = "0x2000A26")]
	public sealed class ItemStorageDataFormatter : IMessagePackFormatter<ItemStorageData>, IMessagePackFormatter
	{
		// Token: 0x06006656 RID: 26198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054F0")]
		[Address(RVA = "0x22E1640", Offset = "0x22E1741", VA = "0x22E1640", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, ItemStorageData value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x06006657 RID: 26199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054F1")]
		[Address(RVA = "0x22E1780", Offset = "0x22E1881", VA = "0x22E1780", Slot = "5")]
		public ItemStorageData Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return null;
		}

		// Token: 0x06006658 RID: 26200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054F2")]
		[Address(RVA = "0x22E19B0", Offset = "0x22E1AB1", VA = "0x22E19B0")]
		public ItemStorageDataFormatter()
		{
		}
	}
}
