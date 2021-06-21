using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace nn.oe
{
	// Token: 0x020014FF RID: 5375
	[Token(Token = "0x2000EBF")]
	public static class CrashReport
	{
		// Token: 0x06007A48 RID: 31304
		[Token(Token = "0x60066D4")]
		[Address(RVA = "0x34E1600", Offset = "0x34E1701", VA = "0x34E1600")]
		[PreserveSig]
		public static extern void Enable();

		// Token: 0x06007A49 RID: 31305
		[Token(Token = "0x60066D5")]
		[Address(RVA = "0x34E1610", Offset = "0x34E1711", VA = "0x34E1610")]
		[PreserveSig]
		public static extern void Disable();
	}
}
