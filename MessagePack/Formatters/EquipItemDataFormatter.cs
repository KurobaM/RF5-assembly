using System;
using Il2CppDummyDll;

namespace MessagePack.Formatters
{
	// Token: 0x02000FC5 RID: 4037
	[Token(Token = "0x2000A1D")]
	public sealed class EquipItemDataFormatter : IMessagePackFormatter<EquipItemData>, IMessagePackFormatter
	{
		// Token: 0x0600663B RID: 26171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054D5")]
		[Address(RVA = "0x25FE510", Offset = "0x25FE611", VA = "0x25FE510", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, EquipItemData value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x0600663C RID: 26172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054D6")]
		[Address(RVA = "0x25FEA10", Offset = "0x25FEB11", VA = "0x25FEA10", Slot = "5")]
		public EquipItemData Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return null;
		}

		// Token: 0x0600663D RID: 26173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054D7")]
		[Address(RVA = "0x25FF240", Offset = "0x25FF341", VA = "0x25FF240")]
		public EquipItemDataFormatter()
		{
		}
	}
}
