using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace BossData
{
	// Token: 0x02000F37 RID: 3895
	[Token(Token = "0x20009EA")]
	[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x149920", Offset = "0x149A21")]
	public class DeadtreeBossDataAsset : BossDataAssetBase
	{
		// Token: 0x06006566 RID: 25958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600543F")]
		[Address(RVA = "0x245B9D0", Offset = "0x245BAD1", VA = "0x245B9D0", Slot = "9")]
		public override BossBehaviorController AddBossBehaviorControllerBase(GameObject monster)
		{
			return null;
		}

		// Token: 0x06006567 RID: 25959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005440")]
		[Address(RVA = "0x245BA30", Offset = "0x245BB31", VA = "0x245BA30", Slot = "10")]
		public override CalcLotteryBossBehavior GetCalcLotteryBossBehavior()
		{
			return null;
		}

		// Token: 0x06006568 RID: 25960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005441")]
		[Address(RVA = "0x245BC50", Offset = "0x245BD51", VA = "0x245BC50")]
		public DeadtreeBossDataAsset()
		{
		}

		// Token: 0x0400C53A RID: 50490
		[Token(Token = "0x400935C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<DeadtreeBossDataAsset.LotteryParam> ActionList;

		// Token: 0x0400C53B RID: 50491
		[Token(Token = "0x400935D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<DeadtreeBossDataAsset.LotteryParam> ExistBurrActionList;

		// Token: 0x0400C53C RID: 50492
		[Token(Token = "0x400935E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<DeadtreeBossDataAsset.LotteryParam> MadnessActionList;

		// Token: 0x0400C53D RID: 50493
		[Token(Token = "0x400935F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<DeadtreeBossDataAsset.LotteryParam> ExistBurrMadnessActionList;

		// Token: 0x0400C53E RID: 50494
		[Token(Token = "0x4009360")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<DeadtreeBossDataAsset.LotteryParam> DamageActionList;

		// Token: 0x02000F38 RID: 3896
		[Token(Token = "0x20014B9")]
		[Serializable]
		public enum LotteryType
		{
			// Token: 0x0400C540 RID: 50496
			[Token(Token = "0x401BDEB")]
			None,
			// Token: 0x0400C541 RID: 50497
			[Token(Token = "0x401BDEC")]
			Wait,
			// Token: 0x0400C542 RID: 50498
			[Token(Token = "0x401BDED")]
			Around_Move,
			// Token: 0x0400C543 RID: 50499
			[Token(Token = "0x401BDEE")]
			Leave_Move,
			// Token: 0x0400C544 RID: 50500
			[Token(Token = "0x401BDEF")]
			Stripping,
			// Token: 0x0400C545 RID: 50501
			[Token(Token = "0x401BDF0")]
			BurrBarrier,
			// Token: 0x0400C546 RID: 50502
			[Token(Token = "0x401BDF1")]
			RespawnBurr,
			// Token: 0x0400C547 RID: 50503
			[Token(Token = "0x401BDF2")]
			JumpAction,
			// Token: 0x0400C548 RID: 50504
			[Token(Token = "0x401BDF3")]
			NoiseofTree,
			// Token: 0x0400C549 RID: 50505
			[Token(Token = "0x401BDF4")]
			BurrBomb
		}

		// Token: 0x02000F39 RID: 3897
		[Token(Token = "0x20014BA")]
		[Serializable]
		public class LotteryParam : BossLotteryParam<DeadtreeBossDataAsset.LotteryType>
		{
			// Token: 0x06006569 RID: 25961 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BD6")]
			[Address(RVA = "0x245BCE0", Offset = "0x245BDE1", VA = "0x245BCE0")]
			public LotteryParam()
			{
			}
		}
	}
}
