using System;
using Il2CppDummyDll;
using MonsterHut;

namespace MessagePack.Formatters.MonsterHut
{
	// Token: 0x02000FEC RID: 4076
	[Token(Token = "0x2000A44")]
	public sealed class FriendMonsterIDAndHouseIDFormatter : IMessagePackFormatter<FriendMonsterIDAndHouseID>, IMessagePackFormatter
	{
		// Token: 0x06006756 RID: 26454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055F0")]
		[Address(RVA = "0x22E1A20", Offset = "0x22E1B21", VA = "0x22E1A20", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, FriendMonsterIDAndHouseID value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x06006757 RID: 26455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055F1")]
		[Address(RVA = "0x22E1A90", Offset = "0x22E1B91", VA = "0x22E1A90", Slot = "5")]
		public FriendMonsterIDAndHouseID Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return null;
		}

		// Token: 0x06006758 RID: 26456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055F2")]
		[Address(RVA = "0x22E1C30", Offset = "0x22E1D31", VA = "0x22E1C30")]
		public FriendMonsterIDAndHouseIDFormatter()
		{
		}
	}
}
