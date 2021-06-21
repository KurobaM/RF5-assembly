using System;
using Il2CppDummyDll;
using MonsterHut;

namespace MessagePack.Formatters.MonsterHut
{
	// Token: 0x02000FED RID: 4077
	[Token(Token = "0x2000A45")]
	public sealed class MonsterHutSaveDataFormatter : IMessagePackFormatter<MonsterHutSaveData>, IMessagePackFormatter
	{
		// Token: 0x06006759 RID: 26457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055F3")]
		[Address(RVA = "0x22E1C40", Offset = "0x22E1D41", VA = "0x22E1C40", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, MonsterHutSaveData value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x0600675A RID: 26458 RVA: 0x00023460 File Offset: 0x00021660
		[Token(Token = "0x60055F4")]
		[Address(RVA = "0x22E1F60", Offset = "0x22E2061", VA = "0x22E1F60", Slot = "5")]
		public MonsterHutSaveData Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return default(MonsterHutSaveData);
		}

		// Token: 0x0600675B RID: 26459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055F5")]
		[Address(RVA = "0x22E2530", Offset = "0x22E2631", VA = "0x22E2530")]
		public MonsterHutSaveDataFormatter()
		{
		}
	}
}
