using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace nn.ec
{
	// Token: 0x020015D6 RID: 5590
	[Token(Token = "0x2000F5E")]
	public sealed class AsyncRecoverRightDataRequest : ConsumableServiceItemAsyncRequestBase
	{
		// Token: 0x06007F41 RID: 32577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069A6")]
		[Address(RVA = "0x2852B00", Offset = "0x2852C01", VA = "0x2852B00")]
		public AsyncRecoverRightDataRequest()
		{
		}

		// Token: 0x06007F42 RID: 32578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069A7")]
		[Address(RVA = "0x2852B80", Offset = "0x2852C81", VA = "0x2852B80", Slot = "7")]
		protected override void Free(IntPtr asyncRequestPtr)
		{
		}

		// Token: 0x06007F43 RID: 32579 RVA: 0x0002D8B8 File Offset: 0x0002BAB8
		[Token(Token = "0x60069A8")]
		[Address(RVA = "0x2852BB0", Offset = "0x2852CB1", VA = "0x2852BB0", Slot = "5")]
		public override Result Begin()
		{
			return default(Result);
		}

		// Token: 0x06007F44 RID: 32580 RVA: 0x0002D8D0 File Offset: 0x0002BAD0
		[Token(Token = "0x60069A9")]
		[Address(RVA = "0x2852BF0", Offset = "0x2852CF1", VA = "0x2852BF0", Slot = "6")]
		public override Result End()
		{
			return default(Result);
		}

		// Token: 0x06007F45 RID: 32581
		[Token(Token = "0x60069AA")]
		[Address(RVA = "0x2852BD0", Offset = "0x2852CD1", VA = "0x2852BD0")]
		[PreserveSig]
		private static extern Result Begin(IntPtr asyncGetConsumableRightDataRequestBase);

		// Token: 0x06007F46 RID: 32582
		[Token(Token = "0x60069AB")]
		[Address(RVA = "0x2852C10", Offset = "0x2852D11", VA = "0x2852C10")]
		[PreserveSig]
		private static extern Result End(IntPtr asyncGetConsumableRightDataRequestBase);

		// Token: 0x06007F47 RID: 32583
		[Token(Token = "0x60069AC")]
		[Address(RVA = "0x2852B60", Offset = "0x2852C61", VA = "0x2852B60")]
		[PreserveSig]
		private static extern Result New(ref IntPtr asyncGetConsumableRightDataRequestBase);

		// Token: 0x06007F48 RID: 32584
		[Token(Token = "0x60069AD")]
		[Address(RVA = "0x2852B90", Offset = "0x2852C91", VA = "0x2852B90")]
		[PreserveSig]
		private static extern Result Delete(IntPtr asyncGetConsumableRightDataRequestBase);
	}
}
