using System;
using Field;
using Il2CppDummyDll;

namespace MessagePack.Formatters.Field
{
	// Token: 0x02000FF2 RID: 4082
	[Token(Token = "0x2000A4A")]
	public sealed class FieldSceneIdFormatter : IMessagePackFormatter<FieldSceneId>, IMessagePackFormatter
	{
		// Token: 0x06006768 RID: 26472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005602")]
		[Address(RVA = "0x260F460", Offset = "0x260F561", VA = "0x260F460", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, FieldSceneId value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x06006769 RID: 26473 RVA: 0x00023490 File Offset: 0x00021690
		[Token(Token = "0x6005603")]
		[Address(RVA = "0x260F470", Offset = "0x260F571", VA = "0x260F470", Slot = "5")]
		public FieldSceneId Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return FieldSceneId.Empty;
		}

		// Token: 0x0600676A RID: 26474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005604")]
		[Address(RVA = "0x260F480", Offset = "0x260F581", VA = "0x260F480")]
		public FieldSceneIdFormatter()
		{
		}
	}
}
