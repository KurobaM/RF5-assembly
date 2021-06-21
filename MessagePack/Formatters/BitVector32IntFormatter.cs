using System;
using Il2CppDummyDll;

namespace MessagePack.Formatters
{
	// Token: 0x02000FC3 RID: 4035
	[Token(Token = "0x2000A1B")]
	public sealed class BitVector32IntFormatter : IMessagePackFormatter<BitVector32Int>, IMessagePackFormatter
	{
		// Token: 0x06006635 RID: 26165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054CF")]
		[Address(RVA = "0x25FC450", Offset = "0x25FC551", VA = "0x25FC450", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, BitVector32Int value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x06006636 RID: 26166 RVA: 0x00022410 File Offset: 0x00020610
		[Token(Token = "0x60054D0")]
		[Address(RVA = "0x25FC490", Offset = "0x25FC591", VA = "0x25FC490", Slot = "5")]
		public BitVector32Int Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return default(BitVector32Int);
		}

		// Token: 0x06006637 RID: 26167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054D1")]
		[Address(RVA = "0x25FC600", Offset = "0x25FC701", VA = "0x25FC600")]
		public BitVector32IntFormatter()
		{
		}
	}
}
