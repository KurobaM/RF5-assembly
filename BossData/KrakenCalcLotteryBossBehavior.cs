using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace BossData
{
	// Token: 0x02000F77 RID: 3959
	[Token(Token = "0x20009FD")]
	public class KrakenCalcLotteryBossBehavior : CalcLotteryBossBehavior
	{
		// Token: 0x060065C3 RID: 26051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600547C")]
		[Address(RVA = "0x245EF90", Offset = "0x245F091", VA = "0x245EF90")]
		public KrakenCalcLotteryBossBehavior(Dictionary<int, List<BossBehaviorParams>> bossBehaviorListDic)
		{
		}

		// Token: 0x060065C4 RID: 26052 RVA: 0x00022230 File Offset: 0x00020430
		[Token(Token = "0x600547D")]
		[Address(RVA = "0x245F1C0", Offset = "0x245F2C1", VA = "0x245F1C0", Slot = "6")]
		public override int Lottery()
		{
			return 0;
		}

		// Token: 0x060065C5 RID: 26053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600547E")]
		[Address(RVA = "0x245F280", Offset = "0x245F381", VA = "0x245F280", Slot = "8")]
		protected override void OnLoop()
		{
		}

		// Token: 0x0400C647 RID: 50759
		[Token(Token = "0x400939B")]
		[FieldOffset(Offset = "0x40")]
		private bool IsInWater;

		// Token: 0x02000F78 RID: 3960
		[Token(Token = "0x20014E6")]
		public enum KrakenBossDataBitArrayIndex
		{
			// Token: 0x0400C649 RID: 50761
			[Token(Token = "0x401BEB9")]
			IsNextEat = 1,
			// Token: 0x0400C64A RID: 50762
			[Token(Token = "0x401BEBA")]
			e_Count
		}
	}
}
