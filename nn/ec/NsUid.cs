using System;
using Il2CppDummyDll;

namespace nn.ec
{
	// Token: 0x020015E2 RID: 5602
	[Token(Token = "0x2000F68")]
	public struct NsUid : IEquatable<NsUid>
	{
		// Token: 0x06007F9E RID: 32670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069F2")]
		[Address(RVA = "0x3646A0", Offset = "0x3647A1", VA = "0x3646A0")]
		public NsUid(ulong _value)
		{
		}

		// Token: 0x06007F9F RID: 32671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069F3")]
		[Address(RVA = "0x3646B0", Offset = "0x3647B1", VA = "0x3646B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007FA0 RID: 32672 RVA: 0x0002DBA0 File Offset: 0x0002BDA0
		[Token(Token = "0x60069F4")]
		[Address(RVA = "0x2853B80", Offset = "0x2853C81", VA = "0x2853B80")]
		public static NsUid GetInvalidId()
		{
			return default(NsUid);
		}

		// Token: 0x06007FA1 RID: 32673 RVA: 0x0002DBB8 File Offset: 0x0002BDB8
		[Token(Token = "0x60069F5")]
		[Address(RVA = "0x3646C0", Offset = "0x3647C1", VA = "0x3646C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06007FA2 RID: 32674 RVA: 0x0002DBD0 File Offset: 0x0002BDD0
		[Token(Token = "0x60069F6")]
		[Address(RVA = "0x364770", Offset = "0x364871", VA = "0x364770", Slot = "4")]
		public bool Equals(NsUid other)
		{
			return default(bool);
		}

		// Token: 0x06007FA3 RID: 32675 RVA: 0x0002DBE8 File Offset: 0x0002BDE8
		[Token(Token = "0x60069F7")]
		[Address(RVA = "0x364780", Offset = "0x364881", VA = "0x364780", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007FA4 RID: 32676 RVA: 0x0002DC00 File Offset: 0x0002BE00
		[Token(Token = "0x60069F8")]
		[Address(RVA = "0x2853C50", Offset = "0x2853D51", VA = "0x2853C50")]
		public static bool operator ==(NsUid lhs, NsUid rhs)
		{
			return default(bool);
		}

		// Token: 0x06007FA5 RID: 32677 RVA: 0x0002DC18 File Offset: 0x0002BE18
		[Token(Token = "0x60069F9")]
		[Address(RVA = "0x2853CE0", Offset = "0x2853DE1", VA = "0x2853CE0")]
		public static bool operator !=(NsUid lhs, NsUid rhs)
		{
			return default(bool);
		}

		// Token: 0x0401C159 RID: 115033
		[Token(Token = "0x401899B")]
		[FieldOffset(Offset = "0x0")]
		public ulong value;
	}
}
