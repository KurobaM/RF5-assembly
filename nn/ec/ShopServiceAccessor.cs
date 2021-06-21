using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using nn.account;
using nn.err;

namespace nn.ec
{
	// Token: 0x020015DC RID: 5596
	[Token(Token = "0x2000F63")]
	public sealed class ShopServiceAccessor : IDisposable
	{
		// Token: 0x17000F69 RID: 3945
		// (get) Token: 0x06007F58 RID: 32600 RVA: 0x0002D9C0 File Offset: 0x0002BBC0
		[Token(Token = "0x17000BA3")]
		public static ErrorRange ResultShopServiceAccessError
		{
			[Token(Token = "0x60069BD")]
			[Address(RVA = "0x2854440", Offset = "0x2854541", VA = "0x2854440")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F6A RID: 3946
		// (get) Token: 0x06007F59 RID: 32601 RVA: 0x0002D9D8 File Offset: 0x0002BBD8
		[Token(Token = "0x17000BA4")]
		public static ErrorRange ResultShopServiceAccessCanceled
		{
			[Token(Token = "0x60069BE")]
			[Address(RVA = "0x2854450", Offset = "0x2854551", VA = "0x2854450")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F6B RID: 3947
		// (get) Token: 0x06007F5A RID: 32602 RVA: 0x0002D9F0 File Offset: 0x0002BBF0
		[Token(Token = "0x17000BA5")]
		public static ErrorRange ResultShopServiceAccessInsufficientBuffer
		{
			[Token(Token = "0x60069BF")]
			[Address(RVA = "0x2854460", Offset = "0x2854561", VA = "0x2854460")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F6C RID: 3948
		// (get) Token: 0x06007F5B RID: 32603 RVA: 0x0002DA08 File Offset: 0x0002BC08
		[Token(Token = "0x17000BA6")]
		public static ErrorRange ResultShopServiceAccessInsufficientWorkMemory
		{
			[Token(Token = "0x60069C0")]
			[Address(RVA = "0x2854470", Offset = "0x2854571", VA = "0x2854470")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F6D RID: 3949
		// (get) Token: 0x06007F5C RID: 32604 RVA: 0x0002DA20 File Offset: 0x0002BC20
		[Token(Token = "0x17000BA7")]
		public static ErrorRange ResultShopServiceAccessInvalidCharacter
		{
			[Token(Token = "0x60069C1")]
			[Address(RVA = "0x2854480", Offset = "0x2854581", VA = "0x2854480")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F6E RID: 3950
		// (get) Token: 0x06007F5D RID: 32605 RVA: 0x0002DA38 File Offset: 0x0002BC38
		[Token(Token = "0x17000BA8")]
		public static ErrorRange ResultShopServiceAccessOverRequest
		{
			[Token(Token = "0x60069C2")]
			[Address(RVA = "0x2854490", Offset = "0x2854591", VA = "0x2854490")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F6F RID: 3951
		// (get) Token: 0x06007F5E RID: 32606 RVA: 0x0002DA50 File Offset: 0x0002BC50
		[Token(Token = "0x17000BA9")]
		public static ErrorRange ResultShopServiceAccessRequestTimeout
		{
			[Token(Token = "0x60069C3")]
			[Address(RVA = "0x28544A0", Offset = "0x28545A1", VA = "0x28544A0")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F70 RID: 3952
		// (get) Token: 0x06007F5F RID: 32607 RVA: 0x0002DA68 File Offset: 0x0002BC68
		[Token(Token = "0x17000BAA")]
		public static ErrorRange ResultShowErrorCodeRequired
		{
			[Token(Token = "0x60069C4")]
			[Address(RVA = "0x28544B0", Offset = "0x28545B1", VA = "0x28544B0")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F71 RID: 3953
		// (get) Token: 0x06007F60 RID: 32608 RVA: 0x0002DA80 File Offset: 0x0002BC80
		[Token(Token = "0x17000BAB")]
		public static ErrorRange ResultInternetRequestNotAccepted
		{
			[Token(Token = "0x60069C5")]
			[Address(RVA = "0x28544C0", Offset = "0x28545C1", VA = "0x28544C0")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F72 RID: 3954
		// (get) Token: 0x06007F61 RID: 32609 RVA: 0x0002DA98 File Offset: 0x0002BC98
		[Token(Token = "0x17000BAC")]
		public static ErrorRange ResultInsufficientWorkMemory
		{
			[Token(Token = "0x60069C6")]
			[Address(RVA = "0x28544D0", Offset = "0x28545D1", VA = "0x28544D0")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F73 RID: 3955
		// (get) Token: 0x06007F62 RID: 32610 RVA: 0x0002DAB0 File Offset: 0x0002BCB0
		[Token(Token = "0x17000BAD")]
		internal IntPtr Ptr
		{
			[Token(Token = "0x60069C7")]
			[Address(RVA = "0x28544E0", Offset = "0x28545E1", VA = "0x28544E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000F74 RID: 3956
		// (get) Token: 0x06007F63 RID: 32611 RVA: 0x0002DAC8 File Offset: 0x0002BCC8
		[Token(Token = "0x17000BAE")]
		public static TimeSpan DefaultTimeout
		{
			[Token(Token = "0x60069C8")]
			[Address(RVA = "0x28544F0", Offset = "0x28545F1", VA = "0x28544F0")]
			get
			{
				return default(TimeSpan);
			}
		}

		// Token: 0x06007F64 RID: 32612
		[Token(Token = "0x60069C9")]
		[Address(RVA = "0x2854530", Offset = "0x2854631", VA = "0x2854530")]
		[PreserveSig]
		public static extern Result InitializeForShopServiceAccessors();

		// Token: 0x06007F65 RID: 32613
		[Token(Token = "0x60069CA")]
		[Address(RVA = "0x2854550", Offset = "0x2854651", VA = "0x2854550")]
		[PreserveSig]
		public static extern Result FinalizeForShopServiceAccessors();

		// Token: 0x06007F66 RID: 32614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069CB")]
		[Address(RVA = "0x2854570", Offset = "0x2854671", VA = "0x2854570")]
		public ShopServiceAccessor()
		{
		}

		// Token: 0x06007F67 RID: 32615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069CC")]
		[Address(RVA = "0x28545E0", Offset = "0x28546E1", VA = "0x28545E0", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06007F68 RID: 32616 RVA: 0x0002DAE0 File Offset: 0x0002BCE0
		[Token(Token = "0x60069CD")]
		[Address(RVA = "0x2854730", Offset = "0x2854831", VA = "0x2854730")]
		public Result Initialize(ShopService targetType)
		{
			return default(Result);
		}

		// Token: 0x06007F69 RID: 32617 RVA: 0x0002DAF8 File Offset: 0x0002BCF8
		[Token(Token = "0x60069CE")]
		[Address(RVA = "0x2854770", Offset = "0x2854871", VA = "0x2854770")]
		public Result Request(ShopServiceAccessor.AsyncResponse outAsyncResponse, Uid userId, ShopServiceMethod method, string requestPath, string postData, TimeSpan timeout)
		{
			return default(Result);
		}

		// Token: 0x06007F6A RID: 32618 RVA: 0x0002DB10 File Offset: 0x0002BD10
		[Token(Token = "0x60069CF")]
		[Address(RVA = "0x28548E0", Offset = "0x28549E1", VA = "0x28548E0")]
		public Result Request(ShopServiceAccessor.AsyncResponse outAsyncResponse, Uid userId, ShopServiceMethod method, string requestPath, TimeSpan timeout)
		{
			return default(Result);
		}

		// Token: 0x06007F6B RID: 32619 RVA: 0x0002DB28 File Offset: 0x0002BD28
		[Token(Token = "0x60069D0")]
		[Address(RVA = "0x2854A10", Offset = "0x2854B11", VA = "0x2854A10")]
		public Result Request(ShopServiceAccessor.AsyncResponse outAsyncResponse, Uid userId, ShopServiceMethod method, string requestPath, string postData)
		{
			return default(Result);
		}

		// Token: 0x06007F6C RID: 32620 RVA: 0x0002DB40 File Offset: 0x0002BD40
		[Token(Token = "0x60069D1")]
		[Address(RVA = "0x2854AC0", Offset = "0x2854BC1", VA = "0x2854AC0")]
		public Result Request(ShopServiceAccessor.AsyncResponse outAsyncResponse, Uid userId, ShopServiceMethod method, string requestPath)
		{
			return default(Result);
		}

		// Token: 0x06007F6D RID: 32621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069D2")]
		[Address(RVA = "0x2854BC0", Offset = "0x2854CC1", VA = "0x2854BC0", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06007F6E RID: 32622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069D3")]
		[Address(RVA = "0x28546A0", Offset = "0x28547A1", VA = "0x28546A0")]
		private void _Dispose()
		{
		}

		// Token: 0x06007F6F RID: 32623
		[Token(Token = "0x60069D4")]
		[Address(RVA = "0x2854750", Offset = "0x2854851", VA = "0x2854750")]
		[PreserveSig]
		private static extern Result Initialize(IntPtr shopServiceAccessor, ShopService target);

		// Token: 0x06007F70 RID: 32624
		[Token(Token = "0x60069D5")]
		[Address(RVA = "0x2854CA0", Offset = "0x2854DA1", VA = "0x2854CA0")]
		[PreserveSig]
		private static extern Result Finalize(IntPtr shopServiceAccessor);

		// Token: 0x06007F71 RID: 32625
		[Token(Token = "0x60069D6")]
		[Address(RVA = "0x2854840", Offset = "0x2854941", VA = "0x2854840")]
		[PreserveSig]
		private static extern Result Request(IntPtr shopServiceAccessor, ref IntPtr outAsyncResponse, Uid userId, ShopServiceMethod method, string requestPath, string postData, long timeoutMilliseconds);

		// Token: 0x06007F72 RID: 32626
		[Token(Token = "0x60069D7")]
		[Address(RVA = "0x2854980", Offset = "0x2854A81", VA = "0x2854980")]
		[PreserveSig]
		private static extern Result Request(IntPtr shopServiceAccessor, ref IntPtr outAsyncResponse, Uid userId, ShopServiceMethod method, string requestPath, long timeoutMilliseconds);

		// Token: 0x06007F73 RID: 32627
		[Token(Token = "0x60069D8")]
		[Address(RVA = "0x2854CD0", Offset = "0x2854DD1", VA = "0x2854CD0")]
		[PreserveSig]
		private static extern Result Request(IntPtr shopServiceAccessor, ref IntPtr outAsyncResponse, Uid userId, ShopServiceMethod method, string requestPath, string postData);

		// Token: 0x06007F74 RID: 32628
		[Token(Token = "0x60069D9")]
		[Address(RVA = "0x2854B40", Offset = "0x2854C41", VA = "0x2854B40")]
		[PreserveSig]
		private static extern Result Request(IntPtr shopServiceAccessor, ref IntPtr outAsyncResponse, Uid userId, ShopServiceMethod method, string requestPath);

		// Token: 0x06007F75 RID: 32629
		[Token(Token = "0x60069DA")]
		[Address(RVA = "0x28545D0", Offset = "0x28546D1", VA = "0x28545D0")]
		[PreserveSig]
		private static extern void New(ref IntPtr shopServiceAccessor);

		// Token: 0x06007F76 RID: 32630
		[Token(Token = "0x60069DB")]
		[Address(RVA = "0x2854CC0", Offset = "0x2854DC1", VA = "0x2854CC0")]
		[PreserveSig]
		private static extern void Delete(IntPtr shopServiceAccessor);

		// Token: 0x0401C14A RID: 115018
		[Token(Token = "0x401898E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr _shopServiceAccessor;

		// Token: 0x0401C14B RID: 115019
		[Token(Token = "0x401898F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool isDisposed;

		// Token: 0x020015DD RID: 5597
		[Token(Token = "0x20015CB")]
		public sealed class AsyncResponse : IDisposable
		{
			// Token: 0x06007F77 RID: 32631 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007FAE")]
			[Address(RVA = "0x2854D70", Offset = "0x2854E71", VA = "0x2854D70")]
			public AsyncResponse()
			{
			}

			// Token: 0x06007F78 RID: 32632 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007FAF")]
			[Address(RVA = "0x2854DE0", Offset = "0x2854EE1", VA = "0x2854DE0")]
			public AsyncResponse(IntPtr asyncResponsePtr)
			{
			}

			// Token: 0x06007F79 RID: 32633 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007FB0")]
			[Address(RVA = "0x2854E40", Offset = "0x2854F41", VA = "0x2854E40", Slot = "1")]
			protected override void Finalize()
			{
			}

			// Token: 0x06007F7A RID: 32634 RVA: 0x0002DB58 File Offset: 0x0002BD58
			[Token(Token = "0x6007FB1")]
			[Address(RVA = "0x2854F60", Offset = "0x2855061", VA = "0x2854F60")]
			public Result Get(ref string outJson)
			{
				return default(Result);
			}

			// Token: 0x06007F7B RID: 32635 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007FB2")]
			[Address(RVA = "0x2855090", Offset = "0x2855191", VA = "0x2855090")]
			public void Wait()
			{
			}

			// Token: 0x06007F7C RID: 32636 RVA: 0x0002DB70 File Offset: 0x0002BD70
			[Token(Token = "0x6007FB3")]
			[Address(RVA = "0x28550B0", Offset = "0x28551B1", VA = "0x28550B0")]
			public bool TryWait()
			{
				return default(bool);
			}

			// Token: 0x06007F7D RID: 32637 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007FB4")]
			[Address(RVA = "0x28550F0", Offset = "0x28551F1", VA = "0x28550F0")]
			public void Cancel()
			{
			}

			// Token: 0x06007F7E RID: 32638 RVA: 0x0002DB88 File Offset: 0x0002BD88
			[Token(Token = "0x6007FB5")]
			[Address(RVA = "0x2855110", Offset = "0x2855211", VA = "0x2855110")]
			public ErrorCode GetErrorCode()
			{
				return default(ErrorCode);
			}

			// Token: 0x06007F7F RID: 32639 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007FB6")]
			[Address(RVA = "0x2854EB0", Offset = "0x2854FB1", VA = "0x2854EB0", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x06007F80 RID: 32640
			[Token(Token = "0x6007FB7")]
			[Address(RVA = "0x2855040", Offset = "0x2855141", VA = "0x2855040")]
			[PreserveSig]
			private static extern Result GetSize(IntPtr asyncResponse, ref long outSize);

			// Token: 0x06007F81 RID: 32641
			[Token(Token = "0x6007FB8")]
			[Address(RVA = "0x2855060", Offset = "0x2855161", VA = "0x2855060")]
			[PreserveSig]
			private static extern Result Get(IntPtr asyncResponse, byte[] outReceivedData, long bufferCapacity);

			// Token: 0x06007F82 RID: 32642
			[Token(Token = "0x6007FB9")]
			[Address(RVA = "0x28550A0", Offset = "0x28551A1", VA = "0x28550A0")]
			[PreserveSig]
			private static extern void Wait(IntPtr asyncResponce);

			// Token: 0x06007F83 RID: 32643
			[Token(Token = "0x6007FBA")]
			[Address(RVA = "0x28550D0", Offset = "0x28551D1", VA = "0x28550D0")]
			[PreserveSig]
			private static extern bool TryWait(IntPtr asyncResponce);

			// Token: 0x06007F84 RID: 32644
			[Token(Token = "0x6007FBB")]
			[Address(RVA = "0x2855100", Offset = "0x2855201", VA = "0x2855100")]
			[PreserveSig]
			private static extern void Cancel(IntPtr asyncResponce);

			// Token: 0x06007F85 RID: 32645
			[Token(Token = "0x6007FBC")]
			[Address(RVA = "0x2855120", Offset = "0x2855221", VA = "0x2855120")]
			[PreserveSig]
			private static extern ErrorCode GetErrorCode(IntPtr asyncResponce);

			// Token: 0x06007F86 RID: 32646
			[Token(Token = "0x6007FBD")]
			[Address(RVA = "0x2854DD0", Offset = "0x2854ED1", VA = "0x2854DD0")]
			[PreserveSig]
			private static extern void New(ref IntPtr asyncResponce);

			// Token: 0x06007F87 RID: 32647
			[Token(Token = "0x6007FBE")]
			[Address(RVA = "0x2855130", Offset = "0x2855231", VA = "0x2855130")]
			[PreserveSig]
			private static extern void Delete(IntPtr asyncResponce);

			// Token: 0x0401C14C RID: 115020
			[Token(Token = "0x401C37A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal IntPtr _asyncResponse;

			// Token: 0x0401C14D RID: 115021
			[Token(Token = "0x401C37B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private bool isDisposed;
		}
	}
}
