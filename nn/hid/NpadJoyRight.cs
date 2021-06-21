using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace nn.hid
{
	// Token: 0x02001566 RID: 5478
	[Token(Token = "0x2000F13")]
	public static class NpadJoyRight
	{
		// Token: 0x06007C04 RID: 31748
		[Token(Token = "0x60067E0")]
		[Address(RVA = "0x2D61F80", Offset = "0x2D62081", VA = "0x2D61F80")]
		[PreserveSig]
		public static extern void GetState(ref NpadJoyRightState pOutValue, NpadId npadId);

		// Token: 0x06007C05 RID: 31749
		[Token(Token = "0x60067E1")]
		[Address(RVA = "0x2D61F90", Offset = "0x2D62091", VA = "0x2D61F90")]
		[PreserveSig]
		public static extern void GetState(ref NpadState pOutValue, NpadId npadId);

		// Token: 0x06007C06 RID: 31750
		[Token(Token = "0x60067E2")]
		[Address(RVA = "0x2D61FA0", Offset = "0x2D620A1", VA = "0x2D61FA0")]
		[PreserveSig]
		public static extern int GetStates([Out] NpadJoyRightState[] pOutValues, int count, NpadId npadId);

		// Token: 0x06007C07 RID: 31751
		[Token(Token = "0x60067E3")]
		[Address(RVA = "0x2D620E0", Offset = "0x2D621E1", VA = "0x2D620E0")]
		[PreserveSig]
		public static extern int GetStates([Out] NpadStateArrayItem[] pOutValues, int count, NpadId npadId);
	}
}
