using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BossData
{
	// Token: 0x02000F3D RID: 3901
	[Token(Token = "0x20009EC")]
	[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x149970", Offset = "0x149A71")]
	public class DragonSisterBossDataAsset : BossDataAssetBase
	{
		// Token: 0x06006572 RID: 25970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005447")]
		[Address(RVA = "0x245C140", Offset = "0x245C241", VA = "0x245C140", Slot = "9")]
		public override BossBehaviorController AddBossBehaviorControllerBase(GameObject monster)
		{
			return null;
		}

		// Token: 0x06006573 RID: 25971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005448")]
		[Address(RVA = "0x245C1A0", Offset = "0x245C2A1", VA = "0x245C1A0", Slot = "10")]
		public override CalcLotteryBossBehavior GetCalcLotteryBossBehavior()
		{
			return null;
		}

		// Token: 0x06006574 RID: 25972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005449")]
		[Address(RVA = "0x245C3C0", Offset = "0x245C4C1", VA = "0x245C3C0")]
		public DragonSisterBossDataAsset()
		{
		}

		// Token: 0x0400C558 RID: 50520
		[Token(Token = "0x4009366")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private DragonSisterBossDataAsset.LotteryBossBehaviorPramsList NormalActionList;

		// Token: 0x0400C559 RID: 50521
		[Token(Token = "0x4009367")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private DragonSisterBossDataAsset.LotteryBossBehaviorPramsList MadnessActionList;

		// Token: 0x02000F3E RID: 3902
		[Token(Token = "0x20014BD")]
		[Serializable]
		public enum LotteryType
		{
			// Token: 0x0400C55B RID: 50523
			[Token(Token = "0x401BDFF")]
			None,
			// Token: 0x0400C55C RID: 50524
			[Token(Token = "0x401BE00")]
			Fly_Close,
			// Token: 0x0400C55D RID: 50525
			[Token(Token = "0x401BE01")]
			Fly_Wander,
			// Token: 0x0400C55E RID: 50526
			[Token(Token = "0x401BE02")]
			Struggle,
			// Token: 0x0400C55F RID: 50527
			[Token(Token = "0x401BE03")]
			Bite,
			// Token: 0x0400C560 RID: 50528
			[Token(Token = "0x401BE04")]
			SwapwithWing,
			// Token: 0x0400C561 RID: 50529
			[Token(Token = "0x401BE05")]
			Meteor,
			// Token: 0x0400C562 RID: 50530
			[Token(Token = "0x401BE06")]
			Blaze,
			// Token: 0x0400C563 RID: 50531
			[Token(Token = "0x401BE07")]
			MegaFireBall,
			// Token: 0x0400C564 RID: 50532
			[Token(Token = "0x401BE08")]
			SwapwithWing_Madness,
			// Token: 0x0400C565 RID: 50533
			[Token(Token = "0x401BE09")]
			Meteor_Madness
		}

		// Token: 0x02000F3F RID: 3903
		[Token(Token = "0x20014BE")]
		[Serializable]
		public class LotteryBossBehavior : LotteryBossBehavior<DragonSisterBossDataAsset.LotteryType>
		{
			// Token: 0x06006575 RID: 25973 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BDA")]
			[Address(RVA = "0x245C450", Offset = "0x245C551", VA = "0x245C450")]
			public LotteryBossBehavior()
			{
			}
		}

		// Token: 0x02000F40 RID: 3904
		[Token(Token = "0x20014BF")]
		[Serializable]
		public class LotteryBossBehaviorParams : LotteryBossBehaviorParams<DragonSisterBossDataAsset.LotteryBossBehavior, DragonSisterBossDataAsset.LotteryType>
		{
			// Token: 0x06006576 RID: 25974 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BDB")]
			[Address(RVA = "0x245C4A0", Offset = "0x245C5A1", VA = "0x245C4A0")]
			public LotteryBossBehaviorParams()
			{
			}
		}

		// Token: 0x02000F41 RID: 3905
		[Token(Token = "0x20014C0")]
		[Serializable]
		public class LotteryBossBehaviorPramsList : LotteryBossBehaviorPramsList<DragonSisterBossDataAsset.LotteryBossBehaviorParams, DragonSisterBossDataAsset.LotteryBossBehavior, DragonSisterBossDataAsset.LotteryType>
		{
			// Token: 0x06006577 RID: 25975 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BDC")]
			[Address(RVA = "0x245C4F0", Offset = "0x245C5F1", VA = "0x245C4F0")]
			public LotteryBossBehaviorPramsList()
			{
			}
		}

		// Token: 0x02000F42 RID: 3906
		[Token(Token = "0x20014C1")]
		[Serializable]
		public class LotteryParam : BossLotteryParam<DragonSisterBossDataAsset.LotteryType>
		{
			// Token: 0x06006578 RID: 25976 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BDD")]
			[Address(RVA = "0x245C540", Offset = "0x245C641", VA = "0x245C540")]
			public LotteryParam()
			{
			}
		}
	}
}
