using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BossData
{
	// Token: 0x02000F79 RID: 3961
	[Token(Token = "0x20009FE")]
	[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x149C40", Offset = "0x149D41")]
	public class KurageBossDataAsset : BossDataAssetBase
	{
		// Token: 0x060065C6 RID: 26054 RVA: 0x00022248 File Offset: 0x00020448
		[Token(Token = "0x600547F")]
		[Address(RVA = "0x245F2B0", Offset = "0x245F3B1", VA = "0x245F2B0", Slot = "7")]
		public override float GetFloatParam(string key)
		{
			return 0f;
		}

		// Token: 0x060065C7 RID: 26055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005480")]
		[Address(RVA = "0x245F390", Offset = "0x245F491", VA = "0x245F390", Slot = "9")]
		public override BossBehaviorController AddBossBehaviorControllerBase(GameObject monster)
		{
			return null;
		}

		// Token: 0x060065C8 RID: 26056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005481")]
		[Address(RVA = "0x245F3F0", Offset = "0x245F4F1", VA = "0x245F3F0", Slot = "10")]
		public override CalcLotteryBossBehavior GetCalcLotteryBossBehavior()
		{
			return null;
		}

		// Token: 0x060065C9 RID: 26057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005482")]
		[Address(RVA = "0x245F610", Offset = "0x245F711", VA = "0x245F610")]
		public KurageBossDataAsset()
		{
		}

		// Token: 0x0400C64B RID: 50763
		[Token(Token = "0x400939C")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		public Vector3 ChargingEffectPos;

		// Token: 0x0400C64C RID: 50764
		[Token(Token = "0x400939D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		public Vector3 ChargingEffectScale;

		// Token: 0x0400C64D RID: 50765
		[Token(Token = "0x400939E")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float HitAttackResetTime;

		// Token: 0x0400C64E RID: 50766
		[Token(Token = "0x400939F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float HitAttackChargePercent;

		// Token: 0x0400C64F RID: 50767
		[Token(Token = "0x40093A0")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float NotHitAttackChargePercent;

		// Token: 0x0400C650 RID: 50768
		[Token(Token = "0x40093A1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private KurageBossDataAsset.LotteryBossBehaviorPramsList NormalActionList;

		// Token: 0x0400C651 RID: 50769
		[Token(Token = "0x40093A2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private KurageBossDataAsset.LotteryBossBehaviorPramsList MadnessActionList;

		// Token: 0x02000F7A RID: 3962
		[Token(Token = "0x20014E7")]
		[Serializable]
		public enum LotteryType
		{
			// Token: 0x0400C653 RID: 50771
			[Token(Token = "0x401BEBC")]
			None,
			// Token: 0x0400C654 RID: 50772
			[Token(Token = "0x401BEBD")]
			Threate_Around_Move,
			// Token: 0x0400C655 RID: 50773
			[Token(Token = "0x401BEBE")]
			Around_Move,
			// Token: 0x0400C656 RID: 50774
			[Token(Token = "0x401BEBF")]
			Leave_Bubble_Move,
			// Token: 0x0400C657 RID: 50775
			[Token(Token = "0x401BEC0")]
			Bubble_Attack,
			// Token: 0x0400C658 RID: 50776
			[Token(Token = "0x401BEC1")]
			Threate_Tornado_Attack,
			// Token: 0x0400C659 RID: 50777
			[Token(Token = "0x401BEC2")]
			ExplosionLightning_Attack,
			// Token: 0x0400C65A RID: 50778
			[Token(Token = "0x401BEC3")]
			Tentacle_Thrust_Attack,
			// Token: 0x0400C65B RID: 50779
			[Token(Token = "0x401BEC4")]
			Lightning_Attack,
			// Token: 0x0400C65C RID: 50780
			[Token(Token = "0x401BEC5")]
			HomingLightning_Attack,
			// Token: 0x0400C65D RID: 50781
			[Token(Token = "0x401BEC6")]
			ThunderShower_Attack,
			// Token: 0x0400C65E RID: 50782
			[Token(Token = "0x401BEC7")]
			IsElectroCharge,
			// Token: 0x0400C65F RID: 50783
			[Token(Token = "0x401BEC8")]
			Dush_Close,
			// Token: 0x0400C660 RID: 50784
			[Token(Token = "0x401BEC9")]
			Jump_Close
		}

		// Token: 0x02000F7B RID: 3963
		[Token(Token = "0x20014E8")]
		[Serializable]
		public class LotteryBossBehavior : LotteryBossBehavior<KurageBossDataAsset.LotteryType>
		{
			// Token: 0x060065CA RID: 26058 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BF6")]
			[Address(RVA = "0x245F700", Offset = "0x245F801", VA = "0x245F700")]
			public LotteryBossBehavior()
			{
			}
		}

		// Token: 0x02000F7C RID: 3964
		[Token(Token = "0x20014E9")]
		[Serializable]
		public class LotteryBossBehaviorParams : LotteryBossBehaviorParams<KurageBossDataAsset.LotteryBossBehavior, KurageBossDataAsset.LotteryType>
		{
			// Token: 0x060065CB RID: 26059 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BF7")]
			[Address(RVA = "0x245F750", Offset = "0x245F851", VA = "0x245F750")]
			public LotteryBossBehaviorParams()
			{
			}
		}

		// Token: 0x02000F7D RID: 3965
		[Token(Token = "0x20014EA")]
		[Serializable]
		public class LotteryBossBehaviorPramsList : LotteryBossBehaviorPramsList<KurageBossDataAsset.LotteryBossBehaviorParams, KurageBossDataAsset.LotteryBossBehavior, KurageBossDataAsset.LotteryType>
		{
			// Token: 0x060065CC RID: 26060 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BF8")]
			[Address(RVA = "0x245F7A0", Offset = "0x245F8A1", VA = "0x245F7A0")]
			public LotteryBossBehaviorPramsList()
			{
			}
		}
	}
}
