using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BossData
{
	// Token: 0x02000F8C RID: 3980
	[Token(Token = "0x2000A04")]
	[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x149D30", Offset = "0x149E31")]
	public class MummyBossDataAsset : BossDataAssetBase
	{
		// Token: 0x060065DE RID: 26078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600548E")]
		[Address(RVA = "0x2186DF0", Offset = "0x2186EF1", VA = "0x2186DF0", Slot = "9")]
		public override BossBehaviorController AddBossBehaviorControllerBase(GameObject monster)
		{
			return null;
		}

		// Token: 0x060065DF RID: 26079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600548F")]
		[Address(RVA = "0x2186E50", Offset = "0x2186F51", VA = "0x2186E50", Slot = "10")]
		public override CalcLotteryBossBehavior GetCalcLotteryBossBehavior()
		{
			return null;
		}

		// Token: 0x060065E0 RID: 26080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005490")]
		[Address(RVA = "0x2186F50", Offset = "0x2187051", VA = "0x2186F50")]
		public MummyBossDataAsset()
		{
		}

		// Token: 0x0400C6A5 RID: 50853
		[Token(Token = "0x40093AF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MummyBossDataAsset.LotteryBossBehaviorPramsList NormalActionList;

		// Token: 0x0400C6A6 RID: 50854
		[Token(Token = "0x40093B0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private MummyBossDataAsset.LotteryBossBehaviorPramsList MadnessActionList;

		// Token: 0x02000F8D RID: 3981
		[Token(Token = "0x20014F4")]
		[Serializable]
		public enum LotteryType
		{
			// Token: 0x0400C6A8 RID: 50856
			[Token(Token = "0x401BF03")]
			None,
			// Token: 0x0400C6A9 RID: 50857
			[Token(Token = "0x401BF04")]
			DeathSmoke_Attack,
			// Token: 0x0400C6AA RID: 50858
			[Token(Token = "0x401BF05")]
			BodyPress_Attack,
			// Token: 0x0400C6AB RID: 50859
			[Token(Token = "0x401BF06")]
			HandPress_Attack,
			// Token: 0x0400C6AC RID: 50860
			[Token(Token = "0x401BF07")]
			Suction_Attack,
			// Token: 0x0400C6AD RID: 50861
			[Token(Token = "0x401BF08")]
			MadnessBodyPress_Attack,
			// Token: 0x0400C6AE RID: 50862
			[Token(Token = "0x401BF09")]
			DashMadnessBodyPress_Attack,
			// Token: 0x0400C6AF RID: 50863
			[Token(Token = "0x401BF0A")]
			OneRoundDeathSmoke_Attack,
			// Token: 0x0400C6B0 RID: 50864
			[Token(Token = "0x401BF0B")]
			QuarterDeathSmoke_Attack,
			// Token: 0x0400C6B1 RID: 50865
			[Token(Token = "0x401BF0C")]
			DashDeathSmoke_Attack,
			// Token: 0x0400C6B2 RID: 50866
			[Token(Token = "0x401BF0D")]
			Loitering_Move
		}

		// Token: 0x02000F8E RID: 3982
		[Token(Token = "0x20014F5")]
		[Serializable]
		public class LotteryBossBehavior : LotteryBossBehavior<MummyBossDataAsset.LotteryType>
		{
			// Token: 0x060065E1 RID: 26081 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BFF")]
			[Address(RVA = "0x2186F60", Offset = "0x2187061", VA = "0x2186F60")]
			public LotteryBossBehavior()
			{
			}
		}

		// Token: 0x02000F8F RID: 3983
		[Token(Token = "0x20014F6")]
		[Serializable]
		public class LotteryBossBehaviorParams : LotteryBossBehaviorParams<MummyBossDataAsset.LotteryBossBehavior, MummyBossDataAsset.LotteryType>
		{
			// Token: 0x060065E2 RID: 26082 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C00")]
			[Address(RVA = "0x2186FB0", Offset = "0x21870B1", VA = "0x2186FB0")]
			public LotteryBossBehaviorParams()
			{
			}
		}

		// Token: 0x02000F90 RID: 3984
		[Token(Token = "0x20014F7")]
		[Serializable]
		public class LotteryBossBehaviorPramsList : LotteryBossBehaviorPramsList<MummyBossDataAsset.LotteryBossBehaviorParams, MummyBossDataAsset.LotteryBossBehavior, MummyBossDataAsset.LotteryType>
		{
			// Token: 0x060065E3 RID: 26083 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C01")]
			[Address(RVA = "0x2187000", Offset = "0x2187101", VA = "0x2187000")]
			public LotteryBossBehaviorPramsList()
			{
			}
		}
	}
}
