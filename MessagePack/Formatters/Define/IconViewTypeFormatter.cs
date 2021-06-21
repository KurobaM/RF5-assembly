using System;
using Define;
using Il2CppDummyDll;

namespace MessagePack.Formatters.Define
{
	// Token: 0x02001007 RID: 4103
	[Token(Token = "0x2000A5F")]
	public sealed class IconViewTypeFormatter : IMessagePackFormatter<IconViewType>, IMessagePackFormatter
	{
		// Token: 0x060067A7 RID: 26535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005641")]
		[Address(RVA = "0x25FD350", Offset = "0x25FD451", VA = "0x25FD350", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, IconViewType value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x060067A8 RID: 26536 RVA: 0x00023670 File Offset: 0x00021870
		[Token(Token = "0x6005642")]
		[Address(RVA = "0x25FD360", Offset = "0x25FD461", VA = "0x25FD360", Slot = "5")]
		public IconViewType Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return IconViewType.None;
		}

		// Token: 0x060067A9 RID: 26537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005643")]
		[Address(RVA = "0x25FD370", Offset = "0x25FD471", VA = "0x25FD370")]
		public IconViewTypeFormatter()
		{
		}
	}
}
