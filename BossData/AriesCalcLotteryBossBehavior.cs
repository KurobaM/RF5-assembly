using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace BossData
{
	// Token: 0x02000F17 RID: 3863
	[Token(Token = "0x20009DA")]
	public class AriesCalcLotteryBossBehavior : CalcLotteryBossBehavior
	{
		// Token: 0x06006509 RID: 25865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053F0")]
		[Address(RVA = "0x2459A20", Offset = "0x2459B21", VA = "0x2459A20")]
		public AriesCalcLotteryBossBehavior(Dictionary<int, List<BossBehaviorParams>> bossBehaviorListDic)
		{
		}

		// Token: 0x0600650A RID: 25866 RVA: 0x00021D80 File Offset: 0x0001FF80
		[Token(Token = "0x60053F1")]
		[Address(RVA = "0x2459C50", Offset = "0x2459D51", VA = "0x2459C50", Slot = "6")]
		public override int Lottery()
		{
			return 0;
		}

		// Token: 0x0600650B RID: 25867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053F2")]
		[Address(RVA = "0x2459D20", Offset = "0x2459E21", VA = "0x2459D20", Slot = "7")]
		protected override void OnNextBehaviorParamsIndex(int listCount, BossBehaviorParam retBehaviorParam)
		{
		}
	}
}
