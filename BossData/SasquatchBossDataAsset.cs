using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BossData
{
	// Token: 0x02000FA0 RID: 4000
	[Token(Token = "0x2000A0A")]
	[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x149E20", Offset = "0x149F21")]
	public class SasquatchBossDataAsset : BossDataAssetBase
	{
		// Token: 0x060065F6 RID: 26102 RVA: 0x000222C0 File Offset: 0x000204C0
		[Token(Token = "0x600549D")]
		[Address(RVA = "0x2187800", Offset = "0x2187901", VA = "0x2187800", Slot = "7")]
		public override float GetFloatParam(string key)
		{
			return 0f;
		}

		// Token: 0x060065F7 RID: 26103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600549E")]
		[Address(RVA = "0x21878C0", Offset = "0x21879C1", VA = "0x21878C0", Slot = "9")]
		public override BossBehaviorController AddBossBehaviorControllerBase(GameObject monster)
		{
			return null;
		}

		// Token: 0x060065F8 RID: 26104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600549F")]
		[Address(RVA = "0x2187920", Offset = "0x2187A21", VA = "0x2187920", Slot = "10")]
		public override CalcLotteryBossBehavior GetCalcLotteryBossBehavior()
		{
			return null;
		}

		// Token: 0x060065F9 RID: 26105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054A0")]
		[Address(RVA = "0x2187A20", Offset = "0x2187B21", VA = "0x2187A20")]
		public SasquatchBossDataAsset()
		{
		}

		// Token: 0x0400C6D8 RID: 50904
		[Token(Token = "0x40093B9")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float WalkRange;

		// Token: 0x0400C6D9 RID: 50905
		[Token(Token = "0x40093BA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float RestraintDamageRate;

		// Token: 0x0400C6DA RID: 50906
		[Token(Token = "0x40093BB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SasquatchBossDataAsset.LotteryBossBehaviorPramsList NormalActionList;

		// Token: 0x0400C6DB RID: 50907
		[Token(Token = "0x40093BC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SasquatchBossDataAsset.LotteryBossBehaviorPramsList MadnessActionList;

		// Token: 0x02000FA1 RID: 4001
		[Token(Token = "0x2001502")]
		[Serializable]
		public enum LotteryType
		{
			// Token: 0x0400C6DD RID: 50909
			[Token(Token = "0x401BF2C")]
			None,
			// Token: 0x0400C6DE RID: 50910
			[Token(Token = "0x401BF2D")]
			HipPress_Attack,
			// Token: 0x0400C6DF RID: 50911
			[Token(Token = "0x401BF2E")]
			WildSwing_Attack,
			// Token: 0x0400C6E0 RID: 50912
			[Token(Token = "0x401BF2F")]
			SuperWildSwing_Attack,
			// Token: 0x0400C6E1 RID: 50913
			[Token(Token = "0x401BF30")]
			TwoWildSwing_Attack,
			// Token: 0x0400C6E2 RID: 50914
			[Token(Token = "0x401BF31")]
			JumpClose_Attack,
			// Token: 0x0400C6E3 RID: 50915
			[Token(Token = "0x401BF32")]
			Angry_Other,
			// Token: 0x0400C6E4 RID: 50916
			[Token(Token = "0x401BF33")]
			MadnessHipPress_Attack,
			// Token: 0x0400C6E5 RID: 50917
			[Token(Token = "0x401BF34")]
			TornadoSwing_Attack,
			// Token: 0x0400C6E6 RID: 50918
			[Token(Token = "0x401BF35")]
			MadnessJumpClose_Attack,
			// Token: 0x0400C6E7 RID: 50919
			[Token(Token = "0x401BF36")]
			RushAttack_Attack
		}

		// Token: 0x02000FA2 RID: 4002
		[Token(Token = "0x2001503")]
		[Serializable]
		public class LotteryBossBehavior : LotteryBossBehavior<SasquatchBossDataAsset.LotteryType>
		{
			// Token: 0x060065FA RID: 26106 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C08")]
			[Address(RVA = "0x2187A40", Offset = "0x2187B41", VA = "0x2187A40")]
			public LotteryBossBehavior()
			{
			}
		}

		// Token: 0x02000FA3 RID: 4003
		[Token(Token = "0x2001504")]
		[Serializable]
		public class LotteryBossBehaviorParams : LotteryBossBehaviorParams<SasquatchBossDataAsset.LotteryBossBehavior, SasquatchBossDataAsset.LotteryType>
		{
			// Token: 0x060065FB RID: 26107 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C09")]
			[Address(RVA = "0x2187A90", Offset = "0x2187B91", VA = "0x2187A90")]
			public LotteryBossBehaviorParams()
			{
			}
		}

		// Token: 0x02000FA4 RID: 4004
		[Token(Token = "0x2001505")]
		[Serializable]
		public class LotteryBossBehaviorPramsList : LotteryBossBehaviorPramsList<SasquatchBossDataAsset.LotteryBossBehaviorParams, SasquatchBossDataAsset.LotteryBossBehavior, SasquatchBossDataAsset.LotteryType>
		{
			// Token: 0x060065FC RID: 26108 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C0A")]
			[Address(RVA = "0x2187AE0", Offset = "0x2187BE1", VA = "0x2187AE0")]
			public LotteryBossBehaviorPramsList()
			{
			}
		}
	}
}
