using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace nn.hid
{
	// Token: 0x02001541 RID: 5441
	[Token(Token = "0x2000EF0")]
	public static class ControllerStrapGuide
	{
		// Token: 0x06007B99 RID: 31641
		[Token(Token = "0x600678B")]
		[Address(RVA = "0x2859E30", Offset = "0x2859F31", VA = "0x2859E30")]
		[PreserveSig]
		public static extern Result Show();

		// Token: 0x06007B9A RID: 31642 RVA: 0x0002BAD0 File Offset: 0x00029CD0
		[Token(Token = "0x600678C")]
		[Address(RVA = "0x2859E50", Offset = "0x2859F51", VA = "0x2859E50")]
		public static Result Show(bool suspendUnityThreads)
		{
			return default(Result);
		}
	}
}
