using System;
using Define;
using Il2CppDummyDll;

namespace MessagePack.Formatters.Define
{
	// Token: 0x02001000 RID: 4096
	[Token(Token = "0x2000A58")]
	public sealed class EventScriptIDFormatter : IMessagePackFormatter<EventScriptID>, IMessagePackFormatter
	{
		// Token: 0x06006792 RID: 26514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600562C")]
		[Address(RVA = "0x25FD200", Offset = "0x25FD301", VA = "0x25FD200", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, EventScriptID value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x06006793 RID: 26515 RVA: 0x000235C8 File Offset: 0x000217C8
		[Token(Token = "0x600562D")]
		[Address(RVA = "0x25FD210", Offset = "0x25FD311", VA = "0x25FD210", Slot = "5")]
		public EventScriptID Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return EventScriptID.None;
		}

		// Token: 0x06006794 RID: 26516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600562E")]
		[Address(RVA = "0x25FD220", Offset = "0x25FD321", VA = "0x25FD220")]
		public EventScriptIDFormatter()
		{
		}
	}
}
