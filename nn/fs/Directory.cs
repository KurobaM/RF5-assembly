using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace nn.fs
{
	// Token: 0x020015AF RID: 5551
	[Token(Token = "0x2000F3A")]
	public static class Directory
	{
		// Token: 0x06007DE2 RID: 32226
		[Token(Token = "0x6006848")]
		[Address(RVA = "0x2858E40", Offset = "0x2858F41", VA = "0x2858E40")]
		[PreserveSig]
		public static extern Result Read(ref long outValue, [Out] DirectoryEntry[] entryBuffer, DirectoryHandle handle, long entryBufferCount);

		// Token: 0x06007DE3 RID: 32227
		[Token(Token = "0x6006849")]
		[Address(RVA = "0x2858F90", Offset = "0x2859091", VA = "0x2858F90")]
		[PreserveSig]
		public static extern Result GetEntryCount(ref long outValue, DirectoryHandle handle);

		// Token: 0x06007DE4 RID: 32228
		[Token(Token = "0x600684A")]
		[Address(RVA = "0x2858FB0", Offset = "0x28590B1", VA = "0x2858FB0")]
		[PreserveSig]
		public static extern void Close(DirectoryHandle handle);

		// Token: 0x06007DE5 RID: 32229
		[Token(Token = "0x600684B")]
		[Address(RVA = "0x2858FC0", Offset = "0x28590C1", VA = "0x2858FC0")]
		[PreserveSig]
		public static extern Result Create(string path);

		// Token: 0x06007DE6 RID: 32230
		[Token(Token = "0x600684C")]
		[Address(RVA = "0x2859000", Offset = "0x2859101", VA = "0x2859000")]
		[PreserveSig]
		public static extern Result Delete(string path);

		// Token: 0x06007DE7 RID: 32231
		[Token(Token = "0x600684D")]
		[Address(RVA = "0x2859040", Offset = "0x2859141", VA = "0x2859040")]
		[PreserveSig]
		public static extern Result DeleteRecursively(string path);

		// Token: 0x06007DE8 RID: 32232
		[Token(Token = "0x600684E")]
		[Address(RVA = "0x2859080", Offset = "0x2859181", VA = "0x2859080")]
		[PreserveSig]
		public static extern Result CleanRecursively(string path);

		// Token: 0x06007DE9 RID: 32233
		[Token(Token = "0x600684F")]
		[Address(RVA = "0x28590C0", Offset = "0x28591C1", VA = "0x28590C0")]
		[PreserveSig]
		public static extern Result Rename(string currentPath, string newPath);

		// Token: 0x06007DEA RID: 32234
		[Token(Token = "0x6006850")]
		[Address(RVA = "0x2859120", Offset = "0x2859221", VA = "0x2859120")]
		[PreserveSig]
		public static extern Result Open(ref DirectoryHandle outValue, string path, OpenDirectoryMode mode);

		// Token: 0x0401C0E4 RID: 114916
		[Token(Token = "0x4018940")]
		public const int EntryNameLengthMax = 768;
	}
}
