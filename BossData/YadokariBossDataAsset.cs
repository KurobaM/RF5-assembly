using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BossData
{
	// Token: 0x02000FB3 RID: 4019
	[Token(Token = "0x2000A10")]
	[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x149F10", Offset = "0x14A011")]
	public class YadokariBossDataAsset : BossDataAssetBase
	{
		// Token: 0x06006611 RID: 26129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054AE")]
		[Address(RVA = "0x2188360", Offset = "0x2188461", VA = "0x2188360", Slot = "9")]
		public override BossBehaviorController AddBossBehaviorControllerBase(GameObject monster)
		{
			return null;
		}

		// Token: 0x06006612 RID: 26130 RVA: 0x00022350 File Offset: 0x00020550
		[Token(Token = "0x60054AF")]
		[Address(RVA = "0x21883C0", Offset = "0x21884C1", VA = "0x21883C0", Slot = "6")]
		public override int GetIntParam(string key)
		{
			return 0;
		}

		// Token: 0x06006613 RID: 26131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054B0")]
		[Address(RVA = "0x2188450", Offset = "0x2188551", VA = "0x2188450", Slot = "10")]
		public override CalcLotteryBossBehavior GetCalcLotteryBossBehavior()
		{
			return null;
		}

		// Token: 0x06006614 RID: 26132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054B1")]
		[Address(RVA = "0x2188550", Offset = "0x2188651", VA = "0x2188550")]
		public YadokariBossDataAsset()
		{
		}

		// Token: 0x0400C717 RID: 50967
		[Token(Token = "0x40093C8")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private int ShellDamageBonusPercent;

		// Token: 0x0400C718 RID: 50968
		[Token(Token = "0x40093C9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private YadokariBossDataAsset.LotteryBossBehaviorPramsList NormalActionList;

		// Token: 0x0400C719 RID: 50969
		[Token(Token = "0x40093CA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private YadokariBossDataAsset.LotteryBossBehaviorPramsList MadnessActionList;

		// Token: 0x02000FB4 RID: 4020
		[Token(Token = "0x200150F")]
		[Serializable]
		public enum LotteryType
		{
			// Token: 0x0400C71B RID: 50971
			[Token(Token = "0x401BF5C")]
			None,
			// Token: 0x0400C71C RID: 50972
			[Token(Token = "0x401BF5D")]
			Around_Move,
			// Token: 0x0400C71D RID: 50973
			[Token(Token = "0x401BF5E")]
			CrabClaw,
			// Token: 0x0400C71E RID: 50974
			[Token(Token = "0x401BF5F")]
			Bubble_Burst,
			// Token: 0x0400C71F RID: 50975
			[Token(Token = "0x401BF60")]
			Bubble_Burst_Right,
			// Token: 0x0400C720 RID: 50976
			[Token(Token = "0x401BF61")]
			Bubble_Burst_Left,
			// Token: 0x0400C721 RID: 50977
			[Token(Token = "0x401BF62")]
			Rotate_Attack,
			// Token: 0x0400C722 RID: 50978
			[Token(Token = "0x401BF63")]
			Throw_Shell,
			// Token: 0x0400C723 RID: 50979
			[Token(Token = "0x401BF64")]
			Bubble_ThreeWay_1,
			// Token: 0x0400C724 RID: 50980
			[Token(Token = "0x401BF65")]
			Bubble_ThreeWay_2,
			// Token: 0x0400C725 RID: 50981
			[Token(Token = "0x401BF66")]
			Jump_Attack,
			// Token: 0x0400C726 RID: 50982
			[Token(Token = "0x401BF67")]
			Jump_Attack_Charge,
			// Token: 0x0400C727 RID: 50983
			[Token(Token = "0x401BF68")]
			Spin_Hammer,
			// Token: 0x0400C728 RID: 50984
			[Token(Token = "0x401BF69")]
			Spin_Bubble,
			// Token: 0x0400C729 RID: 50985
			[Token(Token = "0x401BF6A")]
			ShellAction,
			// Token: 0x0400C72A RID: 50986
			[Token(Token = "0x401BF6B")]
			Dash_Bubble,
			// Token: 0x0400C72B RID: 50987
			[Token(Token = "0x401BF6C")]
			CrossClaw,
			// Token: 0x0400C72C RID: 50988
			[Token(Token = "0x401BF6D")]
			CrossClaw_Charge,
			// Token: 0x0400C72D RID: 50989
			[Token(Token = "0x401BF6E")]
			Dash,
			// Token: 0x0400C72E RID: 50990
			[Token(Token = "0x401BF6F")]
			MoveAndPickupShell
		}

		// Token: 0x02000FB5 RID: 4021
		[Token(Token = "0x2001510")]
		[Serializable]
		public class LotteryBossBehavior : LotteryBossBehavior<YadokariBossDataAsset.LotteryType>
		{
			// Token: 0x06006615 RID: 26133 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C12")]
			[Address(RVA = "0x2188560", Offset = "0x2188661", VA = "0x2188560")]
			public LotteryBossBehavior()
			{
			}
		}

		// Token: 0x02000FB6 RID: 4022
		[Token(Token = "0x2001511")]
		[Serializable]
		public class LotteryBossBehaviorParams : LotteryBossBehaviorParams<YadokariBossDataAsset.LotteryBossBehavior, YadokariBossDataAsset.LotteryType>
		{
			// Token: 0x06006616 RID: 26134 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C13")]
			[Address(RVA = "0x21885B0", Offset = "0x21886B1", VA = "0x21885B0")]
			public LotteryBossBehaviorParams()
			{
			}
		}

		// Token: 0x02000FB7 RID: 4023
		[Token(Token = "0x2001512")]
		[Serializable]
		public class LotteryBossBehaviorPramsList : LotteryBossBehaviorPramsList<YadokariBossDataAsset.LotteryBossBehaviorParams, YadokariBossDataAsset.LotteryBossBehavior, YadokariBossDataAsset.LotteryType>
		{
			// Token: 0x06006617 RID: 26135 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C14")]
			[Address(RVA = "0x2188600", Offset = "0x2188701", VA = "0x2188600")]
			public LotteryBossBehaviorPramsList()
			{
			}
		}
	}
}
