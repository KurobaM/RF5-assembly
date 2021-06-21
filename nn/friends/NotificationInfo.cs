using System;
using Il2CppDummyDll;
using nn.account;

namespace nn.friends
{
	// Token: 0x020015CD RID: 5581
	[Token(Token = "0x2000F56")]
	public struct NotificationInfo
	{
		// Token: 0x06007ECE RID: 32462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006933")]
		[Address(RVA = "0x365C70", Offset = "0x365D71", VA = "0x365C70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0401C123 RID: 114979
		[Token(Token = "0x401897C")]
		[FieldOffset(Offset = "0x0")]
		public NotificationType type;

		// Token: 0x0401C124 RID: 114980
		[Token(Token = "0x401897D")]
		[FieldOffset(Offset = "0x8")]
		public NetworkServiceAccountId accountId;
	}
}
