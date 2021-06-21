using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace nn.aoc
{
	// Token: 0x020015E7 RID: 5607
	[Token(Token = "0x2000F6C")]
	public static class Aoc
	{
		// Token: 0x06007FAB RID: 32683
		[Token(Token = "0x60069FF")]
		[Address(RVA = "0x28527E0", Offset = "0x28528E1", VA = "0x28527E0")]
		[PreserveSig]
		public static extern int CountAddOnContent();

		// Token: 0x06007FAC RID: 32684
		[Token(Token = "0x6006A00")]
		[Address(RVA = "0x28527F0", Offset = "0x28528F1", VA = "0x28527F0")]
		[PreserveSig]
		public static extern int ListAddOnContent(int[] outIndices, int offset, int count);

		// Token: 0x06007FAD RID: 32685
		[Token(Token = "0x6006A01")]
		[Address(RVA = "0x2852800", Offset = "0x2852901", VA = "0x2852800")]
		[PreserveSig]
		public static extern void GetAddOnContentListChangedEvent();

		// Token: 0x06007FAE RID: 32686
		[Token(Token = "0x6006A02")]
		[Address(RVA = "0x2852810", Offset = "0x2852911", VA = "0x2852810")]
		[PreserveSig]
		public static extern bool IsAddOnContentListChanged();

		// Token: 0x06007FAF RID: 32687
		[Token(Token = "0x6006A03")]
		[Address(RVA = "0x2852830", Offset = "0x2852931", VA = "0x2852830")]
		[PreserveSig]
		public static extern void DestroyAddOnContentListChangedEvent();

		// Token: 0x06007FB0 RID: 32688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A04")]
		[Address(RVA = "0x2852840", Offset = "0x2852941", VA = "0x2852840")]
		public static void ShowAddOnContentLostError(int[] indices)
		{
		}

		// Token: 0x06007FB1 RID: 32689
		[Token(Token = "0x6006A05")]
		[Address(RVA = "0x2852860", Offset = "0x2852961", VA = "0x2852860")]
		[PreserveSig]
		private static extern void ShowAddOnContentLostError(int[] indices, int count);
	}
}
