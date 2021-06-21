using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace nn.account
{
	// Token: 0x020015E8 RID: 5608
	[Token(Token = "0x2000F6D")]
	public static class Account
	{
		// Token: 0x06007FB2 RID: 32690
		[Token(Token = "0x6006A06")]
		[Address(RVA = "0x284FC10", Offset = "0x284FD11", VA = "0x284FC10")]
		[PreserveSig]
		public static extern Result GetUserCount(ref int pOutCount);

		// Token: 0x06007FB3 RID: 32691
		[Token(Token = "0x6006A07")]
		[Address(RVA = "0x284FC30", Offset = "0x284FD31", VA = "0x284FC30")]
		[PreserveSig]
		public static extern Result GetUserExistence(ref bool pOutExistence, Uid user);

		// Token: 0x06007FB4 RID: 32692 RVA: 0x0002DC30 File Offset: 0x0002BE30
		[Token(Token = "0x6006A08")]
		[Address(RVA = "0x284FC50", Offset = "0x284FD51", VA = "0x284FC50")]
		public static Result ListAllUsers(ref int pOutActualLength, Uid[] outUsers)
		{
			return default(Result);
		}

		// Token: 0x06007FB5 RID: 32693
		[Token(Token = "0x6006A09")]
		[Address(RVA = "0x284FD00", Offset = "0x284FE01", VA = "0x284FD00")]
		[PreserveSig]
		private static extern Result ListAllUsers(ref int pOutActualLength, [Out] Uid[] outUsers, int arrayLength);

		// Token: 0x06007FB6 RID: 32694 RVA: 0x0002DC48 File Offset: 0x0002BE48
		[Token(Token = "0x6006A0A")]
		[Address(RVA = "0x284FDD0", Offset = "0x284FED1", VA = "0x284FDD0")]
		public static Result ListOpenUsers(ref int pOutActualLength, Uid[] outUsers)
		{
			return default(Result);
		}

		// Token: 0x06007FB7 RID: 32695
		[Token(Token = "0x6006A0B")]
		[Address(RVA = "0x284FE80", Offset = "0x284FF81", VA = "0x284FE80")]
		[PreserveSig]
		private static extern Result ListOpenUsers(ref int pOutActualLength, [Out] Uid[] outUsers, int arrayLength);

		// Token: 0x06007FB8 RID: 32696
		[Token(Token = "0x6006A0C")]
		[Address(RVA = "0x284FF50", Offset = "0x2850051", VA = "0x284FF50")]
		[PreserveSig]
		public static extern Result GetLastOpenedUser(ref Uid pOutUser);

		// Token: 0x06007FB9 RID: 32697
		[Token(Token = "0x6006A0D")]
		[Address(RVA = "0x284FF70", Offset = "0x2850071", VA = "0x284FF70")]
		[PreserveSig]
		public static extern Result GetNickname(ref Nickname pOut, Uid user);

		// Token: 0x06007FBA RID: 32698 RVA: 0x0002DC60 File Offset: 0x0002BE60
		[Token(Token = "0x6006A0E")]
		[Address(RVA = "0x2850010", Offset = "0x2850111", VA = "0x2850010")]
		public static Result LoadProfileImage(ref long pOutActualSize, byte[] outImage, Uid user)
		{
			return default(Result);
		}

		// Token: 0x06007FBB RID: 32699
		[Token(Token = "0x6006A0F")]
		[Address(RVA = "0x2850040", Offset = "0x2850141", VA = "0x2850040")]
		[PreserveSig]
		private static extern Result LoadProfileImage(ref long pOutActualSize, byte[] outImage, long bufferSize, Uid user);

		// Token: 0x06007FBC RID: 32700
		[Token(Token = "0x6006A10")]
		[Address(RVA = "0x2850070", Offset = "0x2850171", VA = "0x2850070")]
		[PreserveSig]
		public static extern void Initialize();

		// Token: 0x06007FBD RID: 32701
		[Token(Token = "0x6006A11")]
		[Address(RVA = "0x2850080", Offset = "0x2850181", VA = "0x2850080")]
		[PreserveSig]
		public static extern Result OpenUser(ref UserHandle pOutHandle, Uid user);

		// Token: 0x06007FBE RID: 32702
		[Token(Token = "0x6006A12")]
		[Address(RVA = "0x28500A0", Offset = "0x28501A1", VA = "0x28500A0")]
		[PreserveSig]
		public static extern bool TryOpenPreselectedUser(ref UserHandle pOutHandle);

		// Token: 0x06007FBF RID: 32703
		[Token(Token = "0x6006A13")]
		[Address(RVA = "0x28500C0", Offset = "0x28501C1", VA = "0x28500C0")]
		[PreserveSig]
		public static extern Result ListQualifiedUsers(ref int pOutActualLength, Uid[] outUsers, int arrayLength);

		// Token: 0x06007FC0 RID: 32704
		[Token(Token = "0x6006A14")]
		[Address(RVA = "0x28500F0", Offset = "0x28501F1", VA = "0x28500F0")]
		[PreserveSig]
		public static extern void CloseUser(UserHandle handle);

		// Token: 0x06007FC1 RID: 32705
		[Token(Token = "0x6006A15")]
		[Address(RVA = "0x2850120", Offset = "0x2850221", VA = "0x2850120")]
		[PreserveSig]
		public static extern Result GetUserId(ref Uid pOut, UserHandle handle);

		// Token: 0x06007FC2 RID: 32706 RVA: 0x0002DC78 File Offset: 0x0002BE78
		[Token(Token = "0x6006A16")]
		[Address(RVA = "0x2850160", Offset = "0x2850261", VA = "0x2850160")]
		public static Result StoreSaveDataThumbnailImage(Uid user, byte[] imageBuffer)
		{
			return default(Result);
		}

		// Token: 0x06007FC3 RID: 32707
		[Token(Token = "0x6006A17")]
		[Address(RVA = "0x2850190", Offset = "0x2850291", VA = "0x2850190")]
		[PreserveSig]
		private static extern Result StoreSaveDataThumbnailImage(Uid user, byte[] imageBuffer, long imageBufferSize);

		// Token: 0x06007FC4 RID: 32708
		[Token(Token = "0x6006A18")]
		[Address(RVA = "0x28501C0", Offset = "0x28502C1", VA = "0x28501C0")]
		[PreserveSig]
		public static extern Result DeleteSaveDataThumbnailImage(Uid user);

		// Token: 0x17000F75 RID: 3957
		// (get) Token: 0x06007FC5 RID: 32709 RVA: 0x0002DC90 File Offset: 0x0002BE90
		[Token(Token = "0x17000BAF")]
		public static ErrorRange ResultCancelled
		{
			[Token(Token = "0x6006A19")]
			[Address(RVA = "0x28501E0", Offset = "0x28502E1", VA = "0x28501E0")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F76 RID: 3958
		// (get) Token: 0x06007FC6 RID: 32710 RVA: 0x0002DCA8 File Offset: 0x0002BEA8
		[Token(Token = "0x17000BB0")]
		public static ErrorRange ResultCancelledByUser
		{
			[Token(Token = "0x6006A1A")]
			[Address(RVA = "0x28501F0", Offset = "0x28502F1", VA = "0x28501F0")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x17000F77 RID: 3959
		// (get) Token: 0x06007FC7 RID: 32711 RVA: 0x0002DCC0 File Offset: 0x0002BEC0
		[Token(Token = "0x17000BB1")]
		public static ErrorRange ResultUserNotExist
		{
			[Token(Token = "0x6006A1B")]
			[Address(RVA = "0x2850200", Offset = "0x2850301", VA = "0x2850200")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x06007FC8 RID: 32712
		[Token(Token = "0x6006A1C")]
		[Address(RVA = "0x2850210", Offset = "0x2850311", VA = "0x2850210")]
		[PreserveSig]
		public static extern Result ShowUserSelector(ref Uid pOut, UserSelectionSettings arg);

		// Token: 0x06007FC9 RID: 32713
		[Token(Token = "0x6006A1D")]
		[Address(RVA = "0x2850250", Offset = "0x2850351", VA = "0x2850250")]
		[PreserveSig]
		public static extern Result ShowUserSelector(ref Uid pOut);

		// Token: 0x06007FCA RID: 32714
		[Token(Token = "0x6006A1E")]
		[Address(RVA = "0x2850270", Offset = "0x2850371", VA = "0x2850270")]
		[PreserveSig]
		public static extern Result ShowUserCreator();

		// Token: 0x06007FCB RID: 32715 RVA: 0x0002DCD8 File Offset: 0x0002BED8
		[Token(Token = "0x6006A1F")]
		[Address(RVA = "0x2850290", Offset = "0x2850391", VA = "0x2850290")]
		public static Result ShowUserSelector(ref Uid pOut, UserSelectionSettings arg, bool suspendUnityThreads)
		{
			return default(Result);
		}

		// Token: 0x06007FCC RID: 32716 RVA: 0x0002DCF0 File Offset: 0x0002BEF0
		[Token(Token = "0x6006A20")]
		[Address(RVA = "0x2850320", Offset = "0x2850421", VA = "0x2850320")]
		public static Result ShowUserSelector(ref Uid pOut, bool suspendUnityThreads)
		{
			return default(Result);
		}

		// Token: 0x06007FCD RID: 32717 RVA: 0x0002DD08 File Offset: 0x0002BF08
		[Token(Token = "0x6006A21")]
		[Address(RVA = "0x2850380", Offset = "0x2850481", VA = "0x2850380")]
		public static Result ShowUserCreator(bool suspendUnityThreads)
		{
			return default(Result);
		}

		// Token: 0x0401C165 RID: 115045
		[Token(Token = "0x40189A2")]
		public const int UserCountMax = 8;

		// Token: 0x0401C166 RID: 115046
		[Token(Token = "0x40189A3")]
		public const int ProfileImageBytesMax = 131072;

		// Token: 0x0401C167 RID: 115047
		[Token(Token = "0x40189A4")]
		public const int SaveDataThumbnailImageBytesMax = 147456;
	}
}
