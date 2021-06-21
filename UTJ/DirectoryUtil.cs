using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UTJ
{
	// Token: 0x02000C0C RID: 3084
	[Token(Token = "0x20007EE")]
	public class DirectoryUtil
	{
		// Token: 0x06004E7E RID: 20094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004157")]
		[Address(RVA = "0x2127200", Offset = "0x2127301", VA = "0x2127200")]
		public static string[] GetDirectories(string path, string searchPattern = "*")
		{
			return null;
		}

		// Token: 0x06004E7F RID: 20095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004158")]
		[Address(RVA = "0x2127420", Offset = "0x2127521", VA = "0x2127420")]
		public static IEnumerable<string> GetFilesRecursively(string path, string searchPattern = "*.*")
		{
			return null;
		}

		// Token: 0x06004E80 RID: 20096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004159")]
		[Address(RVA = "0x21274B0", Offset = "0x21275B1", VA = "0x21274B0")]
		public static void GetFilesRecursively(string path, string searchPattern, List<string> files)
		{
		}

		// Token: 0x06004E81 RID: 20097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600415A")]
		[Address(RVA = "0x21275A0", Offset = "0x21276A1", VA = "0x21275A0")]
		public static string[] GetFiles(string path, string searchPattern = "*.*")
		{
			return null;
		}

		// Token: 0x06004E82 RID: 20098 RVA: 0x000190E0 File Offset: 0x000172E0
		[Token(Token = "0x600415B")]
		[Address(RVA = "0x21277C0", Offset = "0x21278C1", VA = "0x21277C0")]
		public static bool TryToCreateDirectory(string directoryName)
		{
			return default(bool);
		}

		// Token: 0x06004E83 RID: 20099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600415C")]
		[Address(RVA = "0x2127AA0", Offset = "0x2127BA1", VA = "0x2127AA0")]
		public DirectoryUtil()
		{
		}
	}
}
