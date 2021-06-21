using System;
using Il2CppDummyDll;

namespace nn.hid
{
	// Token: 0x0200153E RID: 5438
	[Token(Token = "0x2000EED")]
	public struct ControllerFirmwareUpdateArg
	{
		// Token: 0x06007B90 RID: 31632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006782")]
		[Address(RVA = "0x3661C0", Offset = "0x3662C1", VA = "0x3661C0")]
		public void SetDefault()
		{
		}

		// Token: 0x0401BEAD RID: 114349
		[Token(Token = "0x40187E7")]
		[FieldOffset(Offset = "0x0")]
		public bool enableForceUpdate;

		// Token: 0x0401BEAE RID: 114350
		[Token(Token = "0x40187E8")]
		[FieldOffset(Offset = "0x1")]
		private byte _padding0;

		// Token: 0x0401BEAF RID: 114351
		[Token(Token = "0x40187E9")]
		[FieldOffset(Offset = "0x2")]
		private byte _padding1;

		// Token: 0x0401BEB0 RID: 114352
		[Token(Token = "0x40187EA")]
		[FieldOffset(Offset = "0x3")]
		private byte _padding2;
	}
}
