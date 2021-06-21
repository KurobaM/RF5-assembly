using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BossData
{
	// Token: 0x02000F0B RID: 3851
	[Token(Token = "0x20009D7")]
	[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x149790", Offset = "0x149891")]
	public class AracneBossDataAsset : BossDataAssetBase
	{
		// Token: 0x060064F9 RID: 25849 RVA: 0x00021D38 File Offset: 0x0001FF38
		[Token(Token = "0x60053E6")]
		[Address(RVA = "0x2459180", Offset = "0x2459281", VA = "0x2459180", Slot = "6")]
		public override int GetIntParam(string key)
		{
			return 0;
		}

		// Token: 0x060064FA RID: 25850 RVA: 0x00021D50 File Offset: 0x0001FF50
		[Token(Token = "0x60053E7")]
		[Address(RVA = "0x2459210", Offset = "0x2459311", VA = "0x2459210", Slot = "7")]
		public override float GetFloatParam(string key)
		{
			return 0f;
		}

		// Token: 0x060064FB RID: 25851 RVA: 0x00021D68 File Offset: 0x0001FF68
		[Token(Token = "0x60053E8")]
		[Address(RVA = "0x24592A0", Offset = "0x24593A1", VA = "0x24592A0", Slot = "4")]
		public override float ChangeMadnessRemainHPPercent(bool isColorVariation, MonsterDataID id)
		{
			return 0f;
		}

		// Token: 0x060064FC RID: 25852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053E9")]
		[Address(RVA = "0x24592F0", Offset = "0x24593F1", VA = "0x24592F0", Slot = "9")]
		public override BossBehaviorController AddBossBehaviorControllerBase(GameObject monster)
		{
			return null;
		}

		// Token: 0x060064FD RID: 25853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053EA")]
		[Address(RVA = "0x2459350", Offset = "0x2459451", VA = "0x2459350", Slot = "10")]
		public override CalcLotteryBossBehavior GetCalcLotteryBossBehavior()
		{
			return null;
		}

		// Token: 0x060064FE RID: 25854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053EB")]
		[Address(RVA = "0x2459570", Offset = "0x2459671", VA = "0x2459570")]
		public AracneBossDataAsset()
		{
		}

		// Token: 0x0400C48E RID: 50318
		[Token(Token = "0x4009310")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float AccumulatedDamage;

		// Token: 0x0400C48F RID: 50319
		[Token(Token = "0x4009311")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int MaxSpider;

		// Token: 0x0400C490 RID: 50320
		[Token(Token = "0x4009312")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AracneBossDataAsset.LotteryBossBehaviorPramsList NormalActionList;

		// Token: 0x0400C491 RID: 50321
		[Token(Token = "0x4009313")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AracneBossDataAsset.LotteryBossBehaviorPramsList MadnessActionList;

		// Token: 0x0400C492 RID: 50322
		[Token(Token = "0x4009314")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x17F5D0", Offset = "0x17F6D1")]
		[SerializeField]
		private float EventChangeMadnessRemainHPPercent;

		// Token: 0x02000F0C RID: 3852
		[Token(Token = "0x20014A0")]
		[Serializable]
		public enum LotteryType
		{
			// Token: 0x0400C494 RID: 50324
			[Token(Token = "0x401BD8B")]
			None,
			// Token: 0x0400C495 RID: 50325
			[Token(Token = "0x401BD8C")]
			BothfeetStab_Attack,
			// Token: 0x0400C496 RID: 50326
			[Token(Token = "0x401BD8D")]
			FlatWeb_Attack,
			// Token: 0x0400C497 RID: 50327
			[Token(Token = "0x401BD8E")]
			EightfeetStab_Attack,
			// Token: 0x0400C498 RID: 50328
			[Token(Token = "0x401BD8F")]
			RapidVenom_Attack,
			// Token: 0x0400C499 RID: 50329
			[Token(Token = "0x401BD90")]
			SprinklingVenom_Attack,
			// Token: 0x0400C49A RID: 50330
			[Token(Token = "0x401BD91")]
			MasterSpiderSpawn_Other
		}

		// Token: 0x02000F0D RID: 3853
		[Token(Token = "0x20014A1")]
		[Serializable]
		public class LotteryBossBehavior : LotteryBossBehavior<AracneBossDataAsset.LotteryType>
		{
			// Token: 0x060064FF RID: 25855 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BC2")]
			[Address(RVA = "0x24596B0", Offset = "0x24597B1", VA = "0x24596B0")]
			public LotteryBossBehavior()
			{
			}
		}

		// Token: 0x02000F0E RID: 3854
		[Token(Token = "0x20014A2")]
		[Serializable]
		public class LotteryBossBehaviorParams : LotteryBossBehaviorParams<AracneBossDataAsset.LotteryBossBehavior, AracneBossDataAsset.LotteryType>
		{
			// Token: 0x06006500 RID: 25856 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BC3")]
			[Address(RVA = "0x2459700", Offset = "0x2459801", VA = "0x2459700")]
			public LotteryBossBehaviorParams()
			{
			}
		}

		// Token: 0x02000F0F RID: 3855
		[Token(Token = "0x20014A3")]
		[Serializable]
		public class LotteryBossBehaviorPramsList : LotteryBossBehaviorPramsList<AracneBossDataAsset.LotteryBossBehaviorParams, AracneBossDataAsset.LotteryBossBehavior, AracneBossDataAsset.LotteryType>
		{
			// Token: 0x06006501 RID: 25857 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BC4")]
			[Address(RVA = "0x2459750", Offset = "0x2459851", VA = "0x2459750")]
			public LotteryBossBehaviorPramsList()
			{
			}
		}
	}
}
