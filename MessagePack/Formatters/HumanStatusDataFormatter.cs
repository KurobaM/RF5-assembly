using System;
using Il2CppDummyDll;

namespace MessagePack.Formatters
{
	// Token: 0x02000FCC RID: 4044
	[Token(Token = "0x2000A24")]
	public sealed class HumanStatusDataFormatter : IMessagePackFormatter<HumanStatusData>, IMessagePackFormatter
	{
		// Token: 0x06006650 RID: 26192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054EA")]
		[Address(RVA = "0x2613A70", Offset = "0x2613B71", VA = "0x2613A70", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, HumanStatusData value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x06006651 RID: 26193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054EB")]
		[Address(RVA = "0x26140E0", Offset = "0x26141E1", VA = "0x26140E0", Slot = "5")]
		public HumanStatusData Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return null;
		}

		// Token: 0x06006652 RID: 26194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054EC")]
		[Address(RVA = "0x2614B90", Offset = "0x2614C91", VA = "0x2614B90")]
		public HumanStatusDataFormatter()
		{
		}
	}
}
