using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Farm
{
	// Token: 0x020010B1 RID: 4273
	[Token(Token = "0x2000AB9")]
	public class UniqueRandom
	{
		// Token: 0x06006C0C RID: 27660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059A6")]
		[Address(RVA = "0x21A6180", Offset = "0x21A6281", VA = "0x21A6180")]
		public UniqueRandom()
		{
		}

		// Token: 0x06006C0D RID: 27661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059A7")]
		[Address(RVA = "0x21A6260", Offset = "0x21A6361", VA = "0x21A6260")]
		public UniqueRandom(int seed)
		{
		}

		// Token: 0x06006C0E RID: 27662 RVA: 0x00025038 File Offset: 0x00023238
		[Token(Token = "0x60059A8")]
		[Address(RVA = "0x21A6330", Offset = "0x21A6431", VA = "0x21A6330")]
		public int getSeed()
		{
			return 0;
		}

		// Token: 0x06006C0F RID: 27663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059A9")]
		[Address(RVA = "0x21A62D0", Offset = "0x21A63D1", VA = "0x21A62D0")]
		public void setSeed(int seed)
		{
		}

		// Token: 0x06006C10 RID: 27664 RVA: 0x00025050 File Offset: 0x00023250
		[Token(Token = "0x60059AA")]
		[Address(RVA = "0x21A6340", Offset = "0x21A6441", VA = "0x21A6340")]
		public int Range(int min, int max)
		{
			return 0;
		}

		// Token: 0x04017467 RID: 95335
		[Token(Token = "0x4013FA0")]
		[FieldOffset(Offset = "0x10")]
		private UnityEngine.Random.State state;

		// Token: 0x04017468 RID: 95336
		[Token(Token = "0x4013FA1")]
		[FieldOffset(Offset = "0x20")]
		private int _seed;
	}
}
