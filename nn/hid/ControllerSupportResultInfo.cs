using System;
using Il2CppDummyDll;

namespace nn.hid
{
	// Token: 0x0200153F RID: 5439
	[Token(Token = "0x2000EEE")]
	public struct ControllerSupportResultInfo
	{
		// Token: 0x06007B91 RID: 31633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006783")]
		[Address(RVA = "0x3668D0", Offset = "0x3669D1", VA = "0x3668D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0401BEB1 RID: 114353
		[Token(Token = "0x40187EB")]
		[FieldOffset(Offset = "0x0")]
		public byte playerCount;

		// Token: 0x0401BEB2 RID: 114354
		[Token(Token = "0x40187EC")]
		[FieldOffset(Offset = "0x4")]
		public NpadId selectedId;

		// Token: 0x0401BEB3 RID: 114355
		[Token(Token = "0x40187ED")]
		[FieldOffset(Offset = "0x8")]
		private byte _padding0;

		// Token: 0x0401BEB4 RID: 114356
		[Token(Token = "0x40187EE")]
		[FieldOffset(Offset = "0x9")]
		private byte _padding1;

		// Token: 0x0401BEB5 RID: 114357
		[Token(Token = "0x40187EF")]
		[FieldOffset(Offset = "0xA")]
		private byte _padding2;
	}
}
