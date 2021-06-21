using System;
using Il2CppDummyDll;

namespace MessagePack.Formatters
{
	// Token: 0x02000FE4 RID: 4068
	[Token(Token = "0x2000A3C")]
	public sealed class NpcPatrolRouteFormatter : IMessagePackFormatter<NpcPatrolRoute>, IMessagePackFormatter
	{
		// Token: 0x060066FF RID: 26367 RVA: 0x00022E78 File Offset: 0x00021078
		[Token(Token = "0x6005599")]
		[Address(RVA = "0x22E41E0", Offset = "0x22E42E1", VA = "0x22E41E0")]
		private static System.ReadOnlySpan<byte> GetSpan_TargetSeatName()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x06006700 RID: 26368 RVA: 0x00022E90 File Offset: 0x00021090
		[Token(Token = "0x600559A")]
		[Address(RVA = "0x22E4250", Offset = "0x22E4351", VA = "0x22E4250")]
		private static System.ReadOnlySpan<byte> GetSpan_TargetPoint()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x06006701 RID: 26369 RVA: 0x00022EA8 File Offset: 0x000210A8
		[Token(Token = "0x600559B")]
		[Address(RVA = "0x22E42C0", Offset = "0x22E43C1", VA = "0x22E42C0")]
		private static System.ReadOnlySpan<byte> GetSpan_Rate()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x06006702 RID: 26370 RVA: 0x00022EC0 File Offset: 0x000210C0
		[Token(Token = "0x600559C")]
		[Address(RVA = "0x22E4330", Offset = "0x22E4431", VA = "0x22E4330")]
		private static System.ReadOnlySpan<byte> GetSpan_RotatePatternNumber()
		{
			return default(System.ReadOnlySpan<byte>);
		}

		// Token: 0x06006703 RID: 26371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600559D")]
		[Address(RVA = "0x22E43A0", Offset = "0x22E44A1", VA = "0x22E43A0", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, NpcPatrolRoute value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x06006704 RID: 26372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600559E")]
		[Address(RVA = "0x22E4780", Offset = "0x22E4881", VA = "0x22E4780", Slot = "5")]
		public NpcPatrolRoute Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return null;
		}

		// Token: 0x06006705 RID: 26373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600559F")]
		[Address(RVA = "0x22E5070", Offset = "0x22E5171", VA = "0x22E5070")]
		public NpcPatrolRouteFormatter()
		{
		}
	}
}
