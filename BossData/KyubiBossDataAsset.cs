using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BossData
{
	// Token: 0x02000F80 RID: 3968
	[Token(Token = "0x2000A00")]
	[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x149C90", Offset = "0x149D91")]
	public class KyubiBossDataAsset : BossDataAssetBase
	{
		// Token: 0x060065CF RID: 26063 RVA: 0x00022278 File Offset: 0x00020478
		[Token(Token = "0x6005485")]
		[Address(RVA = "0x245F830", Offset = "0x245F931", VA = "0x245F830", Slot = "7")]
		public override float GetFloatParam(string key)
		{
			return 0f;
		}

		// Token: 0x060065D0 RID: 26064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005486")]
		[Address(RVA = "0x245FA00", Offset = "0x245FB01", VA = "0x245FA00", Slot = "9")]
		public override BossBehaviorController AddBossBehaviorControllerBase(GameObject monster)
		{
			return null;
		}

		// Token: 0x060065D1 RID: 26065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005487")]
		[Address(RVA = "0x245FA60", Offset = "0x245FB61", VA = "0x245FA60", Slot = "10")]
		public override CalcLotteryBossBehavior GetCalcLotteryBossBehavior()
		{
			return null;
		}

		// Token: 0x060065D2 RID: 26066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005488")]
		[Address(RVA = "0x245FBD0", Offset = "0x245FCD1", VA = "0x245FBD0")]
		public KyubiBossDataAsset()
		{
		}

		// Token: 0x0400C66A RID: 50794
		[Token(Token = "0x40093A3")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float ChangeMoveDefaultTargetLength;

		// Token: 0x0400C66B RID: 50795
		[Token(Token = "0x40093A4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float ChangeMoveMadnessTargetLength;

		// Token: 0x0400C66C RID: 50796
		[Token(Token = "0x40093A5")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float JumpLength;

		// Token: 0x0400C66D RID: 50797
		[Token(Token = "0x40093A6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float BeforeRushWaitTime;

		// Token: 0x0400C66E RID: 50798
		[Token(Token = "0x40093A7")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float BeforeJumpAttackWaitTime;

		// Token: 0x0400C66F RID: 50799
		[Token(Token = "0x40093A8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float BeforeFireBallWaitTime;

		// Token: 0x0400C670 RID: 50800
		[Token(Token = "0x40093A9")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float BeforeRoarAttackWaitTime;

		// Token: 0x0400C671 RID: 50801
		[Token(Token = "0x40093AA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float BeforeKyubiFireWaitTime;

		// Token: 0x0400C672 RID: 50802
		[Token(Token = "0x40093AB")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private KyubiBossDataAsset.LotteryBossBehaviorPramsList NormalActionList;

		// Token: 0x0400C673 RID: 50803
		[Token(Token = "0x40093AC")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private KyubiBossDataAsset.LotteryBossBehaviorPramsList MadnessActionList;

		// Token: 0x02000F81 RID: 3969
		[Token(Token = "0x20014EC")]
		[Serializable]
		public enum LotteryType
		{
			// Token: 0x0400C675 RID: 50805
			[Token(Token = "0x401BED4")]
			None,
			// Token: 0x0400C676 RID: 50806
			[Token(Token = "0x401BED5")]
			DropAttack,
			// Token: 0x0400C677 RID: 50807
			[Token(Token = "0x401BED6")]
			JumpAttack,
			// Token: 0x0400C678 RID: 50808
			[Token(Token = "0x401BED7")]
			RushAttack1,
			// Token: 0x0400C679 RID: 50809
			[Token(Token = "0x401BED8")]
			RushAttack2,
			// Token: 0x0400C67A RID: 50810
			[Token(Token = "0x401BED9")]
			RoarAttack,
			// Token: 0x0400C67B RID: 50811
			[Token(Token = "0x401BEDA")]
			KyubiFireAttack,
			// Token: 0x0400C67C RID: 50812
			[Token(Token = "0x401BEDB")]
			FireBallAttack,
			// Token: 0x0400C67D RID: 50813
			[Token(Token = "0x401BEDC")]
			MultiFireBallAttack,
			// Token: 0x0400C67E RID: 50814
			[Token(Token = "0x401BEDD")]
			AroundMove
		}

		// Token: 0x02000F82 RID: 3970
		[Token(Token = "0x20014ED")]
		[Serializable]
		public class LotteryBossBehavior : LotteryBossBehavior<KyubiBossDataAsset.LotteryType>
		{
			// Token: 0x060065D3 RID: 26067 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BF9")]
			[Address(RVA = "0x245FC60", Offset = "0x245FD61", VA = "0x245FC60")]
			public LotteryBossBehavior()
			{
			}
		}

		// Token: 0x02000F83 RID: 3971
		[Token(Token = "0x20014EE")]
		[Serializable]
		public class LotteryBossBehaviorParams : LotteryBossBehaviorParams<KyubiBossDataAsset.LotteryBossBehavior, KyubiBossDataAsset.LotteryType>
		{
			// Token: 0x060065D4 RID: 26068 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BFA")]
			[Address(RVA = "0x245FCB0", Offset = "0x245FDB1", VA = "0x245FCB0")]
			public LotteryBossBehaviorParams()
			{
			}
		}

		// Token: 0x02000F84 RID: 3972
		[Token(Token = "0x20014EF")]
		[Serializable]
		public class LotteryBossBehaviorPramsList : LotteryBossBehaviorPramsList<KyubiBossDataAsset.LotteryBossBehaviorParams, KyubiBossDataAsset.LotteryBossBehavior, KyubiBossDataAsset.LotteryType>
		{
			// Token: 0x060065D5 RID: 26069 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BFB")]
			[Address(RVA = "0x245FD00", Offset = "0x245FE01", VA = "0x245FD00")]
			public LotteryBossBehaviorPramsList()
			{
			}
		}
	}
}
