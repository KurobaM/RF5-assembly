using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using nn.account;

namespace nn.friends
{
	// Token: 0x020015C0 RID: 5568
	[Token(Token = "0x2000F49")]
	public struct Friend
	{
		// Token: 0x06007E81 RID: 32385 RVA: 0x0002D450 File Offset: 0x0002B650
		[Token(Token = "0x60068E6")]
		[Address(RVA = "0x364A80", Offset = "0x364B81", VA = "0x364A80")]
		public NetworkServiceAccountId GetAccountId()
		{
			return default(NetworkServiceAccountId);
		}

		// Token: 0x06007E82 RID: 32386 RVA: 0x0002D468 File Offset: 0x0002B668
		[Token(Token = "0x60068E7")]
		[Address(RVA = "0x364AC0", Offset = "0x364BC1", VA = "0x364AC0")]
		public Nickname GetNickname()
		{
			return default(Nickname);
		}

		// Token: 0x06007E83 RID: 32387 RVA: 0x0002D480 File Offset: 0x0002B680
		[Token(Token = "0x60068E8")]
		[Address(RVA = "0x364B20", Offset = "0x364C21", VA = "0x364B20")]
		public FriendPresence GetPresence()
		{
			return default(FriendPresence);
		}

		// Token: 0x06007E84 RID: 32388 RVA: 0x0002D498 File Offset: 0x0002B698
		[Token(Token = "0x60068E9")]
		[Address(RVA = "0x364BB0", Offset = "0x364CB1", VA = "0x364BB0")]
		public Result GetProfileImage(ref long outSize, byte[] buffer)
		{
			return default(Result);
		}

		// Token: 0x06007E85 RID: 32389 RVA: 0x0002D4B0 File Offset: 0x0002B6B0
		[Token(Token = "0x60068EA")]
		[Address(RVA = "0x364C30", Offset = "0x364D31", VA = "0x364C30")]
		public bool IsFavorite()
		{
			return default(bool);
		}

		// Token: 0x06007E86 RID: 32390 RVA: 0x0002D4C8 File Offset: 0x0002B6C8
		[Token(Token = "0x60068EB")]
		[Address(RVA = "0x364C70", Offset = "0x364D71", VA = "0x364C70")]
		public bool IsNewly()
		{
			return default(bool);
		}

		// Token: 0x06007E87 RID: 32391 RVA: 0x0002D4E0 File Offset: 0x0002B6E0
		[Token(Token = "0x60068EC")]
		[Address(RVA = "0x364CB0", Offset = "0x364DB1", VA = "0x364CB0")]
		public bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06007E88 RID: 32392 RVA: 0x0002D4F8 File Offset: 0x0002B6F8
		[Token(Token = "0x60068ED")]
		[Address(RVA = "0x364CF0", Offset = "0x364DF1", VA = "0x364CF0")]
		public Result Update()
		{
			return default(Result);
		}

		// Token: 0x06007E89 RID: 32393
		[Token(Token = "0x60068EE")]
		[Address(RVA = "0x2855740", Offset = "0x2855841", VA = "0x2855740")]
		[PreserveSig]
		private static extern NetworkServiceAccountId GetAccountId(Friend friend);

		// Token: 0x06007E8A RID: 32394
		[Token(Token = "0x60068EF")]
		[Address(RVA = "0x28557E0", Offset = "0x28558E1", VA = "0x28557E0")]
		[PreserveSig]
		private static extern Nickname GetNickname(Friend friend);

		// Token: 0x06007E8B RID: 32395
		[Token(Token = "0x60068F0")]
		[Address(RVA = "0x28558D0", Offset = "0x28559D1", VA = "0x28558D0")]
		[PreserveSig]
		private static extern void GetPresence(Friend friend, ref FriendPresence outPresence);

		// Token: 0x06007E8C RID: 32396
		[Token(Token = "0x60068F1")]
		[Address(RVA = "0x2855990", Offset = "0x2855A91", VA = "0x2855990")]
		[PreserveSig]
		private static extern Result GetProfileImage(Friend friend, ref long outSize, [In] [Out] byte[] outBuffer, long size);

		// Token: 0x06007E8D RID: 32397
		[Token(Token = "0x60068F2")]
		[Address(RVA = "0x2855A40", Offset = "0x2855B41", VA = "0x2855A40")]
		[PreserveSig]
		private static extern bool IsFavorite(Friend friend);

		// Token: 0x06007E8E RID: 32398
		[Token(Token = "0x60068F3")]
		[Address(RVA = "0x2855AC0", Offset = "0x2855BC1", VA = "0x2855AC0")]
		[PreserveSig]
		private static extern bool IsNewly(Friend friend);

		// Token: 0x06007E8F RID: 32399
		[Token(Token = "0x60068F4")]
		[Address(RVA = "0x2855B40", Offset = "0x2855C41", VA = "0x2855B40")]
		[PreserveSig]
		private static extern bool IsValid(Friend friend);

		// Token: 0x06007E90 RID: 32400
		[Token(Token = "0x60068F5")]
		[Address(RVA = "0x2855BA0", Offset = "0x2855CA1", VA = "0x2855BA0")]
		[PreserveSig]
		private static extern Result Update(ref Friend pFriend);
	}
}
