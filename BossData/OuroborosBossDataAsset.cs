using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BossData
{
	// Token: 0x02000F92 RID: 3986
	[Token(Token = "0x2000A06")]
	[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x149D80", Offset = "0x149E81")]
	public class OuroborosBossDataAsset : BossDataAssetBase
	{
		// Token: 0x060065E5 RID: 26085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005492")]
		[Address(RVA = "0x2187050", Offset = "0x2187151", VA = "0x2187050", Slot = "9")]
		public override BossBehaviorController AddBossBehaviorControllerBase(GameObject monster)
		{
			return null;
		}

		// Token: 0x060065E6 RID: 26086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005493")]
		[Address(RVA = "0x21870B0", Offset = "0x21871B1", VA = "0x21870B0", Slot = "10")]
		public override CalcLotteryBossBehavior GetCalcLotteryBossBehavior()
		{
			return null;
		}

		// Token: 0x060065E7 RID: 26087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005494")]
		[Address(RVA = "0x21871B0", Offset = "0x21872B1", VA = "0x21871B0")]
		public OuroborosBossDataAsset()
		{
		}

		// Token: 0x0400C6B3 RID: 50867
		[Token(Token = "0x40093B1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private OuroborosBossDataAsset.LotteryBossBehaviorPramsList NormalActionList;

		// Token: 0x0400C6B4 RID: 50868
		[Token(Token = "0x40093B2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private OuroborosBossDataAsset.LotteryBossBehaviorPramsList MadnessActionList;

		// Token: 0x02000F93 RID: 3987
		[Token(Token = "0x20014F8")]
		[Serializable]
		public enum LotteryType
		{
			// Token: 0x0400C6B6 RID: 50870
			[Token(Token = "0x401BF0F")]
			None,
			// Token: 0x0400C6B7 RID: 50871
			[Token(Token = "0x401BF10")]
			WindSpear_Attack,
			// Token: 0x0400C6B8 RID: 50872
			[Token(Token = "0x401BF11")]
			ElectromagneticWave_Attack,
			// Token: 0x0400C6B9 RID: 50873
			[Token(Token = "0x401BF12")]
			WindCutter_Attack,
			// Token: 0x0400C6BA RID: 50874
			[Token(Token = "0x401BF13")]
			ThreeTornado_Attack,
			// Token: 0x0400C6BB RID: 50875
			[Token(Token = "0x401BF14")]
			TwoWindSpear_Attack,
			// Token: 0x0400C6BC RID: 50876
			[Token(Token = "0x401BF15")]
			GoToGround_Attack,
			// Token: 0x0400C6BD RID: 50877
			[Token(Token = "0x401BF16")]
			LeaveGoToGround_Attack,
			// Token: 0x0400C6BE RID: 50878
			[Token(Token = "0x401BF17")]
			MadnessWindCutter_Attack
		}

		// Token: 0x02000F94 RID: 3988
		[Token(Token = "0x20014F9")]
		[Serializable]
		public class LotteryBossBehavior : LotteryBossBehavior<OuroborosBossDataAsset.LotteryType>
		{
			// Token: 0x060065E8 RID: 26088 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C02")]
			[Address(RVA = "0x21871C0", Offset = "0x21872C1", VA = "0x21871C0")]
			public LotteryBossBehavior()
			{
			}
		}

		// Token: 0x02000F95 RID: 3989
		[Token(Token = "0x20014FA")]
		[Serializable]
		public class LotteryBossBehaviorParams : LotteryBossBehaviorParams<OuroborosBossDataAsset.LotteryBossBehavior, OuroborosBossDataAsset.LotteryType>
		{
			// Token: 0x060065E9 RID: 26089 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C03")]
			[Address(RVA = "0x2187210", Offset = "0x2187311", VA = "0x2187210")]
			public LotteryBossBehaviorParams()
			{
			}
		}

		// Token: 0x02000F96 RID: 3990
		[Token(Token = "0x20014FB")]
		[Serializable]
		public class LotteryBossBehaviorPramsList : LotteryBossBehaviorPramsList<OuroborosBossDataAsset.LotteryBossBehaviorParams, OuroborosBossDataAsset.LotteryBossBehavior, OuroborosBossDataAsset.LotteryType>
		{
			// Token: 0x060065EA RID: 26090 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C04")]
			[Address(RVA = "0x2187260", Offset = "0x2187361", VA = "0x2187260")]
			public LotteryBossBehaviorPramsList()
			{
			}
		}
	}
}
