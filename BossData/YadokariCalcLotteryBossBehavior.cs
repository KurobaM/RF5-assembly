using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace BossData
{
	// Token: 0x02000FB8 RID: 4024
	[Token(Token = "0x2000A11")]
	public class YadokariCalcLotteryBossBehavior : CalcLotteryBossBehavior
	{
		// Token: 0x06006618 RID: 26136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054B2")]
		[Address(RVA = "0x2188540", Offset = "0x2188641", VA = "0x2188540")]
		public YadokariCalcLotteryBossBehavior(Dictionary<int, List<BossBehaviorParams>> bossBehaviorListDic)
		{
		}

		// Token: 0x06006619 RID: 26137 RVA: 0x00022368 File Offset: 0x00020568
		[Token(Token = "0x60054B3")]
		[Address(RVA = "0x2188650", Offset = "0x2188751", VA = "0x2188650", Slot = "6")]
		public override int Lottery()
		{
			return 0;
		}

		// Token: 0x02000FB9 RID: 4025
		[Token(Token = "0x2001513")]
		public enum YadokariBossDataAssetBitArrayIndex
		{
			// Token: 0x0400C730 RID: 50992
			[Token(Token = "0x401BF71")]
			IsThrowShell = 1,
			// Token: 0x0400C731 RID: 50993
			[Token(Token = "0x401BF72")]
			e_Count
		}
	}
}
