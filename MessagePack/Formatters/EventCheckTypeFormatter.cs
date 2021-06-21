using System;
using Il2CppDummyDll;

namespace MessagePack.Formatters
{
	// Token: 0x02000FBB RID: 4027
	[Token(Token = "0x2000A13")]
	public sealed class EventCheckTypeFormatter : IMessagePackFormatter<EventCheckType>, IMessagePackFormatter
	{
		// Token: 0x0600661D RID: 26141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054B7")]
		[Address(RVA = "0x25FFFF0", Offset = "0x26000F1", VA = "0x25FFFF0", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, EventCheckType value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x0600661E RID: 26142 RVA: 0x00022398 File Offset: 0x00020598
		[Token(Token = "0x60054B8")]
		[Address(RVA = "0x2600000", Offset = "0x2600101", VA = "0x2600000", Slot = "5")]
		public EventCheckType Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return EventCheckType.Once;
		}

		// Token: 0x0600661F RID: 26143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054B9")]
		[Address(RVA = "0x2600010", Offset = "0x2600111", VA = "0x2600010")]
		public EventCheckTypeFormatter()
		{
		}
	}
}
