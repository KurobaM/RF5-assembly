using System;
using Il2CppDummyDll;
using RF5SHIPPING;

namespace MessagePack.Formatters.RF5SHIPPING
{
	// Token: 0x02000FF1 RID: 4081
	[Token(Token = "0x2000A49")]
	public sealed class ShipmentItemRecordsFormatter : IMessagePackFormatter<ShipmentItemRecords>, IMessagePackFormatter
	{
		// Token: 0x06006765 RID: 26469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055FF")]
		[Address(RVA = "0x22EEE60", Offset = "0x22EEF61", VA = "0x22EEE60", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, ShipmentItemRecords value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x06006766 RID: 26470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005600")]
		[Address(RVA = "0x22EF080", Offset = "0x22EF181", VA = "0x22EF080", Slot = "5")]
		public ShipmentItemRecords Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return null;
		}

		// Token: 0x06006767 RID: 26471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005601")]
		[Address(RVA = "0x22EF450", Offset = "0x22EF551", VA = "0x22EF450")]
		public ShipmentItemRecordsFormatter()
		{
		}
	}
}
