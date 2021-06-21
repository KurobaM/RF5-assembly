using System;
using Il2CppDummyDll;

namespace MessagePack.Formatters
{
	// Token: 0x02000FE9 RID: 4073
	[Token(Token = "0x2000A41")]
	public sealed class SubEventStepFormatter : IMessagePackFormatter<SubEventStep>, IMessagePackFormatter
	{
		// Token: 0x0600674A RID: 26442 RVA: 0x00023418 File Offset: 0x00021618
		[Token(Token = "0x60055E4")]
		[Address(RVA = "0x22F2C10", Offset = "0x22F2D11", VA = "0x22F2C10")]
		private static System.ReadOnlySpan<byte> GetSpan_TargetEventStep()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x0600674B RID: 26443 RVA: 0x00023430 File Offset: 0x00021630
		[Token(Token = "0x60055E5")]
		[Address(RVA = "0x22F2C80", Offset = "0x22F2D81", VA = "0x22F2C80")]
		private static System.ReadOnlySpan<byte> GetSpan_KeepEventStep()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x0600674C RID: 26444 RVA: 0x00023448 File Offset: 0x00021648
		[Token(Token = "0x60055E6")]
		[Address(RVA = "0x22F2CF0", Offset = "0x22F2DF1", VA = "0x22F2CF0")]
		private static System.ReadOnlySpan<byte> GetSpan_MainEventSteps()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x0600674D RID: 26445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055E7")]
		[Address(RVA = "0x22F2D60", Offset = "0x22F2E61", VA = "0x22F2D60", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, SubEventStep value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x0600674E RID: 26446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055E8")]
		[Address(RVA = "0x22F3030", Offset = "0x22F3131", VA = "0x22F3030", Slot = "5")]
		public SubEventStep Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return null;
		}

		// Token: 0x0600674F RID: 26447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055E9")]
		[Address(RVA = "0x22F37E0", Offset = "0x22F38E1", VA = "0x22F37E0")]
		public SubEventStepFormatter()
		{
		}
	}
}
