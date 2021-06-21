using System;
using Il2CppDummyDll;

namespace MessagePack.Formatters
{
	// Token: 0x02000FD5 RID: 4053
	[Token(Token = "0x2000A2D")]
	public sealed class RuneAbilityItemDataFormatter : IMessagePackFormatter<RuneAbilityItemData>, IMessagePackFormatter
	{
		// Token: 0x0600666B RID: 26219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005505")]
		[Address(RVA = "0x22F02D0", Offset = "0x22F03D1", VA = "0x22F02D0", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, RuneAbilityItemData value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x0600666C RID: 26220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005506")]
		[Address(RVA = "0x22F0430", Offset = "0x22F0531", VA = "0x22F0430", Slot = "5")]
		public RuneAbilityItemData Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return null;
		}

		// Token: 0x0600666D RID: 26221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005507")]
		[Address(RVA = "0x22F0680", Offset = "0x22F0781", VA = "0x22F0680")]
		public RuneAbilityItemDataFormatter()
		{
		}
	}
}
