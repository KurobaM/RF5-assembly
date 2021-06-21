using System;
using Define;
using Il2CppDummyDll;

namespace MessagePack.Formatters.Define
{
	// Token: 0x02001012 RID: 4114
	[Token(Token = "0x2000A6A")]
	public sealed class WeatherFormatter : IMessagePackFormatter<Weather>, IMessagePackFormatter
	{
		// Token: 0x060067C8 RID: 26568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005662")]
		[Address(RVA = "0x25FD560", Offset = "0x25FD661", VA = "0x25FD560", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, Weather value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x060067C9 RID: 26569 RVA: 0x00023778 File Offset: 0x00021978
		[Token(Token = "0x6005663")]
		[Address(RVA = "0x25FD570", Offset = "0x25FD671", VA = "0x25FD570", Slot = "5")]
		public Weather Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return Weather.None;
		}

		// Token: 0x060067CA RID: 26570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005664")]
		[Address(RVA = "0x25FD580", Offset = "0x25FD681", VA = "0x25FD580")]
		public WeatherFormatter()
		{
		}
	}
}
