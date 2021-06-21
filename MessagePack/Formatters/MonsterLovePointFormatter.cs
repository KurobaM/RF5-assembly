using System;
using Il2CppDummyDll;

namespace MessagePack.Formatters
{
	// Token: 0x02000FE2 RID: 4066
	[Token(Token = "0x2000A3A")]
	public sealed class MonsterLovePointFormatter : IMessagePackFormatter<MonsterLovePoint>, IMessagePackFormatter
	{
		// Token: 0x060066F0 RID: 26352 RVA: 0x00022DA0 File Offset: 0x00020FA0
		[Token(Token = "0x600558A")]
		[Address(RVA = "0x22E2540", Offset = "0x22E2641", VA = "0x22E2540")]
		private static System.ReadOnlySpan<byte> GetSpan_LovePoint()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x060066F1 RID: 26353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600558B")]
		[Address(RVA = "0x22E25B0", Offset = "0x22E26B1", VA = "0x22E25B0", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, MonsterLovePoint value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x060066F2 RID: 26354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600558C")]
		[Address(RVA = "0x22E26A0", Offset = "0x22E27A1", VA = "0x22E26A0", Slot = "5")]
		public MonsterLovePoint Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return null;
		}

		// Token: 0x060066F3 RID: 26355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600558D")]
		[Address(RVA = "0x22E29E0", Offset = "0x22E2AE1", VA = "0x22E29E0")]
		public MonsterLovePointFormatter()
		{
		}
	}
}
