using System;
using Define;
using Il2CppDummyDll;

namespace MessagePack.Formatters.Define
{
	// Token: 0x0200100A RID: 4106
	[Token(Token = "0x2000A62")]
	public sealed class NpcEventTypeFormatter : IMessagePackFormatter<NpcEventType>, IMessagePackFormatter
	{
		// Token: 0x060067B0 RID: 26544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600564A")]
		[Address(RVA = "0x25FD3E0", Offset = "0x25FD4E1", VA = "0x25FD3E0", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, NpcEventType value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x060067B1 RID: 26545 RVA: 0x000236B8 File Offset: 0x000218B8
		[Token(Token = "0x600564B")]
		[Address(RVA = "0x25FD3F0", Offset = "0x25FD4F1", VA = "0x25FD3F0", Slot = "5")]
		public NpcEventType Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return NpcEventType.None;
		}

		// Token: 0x060067B2 RID: 26546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600564C")]
		[Address(RVA = "0x25FD400", Offset = "0x25FD501", VA = "0x25FD400")]
		public NpcEventTypeFormatter()
		{
		}
	}
}
