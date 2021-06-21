using System;
using Il2CppDummyDll;

namespace MessagePack.Formatters
{
	// Token: 0x02000FE6 RID: 4070
	[Token(Token = "0x2000A3E")]
	public sealed class ReservationEventParameterFormatter : IMessagePackFormatter<ReservationEventParameter>, IMessagePackFormatter
	{
		// Token: 0x06006736 RID: 26422 RVA: 0x00023310 File Offset: 0x00021510
		[Token(Token = "0x60055D0")]
		[Address(RVA = "0x22EFCC0", Offset = "0x22EFDC1", VA = "0x22EFCC0")]
		private static System.ReadOnlySpan<byte> GetSpan_EventId()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x06006737 RID: 26423 RVA: 0x00023328 File Offset: 0x00021528
		[Token(Token = "0x60055D1")]
		[Address(RVA = "0x22EFD30", Offset = "0x22EFE31", VA = "0x22EFD30")]
		private static System.ReadOnlySpan<byte> GetSpan_NpcId()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x06006738 RID: 26424 RVA: 0x00023340 File Offset: 0x00021540
		[Token(Token = "0x60055D2")]
		[Address(RVA = "0x22EFDA0", Offset = "0x22EFEA1", VA = "0x22EFDA0")]
		private static System.ReadOnlySpan<byte> GetSpan_Progress()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x06006739 RID: 26425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055D3")]
		[Address(RVA = "0x22EFE10", Offset = "0x22EFF11", VA = "0x22EFE10", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, ReservationEventParameter value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x0600673A RID: 26426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055D4")]
		[Address(RVA = "0x22F0000", Offset = "0x22F0101", VA = "0x22F0000", Slot = "5")]
		public ReservationEventParameter Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return null;
		}

		// Token: 0x0600673B RID: 26427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055D5")]
		[Address(RVA = "0x22F02C0", Offset = "0x22F03C1", VA = "0x22F02C0")]
		public ReservationEventParameterFormatter()
		{
		}
	}
}
