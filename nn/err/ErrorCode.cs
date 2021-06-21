using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace nn.err
{
	// Token: 0x020015D1 RID: 5585
	[Token(Token = "0x2000F59")]
	public struct ErrorCode
	{
		// Token: 0x06007EF7 RID: 32503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600695C")]
		[Address(RVA = "0x364920", Offset = "0x364A21", VA = "0x364920", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007EF8 RID: 32504 RVA: 0x0002D6C0 File Offset: 0x0002B8C0
		[Token(Token = "0x600695D")]
		[Address(RVA = "0x3649C0", Offset = "0x364AC1", VA = "0x3649C0")]
		public bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06007EF9 RID: 32505
		[Token(Token = "0x600695E")]
		[Address(RVA = "0x2855340", Offset = "0x2855441", VA = "0x2855340")]
		[PreserveSig]
		private static extern bool IsValid(ErrorCode errorCode);

		// Token: 0x06007EFA RID: 32506
		[Token(Token = "0x600695F")]
		[Address(RVA = "0x2852FB0", Offset = "0x28530B1", VA = "0x2852FB0")]
		[PreserveSig]
		public static extern ErrorCode GetInvalidErrorCode();

		// Token: 0x0401C139 RID: 115001
		[Token(Token = "0x4018980")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint category;

		// Token: 0x0401C13A RID: 115002
		[Token(Token = "0x4018981")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint number;
	}
}
