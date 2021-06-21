using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace BossData
{
	// Token: 0x02000F2D RID: 3885
	[Token(Token = "0x20009E6")]
	[Serializable]
	public abstract class BossDataAssetBase : ScriptableObject
	{
		// Token: 0x06006529 RID: 25897 RVA: 0x00021DF8 File Offset: 0x0001FFF8
		[Token(Token = "0x600540A")]
		[Address(RVA = "0x245AC80", Offset = "0x245AD81", VA = "0x245AC80", Slot = "4")]
		public virtual float ChangeMadnessRemainHPPercent(bool isColorVariation, MonsterDataID dataid)
		{
			return 0f;
		}

		// Token: 0x0600652A RID: 25898 RVA: 0x00021E10 File Offset: 0x00020010
		[Token(Token = "0x600540B")]
		[Address(RVA = "0x24592D0", Offset = "0x24593D1", VA = "0x24592D0", Slot = "5")]
		public virtual float ChangeMadnessRemainHPPercent(bool isColorVariation)
		{
			return 0f;
		}

		// Token: 0x17000D13 RID: 3347
		// (get) Token: 0x0600652B RID: 25899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A51")]
		public List<string> MadnessEffectBoneList
		{
			[Token(Token = "0x600540C")]
			[Address(RVA = "0x245ACA0", Offset = "0x245ADA1", VA = "0x245ACA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600652C RID: 25900 RVA: 0x00021E28 File Offset: 0x00020028
		[Token(Token = "0x600540D")]
		[Address(RVA = "0x2459200", Offset = "0x2459301", VA = "0x2459200", Slot = "6")]
		public virtual int GetIntParam(string key)
		{
			return 0;
		}

		// Token: 0x0600652D RID: 25901 RVA: 0x00021E40 File Offset: 0x00020040
		[Token(Token = "0x600540E")]
		[Address(RVA = "0x2459290", Offset = "0x2459391", VA = "0x2459290", Slot = "7")]
		public virtual float GetFloatParam(string key)
		{
			return 0f;
		}

		// Token: 0x0600652E RID: 25902 RVA: 0x00021E58 File Offset: 0x00020058
		[Token(Token = "0x600540F")]
		[Address(RVA = "0x245ACB0", Offset = "0x245ADB1", VA = "0x245ACB0", Slot = "8")]
		public virtual bool GetBoolParam(string key)
		{
			return default(bool);
		}

		// Token: 0x0600652F RID: 25903
		[Token(Token = "0x6005410")]
		public abstract BossBehaviorController AddBossBehaviorControllerBase(GameObject monster);

		// Token: 0x06006530 RID: 25904
		[Token(Token = "0x6005411")]
		public abstract CalcLotteryBossBehavior GetCalcLotteryBossBehavior();

		// Token: 0x06006531 RID: 25905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005412")]
		[Address(RVA = "0x2459620", Offset = "0x2459721", VA = "0x2459620")]
		protected BossDataAssetBase()
		{
		}

		// Token: 0x0400C50A RID: 50442
		[Token(Token = "0x4009344")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x17F820", Offset = "0x17F921")]
		[SerializeField]
		private float _ChangeMadnessRemainHPPercent;

		// Token: 0x0400C50B RID: 50443
		[Token(Token = "0x4009345")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x17F870", Offset = "0x17F971")]
		[SerializeField]
		private float VariationChangeMadnessRemainHPPercent;

		// Token: 0x0400C50C RID: 50444
		[Token(Token = "0x4009346")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x17F8C0", Offset = "0x17F9C1")]
		[SerializeField]
		private List<string> _MadnessEffectBoneList;

		// Token: 0x0400C50D RID: 50445
		[Token(Token = "0x4009347")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public float MadnessEffectScale;
	}
}
