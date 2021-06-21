using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace BossData
{
	// Token: 0x02000F3A RID: 3898
	[Token(Token = "0x20009EB")]
	public class DeadtreeCalcLotteryBossBehavior : CalcLotteryBossBehavior
	{
		// Token: 0x0600656A RID: 25962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005442")]
		[Address(RVA = "0x245BBA0", Offset = "0x245BCA1", VA = "0x245BBA0")]
		public DeadtreeCalcLotteryBossBehavior(Dictionary<int, List<BossBehaviorParams>> bossBehaviorListDic)
		{
		}

		// Token: 0x0600656B RID: 25963 RVA: 0x000220E0 File Offset: 0x000202E0
		[Token(Token = "0x6005443")]
		[Address(RVA = "0x245BD30", Offset = "0x245BE31", VA = "0x245BD30", Slot = "6")]
		public override int Lottery()
		{
			return 0;
		}

		// Token: 0x0600656C RID: 25964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005444")]
		[Address(RVA = "0x245BFE0", Offset = "0x245C0E1", VA = "0x245BFE0")]
		public List<DeadtreeBossDataAsset.LotteryParam> SelectAction()
		{
			return null;
		}

		// Token: 0x0600656D RID: 25965 RVA: 0x000220F8 File Offset: 0x000202F8
		[Token(Token = "0x6005445")]
		[Address(RVA = "0x245C050", Offset = "0x245C151", VA = "0x245C050", Slot = "9")]
		public override bool IsMovementAction(int type)
		{
			return default(bool);
		}

		// Token: 0x0600656E RID: 25966 RVA: 0x00022110 File Offset: 0x00020310
		[Token(Token = "0x6005446")]
		[Address(RVA = "0x245C070", Offset = "0x245C171", VA = "0x245C070")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACDE0", Offset = "0x1ACEE1")]
		private bool <Lottery>b__7_1(DeadtreeBossDataAsset.LotteryParam x)
		{
			return default(bool);
		}

		// Token: 0x0400C54A RID: 50506
		[Token(Token = "0x4009361")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		public List<DeadtreeBossDataAsset.LotteryParam> ActionList;

		// Token: 0x0400C54B RID: 50507
		[Token(Token = "0x4009362")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		public List<DeadtreeBossDataAsset.LotteryParam> ExistBurrActionList;

		// Token: 0x0400C54C RID: 50508
		[Token(Token = "0x4009363")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		public List<DeadtreeBossDataAsset.LotteryParam> MadnessActionList;

		// Token: 0x0400C54D RID: 50509
		[Token(Token = "0x4009364")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		public List<DeadtreeBossDataAsset.LotteryParam> ExistBurrMadnessActionList;

		// Token: 0x0400C54E RID: 50510
		[Token(Token = "0x4009365")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		public List<DeadtreeBossDataAsset.LotteryParam> DamageActionList;

		// Token: 0x02000F3B RID: 3899
		[Token(Token = "0x20014BB")]
		public enum DeadtreeBossDataAssetBitArrayIndex
		{
			// Token: 0x0400C550 RID: 50512
			[Token(Token = "0x401BDF6")]
			IsPreviousSelectMove = 1,
			// Token: 0x0400C551 RID: 50513
			[Token(Token = "0x401BDF7")]
			ExistBurr,
			// Token: 0x0400C552 RID: 50514
			[Token(Token = "0x401BDF8")]
			IsDamage,
			// Token: 0x0400C553 RID: 50515
			[Token(Token = "0x401BDF9")]
			MashHeal,
			// Token: 0x0400C554 RID: 50516
			[Token(Token = "0x401BDFA")]
			JumpAction,
			// Token: 0x0400C555 RID: 50517
			[Token(Token = "0x401BDFB")]
			e_Count
		}

		// Token: 0x02000F3C RID: 3900
		[Token(Token = "0x20014BC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159BC0", Offset = "0x159CC1")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06006570 RID: 25968 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BD8")]
			[Address(RVA = "0x245C110", Offset = "0x245C211", VA = "0x245C110")]
			public <>c()
			{
			}

			// Token: 0x06006571 RID: 25969 RVA: 0x00022128 File Offset: 0x00020328
			[Token(Token = "0x6007BD9")]
			[Address(RVA = "0x245C120", Offset = "0x245C221", VA = "0x245C120")]
			internal float <Lottery>b__7_0(DeadtreeBossDataAsset.LotteryParam x)
			{
				return 0f;
			}

			// Token: 0x0400C556 RID: 50518
			[Token(Token = "0x401BDFC")]
			[FieldOffset(Offset = "0x0")]
			public static readonly DeadtreeCalcLotteryBossBehavior.<>c <>9;

			// Token: 0x0400C557 RID: 50519
			[Token(Token = "0x401BDFD")]
			[FieldOffset(Offset = "0x8")]
			public static Func<DeadtreeBossDataAsset.LotteryParam, float> <>9__7_0;
		}
	}
}
