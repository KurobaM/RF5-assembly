using System;
using Il2CppDummyDll;

namespace MessagePack.Formatters
{
	// Token: 0x02000FBD RID: 4029
	[Token(Token = "0x2000A15")]
	public sealed class LovePointManager_FavoriteTypeFormatter : IMessagePackFormatter<LovePointManager.FavoriteType>, IMessagePackFormatter
	{
		// Token: 0x06006623 RID: 26147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054BD")]
		[Address(RVA = "0x22E19C0", Offset = "0x22E1AC1", VA = "0x22E19C0", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, LovePointManager.FavoriteType value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x06006624 RID: 26148 RVA: 0x000223C8 File Offset: 0x000205C8
		[Token(Token = "0x60054BE")]
		[Address(RVA = "0x22E19D0", Offset = "0x22E1AD1", VA = "0x22E19D0", Slot = "5")]
		public LovePointManager.FavoriteType Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return LovePointManager.FavoriteType.Normal;
		}

		// Token: 0x06006625 RID: 26149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054BF")]
		[Address(RVA = "0x22E19E0", Offset = "0x22E1AE1", VA = "0x22E19E0")]
		public LovePointManager_FavoriteTypeFormatter()
		{
		}
	}
}
