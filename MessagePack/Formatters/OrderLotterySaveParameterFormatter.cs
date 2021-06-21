using System;
using Il2CppDummyDll;

namespace MessagePack.Formatters
{
	// Token: 0x02000FCF RID: 4047
	[Token(Token = "0x2000A27")]
	public sealed class OrderLotterySaveParameterFormatter : IMessagePackFormatter<OrderLotterySaveParameter>, IMessagePackFormatter
	{
		// Token: 0x06006659 RID: 26201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054F3")]
		[Address(RVA = "0x22EB2A0", Offset = "0x22EB3A1", VA = "0x22EB2A0", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, OrderLotterySaveParameter value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x0600665A RID: 26202 RVA: 0x00022440 File Offset: 0x00020640
		[Token(Token = "0x60054F4")]
		[Address(RVA = "0x22EB310", Offset = "0x22EB411", VA = "0x22EB310", Slot = "5")]
		public OrderLotterySaveParameter Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return default(OrderLotterySaveParameter);
		}

		// Token: 0x0600665B RID: 26203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054F5")]
		[Address(RVA = "0x22EB510", Offset = "0x22EB611", VA = "0x22EB510")]
		public OrderLotterySaveParameterFormatter()
		{
		}
	}
}
