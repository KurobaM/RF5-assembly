using System;
using Il2CppDummyDll;
using RF5SHIPPING;

namespace MessagePack.Formatters.RF5SHIPPING
{
	// Token: 0x02000FF0 RID: 4080
	[Token(Token = "0x2000A48")]
	public sealed class SeedLevelRecordsFormatter : IMessagePackFormatter<SeedLevelRecords>, IMessagePackFormatter
	{
		// Token: 0x06006762 RID: 26466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055FC")]
		[Address(RVA = "0x22EEAA0", Offset = "0x22EEBA1", VA = "0x22EEAA0", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, SeedLevelRecords value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x06006763 RID: 26467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055FD")]
		[Address(RVA = "0x22EEC00", Offset = "0x22EED01", VA = "0x22EEC00", Slot = "5")]
		public SeedLevelRecords Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return null;
		}

		// Token: 0x06006764 RID: 26468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055FE")]
		[Address(RVA = "0x22EEE50", Offset = "0x22EEF51", VA = "0x22EEE50")]
		public SeedLevelRecordsFormatter()
		{
		}
	}
}
