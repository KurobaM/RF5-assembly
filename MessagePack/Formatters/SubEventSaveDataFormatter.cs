using System;
using Il2CppDummyDll;

namespace MessagePack.Formatters
{
	// Token: 0x02000FE7 RID: 4071
	[Token(Token = "0x2000A3F")]
	public sealed class SubEventSaveDataFormatter : IMessagePackFormatter<SubEventSaveData>, IMessagePackFormatter
	{
		// Token: 0x0600673C RID: 26428 RVA: 0x00023358 File Offset: 0x00021558
		[Token(Token = "0x60055D6")]
		[Address(RVA = "0x22F14E0", Offset = "0x22F15E1", VA = "0x22F14E0")]
		private static System.ReadOnlySpan<byte> GetSpan_ProgressingSubEventID()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x0600673D RID: 26429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055D7")]
		[Address(RVA = "0x22F1550", Offset = "0x22F1651", VA = "0x22F1550", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, SubEventSaveData value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x0600673E RID: 26430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055D8")]
		[Address(RVA = "0x22F1640", Offset = "0x22F1741", VA = "0x22F1640", Slot = "5")]
		public SubEventSaveData Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return null;
		}

		// Token: 0x0600673F RID: 26431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055D9")]
		[Address(RVA = "0x22F1980", Offset = "0x22F1A81", VA = "0x22F1980")]
		public SubEventSaveDataFormatter()
		{
		}
	}
}
