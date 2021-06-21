using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace nn.ec
{
	// Token: 0x020015DB RID: 5595
	[Token(Token = "0x2000F62")]
	public static class PurchasedEvent
	{
		// Token: 0x06007F56 RID: 32598
		[Token(Token = "0x60069BB")]
		[Address(RVA = "0x2853CF0", Offset = "0x2853DF1", VA = "0x2853CF0")]
		[PreserveSig]
		public static extern void Initialize();

		// Token: 0x06007F57 RID: 32599
		[Token(Token = "0x60069BC")]
		[Address(RVA = "0x2853D00", Offset = "0x2853E01", VA = "0x2853D00")]
		[PreserveSig]
		public static extern bool PopPurchasedItemInfo(ref PurchasedItemInfo pOut);
	}
}
