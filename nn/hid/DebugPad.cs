using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace nn.hid
{
	// Token: 0x02001546 RID: 5446
	[Token(Token = "0x2000EF5")]
	public static class DebugPad
	{
		// Token: 0x06007BA0 RID: 31648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006792")]
		[Address(RVA = "0x285BE40", Offset = "0x285BF41", VA = "0x285BE40")]
		public static void Initialize()
		{
		}

		// Token: 0x06007BA1 RID: 31649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006793")]
		[Address(RVA = "0x285BE50", Offset = "0x285BF51", VA = "0x285BE50")]
		public static void GetState(ref DebugPadState pOutValue)
		{
		}

		// Token: 0x06007BA2 RID: 31650 RVA: 0x0002BB30 File Offset: 0x00029D30
		[Token(Token = "0x6006794")]
		[Address(RVA = "0x285BE60", Offset = "0x285BF61", VA = "0x285BE60")]
		public static int GetStates([Out] DebugPadState[] pOutValues, int count)
		{
			return 0;
		}

		// Token: 0x0401BED0 RID: 114384
		[Token(Token = "0x401880A")]
		public const int StateCountMax = 16;
	}
}
