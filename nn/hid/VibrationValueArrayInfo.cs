using System;
using Il2CppDummyDll;

namespace nn.hid
{
	// Token: 0x020015A7 RID: 5543
	[Token(Token = "0x2000F34")]
	public struct VibrationValueArrayInfo
	{
		// Token: 0x06007DC0 RID: 32192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600683C")]
		[Address(RVA = "0x388510", Offset = "0x388611", VA = "0x388510", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0401C0C0 RID: 114880
		[Token(Token = "0x401892A")]
		[FieldOffset(Offset = "0x0")]
		public int sampleLength;

		// Token: 0x0401C0C1 RID: 114881
		[Token(Token = "0x401892B")]
		[FieldOffset(Offset = "0x4")]
		public bool isLoop;

		// Token: 0x0401C0C2 RID: 114882
		[Token(Token = "0x401892C")]
		[FieldOffset(Offset = "0x8")]
		public uint loopStartPosition;

		// Token: 0x0401C0C3 RID: 114883
		[Token(Token = "0x401892D")]
		[FieldOffset(Offset = "0xC")]
		public uint loopEndPosition;

		// Token: 0x0401C0C4 RID: 114884
		[Token(Token = "0x401892E")]
		[FieldOffset(Offset = "0x10")]
		public uint loopInterval;
	}
}
