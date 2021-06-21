using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace BossData
{
	// Token: 0x02000F31 RID: 3889
	[Token(Token = "0x20009E8")]
	[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x1498D0", Offset = "0x1499D1")]
	public class CerberusBossDataAsset : BossDataAssetBase
	{
		// Token: 0x06006559 RID: 25945 RVA: 0x00022050 File Offset: 0x00020250
		[Token(Token = "0x6005437")]
		[Address(RVA = "0x245B140", Offset = "0x245B241", VA = "0x245B140", Slot = "7")]
		public override float GetFloatParam(string key)
		{
			return 0f;
		}

		// Token: 0x0600655A RID: 25946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005438")]
		[Address(RVA = "0x245B2E0", Offset = "0x245B3E1", VA = "0x245B2E0", Slot = "9")]
		public override BossBehaviorController AddBossBehaviorControllerBase(GameObject monster)
		{
			return null;
		}

		// Token: 0x0600655B RID: 25947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005439")]
		[Address(RVA = "0x245B340", Offset = "0x245B441", VA = "0x245B340", Slot = "10")]
		public override CalcLotteryBossBehavior GetCalcLotteryBossBehavior()
		{
			return null;
		}

		// Token: 0x0600655C RID: 25948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600543A")]
		[Address(RVA = "0x245B520", Offset = "0x245B621", VA = "0x245B520")]
		public CerberusBossDataAsset()
		{
		}

		// Token: 0x0400C51C RID: 50460
		[Token(Token = "0x4009351")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float HungryTime;

		// Token: 0x0400C51D RID: 50461
		[Token(Token = "0x4009352")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float MinWaitVigilanceTime;

		// Token: 0x0400C51E RID: 50462
		[Token(Token = "0x4009353")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float MaxWaitVigilanceTime;

		// Token: 0x0400C51F RID: 50463
		[Token(Token = "0x4009354")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float EscapeHPDamageResetTime;

		// Token: 0x0400C520 RID: 50464
		[Token(Token = "0x4009355")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float EscapeHPDamagePercent;

		// Token: 0x0400C521 RID: 50465
		[Token(Token = "0x4009356")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float DivisionHPDamageResetTimer;

		// Token: 0x0400C522 RID: 50466
		[Token(Token = "0x4009357")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float DivisionHPDamagePercent;

		// Token: 0x0400C523 RID: 50467
		[Token(Token = "0x4009358")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<CerberusBossDataAsset.LotteryParam> AttackPriorityList;

		// Token: 0x0400C524 RID: 50468
		[Token(Token = "0x4009359")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<CerberusBossDataAsset.LotteryParam> MadnessAttackPriorityList;

		// Token: 0x02000F32 RID: 3890
		[Token(Token = "0x20014B5")]
		[Serializable]
		public enum LotteryType
		{
			// Token: 0x0400C526 RID: 50470
			[Token(Token = "0x401BDD8")]
			None,
			// Token: 0x0400C527 RID: 50471
			[Token(Token = "0x401BDD9")]
			Around_Move,
			// Token: 0x0400C528 RID: 50472
			[Token(Token = "0x401BDDA")]
			Threate,
			// Token: 0x0400C529 RID: 50473
			[Token(Token = "0x401BDDB")]
			Leave_Move,
			// Token: 0x0400C52A RID: 50474
			[Token(Token = "0x401BDDC")]
			Eat_EatSweets,
			// Token: 0x0400C52B RID: 50475
			[Token(Token = "0x401BDDD")]
			Bite_Attack,
			// Token: 0x0400C52C RID: 50476
			[Token(Token = "0x401BDDE")]
			Strike_Attack,
			// Token: 0x0400C52D RID: 50477
			[Token(Token = "0x401BDDF")]
			Sever_Attack,
			// Token: 0x0400C52E RID: 50478
			[Token(Token = "0x401BDE0")]
			Division
		}

		// Token: 0x02000F33 RID: 3891
		[Token(Token = "0x20014B6")]
		[Serializable]
		public class LotteryParam : BossLotteryParam<CerberusBossDataAsset.LotteryType>
		{
			// Token: 0x0600655D RID: 25949 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BD1")]
			[Address(RVA = "0x245B5B0", Offset = "0x245B6B1", VA = "0x245B5B0")]
			public LotteryParam()
			{
			}
		}
	}
}
