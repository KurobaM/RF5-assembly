using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BossData
{
	// Token: 0x02000F65 RID: 3941
	[Token(Token = "0x20009F8")]
	[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x149B50", Offset = "0x149C51")]
	public class InosisiBossDataAsset : BossDataAssetBase
	{
		// Token: 0x060065AD RID: 26029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600546F")]
		[Address(RVA = "0x245E430", Offset = "0x245E531", VA = "0x245E430", Slot = "9")]
		public override BossBehaviorController AddBossBehaviorControllerBase(GameObject monster)
		{
			return null;
		}

		// Token: 0x060065AE RID: 26030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005470")]
		[Address(RVA = "0x245E490", Offset = "0x245E591", VA = "0x245E490", Slot = "10")]
		public override CalcLotteryBossBehavior GetCalcLotteryBossBehavior()
		{
			return null;
		}

		// Token: 0x060065AF RID: 26031 RVA: 0x00022200 File Offset: 0x00020400
		[Token(Token = "0x6005471")]
		[Address(RVA = "0x245E6B0", Offset = "0x245E7B1", VA = "0x245E6B0", Slot = "7")]
		public override float GetFloatParam(string key)
		{
			return 0f;
		}

		// Token: 0x060065B0 RID: 26032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005472")]
		[Address(RVA = "0x245E730", Offset = "0x245E831", VA = "0x245E730")]
		public InosisiBossDataAsset()
		{
		}

		// Token: 0x0400C60B RID: 50699
		[Token(Token = "0x4009390")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float MaxDamageHPPercent;

		// Token: 0x0400C60C RID: 50700
		[Token(Token = "0x4009391")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private InosisiBossDataAsset.LotteryBossBehaviorPramsList NormalActionList;

		// Token: 0x0400C60D RID: 50701
		[Token(Token = "0x4009392")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private InosisiBossDataAsset.LotteryBossBehaviorPramsList MadnessActionList;

		// Token: 0x02000F66 RID: 3942
		[Token(Token = "0x20014D9")]
		[Serializable]
		public enum LotteryType
		{
			// Token: 0x0400C60F RID: 50703
			[Token(Token = "0x401BE88")]
			None,
			// Token: 0x0400C610 RID: 50704
			[Token(Token = "0x401BE89")]
			AroundMove,
			// Token: 0x0400C611 RID: 50705
			[Token(Token = "0x401BE8A")]
			Rush,
			// Token: 0x0400C612 RID: 50706
			[Token(Token = "0x401BE8B")]
			SuperDush,
			// Token: 0x0400C613 RID: 50707
			[Token(Token = "0x401BE8C")]
			RushMissile,
			// Token: 0x0400C614 RID: 50708
			[Token(Token = "0x401BE8D")]
			Stomp,
			// Token: 0x0400C615 RID: 50709
			[Token(Token = "0x401BE8E")]
			ChargeStomp,
			// Token: 0x0400C616 RID: 50710
			[Token(Token = "0x401BE8F")]
			ThrowWave,
			// Token: 0x0400C617 RID: 50711
			[Token(Token = "0x401BE90")]
			ThrowRock,
			// Token: 0x0400C618 RID: 50712
			[Token(Token = "0x401BE91")]
			MadnessMissile,
			// Token: 0x0400C619 RID: 50713
			[Token(Token = "0x401BE92")]
			Meteor
		}

		// Token: 0x02000F67 RID: 3943
		[Token(Token = "0x20014DA")]
		[Serializable]
		public class LotteryBossBehavior : LotteryBossBehavior<InosisiBossDataAsset.LotteryType>
		{
			// Token: 0x060065B1 RID: 26033 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BED")]
			[Address(RVA = "0x245E7C0", Offset = "0x245E8C1", VA = "0x245E7C0")]
			public LotteryBossBehavior()
			{
			}
		}

		// Token: 0x02000F68 RID: 3944
		[Token(Token = "0x20014DB")]
		[Serializable]
		public class LotteryBossBehaviorParams : LotteryBossBehaviorParams<InosisiBossDataAsset.LotteryBossBehavior, InosisiBossDataAsset.LotteryType>
		{
			// Token: 0x060065B2 RID: 26034 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BEE")]
			[Address(RVA = "0x245E810", Offset = "0x245E911", VA = "0x245E810")]
			public LotteryBossBehaviorParams()
			{
			}
		}

		// Token: 0x02000F69 RID: 3945
		[Token(Token = "0x20014DC")]
		[Serializable]
		public class LotteryBossBehaviorPramsList : LotteryBossBehaviorPramsList<InosisiBossDataAsset.LotteryBossBehaviorParams, InosisiBossDataAsset.LotteryBossBehavior, InosisiBossDataAsset.LotteryType>
		{
			// Token: 0x060065B3 RID: 26035 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BEF")]
			[Address(RVA = "0x245E860", Offset = "0x245E961", VA = "0x245E860")]
			public LotteryBossBehaviorPramsList()
			{
			}
		}
	}
}
