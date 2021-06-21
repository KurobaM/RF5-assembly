using System;
using Define;
using Il2CppDummyDll;

namespace MessagePack.Formatters.Define
{
	// Token: 0x02001008 RID: 4104
	[Token(Token = "0x2000A60")]
	public sealed class LifecycleStateFormatter : IMessagePackFormatter<LifecycleState>, IMessagePackFormatter
	{
		// Token: 0x060067AA RID: 26538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005644")]
		[Address(RVA = "0x25FD380", Offset = "0x25FD481", VA = "0x25FD380", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, LifecycleState value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x060067AB RID: 26539 RVA: 0x00023688 File Offset: 0x00021888
		[Token(Token = "0x6005645")]
		[Address(RVA = "0x25FD390", Offset = "0x25FD491", VA = "0x25FD390", Slot = "5")]
		public LifecycleState Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return LifecycleState.NONE;
		}

		// Token: 0x060067AC RID: 26540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005646")]
		[Address(RVA = "0x25FD3A0", Offset = "0x25FD4A1", VA = "0x25FD3A0")]
		public LifecycleStateFormatter()
		{
		}
	}
}
