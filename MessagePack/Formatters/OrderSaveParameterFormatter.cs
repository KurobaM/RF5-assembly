using System;
using Il2CppDummyDll;

namespace MessagePack.Formatters
{
	// Token: 0x02000FD1 RID: 4049
	[Token(Token = "0x2000A29")]
	public sealed class OrderSaveParameterFormatter : IMessagePackFormatter<OrderSaveParameter>, IMessagePackFormatter
	{
		// Token: 0x0600665F RID: 26207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054F9")]
		[Address(RVA = "0x22EBD80", Offset = "0x22EBE81", VA = "0x22EBD80", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, OrderSaveParameter value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x06006660 RID: 26208 RVA: 0x00022470 File Offset: 0x00020670
		[Token(Token = "0x60054FA")]
		[Address(RVA = "0x22EBF40", Offset = "0x22EC041", VA = "0x22EBF40", Slot = "5")]
		public OrderSaveParameter Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return default(OrderSaveParameter);
		}

		// Token: 0x06006661 RID: 26209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054FB")]
		[Address(RVA = "0x22EC340", Offset = "0x22EC441", VA = "0x22EC340")]
		public OrderSaveParameterFormatter()
		{
		}
	}
}
