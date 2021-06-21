using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace nn.friends
{
	// Token: 0x020015BF RID: 5567
	[Token(Token = "0x2000F48")]
	public sealed class AsyncContext : IDisposable
	{
		// Token: 0x06007E75 RID: 32373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068DA")]
		[Address(RVA = "0x2855400", Offset = "0x2855501", VA = "0x2855400")]
		public AsyncContext()
		{
		}

		// Token: 0x06007E76 RID: 32374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068DB")]
		[Address(RVA = "0x2855470", Offset = "0x2855571", VA = "0x2855470", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06007E77 RID: 32375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068DC")]
		[Address(RVA = "0x2855580", Offset = "0x2855681", VA = "0x2855580", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06007E78 RID: 32376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068DD")]
		[Address(RVA = "0x2855520", Offset = "0x2855621", VA = "0x2855520")]
		private void Dispose(bool disposing)
		{
		}

		// Token: 0x06007E79 RID: 32377 RVA: 0x0002D408 File Offset: 0x0002B608
		[Token(Token = "0x60068DE")]
		[Address(RVA = "0x2855640", Offset = "0x2855741", VA = "0x2855640")]
		public Result Cancel()
		{
			return default(Result);
		}

		// Token: 0x06007E7A RID: 32378 RVA: 0x0002D420 File Offset: 0x0002B620
		[Token(Token = "0x60068DF")]
		[Address(RVA = "0x2855680", Offset = "0x2855781", VA = "0x2855680")]
		public Result HasDone(ref bool outDone)
		{
			return default(Result);
		}

		// Token: 0x06007E7B RID: 32379 RVA: 0x0002D438 File Offset: 0x0002B638
		[Token(Token = "0x60068E0")]
		[Address(RVA = "0x28556C0", Offset = "0x28557C1", VA = "0x28556C0")]
		public Result GetResult()
		{
			return default(Result);
		}

		// Token: 0x06007E7C RID: 32380
		[Token(Token = "0x60068E1")]
		[Address(RVA = "0x2855460", Offset = "0x2855561", VA = "0x2855460")]
		[PreserveSig]
		private static extern IntPtr Create();

		// Token: 0x06007E7D RID: 32381
		[Token(Token = "0x60068E2")]
		[Address(RVA = "0x2855630", Offset = "0x2855731", VA = "0x2855630")]
		[PreserveSig]
		private static extern void Destroy(IntPtr context);

		// Token: 0x06007E7E RID: 32382
		[Token(Token = "0x60068E3")]
		[Address(RVA = "0x2855660", Offset = "0x2855761", VA = "0x2855660")]
		[PreserveSig]
		private static extern Result Cancel(IntPtr context);

		// Token: 0x06007E7F RID: 32383
		[Token(Token = "0x60068E4")]
		[Address(RVA = "0x28556A0", Offset = "0x28557A1", VA = "0x28556A0")]
		[PreserveSig]
		private static extern Result HasDone(IntPtr context, ref bool outDone);

		// Token: 0x06007E80 RID: 32384
		[Token(Token = "0x60068E5")]
		[Address(RVA = "0x28556E0", Offset = "0x28557E1", VA = "0x28556E0")]
		[PreserveSig]
		private static extern Result GetResult(IntPtr context);

		// Token: 0x0401C103 RID: 114947
		[Token(Token = "0x401895C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal IntPtr _context;
	}
}
