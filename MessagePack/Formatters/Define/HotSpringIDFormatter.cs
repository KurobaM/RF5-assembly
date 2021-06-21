using System;
using Define;
using Il2CppDummyDll;

namespace MessagePack.Formatters.Define
{
	// Token: 0x02001005 RID: 4101
	[Token(Token = "0x2000A5D")]
	public sealed class HotSpringIDFormatter : IMessagePackFormatter<HotSpringID>, IMessagePackFormatter
	{
		// Token: 0x060067A1 RID: 26529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600563B")]
		[Address(RVA = "0x25FD2F0", Offset = "0x25FD3F1", VA = "0x25FD2F0", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, HotSpringID value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x060067A2 RID: 26530 RVA: 0x00023640 File Offset: 0x00021840
		[Token(Token = "0x600563C")]
		[Address(RVA = "0x25FD300", Offset = "0x25FD401", VA = "0x25FD300", Slot = "5")]
		public HotSpringID Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return HotSpringID.EMPTY;
		}

		// Token: 0x060067A3 RID: 26531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600563D")]
		[Address(RVA = "0x25FD310", Offset = "0x25FD411", VA = "0x25FD310")]
		public HotSpringIDFormatter()
		{
		}
	}
}
