using System;
using Define;
using Il2CppDummyDll;

namespace MessagePack.Formatters.Define
{
	// Token: 0x02001001 RID: 4097
	[Token(Token = "0x2000A59")]
	public sealed class FarmFieldWorkAreaFormatter : IMessagePackFormatter<FarmFieldWorkArea>, IMessagePackFormatter
	{
		// Token: 0x06006795 RID: 26517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600562F")]
		[Address(RVA = "0x25FD230", Offset = "0x25FD331", VA = "0x25FD230", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, FarmFieldWorkArea value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x06006796 RID: 26518 RVA: 0x000235E0 File Offset: 0x000217E0
		[Token(Token = "0x6005630")]
		[Address(RVA = "0x25FD240", Offset = "0x25FD341", VA = "0x25FD240", Slot = "5")]
		public FarmFieldWorkArea Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return FarmFieldWorkArea.None;
		}

		// Token: 0x06006797 RID: 26519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005631")]
		[Address(RVA = "0x25FD250", Offset = "0x25FD351", VA = "0x25FD250")]
		public FarmFieldWorkAreaFormatter()
		{
		}
	}
}
