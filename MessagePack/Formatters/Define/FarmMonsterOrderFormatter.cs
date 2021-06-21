using System;
using Define;
using Il2CppDummyDll;

namespace MessagePack.Formatters.Define
{
	// Token: 0x02001002 RID: 4098
	[Token(Token = "0x2000A5A")]
	public sealed class FarmMonsterOrderFormatter : IMessagePackFormatter<FarmMonsterOrder>, IMessagePackFormatter
	{
		// Token: 0x06006798 RID: 26520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005632")]
		[Address(RVA = "0x25FD260", Offset = "0x25FD361", VA = "0x25FD260", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, FarmMonsterOrder value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x06006799 RID: 26521 RVA: 0x000235F8 File Offset: 0x000217F8
		[Token(Token = "0x6005633")]
		[Address(RVA = "0x25FD270", Offset = "0x25FD371", VA = "0x25FD270", Slot = "5")]
		public FarmMonsterOrder Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return FarmMonsterOrder.None;
		}

		// Token: 0x0600679A RID: 26522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005634")]
		[Address(RVA = "0x25FD280", Offset = "0x25FD381", VA = "0x25FD280")]
		public FarmMonsterOrderFormatter()
		{
		}
	}
}
