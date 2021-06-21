using System;
using Define;
using Il2CppDummyDll;

namespace MessagePack.Formatters.Define
{
	// Token: 0x0200100B RID: 4107
	[Token(Token = "0x2000A63")]
	public sealed class PartyTypeFormatter : IMessagePackFormatter<PartyType>, IMessagePackFormatter
	{
		// Token: 0x060067B3 RID: 26547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600564D")]
		[Address(RVA = "0x25FD410", Offset = "0x25FD511", VA = "0x25FD410", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, PartyType value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x060067B4 RID: 26548 RVA: 0x000236D0 File Offset: 0x000218D0
		[Token(Token = "0x600564E")]
		[Address(RVA = "0x25FD420", Offset = "0x25FD521", VA = "0x25FD420", Slot = "5")]
		public PartyType Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return PartyType.Player;
		}

		// Token: 0x060067B5 RID: 26549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600564F")]
		[Address(RVA = "0x25FD430", Offset = "0x25FD531", VA = "0x25FD430")]
		public PartyTypeFormatter()
		{
		}
	}
}
