using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace nn.account
{
	// Token: 0x020015E9 RID: 5609
	[Token(Token = "0x2000F6E")]
	public static class NetworkServiceAccount
	{
		// Token: 0x06007FCE RID: 32718
		[Token(Token = "0x6006A22")]
		[Address(RVA = "0x28506D0", Offset = "0x28507D1", VA = "0x28506D0")]
		[PreserveSig]
		public static extern Result EnsureAvailable(UserHandle handle);

		// Token: 0x06007FCF RID: 32719
		[Token(Token = "0x6006A23")]
		[Address(RVA = "0x2850710", Offset = "0x2850811", VA = "0x2850710")]
		[PreserveSig]
		public static extern Result IsAvailable(ref bool pOut, UserHandle handle);

		// Token: 0x06007FD0 RID: 32720
		[Token(Token = "0x6006A24")]
		[Address(RVA = "0x2850750", Offset = "0x2850851", VA = "0x2850750")]
		[PreserveSig]
		public static extern Result GetId(ref NetworkServiceAccountId pOutId, UserHandle handle);

		// Token: 0x06007FD1 RID: 32721 RVA: 0x0002DD20 File Offset: 0x0002BF20
		[Token(Token = "0x6006A25")]
		[Address(RVA = "0x2850790", Offset = "0x2850891", VA = "0x2850790")]
		public static Result EnsurIdTokenCacheAsync(AsyncContext pOutContext, UserHandle handle)
		{
			return default(Result);
		}

		// Token: 0x06007FD2 RID: 32722
		[Token(Token = "0x6006A26")]
		[Address(RVA = "0x28507D0", Offset = "0x28508D1", VA = "0x28507D0")]
		[PreserveSig]
		public static extern Result EnsurIdTokenCacheAsync(IntPtr pOutContext, UserHandle handle);

		// Token: 0x06007FD3 RID: 32723 RVA: 0x0002DD38 File Offset: 0x0002BF38
		[Token(Token = "0x6006A27")]
		[Address(RVA = "0x2850810", Offset = "0x2850911", VA = "0x2850810")]
		public static Result LoadIdTokenCache(ref ulong pOutActualSize, byte[] buffer, UserHandle handle)
		{
			return default(Result);
		}

		// Token: 0x06007FD4 RID: 32724
		[Token(Token = "0x6006A28")]
		[Address(RVA = "0x2850870", Offset = "0x2850971", VA = "0x2850870")]
		[PreserveSig]
		private static extern Result LoadIdTokenCache(ref ulong pOutActualSize, byte[] buffer, int bufferSize, UserHandle handle);

		// Token: 0x17000F78 RID: 3960
		// (get) Token: 0x06007FD5 RID: 32725 RVA: 0x0002DD50 File Offset: 0x0002BF50
		[Token(Token = "0x17000BB2")]
		public static ErrorRange ResultNetworkServiceAccountUnavailable
		{
			[Token(Token = "0x6006A29")]
			[Address(RVA = "0x28508B0", Offset = "0x28509B1", VA = "0x28508B0")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F79 RID: 3961
		// (get) Token: 0x06007FD6 RID: 32726 RVA: 0x0002DD68 File Offset: 0x0002BF68
		[Token(Token = "0x17000BB3")]
		public static ErrorRange ResultTokenCacheUnavailable
		{
			[Token(Token = "0x6006A2A")]
			[Address(RVA = "0x28508C0", Offset = "0x28509C1", VA = "0x28508C0")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F7A RID: 3962
		// (get) Token: 0x06007FD7 RID: 32727 RVA: 0x0002DD80 File Offset: 0x0002BF80
		[Token(Token = "0x17000BB4")]
		public static ErrorRange ResultNetworkCommunicationError
		{
			[Token(Token = "0x6006A2B")]
			[Address(RVA = "0x28508D0", Offset = "0x28509D1", VA = "0x28508D0")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F7B RID: 3963
		// (get) Token: 0x06007FD8 RID: 32728 RVA: 0x0002DD98 File Offset: 0x0002BF98
		[Token(Token = "0x17000BB5")]
		public static ErrorRange ResultSslService
		{
			[Token(Token = "0x6006A2C")]
			[Address(RVA = "0x28508E0", Offset = "0x28509E1", VA = "0x28508E0")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x0401C168 RID: 115048
		[Token(Token = "0x40189A5")]
		public const int IdTokenLengthMax = 3072;
	}
}
