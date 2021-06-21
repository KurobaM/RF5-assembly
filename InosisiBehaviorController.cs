using System;
using BossData;
using Il2CppDummyDll;

// Token: 0x0200070F RID: 1807
[Token(Token = "0x20004F3")]
public class InosisiBehaviorController : BossBehaviorController
{
	// Token: 0x06002D85 RID: 11653 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002668")]
	[Address(RVA = "0x222CFA0", Offset = "0x222D0A1", VA = "0x222CFA0")]
	private MonsterBehaviorController.BehaviorActionParam CreateMoveAroundAction()
	{
		return null;
	}

	// Token: 0x06002D86 RID: 11654 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002669")]
	[Address(RVA = "0x222D160", Offset = "0x222D261", VA = "0x222D160")]
	private MonsterBehaviorController.BehaviorActionParam CreateStompAction()
	{
		return null;
	}

	// Token: 0x06002D87 RID: 11655 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600266A")]
	[Address(RVA = "0x222D330", Offset = "0x222D431", VA = "0x222D330")]
	private MonsterBehaviorController.BehaviorActionParam CreateChargeStompAction()
	{
		return null;
	}

	// Token: 0x06002D88 RID: 11656 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600266B")]
	[Address(RVA = "0x222D500", Offset = "0x222D601", VA = "0x222D500")]
	private MonsterBehaviorController.BehaviorActionParam CreateThrowHornAction(int Rock)
	{
		return null;
	}

	// Token: 0x06002D89 RID: 11657 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600266C")]
	[Address(RVA = "0x222D700", Offset = "0x222D801", VA = "0x222D700")]
	private MonsterBehaviorController.BehaviorActionParam CreateThrowWaveAction()
	{
		return null;
	}

	// Token: 0x06002D8A RID: 11658 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600266D")]
	[Address(RVA = "0x222D710", Offset = "0x222D811", VA = "0x222D710")]
	private MonsterBehaviorController.BehaviorActionParam CreateThrowRockAction()
	{
		return null;
	}

	// Token: 0x06002D8B RID: 11659 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600266E")]
	[Address(RVA = "0x222D720", Offset = "0x222D821", VA = "0x222D720")]
	private MonsterBehaviorController.BehaviorActionParam CreateMeteorAction()
	{
		return null;
	}

	// Token: 0x06002D8C RID: 11660 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600266F")]
	[Address(RVA = "0x222D8E0", Offset = "0x222D9E1", VA = "0x222D8E0")]
	private MonsterBehaviorController.BehaviorActionParam CreateSuperDushAction()
	{
		return null;
	}

	// Token: 0x06002D8D RID: 11661 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002670")]
	[Address(RVA = "0x222DAA0", Offset = "0x222DBA1", VA = "0x222DAA0")]
	private MonsterBehaviorController.BehaviorActionParam CreateRushMissileAction()
	{
		return null;
	}

	// Token: 0x06002D8E RID: 11662 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002671")]
	[Address(RVA = "0x222DC70", Offset = "0x222DD71", VA = "0x222DC70")]
	private MonsterBehaviorController.BehaviorActionParam CreateMadnessMissileAction()
	{
		return null;
	}

	// Token: 0x06002D8F RID: 11663 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002672")]
	[Address(RVA = "0x222DE40", Offset = "0x222DF41", VA = "0x222DE40")]
	private MonsterBehaviorController.BehaviorActionParam CreateRushAction()
	{
		return null;
	}

	// Token: 0x06002D90 RID: 11664 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002673")]
	[Address(RVA = "0x222E000", Offset = "0x222E101", VA = "0x222E000", Slot = "10")]
	protected override void OnSetup()
	{
	}

	// Token: 0x06002D91 RID: 11665 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002674")]
	[Address(RVA = "0x222E240", Offset = "0x222E341", VA = "0x222E240", Slot = "82")]
	public override void SetBossDataAsset(BossDataAssetBase bossData)
	{
	}

	// Token: 0x06002D92 RID: 11666 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002675")]
	[Address(RVA = "0x222E2E0", Offset = "0x222E3E1", VA = "0x222E2E0", Slot = "88")]
	public override void OnUpdateBossDataBitArray()
	{
	}

	// Token: 0x06002D93 RID: 11667 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002676")]
	[Address(RVA = "0x222E360", Offset = "0x222E461", VA = "0x222E360")]
	private void UpdateDamageAmount(int damage)
	{
	}

	// Token: 0x06002D94 RID: 11668 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002677")]
	[Address(RVA = "0x222E3E0", Offset = "0x222E4E1", VA = "0x222E3E0", Slot = "57")]
	public override void TakeDamage(bool isDamage, float blowDist, DamageInfo damageInfo, ref DamageResult damageResult)
	{
	}

	// Token: 0x06002D95 RID: 11669 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002678")]
	[Address(RVA = "0x222E4F0", Offset = "0x222E5F1", VA = "0x222E4F0", Slot = "92")]
	protected override void UpdateRestraintBehaviorTiming()
	{
	}

	// Token: 0x06002D96 RID: 11670 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002679")]
	[Address(RVA = "0x222E540", Offset = "0x222E641", VA = "0x222E540")]
	public InosisiBehaviorController()
	{
	}

	// Token: 0x06002D97 RID: 11671 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600267A")]
	[Address(RVA = "0x222E550", Offset = "0x222E651", VA = "0x222E550")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3520", Offset = "0x1A3621")]
	private void <CreateMoveAroundAction>b__3_1(int index, int type)
	{
	}

	// Token: 0x06002D98 RID: 11672 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600267B")]
	[Address(RVA = "0x222E730", Offset = "0x222E831", VA = "0x222E730")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3530", Offset = "0x1A3631")]
	private void <CreateStompAction>b__4_0()
	{
	}

	// Token: 0x06002D99 RID: 11673 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600267C")]
	[Address(RVA = "0x222E780", Offset = "0x222E881", VA = "0x222E780")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3540", Offset = "0x1A3641")]
	private void <CreateChargeStompAction>b__5_0()
	{
	}

	// Token: 0x06002D9A RID: 11674 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600267D")]
	[Address(RVA = "0x222E7D0", Offset = "0x222E8D1", VA = "0x222E7D0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3550", Offset = "0x1A3651")]
	private void <CreateMeteorAction>b__9_0()
	{
	}

	// Token: 0x06002D9B RID: 11675 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600267E")]
	[Address(RVA = "0x222E820", Offset = "0x222E921", VA = "0x222E820")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3560", Offset = "0x1A3661")]
	private void <CreateSuperDushAction>b__10_0()
	{
	}

	// Token: 0x06002D9C RID: 11676 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600267F")]
	[Address(RVA = "0x222E870", Offset = "0x222E971", VA = "0x222E870")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3570", Offset = "0x1A3671")]
	private void <CreateRushMissileAction>b__11_0()
	{
	}

	// Token: 0x06002D9D RID: 11677 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002680")]
	[Address(RVA = "0x222E8C0", Offset = "0x222E9C1", VA = "0x222E8C0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3580", Offset = "0x1A3681")]
	private void <CreateMadnessMissileAction>b__12_0()
	{
	}

	// Token: 0x06002D9E RID: 11678 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002681")]
	[Address(RVA = "0x222E910", Offset = "0x222EA11", VA = "0x222E910")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3590", Offset = "0x1A3691")]
	private void <CreateRushAction>b__13_0()
	{
	}

	// Token: 0x040073F0 RID: 29680
	[Token(Token = "0x4006AE7")]
	[FieldOffset(Offset = "0x1C0")]
	private float DamageAmount;

	// Token: 0x040073F1 RID: 29681
	[Token(Token = "0x4006AE8")]
	[FieldOffset(Offset = "0x1C4")]
	private float MaxDamageHPPercent;

	// Token: 0x040073F2 RID: 29682
	[Token(Token = "0x4006AE9")]
	[FieldOffset(Offset = "0x1C8")]
	private bool IsFilledDamage;

	// Token: 0x02000710 RID: 1808
	[Token(Token = "0x20011A3")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158470", Offset = "0x158571")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06002DA0 RID: 11680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007209")]
		[Address(RVA = "0x222E9D0", Offset = "0x222EAD1", VA = "0x222E9D0")]
		public <>c()
		{
		}

		// Token: 0x06002DA1 RID: 11681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600720A")]
		[Address(RVA = "0x222E9E0", Offset = "0x222EAE1", VA = "0x222E9E0")]
		internal void <CreateMoveAroundAction>b__3_0()
		{
		}

		// Token: 0x06002DA2 RID: 11682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600720B")]
		[Address(RVA = "0x222E9F0", Offset = "0x222EAF1", VA = "0x222E9F0")]
		internal void <CreateStompAction>b__4_1(int index, int type)
		{
		}

		// Token: 0x06002DA3 RID: 11683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600720C")]
		[Address(RVA = "0x222EA00", Offset = "0x222EB01", VA = "0x222EA00")]
		internal void <CreateChargeStompAction>b__5_1(int index, int type)
		{
		}

		// Token: 0x06002DA4 RID: 11684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600720D")]
		[Address(RVA = "0x222EA10", Offset = "0x222EB11", VA = "0x222EA10")]
		internal void <CreateThrowHornAction>b__6_1(int index, int type)
		{
		}

		// Token: 0x06002DA5 RID: 11685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600720E")]
		[Address(RVA = "0x222EA20", Offset = "0x222EB21", VA = "0x222EA20")]
		internal void <CreateMeteorAction>b__9_1(int index, int type)
		{
		}

		// Token: 0x06002DA6 RID: 11686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600720F")]
		[Address(RVA = "0x222EA30", Offset = "0x222EB31", VA = "0x222EA30")]
		internal void <CreateSuperDushAction>b__10_1(int index, int type)
		{
		}

		// Token: 0x06002DA7 RID: 11687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007210")]
		[Address(RVA = "0x222EA40", Offset = "0x222EB41", VA = "0x222EA40")]
		internal void <CreateRushMissileAction>b__11_1(int index, int type)
		{
		}

		// Token: 0x06002DA8 RID: 11688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007211")]
		[Address(RVA = "0x222EA50", Offset = "0x222EB51", VA = "0x222EA50")]
		internal void <CreateMadnessMissileAction>b__12_1(int index, int type)
		{
		}

		// Token: 0x06002DA9 RID: 11689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007212")]
		[Address(RVA = "0x222EA60", Offset = "0x222EB61", VA = "0x222EA60")]
		internal void <CreateRushAction>b__13_1(int index, int type)
		{
		}

		// Token: 0x040073F3 RID: 29683
		[Token(Token = "0x4019572")]
		[FieldOffset(Offset = "0x0")]
		public static readonly InosisiBehaviorController.<>c <>9;

		// Token: 0x040073F4 RID: 29684
		[Token(Token = "0x4019573")]
		[FieldOffset(Offset = "0x8")]
		public static System.Action <>9__3_0;

		// Token: 0x040073F5 RID: 29685
		[Token(Token = "0x4019574")]
		[FieldOffset(Offset = "0x10")]
		public static Action<int, int> <>9__4_1;

		// Token: 0x040073F6 RID: 29686
		[Token(Token = "0x4019575")]
		[FieldOffset(Offset = "0x18")]
		public static Action<int, int> <>9__5_1;

		// Token: 0x040073F7 RID: 29687
		[Token(Token = "0x4019576")]
		[FieldOffset(Offset = "0x20")]
		public static Action<int, int> <>9__6_1;

		// Token: 0x040073F8 RID: 29688
		[Token(Token = "0x4019577")]
		[FieldOffset(Offset = "0x28")]
		public static Action<int, int> <>9__9_1;

		// Token: 0x040073F9 RID: 29689
		[Token(Token = "0x4019578")]
		[FieldOffset(Offset = "0x30")]
		public static Action<int, int> <>9__10_1;

		// Token: 0x040073FA RID: 29690
		[Token(Token = "0x4019579")]
		[FieldOffset(Offset = "0x38")]
		public static Action<int, int> <>9__11_1;

		// Token: 0x040073FB RID: 29691
		[Token(Token = "0x401957A")]
		[FieldOffset(Offset = "0x40")]
		public static Action<int, int> <>9__12_1;

		// Token: 0x040073FC RID: 29692
		[Token(Token = "0x401957B")]
		[FieldOffset(Offset = "0x48")]
		public static Action<int, int> <>9__13_1;
	}

	// Token: 0x02000711 RID: 1809
	[Token(Token = "0x20011A4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158480", Offset = "0x158581")]
	private sealed class <>c__DisplayClass6_0
	{
		// Token: 0x06002DAA RID: 11690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007213")]
		[Address(RVA = "0x222D6F0", Offset = "0x222D7F1", VA = "0x222D6F0")]
		public <>c__DisplayClass6_0()
		{
		}

		// Token: 0x06002DAB RID: 11691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007214")]
		[Address(RVA = "0x222EA70", Offset = "0x222EB71", VA = "0x222EA70")]
		internal void <CreateThrowHornAction>b__0()
		{
		}

		// Token: 0x040073FD RID: 29693
		[Token(Token = "0x401957C")]
		[FieldOffset(Offset = "0x10")]
		public int Rock;

		// Token: 0x040073FE RID: 29694
		[Token(Token = "0x401957D")]
		[FieldOffset(Offset = "0x18")]
		public InosisiBehaviorController <>4__this;
	}
}
