using System;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;

namespace nn.friends
{
	// Token: 0x020015C3 RID: 5571
	[Token(Token = "0x2000F4C")]
	public struct FriendPresence
	{
		// Token: 0x06007EB3 RID: 32435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006918")]
		[Address(RVA = "0x365880", Offset = "0x365981", VA = "0x365880")]
		public string GetDescription()
		{
			return null;
		}

		// Token: 0x06007EB4 RID: 32436 RVA: 0x0002D600 File Offset: 0x0002B800
		[Token(Token = "0x6006919")]
		[Address(RVA = "0x365890", Offset = "0x365991", VA = "0x365890")]
		public ApplicationInfo GetLastPlayedApplication()
		{
			return default(ApplicationInfo);
		}

		// Token: 0x06007EB5 RID: 32437 RVA: 0x0002D618 File Offset: 0x0002B818
		[Token(Token = "0x600691A")]
		[Address(RVA = "0x3658C0", Offset = "0x3659C1", VA = "0x3658C0")]
		public long GetLastUpdatePosixTime()
		{
			return 0L;
		}

		// Token: 0x06007EB6 RID: 32438 RVA: 0x0002D630 File Offset: 0x0002B830
		[Token(Token = "0x600691B")]
		[Address(RVA = "0x3658F0", Offset = "0x3659F1", VA = "0x3658F0")]
		public PresenceStatus GetStatus()
		{
			return PresenceStatus.Offline;
		}

		// Token: 0x06007EB7 RID: 32439 RVA: 0x0002D648 File Offset: 0x0002B848
		[Token(Token = "0x600691C")]
		[Address(RVA = "0x365920", Offset = "0x365A21", VA = "0x365920")]
		public bool IsSamePresenceGroupApplication()
		{
			return default(bool);
		}

		// Token: 0x06007EB8 RID: 32440
		[Token(Token = "0x600691D")]
		[Address(RVA = "0x2856A90", Offset = "0x2856B91", VA = "0x2856A90")]
		[PreserveSig]
		private static extern void GetDescription(FriendPresence pFriendPresence, [In] [Out] StringBuilder description, long size);

		// Token: 0x06007EB9 RID: 32441
		[Token(Token = "0x600691E")]
		[Address(RVA = "0x2856B40", Offset = "0x2856C41", VA = "0x2856B40")]
		[PreserveSig]
		private static extern ApplicationInfo GetLastPlayedApplication(FriendPresence pFriendPresence);

		// Token: 0x06007EBA RID: 32442
		[Token(Token = "0x600691F")]
		[Address(RVA = "0x2856BA0", Offset = "0x2856CA1", VA = "0x2856BA0")]
		[PreserveSig]
		private static extern long GetLastUpdatePosixTime(FriendPresence pFriendPresence);

		// Token: 0x06007EBB RID: 32443
		[Token(Token = "0x6006920")]
		[Address(RVA = "0x2856C00", Offset = "0x2856D01", VA = "0x2856C00")]
		[PreserveSig]
		private static extern PresenceStatus GetStatus(FriendPresence pFriendPresence);

		// Token: 0x06007EBC RID: 32444
		[Token(Token = "0x6006921")]
		[Address(RVA = "0x2856C70", Offset = "0x2856D71", VA = "0x2856C70")]
		[PreserveSig]
		private static extern bool IsSamePresenceGroupApplication(FriendPresence pFriendPresence);
	}
}
