using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace BossData
{
	// Token: 0x02000F1D RID: 3869
	[Token(Token = "0x20009DC")]
	public class AudmuraCalcLotteryBossBehavior : CalcLotteryBossBehavior
	{
		// Token: 0x06006513 RID: 25875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053F7")]
		[Address(RVA = "0x2459FF0", Offset = "0x245A0F1", VA = "0x2459FF0")]
		public AudmuraCalcLotteryBossBehavior(Dictionary<int, List<BossBehaviorParams>> bossBehaviorListDic)
		{
		}

		// Token: 0x02000F1E RID: 3870
		[Token(Token = "0x20014AD")]
		public enum AudmuraBossDataBitArrayIndex
		{
			// Token: 0x0400C4BB RID: 50363
			[Token(Token = "0x401BDAD")]
			IsBackAttack = 1,
			// Token: 0x0400C4BC RID: 50364
			[Token(Token = "0x401BDAE")]
			e_Count
		}
	}
}
