using System;
using BossData;
using Il2CppDummyDll;

// Token: 0x020006A5 RID: 1701
[Token(Token = "0x20004C7")]
public class AracneBehaviorController : BossBehaviorController
{
	// Token: 0x1700068C RID: 1676
	// (get) Token: 0x06002952 RID: 10578 RVA: 0x00010320 File Offset: 0x0000E520
	[Token(Token = "0x1700053A")]
	private bool IsAccumulatedDamage
	{
		[Token(Token = "0x60022F2")]
		[Address(RVA = "0x24368F0", Offset = "0x24369F1", VA = "0x24368F0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700068D RID: 1677
	// (get) Token: 0x06002953 RID: 10579 RVA: 0x00010338 File Offset: 0x0000E538
	[Token(Token = "0x1700053B")]
	private bool Is2PColor
	{
		[Token(Token = "0x60022F3")]
		[Address(RVA = "0x2436960", Offset = "0x2436A61", VA = "0x2436960")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06002954 RID: 10580 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022F4")]
	[Address(RVA = "0x24369B0", Offset = "0x2436AB1", VA = "0x24369B0", Slot = "10")]
	protected override void OnSetup()
	{
	}

	// Token: 0x06002955 RID: 10581 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022F5")]
	[Address(RVA = "0x24376C0", Offset = "0x24377C1", VA = "0x24376C0", Slot = "82")]
	public override void SetBossDataAsset(BossDataAssetBase bossData)
	{
	}

	// Token: 0x06002956 RID: 10582 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022F6")]
	[Address(RVA = "0x2437700", Offset = "0x2437801", VA = "0x2437700", Slot = "88")]
	public override void OnUpdateBossDataBitArray()
	{
	}

	// Token: 0x06002957 RID: 10583 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022F7")]
	[Address(RVA = "0x2437840", Offset = "0x2437941", VA = "0x2437840", Slot = "57")]
	public override void TakeDamage(bool isDamage, float blowDist, DamageInfo damageInfo, ref DamageResult damageResult)
	{
	}

	// Token: 0x06002958 RID: 10584 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022F8")]
	[Address(RVA = "0x2437940", Offset = "0x2437A41", VA = "0x2437940", Slot = "92")]
	protected override void UpdateRestraintBehaviorTiming()
	{
	}

	// Token: 0x06002959 RID: 10585 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022F9")]
	[Address(RVA = "0x2437980", Offset = "0x2437A81", VA = "0x2437980", Slot = "93")]
	protected override void UpdateReciveItemBehaviorTiming()
	{
	}

	// Token: 0x0600295A RID: 10586 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022FA")]
	[Address(RVA = "0x2436B30", Offset = "0x2436C31", VA = "0x2436B30")]
	private MonsterBehaviorController.BehaviorActionParam CreateBothfeetStabAttack()
	{
		return null;
	}

	// Token: 0x0600295B RID: 10587 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022FB")]
	[Address(RVA = "0x2436D10", Offset = "0x2436E11", VA = "0x2436D10")]
	private MonsterBehaviorController.BehaviorActionParam CreateFlatWebAttack()
	{
		return null;
	}

	// Token: 0x0600295C RID: 10588 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022FC")]
	[Address(RVA = "0x2436EF0", Offset = "0x2436FF1", VA = "0x2436EF0")]
	private MonsterBehaviorController.BehaviorActionParam CreateEightfeetStabAttack()
	{
		return null;
	}

	// Token: 0x0600295D RID: 10589 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022FD")]
	[Address(RVA = "0x24370C0", Offset = "0x24371C1", VA = "0x24370C0")]
	private MonsterBehaviorController.BehaviorActionParam CreateCageWebAttack()
	{
		return null;
	}

	// Token: 0x0600295E RID: 10590 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022FE")]
	[Address(RVA = "0x24372A0", Offset = "0x24373A1", VA = "0x24372A0")]
	private MonsterBehaviorController.BehaviorActionParam CreateSprinklingVenomAttack()
	{
		return null;
	}

	// Token: 0x0600295F RID: 10591 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022FF")]
	[Address(RVA = "0x2437500", Offset = "0x2437601", VA = "0x2437500")]
	private MonsterBehaviorController.BehaviorActionParam CreateMasterSpiderSpawn()
	{
		return null;
	}

	// Token: 0x06002960 RID: 10592 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002300")]
	[Address(RVA = "0x2437A10", Offset = "0x2437B11", VA = "0x2437A10", Slot = "87")]
	public override string GetLotteryTypeEnumToString(int SelectType)
	{
		return null;
	}

	// Token: 0x06002961 RID: 10593 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002301")]
	[Address(RVA = "0x2437B50", Offset = "0x2437C51", VA = "0x2437B50")]
	public AracneBehaviorController()
	{
	}

	// Token: 0x06002962 RID: 10594 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002302")]
	[Address(RVA = "0x2437B60", Offset = "0x2437C61", VA = "0x2437B60")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A22E0", Offset = "0x1A23E1")]
	private void <CreateBothfeetStabAttack>b__13_0()
	{
	}

	// Token: 0x06002963 RID: 10595 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002303")]
	[Address(RVA = "0x2437BB0", Offset = "0x2437CB1", VA = "0x2437BB0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A22F0", Offset = "0x1A23F1")]
	private void <CreateFlatWebAttack>b__14_0()
	{
	}

	// Token: 0x06002964 RID: 10596 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002304")]
	[Address(RVA = "0x2437C00", Offset = "0x2437D01", VA = "0x2437C00")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2300", Offset = "0x1A2401")]
	private void <CreateEightfeetStabAttack>b__15_0()
	{
	}

	// Token: 0x06002965 RID: 10597 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002305")]
	[Address(RVA = "0x2437C50", Offset = "0x2437D51", VA = "0x2437C50")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2310", Offset = "0x1A2411")]
	private void <CreateCageWebAttack>b__16_0()
	{
	}

	// Token: 0x06002966 RID: 10598 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002306")]
	[Address(RVA = "0x2437CA0", Offset = "0x2437DA1", VA = "0x2437CA0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2320", Offset = "0x1A2421")]
	private void <CreateSprinklingVenomAttack>b__17_0()
	{
	}

	// Token: 0x06002967 RID: 10599 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002307")]
	[Address(RVA = "0x2437CF0", Offset = "0x2437DF1", VA = "0x2437CF0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2330", Offset = "0x1A2431")]
	private void <CreateMasterSpiderSpawn>b__18_0()
	{
	}

	// Token: 0x04007194 RID: 29076
	[Token(Token = "0x4006990")]
	[FieldOffset(Offset = "0x1C0")]
	private int AccumulatedDamageCounter;

	// Token: 0x04007195 RID: 29077
	[Token(Token = "0x4006991")]
	[FieldOffset(Offset = "0x1C4")]
	private float AccumulatedDamagePercent;

	// Token: 0x04007196 RID: 29078
	[Token(Token = "0x4006992")]
	[FieldOffset(Offset = "0x1C8")]
	private int MaxSpiderNum;

	// Token: 0x020006A6 RID: 1702
	[Token(Token = "0x2001167")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158250", Offset = "0x158351")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06002969 RID: 10601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600714C")]
		[Address(RVA = "0x2437DB0", Offset = "0x2437EB1", VA = "0x2437DB0")]
		public <>c()
		{
		}

		// Token: 0x0600296A RID: 10602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600714D")]
		[Address(RVA = "0x2437DC0", Offset = "0x2437EC1", VA = "0x2437DC0")]
		internal void <CreateBothfeetStabAttack>b__13_1(int index, int type)
		{
		}

		// Token: 0x0600296B RID: 10603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600714E")]
		[Address(RVA = "0x2437DD0", Offset = "0x2437ED1", VA = "0x2437DD0")]
		internal void <CreateFlatWebAttack>b__14_1(int index, int type)
		{
		}

		// Token: 0x0600296C RID: 10604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600714F")]
		[Address(RVA = "0x2437DE0", Offset = "0x2437EE1", VA = "0x2437DE0")]
		internal void <CreateEightfeetStabAttack>b__15_1(int index, int type)
		{
		}

		// Token: 0x0600296D RID: 10605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007150")]
		[Address(RVA = "0x2437DF0", Offset = "0x2437EF1", VA = "0x2437DF0")]
		internal void <CreateCageWebAttack>b__16_1(int index, int type)
		{
		}

		// Token: 0x0600296E RID: 10606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007151")]
		[Address(RVA = "0x2437E00", Offset = "0x2437F01", VA = "0x2437E00")]
		internal void <CreateSprinklingVenomAttack>b__17_1(int index, int type)
		{
		}

		// Token: 0x0600296F RID: 10607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007152")]
		[Address(RVA = "0x2437E10", Offset = "0x2437F11", VA = "0x2437E10")]
		internal void <CreateSprinklingVenomAttack>b__17_2()
		{
		}

		// Token: 0x06002970 RID: 10608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007153")]
		[Address(RVA = "0x2437E20", Offset = "0x2437F21", VA = "0x2437E20")]
		internal void <CreateMasterSpiderSpawn>b__18_1(int index, int type)
		{
		}

		// Token: 0x04007197 RID: 29079
		[Token(Token = "0x4019477")]
		[FieldOffset(Offset = "0x0")]
		public static readonly AracneBehaviorController.<>c <>9;

		// Token: 0x04007198 RID: 29080
		[Token(Token = "0x4019478")]
		[FieldOffset(Offset = "0x8")]
		public static Action<int, int> <>9__13_1;

		// Token: 0x04007199 RID: 29081
		[Token(Token = "0x4019479")]
		[FieldOffset(Offset = "0x10")]
		public static Action<int, int> <>9__14_1;

		// Token: 0x0400719A RID: 29082
		[Token(Token = "0x401947A")]
		[FieldOffset(Offset = "0x18")]
		public static Action<int, int> <>9__15_1;

		// Token: 0x0400719B RID: 29083
		[Token(Token = "0x401947B")]
		[FieldOffset(Offset = "0x20")]
		public static Action<int, int> <>9__16_1;

		// Token: 0x0400719C RID: 29084
		[Token(Token = "0x401947C")]
		[FieldOffset(Offset = "0x28")]
		public static Action<int, int> <>9__17_1;

		// Token: 0x0400719D RID: 29085
		[Token(Token = "0x401947D")]
		[FieldOffset(Offset = "0x30")]
		public static System.Action <>9__17_2;

		// Token: 0x0400719E RID: 29086
		[Token(Token = "0x401947E")]
		[FieldOffset(Offset = "0x38")]
		public static Action<int, int> <>9__18_1;
	}
}
