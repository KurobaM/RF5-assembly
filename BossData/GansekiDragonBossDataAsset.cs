using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BossData
{
	// Token: 0x02000F4B RID: 3915
	[Token(Token = "0x20009F0")]
	[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x149A10", Offset = "0x149B11")]
	public class GansekiDragonBossDataAsset : BossDataAssetBase
	{
		// Token: 0x06006589 RID: 25993 RVA: 0x000221A0 File Offset: 0x000203A0
		[Token(Token = "0x6005457")]
		[Address(RVA = "0x245CFA0", Offset = "0x245D0A1", VA = "0x245CFA0", Slot = "7")]
		public override float GetFloatParam(string key)
		{
			return 0f;
		}

		// Token: 0x0600658A RID: 25994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005458")]
		[Address(RVA = "0x245D0E0", Offset = "0x245D1E1", VA = "0x245D0E0", Slot = "9")]
		public override BossBehaviorController AddBossBehaviorControllerBase(GameObject monster)
		{
			return null;
		}

		// Token: 0x0600658B RID: 25995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005459")]
		[Address(RVA = "0x245D140", Offset = "0x245D241", VA = "0x245D140", Slot = "10")]
		public override CalcLotteryBossBehavior GetCalcLotteryBossBehavior()
		{
			return null;
		}

		// Token: 0x0600658C RID: 25996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600545A")]
		[Address(RVA = "0x245D330", Offset = "0x245D431", VA = "0x245D330")]
		public GansekiDragonBossDataAsset()
		{
		}

		// Token: 0x0400C5A8 RID: 50600
		[Token(Token = "0x400937A")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x17FC10", Offset = "0x17FD11")]
		[SerializeField]
		private int NormalLoopPattenMax;

		// Token: 0x0400C5A9 RID: 50601
		[Token(Token = "0x400937B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int MadnessLoopPattenMax;

		// Token: 0x0400C5AA RID: 50602
		[Token(Token = "0x400937C")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float AccumulatedDamageMimicry;

		// Token: 0x0400C5AB RID: 50603
		[Token(Token = "0x400937D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float DefencelayerDamageRate;

		// Token: 0x0400C5AC RID: 50604
		[Token(Token = "0x400937E")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float MimicryWaitTime;

		// Token: 0x0400C5AD RID: 50605
		[Token(Token = "0x400937F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float ForceReleaseMimicryDamageRate;

		// Token: 0x0400C5AE RID: 50606
		[Token(Token = "0x4009380")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float ForceReleaseMimicryDamageRateTime;

		// Token: 0x0400C5AF RID: 50607
		[Token(Token = "0x4009381")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GansekiDragonBossDataAsset.LotteryBossBehaviorPramsList NormalAttackActionList;

		// Token: 0x0400C5B0 RID: 50608
		[Token(Token = "0x4009382")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GansekiDragonBossDataAsset.LotteryBossBehaviorPramsList MadnessAttackActionList;

		// Token: 0x0400C5B1 RID: 50609
		[Token(Token = "0x4009383")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GansekiDragonBossDataAsset.LotteryBossBehaviorPramsList MimicryAttackActionList;

		// Token: 0x02000F4C RID: 3916
		[Token(Token = "0x20014C7")]
		[Serializable]
		public enum LotteryType
		{
			// Token: 0x0400C5B3 RID: 50611
			[Token(Token = "0x401BE3B")]
			None,
			// Token: 0x0400C5B4 RID: 50612
			[Token(Token = "0x401BE3C")]
			Rush_Attack,
			// Token: 0x0400C5B5 RID: 50613
			[Token(Token = "0x401BE3D")]
			DoubleRush_Attack,
			// Token: 0x0400C5B6 RID: 50614
			[Token(Token = "0x401BE3E")]
			Trampling_Attack,
			// Token: 0x0400C5B7 RID: 50615
			[Token(Token = "0x401BE3F")]
			HeadButt_Attack,
			// Token: 0x0400C5B8 RID: 50616
			[Token(Token = "0x401BE40")]
			JumpPress_Attack,
			// Token: 0x0400C5B9 RID: 50617
			[Token(Token = "0x401BE41")]
			RockSkipping_Attack,
			// Token: 0x0400C5BA RID: 50618
			[Token(Token = "0x401BE42")]
			TiltTrampling_Attack,
			// Token: 0x0400C5BB RID: 50619
			[Token(Token = "0x401BE43")]
			DoubleEarthSpike_Attack,
			// Token: 0x0400C5BC RID: 50620
			[Token(Token = "0x401BE44")]
			TripleEarthSpike_Attack,
			// Token: 0x0400C5BD RID: 50621
			[Token(Token = "0x401BE45")]
			AvengerRock_Attack,
			// Token: 0x0400C5BE RID: 50622
			[Token(Token = "0x401BE46")]
			RockMimicry_Start,
			// Token: 0x0400C5BF RID: 50623
			[Token(Token = "0x401BE47")]
			RockMimicryRush_Attack,
			// Token: 0x0400C5C0 RID: 50624
			[Token(Token = "0x401BE48")]
			DoubleRockMimicryRush_Attack,
			// Token: 0x0400C5C1 RID: 50625
			[Token(Token = "0x401BE49")]
			RockMimicry_Release,
			// Token: 0x0400C5C2 RID: 50626
			[Token(Token = "0x401BE4A")]
			EatRock1_Attack,
			// Token: 0x0400C5C3 RID: 50627
			[Token(Token = "0x401BE4B")]
			EatRock2_Attack,
			// Token: 0x0400C5C4 RID: 50628
			[Token(Token = "0x401BE4C")]
			Rush_Move,
			// Token: 0x0400C5C5 RID: 50629
			[Token(Token = "0x401BE4D")]
			MimicryWait1,
			// Token: 0x0400C5C6 RID: 50630
			[Token(Token = "0x401BE4E")]
			RockMimicryJump_Attack,
			// Token: 0x0400C5C7 RID: 50631
			[Token(Token = "0x401BE4F")]
			Angry_Other,
			// Token: 0x0400C5C8 RID: 50632
			[Token(Token = "0x401BE50")]
			RockMimicryMagic_Attack,
			// Token: 0x0400C5C9 RID: 50633
			[Token(Token = "0x401BE51")]
			MimicryWait2
		}

		// Token: 0x02000F4D RID: 3917
		[Token(Token = "0x20014C8")]
		[Serializable]
		public class LotteryBossBehavior : LotteryBossBehavior<GansekiDragonBossDataAsset.LotteryType>
		{
			// Token: 0x0600658D RID: 25997 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BE1")]
			[Address(RVA = "0x245D3F0", Offset = "0x245D4F1", VA = "0x245D3F0")]
			public LotteryBossBehavior()
			{
			}
		}

		// Token: 0x02000F4E RID: 3918
		[Token(Token = "0x20014C9")]
		[Serializable]
		public class LotteryBossBehaviorParams : LotteryBossBehaviorParams<GansekiDragonBossDataAsset.LotteryBossBehavior, GansekiDragonBossDataAsset.LotteryType>
		{
			// Token: 0x0600658E RID: 25998 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BE2")]
			[Address(RVA = "0x245D440", Offset = "0x245D541", VA = "0x245D440")]
			public LotteryBossBehaviorParams()
			{
			}
		}

		// Token: 0x02000F4F RID: 3919
		[Token(Token = "0x20014CA")]
		[Serializable]
		public class LotteryBossBehaviorPramsList : LotteryBossBehaviorPramsList<GansekiDragonBossDataAsset.LotteryBossBehaviorParams, GansekiDragonBossDataAsset.LotteryBossBehavior, GansekiDragonBossDataAsset.LotteryType>
		{
			// Token: 0x0600658F RID: 25999 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BE3")]
			[Address(RVA = "0x245D490", Offset = "0x245D591", VA = "0x245D490")]
			public LotteryBossBehaviorPramsList()
			{
			}
		}
	}
}
