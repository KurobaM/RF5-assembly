using System;
using Il2CppDummyDll;
using RF5SHIPPING;

namespace MessagePack.Formatters.RF5SHIPPING
{
	// Token: 0x02000FEE RID: 4078
	[Token(Token = "0x2000A46")]
	public sealed class CROWNTYPEFormatter : IMessagePackFormatter<CROWNTYPE>, IMessagePackFormatter
	{
		// Token: 0x0600675C RID: 26460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055F6")]
		[Address(RVA = "0x22EE500", Offset = "0x22EE601", VA = "0x22EE500", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, CROWNTYPE value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x0600675D RID: 26461 RVA: 0x00023478 File Offset: 0x00021678
		[Token(Token = "0x60055F7")]
		[Address(RVA = "0x22EE510", Offset = "0x22EE611", VA = "0x22EE510", Slot = "5")]
		public CROWNTYPE Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return CROWNTYPE.NONE;
		}

		// Token: 0x0600675E RID: 26462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055F8")]
		[Address(RVA = "0x22EE520", Offset = "0x22EE621", VA = "0x22EE520")]
		public CROWNTYPEFormatter()
		{
		}
	}
}
