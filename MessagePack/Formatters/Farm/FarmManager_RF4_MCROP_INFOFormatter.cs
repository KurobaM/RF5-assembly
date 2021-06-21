using System;
using Farm;
using Il2CppDummyDll;

namespace MessagePack.Formatters.Farm
{
	// Token: 0x02000FF8 RID: 4088
	[Token(Token = "0x2000A50")]
	public sealed class FarmManager_RF4_MCROP_INFOFormatter : IMessagePackFormatter<FarmManager.RF4_MCROP_INFO>, IMessagePackFormatter
	{
		// Token: 0x0600677A RID: 26490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005614")]
		[Address(RVA = "0x260EA70", Offset = "0x260EB71", VA = "0x260EA70", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, FarmManager.RF4_MCROP_INFO value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x0600677B RID: 26491 RVA: 0x00023508 File Offset: 0x00021708
		[Token(Token = "0x6005615")]
		[Address(RVA = "0x260EAE0", Offset = "0x260EBE1", VA = "0x260EAE0", Slot = "5")]
		public FarmManager.RF4_MCROP_INFO Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return default(FarmManager.RF4_MCROP_INFO);
		}

		// Token: 0x0600677C RID: 26492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005616")]
		[Address(RVA = "0x260ECB0", Offset = "0x260EDB1", VA = "0x260ECB0")]
		public FarmManager_RF4_MCROP_INFOFormatter()
		{
		}
	}
}
