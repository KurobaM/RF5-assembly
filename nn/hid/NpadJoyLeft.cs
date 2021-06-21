using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace nn.hid
{
	// Token: 0x02001564 RID: 5476
	[Token(Token = "0x2000F11")]
	public static class NpadJoyLeft
	{
		// Token: 0x06007BFF RID: 31743
		[Token(Token = "0x60067DB")]
		[Address(RVA = "0x2D61AA0", Offset = "0x2D61BA1", VA = "0x2D61AA0")]
		[PreserveSig]
		public static extern void GetState(ref NpadJoyLeftState pOutValue, NpadId npadId);

		// Token: 0x06007C00 RID: 31744
		[Token(Token = "0x60067DC")]
		[Address(RVA = "0x2D61AB0", Offset = "0x2D61BB1", VA = "0x2D61AB0")]
		[PreserveSig]
		public static extern void GetState(ref NpadState pOutValue, NpadId npadId);

		// Token: 0x06007C01 RID: 31745
		[Token(Token = "0x60067DD")]
		[Address(RVA = "0x2D61AC0", Offset = "0x2D61BC1", VA = "0x2D61AC0")]
		[PreserveSig]
		public static extern int GetStates([Out] NpadJoyLeftState[] pOutValues, int count, NpadId npadId);

		// Token: 0x06007C02 RID: 31746
		[Token(Token = "0x60067DE")]
		[Address(RVA = "0x2D61C00", Offset = "0x2D61D01", VA = "0x2D61C00")]
		[PreserveSig]
		public static extern int GetStates([Out] NpadStateArrayItem[] pOutValues, int count, NpadId npadId);
	}
}
