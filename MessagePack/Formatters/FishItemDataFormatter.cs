using System;
using Il2CppDummyDll;

namespace MessagePack.Formatters
{
	// Token: 0x02000FC8 RID: 4040
	[Token(Token = "0x2000A20")]
	public sealed class FishItemDataFormatter : IMessagePackFormatter<FishItemData>, IMessagePackFormatter
	{
		// Token: 0x06006644 RID: 26180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054DE")]
		[Address(RVA = "0x260FF10", Offset = "0x2610011", VA = "0x260FF10", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, FishItemData value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x06006645 RID: 26181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054DF")]
		[Address(RVA = "0x2610080", Offset = "0x2610181", VA = "0x2610080", Slot = "5")]
		public FishItemData Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return null;
		}

		// Token: 0x06006646 RID: 26182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054E0")]
		[Address(RVA = "0x2610300", Offset = "0x2610401", VA = "0x2610300")]
		public FishItemDataFormatter()
		{
		}
	}
}
