using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BossData
{
	// Token: 0x02000F12 RID: 3858
	[Token(Token = "0x20009D9")]
	[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x1497E0", Offset = "0x1498E1")]
	public class AriesBossDataAsset : BossDataAssetBase
	{
		// Token: 0x06006503 RID: 25859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053ED")]
		[Address(RVA = "0x2459850", Offset = "0x2459951", VA = "0x2459850", Slot = "9")]
		public override BossBehaviorController AddBossBehaviorControllerBase(GameObject monster)
		{
			return null;
		}

		// Token: 0x06006504 RID: 25860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053EE")]
		[Address(RVA = "0x24598B0", Offset = "0x24599B1", VA = "0x24598B0", Slot = "10")]
		public override CalcLotteryBossBehavior GetCalcLotteryBossBehavior()
		{
			return null;
		}

		// Token: 0x06006505 RID: 25861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053EF")]
		[Address(RVA = "0x2459AD0", Offset = "0x2459BD1", VA = "0x2459AD0")]
		public AriesBossDataAsset()
		{
		}

		// Token: 0x0400C49F RID: 50335
		[Token(Token = "0x4009315")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AriesBossDataAsset.LotteryBossBehaviorPramsList NormalActionList;

		// Token: 0x0400C4A0 RID: 50336
		[Token(Token = "0x4009316")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AriesBossDataAsset.LotteryBossBehaviorPramsList MadnessActionList;

		// Token: 0x02000F13 RID: 3859
		[Token(Token = "0x20014A5")]
		[Serializable]
		public enum LotteryType
		{
			// Token: 0x0400C4A2 RID: 50338
			[Token(Token = "0x401BD97")]
			None,
			// Token: 0x0400C4A3 RID: 50339
			[Token(Token = "0x401BD98")]
			Around_Move,
			// Token: 0x0400C4A4 RID: 50340
			[Token(Token = "0x401BD99")]
			ElectricHairball_Attack,
			// Token: 0x0400C4A5 RID: 50341
			[Token(Token = "0x401BD9A")]
			RushSliding_Attack,
			// Token: 0x0400C4A6 RID: 50342
			[Token(Token = "0x401BD9B")]
			MadnessRushSliding_Attack,
			// Token: 0x0400C4A7 RID: 50343
			[Token(Token = "0x401BD9C")]
			HornSwing_Attack,
			// Token: 0x0400C4A8 RID: 50344
			[Token(Token = "0x401BD9D")]
			SoundWave_Attack,
			// Token: 0x0400C4A9 RID: 50345
			[Token(Token = "0x401BD9E")]
			MadnessSoundWave_Attack,
			// Token: 0x0400C4AA RID: 50346
			[Token(Token = "0x401BD9F")]
			Bouncing_Attack,
			// Token: 0x0400C4AB RID: 50347
			[Token(Token = "0x401BDA0")]
			BackBehavior,
			// Token: 0x0400C4AC RID: 50348
			[Token(Token = "0x401BDA1")]
			NextBehavior
		}

		// Token: 0x02000F14 RID: 3860
		[Token(Token = "0x20014A6")]
		[Serializable]
		public class LotteryBossBehavior : LotteryBossBehavior<AriesBossDataAsset.LotteryType>
		{
			// Token: 0x06006506 RID: 25862 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BC5")]
			[Address(RVA = "0x2459B60", Offset = "0x2459C61", VA = "0x2459B60")]
			public LotteryBossBehavior()
			{
			}
		}

		// Token: 0x02000F15 RID: 3861
		[Token(Token = "0x20014A7")]
		[Serializable]
		public class LotteryBossBehaviorParams : LotteryBossBehaviorParams<AriesBossDataAsset.LotteryBossBehavior, AriesBossDataAsset.LotteryType>
		{
			// Token: 0x06006507 RID: 25863 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BC6")]
			[Address(RVA = "0x2459BB0", Offset = "0x2459CB1", VA = "0x2459BB0")]
			public LotteryBossBehaviorParams()
			{
			}
		}

		// Token: 0x02000F16 RID: 3862
		[Token(Token = "0x20014A8")]
		[Serializable]
		public class LotteryBossBehaviorPramsList : LotteryBossBehaviorPramsList<AriesBossDataAsset.LotteryBossBehaviorParams, AriesBossDataAsset.LotteryBossBehavior, AriesBossDataAsset.LotteryType>
		{
			// Token: 0x06006508 RID: 25864 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BC7")]
			[Address(RVA = "0x2459C00", Offset = "0x2459D01", VA = "0x2459C00")]
			public LotteryBossBehaviorPramsList()
			{
			}
		}
	}
}
