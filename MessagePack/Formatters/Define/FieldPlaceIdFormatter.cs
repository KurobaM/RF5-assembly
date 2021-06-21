using System;
using Define;
using Il2CppDummyDll;

namespace MessagePack.Formatters.Define
{
	// Token: 0x02001003 RID: 4099
	[Token(Token = "0x2000A5B")]
	public sealed class FieldPlaceIdFormatter : IMessagePackFormatter<FieldPlaceId>, IMessagePackFormatter
	{
		// Token: 0x0600679B RID: 26523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005635")]
		[Address(RVA = "0x25FD290", Offset = "0x25FD391", VA = "0x25FD290", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, FieldPlaceId value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x0600679C RID: 26524 RVA: 0x00023610 File Offset: 0x00021810
		[Token(Token = "0x6005636")]
		[Address(RVA = "0x25FD2A0", Offset = "0x25FD3A1", VA = "0x25FD2A0", Slot = "5")]
		public FieldPlaceId Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return FieldPlaceId.None;
		}

		// Token: 0x0600679D RID: 26525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005637")]
		[Address(RVA = "0x25FD2B0", Offset = "0x25FD3B1", VA = "0x25FD2B0")]
		public FieldPlaceIdFormatter()
		{
		}
	}
}
