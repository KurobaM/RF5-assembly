using System;
using Il2CppDummyDll;

namespace nn.hid
{
	// Token: 0x020015A4 RID: 5540
	[Token(Token = "0x2000F31")]
	public struct VibrationDeviceInfo
	{
		// Token: 0x06007DB8 RID: 32184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006834")]
		[Address(RVA = "0x3880A0", Offset = "0x3881A1", VA = "0x3880A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0401C0B5 RID: 114869
		[Token(Token = "0x401891F")]
		[FieldOffset(Offset = "0x0")]
		public VibrationDeviceType deviceType;

		// Token: 0x0401C0B6 RID: 114870
		[Token(Token = "0x4018920")]
		[FieldOffset(Offset = "0x4")]
		public VibrationDevicePosition position;
	}
}
