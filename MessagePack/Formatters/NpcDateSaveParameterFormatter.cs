using System;
using Il2CppDummyDll;

namespace MessagePack.Formatters
{
	// Token: 0x02000FE3 RID: 4067
	[Token(Token = "0x2000A3B")]
	public sealed class NpcDateSaveParameterFormatter : IMessagePackFormatter<NpcDateSaveParameter>, IMessagePackFormatter
	{
		// Token: 0x060066F4 RID: 26356 RVA: 0x00022DB8 File Offset: 0x00020FB8
		[Token(Token = "0x600558E")]
		[Address(RVA = "0x22E29F0", Offset = "0x22E2AF1", VA = "0x22E29F0")]
		private static System.ReadOnlySpan<byte> GetSpan_ProgressType()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x060066F5 RID: 26357 RVA: 0x00022DD0 File Offset: 0x00020FD0
		[Token(Token = "0x600558F")]
		[Address(RVA = "0x22E2A60", Offset = "0x22E2B61", VA = "0x22E2A60")]
		private static System.ReadOnlySpan<byte> GetSpan_dateType()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x060066F6 RID: 26358 RVA: 0x00022DE8 File Offset: 0x00020FE8
		[Token(Token = "0x6005590")]
		[Address(RVA = "0x22E2AD0", Offset = "0x22E2BD1", VA = "0x22E2AD0")]
		private static System.ReadOnlySpan<byte> GetSpan_dateSpotID()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x060066F7 RID: 26359 RVA: 0x00022E00 File Offset: 0x00021000
		[Token(Token = "0x6005591")]
		[Address(RVA = "0x22E2B40", Offset = "0x22E2C41", VA = "0x22E2B40")]
		private static System.ReadOnlySpan<byte> GetSpan_NpcId()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x060066F8 RID: 26360 RVA: 0x00022E18 File Offset: 0x00021018
		[Token(Token = "0x6005592")]
		[Address(RVA = "0x22E2BB0", Offset = "0x22E2CB1", VA = "0x22E2BB0")]
		private static System.ReadOnlySpan<byte> GetSpan_dateStartTime()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x060066F9 RID: 26361 RVA: 0x00022E30 File Offset: 0x00021030
		[Token(Token = "0x6005593")]
		[Address(RVA = "0x22E2C20", Offset = "0x22E2D21", VA = "0x22E2C20")]
		private static System.ReadOnlySpan<byte> GetSpan_meetingLimitTime()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x060066FA RID: 26362 RVA: 0x00022E48 File Offset: 0x00021048
		[Token(Token = "0x6005594")]
		[Address(RVA = "0x22E2C90", Offset = "0x22E2D91", VA = "0x22E2C90")]
		private static System.ReadOnlySpan<byte> GetSpan_meetingEventPointOnFlag()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x060066FB RID: 26363 RVA: 0x00022E60 File Offset: 0x00021060
		[Token(Token = "0x6005595")]
		[Address(RVA = "0x22E2D00", Offset = "0x22E2E01", VA = "0x22E2D00")]
		private static System.ReadOnlySpan<byte> GetSpan_doSuppo()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x060066FC RID: 26364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005596")]
		[Address(RVA = "0x22E2D70", Offset = "0x22E2E71", VA = "0x22E2D70", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, NpcDateSaveParameter value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x060066FD RID: 26365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005597")]
		[Address(RVA = "0x22E33D0", Offset = "0x22E34D1", VA = "0x22E33D0", Slot = "5")]
		public NpcDateSaveParameter Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return null;
		}

		// Token: 0x060066FE RID: 26366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005598")]
		[Address(RVA = "0x22E41D0", Offset = "0x22E42D1", VA = "0x22E41D0")]
		public NpcDateSaveParameterFormatter()
		{
		}
	}
}
