using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace nn.fs
{
	// Token: 0x020015B3 RID: 5555
	[Token(Token = "0x2000F3E")]
	public static class File
	{
		// Token: 0x06007DEB RID: 32235
		[Token(Token = "0x6006851")]
		[Address(RVA = "0x2859250", Offset = "0x2859351", VA = "0x2859250")]
		[PreserveSig]
		public static extern Result Read(FileHandle handle, long offset, byte[] buffer, long size, ReadOption option);

		// Token: 0x06007DEC RID: 32236
		[Token(Token = "0x6006852")]
		[Address(RVA = "0x2859280", Offset = "0x2859381", VA = "0x2859280")]
		[PreserveSig]
		public static extern Result Read(FileHandle handle, long offset, byte[] buffer, long size);

		// Token: 0x06007DED RID: 32237
		[Token(Token = "0x6006853")]
		[Address(RVA = "0x28592B0", Offset = "0x28593B1", VA = "0x28592B0")]
		[PreserveSig]
		public static extern Result Read(ref long outValue, FileHandle handle, long offset, byte[] buffer, long size, ReadOption option);

		// Token: 0x06007DEE RID: 32238
		[Token(Token = "0x6006854")]
		[Address(RVA = "0x28592E0", Offset = "0x28593E1", VA = "0x28592E0")]
		[PreserveSig]
		public static extern Result Read(ref long outValue, FileHandle handle, long offset, byte[] buffer, long size);

		// Token: 0x06007DEF RID: 32239
		[Token(Token = "0x6006855")]
		[Address(RVA = "0x2859310", Offset = "0x2859411", VA = "0x2859310")]
		[PreserveSig]
		public static extern Result Write(FileHandle handle, long offset, byte[] buffer, long size, WriteOption option);

		// Token: 0x06007DF0 RID: 32240
		[Token(Token = "0x6006856")]
		[Address(RVA = "0x2859340", Offset = "0x2859441", VA = "0x2859340")]
		[PreserveSig]
		public static extern Result Flush(FileHandle handle);

		// Token: 0x06007DF1 RID: 32241
		[Token(Token = "0x6006857")]
		[Address(RVA = "0x2859360", Offset = "0x2859461", VA = "0x2859360")]
		[PreserveSig]
		public static extern Result SetSize(FileHandle handle, long size);

		// Token: 0x06007DF2 RID: 32242
		[Token(Token = "0x6006858")]
		[Address(RVA = "0x2859380", Offset = "0x2859481", VA = "0x2859380")]
		[PreserveSig]
		public static extern Result GetSize(ref long outValue, FileHandle handle);

		// Token: 0x06007DF3 RID: 32243
		[Token(Token = "0x6006859")]
		[Address(RVA = "0x28593A0", Offset = "0x28594A1", VA = "0x28593A0")]
		[PreserveSig]
		public static extern OpenFileMode GetOpenMode(FileHandle handle);

		// Token: 0x06007DF4 RID: 32244
		[Token(Token = "0x600685A")]
		[Address(RVA = "0x28593B0", Offset = "0x28594B1", VA = "0x28593B0")]
		[PreserveSig]
		public static extern void Close(FileHandle handle);

		// Token: 0x06007DF5 RID: 32245
		[Token(Token = "0x600685B")]
		[Address(RVA = "0x28593C0", Offset = "0x28594C1", VA = "0x28593C0")]
		[PreserveSig]
		public static extern Result Create(string path, long size);

		// Token: 0x06007DF6 RID: 32246
		[Token(Token = "0x600685C")]
		[Address(RVA = "0x2859400", Offset = "0x2859501", VA = "0x2859400")]
		[PreserveSig]
		public static extern Result Delete(string path);

		// Token: 0x06007DF7 RID: 32247
		[Token(Token = "0x600685D")]
		[Address(RVA = "0x2859440", Offset = "0x2859541", VA = "0x2859440")]
		[PreserveSig]
		public static extern Result Rename(string currentPath, string newPath);

		// Token: 0x06007DF8 RID: 32248
		[Token(Token = "0x600685E")]
		[Address(RVA = "0x28594A0", Offset = "0x28595A1", VA = "0x28594A0")]
		[PreserveSig]
		public static extern Result Open(ref FileHandle outValue, string path, OpenFileMode mode);
	}
}
