using System;
using Il2CppDummyDll;

namespace MessagePack.Formatters
{
	// Token: 0x02000FC4 RID: 4036
	[Token(Token = "0x2000A1C")]
	public sealed class EnemyStatusDataFormatter : IMessagePackFormatter<EnemyStatusData>, IMessagePackFormatter
	{
		// Token: 0x06006638 RID: 26168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054D2")]
		[Address(RVA = "0x25FD5C0", Offset = "0x25FD6C1", VA = "0x25FD5C0", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, EnemyStatusData value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x06006639 RID: 26169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054D3")]
		[Address(RVA = "0x25FDB80", Offset = "0x25FDC81", VA = "0x25FDB80", Slot = "5")]
		public EnemyStatusData Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return null;
		}

		// Token: 0x0600663A RID: 26170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054D4")]
		[Address(RVA = "0x25FE500", Offset = "0x25FE601", VA = "0x25FE500")]
		public EnemyStatusDataFormatter()
		{
		}
	}
}
