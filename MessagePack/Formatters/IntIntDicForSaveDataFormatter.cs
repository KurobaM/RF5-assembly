using System;
using Il2CppDummyDll;

namespace MessagePack.Formatters
{
	// Token: 0x02000FCD RID: 4045
	[Token(Token = "0x2000A25")]
	public sealed class IntIntDicForSaveDataFormatter : IMessagePackFormatter<IntIntDicForSaveData>, IMessagePackFormatter
	{
		// Token: 0x06006653 RID: 26195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054ED")]
		[Address(RVA = "0x2615090", Offset = "0x2615191", VA = "0x2615090", Slot = "4")]
		public void Serialize(ref MessagePackWriter writer, IntIntDicForSaveData value, MessagePackSerializerOptions options)
		{
		}

		// Token: 0x06006654 RID: 26196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054EE")]
		[Address(RVA = "0x2615270", Offset = "0x2615371", VA = "0x2615270", Slot = "5")]
		public IntIntDicForSaveData Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
		{
			return null;
		}

		// Token: 0x06006655 RID: 26197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054EF")]
		[Address(RVA = "0x2615570", Offset = "0x2615671", VA = "0x2615570")]
		public IntIntDicForSaveDataFormatter()
		{
		}
	}
}
