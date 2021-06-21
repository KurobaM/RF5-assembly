using System;
using Define;
using Il2CppDummyDll;

namespace MessagePack.Formatters.Define
{
	// Token: 0x02000FFE RID: 4094
	[Token(Token = "0x2000A56")]
	public sealed class DatProgressTypeFormatter : IMessagePackFormatter<DatProgressType>, IMessagePackFormatter
	{
		// Token: 0x0600678C RID: 26508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005626")]
		[Address(RVA = "0x25FD140", Offset = "0x25FD241", VA = "0x25FD140", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, DatProgressType value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x0600678D RID: 26509 RVA: 0x00023598 File Offset: 0x00021798
		[Token(Token = "0x6005627")]
		[Address(RVA = "0x25FD150", Offset = "0x25FD251", VA = "0x25FD150", Slot = "5")]
		public DatProgressType Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return DatProgressType.None;
		}

		// Token: 0x0600678E RID: 26510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005628")]
		[Address(RVA = "0x25FD160", Offset = "0x25FD261", VA = "0x25FD160")]
		public DatProgressTypeFormatter()
		{
		}
	}
}
