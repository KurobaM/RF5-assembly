using System;
using Define;
using Il2CppDummyDll;

namespace MessagePack.Formatters.Define
{
	// Token: 0x02000FFA RID: 4090
	[Token(Token = "0x2000A52")]
	public sealed class ActorIDFormatter : IMessagePackFormatter<ActorID>, IMessagePackFormatter
	{
		// Token: 0x06006780 RID: 26496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600561A")]
		[Address(RVA = "0x25FD0E0", Offset = "0x25FD1E1", VA = "0x25FD0E0", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, ActorID value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x06006781 RID: 26497 RVA: 0x00023538 File Offset: 0x00021738
		[Token(Token = "0x600561B")]
		[Address(RVA = "0x25FD0F0", Offset = "0x25FD1F1", VA = "0x25FD0F0", Slot = "5")]
		public ActorID Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return ActorID.act000;
		}

		// Token: 0x06006782 RID: 26498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600561C")]
		[Address(RVA = "0x25FD100", Offset = "0x25FD201", VA = "0x25FD100")]
		public ActorIDFormatter()
		{
		}
	}
}
