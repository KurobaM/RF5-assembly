using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace BossData
{
	// Token: 0x02000F2C RID: 3884
	[Token(Token = "0x20009E5")]
	[Serializable]
	public class LotteryBossBehaviorPramsList<TParams, TBehavior, TLotteryType> where TParams : LotteryBossBehaviorParams<TBehavior, TLotteryType> where TBehavior : LotteryBossBehavior<TLotteryType> where TLotteryType : Enum
	{
		// Token: 0x06006527 RID: 25895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005408")]
		public List<BossBehaviorParams> GetBossBehaviorParamsList()
		{
			return null;
		}

		// Token: 0x06006528 RID: 25896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005409")]
		public LotteryBossBehaviorPramsList()
		{
		}

		// Token: 0x0400C508 RID: 50440
		[Token(Token = "0x4009342")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<TParams> ParamsList;

		// Token: 0x0400C509 RID: 50441
		[Token(Token = "0x4009343")]
		[FieldOffset(Offset = "0x0")]
		private List<BossBehaviorParams> CashParamsList;
	}
}
