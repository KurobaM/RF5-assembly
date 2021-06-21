using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace MessagePack.Formatters
{
	// Token: 0x02000FC1 RID: 4033
	[Token(Token = "0x2000A19")]
	public sealed class StatusDataBaseFormatter : IMessagePackFormatter<StatusDataBase>, IMessagePackFormatter
	{
		// Token: 0x0600662F RID: 26159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054C9")]
		[Address(RVA = "0x22F0B80", Offset = "0x22F0C81", VA = "0x22F0B80")]
		public StatusDataBaseFormatter()
		{
		}

		// Token: 0x06006630 RID: 26160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054CA")]
		[Address(RVA = "0x22F0E10", Offset = "0x22F0F11", VA = "0x22F0E10", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, StatusDataBase value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x06006631 RID: 26161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054CB")]
		[Address(RVA = "0x22F1180", Offset = "0x22F1281", VA = "0x22F1180", Slot = "5")]
		public StatusDataBase Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return null;
		}

		// Token: 0x0400C734 RID: 50996
		[Token(Token = "0x40093CD")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>> typeToKeyAndJumpMap;

		// Token: 0x0400C735 RID: 50997
		[Token(Token = "0x40093CE")]
		[FieldOffset(Offset = "0x18")]
		private readonly Dictionary<int, int> keyToJumpMap;
	}
}
