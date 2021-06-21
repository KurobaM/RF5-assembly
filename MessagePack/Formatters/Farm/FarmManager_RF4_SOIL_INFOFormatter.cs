using System;
using Farm;
using Il2CppDummyDll;

namespace MessagePack.Formatters.Farm
{
	// Token: 0x02000FF9 RID: 4089
	[Token(Token = "0x2000A51")]
	public sealed class FarmManager_RF4_SOIL_INFOFormatter : IMessagePackFormatter<FarmManager.RF4_SOIL_INFO>, IMessagePackFormatter
	{
		// Token: 0x0600677D RID: 26493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005617")]
		[Address(RVA = "0x260ECC0", Offset = "0x260EDC1", VA = "0x260ECC0", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, FarmManager.RF4_SOIL_INFO value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x0600677E RID: 26494 RVA: 0x00023520 File Offset: 0x00021720
		[Token(Token = "0x6005618")]
		[Address(RVA = "0x260EF90", Offset = "0x260F091", VA = "0x260EF90", Slot = "5")]
		public FarmManager.RF4_SOIL_INFO Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return default(FarmManager.RF4_SOIL_INFO);
		}

		// Token: 0x0600677F RID: 26495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005619")]
		[Address(RVA = "0x260F450", Offset = "0x260F551", VA = "0x260F450")]
		public FarmManager_RF4_SOIL_INFOFormatter()
		{
		}
	}
}
