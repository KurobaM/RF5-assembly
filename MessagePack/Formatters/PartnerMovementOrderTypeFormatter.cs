using System;
using Il2CppDummyDll;

namespace MessagePack.Formatters
{
	// Token: 0x02000FBF RID: 4031
	[Token(Token = "0x2000A17")]
	public sealed class PartnerMovementOrderTypeFormatter : IMessagePackFormatter<PartnerMovementOrderType>, IMessagePackFormatter
	{
		// Token: 0x06006629 RID: 26153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054C3")]
		[Address(RVA = "0x22ED030", Offset = "0x22ED131", VA = "0x22ED030", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, PartnerMovementOrderType value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x0600662A RID: 26154 RVA: 0x000223F8 File Offset: 0x000205F8
		[Token(Token = "0x60054C4")]
		[Address(RVA = "0x22ED040", Offset = "0x22ED141", VA = "0x22ED040", Slot = "5")]
		public PartnerMovementOrderType Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return PartnerMovementOrderType.None;
		}

		// Token: 0x0600662B RID: 26155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054C5")]
		[Address(RVA = "0x22ED050", Offset = "0x22ED151", VA = "0x22ED050")]
		public PartnerMovementOrderTypeFormatter()
		{
		}
	}
}
