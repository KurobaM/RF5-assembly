using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace MessagePack.Formatters
{
	// Token: 0x02000FC0 RID: 4032
	[Token(Token = "0x2000A18")]
	public sealed class ItemDataFormatter : IMessagePackFormatter<ItemData>, IMessagePackFormatter
	{
		// Token: 0x0600662C RID: 26156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054C6")]
		[Address(RVA = "0x22E05F0", Offset = "0x22E06F1", VA = "0x22E05F0")]
		public ItemDataFormatter()
		{
		}

		// Token: 0x0600662D RID: 26157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054C7")]
		[Address(RVA = "0x22E0A30", Offset = "0x22E0B31", VA = "0x22E0A30", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, ItemData value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x0600662E RID: 26158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054C8")]
		[Address(RVA = "0x22E1090", Offset = "0x22E1191", VA = "0x22E1090", Slot = "5")]
		public ItemData Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return null;
		}

		// Token: 0x0400C732 RID: 50994
		[Token(Token = "0x40093CB")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>> typeToKeyAndJumpMap;

		// Token: 0x0400C733 RID: 50995
		[Token(Token = "0x40093CC")]
		[FieldOffset(Offset = "0x18")]
		private readonly Dictionary<int, int> keyToJumpMap;
	}
}
