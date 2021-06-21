using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace nn.hid
{
	// Token: 0x02001542 RID: 5442
	[Token(Token = "0x2000EF1")]
	public static class ControllerFirmwareUpdate
	{
		// Token: 0x06007B9B RID: 31643
		[Token(Token = "0x600678D")]
		[Address(RVA = "0x2859D80", Offset = "0x2859E81", VA = "0x2859D80")]
		[PreserveSig]
		public static extern Result Show(ControllerFirmwareUpdateArg showControllerFirmwareUpdateArg);

		// Token: 0x06007B9C RID: 31644 RVA: 0x0002BAE8 File Offset: 0x00029CE8
		[Token(Token = "0x600678E")]
		[Address(RVA = "0x2859DA0", Offset = "0x2859EA1", VA = "0x2859DA0")]
		public static Result Show(ControllerFirmwareUpdateArg showControllerFirmwareUpdateArg, bool suspendUnityThreads)
		{
			return default(Result);
		}

		// Token: 0x17000EA6 RID: 3750
		// (get) Token: 0x06007B9D RID: 31645 RVA: 0x0002BB00 File Offset: 0x00029D00
		[Token(Token = "0x17000B4C")]
		public static ErrorRange ResultControllerFirmwareUpdateError
		{
			[Token(Token = "0x600678F")]
			[Address(RVA = "0x2859E00", Offset = "0x2859F01", VA = "0x2859E00")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000EA7 RID: 3751
		// (get) Token: 0x06007B9E RID: 31646 RVA: 0x0002BB18 File Offset: 0x00029D18
		[Token(Token = "0x17000B4D")]
		public static ErrorRange ResultControllerFirmwareUpdateFailed
		{
			[Token(Token = "0x6006790")]
			[Address(RVA = "0x2859E10", Offset = "0x2859F11", VA = "0x2859E10")]
			get
			{
				return default(ErrorRange);
			}
		}
	}
}
