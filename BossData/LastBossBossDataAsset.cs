using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BossData
{
	// Token: 0x02000F86 RID: 3974
	[Token(Token = "0x2000A02")]
	[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x149CE0", Offset = "0x149DE1")]
	public class LastBossBossDataAsset : BossDataAssetBase
	{
		// Token: 0x060065D7 RID: 26071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600548A")]
		[Address(RVA = "0x245FE00", Offset = "0x245FF01", VA = "0x245FE00", Slot = "9")]
		public override BossBehaviorController AddBossBehaviorControllerBase(GameObject monster)
		{
			return null;
		}

		// Token: 0x060065D8 RID: 26072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600548B")]
		[Address(RVA = "0x245FE60", Offset = "0x245FF61", VA = "0x245FE60", Slot = "10")]
		public override CalcLotteryBossBehavior GetCalcLotteryBossBehavior()
		{
			return null;
		}

		// Token: 0x060065D9 RID: 26073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600548C")]
		[Address(RVA = "0x245FF50", Offset = "0x2460051", VA = "0x245FF50")]
		public LastBossBossDataAsset()
		{
		}

		// Token: 0x0400C67F RID: 50815
		[Token(Token = "0x40093AD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private LastBossBossDataAsset.LotteryBossBehaviorPramsList NormalActionList;

		// Token: 0x0400C680 RID: 50816
		[Token(Token = "0x40093AE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private LastBossBossDataAsset.LotteryBossBehaviorPramsList MadnessActionList;

		// Token: 0x02000F87 RID: 3975
		[Token(Token = "0x20014F0")]
		[Serializable]
		public enum LotteryType
		{
			// Token: 0x0400C682 RID: 50818
			[Token(Token = "0x401BEDF")]
			None,
			// Token: 0x0400C683 RID: 50819
			[Token(Token = "0x401BEE0")]
			Suction_Attack,
			// Token: 0x0400C684 RID: 50820
			[Token(Token = "0x401BEE1")]
			WaveCannon_Attack,
			// Token: 0x0400C685 RID: 50821
			[Token(Token = "0x401BEE2")]
			Arrow_Attack,
			// Token: 0x0400C686 RID: 50822
			[Token(Token = "0x401BEE3")]
			LaserShelling_Attack,
			// Token: 0x0400C687 RID: 50823
			[Token(Token = "0x401BEE4")]
			LaserRadiation_Attack,
			// Token: 0x0400C688 RID: 50824
			[Token(Token = "0x401BEE5")]
			Warp_Attack,
			// Token: 0x0400C689 RID: 50825
			[Token(Token = "0x401BEE6")]
			BoneDrop_Attack,
			// Token: 0x0400C68A RID: 50826
			[Token(Token = "0x401BEE7")]
			RiseHere_Attack,
			// Token: 0x0400C68B RID: 50827
			[Token(Token = "0x401BEE8")]
			DescendHere_Attack,
			// Token: 0x0400C68C RID: 50828
			[Token(Token = "0x401BEE9")]
			RiseTarget_Attack,
			// Token: 0x0400C68D RID: 50829
			[Token(Token = "0x401BEEA")]
			DescendTarget_Attack,
			// Token: 0x0400C68E RID: 50830
			[Token(Token = "0x401BEEB")]
			Loitering_Move,
			// Token: 0x0400C68F RID: 50831
			[Token(Token = "0x401BEEC")]
			GoOutSide_Move,
			// Token: 0x0400C690 RID: 50832
			[Token(Token = "0x401BEED")]
			Callapse_Other,
			// Token: 0x0400C691 RID: 50833
			[Token(Token = "0x401BEEE")]
			Point0_Move,
			// Token: 0x0400C692 RID: 50834
			[Token(Token = "0x401BEEF")]
			Point1_Move,
			// Token: 0x0400C693 RID: 50835
			[Token(Token = "0x401BEF0")]
			Point2_Move,
			// Token: 0x0400C694 RID: 50836
			[Token(Token = "0x401BEF1")]
			Point3_Move,
			// Token: 0x0400C695 RID: 50837
			[Token(Token = "0x401BEF2")]
			Point4_Move,
			// Token: 0x0400C696 RID: 50838
			[Token(Token = "0x401BEF3")]
			Point5_Move,
			// Token: 0x0400C697 RID: 50839
			[Token(Token = "0x401BEF4")]
			Point6_Move,
			// Token: 0x0400C698 RID: 50840
			[Token(Token = "0x401BEF5")]
			Point7_Move,
			// Token: 0x0400C699 RID: 50841
			[Token(Token = "0x401BEF6")]
			Point0_LookAt,
			// Token: 0x0400C69A RID: 50842
			[Token(Token = "0x401BEF7")]
			Point1_LookAt,
			// Token: 0x0400C69B RID: 50843
			[Token(Token = "0x401BEF8")]
			Point2_LookAt,
			// Token: 0x0400C69C RID: 50844
			[Token(Token = "0x401BEF9")]
			Point3_LookAt,
			// Token: 0x0400C69D RID: 50845
			[Token(Token = "0x401BEFA")]
			Point4_LookAt,
			// Token: 0x0400C69E RID: 50846
			[Token(Token = "0x401BEFB")]
			Point5_LookAt,
			// Token: 0x0400C69F RID: 50847
			[Token(Token = "0x401BEFC")]
			Point6_LookAt,
			// Token: 0x0400C6A0 RID: 50848
			[Token(Token = "0x401BEFD")]
			Point7_LookAt,
			// Token: 0x0400C6A1 RID: 50849
			[Token(Token = "0x401BEFE")]
			Attack12,
			// Token: 0x0400C6A2 RID: 50850
			[Token(Token = "0x401BEFF")]
			Attack13,
			// Token: 0x0400C6A3 RID: 50851
			[Token(Token = "0x401BF00")]
			Point8_Move,
			// Token: 0x0400C6A4 RID: 50852
			[Token(Token = "0x401BF01")]
			Point8_LookAt
		}

		// Token: 0x02000F88 RID: 3976
		[Token(Token = "0x20014F1")]
		[Serializable]
		public class LotteryBossBehavior : LotteryBossBehavior<LastBossBossDataAsset.LotteryType>
		{
			// Token: 0x060065DA RID: 26074 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BFC")]
			[Address(RVA = "0x2186CF0", Offset = "0x2186DF1", VA = "0x2186CF0")]
			public LotteryBossBehavior()
			{
			}
		}

		// Token: 0x02000F89 RID: 3977
		[Token(Token = "0x20014F2")]
		[Serializable]
		public class LotteryBossBehaviorParams : LotteryBossBehaviorParams<LastBossBossDataAsset.LotteryBossBehavior, LastBossBossDataAsset.LotteryType>
		{
			// Token: 0x060065DB RID: 26075 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BFD")]
			[Address(RVA = "0x2186D40", Offset = "0x2186E41", VA = "0x2186D40")]
			public LotteryBossBehaviorParams()
			{
			}
		}

		// Token: 0x02000F8A RID: 3978
		[Token(Token = "0x20014F3")]
		[Serializable]
		public class LotteryBossBehaviorPramsList : LotteryBossBehaviorPramsList<LastBossBossDataAsset.LotteryBossBehaviorParams, LastBossBossDataAsset.LotteryBossBehavior, LastBossBossDataAsset.LotteryType>
		{
			// Token: 0x060065DC RID: 26076 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BFE")]
			[Address(RVA = "0x2186D90", Offset = "0x2186E91", VA = "0x2186D90")]
			public LotteryBossBehaviorPramsList()
			{
			}
		}
	}
}
