using System;
using Define;
using Il2CppDummyDll;

namespace MessagePack.Formatters.Define
{
	// Token: 0x02001004 RID: 4100
	[Token(Token = "0x2000A5C")]
	public sealed class GameFlagDataFormatter : IMessagePackFormatter<GameFlagData>, IMessagePackFormatter
	{
		// Token: 0x0600679E RID: 26526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005638")]
		[Address(RVA = "0x25FD2C0", Offset = "0x25FD3C1", VA = "0x25FD2C0", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, GameFlagData value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x0600679F RID: 26527 RVA: 0x00023628 File Offset: 0x00021828
		[Token(Token = "0x6005639")]
		[Address(RVA = "0x25FD2D0", Offset = "0x25FD3D1", VA = "0x25FD2D0", Slot = "5")]
		public GameFlagData Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return GameFlagData.None;
		}

		// Token: 0x060067A0 RID: 26528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600563A")]
		[Address(RVA = "0x25FD2E0", Offset = "0x25FD3E1", VA = "0x25FD2E0")]
		public GameFlagDataFormatter()
		{
		}
	}
}
