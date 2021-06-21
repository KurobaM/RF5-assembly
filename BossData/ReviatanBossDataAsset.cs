using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BossData
{
	// Token: 0x02000F99 RID: 3993
	[Token(Token = "0x2000A08")]
	[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x149DD0", Offset = "0x149ED1")]
	public class ReviatanBossDataAsset : BossDataAssetBase
	{
		// Token: 0x17000D1C RID: 3356
		// (get) Token: 0x060065EC RID: 26092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A5A")]
		public Vector2[] GetRecoveryPercents
		{
			[Token(Token = "0x6005496")]
			[Address(RVA = "0x21872B0", Offset = "0x21873B1", VA = "0x21872B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060065ED RID: 26093 RVA: 0x00022290 File Offset: 0x00020490
		[Token(Token = "0x6005497")]
		[Address(RVA = "0x21872C0", Offset = "0x21873C1", VA = "0x21872C0", Slot = "6")]
		public override int GetIntParam(string key)
		{
			return 0;
		}

		// Token: 0x060065EE RID: 26094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005498")]
		[Address(RVA = "0x21873B0", Offset = "0x21874B1", VA = "0x21873B0", Slot = "9")]
		public override BossBehaviorController AddBossBehaviorControllerBase(GameObject monster)
		{
			return null;
		}

		// Token: 0x060065EF RID: 26095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005499")]
		[Address(RVA = "0x2187410", Offset = "0x2187511", VA = "0x2187410", Slot = "10")]
		public override CalcLotteryBossBehavior GetCalcLotteryBossBehavior()
		{
			return null;
		}

		// Token: 0x060065F0 RID: 26096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600549A")]
		[Address(RVA = "0x2187510", Offset = "0x2187611", VA = "0x2187510")]
		public ReviatanBossDataAsset()
		{
		}

		// Token: 0x0400C6C2 RID: 50882
		[Token(Token = "0x40093B3")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private int IcePillarMax;

		// Token: 0x0400C6C3 RID: 50883
		[Token(Token = "0x40093B4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int NormalRecoveryCount;

		// Token: 0x0400C6C4 RID: 50884
		[Token(Token = "0x40093B5")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private int VariationRecoveryCount;

		// Token: 0x0400C6C5 RID: 50885
		[Token(Token = "0x40093B6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Vector2[] RecoveryPercents;

		// Token: 0x0400C6C6 RID: 50886
		[Token(Token = "0x40093B7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ReviatanBossDataAsset.LotteryBossBehaviorPramsList NormalActionList;

		// Token: 0x0400C6C7 RID: 50887
		[Token(Token = "0x40093B8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ReviatanBossDataAsset.LotteryBossBehaviorPramsList MadnessActionList;

		// Token: 0x02000F9A RID: 3994
		[Token(Token = "0x20014FD")]
		[Serializable]
		public enum LotteryType
		{
			// Token: 0x0400C6C9 RID: 50889
			[Token(Token = "0x401BF1C")]
			None,
			// Token: 0x0400C6CA RID: 50890
			[Token(Token = "0x401BF1D")]
			Geyser_Attack,
			// Token: 0x0400C6CB RID: 50891
			[Token(Token = "0x401BF1E")]
			WaterGun_Attack,
			// Token: 0x0400C6CC RID: 50892
			[Token(Token = "0x401BF1F")]
			WaterLaser_Attack,
			// Token: 0x0400C6CD RID: 50893
			[Token(Token = "0x401BF20")]
			Tsunami_Attack,
			// Token: 0x0400C6CE RID: 50894
			[Token(Token = "0x401BF21")]
			IcePillar_Attack,
			// Token: 0x0400C6CF RID: 50895
			[Token(Token = "0x401BF22")]
			Headbutt_Attack,
			// Token: 0x0400C6D0 RID: 50896
			[Token(Token = "0x401BF23")]
			Recovery_Other,
			// Token: 0x0400C6D1 RID: 50897
			[Token(Token = "0x401BF24")]
			Leave_Move,
			// Token: 0x0400C6D2 RID: 50898
			[Token(Token = "0x401BF25")]
			WaterGun_Headbutt_Attack,
			// Token: 0x0400C6D3 RID: 50899
			[Token(Token = "0x401BF26")]
			BigGeyser_Attack
		}

		// Token: 0x02000F9B RID: 3995
		[Token(Token = "0x20014FE")]
		[Serializable]
		public class LotteryBossBehavior : LotteryBossBehavior<ReviatanBossDataAsset.LotteryType>
		{
			// Token: 0x060065F1 RID: 26097 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C05")]
			[Address(RVA = "0x2187670", Offset = "0x2187771", VA = "0x2187670")]
			public LotteryBossBehavior()
			{
			}
		}

		// Token: 0x02000F9C RID: 3996
		[Token(Token = "0x20014FF")]
		[Serializable]
		public class LotteryBossBehaviorParams : LotteryBossBehaviorParams<ReviatanBossDataAsset.LotteryBossBehavior, ReviatanBossDataAsset.LotteryType>
		{
			// Token: 0x060065F2 RID: 26098 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C06")]
			[Address(RVA = "0x21876C0", Offset = "0x21877C1", VA = "0x21876C0")]
			public LotteryBossBehaviorParams()
			{
			}
		}

		// Token: 0x02000F9D RID: 3997
		[Token(Token = "0x2001500")]
		[Serializable]
		public class LotteryBossBehaviorPramsList : LotteryBossBehaviorPramsList<ReviatanBossDataAsset.LotteryBossBehaviorParams, ReviatanBossDataAsset.LotteryBossBehavior, ReviatanBossDataAsset.LotteryType>
		{
			// Token: 0x060065F3 RID: 26099 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C07")]
			[Address(RVA = "0x2187710", Offset = "0x2187811", VA = "0x2187710")]
			public LotteryBossBehaviorPramsList()
			{
			}
		}
	}
}
