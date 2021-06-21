using System;
using Il2CppDummyDll;
using RF5WANTED;

namespace MessagePack.Formatters.RF5WANTED
{
	// Token: 0x02000FEB RID: 4075
	[Token(Token = "0x2000A43")]
	public sealed class WantedSaveDataFormatter : IMessagePackFormatter<WantedSaveData>, IMessagePackFormatter
	{
		// Token: 0x06006753 RID: 26451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055ED")]
		[Address(RVA = "0x22EF460", Offset = "0x22EF561", VA = "0x22EF460", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, WantedSaveData value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x06006754 RID: 26452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055EE")]
		[Address(RVA = "0x22EF750", Offset = "0x22EF851", VA = "0x22EF750", Slot = "5")]
		public WantedSaveData Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return null;
		}

		// Token: 0x06006755 RID: 26453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055EF")]
		[Address(RVA = "0x22EFCB0", Offset = "0x22EFDB1", VA = "0x22EFCB0")]
		public WantedSaveDataFormatter()
		{
		}
	}
}
