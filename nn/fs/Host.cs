using System;
using Il2CppDummyDll;

namespace nn.fs
{
	// Token: 0x020015B8 RID: 5560
	[Token(Token = "0x2000F43")]
	public static class Host
	{
		// Token: 0x06007E09 RID: 32265 RVA: 0x0002CDD8 File Offset: 0x0002AFD8
		[Token(Token = "0x600686F")]
		[Address(RVA = "0x28597D0", Offset = "0x28598D1", VA = "0x28597D0")]
		public static Result MountHost(string name, string rootPath)
		{
			return default(Result);
		}

		// Token: 0x06007E0A RID: 32266 RVA: 0x0002CDF0 File Offset: 0x0002AFF0
		[Token(Token = "0x6006870")]
		[Address(RVA = "0x2859830", Offset = "0x2859931", VA = "0x2859830")]
		public static Result MountHost(string name, string rootPath, Host.MountHostOption option)
		{
			return default(Result);
		}

		// Token: 0x06007E0B RID: 32267 RVA: 0x0002CE08 File Offset: 0x0002B008
		[Token(Token = "0x6006871")]
		[Address(RVA = "0x2859890", Offset = "0x2859991", VA = "0x2859890")]
		public static Result MountHostRoot()
		{
			return default(Result);
		}

		// Token: 0x06007E0C RID: 32268 RVA: 0x0002CE20 File Offset: 0x0002B020
		[Token(Token = "0x6006872")]
		[Address(RVA = "0x28598F0", Offset = "0x28599F1", VA = "0x28598F0")]
		public static Result MountHostRoot(Host.MountHostOption option)
		{
			return default(Result);
		}

		// Token: 0x06007E0D RID: 32269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006873")]
		[Address(RVA = "0x2859950", Offset = "0x2859A51", VA = "0x2859950")]
		public static void UnMountHostRoot()
		{
		}

		// Token: 0x17000F27 RID: 3879
		// (get) Token: 0x06007E0E RID: 32270 RVA: 0x0002CE38 File Offset: 0x0002B038
		[Token(Token = "0x17000B61")]
		public static ErrorRange ResultSaveDataHostFileSystemCorrupted
		{
			[Token(Token = "0x6006874")]
			[Address(RVA = "0x28599B0", Offset = "0x2859AB1", VA = "0x28599B0")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F28 RID: 3880
		// (get) Token: 0x06007E0F RID: 32271 RVA: 0x0002CE50 File Offset: 0x0002B050
		[Token(Token = "0x17000B62")]
		public static ErrorRange ResultSaveDataHostEntryCorrupted
		{
			[Token(Token = "0x6006875")]
			[Address(RVA = "0x28599C0", Offset = "0x2859AC1", VA = "0x28599C0")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F29 RID: 3881
		// (get) Token: 0x06007E10 RID: 32272 RVA: 0x0002CE68 File Offset: 0x0002B068
		[Token(Token = "0x17000B63")]
		public static ErrorRange ResultSaveDataHostFileDataCorrupted
		{
			[Token(Token = "0x6006876")]
			[Address(RVA = "0x28599D0", Offset = "0x2859AD1", VA = "0x28599D0")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F2A RID: 3882
		// (get) Token: 0x06007E11 RID: 32273 RVA: 0x0002CE80 File Offset: 0x0002B080
		[Token(Token = "0x17000B64")]
		public static ErrorRange ResultSaveDataHostFileCorrupted
		{
			[Token(Token = "0x6006877")]
			[Address(RVA = "0x28599E0", Offset = "0x2859AE1", VA = "0x28599E0")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F2B RID: 3883
		// (get) Token: 0x06007E12 RID: 32274 RVA: 0x0002CE98 File Offset: 0x0002B098
		[Token(Token = "0x17000B65")]
		public static ErrorRange ResultInvalidSaveDataHostHandle
		{
			[Token(Token = "0x6006878")]
			[Address(RVA = "0x28599F0", Offset = "0x2859AF1", VA = "0x28599F0")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F2C RID: 3884
		// (get) Token: 0x06007E13 RID: 32275 RVA: 0x0002CEB0 File Offset: 0x0002B0B0
		[Token(Token = "0x17000B66")]
		public static ErrorRange ResultHostFileSystemCorrupted
		{
			[Token(Token = "0x6006879")]
			[Address(RVA = "0x2859A00", Offset = "0x2859B01", VA = "0x2859A00")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F2D RID: 3885
		// (get) Token: 0x06007E14 RID: 32276 RVA: 0x0002CEC8 File Offset: 0x0002B0C8
		[Token(Token = "0x17000B67")]
		public static ErrorRange ResultHostEntryCorrupted
		{
			[Token(Token = "0x600687A")]
			[Address(RVA = "0x2859A10", Offset = "0x2859B11", VA = "0x2859A10")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F2E RID: 3886
		// (get) Token: 0x06007E15 RID: 32277 RVA: 0x0002CEE0 File Offset: 0x0002B0E0
		[Token(Token = "0x17000B68")]
		public static ErrorRange ResultHostFileDataCorrupted
		{
			[Token(Token = "0x600687B")]
			[Address(RVA = "0x2859A20", Offset = "0x2859B21", VA = "0x2859A20")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F2F RID: 3887
		// (get) Token: 0x06007E16 RID: 32278 RVA: 0x0002CEF8 File Offset: 0x0002B0F8
		[Token(Token = "0x17000B69")]
		public static ErrorRange ResultHostFileCorrupted
		{
			[Token(Token = "0x600687C")]
			[Address(RVA = "0x2859A30", Offset = "0x2859B31", VA = "0x2859A30")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F30 RID: 3888
		// (get) Token: 0x06007E17 RID: 32279 RVA: 0x0002CF10 File Offset: 0x0002B110
		[Token(Token = "0x17000B6A")]
		public static ErrorRange ResultInvalidHostHandle
		{
			[Token(Token = "0x600687D")]
			[Address(RVA = "0x2859A40", Offset = "0x2859B41", VA = "0x2859A40")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x020015B9 RID: 5561
		[Token(Token = "0x20015C7")]
		public enum MountHostOptionFlag
		{
			// Token: 0x0401C0F8 RID: 114936
			[Token(Token = "0x401C363")]
			PseudoCaseSensitive = 1
		}

		// Token: 0x020015BA RID: 5562
		[Token(Token = "0x20015C8")]
		public struct MountHostOption
		{
			// Token: 0x06007E18 RID: 32280 RVA: 0x0002CF28 File Offset: 0x0002B128
			[Token(Token = "0x6007FAD")]
			[Address(RVA = "0x2859A50", Offset = "0x2859B51", VA = "0x2859A50")]
			public static Host.MountHostOption MakeValue(int flags)
			{
				return default(Host.MountHostOption);
			}

			// Token: 0x0401C0F9 RID: 114937
			[Token(Token = "0x401C364")]
			[FieldOffset(Offset = "0x0")]
			public int flags;
		}
	}
}
