using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace nn.hid
{
	// Token: 0x02001562 RID: 5474
	[Token(Token = "0x2000F0F")]
	public static class NpadJoyDual
	{
		// Token: 0x06007BFA RID: 31738
		[Token(Token = "0x60067D6")]
		[Address(RVA = "0x285E950", Offset = "0x285EA51", VA = "0x285E950")]
		[PreserveSig]
		public static extern void GetState(ref NpadJoyDualState pOutValue, NpadId npadId);

		// Token: 0x06007BFB RID: 31739
		[Token(Token = "0x60067D7")]
		[Address(RVA = "0x285D940", Offset = "0x285DA41", VA = "0x285D940")]
		[PreserveSig]
		public static extern void GetState(ref NpadState pOutValue, NpadId npadId);

		// Token: 0x06007BFC RID: 31740
		[Token(Token = "0x60067D8")]
		[Address(RVA = "0x285E960", Offset = "0x285EA61", VA = "0x285E960")]
		[PreserveSig]
		public static extern int GetStates([Out] NpadJoyDualState[] pOutValues, int count, NpadId npadId);

		// Token: 0x06007BFD RID: 31741
		[Token(Token = "0x60067D9")]
		[Address(RVA = "0x285DF10", Offset = "0x285E011", VA = "0x285DF10")]
		[PreserveSig]
		public static extern int GetStates([Out] NpadStateArrayItem[] pOutValues, int count, NpadId npadId);
	}
}
