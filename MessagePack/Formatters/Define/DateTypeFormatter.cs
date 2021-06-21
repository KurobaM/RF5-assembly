using System;
using Define;
using Il2CppDummyDll;

namespace MessagePack.Formatters.Define
{
	// Token: 0x02000FFD RID: 4093
	[Token(Token = "0x2000A55")]
	public sealed class DateTypeFormatter : IMessagePackFormatter<DateType>, IMessagePackFormatter
	{
		// Token: 0x06006789 RID: 26505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005623")]
		[Address(RVA = "0x25FD1A0", Offset = "0x25FD2A1", VA = "0x25FD1A0", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, DateType value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x0600678A RID: 26506 RVA: 0x00023580 File Offset: 0x00021780
		[Token(Token = "0x6005624")]
		[Address(RVA = "0x25FD1B0", Offset = "0x25FD2B1", VA = "0x25FD1B0", Slot = "5")]
		public DateType Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return DateType.None;
		}

		// Token: 0x0600678B RID: 26507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005625")]
		[Address(RVA = "0x25FD1C0", Offset = "0x25FD2C1", VA = "0x25FD1C0")]
		public DateTypeFormatter()
		{
		}
	}
}
