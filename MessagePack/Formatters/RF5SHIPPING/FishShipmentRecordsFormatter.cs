using System;
using Il2CppDummyDll;
using RF5SHIPPING;

namespace MessagePack.Formatters.RF5SHIPPING
{
	// Token: 0x02000FEF RID: 4079
	[Token(Token = "0x2000A47")]
	public sealed class FishShipmentRecordsFormatter : IMessagePackFormatter<FishShipmentRecords>, IMessagePackFormatter
	{
		// Token: 0x0600675F RID: 26463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055F9")]
		[Address(RVA = "0x22EE530", Offset = "0x22EE631", VA = "0x22EE530", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, FishShipmentRecords value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x06006760 RID: 26464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055FA")]
		[Address(RVA = "0x22EE730", Offset = "0x22EE831", VA = "0x22EE730", Slot = "5")]
		public FishShipmentRecords Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return null;
		}

		// Token: 0x06006761 RID: 26465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055FB")]
		[Address(RVA = "0x22EEA90", Offset = "0x22EEB91", VA = "0x22EEA90")]
		public FishShipmentRecordsFormatter()
		{
		}
	}
}
