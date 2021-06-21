using System;
using Il2CppDummyDll;

namespace nn.hid
{
	// Token: 0x02001552 RID: 5458
	[Token(Token = "0x2000EFF")]
	[Flags]
	public enum NpadAttribute
	{
		// Token: 0x0401BF31 RID: 114481
		[Token(Token = "0x4018863")]
		None = 0,
		// Token: 0x0401BF32 RID: 114482
		[Token(Token = "0x4018864")]
		IsConnected = 1,
		// Token: 0x0401BF33 RID: 114483
		[Token(Token = "0x4018865")]
		IsWired = 2,
		// Token: 0x0401BF34 RID: 114484
		[Token(Token = "0x4018866")]
		IsLeftConnected = 4,
		// Token: 0x0401BF35 RID: 114485
		[Token(Token = "0x4018867")]
		IsLeftWired = 8,
		// Token: 0x0401BF36 RID: 114486
		[Token(Token = "0x4018868")]
		IsRightConnected = 16,
		// Token: 0x0401BF37 RID: 114487
		[Token(Token = "0x4018869")]
		IsRightWired = 32
	}
}
