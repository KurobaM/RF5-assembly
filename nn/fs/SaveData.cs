using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using nn.account;

namespace nn.fs
{
	// Token: 0x020015BB RID: 5563
	[Token(Token = "0x2000F44")]
	public static class SaveData
	{
		// Token: 0x17000F31 RID: 3889
		// (get) Token: 0x06007E19 RID: 32281 RVA: 0x0002CF40 File Offset: 0x0002B140
		[Token(Token = "0x17000B6B")]
		public static ErrorRange ResultUsableSpaceNotEnoughForSaveData
		{
			[Token(Token = "0x600687E")]
			[Address(RVA = "0x2859B40", Offset = "0x2859C41", VA = "0x2859B40")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x06007E1A RID: 32282
		[Token(Token = "0x600687F")]
		[Address(RVA = "0x2859B50", Offset = "0x2859C51", VA = "0x2859B50")]
		[PreserveSig]
		public static extern Result Ensure(Uid user);

		// Token: 0x06007E1B RID: 32283
		[Token(Token = "0x6006880")]
		[Address(RVA = "0x2859B70", Offset = "0x2859C71", VA = "0x2859B70")]
		[PreserveSig]
		public static extern Result Mount(string name, Uid user);

		// Token: 0x06007E1C RID: 32284
		[Token(Token = "0x6006881")]
		[Address(RVA = "0x2859BC0", Offset = "0x2859CC1", VA = "0x2859BC0")]
		[PreserveSig]
		public static extern Result MountSaveDataReadOnly(string name, ulong applicationId, Uid user);

		// Token: 0x06007E1D RID: 32285
		[Token(Token = "0x6006882")]
		[Address(RVA = "0x2859C20", Offset = "0x2859D21", VA = "0x2859C20")]
		[PreserveSig]
		public static extern bool IsExisting(Uid user);

		// Token: 0x06007E1E RID: 32286
		[Token(Token = "0x6006883")]
		[Address(RVA = "0x2859C40", Offset = "0x2859D41", VA = "0x2859C40")]
		[PreserveSig]
		public static extern bool IsExisting(ulong applicationId, Uid user);

		// Token: 0x06007E1F RID: 32287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006884")]
		[Address(RVA = "0x2859C60", Offset = "0x2859D61", VA = "0x2859C60")]
		public static void SetRootPath(string rootPath)
		{
		}

		// Token: 0x06007E20 RID: 32288 RVA: 0x0002CF58 File Offset: 0x0002B158
		[Token(Token = "0x6006885")]
		[Address(RVA = "0x2859C70", Offset = "0x2859D71", VA = "0x2859C70")]
		public static Result MountForDebug(string name)
		{
			return default(Result);
		}
	}
}
