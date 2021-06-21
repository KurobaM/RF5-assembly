using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using nn.err;

namespace nn.ec
{
	// Token: 0x020015D3 RID: 5587
	[Token(Token = "0x2000F5B")]
	public abstract class ConsumableServiceItemAsyncRequestBase : IDisposable
	{
		// Token: 0x06007F21 RID: 32545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006986")]
		[Address(RVA = "0x28528F0", Offset = "0x28529F1", VA = "0x28528F0")]
		public ConsumableServiceItemAsyncRequestBase()
		{
		}

		// Token: 0x17000F61 RID: 3937
		// (get) Token: 0x06007F22 RID: 32546 RVA: 0x0002D810 File Offset: 0x0002BA10
		[Token(Token = "0x17000B9B")]
		internal IntPtr Ptr
		{
			[Token(Token = "0x6006987")]
			[Address(RVA = "0x2852CC0", Offset = "0x2852DC1", VA = "0x2852CC0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06007F23 RID: 32547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006988")]
		[Address(RVA = "0x2852CD0", Offset = "0x2852DD1", VA = "0x2852CD0", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06007F24 RID: 32548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006989")]
		[Address(RVA = "0x2852DA0", Offset = "0x2852EA1", VA = "0x2852DA0")]
		public void Cancel()
		{
		}

		// Token: 0x06007F25 RID: 32549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600698A")]
		[Address(RVA = "0x2852E20", Offset = "0x2852F21", VA = "0x2852E20")]
		public void Wait()
		{
		}

		// Token: 0x06007F26 RID: 32550 RVA: 0x0002D828 File Offset: 0x0002BA28
		[Token(Token = "0x600698B")]
		[Address(RVA = "0x2852EA0", Offset = "0x2852FA1", VA = "0x2852EA0")]
		public bool TryWait()
		{
			return default(bool);
		}

		// Token: 0x06007F27 RID: 32551 RVA: 0x0002D840 File Offset: 0x0002BA40
		[Token(Token = "0x600698C")]
		[Address(RVA = "0x2852F40", Offset = "0x2853041", VA = "0x2852F40")]
		public ErrorCode GetErrorCode()
		{
			return default(ErrorCode);
		}

		// Token: 0x06007F28 RID: 32552
		[Token(Token = "0x600698D")]
		public abstract Result Begin();

		// Token: 0x06007F29 RID: 32553
		[Token(Token = "0x600698E")]
		public abstract Result End();

		// Token: 0x06007F2A RID: 32554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600698F")]
		[Address(RVA = "0x2852FD0", Offset = "0x28530D1", VA = "0x2852FD0", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06007F2B RID: 32555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006990")]
		[Address(RVA = "0x2852D60", Offset = "0x2852E61", VA = "0x2852D60")]
		private void _Dispose()
		{
		}

		// Token: 0x06007F2C RID: 32556
		[Token(Token = "0x6006991")]
		protected abstract void Free(IntPtr asyncRequestPtr);

		// Token: 0x06007F2D RID: 32557
		[Token(Token = "0x6006992")]
		[Address(RVA = "0x2852E10", Offset = "0x2852F11", VA = "0x2852E10")]
		[PreserveSig]
		private static extern void Cancel(IntPtr consumableServiceItemAsyncRequestBase);

		// Token: 0x06007F2E RID: 32558
		[Token(Token = "0x6006993")]
		[Address(RVA = "0x2852E90", Offset = "0x2852F91", VA = "0x2852E90")]
		[PreserveSig]
		private static extern void Wait(IntPtr consumableServiceItemAsyncRequestBase);

		// Token: 0x06007F2F RID: 32559
		[Token(Token = "0x6006994")]
		[Address(RVA = "0x2852F20", Offset = "0x2853021", VA = "0x2852F20")]
		[PreserveSig]
		private static extern bool TryWait(IntPtr consumableServiceItemAsyncRequestBase);

		// Token: 0x06007F30 RID: 32560
		[Token(Token = "0x6006995")]
		[Address(RVA = "0x2852FC0", Offset = "0x28530C1", VA = "0x2852FC0")]
		[PreserveSig]
		private static extern ErrorCode GetErrorCode(IntPtr consumableServiceItemAsyncRequestBase);

		// Token: 0x0401C13E RID: 115006
		[Token(Token = "0x4018985")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected IntPtr _consumableServiceItemAsyncRequestBase;

		// Token: 0x0401C13F RID: 115007
		[Token(Token = "0x4018986")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected bool isDisposed;
	}
}
