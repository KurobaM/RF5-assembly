using System;
using Il2CppDummyDll;

namespace MessagePack.Formatters
{
	// Token: 0x02000FDC RID: 4060
	[Token(Token = "0x2000A34")]
	public sealed class EventScriptAchievedTimeFormatter : IMessagePackFormatter<EventScriptAchievedTime>, IMessagePackFormatter
	{
		// Token: 0x060066BA RID: 26298 RVA: 0x00022A28 File Offset: 0x00020C28
		[Token(Token = "0x6005554")]
		[Address(RVA = "0x26084C0", Offset = "0x26085C1", VA = "0x26084C0")]
		private static System.ReadOnlySpan<byte> GetSpan_EventScriptAchievedType()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x060066BB RID: 26299 RVA: 0x00022A40 File Offset: 0x00020C40
		[Token(Token = "0x6005555")]
		[Address(RVA = "0x2608530", Offset = "0x2608631", VA = "0x2608530")]
		private static System.ReadOnlySpan<byte> GetSpan_AchievedTime()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x060066BC RID: 26300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005556")]
		[Address(RVA = "0x26085A0", Offset = "0x26086A1", VA = "0x26085A0", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, EventScriptAchievedTime value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x060066BD RID: 26301 RVA: 0x00022A58 File Offset: 0x00020C58
		[Token(Token = "0x6005557")]
		[Address(RVA = "0x26086F0", Offset = "0x26087F1", VA = "0x26086F0", Slot = "5")]
		public EventScriptAchievedTime Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return default(EventScriptAchievedTime);
		}

		// Token: 0x060066BE RID: 26302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005558")]
		[Address(RVA = "0x2608C10", Offset = "0x2608D11", VA = "0x2608C10")]
		public EventScriptAchievedTimeFormatter()
		{
		}
	}
}
