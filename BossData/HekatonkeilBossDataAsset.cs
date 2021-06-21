using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BossData
{
	// Token: 0x02000F5F RID: 3935
	[Token(Token = "0x20009F6")]
	[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x149B00", Offset = "0x149C01")]
	public class HekatonkeilBossDataAsset : BossDataAssetBase
	{
		// Token: 0x060065A6 RID: 26022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600546B")]
		[Address(RVA = "0x245E030", Offset = "0x245E131", VA = "0x245E030", Slot = "9")]
		public override BossBehaviorController AddBossBehaviorControllerBase(GameObject monster)
		{
			return null;
		}

		// Token: 0x060065A7 RID: 26023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600546C")]
		[Address(RVA = "0x245E090", Offset = "0x245E191", VA = "0x245E090", Slot = "10")]
		public override CalcLotteryBossBehavior GetCalcLotteryBossBehavior()
		{
			return null;
		}

		// Token: 0x060065A8 RID: 26024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600546D")]
		[Address(RVA = "0x245E2B0", Offset = "0x245E3B1", VA = "0x245E2B0")]
		public HekatonkeilBossDataAsset()
		{
		}

		// Token: 0x0400C5F5 RID: 50677
		[Token(Token = "0x400938E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private HekatonkeilBossDataAsset.LotteryBossBehaviorPramsList NormalActionList;

		// Token: 0x0400C5F6 RID: 50678
		[Token(Token = "0x400938F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private HekatonkeilBossDataAsset.LotteryBossBehaviorPramsList MadnessActionList;

		// Token: 0x02000F60 RID: 3936
		[Token(Token = "0x20014D5")]
		[Serializable]
		public enum LotteryType
		{
			// Token: 0x0400C5F8 RID: 50680
			[Token(Token = "0x401BE74")]
			None,
			// Token: 0x0400C5F9 RID: 50681
			[Token(Token = "0x401BE75")]
			ThreePunchGround,
			// Token: 0x0400C5FA RID: 50682
			[Token(Token = "0x401BE76")]
			HoldArmsPunchGround,
			// Token: 0x0400C5FB RID: 50683
			[Token(Token = "0x401BE77")]
			MadnessThreePunchGround,
			// Token: 0x0400C5FC RID: 50684
			[Token(Token = "0x401BE78")]
			MadnessHoldArmsPunchGround,
			// Token: 0x0400C5FD RID: 50685
			[Token(Token = "0x401BE79")]
			Flame,
			// Token: 0x0400C5FE RID: 50686
			[Token(Token = "0x401BE7A")]
			FireBall,
			// Token: 0x0400C5FF RID: 50687
			[Token(Token = "0x401BE7B")]
			ThreeFireBall,
			// Token: 0x0400C600 RID: 50688
			[Token(Token = "0x401BE7C")]
			DashAttack,
			// Token: 0x0400C601 RID: 50689
			[Token(Token = "0x401BE7D")]
			EarthQuake,
			// Token: 0x0400C602 RID: 50690
			[Token(Token = "0x401BE7E")]
			RapidBlow,
			// Token: 0x0400C603 RID: 50691
			[Token(Token = "0x401BE7F")]
			RangeCheck_ThreePunchGround,
			// Token: 0x0400C604 RID: 50692
			[Token(Token = "0x401BE80")]
			RangeCheck_HoldArmsPunchGround,
			// Token: 0x0400C605 RID: 50693
			[Token(Token = "0x401BE81")]
			RangeCheck_MadnessThreePunchGround,
			// Token: 0x0400C606 RID: 50694
			[Token(Token = "0x401BE82")]
			RangeCheck_MadnessHoldArmsPunchGround,
			// Token: 0x0400C607 RID: 50695
			[Token(Token = "0x401BE83")]
			ThrowRockSmall3,
			// Token: 0x0400C608 RID: 50696
			[Token(Token = "0x401BE84")]
			ThrowRockSmall1,
			// Token: 0x0400C609 RID: 50697
			[Token(Token = "0x401BE85")]
			ThrowRockSmall3Attribute,
			// Token: 0x0400C60A RID: 50698
			[Token(Token = "0x401BE86")]
			ThrowRockBig1Attribute
		}

		// Token: 0x02000F61 RID: 3937
		[Token(Token = "0x20014D6")]
		[Serializable]
		public class LotteryBossBehavior : LotteryBossBehavior<HekatonkeilBossDataAsset.LotteryType>
		{
			// Token: 0x060065A9 RID: 26025 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BEA")]
			[Address(RVA = "0x245E340", Offset = "0x245E441", VA = "0x245E340")]
			public LotteryBossBehavior()
			{
			}
		}

		// Token: 0x02000F62 RID: 3938
		[Token(Token = "0x20014D7")]
		[Serializable]
		public class LotteryBossBehaviorParams : LotteryBossBehaviorParams<HekatonkeilBossDataAsset.LotteryBossBehavior, HekatonkeilBossDataAsset.LotteryType>
		{
			// Token: 0x060065AA RID: 26026 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BEB")]
			[Address(RVA = "0x245E390", Offset = "0x245E491", VA = "0x245E390")]
			public LotteryBossBehaviorParams()
			{
			}
		}

		// Token: 0x02000F63 RID: 3939
		[Token(Token = "0x20014D8")]
		[Serializable]
		public class LotteryBossBehaviorPramsList : LotteryBossBehaviorPramsList<HekatonkeilBossDataAsset.LotteryBossBehaviorParams, HekatonkeilBossDataAsset.LotteryBossBehavior, HekatonkeilBossDataAsset.LotteryType>
		{
			// Token: 0x060065AB RID: 26027 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BEC")]
			[Address(RVA = "0x245E3E0", Offset = "0x245E4E1", VA = "0x245E3E0")]
			public LotteryBossBehaviorPramsList()
			{
			}
		}
	}
}
