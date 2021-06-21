using System;
using Farm;
using Il2CppDummyDll;

namespace MessagePack.Formatters.Farm
{
	// Token: 0x02000FF6 RID: 4086
	[Token(Token = "0x2000A4E")]
	public sealed class FarmManager_RF4_CROP_STATEFormatter : IMessagePackFormatter<FarmManager.RF4_CROP_STATE>, IMessagePackFormatter
	{
		// Token: 0x06006774 RID: 26484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600560E")]
		[Address(RVA = "0x260D9D0", Offset = "0x260DAD1", VA = "0x260D9D0", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, FarmManager.RF4_CROP_STATE value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x06006775 RID: 26485 RVA: 0x000234D8 File Offset: 0x000216D8
		[Token(Token = "0x600560F")]
		[Address(RVA = "0x260DCF0", Offset = "0x260DDF1", VA = "0x260DCF0", Slot = "5")]
		public FarmManager.RF4_CROP_STATE Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return default(FarmManager.RF4_CROP_STATE);
		}

		// Token: 0x06006776 RID: 26486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005610")]
		[Address(RVA = "0x260E280", Offset = "0x260E381", VA = "0x260E280")]
		public FarmManager_RF4_CROP_STATEFormatter()
		{
		}
	}
}
