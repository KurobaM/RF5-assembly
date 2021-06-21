using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace nn.hid
{
	// Token: 0x0200154E RID: 5454
	[Token(Token = "0x2000EFB")]
	public static class Gesture
	{
		// Token: 0x06007BC4 RID: 31684
		[Token(Token = "0x60067A0")]
		[Address(RVA = "0x285C190", Offset = "0x285C291", VA = "0x285C190")]
		[PreserveSig]
		public static extern void Initialize();

		// Token: 0x06007BC5 RID: 31685
		[Token(Token = "0x60067A1")]
		[Address(RVA = "0x285C1A0", Offset = "0x285C2A1", VA = "0x285C1A0")]
		[PreserveSig]
		public static extern int GetStates([Out] GestureState[] pOutValues, int count);

		// Token: 0x0401BEFD RID: 114429
		[Token(Token = "0x401882F")]
		public const int PointCountMax = 4;

		// Token: 0x0401BEFE RID: 114430
		[Token(Token = "0x4018830")]
		public const int StateCountMax = 16;
	}
}
