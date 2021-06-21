using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace BossData
{
	// Token: 0x02000F24 RID: 3876
	[Token(Token = "0x20009DE")]
	public class BasiliskCalcLotteryBossBehavior : CalcLotteryBossBehavior
	{
		// Token: 0x0600651A RID: 25882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053FB")]
		[Address(RVA = "0x245A580", Offset = "0x245A681", VA = "0x245A580")]
		public BasiliskCalcLotteryBossBehavior(Dictionary<int, List<BossBehaviorParams>> bossBehaviorListDic)
		{
		}

		// Token: 0x0600651B RID: 25883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053FC")]
		[Address(RVA = "0x245A850", Offset = "0x245A951", VA = "0x245A850", Slot = "5")]
		public override void OnMadness()
		{
		}

		// Token: 0x0600651C RID: 25884 RVA: 0x00021DB0 File Offset: 0x0001FFB0
		[Token(Token = "0x60053FD")]
		[Address(RVA = "0x245A8F0", Offset = "0x245A9F1", VA = "0x245A8F0")]
		private bool IsCheckState(int lotteryType)
		{
			return default(bool);
		}

		// Token: 0x0600651D RID: 25885 RVA: 0x00021DC8 File Offset: 0x0001FFC8
		[Token(Token = "0x60053FE")]
		[Address(RVA = "0x245A920", Offset = "0x245AA21", VA = "0x245A920", Slot = "6")]
		public override int Lottery()
		{
			return 0;
		}

		// Token: 0x0600651E RID: 25886 RVA: 0x00021DE0 File Offset: 0x0001FFE0
		[Token(Token = "0x60053FF")]
		[Address(RVA = "0x245A930", Offset = "0x245AA31", VA = "0x245A930")]
		public int GetBehaviorType()
		{
			return 0;
		}

		// Token: 0x0600651F RID: 25887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005400")]
		[Address(RVA = "0x245AB60", Offset = "0x245AC61", VA = "0x245AB60")]
		private void UpdateBehaviorList(int behaviorType)
		{
		}

		// Token: 0x0400C4EC RID: 50412
		[Token(Token = "0x400932A")]
		[FieldOffset(Offset = "0x40")]
		private List<BossBehaviorParams> CurrentBehaviorParamsList;

		// Token: 0x02000F25 RID: 3877
		[Token(Token = "0x20014B2")]
		public enum BasiliskBossDataAssetBitArrayIndex
		{
			// Token: 0x0400C4EE RID: 50414
			[Token(Token = "0x401BDCF")]
			IsStageCenterTarget = 1,
			// Token: 0x0400C4EF RID: 50415
			[Token(Token = "0x401BDD0")]
			IsNormalColor,
			// Token: 0x0400C4F0 RID: 50416
			[Token(Token = "0x401BDD1")]
			e_Count
		}
	}
}
