using System;
using Il2CppDummyDll;

namespace MessagePack.Formatters
{
	// Token: 0x02000FE0 RID: 4064
	[Token(Token = "0x2000A38")]
	public sealed class HumanEquipFormatter : IMessagePackFormatter<HumanEquip>, IMessagePackFormatter
	{
		// Token: 0x060066E8 RID: 26344 RVA: 0x00022D70 File Offset: 0x00020F70
		[Token(Token = "0x6005582")]
		[Address(RVA = "0x2613590", Offset = "0x2613691", VA = "0x2613590")]
		private static System.ReadOnlySpan<byte> GetSpan_EquipItems()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x060066E9 RID: 26345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005583")]
		[Address(RVA = "0x2613600", Offset = "0x2613701", VA = "0x2613600", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, HumanEquip value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x060066EA RID: 26346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005584")]
		[Address(RVA = "0x26137D0", Offset = "0x26138D1", VA = "0x26137D0", Slot = "5")]
		public HumanEquip Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return null;
		}

		// Token: 0x060066EB RID: 26347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005585")]
		[Address(RVA = "0x2613A60", Offset = "0x2613B61", VA = "0x2613A60")]
		public HumanEquipFormatter()
		{
		}
	}
}
