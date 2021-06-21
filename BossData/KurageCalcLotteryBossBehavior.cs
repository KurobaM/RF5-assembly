using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace BossData
{
	// Token: 0x02000F7E RID: 3966
	[Token(Token = "0x20009FF")]
	public class KurageCalcLotteryBossBehavior : CalcLotteryBossBehavior
	{
		// Token: 0x060065CD RID: 26061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005483")]
		[Address(RVA = "0x245F560", Offset = "0x245F661", VA = "0x245F560")]
		public KurageCalcLotteryBossBehavior(Dictionary<int, List<BossBehaviorParams>> bossBehaviorListDic)
		{
		}

		// Token: 0x060065CE RID: 26062 RVA: 0x00022260 File Offset: 0x00020460
		[Token(Token = "0x6005484")]
		[Address(RVA = "0x245F7F0", Offset = "0x245F8F1", VA = "0x245F7F0", Slot = "6")]
		public override int Lottery()
		{
			return 0;
		}

		// Token: 0x02000F7F RID: 3967
		[Token(Token = "0x20014EB")]
		public enum KurageBossDataAssetBitArrayIndex
		{
			// Token: 0x0400C662 RID: 50786
			[Token(Token = "0x401BECB")]
			IsHitAttack = 1,
			// Token: 0x0400C663 RID: 50787
			[Token(Token = "0x401BECC")]
			IsPreviousSelectMove,
			// Token: 0x0400C664 RID: 50788
			[Token(Token = "0x401BECD")]
			IsCharge,
			// Token: 0x0400C665 RID: 50789
			[Token(Token = "0x401BECE")]
			TentaclesAction,
			// Token: 0x0400C666 RID: 50790
			[Token(Token = "0x401BECF")]
			BubbleAction,
			// Token: 0x0400C667 RID: 50791
			[Token(Token = "0x401BED0")]
			IsCounterattackThunderbolt,
			// Token: 0x0400C668 RID: 50792
			[Token(Token = "0x401BED1")]
			IsElectroCharge,
			// Token: 0x0400C669 RID: 50793
			[Token(Token = "0x401BED2")]
			e_Count
		}
	}
}
