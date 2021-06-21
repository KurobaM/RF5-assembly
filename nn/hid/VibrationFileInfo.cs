using System;
using Il2CppDummyDll;

namespace nn.hid
{
	// Token: 0x020015A6 RID: 5542
	[Token(Token = "0x2000F33")]
	public struct VibrationFileInfo
	{
		// Token: 0x06007DBF RID: 32191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600683B")]
		[Address(RVA = "0x388140", Offset = "0x388241", VA = "0x388140", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0401C0B7 RID: 114871
		[Token(Token = "0x4018921")]
		[FieldOffset(Offset = "0x0")]
		public uint metaDataSize;

		// Token: 0x0401C0B8 RID: 114872
		[Token(Token = "0x4018922")]
		[FieldOffset(Offset = "0x4")]
		public ushort formatId;

		// Token: 0x0401C0B9 RID: 114873
		[Token(Token = "0x4018923")]
		[FieldOffset(Offset = "0x6")]
		public ushort samplingRate;

		// Token: 0x0401C0BA RID: 114874
		[Token(Token = "0x4018924")]
		[FieldOffset(Offset = "0x8")]
		public uint dataSize;

		// Token: 0x0401C0BB RID: 114875
		[Token(Token = "0x4018925")]
		[FieldOffset(Offset = "0xC")]
		public int sampleLength;

		// Token: 0x0401C0BC RID: 114876
		[Token(Token = "0x4018926")]
		[FieldOffset(Offset = "0x10")]
		public int isLoop;

		// Token: 0x0401C0BD RID: 114877
		[Token(Token = "0x4018927")]
		[FieldOffset(Offset = "0x14")]
		public uint loopStartPosition;

		// Token: 0x0401C0BE RID: 114878
		[Token(Token = "0x4018928")]
		[FieldOffset(Offset = "0x18")]
		public uint loopEndPosition;

		// Token: 0x0401C0BF RID: 114879
		[Token(Token = "0x4018929")]
		[FieldOffset(Offset = "0x1C")]
		public uint loopInterval;
	}
}
