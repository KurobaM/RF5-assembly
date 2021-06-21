using System;
using Define;
using Il2CppDummyDll;

namespace MessagePack.Formatters.Define
{
	// Token: 0x0200100F RID: 4111
	[Token(Token = "0x2000A67")]
	public sealed class VaccinationIDFormatter : IMessagePackFormatter<VaccinationID>, IMessagePackFormatter
	{
		// Token: 0x060067BF RID: 26559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005659")]
		[Address(RVA = "0x25FD4D0", Offset = "0x25FD5D1", VA = "0x25FD4D0", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, VaccinationID value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x060067C0 RID: 26560 RVA: 0x00023730 File Offset: 0x00021930
		[Token(Token = "0x600565A")]
		[Address(RVA = "0x25FD4E0", Offset = "0x25FD5E1", VA = "0x25FD4E0", Slot = "5")]
		public VaccinationID Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return VaccinationID.EMPTY;
		}

		// Token: 0x060067C1 RID: 26561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600565B")]
		[Address(RVA = "0x25FD4F0", Offset = "0x25FD5F1", VA = "0x25FD4F0")]
		public VaccinationIDFormatter()
		{
		}
	}
}
