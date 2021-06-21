using System;
using Il2CppDummyDll;

namespace MessagePack.Formatters
{
	// Token: 0x02000FC6 RID: 4038
	[Token(Token = "0x2000A1E")]
	public sealed class FieldOnGroundItemInfoFormatter : IMessagePackFormatter<FieldOnGroundItemInfo>, IMessagePackFormatter
	{
		// Token: 0x0600663E RID: 26174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054D8")]
		[Address(RVA = "0x260F490", Offset = "0x260F591", VA = "0x260F490", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, FieldOnGroundItemInfo value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x0600663F RID: 26175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054D9")]
		[Address(RVA = "0x260F730", Offset = "0x260F831", VA = "0x260F730", Slot = "5")]
		public FieldOnGroundItemInfo Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return null;
		}

		// Token: 0x06006640 RID: 26176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054DA")]
		[Address(RVA = "0x260FB80", Offset = "0x260FC81", VA = "0x260FB80")]
		public FieldOnGroundItemInfoFormatter()
		{
		}
	}
}
