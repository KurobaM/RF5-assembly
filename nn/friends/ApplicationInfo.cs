using System;
using Il2CppDummyDll;

namespace nn.friends
{
	// Token: 0x020015CB RID: 5579
	[Token(Token = "0x2000F54")]
	public struct ApplicationInfo
	{
		// Token: 0x06007ECC RID: 32460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006931")]
		[Address(RVA = "0x3649E0", Offset = "0x364AE1", VA = "0x3649E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0401C120 RID: 114976
		[Token(Token = "0x4018979")]
		[FieldOffset(Offset = "0x0")]
		public ulong appId;

		// Token: 0x0401C121 RID: 114977
		[Token(Token = "0x401897A")]
		[FieldOffset(Offset = "0x8")]
		public ulong presenceGroupId;
	}
}
