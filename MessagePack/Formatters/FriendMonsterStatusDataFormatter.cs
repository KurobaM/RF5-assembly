using System;
using Il2CppDummyDll;

namespace MessagePack.Formatters
{
	// Token: 0x02000FCB RID: 4043
	[Token(Token = "0x2000A23")]
	public sealed class FriendMonsterStatusDataFormatter : IMessagePackFormatter<FriendMonsterStatusData>, IMessagePackFormatter
	{
		// Token: 0x0600664D RID: 26189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054E7")]
		[Address(RVA = "0x2611590", Offset = "0x2611691", VA = "0x2611590", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, FriendMonsterStatusData value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x0600664E RID: 26190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054E8")]
		[Address(RVA = "0x2611F30", Offset = "0x2612031", VA = "0x2611F30", Slot = "5")]
		public FriendMonsterStatusData Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return null;
		}

		// Token: 0x0600664F RID: 26191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054E9")]
		[Address(RVA = "0x2612F60", Offset = "0x2613061", VA = "0x2612F60")]
		public FriendMonsterStatusDataFormatter()
		{
		}
	}
}
