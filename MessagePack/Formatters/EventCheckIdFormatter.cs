using System;
using Il2CppDummyDll;

namespace MessagePack.Formatters
{
	// Token: 0x02000FD8 RID: 4056
	[Token(Token = "0x2000A30")]
	public sealed class EventCheckIdFormatter : IMessagePackFormatter<EventCheckId>, IMessagePackFormatter
	{
		// Token: 0x06006678 RID: 26232 RVA: 0x00022500 File Offset: 0x00020700
		[Token(Token = "0x6005512")]
		[Address(RVA = "0x25FF250", Offset = "0x25FF351", VA = "0x25FF250")]
		private static System.ReadOnlySpan<byte> GetSpan_CheckTriggerType()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x06006679 RID: 26233 RVA: 0x00022518 File Offset: 0x00020718
		[Token(Token = "0x6005513")]
		[Address(RVA = "0x25FF2C0", Offset = "0x25FF3C1", VA = "0x25FF2C0")]
		private static System.ReadOnlySpan<byte> GetSpan_CheckTriggerId()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x0600667A RID: 26234 RVA: 0x00022530 File Offset: 0x00020730
		[Token(Token = "0x6005514")]
		[Address(RVA = "0x25FF330", Offset = "0x25FF431", VA = "0x25FF330")]
		private static System.ReadOnlySpan<byte> GetSpan_CheckScriptName()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x0600667B RID: 26235 RVA: 0x00022548 File Offset: 0x00020748
		[Token(Token = "0x6005515")]
		[Address(RVA = "0x25FF3A0", Offset = "0x25FF4A1", VA = "0x25FF3A0")]
		private static System.ReadOnlySpan<byte> GetSpan_CheckEnemyName()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x0600667C RID: 26236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005516")]
		[Address(RVA = "0x25FF410", Offset = "0x25FF511", VA = "0x25FF410", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, EventCheckId value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x0600667D RID: 26237 RVA: 0x00022560 File Offset: 0x00020760
		[Token(Token = "0x6005517")]
		[Address(RVA = "0x25FF7C0", Offset = "0x25FF8C1", VA = "0x25FF7C0", Slot = "5")]
		public EventCheckId Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return default(EventCheckId);
		}

		// Token: 0x0600667E RID: 26238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005518")]
		[Address(RVA = "0x25FFFE0", Offset = "0x26000E1", VA = "0x25FFFE0")]
		public EventCheckIdFormatter()
		{
		}
	}
}
