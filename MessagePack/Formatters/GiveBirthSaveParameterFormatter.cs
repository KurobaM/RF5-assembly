using System;
using Il2CppDummyDll;

namespace MessagePack.Formatters
{
	// Token: 0x02000FDF RID: 4063
	[Token(Token = "0x2000A37")]
	public sealed class GiveBirthSaveParameterFormatter : IMessagePackFormatter<GiveBirthSaveParameter>, IMessagePackFormatter
	{
		// Token: 0x060066E3 RID: 26339 RVA: 0x00022D40 File Offset: 0x00020F40
		[Token(Token = "0x600557D")]
		[Address(RVA = "0x2612F70", Offset = "0x2613071", VA = "0x2612F70")]
		private static System.ReadOnlySpan<byte> GetSpan_Targetdays()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x060066E4 RID: 26340 RVA: 0x00022D58 File Offset: 0x00020F58
		[Token(Token = "0x600557E")]
		[Address(RVA = "0x2612FE0", Offset = "0x26130E1", VA = "0x2612FE0")]
		private static System.ReadOnlySpan<byte> GetSpan_NowType()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x060066E5 RID: 26341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600557F")]
		[Address(RVA = "0x2613050", Offset = "0x2613151", VA = "0x2613050", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, GiveBirthSaveParameter value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x060066E6 RID: 26342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005580")]
		[Address(RVA = "0x26131C0", Offset = "0x26132C1", VA = "0x26131C0", Slot = "5")]
		public GiveBirthSaveParameter Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return null;
		}

		// Token: 0x060066E7 RID: 26343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005581")]
		[Address(RVA = "0x2613580", Offset = "0x2613681", VA = "0x2613580")]
		public GiveBirthSaveParameterFormatter()
		{
		}
	}
}
