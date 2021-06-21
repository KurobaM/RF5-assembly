using System;
using Il2CppDummyDll;

namespace MessagePack.Formatters
{
	// Token: 0x02000FC9 RID: 4041
	[Token(Token = "0x2000A21")]
	public sealed class FloatParameterFormatter : IMessagePackFormatter<FloatParameter>, IMessagePackFormatter
	{
		// Token: 0x06006647 RID: 26183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054E1")]
		[Address(RVA = "0x2610310", Offset = "0x2610411", VA = "0x2610310", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, FloatParameter value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x06006648 RID: 26184 RVA: 0x00022428 File Offset: 0x00020628
		[Token(Token = "0x60054E2")]
		[Address(RVA = "0x2610630", Offset = "0x2610731", VA = "0x2610630", Slot = "5")]
		public FloatParameter Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return default(FloatParameter);
		}

		// Token: 0x06006649 RID: 26185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054E3")]
		[Address(RVA = "0x2610FF0", Offset = "0x26110F1", VA = "0x2610FF0")]
		public FloatParameterFormatter()
		{
		}
	}
}
