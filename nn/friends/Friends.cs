using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using nn.account;

namespace nn.friends
{
	// Token: 0x020015BE RID: 5566
	[Token(Token = "0x2000F47")]
	public static class Friends
	{
		// Token: 0x06007E2A RID: 32298
		[Token(Token = "0x600688F")]
		[Address(RVA = "0x2856CB0", Offset = "0x2856DB1", VA = "0x2856CB0")]
		[PreserveSig]
		public static extern void Initialize();

		// Token: 0x06007E2B RID: 32299 RVA: 0x0002D018 File Offset: 0x0002B218
		[Token(Token = "0x6006890")]
		[Address(RVA = "0x2856CC0", Offset = "0x2856DC1", VA = "0x2856CC0")]
		public static Result GetFriendList(ref int outCount, NetworkServiceAccountId[] outAccountIds, Uid uid, int offset, FriendFilter filter)
		{
			return default(Result);
		}

		// Token: 0x06007E2C RID: 32300
		[Token(Token = "0x6006891")]
		[Address(RVA = "0x2856CF0", Offset = "0x2856DF1", VA = "0x2856CF0")]
		[PreserveSig]
		private static extern Result GetFriendList(ref int outCount, [In] [Out] NetworkServiceAccountId[] outAccountIds, Uid uid, int offset, int count, FriendFilter filter);

		// Token: 0x06007E2D RID: 32301 RVA: 0x0002D030 File Offset: 0x0002B230
		[Token(Token = "0x6006892")]
		[Address(RVA = "0x2856D20", Offset = "0x2856E21", VA = "0x2856D20")]
		public static Result GetFriendList(ref int outCount, NetworkServiceAccountId[] outAccountIds, int offset, FriendFilter filter)
		{
			return default(Result);
		}

		// Token: 0x06007E2E RID: 32302
		[Token(Token = "0x6006893")]
		[Address(RVA = "0x2856D50", Offset = "0x2856E51", VA = "0x2856D50")]
		[PreserveSig]
		private static extern Result GetFriendList(ref int outCount, [In] [Out] NetworkServiceAccountId[] outAccountIds, int offset, int count, FriendFilter filter);

		// Token: 0x06007E2F RID: 32303 RVA: 0x0002D048 File Offset: 0x0002B248
		[Token(Token = "0x6006894")]
		[Address(RVA = "0x2856D80", Offset = "0x2856E81", VA = "0x2856D80")]
		public static Result GetFriendList(ref int outCount, Friend[] outFriends, Uid uid, int offset, FriendFilter filter)
		{
			return default(Result);
		}

		// Token: 0x06007E30 RID: 32304
		[Token(Token = "0x6006895")]
		[Address(RVA = "0x2856DB0", Offset = "0x2856EB1", VA = "0x2856DB0")]
		[PreserveSig]
		private static extern Result GetFriendList(ref int outCount, [In] [Out] Friend[] outFriends, Uid uid, int offset, int count, FriendFilter filter);

		// Token: 0x06007E31 RID: 32305 RVA: 0x0002D060 File Offset: 0x0002B260
		[Token(Token = "0x6006896")]
		[Address(RVA = "0x2856DE0", Offset = "0x2856EE1", VA = "0x2856DE0")]
		public static Result GetFriendList(ref int outCount, Friend[] outFriends, int offset, FriendFilter filter)
		{
			return default(Result);
		}

		// Token: 0x06007E32 RID: 32306
		[Token(Token = "0x6006897")]
		[Address(RVA = "0x2856E10", Offset = "0x2856F11", VA = "0x2856E10")]
		[PreserveSig]
		private static extern Result GetFriendList(ref int outCount, [In] [Out] Friend[] outFriends, int offset, int count, FriendFilter filter);

		// Token: 0x06007E33 RID: 32307 RVA: 0x0002D078 File Offset: 0x0002B278
		[Token(Token = "0x6006898")]
		[Address(RVA = "0x2856E40", Offset = "0x2856F41", VA = "0x2856E40")]
		public static Result UpdateFriendInfo(Friend[] outFriends, Uid uid, NetworkServiceAccountId[] accountIds)
		{
			return default(Result);
		}

		// Token: 0x06007E34 RID: 32308
		[Token(Token = "0x6006899")]
		[Address(RVA = "0x2856E80", Offset = "0x2856F81", VA = "0x2856E80")]
		[PreserveSig]
		private static extern Result UpdateFriendInfo([In] [Out] Friend[] outFriends, Uid uid, [In] NetworkServiceAccountId[] accountIds, int count);

		// Token: 0x06007E35 RID: 32309 RVA: 0x0002D090 File Offset: 0x0002B290
		[Token(Token = "0x600689A")]
		[Address(RVA = "0x2856EB0", Offset = "0x2856FB1", VA = "0x2856EB0")]
		public static Result UpdateFriendInfo(Friend[] outFriends, NetworkServiceAccountId[] accountIds)
		{
			return default(Result);
		}

		// Token: 0x06007E36 RID: 32310
		[Token(Token = "0x600689B")]
		[Address(RVA = "0x2856EF0", Offset = "0x2856FF1", VA = "0x2856EF0")]
		[PreserveSig]
		private static extern Result UpdateFriendInfo([In] [Out] Friend[] outFriends, NetworkServiceAccountId[] accountIds, int count);

		// Token: 0x06007E37 RID: 32311 RVA: 0x0002D0A8 File Offset: 0x0002B2A8
		[Token(Token = "0x600689C")]
		[Address(RVA = "0x2856F20", Offset = "0x2857021", VA = "0x2856F20")]
		public static Result EnsureFriendListAvailable(AsyncContext outAsync, Uid uid)
		{
			return default(Result);
		}

		// Token: 0x06007E38 RID: 32312
		[Token(Token = "0x600689D")]
		[Address(RVA = "0x2856F50", Offset = "0x2857051", VA = "0x2856F50")]
		[PreserveSig]
		private static extern Result EnsureFriendListAvailable(IntPtr outAsync, Uid uid);

		// Token: 0x06007E39 RID: 32313 RVA: 0x0002D0C0 File Offset: 0x0002B2C0
		[Token(Token = "0x600689E")]
		[Address(RVA = "0x2856F70", Offset = "0x2857071", VA = "0x2856F70")]
		public static Result EnsureFriendListAvailable(AsyncContext outAsync)
		{
			return default(Result);
		}

		// Token: 0x06007E3A RID: 32314
		[Token(Token = "0x600689F")]
		[Address(RVA = "0x2856FA0", Offset = "0x28570A1", VA = "0x2856FA0")]
		[PreserveSig]
		private static extern Result EnsureFriendListAvailable(IntPtr outAsync);

		// Token: 0x06007E3B RID: 32315 RVA: 0x0002D0D8 File Offset: 0x0002B2D8
		[Token(Token = "0x60068A0")]
		[Address(RVA = "0x2856FC0", Offset = "0x28570C1", VA = "0x2856FC0")]
		public static Result GetBlockedUserList(ref int outCount, NetworkServiceAccountId[] outAccountIds, Uid uid, int offset)
		{
			return default(Result);
		}

		// Token: 0x06007E3C RID: 32316
		[Token(Token = "0x60068A1")]
		[Address(RVA = "0x2856FF0", Offset = "0x28570F1", VA = "0x2856FF0")]
		[PreserveSig]
		private static extern Result GetBlockedUserList(ref int outCount, [In] [Out] NetworkServiceAccountId[] outAccountIds, Uid uid, int offset, int count);

		// Token: 0x06007E3D RID: 32317 RVA: 0x0002D0F0 File Offset: 0x0002B2F0
		[Token(Token = "0x60068A2")]
		[Address(RVA = "0x2857020", Offset = "0x2857121", VA = "0x2857020")]
		public static Result GetBlockedUserList(ref int outCount, NetworkServiceAccountId[] outAccountIds, int offset)
		{
			return default(Result);
		}

		// Token: 0x06007E3E RID: 32318
		[Token(Token = "0x60068A3")]
		[Address(RVA = "0x2857050", Offset = "0x2857151", VA = "0x2857050")]
		[PreserveSig]
		private static extern Result GetBlockedUserList(ref int outCount, [In] [Out] NetworkServiceAccountId[] outAccountIds, int offset, int count);

		// Token: 0x06007E3F RID: 32319 RVA: 0x0002D108 File Offset: 0x0002B308
		[Token(Token = "0x60068A4")]
		[Address(RVA = "0x2857080", Offset = "0x2857181", VA = "0x2857080")]
		public static Result GetProfileList(AsyncContext outAsync, Profile[] outProfiles, Uid uid, NetworkServiceAccountId[] accountIds)
		{
			return default(Result);
		}

		// Token: 0x06007E40 RID: 32320 RVA: 0x0002D120 File Offset: 0x0002B320
		[Token(Token = "0x60068A5")]
		[Address(RVA = "0x28570F0", Offset = "0x28571F1", VA = "0x28570F0")]
		public static Result EnsureBlockedUserListAvailable(AsyncContext outAsync, Uid uid)
		{
			return default(Result);
		}

		// Token: 0x06007E41 RID: 32321
		[Token(Token = "0x60068A6")]
		[Address(RVA = "0x2857120", Offset = "0x2857221", VA = "0x2857120")]
		[PreserveSig]
		private static extern Result EnsureBlockedUserListAvailable(IntPtr outAsync, Uid uid);

		// Token: 0x06007E42 RID: 32322 RVA: 0x0002D138 File Offset: 0x0002B338
		[Token(Token = "0x60068A7")]
		[Address(RVA = "0x2857140", Offset = "0x2857241", VA = "0x2857140")]
		public static Result EnsureBlockedUserListAvailable(AsyncContext outAsync)
		{
			return default(Result);
		}

		// Token: 0x06007E43 RID: 32323
		[Token(Token = "0x60068A8")]
		[Address(RVA = "0x2857170", Offset = "0x2857271", VA = "0x2857170")]
		[PreserveSig]
		private static extern Result EnsureBlockedUserListAvailable(IntPtr outAsync);

		// Token: 0x06007E44 RID: 32324
		[Token(Token = "0x60068A9")]
		[Address(RVA = "0x28570C0", Offset = "0x28571C1", VA = "0x28570C0")]
		[PreserveSig]
		private static extern Result GetProfileList(IntPtr outAsync, [In] [Out] Profile[] outProfiles, Uid uid, [In] NetworkServiceAccountId[] accountIds, int count);

		// Token: 0x06007E45 RID: 32325 RVA: 0x0002D150 File Offset: 0x0002B350
		[Token(Token = "0x60068AA")]
		[Address(RVA = "0x2857190", Offset = "0x2857291", VA = "0x2857190")]
		public static Result GetProfileList(AsyncContext outAsync, Profile[] outProfiles, NetworkServiceAccountId[] accountIds)
		{
			return default(Result);
		}

		// Token: 0x06007E46 RID: 32326
		[Token(Token = "0x60068AB")]
		[Address(RVA = "0x28571D0", Offset = "0x28572D1", VA = "0x28571D0")]
		[PreserveSig]
		private static extern Result GetProfileList(IntPtr outAsync, [In] [Out] Profile[] outProfiles, [In] NetworkServiceAccountId[] accountIds, int count);

		// Token: 0x06007E47 RID: 32327
		[Token(Token = "0x60068AC")]
		[Address(RVA = "0x2857200", Offset = "0x2857301", VA = "0x2857200")]
		[PreserveSig]
		public static extern Result DeclareOpenOnlinePlaySession(Uid uid);

		// Token: 0x06007E48 RID: 32328
		[Token(Token = "0x60068AD")]
		[Address(RVA = "0x2857220", Offset = "0x2857321", VA = "0x2857220")]
		[PreserveSig]
		public static extern Result DeclareOpenOnlinePlaySession();

		// Token: 0x06007E49 RID: 32329
		[Token(Token = "0x60068AE")]
		[Address(RVA = "0x2857240", Offset = "0x2857341", VA = "0x2857240")]
		[PreserveSig]
		public static extern Result DeclareCloseOnlinePlaySession(Uid uid);

		// Token: 0x06007E4A RID: 32330
		[Token(Token = "0x60068AF")]
		[Address(RVA = "0x2857260", Offset = "0x2857361", VA = "0x2857260")]
		[PreserveSig]
		public static extern Result DeclareCloseOnlinePlaySession();

		// Token: 0x06007E4B RID: 32331
		[Token(Token = "0x60068B0")]
		[Address(RVA = "0x2857280", Offset = "0x2857381", VA = "0x2857280")]
		[PreserveSig]
		public static extern Result GetPlayHistoryRegistrationKey(ref PlayHistoryRegistrationKey outKey, Uid uid, bool isLocalPlay);

		// Token: 0x06007E4C RID: 32332
		[Token(Token = "0x60068B1")]
		[Address(RVA = "0x28572A0", Offset = "0x28573A1", VA = "0x28572A0")]
		[PreserveSig]
		public static extern Result GetPlayHistoryRegistrationKey(ref PlayHistoryRegistrationKey outKey, bool isLocalPlay);

		// Token: 0x06007E4D RID: 32333
		[Token(Token = "0x60068B2")]
		[Address(RVA = "0x28572C0", Offset = "0x28573C1", VA = "0x28572C0")]
		[PreserveSig]
		public static extern Result AddPlayHistory(Uid uid, PlayHistoryRegistrationKey key, InAppScreenName inAppScreenName, InAppScreenName myInAppScreenName);

		// Token: 0x06007E4E RID: 32334
		[Token(Token = "0x60068B3")]
		[Address(RVA = "0x28573D0", Offset = "0x28574D1", VA = "0x28573D0")]
		[PreserveSig]
		public static extern Result AddPlayHistory(PlayHistoryRegistrationKey key, InAppScreenName inAppScreenName, InAppScreenName myInAppScreenName);

		// Token: 0x06007E4F RID: 32335 RVA: 0x0002D168 File Offset: 0x0002B368
		[Token(Token = "0x60068B4")]
		[Address(RVA = "0x28574C0", Offset = "0x28575C1", VA = "0x28574C0")]
		public static bool TryPopFriendInvitationNotificationInfo(ref Uid pOutUid, ref long pOutSize, byte[] pOutBuffer)
		{
			return default(bool);
		}

		// Token: 0x06007E50 RID: 32336
		[Token(Token = "0x60068B5")]
		[Address(RVA = "0x28574F0", Offset = "0x28575F1", VA = "0x28574F0")]
		[PreserveSig]
		private static extern bool TryPopFriendInvitationNotificationInfo(ref Uid pOutUid, ref long pOutSize, [In] [Out] byte[] pOutBuffer, long bufferSize);

		// Token: 0x06007E51 RID: 32337
		[Token(Token = "0x60068B6")]
		[Address(RVA = "0x2857520", Offset = "0x2857621", VA = "0x2857520")]
		[PreserveSig]
		public static extern Result ShowFriendList(Uid uid);

		// Token: 0x06007E52 RID: 32338
		[Token(Token = "0x60068B7")]
		[Address(RVA = "0x2857540", Offset = "0x2857641", VA = "0x2857540")]
		[PreserveSig]
		public static extern Result ShowUserDetailInfo(Uid uid, NetworkServiceAccountId accountId, InAppScreenName myInAppScreenName, InAppScreenName inAppScreenName);

		// Token: 0x06007E53 RID: 32339
		[Token(Token = "0x60068B8")]
		[Address(RVA = "0x2857630", Offset = "0x2857731", VA = "0x2857630")]
		[PreserveSig]
		public static extern Result StartSendingFriendRequest(Uid uid, NetworkServiceAccountId accountId, InAppScreenName myInAppScreenName, InAppScreenName inAppScreenName);

		// Token: 0x06007E54 RID: 32340
		[Token(Token = "0x60068B9")]
		[Address(RVA = "0x2857720", Offset = "0x2857821", VA = "0x2857720")]
		[PreserveSig]
		public static extern Result ShowMethodsOfSendingFriendRequest(Uid uid);

		// Token: 0x06007E55 RID: 32341
		[Token(Token = "0x60068BA")]
		[Address(RVA = "0x2857740", Offset = "0x2857841", VA = "0x2857740")]
		[PreserveSig]
		public static extern Result StartFacedFriendRequest(Uid uid);

		// Token: 0x06007E56 RID: 32342
		[Token(Token = "0x60068BB")]
		[Address(RVA = "0x2857760", Offset = "0x2857861", VA = "0x2857760")]
		[PreserveSig]
		public static extern Result ShowReceivedFriendRequestList(Uid uid);

		// Token: 0x06007E57 RID: 32343
		[Token(Token = "0x60068BC")]
		[Address(RVA = "0x2857780", Offset = "0x2857881", VA = "0x2857780")]
		[PreserveSig]
		public static extern Result ShowBlockedUserList(Uid uid);

		// Token: 0x06007E58 RID: 32344 RVA: 0x0002D180 File Offset: 0x0002B380
		[Token(Token = "0x60068BD")]
		[Address(RVA = "0x28577A0", Offset = "0x28578A1", VA = "0x28577A0")]
		public static Result StartFriendInvitation(Uid uid, int maxInviteeCount, FriendInvitationGameModeDescription description, byte[] pAppParameter)
		{
			return default(Result);
		}

		// Token: 0x06007E59 RID: 32345
		[Token(Token = "0x60068BE")]
		[Address(RVA = "0x28578B0", Offset = "0x28579B1", VA = "0x28578B0")]
		[PreserveSig]
		private static extern Result StartFriendInvitation(Uid uid, int maxInviteeCount, FriendInvitationGameModeDescription description, [In] byte[] pAppParameter, long appParameterSize);

		// Token: 0x06007E5A RID: 32346 RVA: 0x0002D198 File Offset: 0x0002B398
		[Token(Token = "0x60068BF")]
		[Address(RVA = "0x28579C0", Offset = "0x2857AC1", VA = "0x28579C0")]
		public static Result StartSendingFriendInvitation(Uid uid, NetworkServiceAccountId[] pInvitees, FriendInvitationGameModeDescription description, byte[] pAppParameter)
		{
			return default(Result);
		}

		// Token: 0x06007E5B RID: 32347
		[Token(Token = "0x60068C0")]
		[Address(RVA = "0x2857AE0", Offset = "0x2857BE1", VA = "0x2857AE0")]
		[PreserveSig]
		private static extern Result StartSendingFriendInvitation(Uid uid, [In] NetworkServiceAccountId[] pInvitees, int inviteeCount, FriendInvitationGameModeDescription description, [In] byte[] pAppParameter, long appParameterSize);

		// Token: 0x17000F37 RID: 3895
		// (get) Token: 0x06007E5C RID: 32348 RVA: 0x0002D1B0 File Offset: 0x0002B3B0
		[Token(Token = "0x17000B71")]
		public static ErrorRange ResultNotInitialized
		{
			[Token(Token = "0x60068C1")]
			[Address(RVA = "0x2857C00", Offset = "0x2857D01", VA = "0x2857C00")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F38 RID: 3896
		// (get) Token: 0x06007E5D RID: 32349 RVA: 0x0002D1C8 File Offset: 0x0002B3C8
		[Token(Token = "0x17000B72")]
		public static ErrorRange ResultInvalidArgument
		{
			[Token(Token = "0x60068C2")]
			[Address(RVA = "0x2857C10", Offset = "0x2857D11", VA = "0x2857C10")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F39 RID: 3897
		// (get) Token: 0x06007E5E RID: 32350 RVA: 0x0002D1E0 File Offset: 0x0002B3E0
		[Token(Token = "0x17000B73")]
		public static ErrorRange ResultUserNotOpened
		{
			[Token(Token = "0x60068C3")]
			[Address(RVA = "0x2857C20", Offset = "0x2857D21", VA = "0x2857C20")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F3A RID: 3898
		// (get) Token: 0x06007E5F RID: 32351 RVA: 0x0002D1F8 File Offset: 0x0002B3F8
		[Token(Token = "0x17000B74")]
		public static ErrorRange ResultNetworkServiceAccountNotLinked
		{
			[Token(Token = "0x60068C4")]
			[Address(RVA = "0x2857C30", Offset = "0x2857D31", VA = "0x2857C30")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F3B RID: 3899
		// (get) Token: 0x06007E60 RID: 32352 RVA: 0x0002D210 File Offset: 0x0002B410
		[Token(Token = "0x17000B75")]
		public static ErrorRange ResultOwnNetworkServiceAccountSpecified
		{
			[Token(Token = "0x60068C5")]
			[Address(RVA = "0x2857C40", Offset = "0x2857D41", VA = "0x2857C40")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F3C RID: 3900
		// (get) Token: 0x06007E61 RID: 32353 RVA: 0x0002D228 File Offset: 0x0002B428
		[Token(Token = "0x17000B76")]
		public static ErrorRange ResultInternetRequestNotAccepted
		{
			[Token(Token = "0x60068C6")]
			[Address(RVA = "0x2857C50", Offset = "0x2857D51", VA = "0x2857C50")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F3D RID: 3901
		// (get) Token: 0x06007E62 RID: 32354 RVA: 0x0002D240 File Offset: 0x0002B440
		[Token(Token = "0x17000B77")]
		public static ErrorRange ResultNotCalled
		{
			[Token(Token = "0x60068C7")]
			[Address(RVA = "0x2857C60", Offset = "0x2857D61", VA = "0x2857C60")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F3E RID: 3902
		// (get) Token: 0x06007E63 RID: 32355 RVA: 0x0002D258 File Offset: 0x0002B458
		[Token(Token = "0x17000B78")]
		public static ErrorRange ResultCallInProgress
		{
			[Token(Token = "0x60068C8")]
			[Address(RVA = "0x2857C70", Offset = "0x2857D71", VA = "0x2857C70")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F3F RID: 3903
		// (get) Token: 0x06007E64 RID: 32356 RVA: 0x0002D270 File Offset: 0x0002B470
		[Token(Token = "0x17000B79")]
		public static ErrorRange ResultCanceled
		{
			[Token(Token = "0x60068C9")]
			[Address(RVA = "0x2857C80", Offset = "0x2857D81", VA = "0x2857C80")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F40 RID: 3904
		// (get) Token: 0x06007E65 RID: 32357 RVA: 0x0002D288 File Offset: 0x0002B488
		[Token(Token = "0x17000B7A")]
		public static ErrorRange ResultProfileImageCacheNotFound
		{
			[Token(Token = "0x60068CA")]
			[Address(RVA = "0x2857C90", Offset = "0x2857D91", VA = "0x2857C90")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F41 RID: 3905
		// (get) Token: 0x06007E66 RID: 32358 RVA: 0x0002D2A0 File Offset: 0x0002B4A0
		[Token(Token = "0x17000B7B")]
		public static ErrorRange ResultOutOfMemory
		{
			[Token(Token = "0x60068CB")]
			[Address(RVA = "0x2857CA0", Offset = "0x2857DA1", VA = "0x2857CA0")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F42 RID: 3906
		// (get) Token: 0x06007E67 RID: 32359 RVA: 0x0002D2B8 File Offset: 0x0002B4B8
		[Token(Token = "0x17000B7C")]
		public static ErrorRange ResultOutOfResource
		{
			[Token(Token = "0x60068CC")]
			[Address(RVA = "0x2857CB0", Offset = "0x2857DB1", VA = "0x2857CB0")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F43 RID: 3907
		// (get) Token: 0x06007E68 RID: 32360 RVA: 0x0002D2D0 File Offset: 0x0002B4D0
		[Token(Token = "0x17000B7D")]
		public static ErrorRange ResultReservedKey
		{
			[Token(Token = "0x60068CD")]
			[Address(RVA = "0x2857CC0", Offset = "0x2857DC1", VA = "0x2857CC0")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F44 RID: 3908
		// (get) Token: 0x06007E69 RID: 32361 RVA: 0x0002D2E8 File Offset: 0x0002B4E8
		[Token(Token = "0x17000B7E")]
		public static ErrorRange ResultDuplicatedKey
		{
			[Token(Token = "0x60068CE")]
			[Address(RVA = "0x2857CD0", Offset = "0x2857DD1", VA = "0x2857CD0")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F45 RID: 3909
		// (get) Token: 0x06007E6A RID: 32362 RVA: 0x0002D300 File Offset: 0x0002B500
		[Token(Token = "0x17000B7F")]
		public static ErrorRange ResultNotificationNotFound
		{
			[Token(Token = "0x60068CF")]
			[Address(RVA = "0x2857CE0", Offset = "0x2857DE1", VA = "0x2857CE0")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F46 RID: 3910
		// (get) Token: 0x06007E6B RID: 32363 RVA: 0x0002D318 File Offset: 0x0002B518
		[Token(Token = "0x17000B80")]
		public static ErrorRange ResultPlayHistoryRegistrationKeyBroken
		{
			[Token(Token = "0x60068D0")]
			[Address(RVA = "0x2857CF0", Offset = "0x2857DF1", VA = "0x2857CF0")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F47 RID: 3911
		// (get) Token: 0x06007E6C RID: 32364 RVA: 0x0002D330 File Offset: 0x0002B530
		[Token(Token = "0x17000B81")]
		public static ErrorRange ResultOwnPlayHistoryRegistrationKey
		{
			[Token(Token = "0x60068D1")]
			[Address(RVA = "0x2857D00", Offset = "0x2857E01", VA = "0x2857D00")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F48 RID: 3912
		// (get) Token: 0x06007E6D RID: 32365 RVA: 0x0002D348 File Offset: 0x0002B548
		[Token(Token = "0x17000B82")]
		public static ErrorRange ResultAppletCanceled
		{
			[Token(Token = "0x60068D2")]
			[Address(RVA = "0x2857D10", Offset = "0x2857E11", VA = "0x2857D10")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F49 RID: 3913
		// (get) Token: 0x06007E6E RID: 32366 RVA: 0x0002D360 File Offset: 0x0002B560
		[Token(Token = "0x17000B83")]
		public static ErrorRange ResultApplicationInfoNotRegistered
		{
			[Token(Token = "0x60068D3")]
			[Address(RVA = "0x2857D20", Offset = "0x2857E21", VA = "0x2857D20")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F4A RID: 3914
		// (get) Token: 0x06007E6F RID: 32367 RVA: 0x0002D378 File Offset: 0x0002B578
		[Token(Token = "0x17000B84")]
		public static ErrorRange ResultNotPermitted
		{
			[Token(Token = "0x60068D4")]
			[Address(RVA = "0x2857D30", Offset = "0x2857E31", VA = "0x2857D30")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F4B RID: 3915
		// (get) Token: 0x06007E70 RID: 32368 RVA: 0x0002D390 File Offset: 0x0002B590
		[Token(Token = "0x17000B85")]
		public static ErrorRange ResultInvalidOperation
		{
			[Token(Token = "0x60068D5")]
			[Address(RVA = "0x2857D40", Offset = "0x2857E41", VA = "0x2857D40")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F4C RID: 3916
		// (get) Token: 0x06007E71 RID: 32369 RVA: 0x0002D3A8 File Offset: 0x0002B5A8
		[Token(Token = "0x17000B86")]
		public static ErrorRange ResultNotImplemented
		{
			[Token(Token = "0x60068D6")]
			[Address(RVA = "0x2857D50", Offset = "0x2857E51", VA = "0x2857D50")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F4D RID: 3917
		// (get) Token: 0x06007E72 RID: 32370 RVA: 0x0002D3C0 File Offset: 0x0002B5C0
		[Token(Token = "0x17000B87")]
		public static ErrorRange ResultResponseFormatError
		{
			[Token(Token = "0x60068D7")]
			[Address(RVA = "0x2857D60", Offset = "0x2857E61", VA = "0x2857D60")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F4E RID: 3918
		// (get) Token: 0x06007E73 RID: 32371 RVA: 0x0002D3D8 File Offset: 0x0002B5D8
		[Token(Token = "0x17000B88")]
		public static ErrorRange ResultHttpError
		{
			[Token(Token = "0x60068D8")]
			[Address(RVA = "0x2857D70", Offset = "0x2857E71", VA = "0x2857D70")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F4F RID: 3919
		// (get) Token: 0x06007E74 RID: 32372 RVA: 0x0002D3F0 File Offset: 0x0002B5F0
		[Token(Token = "0x17000B89")]
		public static ErrorRange ResultServerError
		{
			[Token(Token = "0x60068D9")]
			[Address(RVA = "0x2857D80", Offset = "0x2857E81", VA = "0x2857D80")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x0401C0FA RID: 114938
		[Token(Token = "0x4018953")]
		public const int FriendCountMax = 300;

		// Token: 0x0401C0FB RID: 114939
		[Token(Token = "0x4018954")]
		public const int BlockedUserCountMax = 100;

		// Token: 0x0401C0FC RID: 114940
		[Token(Token = "0x4018955")]
		public const long PresenceAppFieldSize = 192L;

		// Token: 0x0401C0FD RID: 114941
		[Token(Token = "0x4018956")]
		public const int InAppScreenNameLengthMax = 20;

		// Token: 0x0401C0FE RID: 114942
		[Token(Token = "0x4018957")]
		public const int GetProfileCountMax = 100;

		// Token: 0x0401C0FF RID: 114943
		[Token(Token = "0x4018958")]
		public const long ProfileImageSizeMax = 131072L;

		// Token: 0x0401C100 RID: 114944
		[Token(Token = "0x4018959")]
		public const int NotificationCountMax = 100;

		// Token: 0x0401C101 RID: 114945
		[Token(Token = "0x401895A")]
		public const int FriendInvitationInviteeCountMax = 16;

		// Token: 0x0401C102 RID: 114946
		[Token(Token = "0x401895B")]
		public const long FriendInvitationApplicationParameterSizeMax = 1024L;
	}
}
