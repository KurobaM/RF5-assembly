using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BossData
{
	// Token: 0x02000F18 RID: 3864
	[Token(Token = "0x20009DB")]
	[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x149830", Offset = "0x149931")]
	public class AudmuraBossDataAsset : BossDataAssetBase
	{
		// Token: 0x0600650C RID: 25868 RVA: 0x00021D98 File Offset: 0x0001FF98
		[Token(Token = "0x60053F3")]
		[Address(RVA = "0x2459DA0", Offset = "0x2459EA1", VA = "0x2459DA0", Slot = "6")]
		public override int GetIntParam(string key)
		{
			return 0;
		}

		// Token: 0x0600650D RID: 25869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053F4")]
		[Address(RVA = "0x2459E20", Offset = "0x2459F21", VA = "0x2459E20", Slot = "9")]
		public override BossBehaviorController AddBossBehaviorControllerBase(GameObject monster)
		{
			return null;
		}

		// Token: 0x0600650E RID: 25870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053F5")]
		[Address(RVA = "0x2459E80", Offset = "0x2459F81", VA = "0x2459E80", Slot = "10")]
		public override CalcLotteryBossBehavior GetCalcLotteryBossBehavior()
		{
			return null;
		}

		// Token: 0x0600650F RID: 25871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053F6")]
		[Address(RVA = "0x245A0A0", Offset = "0x245A1A1", VA = "0x245A0A0")]
		public AudmuraBossDataAsset()
		{
		}

		// Token: 0x0400C4AD RID: 50349
		[Token(Token = "0x4009317")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private int CrystalHP;

		// Token: 0x0400C4AE RID: 50350
		[Token(Token = "0x4009318")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AudmuraBossDataAsset.LotteryBossBehaviorPramsList NormalActionList;

		// Token: 0x0400C4AF RID: 50351
		[Token(Token = "0x4009319")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AudmuraBossDataAsset.LotteryBossBehaviorPramsList MadnessActionList;

		// Token: 0x02000F19 RID: 3865
		[Token(Token = "0x20014A9")]
		[Serializable]
		public enum LotteryType
		{
			// Token: 0x0400C4B1 RID: 50353
			[Token(Token = "0x401BDA3")]
			None,
			// Token: 0x0400C4B2 RID: 50354
			[Token(Token = "0x401BDA4")]
			BackKick_Attack,
			// Token: 0x0400C4B3 RID: 50355
			[Token(Token = "0x401BDA5")]
			SwingingAround_Attack,
			// Token: 0x0400C4B4 RID: 50356
			[Token(Token = "0x401BDA6")]
			Crystallization_Attack,
			// Token: 0x0400C4B5 RID: 50357
			[Token(Token = "0x401BDA7")]
			ReflectiveLaser_Attack,
			// Token: 0x0400C4B6 RID: 50358
			[Token(Token = "0x401BDA8")]
			TiltSwingingAround_Attack,
			// Token: 0x0400C4B7 RID: 50359
			[Token(Token = "0x401BDA9")]
			Jump_Attack,
			// Token: 0x0400C4B8 RID: 50360
			[Token(Token = "0x401BDAA")]
			ThreeWayLaser_Attack,
			// Token: 0x0400C4B9 RID: 50361
			[Token(Token = "0x401BDAB")]
			Around_Move
		}

		// Token: 0x02000F1A RID: 3866
		[Token(Token = "0x20014AA")]
		[Serializable]
		public class LotteryBossBehavior : LotteryBossBehavior<AudmuraBossDataAsset.LotteryType>
		{
			// Token: 0x06006510 RID: 25872 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BC8")]
			[Address(RVA = "0x245A140", Offset = "0x245A241", VA = "0x245A140")]
			public LotteryBossBehavior()
			{
			}
		}

		// Token: 0x02000F1B RID: 3867
		[Token(Token = "0x20014AB")]
		[Serializable]
		public class LotteryBossBehaviorParams : LotteryBossBehaviorParams<AudmuraBossDataAsset.LotteryBossBehavior, AudmuraBossDataAsset.LotteryType>
		{
			// Token: 0x06006511 RID: 25873 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BC9")]
			[Address(RVA = "0x245A190", Offset = "0x245A291", VA = "0x245A190")]
			public LotteryBossBehaviorParams()
			{
			}
		}

		// Token: 0x02000F1C RID: 3868
		[Token(Token = "0x20014AC")]
		[Serializable]
		public class LotteryBossBehaviorPramsList : LotteryBossBehaviorPramsList<AudmuraBossDataAsset.LotteryBossBehaviorParams, AudmuraBossDataAsset.LotteryBossBehavior, AudmuraBossDataAsset.LotteryType>
		{
			// Token: 0x06006512 RID: 25874 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BCA")]
			[Address(RVA = "0x245A1E0", Offset = "0x245A2E1", VA = "0x245A1E0")]
			public LotteryBossBehaviorPramsList()
			{
			}
		}
	}
}
