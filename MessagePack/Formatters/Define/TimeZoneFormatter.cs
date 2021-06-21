using System;
using Define;
using Il2CppDummyDll;

namespace MessagePack.Formatters.Define
{
	// Token: 0x0200100E RID: 4110
	[Token(Token = "0x2000A66")]
	public sealed class TimeZoneFormatter : IMessagePackFormatter<Define.TimeZone>, IMessagePackFormatter
	{
		// Token: 0x060067BC RID: 26556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005656")]
		[Address(RVA = "0x25FD4A0", Offset = "0x25FD5A1", VA = "0x25FD4A0", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, Define.TimeZone value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x060067BD RID: 26557 RVA: 0x00023718 File Offset: 0x00021918
		[Token(Token = "0x6005657")]
		[Address(RVA = "0x25FD4B0", Offset = "0x25FD5B1", VA = "0x25FD4B0", Slot = "5")]
		public Define.TimeZone Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return Define.TimeZone.None;
		}

		// Token: 0x060067BE RID: 26558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005658")]
		[Address(RVA = "0x25FD4C0", Offset = "0x25FD5C1", VA = "0x25FD4C0")]
		public TimeZoneFormatter()
		{
		}
	}
}
