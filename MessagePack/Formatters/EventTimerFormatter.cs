using System;
using Il2CppDummyDll;

namespace MessagePack.Formatters
{
	// Token: 0x02000FDD RID: 4061
	[Token(Token = "0x2000A35")]
	public sealed class EventTimerFormatter : IMessagePackFormatter<EventTimer>, IMessagePackFormatter
	{
		// Token: 0x060066BF RID: 26303 RVA: 0x00022A70 File Offset: 0x00020C70
		[Token(Token = "0x6005559")]
		[Address(RVA = "0x2608C20", Offset = "0x2608D21", VA = "0x2608C20")]
		private static System.ReadOnlySpan<byte> GetSpan_Year()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x060066C0 RID: 26304 RVA: 0x00022A88 File Offset: 0x00020C88
		[Token(Token = "0x600555A")]
		[Address(RVA = "0x2608C90", Offset = "0x2608D91", VA = "0x2608C90")]
		private static System.ReadOnlySpan<byte> GetSpan_Season()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x060066C1 RID: 26305 RVA: 0x00022AA0 File Offset: 0x00020CA0
		[Token(Token = "0x600555B")]
		[Address(RVA = "0x2608D00", Offset = "0x2608E01", VA = "0x2608D00")]
		private static System.ReadOnlySpan<byte> GetSpan_Week()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x060066C2 RID: 26306 RVA: 0x00022AB8 File Offset: 0x00020CB8
		[Token(Token = "0x600555C")]
		[Address(RVA = "0x2608D70", Offset = "0x2608E71", VA = "0x2608D70")]
		private static System.ReadOnlySpan<byte> GetSpan_Day()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x060066C3 RID: 26307 RVA: 0x00022AD0 File Offset: 0x00020CD0
		[Token(Token = "0x600555D")]
		[Address(RVA = "0x2608DE0", Offset = "0x2608EE1", VA = "0x2608DE0")]
		private static System.ReadOnlySpan<byte> GetSpan_Hour()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x060066C4 RID: 26308 RVA: 0x00022AE8 File Offset: 0x00020CE8
		[Token(Token = "0x600555E")]
		[Address(RVA = "0x2608E50", Offset = "0x2608F51", VA = "0x2608E50")]
		private static System.ReadOnlySpan<byte> GetSpan_Minutes()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x060066C5 RID: 26309 RVA: 0x00022B00 File Offset: 0x00020D00
		[Token(Token = "0x600555F")]
		[Address(RVA = "0x2608EC0", Offset = "0x2608FC1", VA = "0x2608EC0")]
		private static System.ReadOnlySpan<byte> GetSpan_TimeZone()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x060066C6 RID: 26310 RVA: 0x00022B18 File Offset: 0x00020D18
		[Token(Token = "0x6005560")]
		[Address(RVA = "0x2608F30", Offset = "0x2609031", VA = "0x2608F30")]
		private static System.ReadOnlySpan<byte> GetSpan_Weather()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x060066C7 RID: 26311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005561")]
		[Address(RVA = "0x2608FA0", Offset = "0x26090A1", VA = "0x2608FA0", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, EventTimer value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x060066C8 RID: 26312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005562")]
		[Address(RVA = "0x2609600", Offset = "0x2609701", VA = "0x2609600", Slot = "5")]
		public EventTimer Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return null;
		}

		// Token: 0x060066C9 RID: 26313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005563")]
		[Address(RVA = "0x2609C40", Offset = "0x2609D41", VA = "0x2609C40")]
		public EventTimerFormatter()
		{
		}
	}
}
