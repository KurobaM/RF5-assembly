using System;
using Il2CppDummyDll;

namespace MessagePack.Formatters
{
	// Token: 0x02000FBE RID: 4030
	[Token(Token = "0x2000A16")]
	public sealed class MonsterDataIDFormatter : IMessagePackFormatter<MonsterDataID>, IMessagePackFormatter
	{
		// Token: 0x06006626 RID: 26150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054C0")]
		[Address(RVA = "0x22E19F0", Offset = "0x22E1AF1", VA = "0x22E19F0", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, MonsterDataID value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x06006627 RID: 26151 RVA: 0x000223E0 File Offset: 0x000205E0
		[Token(Token = "0x60054C1")]
		[Address(RVA = "0x22E1A00", Offset = "0x22E1B01", VA = "0x22E1A00", Slot = "5")]
		public MonsterDataID Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return MonsterDataID.MonsterData_EMPTY;
		}

		// Token: 0x06006628 RID: 26152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054C2")]
		[Address(RVA = "0x22E1A10", Offset = "0x22E1B11", VA = "0x22E1A10")]
		public MonsterDataIDFormatter()
		{
		}
	}
}
