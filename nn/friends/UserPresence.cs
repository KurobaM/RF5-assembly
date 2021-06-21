using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using nn.account;

namespace nn.friends
{
	// Token: 0x020015C2 RID: 5570
	[Token(Token = "0x2000F4B")]
	public struct UserPresence
	{
		// Token: 0x06007EA5 RID: 32421 RVA: 0x0002D5A0 File Offset: 0x0002B7A0
		[Token(Token = "0x600690A")]
		[Address(RVA = "0x365E20", Offset = "0x365F21", VA = "0x365E20")]
		public Result Initialize(Uid uid)
		{
			return default(Result);
		}

		// Token: 0x06007EA6 RID: 32422 RVA: 0x0002D5B8 File Offset: 0x0002B7B8
		[Token(Token = "0x600690B")]
		[Address(RVA = "0x365E40", Offset = "0x365F41", VA = "0x365E40")]
		public Result Initialize()
		{
			return default(Result);
		}

		// Token: 0x06007EA7 RID: 32423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600690C")]
		[Address(RVA = "0x365E60", Offset = "0x365F61", VA = "0x365E60")]
		public void Clear()
		{
		}

		// Token: 0x06007EA8 RID: 32424 RVA: 0x0002D5D0 File Offset: 0x0002B7D0
		[Token(Token = "0x600690D")]
		[Address(RVA = "0x365E70", Offset = "0x365F71", VA = "0x365E70")]
		public Result Commit()
		{
			return default(Result);
		}

		// Token: 0x06007EA9 RID: 32425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600690E")]
		[Address(RVA = "0x365E90", Offset = "0x365F91", VA = "0x365E90")]
		public void DeclareOpenOnlinePlaySession()
		{
		}

		// Token: 0x06007EAA RID: 32426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600690F")]
		[Address(RVA = "0x365EA0", Offset = "0x365FA1", VA = "0x365EA0")]
		public void DeclareCloseOnlinePlaySession()
		{
		}

		// Token: 0x06007EAB RID: 32427 RVA: 0x0002D5E8 File Offset: 0x0002B7E8
		[Token(Token = "0x6006910")]
		[Address(RVA = "0x365EB0", Offset = "0x365FB1", VA = "0x365EB0")]
		public Result SetDescription(string description)
		{
			return default(Result);
		}

		// Token: 0x06007EAC RID: 32428
		[Token(Token = "0x6006911")]
		[Address(RVA = "0x2858C20", Offset = "0x2858D21", VA = "0x2858C20")]
		[PreserveSig]
		private static extern Result Initialize(ref UserPresence pUserPresence, Uid uid);

		// Token: 0x06007EAD RID: 32429
		[Token(Token = "0x6006912")]
		[Address(RVA = "0x2858C60", Offset = "0x2858D61", VA = "0x2858C60")]
		[PreserveSig]
		private static extern Result Initialize(ref UserPresence pUserPresence);

		// Token: 0x06007EAE RID: 32430
		[Token(Token = "0x6006913")]
		[Address(RVA = "0x2858C90", Offset = "0x2858D91", VA = "0x2858C90")]
		[PreserveSig]
		private static extern void Clear(ref UserPresence pUserPresence);

		// Token: 0x06007EAF RID: 32431
		[Token(Token = "0x6006914")]
		[Address(RVA = "0x2858CC0", Offset = "0x2858DC1", VA = "0x2858CC0")]
		[PreserveSig]
		private static extern Result Commit(ref UserPresence pUserPresence);

		// Token: 0x06007EB0 RID: 32432
		[Token(Token = "0x6006915")]
		[Address(RVA = "0x2858CF0", Offset = "0x2858DF1", VA = "0x2858CF0")]
		[PreserveSig]
		private static extern void DeclareOpenOnlinePlaySession(ref UserPresence pUserPresence);

		// Token: 0x06007EB1 RID: 32433
		[Token(Token = "0x6006916")]
		[Address(RVA = "0x2858D10", Offset = "0x2858E11", VA = "0x2858D10")]
		[PreserveSig]
		private static extern void DeclareCloseOnlinePlaySession(ref UserPresence pUserPresence);

		// Token: 0x06007EB2 RID: 32434
		[Token(Token = "0x6006917")]
		[Address(RVA = "0x2858D70", Offset = "0x2858E71", VA = "0x2858D70")]
		[PreserveSig]
		private static extern Result SetDescription(ref UserPresence pUserPresence, [In] string description);
	}
}
