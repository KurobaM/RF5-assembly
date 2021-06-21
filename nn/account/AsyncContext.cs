using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace nn.account
{
	// Token: 0x020015EA RID: 5610
	[Token(Token = "0x2000F6F")]
	public sealed class AsyncContext : IDisposable
	{
		// Token: 0x06007FD9 RID: 32729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A2D")]
		[Address(RVA = "0x28503D0", Offset = "0x28504D1", VA = "0x28503D0")]
		public AsyncContext()
		{
		}

		// Token: 0x06007FDA RID: 32730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A2E")]
		[Address(RVA = "0x2850440", Offset = "0x2850541", VA = "0x2850440", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06007FDB RID: 32731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A2F")]
		[Address(RVA = "0x2850550", Offset = "0x2850651", VA = "0x2850550", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06007FDC RID: 32732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A30")]
		[Address(RVA = "0x28504F0", Offset = "0x28505F1", VA = "0x28504F0")]
		private void Dispose(bool disposing)
		{
		}

		// Token: 0x06007FDD RID: 32733 RVA: 0x0002DDB0 File Offset: 0x0002BFB0
		[Token(Token = "0x6006A31")]
		[Address(RVA = "0x2850610", Offset = "0x2850711", VA = "0x2850610")]
		public Result Cancel()
		{
			return default(Result);
		}

		// Token: 0x06007FDE RID: 32734 RVA: 0x0002DDC8 File Offset: 0x0002BFC8
		[Token(Token = "0x6006A32")]
		[Address(RVA = "0x2850650", Offset = "0x2850751", VA = "0x2850650")]
		public Result HasDone(ref bool pOut)
		{
			return default(Result);
		}

		// Token: 0x06007FDF RID: 32735 RVA: 0x0002DDE0 File Offset: 0x0002BFE0
		[Token(Token = "0x6006A33")]
		[Address(RVA = "0x2850690", Offset = "0x2850791", VA = "0x2850690")]
		public Result GetResult()
		{
			return default(Result);
		}

		// Token: 0x06007FE0 RID: 32736
		[Token(Token = "0x6006A34")]
		[Address(RVA = "0x2850430", Offset = "0x2850531", VA = "0x2850430")]
		[PreserveSig]
		private static extern IntPtr Create();

		// Token: 0x06007FE1 RID: 32737
		[Token(Token = "0x6006A35")]
		[Address(RVA = "0x2850600", Offset = "0x2850701", VA = "0x2850600")]
		[PreserveSig]
		private static extern void Destroy(IntPtr context);

		// Token: 0x06007FE2 RID: 32738
		[Token(Token = "0x6006A36")]
		[Address(RVA = "0x2850630", Offset = "0x2850731", VA = "0x2850630")]
		[PreserveSig]
		private static extern Result Cancel(IntPtr context);

		// Token: 0x06007FE3 RID: 32739
		[Token(Token = "0x6006A37")]
		[Address(RVA = "0x2850670", Offset = "0x2850771", VA = "0x2850670")]
		[PreserveSig]
		private static extern Result HasDone(IntPtr context, ref bool pOut);

		// Token: 0x06007FE4 RID: 32740
		[Token(Token = "0x6006A38")]
		[Address(RVA = "0x28506B0", Offset = "0x28507B1", VA = "0x28506B0")]
		[PreserveSig]
		private static extern Result GetResult(IntPtr context);

		// Token: 0x0401C169 RID: 115049
		[Token(Token = "0x40189A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal IntPtr _context;
	}
}
