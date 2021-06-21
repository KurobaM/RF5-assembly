using System;
using Define;
using Il2CppDummyDll;

namespace MessagePack.Formatters.Define
{
	// Token: 0x0200100D RID: 4109
	[Token(Token = "0x2000A65")]
	public sealed class SeasonFormatter : IMessagePackFormatter<Season>, IMessagePackFormatter
	{
		// Token: 0x060067B9 RID: 26553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005653")]
		[Address(RVA = "0x25FD470", Offset = "0x25FD571", VA = "0x25FD470", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, Season value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x060067BA RID: 26554 RVA: 0x00023700 File Offset: 0x00021900
		[Token(Token = "0x6005654")]
		[Address(RVA = "0x25FD480", Offset = "0x25FD581", VA = "0x25FD480", Slot = "5")]
		public Season Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return Season.None;
		}

		// Token: 0x060067BB RID: 26555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005655")]
		[Address(RVA = "0x25FD490", Offset = "0x25FD591", VA = "0x25FD490")]
		public SeasonFormatter()
		{
		}
	}
}
