using System;
using Define;
using Il2CppDummyDll;

namespace MessagePack.Formatters.Define
{
	// Token: 0x02001010 RID: 4112
	[Token(Token = "0x2000A68")]
	public sealed class VariationNoFormatter : IMessagePackFormatter<VariationNo>, IMessagePackFormatter
	{
		// Token: 0x060067C2 RID: 26562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600565C")]
		[Address(RVA = "0x25FD500", Offset = "0x25FD601", VA = "0x25FD500", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, VariationNo value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x060067C3 RID: 26563 RVA: 0x00023748 File Offset: 0x00021948
		[Token(Token = "0x600565D")]
		[Address(RVA = "0x25FD510", Offset = "0x25FD611", VA = "0x25FD510", Slot = "5")]
		public VariationNo Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return VariationNo.VARIA_000;
		}

		// Token: 0x060067C4 RID: 26564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600565E")]
		[Address(RVA = "0x25FD520", Offset = "0x25FD621", VA = "0x25FD520")]
		public VariationNoFormatter()
		{
		}
	}
}
