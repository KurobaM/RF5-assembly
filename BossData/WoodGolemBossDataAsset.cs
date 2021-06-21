using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BossData
{
	// Token: 0x02000FAC RID: 4012
	[Token(Token = "0x2000A0E")]
	[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x149EC0", Offset = "0x149FC1")]
	public class WoodGolemBossDataAsset : BossDataAssetBase
	{
		// Token: 0x0600660A RID: 26122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054AA")]
		[Address(RVA = "0x2188100", Offset = "0x2188201", VA = "0x2188100", Slot = "9")]
		public override BossBehaviorController AddBossBehaviorControllerBase(GameObject monster)
		{
			return null;
		}

		// Token: 0x0600660B RID: 26123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054AB")]
		[Address(RVA = "0x2188160", Offset = "0x2188261", VA = "0x2188160", Slot = "10")]
		public override CalcLotteryBossBehavior GetCalcLotteryBossBehavior()
		{
			return null;
		}

		// Token: 0x0600660C RID: 26124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054AC")]
		[Address(RVA = "0x2188260", Offset = "0x2188361", VA = "0x2188260")]
		public WoodGolemBossDataAsset()
		{
		}

		// Token: 0x0400C704 RID: 50948
		[Token(Token = "0x40093C6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private WoodGolemBossDataAsset.LotteryBossBehaviorPramsList NormalActionList;

		// Token: 0x0400C705 RID: 50949
		[Token(Token = "0x40093C7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private WoodGolemBossDataAsset.LotteryBossBehaviorPramsList MadnessActionList;

		// Token: 0x02000FAD RID: 4013
		[Token(Token = "0x200150A")]
		[Serializable]
		public enum LotteryType
		{
			// Token: 0x0400C707 RID: 50951
			[Token(Token = "0x401BF4B")]
			None,
			// Token: 0x0400C708 RID: 50952
			[Token(Token = "0x401BF4C")]
			RocketPunch_Attack,
			// Token: 0x0400C709 RID: 50953
			[Token(Token = "0x401BF4D")]
			BodyPress_Attack,
			// Token: 0x0400C70A RID: 50954
			[Token(Token = "0x401BF4E")]
			LeftPunch_Attack,
			// Token: 0x0400C70B RID: 50955
			[Token(Token = "0x401BF4F")]
			RotatingLaser_Attack,
			// Token: 0x0400C70C RID: 50956
			[Token(Token = "0x401BF50")]
			DashRush_Attack,
			// Token: 0x0400C70D RID: 50957
			[Token(Token = "0x401BF51")]
			MadnessRocketPunch_Attack,
			// Token: 0x0400C70E RID: 50958
			[Token(Token = "0x401BF52")]
			MadnessBodyPress_Attack,
			// Token: 0x0400C70F RID: 50959
			[Token(Token = "0x401BF53")]
			MadnessLeftPunch_Attack,
			// Token: 0x0400C710 RID: 50960
			[Token(Token = "0x401BF54")]
			WalkClose_Move,
			// Token: 0x0400C711 RID: 50961
			[Token(Token = "0x401BF55")]
			GrowArm_Other,
			// Token: 0x0400C712 RID: 50962
			[Token(Token = "0x401BF56")]
			MadnessTwoLeftPunch_Attack,
			// Token: 0x0400C713 RID: 50963
			[Token(Token = "0x401BF57")]
			BigBang_Attack
		}

		// Token: 0x02000FAE RID: 4014
		[Token(Token = "0x200150B")]
		[Serializable]
		public class LotteryBossBehavior : LotteryBossBehavior<WoodGolemBossDataAsset.LotteryType>
		{
			// Token: 0x0600660D RID: 26125 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C0F")]
			[Address(RVA = "0x2188270", Offset = "0x2188371", VA = "0x2188270")]
			public LotteryBossBehavior()
			{
			}
		}

		// Token: 0x02000FAF RID: 4015
		[Token(Token = "0x200150C")]
		[Serializable]
		public class LotteryBossBehaviorParams : LotteryBossBehaviorParams<WoodGolemBossDataAsset.LotteryBossBehavior, WoodGolemBossDataAsset.LotteryType>
		{
			// Token: 0x0600660E RID: 26126 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C10")]
			[Address(RVA = "0x21882C0", Offset = "0x21883C1", VA = "0x21882C0")]
			public LotteryBossBehaviorParams()
			{
			}
		}

		// Token: 0x02000FB0 RID: 4016
		[Token(Token = "0x200150D")]
		[Serializable]
		public class LotteryBossBehaviorPramsList : LotteryBossBehaviorPramsList<WoodGolemBossDataAsset.LotteryBossBehaviorParams, WoodGolemBossDataAsset.LotteryBossBehavior, WoodGolemBossDataAsset.LotteryType>
		{
			// Token: 0x0600660F RID: 26127 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C11")]
			[Address(RVA = "0x2188310", Offset = "0x2188411", VA = "0x2188310")]
			public LotteryBossBehaviorPramsList()
			{
			}
		}
	}
}
