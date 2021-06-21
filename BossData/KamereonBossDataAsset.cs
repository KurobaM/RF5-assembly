using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BossData
{
	// Token: 0x02000F6C RID: 3948
	[Token(Token = "0x20009FA")]
	[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x149BA0", Offset = "0x149CA1")]
	public class KamereonBossDataAsset : BossDataAssetBase
	{
		// Token: 0x060065B5 RID: 26037 RVA: 0x00022218 File Offset: 0x00020418
		[Token(Token = "0x6005474")]
		[Address(RVA = "0x245E8B0", Offset = "0x245E9B1", VA = "0x245E8B0", Slot = "7")]
		public override float GetFloatParam(string key)
		{
			return 0f;
		}

		// Token: 0x060065B6 RID: 26038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005475")]
		[Address(RVA = "0x245E990", Offset = "0x245EA91", VA = "0x245E990", Slot = "9")]
		public override BossBehaviorController AddBossBehaviorControllerBase(GameObject monster)
		{
			return null;
		}

		// Token: 0x060065B7 RID: 26039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005476")]
		[Address(RVA = "0x245E9F0", Offset = "0x245EAF1", VA = "0x245E9F0", Slot = "10")]
		public override CalcLotteryBossBehavior GetCalcLotteryBossBehavior()
		{
			return null;
		}

		// Token: 0x060065B8 RID: 26040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005477")]
		[Address(RVA = "0x245EC10", Offset = "0x245ED11", VA = "0x245EC10")]
		public KamereonBossDataAsset()
		{
		}

		// Token: 0x0400C61E RID: 50718
		[Token(Token = "0x4009393")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float StealthTimeNormal;

		// Token: 0x0400C61F RID: 50719
		[Token(Token = "0x4009394")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float StealthTimeMadness;

		// Token: 0x0400C620 RID: 50720
		[Token(Token = "0x4009395")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float StealthSlowScale;

		// Token: 0x0400C621 RID: 50721
		[Token(Token = "0x4009396")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private KamereonBossDataAsset.LotteryBossBehaviorPramsList NormalActionList;

		// Token: 0x0400C622 RID: 50722
		[Token(Token = "0x4009397")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private KamereonBossDataAsset.LotteryBossBehaviorPramsList MadnessActionList;

		// Token: 0x02000F6D RID: 3949
		[Token(Token = "0x20014DE")]
		[Serializable]
		public enum LotteryType
		{
			// Token: 0x0400C624 RID: 50724
			[Token(Token = "0x401BE98")]
			None,
			// Token: 0x0400C625 RID: 50725
			[Token(Token = "0x401BE99")]
			ThereTongueRowing_Attack,
			// Token: 0x0400C626 RID: 50726
			[Token(Token = "0x401BE9A")]
			TongueRowing_Attack,
			// Token: 0x0400C627 RID: 50727
			[Token(Token = "0x401BE9B")]
			Tongue_Attack,
			// Token: 0x0400C628 RID: 50728
			[Token(Token = "0x401BE9C")]
			Venom_Attack,
			// Token: 0x0400C629 RID: 50729
			[Token(Token = "0x401BE9D")]
			CrazyRush_Attack,
			// Token: 0x0400C62A RID: 50730
			[Token(Token = "0x401BE9E")]
			Random_Move,
			// Token: 0x0400C62B RID: 50731
			[Token(Token = "0x401BE9F")]
			StealthRelease_Other,
			// Token: 0x0400C62C RID: 50732
			[Token(Token = "0x401BEA0")]
			StealthActivate_Other,
			// Token: 0x0400C62D RID: 50733
			[Token(Token = "0x401BEA1")]
			TargetJump_Move,
			// Token: 0x0400C62E RID: 50734
			[Token(Token = "0x401BEA2")]
			BackJump_Move
		}

		// Token: 0x02000F6E RID: 3950
		[Token(Token = "0x20014DF")]
		[Serializable]
		public class LotteryBossBehavior : LotteryBossBehavior<KamereonBossDataAsset.LotteryType>
		{
			// Token: 0x060065B9 RID: 26041 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BF0")]
			[Address(RVA = "0x245ECB0", Offset = "0x245EDB1", VA = "0x245ECB0")]
			public LotteryBossBehavior()
			{
			}
		}

		// Token: 0x02000F6F RID: 3951
		[Token(Token = "0x20014E0")]
		[Serializable]
		public class LotteryBossBehaviorParams : LotteryBossBehaviorParams<KamereonBossDataAsset.LotteryBossBehavior, KamereonBossDataAsset.LotteryType>
		{
			// Token: 0x060065BA RID: 26042 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BF1")]
			[Address(RVA = "0x245ED00", Offset = "0x245EE01", VA = "0x245ED00")]
			public LotteryBossBehaviorParams()
			{
			}
		}

		// Token: 0x02000F70 RID: 3952
		[Token(Token = "0x20014E1")]
		[Serializable]
		public class LotteryBossBehaviorPramsList : LotteryBossBehaviorPramsList<KamereonBossDataAsset.LotteryBossBehaviorParams, KamereonBossDataAsset.LotteryBossBehavior, KamereonBossDataAsset.LotteryType>
		{
			// Token: 0x060065BB RID: 26043 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BF2")]
			[Address(RVA = "0x245ED50", Offset = "0x245EE51", VA = "0x245ED50")]
			public LotteryBossBehaviorPramsList()
			{
			}
		}
	}
}
