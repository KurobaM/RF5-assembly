using System;
using Il2CppDummyDll;

namespace MessagePack.Formatters
{
	// Token: 0x02000FDB RID: 4059
	[Token(Token = "0x2000A33")]
	public sealed class EventScheduleDataFormatter : IMessagePackFormatter<EventScheduleData>, IMessagePackFormatter
	{
		// Token: 0x060066AC RID: 26284 RVA: 0x00022920 File Offset: 0x00020B20
		[Token(Token = "0x6005546")]
		[Address(RVA = "0x2606680", Offset = "0x2606781", VA = "0x2606680")]
		private static System.ReadOnlySpan<byte> GetSpan_EventId()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x060066AD RID: 26285 RVA: 0x00022938 File Offset: 0x00020B38
		[Token(Token = "0x6005547")]
		[Address(RVA = "0x26066F0", Offset = "0x26067F1", VA = "0x26066F0")]
		private static System.ReadOnlySpan<byte> GetSpan_EventStep()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x060066AE RID: 26286 RVA: 0x00022950 File Offset: 0x00020B50
		[Token(Token = "0x6005548")]
		[Address(RVA = "0x2606760", Offset = "0x2606861", VA = "0x2606760")]
		private static System.ReadOnlySpan<byte> GetSpan_StartTime()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x060066AF RID: 26287 RVA: 0x00022968 File Offset: 0x00020B68
		[Token(Token = "0x6005549")]
		[Address(RVA = "0x26067D0", Offset = "0x26068D1", VA = "0x26067D0")]
		private static System.ReadOnlySpan<byte> GetSpan_EndTime()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x060066B0 RID: 26288 RVA: 0x00022980 File Offset: 0x00020B80
		[Token(Token = "0x600554A")]
		[Address(RVA = "0x2606840", Offset = "0x2606941", VA = "0x2606840")]
		private static System.ReadOnlySpan<byte> GetSpan_JoinNpcNumMin()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x060066B1 RID: 26289 RVA: 0x00022998 File Offset: 0x00020B98
		[Token(Token = "0x600554B")]
		[Address(RVA = "0x26068B0", Offset = "0x26069B1", VA = "0x26068B0")]
		private static System.ReadOnlySpan<byte> GetSpan_JoinNpcNumMax()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x060066B2 RID: 26290 RVA: 0x000229B0 File Offset: 0x00020BB0
		[Token(Token = "0x600554C")]
		[Address(RVA = "0x2606920", Offset = "0x2606A21", VA = "0x2606920")]
		private static System.ReadOnlySpan<byte> GetSpan_JoinNpcs()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x060066B3 RID: 26291 RVA: 0x000229C8 File Offset: 0x00020BC8
		[Token(Token = "0x600554D")]
		[Address(RVA = "0x2606990", Offset = "0x2606A91", VA = "0x2606990")]
		private static System.ReadOnlySpan<byte> GetSpan_JoinRateNpcs()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x060066B4 RID: 26292 RVA: 0x000229E0 File Offset: 0x00020BE0
		[Token(Token = "0x600554E")]
		[Address(RVA = "0x2606A00", Offset = "0x2606B01", VA = "0x2606A00")]
		private static System.ReadOnlySpan<byte> GetSpan_DecideJoinNpcs()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x060066B5 RID: 26293 RVA: 0x000229F8 File Offset: 0x00020BF8
		[Token(Token = "0x600554F")]
		[Address(RVA = "0x2606A70", Offset = "0x2606B71", VA = "0x2606A70")]
		private static System.ReadOnlySpan<byte> GetSpan_NpcScoreResults()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x060066B6 RID: 26294 RVA: 0x00022A10 File Offset: 0x00020C10
		[Token(Token = "0x6005550")]
		[Address(RVA = "0x2606AE0", Offset = "0x2606BE1", VA = "0x2606AE0")]
		private static System.ReadOnlySpan<byte> GetSpan_NpcEventDatas()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x060066B7 RID: 26295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005551")]
		[Address(RVA = "0x2606B50", Offset = "0x2606C51", VA = "0x2606B50", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, EventScheduleData value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x060066B8 RID: 26296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005552")]
		[Address(RVA = "0x2607520", Offset = "0x2607621", VA = "0x2607520", Slot = "5")]
		public EventScheduleData Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return null;
		}

		// Token: 0x060066B9 RID: 26297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005553")]
		[Address(RVA = "0x26084B0", Offset = "0x26085B1", VA = "0x26084B0")]
		public EventScheduleDataFormatter()
		{
		}
	}
}
