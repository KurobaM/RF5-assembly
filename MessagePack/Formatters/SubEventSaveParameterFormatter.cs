using System;
using Il2CppDummyDll;

namespace MessagePack.Formatters
{
	// Token: 0x02000FE8 RID: 4072
	[Token(Token = "0x2000A40")]
	public sealed class SubEventSaveParameterFormatter : IMessagePackFormatter<SubEventSaveParameter>, IMessagePackFormatter
	{
		// Token: 0x06006740 RID: 26432 RVA: 0x00023370 File Offset: 0x00021570
		[Token(Token = "0x60055DA")]
		[Address(RVA = "0x22F1990", Offset = "0x22F1A91", VA = "0x22F1990")]
		private static System.ReadOnlySpan<byte> GetSpan_Step()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x06006741 RID: 26433 RVA: 0x00023388 File Offset: 0x00021588
		[Token(Token = "0x60055DB")]
		[Address(RVA = "0x22F1A00", Offset = "0x22F1B01", VA = "0x22F1A00")]
		private static System.ReadOnlySpan<byte> GetSpan_NextStep()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x06006742 RID: 26434 RVA: 0x000233A0 File Offset: 0x000215A0
		[Token(Token = "0x60055DC")]
		[Address(RVA = "0x22F1A70", Offset = "0x22F1B71", VA = "0x22F1A70")]
		private static System.ReadOnlySpan<byte> GetSpan_NextStepDaysLeft()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x06006743 RID: 26435 RVA: 0x000233B8 File Offset: 0x000215B8
		[Token(Token = "0x60055DD")]
		[Address(RVA = "0x22F1AE0", Offset = "0x22F1BE1", VA = "0x22F1AE0")]
		private static System.ReadOnlySpan<byte> GetSpan_NextStepTime()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x06006744 RID: 26436 RVA: 0x000233D0 File Offset: 0x000215D0
		[Token(Token = "0x60055DE")]
		[Address(RVA = "0x22F1B50", Offset = "0x22F1C51", VA = "0x22F1B50")]
		private static System.ReadOnlySpan<byte> GetSpan_NextStepConfig()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x06006745 RID: 26437 RVA: 0x000233E8 File Offset: 0x000215E8
		[Token(Token = "0x60055DF")]
		[Address(RVA = "0x22F1BC0", Offset = "0x22F1CC1", VA = "0x22F1BC0")]
		private static System.ReadOnlySpan<byte> GetSpan_Completed()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x06006746 RID: 26438 RVA: 0x00023400 File Offset: 0x00021600
		[Token(Token = "0x60055E0")]
		[Address(RVA = "0x22F1C30", Offset = "0x22F1D31", VA = "0x22F1C30")]
		private static System.ReadOnlySpan<byte> GetSpan_CompletedDate()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x06006747 RID: 26439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055E1")]
		[Address(RVA = "0x22F1CA0", Offset = "0x22F1DA1", VA = "0x22F1CA0", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, SubEventSaveParameter value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x06006748 RID: 26440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055E2")]
		[Address(RVA = "0x22F20A0", Offset = "0x22F21A1", VA = "0x22F20A0", Slot = "5")]
		public SubEventSaveParameter Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return null;
		}

		// Token: 0x06006749 RID: 26441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055E3")]
		[Address(RVA = "0x22F2C00", Offset = "0x22F2D01", VA = "0x22F2C00")]
		public SubEventSaveParameterFormatter()
		{
		}
	}
}
