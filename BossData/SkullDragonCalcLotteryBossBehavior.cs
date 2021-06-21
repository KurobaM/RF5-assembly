using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace BossData
{
	// Token: 0x02000FA9 RID: 4009
	[Token(Token = "0x2000A0D")]
	public class SkullDragonCalcLotteryBossBehavior : CalcLotteryBossBehavior
	{
		// Token: 0x06006603 RID: 26115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054A6")]
		[Address(RVA = "0x2187D50", Offset = "0x2187E51", VA = "0x2187D50")]
		public SkullDragonCalcLotteryBossBehavior(Dictionary<int, List<BossBehaviorParams>> bossBehaviorListDic)
		{
		}

		// Token: 0x06006604 RID: 26116 RVA: 0x000222F0 File Offset: 0x000204F0
		[Token(Token = "0x60054A7")]
		[Address(RVA = "0x2187DC0", Offset = "0x2187EC1", VA = "0x2187DC0", Slot = "6")]
		public override int Lottery()
		{
			return 0;
		}

		// Token: 0x06006605 RID: 26117 RVA: 0x00022308 File Offset: 0x00020508
		[Token(Token = "0x60054A8")]
		[Address(RVA = "0x2188010", Offset = "0x2188111", VA = "0x2188010", Slot = "9")]
		public override bool IsMovementAction(int type)
		{
			return default(bool);
		}

		// Token: 0x06006606 RID: 26118 RVA: 0x00022320 File Offset: 0x00020520
		[Token(Token = "0x60054A9")]
		[Address(RVA = "0x2188030", Offset = "0x2188131", VA = "0x2188030")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACE10", Offset = "0x1ACF11")]
		private bool <Lottery>b__5_1(SkullDragonBossDataAsset.LotteryParam x)
		{
			return default(bool);
		}

		// Token: 0x0400C6F9 RID: 50937
		[Token(Token = "0x40093C3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		public List<SkullDragonBossDataAsset.LotteryParam> ActionList;

		// Token: 0x0400C6FA RID: 50938
		[Token(Token = "0x40093C4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		public List<SkullDragonBossDataAsset.LotteryParam> FilledTailDamageActionList;

		// Token: 0x0400C6FB RID: 50939
		[Token(Token = "0x40093C5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		public List<SkullDragonBossDataAsset.LotteryParam> MadnessActionList;

		// Token: 0x02000FAA RID: 4010
		[Token(Token = "0x2001508")]
		public enum SkullDragonBossDataAssetBitArrayIndex
		{
			// Token: 0x0400C6FD RID: 50941
			[Token(Token = "0x401BF43")]
			IsPreviousSelectMove = 1,
			// Token: 0x0400C6FE RID: 50942
			[Token(Token = "0x401BF44")]
			IsRedyFireBreath,
			// Token: 0x0400C6FF RID: 50943
			[Token(Token = "0x401BF45")]
			FilledTailDamage,
			// Token: 0x0400C700 RID: 50944
			[Token(Token = "0x401BF46")]
			IsHeadAttack,
			// Token: 0x0400C701 RID: 50945
			[Token(Token = "0x401BF47")]
			e_Count
		}

		// Token: 0x02000FAB RID: 4011
		[Token(Token = "0x2001509")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159BD0", Offset = "0x159CD1")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06006608 RID: 26120 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C0D")]
			[Address(RVA = "0x21880D0", Offset = "0x21881D1", VA = "0x21880D0")]
			public <>c()
			{
			}

			// Token: 0x06006609 RID: 26121 RVA: 0x00022338 File Offset: 0x00020538
			[Token(Token = "0x6007C0E")]
			[Address(RVA = "0x21880E0", Offset = "0x21881E1", VA = "0x21880E0")]
			internal float <Lottery>b__5_0(SkullDragonBossDataAsset.LotteryParam x)
			{
				return 0f;
			}

			// Token: 0x0400C702 RID: 50946
			[Token(Token = "0x401BF48")]
			[FieldOffset(Offset = "0x0")]
			public static readonly SkullDragonCalcLotteryBossBehavior.<>c <>9;

			// Token: 0x0400C703 RID: 50947
			[Token(Token = "0x401BF49")]
			[FieldOffset(Offset = "0x8")]
			public static Func<SkullDragonBossDataAsset.LotteryParam, float> <>9__5_0;
		}
	}
}
