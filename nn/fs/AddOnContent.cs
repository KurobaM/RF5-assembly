using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace nn.fs
{
	// Token: 0x020015AC RID: 5548
	[Token(Token = "0x2000F37")]
	public static class AddOnContent
	{
		// Token: 0x06007DDD RID: 32221
		[Token(Token = "0x6006843")]
		[Address(RVA = "0x2858DC0", Offset = "0x2858EC1", VA = "0x2858DC0")]
		[PreserveSig]
		public static extern Result QueryMountCacheSize(ref long pOutValue, int targetIndex);

		// Token: 0x06007DDE RID: 32222
		[Token(Token = "0x6006844")]
		[Address(RVA = "0x2858DE0", Offset = "0x2858EE1", VA = "0x2858DE0")]
		[PreserveSig]
		public static extern Result Mount(string name, int targetIndex, byte[] pFileSystemCacheBuffer, long fileSystemCacheBufferSize);
	}
}
