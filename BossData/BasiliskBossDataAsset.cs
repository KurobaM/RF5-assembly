using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BossData
{
	// Token: 0x02000F1F RID: 3871
	[Token(Token = "0x20009DD")]
	[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x149880", Offset = "0x149981")]
	public class BasiliskBossDataAsset : BossDataAssetBase
	{
		// Token: 0x06006514 RID: 25876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053F8")]
		[Address(RVA = "0x245A230", Offset = "0x245A331", VA = "0x245A230", Slot = "9")]
		public override BossBehaviorController AddBossBehaviorControllerBase(GameObject monster)
		{
			return null;
		}

		// Token: 0x06006515 RID: 25877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053F9")]
		[Address(RVA = "0x245A290", Offset = "0x245A391", VA = "0x245A290", Slot = "10")]
		public override CalcLotteryBossBehavior GetCalcLotteryBossBehavior()
		{
			return null;
		}

		// Token: 0x06006516 RID: 25878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053FA")]
		[Address(RVA = "0x245A6D0", Offset = "0x245A7D1", VA = "0x245A6D0")]
		public BasiliskBossDataAsset()
		{
		}

		// Token: 0x0400C4BD RID: 50365
		[Token(Token = "0x400931A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private BasiliskBossDataAsset.LotteryBossBehaviorPramsList Normal_1_FireBall;

		// Token: 0x0400C4BE RID: 50366
		[Token(Token = "0x400931B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private BasiliskBossDataAsset.LotteryBossBehaviorPramsList Check_Normal_2;

		// Token: 0x0400C4BF RID: 50367
		[Token(Token = "0x400931C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private BasiliskBossDataAsset.LotteryBossBehaviorPramsList Normal_2_MoveBite_Attack;

		// Token: 0x0400C4C0 RID: 50368
		[Token(Token = "0x400931D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private BasiliskBossDataAsset.LotteryBossBehaviorPramsList Check_Normal_3;

		// Token: 0x0400C4C1 RID: 50369
		[Token(Token = "0x400931E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private BasiliskBossDataAsset.LotteryBossBehaviorPramsList Normal_3_TargetCenter;

		// Token: 0x0400C4C2 RID: 50370
		[Token(Token = "0x400931F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private BasiliskBossDataAsset.LotteryBossBehaviorPramsList Normal_3_MoveCenter;

		// Token: 0x0400C4C3 RID: 50371
		[Token(Token = "0x4009320")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private BasiliskBossDataAsset.LotteryBossBehaviorPramsList Madness_1;

		// Token: 0x0400C4C4 RID: 50372
		[Token(Token = "0x4009321")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private BasiliskBossDataAsset.LotteryBossBehaviorPramsList Check_Madness_2;

		// Token: 0x0400C4C5 RID: 50373
		[Token(Token = "0x4009322")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private BasiliskBossDataAsset.LotteryBossBehaviorPramsList Madness_2_Close;

		// Token: 0x0400C4C6 RID: 50374
		[Token(Token = "0x4009323")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private BasiliskBossDataAsset.LotteryBossBehaviorPramsList Madness_2_Middle;

		// Token: 0x0400C4C7 RID: 50375
		[Token(Token = "0x4009324")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private BasiliskBossDataAsset.LotteryBossBehaviorPramsList Madness_2_Long;

		// Token: 0x0400C4C8 RID: 50376
		[Token(Token = "0x4009325")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private BasiliskBossDataAsset.LotteryBossBehaviorPramsList Madness_3;

		// Token: 0x0400C4C9 RID: 50377
		[Token(Token = "0x4009326")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private BasiliskBossDataAsset.LotteryBossBehaviorPramsList Check_Mandess_4;

		// Token: 0x0400C4CA RID: 50378
		[Token(Token = "0x4009327")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private BasiliskBossDataAsset.LotteryBossBehaviorPramsList Madness_4_Close;

		// Token: 0x0400C4CB RID: 50379
		[Token(Token = "0x4009328")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private BasiliskBossDataAsset.LotteryBossBehaviorPramsList Madness_4_Long;

		// Token: 0x0400C4CC RID: 50380
		[Token(Token = "0x4009329")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private BasiliskBossDataAsset.LotteryBossBehaviorPramsList Madness_5;

		// Token: 0x02000F20 RID: 3872
		[Token(Token = "0x20014AE")]
		[Serializable]
		public enum LotteryType
		{
			// Token: 0x0400C4CE RID: 50382
			[Token(Token = "0x401BDB0")]
			None,
			// Token: 0x0400C4CF RID: 50383
			[Token(Token = "0x401BDB1")]
			Bite_Attack,
			// Token: 0x0400C4D0 RID: 50384
			[Token(Token = "0x401BDB2")]
			MoveBite_Attack,
			// Token: 0x0400C4D1 RID: 50385
			[Token(Token = "0x401BDB3")]
			Rotation_Attack_3,
			// Token: 0x0400C4D2 RID: 50386
			[Token(Token = "0x401BDB4")]
			Rotation_Attack_2,
			// Token: 0x0400C4D3 RID: 50387
			[Token(Token = "0x401BDB5")]
			FireShot_Attack,
			// Token: 0x0400C4D4 RID: 50388
			[Token(Token = "0x401BDB6")]
			FireShot_Multi_Attack,
			// Token: 0x0400C4D5 RID: 50389
			[Token(Token = "0x401BDB7")]
			Napalm_Attack,
			// Token: 0x0400C4D6 RID: 50390
			[Token(Token = "0x401BDB8")]
			MultiBite_Attack,
			// Token: 0x0400C4D7 RID: 50391
			[Token(Token = "0x401BDB9")]
			Target_Move,
			// Token: 0x0400C4D8 RID: 50392
			[Token(Token = "0x401BDBA")]
			Right_Move,
			// Token: 0x0400C4D9 RID: 50393
			[Token(Token = "0x401BDBB")]
			Left_Move,
			// Token: 0x0400C4DA RID: 50394
			[Token(Token = "0x401BDBC")]
			FallBack_Move,
			// Token: 0x0400C4DB RID: 50395
			[Token(Token = "0x401BDBD")]
			Normal_1_FireBall,
			// Token: 0x0400C4DC RID: 50396
			[Token(Token = "0x401BDBE")]
			Check_Normal_2,
			// Token: 0x0400C4DD RID: 50397
			[Token(Token = "0x401BDBF")]
			Normal_2_MoveBite_Attack,
			// Token: 0x0400C4DE RID: 50398
			[Token(Token = "0x401BDC0")]
			Check_Normal_3,
			// Token: 0x0400C4DF RID: 50399
			[Token(Token = "0x401BDC1")]
			Normal_3_TargetCenter,
			// Token: 0x0400C4E0 RID: 50400
			[Token(Token = "0x401BDC2")]
			Normal_3_MoveCenter,
			// Token: 0x0400C4E1 RID: 50401
			[Token(Token = "0x401BDC3")]
			Madness_1,
			// Token: 0x0400C4E2 RID: 50402
			[Token(Token = "0x401BDC4")]
			Check_Madness_2,
			// Token: 0x0400C4E3 RID: 50403
			[Token(Token = "0x401BDC5")]
			Madness_2_Close,
			// Token: 0x0400C4E4 RID: 50404
			[Token(Token = "0x401BDC6")]
			Madness_2_Middle,
			// Token: 0x0400C4E5 RID: 50405
			[Token(Token = "0x401BDC7")]
			Madness_2_Long,
			// Token: 0x0400C4E6 RID: 50406
			[Token(Token = "0x401BDC8")]
			Madness_3,
			// Token: 0x0400C4E7 RID: 50407
			[Token(Token = "0x401BDC9")]
			Check_Mandess_4,
			// Token: 0x0400C4E8 RID: 50408
			[Token(Token = "0x401BDCA")]
			Madness_4_Close,
			// Token: 0x0400C4E9 RID: 50409
			[Token(Token = "0x401BDCB")]
			Madness_4_Long,
			// Token: 0x0400C4EA RID: 50410
			[Token(Token = "0x401BDCC")]
			Madness_5,
			// Token: 0x0400C4EB RID: 50411
			[Token(Token = "0x401BDCD")]
			FireShot_OldMulti_Attack
		}

		// Token: 0x02000F21 RID: 3873
		[Token(Token = "0x20014AF")]
		[Serializable]
		public class LotteryBossBehavior : LotteryBossBehavior<BasiliskBossDataAsset.LotteryType>
		{
			// Token: 0x06006517 RID: 25879 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BCB")]
			[Address(RVA = "0x245A760", Offset = "0x245A861", VA = "0x245A760")]
			public LotteryBossBehavior()
			{
			}
		}

		// Token: 0x02000F22 RID: 3874
		[Token(Token = "0x20014B0")]
		[Serializable]
		public class LotteryBossBehaviorParams : LotteryBossBehaviorParams<BasiliskBossDataAsset.LotteryBossBehavior, BasiliskBossDataAsset.LotteryType>
		{
			// Token: 0x06006518 RID: 25880 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BCC")]
			[Address(RVA = "0x245A7B0", Offset = "0x245A8B1", VA = "0x245A7B0")]
			public LotteryBossBehaviorParams()
			{
			}
		}

		// Token: 0x02000F23 RID: 3875
		[Token(Token = "0x20014B1")]
		[Serializable]
		public class LotteryBossBehaviorPramsList : LotteryBossBehaviorPramsList<BasiliskBossDataAsset.LotteryBossBehaviorParams, BasiliskBossDataAsset.LotteryBossBehavior, BasiliskBossDataAsset.LotteryType>
		{
			// Token: 0x06006519 RID: 25881 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BCD")]
			[Address(RVA = "0x245A800", Offset = "0x245A901", VA = "0x245A800")]
			public LotteryBossBehaviorPramsList()
			{
			}
		}
	}
}
