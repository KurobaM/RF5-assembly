using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BossData
{
	// Token: 0x02000F26 RID: 3878
	[Token(Token = "0x20009DF")]
	[Serializable]
	public class BossLotteryParam<T>
	{
		// Token: 0x06006520 RID: 25888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005401")]
		public BossLotteryParam()
		{
		}

		// Token: 0x0400C4F1 RID: 50417
		[Token(Token = "0x400932B")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		public T Index;

		// Token: 0x0400C4F2 RID: 50418
		[Token(Token = "0x400932C")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		public float Weight;
	}
}
