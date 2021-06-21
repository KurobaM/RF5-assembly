using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace BossData
{
	// Token: 0x02000F6A RID: 3946
	[Token(Token = "0x20009F9")]
	public class InosisiCalcLotteryBossBehavior : CalcLotteryBossBehavior
	{
		// Token: 0x060065B4 RID: 26036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005473")]
		[Address(RVA = "0x245E600", Offset = "0x245E701", VA = "0x245E600")]
		public InosisiCalcLotteryBossBehavior(Dictionary<int, List<BossBehaviorParams>> bossBehaviorListDic)
		{
		}

		// Token: 0x02000F6B RID: 3947
		[Token(Token = "0x20014DD")]
		public enum InosisiBossDataAssetBitArrayIndex
		{
			// Token: 0x0400C61B RID: 50715
			[Token(Token = "0x401BE94")]
			IsPreviousSelectMove = 1,
			// Token: 0x0400C61C RID: 50716
			[Token(Token = "0x401BE95")]
			FilledDamage,
			// Token: 0x0400C61D RID: 50717
			[Token(Token = "0x401BE96")]
			e_Count
		}
	}
}
