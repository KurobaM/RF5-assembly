using System;
using Farm;
using Il2CppDummyDll;

namespace MessagePack.Formatters.Farm
{
	// Token: 0x02000FF5 RID: 4085
	[Token(Token = "0x2000A4D")]
	public sealed class FarmCropDataFormatter : IMessagePackFormatter<FarmCropData>, IMessagePackFormatter
	{
		// Token: 0x06006771 RID: 26481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600560B")]
		[Address(RVA = "0x260D280", Offset = "0x260D381", VA = "0x260D280", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, FarmCropData value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x06006772 RID: 26482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600560C")]
		[Address(RVA = "0x260D4E0", Offset = "0x260D5E1", VA = "0x260D4E0", Slot = "5")]
		public FarmCropData Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return null;
		}

		// Token: 0x06006773 RID: 26483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600560D")]
		[Address(RVA = "0x260D960", Offset = "0x260DA61", VA = "0x260D960")]
		public FarmCropDataFormatter()
		{
		}
	}
}
