using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BossData
{
	// Token: 0x02000F72 RID: 3954
	[Token(Token = "0x20009FC")]
	[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x149BF0", Offset = "0x149CF1")]
	public class KrakenBossDataAsset : BossDataAssetBase
	{
		// Token: 0x060065BD RID: 26045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005479")]
		[Address(RVA = "0x245EDA0", Offset = "0x245EEA1", VA = "0x245EDA0", Slot = "9")]
		public override BossBehaviorController AddBossBehaviorControllerBase(GameObject monster)
		{
			return null;
		}

		// Token: 0x060065BE RID: 26046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600547A")]
		[Address(RVA = "0x245EE00", Offset = "0x245EF01", VA = "0x245EE00", Slot = "10")]
		public override CalcLotteryBossBehavior GetCalcLotteryBossBehavior()
		{
			return null;
		}

		// Token: 0x060065BF RID: 26047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600547B")]
		[Address(RVA = "0x245F040", Offset = "0x245F141", VA = "0x245F040")]
		public KrakenBossDataAsset()
		{
		}

		// Token: 0x0400C62F RID: 50735
		[Token(Token = "0x4009398")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private KrakenBossDataAsset.LotteryBossBehaviorPramsList NormalActionList;

		// Token: 0x0400C630 RID: 50736
		[Token(Token = "0x4009399")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private KrakenBossDataAsset.LotteryBossBehaviorPramsList MadnessActionList;

		// Token: 0x0400C631 RID: 50737
		[Token(Token = "0x400939A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private KrakenBossDataAsset.LotteryBossBehaviorPramsList InWaterActionList;

		// Token: 0x02000F73 RID: 3955
		[Token(Token = "0x20014E2")]
		[Serializable]
		public enum LotteryType
		{
			// Token: 0x0400C633 RID: 50739
			[Token(Token = "0x401BEA4")]
			None,
			// Token: 0x0400C634 RID: 50740
			[Token(Token = "0x401BEA5")]
			LegStripping_Attack,
			// Token: 0x0400C635 RID: 50741
			[Token(Token = "0x401BEA6")]
			EarthquakeIcicles_Attack,
			// Token: 0x0400C636 RID: 50742
			[Token(Token = "0x401BEA7")]
			LegPinch_Attack,
			// Token: 0x0400C637 RID: 50743
			[Token(Token = "0x401BEA8")]
			TiltLegStripping_Attack,
			// Token: 0x0400C638 RID: 50744
			[Token(Token = "0x401BEA9")]
			StickOut_Attack,
			// Token: 0x0400C639 RID: 50745
			[Token(Token = "0x401BEAA")]
			RotateLegStripping_Attack,
			// Token: 0x0400C63A RID: 50746
			[Token(Token = "0x401BEAB")]
			Dive_Other,
			// Token: 0x0400C63B RID: 50747
			[Token(Token = "0x401BEAC")]
			CreateNormalSkyFish_Other,
			// Token: 0x0400C63C RID: 50748
			[Token(Token = "0x401BEAD")]
			Eat_Other,
			// Token: 0x0400C63D RID: 50749
			[Token(Token = "0x401BEAE")]
			Rise_Other,
			// Token: 0x0400C63E RID: 50750
			[Token(Token = "0x401BEAF")]
			KrakenLaser_Attack,
			// Token: 0x0400C63F RID: 50751
			[Token(Token = "0x401BEB0")]
			RotateKrakenLaser_Attack,
			// Token: 0x0400C640 RID: 50752
			[Token(Token = "0x401BEB1")]
			TwoAquaBreath_Attack,
			// Token: 0x0400C641 RID: 50753
			[Token(Token = "0x401BEB2")]
			TwoIcicleBreath_Attack,
			// Token: 0x0400C642 RID: 50754
			[Token(Token = "0x401BEB3")]
			RotateDeltaLaser_Attack,
			// Token: 0x0400C643 RID: 50755
			[Token(Token = "0x401BEB4")]
			WaterBall1_Attack,
			// Token: 0x0400C644 RID: 50756
			[Token(Token = "0x401BEB5")]
			WaterBall2_Attack,
			// Token: 0x0400C645 RID: 50757
			[Token(Token = "0x401BEB6")]
			CreateMadnessSkyFish_Other,
			// Token: 0x0400C646 RID: 50758
			[Token(Token = "0x401BEB7")]
			WaterBall1InWater_Attack
		}

		// Token: 0x02000F74 RID: 3956
		[Token(Token = "0x20014E3")]
		[Serializable]
		public class LotteryBossBehavior : LotteryBossBehavior<KrakenBossDataAsset.LotteryType>
		{
			// Token: 0x060065C0 RID: 26048 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BF3")]
			[Address(RVA = "0x245F0D0", Offset = "0x245F1D1", VA = "0x245F0D0")]
			public LotteryBossBehavior()
			{
			}
		}

		// Token: 0x02000F75 RID: 3957
		[Token(Token = "0x20014E4")]
		[Serializable]
		public class LotteryBossBehaviorParams : LotteryBossBehaviorParams<KrakenBossDataAsset.LotteryBossBehavior, KrakenBossDataAsset.LotteryType>
		{
			// Token: 0x060065C1 RID: 26049 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BF4")]
			[Address(RVA = "0x245F120", Offset = "0x245F221", VA = "0x245F120")]
			public LotteryBossBehaviorParams()
			{
			}
		}

		// Token: 0x02000F76 RID: 3958
		[Token(Token = "0x20014E5")]
		[Serializable]
		public class LotteryBossBehaviorPramsList : LotteryBossBehaviorPramsList<KrakenBossDataAsset.LotteryBossBehaviorParams, KrakenBossDataAsset.LotteryBossBehavior, KrakenBossDataAsset.LotteryType>
		{
			// Token: 0x060065C2 RID: 26050 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BF5")]
			[Address(RVA = "0x245F170", Offset = "0x245F271", VA = "0x245F170")]
			public LotteryBossBehaviorPramsList()
			{
			}
		}
	}
}
