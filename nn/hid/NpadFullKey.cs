using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace nn.hid
{
	// Token: 0x02001558 RID: 5464
	[Token(Token = "0x2000F05")]
	public static class NpadFullKey
	{
		// Token: 0x06007BDF RID: 31711
		[Token(Token = "0x60067BB")]
		[Address(RVA = "0x285E110", Offset = "0x285E211", VA = "0x285E110")]
		[PreserveSig]
		public static extern void GetState(ref NpadFullKeyState pOutValue, NpadId npadId);

		// Token: 0x06007BE0 RID: 31712
		[Token(Token = "0x60067BC")]
		[Address(RVA = "0x285D920", Offset = "0x285DA21", VA = "0x285D920")]
		[PreserveSig]
		public static extern void GetState(ref NpadState pOutValue, NpadId npadId);

		// Token: 0x06007BE1 RID: 31713
		[Token(Token = "0x60067BD")]
		[Address(RVA = "0x285E120", Offset = "0x285E221", VA = "0x285E120")]
		[PreserveSig]
		public static extern int GetStates([Out] NpadFullKeyState[] pOutValues, int count, NpadId npadId);

		// Token: 0x06007BE2 RID: 31714
		[Token(Token = "0x60067BE")]
		[Address(RVA = "0x285DC90", Offset = "0x285DD91", VA = "0x285DC90")]
		[PreserveSig]
		public static extern int GetStates([Out] NpadStateArrayItem[] pOutValues, int count, NpadId npadId);
	}
}
