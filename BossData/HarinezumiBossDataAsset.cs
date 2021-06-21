using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BossData
{
	// Token: 0x02000F52 RID: 3922
	[Token(Token = "0x20009F2")]
	[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x149A60", Offset = "0x149B61")]
	public class HarinezumiBossDataAsset : BossDataAssetBase
	{
		// Token: 0x06006597 RID: 26007 RVA: 0x000221E8 File Offset: 0x000203E8
		[Token(Token = "0x6005462")]
		[Address(RVA = "0x245D780", Offset = "0x245D881", VA = "0x245D780", Slot = "7")]
		public override float GetFloatParam(string key)
		{
			return 0f;
		}

		// Token: 0x06006598 RID: 26008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005463")]
		[Address(RVA = "0x245D830", Offset = "0x245D931", VA = "0x245D830", Slot = "9")]
		public override BossBehaviorController AddBossBehaviorControllerBase(GameObject monster)
		{
			return null;
		}

		// Token: 0x06006599 RID: 26009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005464")]
		[Address(RVA = "0x245D890", Offset = "0x245D991", VA = "0x245D890", Slot = "10")]
		public override CalcLotteryBossBehavior GetCalcLotteryBossBehavior()
		{
			return null;
		}

		// Token: 0x0600659A RID: 26010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005465")]
		[Address(RVA = "0x245DAB0", Offset = "0x245DBB1", VA = "0x245DAB0")]
		public HarinezumiBossDataAsset()
		{
		}

		// Token: 0x0400C5D3 RID: 50643
		[Token(Token = "0x4009388")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float RespawnNeedleTime;

		// Token: 0x0400C5D4 RID: 50644
		[Token(Token = "0x4009389")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float SpinAttackHPPercentDamage;

		// Token: 0x0400C5D5 RID: 50645
		[Token(Token = "0x400938A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private HarinezumiBossDataAsset.LotteryBossBehaviorPramsList NormalActionList;

		// Token: 0x0400C5D6 RID: 50646
		[Token(Token = "0x400938B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private HarinezumiBossDataAsset.LotteryBossBehaviorPramsList MadnessActionList;

		// Token: 0x02000F53 RID: 3923
		[Token(Token = "0x20014CC")]
		[Serializable]
		public enum LotteryType
		{
			// Token: 0x0400C5D8 RID: 50648
			[Token(Token = "0x401BE58")]
			None,
			// Token: 0x0400C5D9 RID: 50649
			[Token(Token = "0x401BE59")]
			ShotNeedle_Attack,
			// Token: 0x0400C5DA RID: 50650
			[Token(Token = "0x401BE5A")]
			Rush_Attack,
			// Token: 0x0400C5DB RID: 50651
			[Token(Token = "0x401BE5B")]
			Scratch_Attack,
			// Token: 0x0400C5DC RID: 50652
			[Token(Token = "0x401BE5C")]
			Spin_Attack,
			// Token: 0x0400C5DD RID: 50653
			[Token(Token = "0x401BE5D")]
			Threate,
			// Token: 0x0400C5DE RID: 50654
			[Token(Token = "0x401BE5E")]
			Jump,
			// Token: 0x0400C5DF RID: 50655
			[Token(Token = "0x401BE5F")]
			ApproachWalk,
			// Token: 0x0400C5E0 RID: 50656
			[Token(Token = "0x401BE60")]
			ApproachDash
		}

		// Token: 0x02000F54 RID: 3924
		[Token(Token = "0x20014CD")]
		[Serializable]
		public class LotteryBossBehavior : LotteryBossBehavior<HarinezumiBossDataAsset.LotteryType>
		{
			// Token: 0x0600659B RID: 26011 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BE4")]
			[Address(RVA = "0x245DB40", Offset = "0x245DC41", VA = "0x245DB40")]
			public LotteryBossBehavior()
			{
			}
		}

		// Token: 0x02000F55 RID: 3925
		[Token(Token = "0x20014CE")]
		[Serializable]
		public class LotteryBossBehaviorParams : LotteryBossBehaviorParams<HarinezumiBossDataAsset.LotteryBossBehavior, HarinezumiBossDataAsset.LotteryType>
		{
			// Token: 0x0600659C RID: 26012 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BE5")]
			[Address(RVA = "0x245DB90", Offset = "0x245DC91", VA = "0x245DB90")]
			public LotteryBossBehaviorParams()
			{
			}
		}

		// Token: 0x02000F56 RID: 3926
		[Token(Token = "0x20014CF")]
		[Serializable]
		public class LotteryBossBehaviorPramsList : LotteryBossBehaviorPramsList<HarinezumiBossDataAsset.LotteryBossBehaviorParams, HarinezumiBossDataAsset.LotteryBossBehavior, HarinezumiBossDataAsset.LotteryType>
		{
			// Token: 0x0600659D RID: 26013 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BE6")]
			[Address(RVA = "0x245DBE0", Offset = "0x245DCE1", VA = "0x245DBE0")]
			public LotteryBossBehaviorPramsList()
			{
			}
		}
	}
}
