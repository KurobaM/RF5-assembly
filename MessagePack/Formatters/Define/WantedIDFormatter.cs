using System;
using Define;
using Il2CppDummyDll;

namespace MessagePack.Formatters.Define
{
	// Token: 0x02001011 RID: 4113
	[Token(Token = "0x2000A69")]
	public sealed class WantedIDFormatter : IMessagePackFormatter<WantedID>, IMessagePackFormatter
	{
		// Token: 0x060067C5 RID: 26565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600565F")]
		[Address(RVA = "0x25FD530", Offset = "0x25FD631", VA = "0x25FD530", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, WantedID value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x060067C6 RID: 26566 RVA: 0x00023760 File Offset: 0x00021960
		[Token(Token = "0x6005660")]
		[Address(RVA = "0x25FD540", Offset = "0x25FD641", VA = "0x25FD540", Slot = "5")]
		public WantedID Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return WantedID.Forest1;
		}

		// Token: 0x060067C7 RID: 26567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005661")]
		[Address(RVA = "0x25FD550", Offset = "0x25FD651", VA = "0x25FD550")]
		public WantedIDFormatter()
		{
		}
	}
}
