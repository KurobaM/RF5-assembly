using System;
using Il2CppDummyDll;

namespace MessagePack.Formatters
{
	// Token: 0x02000FD9 RID: 4057
	[Token(Token = "0x2000A31")]
	public sealed class EventDataFormatter : IMessagePackFormatter<EventData>, IMessagePackFormatter
	{
		// Token: 0x0600667F RID: 26239 RVA: 0x00022578 File Offset: 0x00020778
		[Token(Token = "0x6005519")]
		[Address(RVA = "0x2600020", Offset = "0x2600121", VA = "0x2600020")]
		private static System.ReadOnlySpan<byte> GetSpan_EventId()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x06006680 RID: 26240 RVA: 0x00022590 File Offset: 0x00020790
		[Token(Token = "0x600551A")]
		[Address(RVA = "0x2600090", Offset = "0x2600191", VA = "0x2600090")]
		private static System.ReadOnlySpan<byte> GetSpan_EventState()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x06006681 RID: 26241 RVA: 0x000225A8 File Offset: 0x000207A8
		[Token(Token = "0x600551B")]
		[Address(RVA = "0x2600100", Offset = "0x2600201", VA = "0x2600100")]
		private static System.ReadOnlySpan<byte> GetSpan_OrderId()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x06006682 RID: 26242 RVA: 0x000225C0 File Offset: 0x000207C0
		[Token(Token = "0x600551C")]
		[Address(RVA = "0x2600170", Offset = "0x2600271", VA = "0x2600170")]
		private static System.ReadOnlySpan<byte> GetSpan_CurrentStep()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x06006683 RID: 26243 RVA: 0x000225D8 File Offset: 0x000207D8
		[Token(Token = "0x600551D")]
		[Address(RVA = "0x26001E0", Offset = "0x26002E1", VA = "0x26001E0")]
		private static System.ReadOnlySpan<byte> GetSpan_CurrentReservedStep()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x06006684 RID: 26244 RVA: 0x000225F0 File Offset: 0x000207F0
		[Token(Token = "0x600551E")]
		[Address(RVA = "0x2600250", Offset = "0x2600351", VA = "0x2600250")]
		private static System.ReadOnlySpan<byte> GetSpan_NextStep()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x06006685 RID: 26245 RVA: 0x00022608 File Offset: 0x00020808
		[Token(Token = "0x600551F")]
		[Address(RVA = "0x26002C0", Offset = "0x26003C1", VA = "0x26002C0")]
		private static System.ReadOnlySpan<byte> GetSpan_CurrentNpcEventType()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x06006686 RID: 26246 RVA: 0x00022620 File Offset: 0x00020820
		[Token(Token = "0x6005520")]
		[Address(RVA = "0x2600330", Offset = "0x2600431", VA = "0x2600330")]
		private static System.ReadOnlySpan<byte> GetSpan_CurrentNpcEventPath()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x06006687 RID: 26247 RVA: 0x00022638 File Offset: 0x00020838
		[Token(Token = "0x6005521")]
		[Address(RVA = "0x26003A0", Offset = "0x26004A1", VA = "0x26003A0")]
		private static System.ReadOnlySpan<byte> GetSpan_CurrentTargetEventStep()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x06006688 RID: 26248 RVA: 0x00022650 File Offset: 0x00020850
		[Token(Token = "0x6005522")]
		[Address(RVA = "0x2600410", Offset = "0x2600511", VA = "0x2600410")]
		private static System.ReadOnlySpan<byte> GetSpan_SubEventSteps()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x06006689 RID: 26249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005523")]
		[Address(RVA = "0x2600480", Offset = "0x2600581", VA = "0x2600480", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, EventData value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x0600668A RID: 26250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005524")]
		[Address(RVA = "0x2600BE0", Offset = "0x2600CE1", VA = "0x2600BE0", Slot = "5")]
		public EventData Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return null;
		}

		// Token: 0x0600668B RID: 26251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005525")]
		[Address(RVA = "0x2601B80", Offset = "0x2601C81", VA = "0x2601B80")]
		public EventDataFormatter()
		{
		}
	}
}
