using System;
using Define;
using Il2CppDummyDll;

namespace MessagePack.Formatters.Define
{
	// Token: 0x0200100C RID: 4108
	[Token(Token = "0x2000A64")]
	public sealed class PlaceFormatter : IMessagePackFormatter<Place>, IMessagePackFormatter
	{
		// Token: 0x060067B6 RID: 26550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005650")]
		[Address(RVA = "0x25FD440", Offset = "0x25FD541", VA = "0x25FD440", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, Place value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x060067B7 RID: 26551 RVA: 0x000236E8 File Offset: 0x000218E8
		[Token(Token = "0x6005651")]
		[Address(RVA = "0x25FD450", Offset = "0x25FD551", VA = "0x25FD450", Slot = "5")]
		public Place Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return Place.Field;
		}

		// Token: 0x060067B8 RID: 26552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005652")]
		[Address(RVA = "0x25FD460", Offset = "0x25FD561", VA = "0x25FD460")]
		public PlaceFormatter()
		{
		}
	}
}
