using System;
using Il2CppDummyDll;

namespace MessagePack.Formatters
{
	// Token: 0x02000FD0 RID: 4048
	[Token(Token = "0x2000A28")]
	public sealed class OrderSaveDataFormatter : IMessagePackFormatter<OrderSaveData>, IMessagePackFormatter
	{
		// Token: 0x0600665C RID: 26204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054F6")]
		[Address(RVA = "0x22EB520", Offset = "0x22EB621", VA = "0x22EB520", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, OrderSaveData value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x0600665D RID: 26205 RVA: 0x00022458 File Offset: 0x00020658
		[Token(Token = "0x60054F7")]
		[Address(RVA = "0x22EB800", Offset = "0x22EB901", VA = "0x22EB800", Slot = "5")]
		public OrderSaveData Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return default(OrderSaveData);
		}

		// Token: 0x0600665E RID: 26206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054F8")]
		[Address(RVA = "0x22EBD70", Offset = "0x22EBE71", VA = "0x22EBD70")]
		public OrderSaveDataFormatter()
		{
		}
	}
}
