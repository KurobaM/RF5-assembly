using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace BossData
{
	// Token: 0x02000F34 RID: 3892
	[Token(Token = "0x20009E9")]
	public class CerberusCalcLotteryBossBehavior : CalcLotteryBossBehavior
	{
		// Token: 0x0600655E RID: 25950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600543B")]
		[Address(RVA = "0x245B470", Offset = "0x245B571", VA = "0x245B470")]
		public CerberusCalcLotteryBossBehavior(Dictionary<int, List<BossBehaviorParams>> bossBehaviorListDic)
		{
		}

		// Token: 0x0600655F RID: 25951 RVA: 0x00022068 File Offset: 0x00020268
		[Token(Token = "0x600543C")]
		[Address(RVA = "0x245B600", Offset = "0x245B701", VA = "0x245B600", Slot = "6")]
		public override int Lottery()
		{
			return 0;
		}

		// Token: 0x06006560 RID: 25952 RVA: 0x00022080 File Offset: 0x00020280
		[Token(Token = "0x600543D")]
		[Address(RVA = "0x245B8D0", Offset = "0x245B9D1", VA = "0x245B8D0", Slot = "9")]
		public override bool IsMovementAction(int type)
		{
			return default(bool);
		}

		// Token: 0x06006561 RID: 25953 RVA: 0x00022098 File Offset: 0x00020298
		[Token(Token = "0x600543E")]
		[Address(RVA = "0x245B8E0", Offset = "0x245B9E1", VA = "0x245B8E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACDD0", Offset = "0x1ACED1")]
		private bool <Lottery>b__4_0(CerberusBossDataAsset.LotteryParam x)
		{
			return default(bool);
		}

		// Token: 0x0400C52F RID: 50479
		[Token(Token = "0x400935A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		public List<CerberusBossDataAsset.LotteryParam> AttackPriorityList;

		// Token: 0x0400C530 RID: 50480
		[Token(Token = "0x400935B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		public List<CerberusBossDataAsset.LotteryParam> MadnessAttackPriorityList;

		// Token: 0x02000F35 RID: 3893
		[Token(Token = "0x20014B7")]
		public enum CerberusBossDataAssetBitArrayIndex
		{
			// Token: 0x0400C532 RID: 50482
			[Token(Token = "0x401BDE2")]
			IsPreviousSelectMove = 1,
			// Token: 0x0400C533 RID: 50483
			[Token(Token = "0x401BDE3")]
			IsEscapeJump,
			// Token: 0x0400C534 RID: 50484
			[Token(Token = "0x401BDE4")]
			CanEatSweets,
			// Token: 0x0400C535 RID: 50485
			[Token(Token = "0x401BDE5")]
			IsDivision,
			// Token: 0x0400C536 RID: 50486
			[Token(Token = "0x401BDE6")]
			e_Count
		}

		// Token: 0x02000F36 RID: 3894
		[Token(Token = "0x20014B8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159BB0", Offset = "0x159CB1")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06006563 RID: 25955 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BD3")]
			[Address(RVA = "0x245B980", Offset = "0x245BA81", VA = "0x245B980")]
			public <>c()
			{
			}

			// Token: 0x06006564 RID: 25956 RVA: 0x000220B0 File Offset: 0x000202B0
			[Token(Token = "0x6007BD4")]
			[Address(RVA = "0x245B990", Offset = "0x245BA91", VA = "0x245B990")]
			internal float <Lottery>b__4_1(CerberusBossDataAsset.LotteryParam x)
			{
				return 0f;
			}

			// Token: 0x06006565 RID: 25957 RVA: 0x000220C8 File Offset: 0x000202C8
			[Token(Token = "0x6007BD5")]
			[Address(RVA = "0x245B9B0", Offset = "0x245BAB1", VA = "0x245B9B0")]
			internal float <Lottery>b__4_2(CerberusBossDataAsset.LotteryParam x)
			{
				return 0f;
			}

			// Token: 0x0400C537 RID: 50487
			[Token(Token = "0x401BDE7")]
			[FieldOffset(Offset = "0x0")]
			public static readonly CerberusCalcLotteryBossBehavior.<>c <>9;

			// Token: 0x0400C538 RID: 50488
			[Token(Token = "0x401BDE8")]
			[FieldOffset(Offset = "0x8")]
			public static Func<CerberusBossDataAsset.LotteryParam, float> <>9__4_1;

			// Token: 0x0400C539 RID: 50489
			[Token(Token = "0x401BDE9")]
			[FieldOffset(Offset = "0x10")]
			public static Func<CerberusBossDataAsset.LotteryParam, float> <>9__4_2;
		}
	}
}
