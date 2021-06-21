using System;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using nn.account;

namespace nn.friends
{
	// Token: 0x020015C4 RID: 5572
	[Token(Token = "0x2000F4D")]
	public struct Profile
	{
		// Token: 0x06007EBD RID: 32445 RVA: 0x0002D660 File Offset: 0x0002B860
		[Token(Token = "0x6006922")]
		[Address(RVA = "0x365D20", Offset = "0x365E21", VA = "0x365D20")]
		public NetworkServiceAccountId GetAccountId()
		{
			return default(NetworkServiceAccountId);
		}

		// Token: 0x06007EBE RID: 32446 RVA: 0x0002D678 File Offset: 0x0002B878
		[Token(Token = "0x6006923")]
		[Address(RVA = "0x365D60", Offset = "0x365E61", VA = "0x365D60")]
		public Nickname GetNickname()
		{
			return default(Nickname);
		}

		// Token: 0x06007EBF RID: 32447 RVA: 0x0002D690 File Offset: 0x0002B890
		[Token(Token = "0x6006924")]
		[Address(RVA = "0x365DC0", Offset = "0x365EC1", VA = "0x365DC0")]
		public Result GetProfileImageUrl(ref string outUrl, ImageSize imageSize)
		{
			return default(Result);
		}

		// Token: 0x06007EC0 RID: 32448 RVA: 0x0002D6A8 File Offset: 0x0002B8A8
		[Token(Token = "0x6006925")]
		[Address(RVA = "0x365DE0", Offset = "0x365EE1", VA = "0x365DE0")]
		public bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06007EC1 RID: 32449
		[Token(Token = "0x6006926")]
		[Address(RVA = "0x28588E0", Offset = "0x28589E1", VA = "0x28588E0")]
		[PreserveSig]
		private static extern NetworkServiceAccountId GetAccountId(Profile profile);

		// Token: 0x06007EC2 RID: 32450
		[Token(Token = "0x6006927")]
		[Address(RVA = "0x2858980", Offset = "0x2858A81", VA = "0x2858980")]
		[PreserveSig]
		private static extern Nickname GetNickname(Profile profile);

		// Token: 0x06007EC3 RID: 32451
		[Token(Token = "0x6006928")]
		[Address(RVA = "0x2858AF0", Offset = "0x2858BF1", VA = "0x2858AF0")]
		[PreserveSig]
		private static extern Result GetProfileImageUrl(Profile profile, [In] [Out] StringBuilder outUrl, ImageSize imageSize);

		// Token: 0x06007EC4 RID: 32452
		[Token(Token = "0x6006929")]
		[Address(RVA = "0x2858BC0", Offset = "0x2858CC1", VA = "0x2858BC0")]
		[PreserveSig]
		private static extern bool IsValid(Profile profile);
	}
}
