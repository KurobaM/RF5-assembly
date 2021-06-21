using System;
using Il2CppDummyDll;

namespace MessagePack.Formatters
{
	// Token: 0x02000FBA RID: 4026
	[Token(Token = "0x2000A12")]
	public sealed class DualSmithActorDataTable_LotteryTypeFormatter : IMessagePackFormatter<DualSmithActorDataTable.LotteryType>, IMessagePackFormatter
	{
		// Token: 0x0600661A RID: 26138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054B4")]
		[Address(RVA = "0x25FD590", Offset = "0x25FD691", VA = "0x25FD590", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, DualSmithActorDataTable.LotteryType value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x0600661B RID: 26139 RVA: 0x00022380 File Offset: 0x00020580
		[Token(Token = "0x60054B5")]
		[Address(RVA = "0x25FD5A0", Offset = "0x25FD6A1", VA = "0x25FD5A0", Slot = "5")]
		public DualSmithActorDataTable.LotteryType Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return DualSmithActorDataTable.LotteryType.Critical;
		}

		// Token: 0x0600661C RID: 26140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054B6")]
		[Address(RVA = "0x25FD5B0", Offset = "0x25FD6B1", VA = "0x25FD5B0")]
		public DualSmithActorDataTable_LotteryTypeFormatter()
		{
		}
	}
}
