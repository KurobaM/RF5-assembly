using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BossData
{
	// Token: 0x02000F2B RID: 3883
	[Token(Token = "0x20009E4")]
	[Serializable]
	public class LotteryBossBehaviorParams<TBehavior, TLotteryType> where TBehavior : LotteryBossBehavior<TLotteryType> where TLotteryType : Enum
	{
		// Token: 0x06006525 RID: 25893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005406")]
		public BossBehaviorParams GetBossBehaviorParams()
		{
			return null;
		}

		// Token: 0x06006526 RID: 25894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005407")]
		public LotteryBossBehaviorParams()
		{
		}

		// Token: 0x0400C507 RID: 50439
		[Token(Token = "0x4009341")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		public TBehavior[] BehaviorParams;
	}
}
