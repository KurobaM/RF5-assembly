using System;
using Il2CppDummyDll;

namespace MessagePack.Formatters
{
	// Token: 0x02000FBC RID: 4028
	[Token(Token = "0x2000A14")]
	public sealed class ItemIDFormatter : IMessagePackFormatter<ItemID>, IMessagePackFormatter
	{
		// Token: 0x06006620 RID: 26144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054BA")]
		[Address(RVA = "0x22E1610", Offset = "0x22E1711", VA = "0x22E1610", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, ItemID value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x06006621 RID: 26145 RVA: 0x000223B0 File Offset: 0x000205B0
		[Token(Token = "0x60054BB")]
		[Address(RVA = "0x22E1620", Offset = "0x22E1721", VA = "0x22E1620", Slot = "5")]
		public ItemID Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return ItemID.ITEM_EMPTY;
		}

		// Token: 0x06006622 RID: 26146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054BC")]
		[Address(RVA = "0x22E1630", Offset = "0x22E1731", VA = "0x22E1630")]
		public ItemIDFormatter()
		{
		}
	}
}
