using System;
using Il2CppDummyDll;

namespace MessagePack.Formatters
{
	// Token: 0x02000FC7 RID: 4039
	[Token(Token = "0x2000A1F")]
	public sealed class FieldOnGroundItemStorageFormatter : IMessagePackFormatter<FieldOnGroundItemStorage>, IMessagePackFormatter
	{
		// Token: 0x06006641 RID: 26177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054DB")]
		[Address(RVA = "0x260FB90", Offset = "0x260FC91", VA = "0x260FB90", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, FieldOnGroundItemStorage value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x06006642 RID: 26178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054DC")]
		[Address(RVA = "0x260FCD0", Offset = "0x260FDD1", VA = "0x260FCD0", Slot = "5")]
		public FieldOnGroundItemStorage Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return null;
		}

		// Token: 0x06006643 RID: 26179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054DD")]
		[Address(RVA = "0x260FF00", Offset = "0x2610001", VA = "0x260FF00")]
		public FieldOnGroundItemStorageFormatter()
		{
		}
	}
}
