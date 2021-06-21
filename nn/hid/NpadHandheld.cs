using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace nn.hid
{
	// Token: 0x0200155A RID: 5466
	[Token(Token = "0x2000F07")]
	public static class NpadHandheld
	{
		// Token: 0x06007BE4 RID: 31716
		[Token(Token = "0x60067C0")]
		[Address(RVA = "0x285E4A0", Offset = "0x285E5A1", VA = "0x285E4A0")]
		[PreserveSig]
		public static extern void GetState(ref NpadHandheldState pOutValue, NpadId npadId);

		// Token: 0x06007BE5 RID: 31717
		[Token(Token = "0x60067C1")]
		[Address(RVA = "0x285D930", Offset = "0x285DA31", VA = "0x285D930")]
		[PreserveSig]
		public static extern void GetState(ref NpadState pOutValue, NpadId npadId);

		// Token: 0x06007BE6 RID: 31718
		[Token(Token = "0x60067C2")]
		[Address(RVA = "0x285E4B0", Offset = "0x285E5B1", VA = "0x285E4B0")]
		[PreserveSig]
		public static extern int GetStates([Out] NpadHandheldState[] pOutValues, int count, NpadId npadId);

		// Token: 0x06007BE7 RID: 31719
		[Token(Token = "0x60067C3")]
		[Address(RVA = "0x285DDD0", Offset = "0x285DED1", VA = "0x285DDD0")]
		[PreserveSig]
		public static extern int GetStates([Out] NpadStateArrayItem[] pOutValues, int count, NpadId npadId);
	}
}
