using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace nn.ec
{
	// Token: 0x020015D5 RID: 5589
	[Token(Token = "0x2000F5D")]
	public sealed class AsyncConsumeRightDataRequest : ConsumableServiceItemAsyncRequestBase
	{
		// Token: 0x06007F39 RID: 32569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600699E")]
		[Address(RVA = "0x2852890", Offset = "0x2852991", VA = "0x2852890")]
		public AsyncConsumeRightDataRequest()
		{
		}

		// Token: 0x06007F3A RID: 32570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600699F")]
		[Address(RVA = "0x2852950", Offset = "0x2852A51", VA = "0x2852950", Slot = "7")]
		protected override void Free(IntPtr asyncRequestPtr)
		{
		}

		// Token: 0x06007F3B RID: 32571 RVA: 0x0002D888 File Offset: 0x0002BA88
		[Token(Token = "0x60069A0")]
		[Address(RVA = "0x2852970", Offset = "0x2852A71", VA = "0x2852970", Slot = "5")]
		public override Result Begin()
		{
			return default(Result);
		}

		// Token: 0x06007F3C RID: 32572 RVA: 0x0002D8A0 File Offset: 0x0002BAA0
		[Token(Token = "0x60069A1")]
		[Address(RVA = "0x28529B0", Offset = "0x2852AB1", VA = "0x28529B0", Slot = "6")]
		public override Result End()
		{
			return default(Result);
		}

		// Token: 0x06007F3D RID: 32573
		[Token(Token = "0x60069A2")]
		[Address(RVA = "0x2852990", Offset = "0x2852A91", VA = "0x2852990")]
		[PreserveSig]
		private static extern Result Begin(IntPtr asyncConsumeRightDataRequest);

		// Token: 0x06007F3E RID: 32574
		[Token(Token = "0x60069A3")]
		[Address(RVA = "0x28529D0", Offset = "0x2852AD1", VA = "0x28529D0")]
		[PreserveSig]
		private static extern Result End(IntPtr asyncConsumeRightDataRequest);

		// Token: 0x06007F3F RID: 32575
		[Token(Token = "0x60069A4")]
		[Address(RVA = "0x2852940", Offset = "0x2852A41", VA = "0x2852940")]
		[PreserveSig]
		private static extern void New(ref IntPtr asyncConsumeRightDataRequest);

		// Token: 0x06007F40 RID: 32576
		[Token(Token = "0x60069A5")]
		[Address(RVA = "0x2852960", Offset = "0x2852A61", VA = "0x2852960")]
		[PreserveSig]
		private static extern void Delete(IntPtr asyncConsumeRightDataRequest);
	}
}
