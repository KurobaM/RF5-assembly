using System;
using Farm;
using Il2CppDummyDll;

namespace MessagePack.Formatters.Farm
{
	// Token: 0x02000FF3 RID: 4083
	[Token(Token = "0x2000A4B")]
	public sealed class FarmManager_FARM_IDFormatter : IMessagePackFormatter<FarmManager.FARM_ID>, IMessagePackFormatter
	{
		// Token: 0x0600676B RID: 26475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005605")]
		[Address(RVA = "0x260D970", Offset = "0x260DA71", VA = "0x260D970", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, FarmManager.FARM_ID value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x0600676C RID: 26476 RVA: 0x000234A8 File Offset: 0x000216A8
		[Token(Token = "0x6005606")]
		[Address(RVA = "0x260D980", Offset = "0x260DA81", VA = "0x260D980", Slot = "5")]
		public FarmManager.FARM_ID Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return FarmManager.FARM_ID.RF4_FREEFARM_ID_Village;
		}

		// Token: 0x0600676D RID: 26477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005607")]
		[Address(RVA = "0x260D990", Offset = "0x260DA91", VA = "0x260D990")]
		public FarmManager_FARM_IDFormatter()
		{
		}
	}
}
