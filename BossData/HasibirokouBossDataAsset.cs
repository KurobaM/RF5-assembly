using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BossData
{
	// Token: 0x02000F59 RID: 3929
	[Token(Token = "0x20009F4")]
	[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x149AB0", Offset = "0x149BB1")]
	public class HasibirokouBossDataAsset : BossDataAssetBase
	{
		// Token: 0x0600659F RID: 26015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005467")]
		[Address(RVA = "0x245DC30", Offset = "0x245DD31", VA = "0x245DC30", Slot = "9")]
		public override BossBehaviorController AddBossBehaviorControllerBase(GameObject monster)
		{
			return null;
		}

		// Token: 0x060065A0 RID: 26016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005468")]
		[Address(RVA = "0x245DC90", Offset = "0x245DD91", VA = "0x245DC90", Slot = "10")]
		public override CalcLotteryBossBehavior GetCalcLotteryBossBehavior()
		{
			return null;
		}

		// Token: 0x060065A1 RID: 26017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005469")]
		[Address(RVA = "0x245DEB0", Offset = "0x245DFB1", VA = "0x245DEB0")]
		public HasibirokouBossDataAsset()
		{
		}

		// Token: 0x0400C5E4 RID: 50660
		[Token(Token = "0x400938C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private HasibirokouBossDataAsset.LotteryBossBehaviorPramsList NormalActionList;

		// Token: 0x0400C5E5 RID: 50661
		[Token(Token = "0x400938D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private HasibirokouBossDataAsset.LotteryBossBehaviorPramsList MadnessActionList;

		// Token: 0x02000F5A RID: 3930
		[Token(Token = "0x20014D1")]
		[Serializable]
		public enum LotteryType
		{
			// Token: 0x0400C5E7 RID: 50663
			[Token(Token = "0x401BE65")]
			None,
			// Token: 0x0400C5E8 RID: 50664
			[Token(Token = "0x401BE66")]
			Peck_Attack,
			// Token: 0x0400C5E9 RID: 50665
			[Token(Token = "0x401BE67")]
			DashPeck_Attack,
			// Token: 0x0400C5EA RID: 50666
			[Token(Token = "0x401BE68")]
			Jump_Attack,
			// Token: 0x0400C5EB RID: 50667
			[Token(Token = "0x401BE69")]
			FeatherBlowStraight_Attack,
			// Token: 0x0400C5EC RID: 50668
			[Token(Token = "0x401BE6A")]
			FeatherBlowDiffusion_Attack,
			// Token: 0x0400C5ED RID: 50669
			[Token(Token = "0x401BE6B")]
			SonicStorm_Attack,
			// Token: 0x0400C5EE RID: 50670
			[Token(Token = "0x401BE6C")]
			WindLaser_Attack,
			// Token: 0x0400C5EF RID: 50671
			[Token(Token = "0x401BE6D")]
			TwoWindLaser_Attack,
			// Token: 0x0400C5F0 RID: 50672
			[Token(Token = "0x401BE6E")]
			Tonguing_Attack,
			// Token: 0x0400C5F1 RID: 50673
			[Token(Token = "0x401BE6F")]
			SonicWindScatter_Attack,
			// Token: 0x0400C5F2 RID: 50674
			[Token(Token = "0x401BE70")]
			Recovery_Other,
			// Token: 0x0400C5F3 RID: 50675
			[Token(Token = "0x401BE71")]
			SonicStormMadness_Attack,
			// Token: 0x0400C5F4 RID: 50676
			[Token(Token = "0x401BE72")]
			StartMenacing_Other
		}

		// Token: 0x02000F5B RID: 3931
		[Token(Token = "0x20014D2")]
		[Serializable]
		public class LotteryBossBehavior : LotteryBossBehavior<HasibirokouBossDataAsset.LotteryType>
		{
			// Token: 0x060065A2 RID: 26018 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BE7")]
			[Address(RVA = "0x245DF40", Offset = "0x245E041", VA = "0x245DF40")]
			public LotteryBossBehavior()
			{
			}
		}

		// Token: 0x02000F5C RID: 3932
		[Token(Token = "0x20014D3")]
		[Serializable]
		public class LotteryBossBehaviorParams : LotteryBossBehaviorParams<HasibirokouBossDataAsset.LotteryBossBehavior, HasibirokouBossDataAsset.LotteryType>
		{
			// Token: 0x060065A3 RID: 26019 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BE8")]
			[Address(RVA = "0x245DF90", Offset = "0x245E091", VA = "0x245DF90")]
			public LotteryBossBehaviorParams()
			{
			}
		}

		// Token: 0x02000F5D RID: 3933
		[Token(Token = "0x20014D4")]
		[Serializable]
		public class LotteryBossBehaviorPramsList : LotteryBossBehaviorPramsList<HasibirokouBossDataAsset.LotteryBossBehaviorParams, HasibirokouBossDataAsset.LotteryBossBehavior, HasibirokouBossDataAsset.LotteryType>
		{
			// Token: 0x060065A4 RID: 26020 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BE9")]
			[Address(RVA = "0x245DFE0", Offset = "0x245E0E1", VA = "0x245DFE0")]
			public LotteryBossBehaviorPramsList()
			{
			}
		}
	}
}
