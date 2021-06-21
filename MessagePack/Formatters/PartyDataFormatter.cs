using System;
using Il2CppDummyDll;

namespace MessagePack.Formatters
{
	// Token: 0x02000FD3 RID: 4051
	[Token(Token = "0x2000A2B")]
	public sealed class PartyDataFormatter : IMessagePackFormatter<PartyData>, IMessagePackFormatter
	{
		// Token: 0x06006665 RID: 26213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054FF")]
		[Address(RVA = "0x22ED060", Offset = "0x22ED161", VA = "0x22ED060", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, PartyData value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x06006666 RID: 26214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005500")]
		[Address(RVA = "0x22ED300", Offset = "0x22ED401", VA = "0x22ED300", Slot = "5")]
		public PartyData Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return null;
		}

		// Token: 0x06006667 RID: 26215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005501")]
		[Address(RVA = "0x22ED780", Offset = "0x22ED881", VA = "0x22ED780")]
		public PartyDataFormatter()
		{
		}
	}
}
