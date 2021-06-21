using System;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;

namespace UTJ
{
	// Token: 0x02000C0D RID: 3085
	[Token(Token = "0x20007EF")]
	public class FileUtil
	{
		// Token: 0x06004E84 RID: 20100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600415D")]
		[Address(RVA = "0x2129E20", Offset = "0x2129F21", VA = "0x2129E20")]
		public static string ReadAllText(string inFilePath, Encoding inDefaultEncoding)
		{
			return null;
		}

		// Token: 0x06004E85 RID: 20101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600415E")]
		[Address(RVA = "0x212A320", Offset = "0x212A421", VA = "0x212A320")]
		public static string ReadAllText(string inFilePath)
		{
			return null;
		}

		// Token: 0x06004E86 RID: 20102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600415F")]
		[Address(RVA = "0x212A360", Offset = "0x212A461", VA = "0x212A360")]
		public static string[] ReadAllLines(string inFilePath, Encoding inDefaultEncoding)
		{
			return null;
		}

		// Token: 0x06004E87 RID: 20103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004160")]
		[Address(RVA = "0x212A4E0", Offset = "0x212A5E1", VA = "0x212A4E0")]
		public static string[] ReadAllLines(string inFilePath)
		{
			return null;
		}

		// Token: 0x06004E88 RID: 20104 RVA: 0x000190F8 File Offset: 0x000172F8
		[Token(Token = "0x6004161")]
		[Address(RVA = "0x212A520", Offset = "0x212A621", VA = "0x212A520")]
		public static bool WriteAllText(string filePath, string text, [Optional] Encoding encoding)
		{
			return default(bool);
		}

		// Token: 0x06004E89 RID: 20105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004162")]
		[Address(RVA = "0x2129F80", Offset = "0x212A081", VA = "0x2129F80")]
		public static Encoding TryToDetectEncoding(string inFilePath, Encoding inDefaultEncoding)
		{
			return null;
		}

		// Token: 0x06004E8A RID: 20106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004163")]
		[Address(RVA = "0x212A8D0", Offset = "0x212A9D1", VA = "0x212A8D0")]
		public static Encoding TryToDetectEncoding(string inFilePath)
		{
			return null;
		}

		// Token: 0x06004E8B RID: 20107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004164")]
		[Address(RVA = "0x212A900", Offset = "0x212AA01", VA = "0x212A900")]
		public static void ExploreToDirectory(string directory)
		{
		}

		// Token: 0x06004E8C RID: 20108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004165")]
		[Address(RVA = "0x212A6A0", Offset = "0x212A7A1", VA = "0x212A6A0")]
		private static byte[] ReadFirstBytesOfFile(string inFilePath, int inNumBytesToRead)
		{
			return null;
		}

		// Token: 0x06004E8D RID: 20109 RVA: 0x00019110 File Offset: 0x00017310
		[Token(Token = "0x6004166")]
		[Address(RVA = "0x212A840", Offset = "0x212A941", VA = "0x212A840")]
		private static bool CheckIfBufferStartsWithHeader(byte[] inBuffer, byte[] inHeader)
		{
			return default(bool);
		}

		// Token: 0x06004E8E RID: 20110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004167")]
		[Address(RVA = "0x212A910", Offset = "0x212AA11", VA = "0x212A910")]
		public FileUtil()
		{
		}
	}
}
