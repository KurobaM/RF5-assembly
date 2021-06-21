using System;
using Define;
using Il2CppDummyDll;

namespace MessagePack.Formatters.Define
{
	// Token: 0x02000FFB RID: 4091
	[Token(Token = "0x2000A53")]
	public sealed class BadStatusFormatter : IMessagePackFormatter<BadStatus>, IMessagePackFormatter
	{
		// Token: 0x06006783 RID: 26499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600561D")]
		[Address(RVA = "0x25FD110", Offset = "0x25FD211", VA = "0x25FD110", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, BadStatus value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x06006784 RID: 26500 RVA: 0x00023550 File Offset: 0x00021750
		[Token(Token = "0x600561E")]
		[Address(RVA = "0x25FD120", Offset = "0x25FD221", VA = "0x25FD120", Slot = "5")]
		public BadStatus Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return BadStatus.None;
		}

		// Token: 0x06006785 RID: 26501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600561F")]
		[Address(RVA = "0x25FD130", Offset = "0x25FD231", VA = "0x25FD130")]
		public BadStatusFormatter()
		{
		}
	}
}
