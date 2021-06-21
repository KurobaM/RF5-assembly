using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace BossData
{
	// Token: 0x02000FA6 RID: 4006
	[Token(Token = "0x2000A0C")]
	[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x149E70", Offset = "0x149F71")]
	public class SkullDragonBossDataAsset : BossDataAssetBase
	{
		// Token: 0x060065FE RID: 26110 RVA: 0x000222D8 File Offset: 0x000204D8
		[Token(Token = "0x60054A2")]
		[Address(RVA = "0x2187B30", Offset = "0x2187C31", VA = "0x2187B30", Slot = "7")]
		public override float GetFloatParam(string key)
		{
			return 0f;
		}

		// Token: 0x060065FF RID: 26111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054A3")]
		[Address(RVA = "0x2187C20", Offset = "0x2187D21", VA = "0x2187C20", Slot = "9")]
		public override BossBehaviorController AddBossBehaviorControllerBase(GameObject monster)
		{
			return null;
		}

		// Token: 0x06006600 RID: 26112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054A4")]
		[Address(RVA = "0x2187C80", Offset = "0x2187D81", VA = "0x2187C80", Slot = "10")]
		public override CalcLotteryBossBehavior GetCalcLotteryBossBehavior()
		{
			return null;
		}

		// Token: 0x06006601 RID: 26113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054A5")]
		[Address(RVA = "0x2187D60", Offset = "0x2187E61", VA = "0x2187D60")]
		public SkullDragonBossDataAsset()
		{
		}

		// Token: 0x0400C6E8 RID: 50920
		[Token(Token = "0x40093BD")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		public float MaxTailDamageHPPercent;

		// Token: 0x0400C6E9 RID: 50921
		[Token(Token = "0x40093BE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public float WaitFireBreathTime;

		// Token: 0x0400C6EA RID: 50922
		[Token(Token = "0x40093BF")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		public float WaitAngerTime;

		// Token: 0x0400C6EB RID: 50923
		[Token(Token = "0x40093C0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<SkullDragonBossDataAsset.LotteryParam> ActionList;

		// Token: 0x0400C6EC RID: 50924
		[Token(Token = "0x40093C1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<SkullDragonBossDataAsset.LotteryParam> FilledTailDamageActionList;

		// Token: 0x0400C6ED RID: 50925
		[Token(Token = "0x40093C2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<SkullDragonBossDataAsset.LotteryParam> MadnessActionList;

		// Token: 0x02000FA7 RID: 4007
		[Token(Token = "0x2001506")]
		[Serializable]
		public enum LotteryType
		{
			// Token: 0x0400C6EF RID: 50927
			[Token(Token = "0x401BF38")]
			None,
			// Token: 0x0400C6F0 RID: 50928
			[Token(Token = "0x401BF39")]
			Threat,
			// Token: 0x0400C6F1 RID: 50929
			[Token(Token = "0x401BF3A")]
			Around_Move,
			// Token: 0x0400C6F2 RID: 50930
			[Token(Token = "0x401BF3B")]
			Threat_AroundMove,
			// Token: 0x0400C6F3 RID: 50931
			[Token(Token = "0x401BF3C")]
			Sever_Attack,
			// Token: 0x0400C6F4 RID: 50932
			[Token(Token = "0x401BF3D")]
			Stomp_Attack,
			// Token: 0x0400C6F5 RID: 50933
			[Token(Token = "0x401BF3E")]
			RushSever_Attack,
			// Token: 0x0400C6F6 RID: 50934
			[Token(Token = "0x401BF3F")]
			FireBreath_Attack,
			// Token: 0x0400C6F7 RID: 50935
			[Token(Token = "0x401BF40")]
			HeadAttack,
			// Token: 0x0400C6F8 RID: 50936
			[Token(Token = "0x401BF41")]
			MoveSever_Attack
		}

		// Token: 0x02000FA8 RID: 4008
		[Token(Token = "0x2001507")]
		[Serializable]
		public class LotteryParam : BossLotteryParam<SkullDragonBossDataAsset.LotteryType>
		{
			// Token: 0x06006602 RID: 26114 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C0B")]
			[Address(RVA = "0x2187D70", Offset = "0x2187E71", VA = "0x2187D70")]
			public LotteryParam()
			{
			}
		}
	}
}
