using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace BossData
{
	// Token: 0x02000F10 RID: 3856
	[Token(Token = "0x20009D8")]
	public class AracneCalcLotteryBossBehavior : CalcLotteryBossBehavior
	{
		// Token: 0x06006502 RID: 25858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053EC")]
		[Address(RVA = "0x24594C0", Offset = "0x24595C1", VA = "0x24594C0")]
		public AracneCalcLotteryBossBehavior(Dictionary<int, List<BossBehaviorParams>> bossBehaviorListDic)
		{
		}

		// Token: 0x02000F11 RID: 3857
		[Token(Token = "0x20014A4")]
		public enum AracneBossDataBitArrayIndex
		{
			// Token: 0x0400C49C RID: 50332
			[Token(Token = "0x401BD93")]
			IsAccumulatedDamage = 1,
			// Token: 0x0400C49D RID: 50333
			[Token(Token = "0x401BD94")]
			IsMaxMasterSpider,
			// Token: 0x0400C49E RID: 50334
			[Token(Token = "0x401BD95")]
			e_Count
		}
	}
}
