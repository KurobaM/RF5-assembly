using System;
using Il2CppDummyDll;

namespace nn.hid
{
	// Token: 0x0200154F RID: 5455
	[Token(Token = "0x2000EFC")]
	[Flags]
	public enum NpadStyle
	{
		// Token: 0x0401BF00 RID: 114432
		[Token(Token = "0x4018832")]
		None = 0,
		// Token: 0x0401BF01 RID: 114433
		[Token(Token = "0x4018833")]
		FullKey = 1,
		// Token: 0x0401BF02 RID: 114434
		[Token(Token = "0x4018834")]
		Handheld = 2,
		// Token: 0x0401BF03 RID: 114435
		[Token(Token = "0x4018835")]
		JoyDual = 4,
		// Token: 0x0401BF04 RID: 114436
		[Token(Token = "0x4018836")]
		JoyLeft = 8,
		// Token: 0x0401BF05 RID: 114437
		[Token(Token = "0x4018837")]
		JoyRight = 16,
		// Token: 0x0401BF06 RID: 114438
		[Token(Token = "0x4018838")]
		Invalid = 32
	}
}
