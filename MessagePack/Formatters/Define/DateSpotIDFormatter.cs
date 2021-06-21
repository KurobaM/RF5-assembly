using System;
using Define;
using Il2CppDummyDll;

namespace MessagePack.Formatters.Define
{
	// Token: 0x02000FFC RID: 4092
	[Token(Token = "0x2000A54")]
	public sealed class DateSpotIDFormatter : IMessagePackFormatter<DateSpotID>, IMessagePackFormatter
	{
		// Token: 0x06006786 RID: 26502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005620")]
		[Address(RVA = "0x25FD170", Offset = "0x25FD271", VA = "0x25FD170", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, DateSpotID value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x06006787 RID: 26503 RVA: 0x00023568 File Offset: 0x00021768
		[Token(Token = "0x6005621")]
		[Address(RVA = "0x25FD180", Offset = "0x25FD281", VA = "0x25FD180", Slot = "5")]
		public DateSpotID Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return DateSpotID.None;
		}

		// Token: 0x06006788 RID: 26504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005622")]
		[Address(RVA = "0x25FD190", Offset = "0x25FD291", VA = "0x25FD190")]
		public DateSpotIDFormatter()
		{
		}
	}
}
