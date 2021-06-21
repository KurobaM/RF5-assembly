using System;
using Define;
using Il2CppDummyDll;

namespace MessagePack.Formatters.Define
{
	// Token: 0x02001006 RID: 4102
	[Token(Token = "0x2000A5E")]
	public sealed class IconTypeFormatter : IMessagePackFormatter<IconType>, IMessagePackFormatter
	{
		// Token: 0x060067A4 RID: 26532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600563E")]
		[Address(RVA = "0x25FD320", Offset = "0x25FD421", VA = "0x25FD320", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, IconType value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x060067A5 RID: 26533 RVA: 0x00023658 File Offset: 0x00021858
		[Token(Token = "0x600563F")]
		[Address(RVA = "0x25FD330", Offset = "0x25FD431", VA = "0x25FD330", Slot = "5")]
		public IconType Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return IconType.Star;
		}

		// Token: 0x060067A6 RID: 26534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005640")]
		[Address(RVA = "0x25FD340", Offset = "0x25FD441", VA = "0x25FD340")]
		public IconTypeFormatter()
		{
		}
	}
}
