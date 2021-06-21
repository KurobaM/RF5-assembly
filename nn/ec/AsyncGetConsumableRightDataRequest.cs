using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace nn.ec
{
	// Token: 0x020015D4 RID: 5588
	[Token(Token = "0x2000F5C")]
	public sealed class AsyncGetConsumableRightDataRequest : ConsumableServiceItemAsyncRequestBase
	{
		// Token: 0x06007F31 RID: 32561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006996")]
		[Address(RVA = "0x28529F0", Offset = "0x2852AF1", VA = "0x28529F0")]
		public AsyncGetConsumableRightDataRequest()
		{
		}

		// Token: 0x06007F32 RID: 32562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006997")]
		[Address(RVA = "0x2852A60", Offset = "0x2852B61", VA = "0x2852A60", Slot = "7")]
		protected override void Free(IntPtr asyncRequestPtr)
		{
		}

		// Token: 0x06007F33 RID: 32563 RVA: 0x0002D858 File Offset: 0x0002BA58
		[Token(Token = "0x6006998")]
		[Address(RVA = "0x2852A80", Offset = "0x2852B81", VA = "0x2852A80", Slot = "5")]
		public override Result Begin()
		{
			return default(Result);
		}

		// Token: 0x06007F34 RID: 32564 RVA: 0x0002D870 File Offset: 0x0002BA70
		[Token(Token = "0x6006999")]
		[Address(RVA = "0x2852AC0", Offset = "0x2852BC1", VA = "0x2852AC0", Slot = "6")]
		public override Result End()
		{
			return default(Result);
		}

		// Token: 0x06007F35 RID: 32565
		[Token(Token = "0x600699A")]
		[Address(RVA = "0x2852AA0", Offset = "0x2852BA1", VA = "0x2852AA0")]
		[PreserveSig]
		private static extern Result Begin(IntPtr asyncGetConsumableRightDataRequest);

		// Token: 0x06007F36 RID: 32566
		[Token(Token = "0x600699B")]
		[Address(RVA = "0x2852AE0", Offset = "0x2852BE1", VA = "0x2852AE0")]
		[PreserveSig]
		private static extern Result End(IntPtr asyncGetConsumableRightDataRequest);

		// Token: 0x06007F37 RID: 32567
		[Token(Token = "0x600699C")]
		[Address(RVA = "0x2852A50", Offset = "0x2852B51", VA = "0x2852A50")]
		[PreserveSig]
		private static extern void New(ref IntPtr asyncGetConsumableRightDataRequest);

		// Token: 0x06007F38 RID: 32568
		[Token(Token = "0x600699D")]
		[Address(RVA = "0x2852A70", Offset = "0x2852B71", VA = "0x2852A70")]
		[PreserveSig]
		private static extern void Delete(IntPtr asyncGetConsumableRightDataRequest);
	}
}
