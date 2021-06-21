using System;
using Il2CppDummyDll;

namespace MessagePack.Formatters
{
	// Token: 0x02000FCA RID: 4042
	[Token(Token = "0x2000A22")]
	public sealed class FoodItemDataFormatter : IMessagePackFormatter<FoodItemData>, IMessagePackFormatter
	{
		// Token: 0x0600664A RID: 26186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054E4")]
		[Address(RVA = "0x2611000", Offset = "0x2611101", VA = "0x2611000", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, FoodItemData value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x0600664B RID: 26187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054E5")]
		[Address(RVA = "0x2611200", Offset = "0x2611301", VA = "0x2611200", Slot = "5")]
		public FoodItemData Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return null;
		}

		// Token: 0x0600664C RID: 26188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054E6")]
		[Address(RVA = "0x2611580", Offset = "0x2611681", VA = "0x2611580")]
		public FoodItemDataFormatter()
		{
		}
	}
}
