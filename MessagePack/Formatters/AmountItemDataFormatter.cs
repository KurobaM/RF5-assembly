using System;
using Il2CppDummyDll;

namespace MessagePack.Formatters
{
	// Token: 0x02000FC2 RID: 4034
	[Token(Token = "0x2000A1A")]
	public sealed class AmountItemDataFormatter : IMessagePackFormatter<AmountItemData>, IMessagePackFormatter
	{
		// Token: 0x06006632 RID: 26162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054CC")]
		[Address(RVA = "0x25FBF60", Offset = "0x25FC061", VA = "0x25FBF60", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, AmountItemData value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x06006633 RID: 26163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054CD")]
		[Address(RVA = "0x25FC140", Offset = "0x25FC241", VA = "0x25FC140", Slot = "5")]
		public AmountItemData Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return null;
		}

		// Token: 0x06006634 RID: 26164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054CE")]
		[Address(RVA = "0x25FC440", Offset = "0x25FC541", VA = "0x25FC440")]
		public AmountItemDataFormatter()
		{
		}
	}
}
