using System;
using Il2CppDummyDll;

namespace Common
{
	// Token: 0x020011C3 RID: 4547
	[Token(Token = "0x2000B98")]
	public class AesCryptography
	{
		// Token: 0x06007114 RID: 28948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DD0")]
		[Address(RVA = "0x20DB2B0", Offset = "0x20DB3B1", VA = "0x20DB2B0")]
		public byte[] Encrypt(byte[] binData, int length = 0)
		{
			return null;
		}

		// Token: 0x06007115 RID: 28949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DD1")]
		[Address(RVA = "0x20DB4B0", Offset = "0x20DB5B1", VA = "0x20DB4B0")]
		public byte[] Decrypt(byte[] binData, int length = 0)
		{
			return null;
		}

		// Token: 0x06007116 RID: 28950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DD2")]
		[Address(RVA = "0x20DB6B0", Offset = "0x20DB7B1", VA = "0x20DB6B0")]
		public AesCryptography()
		{
		}

		// Token: 0x040182F2 RID: 99058
		[Token(Token = "0x4014D5E")]
		private const string AesInitVector = "XuMigxpK61gLwgo1RsreLLGPcw3vJFze";

		// Token: 0x040182F3 RID: 99059
		[Token(Token = "0x4014D5F")]
		private const string AesKey = "1cOSvkZ4HQCi6z/yQpEEl4neB+AIXwTX";

		// Token: 0x040182F4 RID: 99060
		[Token(Token = "0x4014D60")]
		private const int BlockSize = 256;

		// Token: 0x040182F5 RID: 99061
		[Token(Token = "0x4014D61")]
		private const int KeySize = 256;
	}
}
