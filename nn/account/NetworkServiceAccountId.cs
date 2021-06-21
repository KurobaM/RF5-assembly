using System;
using Il2CppDummyDll;

namespace nn.account
{
	// Token: 0x020015F1 RID: 5617
	[Token(Token = "0x2000F74")]
	public struct NetworkServiceAccountId : IEquatable<NetworkServiceAccountId>
	{
		// Token: 0x0600800C RID: 32780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A4A")]
		[Address(RVA = "0x363B20", Offset = "0x363C21", VA = "0x363B20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600800D RID: 32781 RVA: 0x0002DFF0 File Offset: 0x0002C1F0
		[Token(Token = "0x6006A4B")]
		[Address(RVA = "0x363BA0", Offset = "0x363CA1", VA = "0x363BA0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600800E RID: 32782 RVA: 0x0002E008 File Offset: 0x0002C208
		[Token(Token = "0x6006A4C")]
		[Address(RVA = "0x363C50", Offset = "0x363D51", VA = "0x363C50", Slot = "4")]
		public bool Equals(NetworkServiceAccountId other)
		{
			return default(bool);
		}

		// Token: 0x0600800F RID: 32783 RVA: 0x0002E020 File Offset: 0x0002C220
		[Token(Token = "0x6006A4D")]
		[Address(RVA = "0x363C60", Offset = "0x363D61", VA = "0x363C60", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06008010 RID: 32784 RVA: 0x0002E038 File Offset: 0x0002C238
		[Token(Token = "0x6006A4E")]
		[Address(RVA = "0x2850A30", Offset = "0x2850B31", VA = "0x2850A30")]
		public static bool operator ==(NetworkServiceAccountId lhs, NetworkServiceAccountId rhs)
		{
			return default(bool);
		}

		// Token: 0x06008011 RID: 32785 RVA: 0x0002E050 File Offset: 0x0002C250
		[Token(Token = "0x6006A4F")]
		[Address(RVA = "0x2850AC0", Offset = "0x2850BC1", VA = "0x2850AC0")]
		public static bool operator !=(NetworkServiceAccountId lhs, NetworkServiceAccountId rhs)
		{
			return default(bool);
		}

		// Token: 0x0401C183 RID: 115075
		[Token(Token = "0x40189B4")]
		[FieldOffset(Offset = "0x0")]
		public ulong id;
	}
}
