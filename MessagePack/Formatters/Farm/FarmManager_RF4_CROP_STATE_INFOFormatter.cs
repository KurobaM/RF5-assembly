using System;
using Farm;
using Il2CppDummyDll;

namespace MessagePack.Formatters.Farm
{
	// Token: 0x02000FF7 RID: 4087
	[Token(Token = "0x2000A4F")]
	public sealed class FarmManager_RF4_CROP_STATE_INFOFormatter : IMessagePackFormatter<FarmManager.RF4_CROP_STATE_INFO>, IMessagePackFormatter
	{
		// Token: 0x06006777 RID: 26487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005611")]
		[Address(RVA = "0x260E290", Offset = "0x260E391", VA = "0x260E290", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, FarmManager.RF4_CROP_STATE_INFO value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x06006778 RID: 26488 RVA: 0x000234F0 File Offset: 0x000216F0
		[Token(Token = "0x6005612")]
		[Address(RVA = "0x260E560", Offset = "0x260E661", VA = "0x260E560", Slot = "5")]
		public FarmManager.RF4_CROP_STATE_INFO Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return default(FarmManager.RF4_CROP_STATE_INFO);
		}

		// Token: 0x06006779 RID: 26489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005613")]
		[Address(RVA = "0x260EA60", Offset = "0x260EB61", VA = "0x260EA60")]
		public FarmManager_RF4_CROP_STATE_INFOFormatter()
		{
		}
	}
}
