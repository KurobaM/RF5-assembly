using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace BossData
{
	// Token: 0x02000F2E RID: 3886
	[Token(Token = "0x20009E7")]
	public class CalcLotteryBossBehavior
	{
		// Token: 0x06006532 RID: 25906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005413")]
		[Address(RVA = "0x24597A0", Offset = "0x24598A1", VA = "0x24597A0")]
		public CalcLotteryBossBehavior(Dictionary<int, List<BossBehaviorParams>> bossBehaviorListDic)
		{
		}

		// Token: 0x17000D14 RID: 3348
		// (get) Token: 0x06006533 RID: 25907 RVA: 0x00021E70 File Offset: 0x00020070
		// (set) Token: 0x06006534 RID: 25908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A52")]
		protected bool IsMadness
		{
			[Token(Token = "0x6005414")]
			[Address(RVA = "0x245ACC0", Offset = "0x245ADC1", VA = "0x245ACC0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACCF0", Offset = "0x1ACDF1")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005415")]
			[Address(RVA = "0x245ACD0", Offset = "0x245ADD1", VA = "0x245ACD0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACD00", Offset = "0x1ACE01")]
			set
			{
			}
		}

		// Token: 0x17000D15 RID: 3349
		// (get) Token: 0x06006536 RID: 25910 RVA: 0x00021E88 File Offset: 0x00020088
		// (set) Token: 0x06006535 RID: 25909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A53")]
		public int NextBehaviorParamsIndex
		{
			[Token(Token = "0x6005417")]
			[Address(RVA = "0x245ACF0", Offset = "0x245ADF1", VA = "0x245ACF0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACD20", Offset = "0x1ACE21")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005416")]
			[Address(RVA = "0x245ACE0", Offset = "0x245ADE1", VA = "0x245ACE0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACD10", Offset = "0x1ACE11")]
			protected set
			{
			}
		}

		// Token: 0x17000D16 RID: 3350
		// (get) Token: 0x06006538 RID: 25912 RVA: 0x00021EA0 File Offset: 0x000200A0
		// (set) Token: 0x06006537 RID: 25911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A54")]
		public int LoopBehaviorParamsCounter
		{
			[Token(Token = "0x6005419")]
			[Address(RVA = "0x245AD10", Offset = "0x245AE11", VA = "0x245AD10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACD40", Offset = "0x1ACE41")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005418")]
			[Address(RVA = "0x245AD00", Offset = "0x245AE01", VA = "0x245AD00")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACD30", Offset = "0x1ACE31")]
			private set
			{
			}
		}

		// Token: 0x17000D17 RID: 3351
		// (get) Token: 0x0600653A RID: 25914 RVA: 0x00021EB8 File Offset: 0x000200B8
		// (set) Token: 0x06006539 RID: 25913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A55")]
		public float TargetSqrDistance
		{
			[Token(Token = "0x600541B")]
			[Address(RVA = "0x245AD30", Offset = "0x245AE31", VA = "0x245AD30")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACD60", Offset = "0x1ACE61")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600541A")]
			[Address(RVA = "0x245AD20", Offset = "0x245AE21", VA = "0x245AD20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACD50", Offset = "0x1ACE51")]
			set
			{
			}
		}

		// Token: 0x17000D18 RID: 3352
		// (get) Token: 0x0600653C RID: 25916 RVA: 0x00021ED0 File Offset: 0x000200D0
		// (set) Token: 0x0600653B RID: 25915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A56")]
		public bool IsHitPrevAttack
		{
			[Token(Token = "0x600541D")]
			[Address(RVA = "0x245AD50", Offset = "0x245AE51", VA = "0x245AD50")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACD80", Offset = "0x1ACE81")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600541C")]
			[Address(RVA = "0x245AD40", Offset = "0x245AE41", VA = "0x245AD40")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACD70", Offset = "0x1ACE71")]
			set
			{
			}
		}

		// Token: 0x17000D19 RID: 3353
		// (get) Token: 0x0600653E RID: 25918 RVA: 0x00021EE8 File Offset: 0x000200E8
		// (set) Token: 0x0600653D RID: 25917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A57")]
		public int RemainHp
		{
			[Token(Token = "0x600541F")]
			[Address(RVA = "0x245AD70", Offset = "0x245AE71", VA = "0x245AD70")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACDA0", Offset = "0x1ACEA1")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600541E")]
			[Address(RVA = "0x245AD60", Offset = "0x245AE61", VA = "0x245AD60")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACD90", Offset = "0x1ACE91")]
			set
			{
			}
		}

		// Token: 0x17000D1A RID: 3354
		// (get) Token: 0x06006540 RID: 25920 RVA: 0x00021F00 File Offset: 0x00020100
		// (set) Token: 0x0600653F RID: 25919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A58")]
		private int LotteryProbability
		{
			[Token(Token = "0x6005421")]
			[Address(RVA = "0x245AD90", Offset = "0x245AE91", VA = "0x245AD90")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACDC0", Offset = "0x1ACEC1")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005420")]
			[Address(RVA = "0x245AD80", Offset = "0x245AE81", VA = "0x245AD80")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACDB0", Offset = "0x1ACEB1")]
			set
			{
			}
		}

		// Token: 0x06006541 RID: 25921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005422")]
		[Address(RVA = "0x245ADA0", Offset = "0x245AEA1", VA = "0x245ADA0", Slot = "4")]
		public virtual void Setup(int bitArraybits = 0)
		{
		}

		// Token: 0x06006542 RID: 25922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005423")]
		[Address(RVA = "0x245A8D0", Offset = "0x245A9D1", VA = "0x245A8D0", Slot = "5")]
		public virtual void OnMadness()
		{
		}

		// Token: 0x06006543 RID: 25923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005424")]
		[Address(RVA = "0x245AE50", Offset = "0x245AF51", VA = "0x245AE50")]
		public void SetBitArray(int index, bool value)
		{
		}

		// Token: 0x06006544 RID: 25924 RVA: 0x00021F18 File Offset: 0x00020118
		[Token(Token = "0x6005425")]
		[Address(RVA = "0x245AE80", Offset = "0x245AF81", VA = "0x245AE80")]
		public bool GetBitArray(int index)
		{
			return default(bool);
		}

		// Token: 0x06006545 RID: 25925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005426")]
		[Address(RVA = "0x2458A10", Offset = "0x2458B11", VA = "0x2458A10")]
		public void OnUpdateBossDataBitArray()
		{
		}

		// Token: 0x06006546 RID: 25926 RVA: 0x00021F30 File Offset: 0x00020130
		[Token(Token = "0x6005427")]
		[Address(RVA = "0x2459C90", Offset = "0x2459D91", VA = "0x2459C90", Slot = "6")]
		public virtual int Lottery()
		{
			return 0;
		}

		// Token: 0x06006547 RID: 25927 RVA: 0x00021F48 File Offset: 0x00020148
		[Token(Token = "0x6005428")]
		[Address(RVA = "0x245AA30", Offset = "0x245AB31", VA = "0x245AA30")]
		protected int GetNextBehaviorParamIndex(List<BossBehaviorParams> bossBehaviorParamsList)
		{
			return 0;
		}

		// Token: 0x06006548 RID: 25928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005429")]
		[Address(RVA = "0x2459D70", Offset = "0x2459E71", VA = "0x2459D70", Slot = "7")]
		protected virtual void OnNextBehaviorParamsIndex(int listCount, BossBehaviorParam retBehaviorParam)
		{
		}

		// Token: 0x06006549 RID: 25929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600542A")]
		[Address(RVA = "0x245B040", Offset = "0x245B141", VA = "0x245B040", Slot = "8")]
		protected virtual void OnLoop()
		{
		}

		// Token: 0x0600654A RID: 25930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600542B")]
		[Address(RVA = "0x245AE30", Offset = "0x245AF31", VA = "0x245AE30")]
		public void ResetNextBehaviorParamsIndex()
		{
		}

		// Token: 0x0600654B RID: 25931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600542C")]
		[Address(RVA = "0x245AE40", Offset = "0x245AF41", VA = "0x245AE40")]
		public void ResetLoopBehaviorParamsCounter()
		{
		}

		// Token: 0x0600654C RID: 25932 RVA: 0x00021F60 File Offset: 0x00020160
		[Token(Token = "0x600542D")]
		[Address(RVA = "0x245B050", Offset = "0x245B151", VA = "0x245B050", Slot = "9")]
		public virtual bool IsMovementAction(int type)
		{
			return default(bool);
		}

		// Token: 0x0600654D RID: 25933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600542E")]
		protected virtual T Lottery<T>(BossLotteryParam<T>[] sortedPairs) where T : struct
		{
			return null;
		}

		// Token: 0x0600654E RID: 25934 RVA: 0x00021F78 File Offset: 0x00020178
		[Token(Token = "0x600542F")]
		[Address(RVA = "0x245AEB0", Offset = "0x245AFB1", VA = "0x245AEB0")]
		private bool GetIsCompare(CompareType compareType, int param)
		{
			return default(bool);
		}

		// Token: 0x0600654F RID: 25935 RVA: 0x00021F90 File Offset: 0x00020190
		[Token(Token = "0x6005430")]
		[Address(RVA = "0x245B0D0", Offset = "0x245B1D1", VA = "0x245B0D0")]
		public bool IsMatchLoopCount(int value)
		{
			return default(bool);
		}

		// Token: 0x06006550 RID: 25936 RVA: 0x00021FA8 File Offset: 0x000201A8
		[Token(Token = "0x6005431")]
		[Address(RVA = "0x245B060", Offset = "0x245B161", VA = "0x245B060")]
		public bool IsLoopSurplusOddNumber()
		{
			return default(bool);
		}

		// Token: 0x06006551 RID: 25937 RVA: 0x00021FC0 File Offset: 0x000201C0
		[Token(Token = "0x6005432")]
		[Address(RVA = "0x245B080", Offset = "0x245B181", VA = "0x245B080")]
		public bool IsLoopSurplusEvenNumber()
		{
			return default(bool);
		}

		// Token: 0x06006552 RID: 25938 RVA: 0x00021FD8 File Offset: 0x000201D8
		[Token(Token = "0x6005433")]
		[Address(RVA = "0x245B090", Offset = "0x245B191", VA = "0x245B090")]
		public bool IsInTargetRange(int range)
		{
			return default(bool);
		}

		// Token: 0x06006553 RID: 25939 RVA: 0x00021FF0 File Offset: 0x000201F0
		[Token(Token = "0x6005434")]
		[Address(RVA = "0x245B0B0", Offset = "0x245B1B1", VA = "0x245B0B0")]
		public bool IsOutTargetRange(int range)
		{
			return default(bool);
		}

		// Token: 0x06006554 RID: 25940 RVA: 0x00022008 File Offset: 0x00020208
		[Token(Token = "0x6005435")]
		[Address(RVA = "0x245B0E0", Offset = "0x245B1E1", VA = "0x245B0E0")]
		public bool IsRemainHp(int value)
		{
			return default(bool);
		}

		// Token: 0x06006555 RID: 25941 RVA: 0x00022020 File Offset: 0x00020220
		[Token(Token = "0x6005436")]
		[Address(RVA = "0x245B0F0", Offset = "0x245B1F1", VA = "0x245B0F0")]
		public bool Probability(int value)
		{
			return default(bool);
		}

		// Token: 0x0400C50E RID: 50446
		[Token(Token = "0x4009348")]
		[FieldOffset(Offset = "0x10")]
		protected Dictionary<int, List<BossBehaviorParams>> BossBehaviorParmsListDic;

		// Token: 0x0400C50F RID: 50447
		[Token(Token = "0x4009349")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F920", Offset = "0x17FA21")]
		private bool <IsMadness>k__BackingField;

		// Token: 0x0400C510 RID: 50448
		[Token(Token = "0x400934A")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F930", Offset = "0x17FA31")]
		private int <NextBehaviorParamsIndex>k__BackingField;

		// Token: 0x0400C511 RID: 50449
		[Token(Token = "0x400934B")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F940", Offset = "0x17FA41")]
		private int <LoopBehaviorParamsCounter>k__BackingField;

		// Token: 0x0400C512 RID: 50450
		[Token(Token = "0x400934C")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F950", Offset = "0x17FA51")]
		private float <TargetSqrDistance>k__BackingField;

		// Token: 0x0400C513 RID: 50451
		[Token(Token = "0x400934D")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F960", Offset = "0x17FA61")]
		private bool <IsHitPrevAttack>k__BackingField;

		// Token: 0x0400C514 RID: 50452
		[Token(Token = "0x400934E")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F970", Offset = "0x17FA71")]
		private int <RemainHp>k__BackingField;

		// Token: 0x0400C515 RID: 50453
		[Token(Token = "0x400934F")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F980", Offset = "0x17FA81")]
		private int <LotteryProbability>k__BackingField;

		// Token: 0x0400C516 RID: 50454
		[Token(Token = "0x4009350")]
		[FieldOffset(Offset = "0x38")]
		protected BitArray BitArray;

		// Token: 0x02000F2F RID: 3887
		[Token(Token = "0x20014B3")]
		public enum BitArrayIndex
		{
			// Token: 0x0400C518 RID: 50456
			[Token(Token = "0x401BDD3")]
			Empty,
			// Token: 0x0400C519 RID: 50457
			[Token(Token = "0x401BDD4")]
			e_Count
		}

		// Token: 0x02000F30 RID: 3888
		[Token(Token = "0x20014B4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159BA0", Offset = "0x159CA1")]
		[Serializable]
		private sealed class <>c__44<T> where T : struct
		{
			// Token: 0x06006557 RID: 25943 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BCF")]
			public <>c__44()
			{
			}

			// Token: 0x06006558 RID: 25944 RVA: 0x00022038 File Offset: 0x00020238
			[Token(Token = "0x6007BD0")]
			internal float <Lottery>b__44_0(BossLotteryParam<T> x)
			{
				return 0f;
			}

			// Token: 0x0400C51A RID: 50458
			[Token(Token = "0x401BDD5")]
			[FieldOffset(Offset = "0x0")]
			public static readonly CalcLotteryBossBehavior.<>c__44<T> <>9;

			// Token: 0x0400C51B RID: 50459
			[Token(Token = "0x401BDD6")]
			[FieldOffset(Offset = "0x0")]
			public static Func<BossLotteryParam<T>, float> <>9__44_0;
		}
	}
}
