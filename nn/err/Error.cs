using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace nn.err
{
	// Token: 0x020015D0 RID: 5584
	[Token(Token = "0x2000F58")]
	public static class Error
	{
		// Token: 0x06007EEF RID: 32495
		[Token(Token = "0x6006954")]
		[Address(RVA = "0x2855140", Offset = "0x2855241", VA = "0x2855140")]
		[PreserveSig]
		public static extern void Show(Result result);

		// Token: 0x06007EF0 RID: 32496
		[Token(Token = "0x6006955")]
		[Address(RVA = "0x2855150", Offset = "0x2855251", VA = "0x2855150")]
		[PreserveSig]
		public static extern void Show(ErrorCode errorCode);

		// Token: 0x06007EF1 RID: 32497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006956")]
		[Address(RVA = "0x2855160", Offset = "0x2855261", VA = "0x2855160")]
		public static void Show(Result result, bool suspendUnityThreads)
		{
		}

		// Token: 0x06007EF2 RID: 32498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006957")]
		[Address(RVA = "0x28551B0", Offset = "0x28552B1", VA = "0x28551B0")]
		public static void Show(ErrorCode errorCode, bool suspendUnityThreads)
		{
		}

		// Token: 0x06007EF3 RID: 32499
		[Token(Token = "0x6006958")]
		[Address(RVA = "0x2855200", Offset = "0x2855301", VA = "0x2855200")]
		[PreserveSig]
		public static extern void ShowUnacceptableAddOnContentVersion();

		// Token: 0x06007EF4 RID: 32500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006959")]
		[Address(RVA = "0x2855210", Offset = "0x2855311", VA = "0x2855210")]
		public static void ShowUnacceptableAddOnContentVersion(bool suspendUnityThreads)
		{
		}

		// Token: 0x06007EF5 RID: 32501
		[Token(Token = "0x600695A")]
		[Address(RVA = "0x2855240", Offset = "0x2855341", VA = "0x2855240")]
		[PreserveSig]
		public static extern void ShowUnacceptableApplicationVersion();

		// Token: 0x06007EF6 RID: 32502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600695B")]
		[Address(RVA = "0x2855250", Offset = "0x2855351", VA = "0x2855250")]
		public static void ShowUnacceptableApplicationVersion(bool suspendUnityThreads)
		{
		}
	}
}
