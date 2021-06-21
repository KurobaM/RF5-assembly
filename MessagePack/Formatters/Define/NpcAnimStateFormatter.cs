using System;
using Define;
using Il2CppDummyDll;

namespace MessagePack.Formatters.Define
{
	// Token: 0x02001009 RID: 4105
	[Token(Token = "0x2000A61")]
	public sealed class NpcAnimStateFormatter : IMessagePackFormatter<NpcAnimState>, IMessagePackFormatter
	{
		// Token: 0x060067AD RID: 26541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005647")]
		[Address(RVA = "0x25FD3B0", Offset = "0x25FD4B1", VA = "0x25FD3B0", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, NpcAnimState value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x060067AE RID: 26542 RVA: 0x000236A0 File Offset: 0x000218A0
		[Token(Token = "0x6005648")]
		[Address(RVA = "0x25FD3C0", Offset = "0x25FD4C1", VA = "0x25FD3C0", Slot = "5")]
		public NpcAnimState Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return NpcAnimState.Idle;
		}

		// Token: 0x060067AF RID: 26543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005649")]
		[Address(RVA = "0x25FD3D0", Offset = "0x25FD4D1", VA = "0x25FD3D0")]
		public NpcAnimStateFormatter()
		{
		}
	}
}
