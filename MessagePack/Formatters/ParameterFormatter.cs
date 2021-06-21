using System;
using Il2CppDummyDll;

namespace MessagePack.Formatters
{
	// Token: 0x02000FD2 RID: 4050
	[Token(Token = "0x2000A2A")]
	public sealed class ParameterFormatter : IMessagePackFormatter<Parameter>, IMessagePackFormatter
	{
		// Token: 0x06006662 RID: 26210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054FC")]
		[Address(RVA = "0x22EC350", Offset = "0x22EC451", VA = "0x22EC350", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, Parameter value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x06006663 RID: 26211 RVA: 0x00022488 File Offset: 0x00020688
		[Token(Token = "0x60054FD")]
		[Address(RVA = "0x22EC670", Offset = "0x22EC771", VA = "0x22EC670", Slot = "5")]
		public Parameter Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return default(Parameter);
		}

		// Token: 0x06006664 RID: 26212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054FE")]
		[Address(RVA = "0x22ED020", Offset = "0x22ED121", VA = "0x22ED020")]
		public ParameterFormatter()
		{
		}
	}
}
