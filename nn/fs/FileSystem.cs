using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace nn.fs
{
	// Token: 0x020015B5 RID: 5557
	[Token(Token = "0x2000F40")]
	public static class FileSystem
	{
		// Token: 0x06007DF9 RID: 32249
		[Token(Token = "0x600685F")]
		[Address(RVA = "0x2859500", Offset = "0x2859601", VA = "0x2859500")]
		[PreserveSig]
		public static extern Result GetEntryType(ref EntryType outValue, string path);

		// Token: 0x06007DFA RID: 32250
		[Token(Token = "0x6006860")]
		[Address(RVA = "0x2859550", Offset = "0x2859651", VA = "0x2859550")]
		[PreserveSig]
		public static extern Result GetFreeSpaceSize(ref long outValue, string path);

		// Token: 0x06007DFB RID: 32251
		[Token(Token = "0x6006861")]
		[Address(RVA = "0x28595A0", Offset = "0x28596A1", VA = "0x28595A0")]
		[PreserveSig]
		public static extern void Unmount(string name);

		// Token: 0x17000F1D RID: 3869
		// (get) Token: 0x06007DFC RID: 32252 RVA: 0x0002CCD0 File Offset: 0x0002AED0
		[Token(Token = "0x17000B57")]
		public static ErrorRange ResultHandledByAllProcess
		{
			[Token(Token = "0x6006862")]
			[Address(RVA = "0x28595D0", Offset = "0x28596D1", VA = "0x28595D0")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F1E RID: 3870
		// (get) Token: 0x06007DFD RID: 32253 RVA: 0x0002CCE8 File Offset: 0x0002AEE8
		[Token(Token = "0x17000B58")]
		public static ErrorRange ResultPathNotFound
		{
			[Token(Token = "0x6006863")]
			[Address(RVA = "0x28595E0", Offset = "0x28596E1", VA = "0x28595E0")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F1F RID: 3871
		// (get) Token: 0x06007DFE RID: 32254 RVA: 0x0002CD00 File Offset: 0x0002AF00
		[Token(Token = "0x17000B59")]
		public static ErrorRange ResultPathAlreadyExists
		{
			[Token(Token = "0x6006864")]
			[Address(RVA = "0x28595F0", Offset = "0x28596F1", VA = "0x28595F0")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F20 RID: 3872
		// (get) Token: 0x06007DFF RID: 32255 RVA: 0x0002CD18 File Offset: 0x0002AF18
		[Token(Token = "0x17000B5A")]
		public static ErrorRange ResultTargetLocked
		{
			[Token(Token = "0x6006865")]
			[Address(RVA = "0x2859600", Offset = "0x2859701", VA = "0x2859600")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F21 RID: 3873
		// (get) Token: 0x06007E00 RID: 32256 RVA: 0x0002CD30 File Offset: 0x0002AF30
		[Token(Token = "0x17000B5B")]
		public static ErrorRange ResultDirectoryNotEmpty
		{
			[Token(Token = "0x6006866")]
			[Address(RVA = "0x2859610", Offset = "0x2859711", VA = "0x2859610")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F22 RID: 3874
		// (get) Token: 0x06007E01 RID: 32257 RVA: 0x0002CD48 File Offset: 0x0002AF48
		[Token(Token = "0x17000B5C")]
		public static ErrorRange ResultDirectoryStatusChanged
		{
			[Token(Token = "0x6006867")]
			[Address(RVA = "0x2859620", Offset = "0x2859721", VA = "0x2859620")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F23 RID: 3875
		// (get) Token: 0x06007E02 RID: 32258 RVA: 0x0002CD60 File Offset: 0x0002AF60
		[Token(Token = "0x17000B5D")]
		public static ErrorRange ResultUsableSpaceNotEnough
		{
			[Token(Token = "0x6006868")]
			[Address(RVA = "0x2859630", Offset = "0x2859731", VA = "0x2859630")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F24 RID: 3876
		// (get) Token: 0x06007E03 RID: 32259 RVA: 0x0002CD78 File Offset: 0x0002AF78
		[Token(Token = "0x17000B5E")]
		public static ErrorRange ResultUnsupportedSdkVersion
		{
			[Token(Token = "0x6006869")]
			[Address(RVA = "0x2859640", Offset = "0x2859741", VA = "0x2859640")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F25 RID: 3877
		// (get) Token: 0x06007E04 RID: 32260 RVA: 0x0002CD90 File Offset: 0x0002AF90
		[Token(Token = "0x17000B5F")]
		public static ErrorRange ResultMountNameAlreadyExists
		{
			[Token(Token = "0x600686A")]
			[Address(RVA = "0x2859650", Offset = "0x2859751", VA = "0x2859650")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F26 RID: 3878
		// (get) Token: 0x06007E05 RID: 32261 RVA: 0x0002CDA8 File Offset: 0x0002AFA8
		[Token(Token = "0x17000B60")]
		public static ErrorRange ResultTargetNotFound
		{
			[Token(Token = "0x600686B")]
			[Address(RVA = "0x2859660", Offset = "0x2859761", VA = "0x2859660")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x06007E06 RID: 32262
		[Token(Token = "0x600686C")]
		[Address(RVA = "0x2859670", Offset = "0x2859771", VA = "0x2859670")]
		[PreserveSig]
		public static extern Result Commit(string name);

		// Token: 0x06007E07 RID: 32263
		[Token(Token = "0x600686D")]
		[Address(RVA = "0x28596B0", Offset = "0x28597B1", VA = "0x28596B0")]
		[PreserveSig]
		private static extern Result Commit(string[] name, int nameCount);

		// Token: 0x06007E08 RID: 32264 RVA: 0x0002CDC0 File Offset: 0x0002AFC0
		[Token(Token = "0x600686E")]
		[Address(RVA = "0x28597A0", Offset = "0x28598A1", VA = "0x28597A0")]
		public static Result Commit(string[] name)
		{
			return default(Result);
		}

		// Token: 0x0401C0EE RID: 114926
		[Token(Token = "0x401894A")]
		public const int MountNameLengthMax = 15;
	}
}
