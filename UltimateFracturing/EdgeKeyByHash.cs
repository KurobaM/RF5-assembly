using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UltimateFracturing
{
	// Token: 0x02000C48 RID: 3144
	[Token(Token = "0x2000801")]
	public struct EdgeKeyByHash
	{
		// Token: 0x06004FC8 RID: 20424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600420A")]
		[Address(RVA = "0x2EB440", Offset = "0x2EB541", VA = "0x2EB440")]
		public EdgeKeyByHash(int nHashA, int nHashB)
		{
		}

		// Token: 0x06004FC9 RID: 20425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600420B")]
		[Address(RVA = "0x2EB450", Offset = "0x2EB551", VA = "0x2EB450")]
		public void Set(int nHashA, int nHashB)
		{
		}

		// Token: 0x06004FCA RID: 20426 RVA: 0x000199F8 File Offset: 0x00017BF8
		[Token(Token = "0x600420C")]
		[Address(RVA = "0x2EB460", Offset = "0x2EB561", VA = "0x2EB460")]
		public bool CompareTo(int nHashA, int nHashB)
		{
			return default(bool);
		}

		// Token: 0x0400B08E RID: 45198
		[Token(Token = "0x4008464")]
		[FieldOffset(Offset = "0x0")]
		public int nHashA;

		// Token: 0x0400B08F RID: 45199
		[Token(Token = "0x4008465")]
		[FieldOffset(Offset = "0x4")]
		public int nHashB;

		// Token: 0x02000C49 RID: 3145
		[Token(Token = "0x20013C2")]
		public class EqualityComparer : IEqualityComparer<EdgeKeyByHash>
		{
			// Token: 0x06004FCB RID: 20427 RVA: 0x00019A10 File Offset: 0x00017C10
			[Token(Token = "0x600788C")]
			[Address(RVA = "0x23B98B0", Offset = "0x23B99B1", VA = "0x23B98B0", Slot = "4")]
			public bool Equals(EdgeKeyByHash x, EdgeKeyByHash y)
			{
				return default(bool);
			}

			// Token: 0x06004FCC RID: 20428 RVA: 0x00019A28 File Offset: 0x00017C28
			[Token(Token = "0x600788D")]
			[Address(RVA = "0x23B98F0", Offset = "0x23B99F1", VA = "0x23B98F0", Slot = "5")]
			public int GetHashCode(EdgeKeyByHash x)
			{
				return 0;
			}

			// Token: 0x06004FCD RID: 20429 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600788E")]
			[Address(RVA = "0x23B9940", Offset = "0x23B9A41", VA = "0x23B9940")]
			public EqualityComparer()
			{
			}
		}
	}
}
