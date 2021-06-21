using System;
using Il2CppDummyDll;

namespace nn.friends
{
	// Token: 0x020015CA RID: 5578
	[Token(Token = "0x2000F53")]
	public struct FriendFilter
	{
		// Token: 0x06007ECB RID: 32459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006930")]
		[Address(RVA = "0x364D10", Offset = "0x364E11", VA = "0x364D10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0401C11A RID: 114970
		[Token(Token = "0x4018973")]
		[FieldOffset(Offset = "0x0")]
		public PresenceStatusFilter presenceStatus;

		// Token: 0x0401C11B RID: 114971
		[Token(Token = "0x4018974")]
		[FieldOffset(Offset = "0x4")]
		public bool isFavoriteOnly;

		// Token: 0x0401C11C RID: 114972
		[Token(Token = "0x4018975")]
		[FieldOffset(Offset = "0x5")]
		public bool isSameAppPresenceOnly;

		// Token: 0x0401C11D RID: 114973
		[Token(Token = "0x4018976")]
		[FieldOffset(Offset = "0x6")]
		public bool isSameAppPlayedOnly;

		// Token: 0x0401C11E RID: 114974
		[Token(Token = "0x4018977")]
		[FieldOffset(Offset = "0x7")]
		public bool isArbitraryAppPlayedOnly;

		// Token: 0x0401C11F RID: 114975
		[Token(Token = "0x4018978")]
		[FieldOffset(Offset = "0x8")]
		public ulong presenceGroupId;
	}
}
