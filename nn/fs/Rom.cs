using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace nn.fs
{
	// Token: 0x020015BC RID: 5564
	[Token(Token = "0x2000F45")]
	public static class Rom
	{
		// Token: 0x17000F32 RID: 3890
		// (get) Token: 0x06007E21 RID: 32289 RVA: 0x0002CF70 File Offset: 0x0002B170
		[Token(Token = "0x17000B6C")]
		public static ErrorRange ResultRomHostFileSystemCorrupted
		{
			[Token(Token = "0x6006886")]
			[Address(RVA = "0x2859A60", Offset = "0x2859B61", VA = "0x2859A60")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F33 RID: 3891
		// (get) Token: 0x06007E22 RID: 32290 RVA: 0x0002CF88 File Offset: 0x0002B188
		[Token(Token = "0x17000B6D")]
		public static ErrorRange ResultRomHostEntryCorrupted
		{
			[Token(Token = "0x6006887")]
			[Address(RVA = "0x2859A70", Offset = "0x2859B71", VA = "0x2859A70")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F34 RID: 3892
		// (get) Token: 0x06007E23 RID: 32291 RVA: 0x0002CFA0 File Offset: 0x0002B1A0
		[Token(Token = "0x17000B6E")]
		public static ErrorRange ResultRomHostFileDataCorrupted
		{
			[Token(Token = "0x6006888")]
			[Address(RVA = "0x2859A80", Offset = "0x2859B81", VA = "0x2859A80")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F35 RID: 3893
		// (get) Token: 0x06007E24 RID: 32292 RVA: 0x0002CFB8 File Offset: 0x0002B1B8
		[Token(Token = "0x17000B6F")]
		public static ErrorRange ResultRomHostFileCorrupted
		{
			[Token(Token = "0x6006889")]
			[Address(RVA = "0x2859A90", Offset = "0x2859B91", VA = "0x2859A90")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F36 RID: 3894
		// (get) Token: 0x06007E25 RID: 32293 RVA: 0x0002CFD0 File Offset: 0x0002B1D0
		[Token(Token = "0x17000B70")]
		public static ErrorRange ResultInvalidRomHostHandle
		{
			[Token(Token = "0x600688A")]
			[Address(RVA = "0x2859AA0", Offset = "0x2859BA1", VA = "0x2859AA0")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x06007E26 RID: 32294
		[Token(Token = "0x600688B")]
		[Address(RVA = "0x2859AB0", Offset = "0x2859BB1", VA = "0x2859AB0")]
		[PreserveSig]
		public static extern Result QueryMountRomCacheSize(ref long pOutValue);

		// Token: 0x06007E27 RID: 32295
		[Token(Token = "0x600688C")]
		[Address(RVA = "0x2859AD0", Offset = "0x2859BD1", VA = "0x2859AD0")]
		[PreserveSig]
		public static extern Result MountRom(string name, byte[] pFileSystemCacheBuffer, long fileSystemCacheBufferSize);

		// Token: 0x06007E28 RID: 32296 RVA: 0x0002CFE8 File Offset: 0x0002B1E8
		[Token(Token = "0x600688D")]
		[Address(RVA = "0x2859B30", Offset = "0x2859C31", VA = "0x2859B30")]
		public static bool CanMountRomForDebug()
		{
			return default(bool);
		}
	}
}
