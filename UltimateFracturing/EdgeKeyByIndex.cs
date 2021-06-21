using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UltimateFracturing
{
	// Token: 0x02000C46 RID: 3142
	[Token(Token = "0x2000800")]
	public struct EdgeKeyByIndex
	{
		// Token: 0x06004FC2 RID: 20418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004207")]
		[Address(RVA = "0x2EB4B0", Offset = "0x2EB5B1", VA = "0x2EB4B0")]
		public EdgeKeyByIndex(int nIndexA, int nIndexB)
		{
		}

		// Token: 0x06004FC3 RID: 20419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004208")]
		[Address(RVA = "0x2EB4C0", Offset = "0x2EB5C1", VA = "0x2EB4C0")]
		public void Set(int nIndexA, int nIndexB)
		{
		}

		// Token: 0x06004FC4 RID: 20420 RVA: 0x000199B0 File Offset: 0x00017BB0
		[Token(Token = "0x6004209")]
		[Address(RVA = "0x2EB4D0", Offset = "0x2EB5D1", VA = "0x2EB4D0")]
		public bool CompareTo(int nIndexA, int nIndexB)
		{
			return default(bool);
		}

		// Token: 0x0400B08C RID: 45196
		[Token(Token = "0x4008462")]
		[FieldOffset(Offset = "0x0")]
		public int nIndexA;

		// Token: 0x0400B08D RID: 45197
		[Token(Token = "0x4008463")]
		[FieldOffset(Offset = "0x4")]
		public int nIndexB;

		// Token: 0x02000C47 RID: 3143
		[Token(Token = "0x20013C1")]
		public class EqualityComparer : IEqualityComparer<EdgeKeyByIndex>
		{
			// Token: 0x06004FC5 RID: 20421 RVA: 0x000199C8 File Offset: 0x00017BC8
			[Token(Token = "0x6007889")]
			[Address(RVA = "0x23B99C0", Offset = "0x23B9AC1", VA = "0x23B99C0", Slot = "4")]
			public bool Equals(EdgeKeyByIndex x, EdgeKeyByIndex y)
			{
				return default(bool);
			}

			// Token: 0x06004FC6 RID: 20422 RVA: 0x000199E0 File Offset: 0x00017BE0
			[Token(Token = "0x600788A")]
			[Address(RVA = "0x23B9A00", Offset = "0x23B9B01", VA = "0x23B9A00", Slot = "5")]
			public int GetHashCode(EdgeKeyByIndex x)
			{
				return 0;
			}

			// Token: 0x06004FC7 RID: 20423 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600788B")]
			[Address(RVA = "0x23B9A50", Offset = "0x23B9B51", VA = "0x23B9A50")]
			public EqualityComparer()
			{
			}
		}
	}
}
