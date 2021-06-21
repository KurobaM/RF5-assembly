using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace BossData
{
	// Token: 0x02000F9E RID: 3998
	[Token(Token = "0x2000A09")]
	public class ReviatanCalcLotteryBossBehavior : CalcLotteryBossBehavior
	{
		// Token: 0x060065F4 RID: 26100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600549B")]
		[Address(RVA = "0x2187500", Offset = "0x2187601", VA = "0x2187500")]
		public ReviatanCalcLotteryBossBehavior(Dictionary<int, List<BossBehaviorParams>> bossBehaviorListDic)
		{
		}

		// Token: 0x060065F5 RID: 26101 RVA: 0x000222A8 File Offset: 0x000204A8
		[Token(Token = "0x600549C")]
		[Address(RVA = "0x2187760", Offset = "0x2187861", VA = "0x2187760", Slot = "6")]
		public override int Lottery()
		{
			return 0;
		}

		// Token: 0x02000F9F RID: 3999
		[Token(Token = "0x2001501")]
		public enum ReviatanBossDataBitArrayIndex
		{
			// Token: 0x0400C6D5 RID: 50901
			[Token(Token = "0x401BF28")]
			IsRecovery = 1,
			// Token: 0x0400C6D6 RID: 50902
			[Token(Token = "0x401BF29")]
			IsNormalColor,
			// Token: 0x0400C6D7 RID: 50903
			[Token(Token = "0x401BF2A")]
			e_Count
		}
	}
}
