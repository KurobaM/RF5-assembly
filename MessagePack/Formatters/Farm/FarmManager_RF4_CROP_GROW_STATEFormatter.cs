using System;
using Farm;
using Il2CppDummyDll;

namespace MessagePack.Formatters.Farm
{
	// Token: 0x02000FF4 RID: 4084
	[Token(Token = "0x2000A4C")]
	public sealed class FarmManager_RF4_CROP_GROW_STATEFormatter : IMessagePackFormatter<FarmManager.RF4_CROP_GROW_STATE>, IMessagePackFormatter
	{
		// Token: 0x0600676E RID: 26478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005608")]
		[Address(RVA = "0x260D9A0", Offset = "0x260DAA1", VA = "0x260D9A0", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, FarmManager.RF4_CROP_GROW_STATE value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x0600676F RID: 26479 RVA: 0x000234C0 File Offset: 0x000216C0
		[Token(Token = "0x6005609")]
		[Address(RVA = "0x260D9B0", Offset = "0x260DAB1", VA = "0x260D9B0", Slot = "5")]
		public FarmManager.RF4_CROP_GROW_STATE Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return FarmManager.RF4_CROP_GROW_STATE.RF4_CROP_GROW_NULL;
		}

		// Token: 0x06006770 RID: 26480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600560A")]
		[Address(RVA = "0x260D9C0", Offset = "0x260DAC1", VA = "0x260D9C0")]
		public FarmManager_RF4_CROP_GROW_STATEFormatter()
		{
		}
	}
}
