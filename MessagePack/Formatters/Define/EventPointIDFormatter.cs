using System;
using Define;
using Il2CppDummyDll;

namespace MessagePack.Formatters.Define
{
	// Token: 0x02000FFF RID: 4095
	[Token(Token = "0x2000A57")]
	public sealed class EventPointIDFormatter : IMessagePackFormatter<EventPointID>, IMessagePackFormatter
	{
		// Token: 0x0600678F RID: 26511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005629")]
		[Address(RVA = "0x25FD1D0", Offset = "0x25FD2D1", VA = "0x25FD1D0", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, EventPointID value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x06006790 RID: 26512 RVA: 0x000235B0 File Offset: 0x000217B0
		[Token(Token = "0x600562A")]
		[Address(RVA = "0x25FD1E0", Offset = "0x25FD2E1", VA = "0x25FD1E0", Slot = "5")]
		public EventPointID Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return EventPointID.None;
		}

		// Token: 0x06006791 RID: 26513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600562B")]
		[Address(RVA = "0x25FD1F0", Offset = "0x25FD2F1", VA = "0x25FD1F0")]
		public EventPointIDFormatter()
		{
		}
	}
}
