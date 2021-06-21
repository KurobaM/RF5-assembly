using System;
using BehaviorDesigner.Runtime.Tasks;
using BossData;
using Il2CppDummyDll;

// Token: 0x02000763 RID: 1891
[Token(Token = "0x2000515")]
public class SkullDragonBehaviorController : BossBehaviorController
{
	// Token: 0x170006E0 RID: 1760
	// (get) Token: 0x060030AD RID: 12461 RVA: 0x00011088 File Offset: 0x0000F288
	// (set) Token: 0x060030AE RID: 12462 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000572")]
	public bool IsRedyFireBreath
	{
		[Token(Token = "0x60028E4")]
		[Address(RVA = "0x1DE9720", Offset = "0x1DE9821", VA = "0x1DE9720")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A43C0", Offset = "0x1A44C1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60028E5")]
		[Address(RVA = "0x1DE9730", Offset = "0x1DE9831", VA = "0x1DE9730")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A43D0", Offset = "0x1A44D1")]
		set
		{
		}
	}

	// Token: 0x170006E1 RID: 1761
	// (get) Token: 0x060030AF RID: 12463 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000573")]
	private SkullDragonController SkullDragonController
	{
		[Token(Token = "0x60028E6")]
		[Address(RVA = "0x1DE9740", Offset = "0x1DE9841", VA = "0x1DE9740")]
		get
		{
			return null;
		}
	}

	// Token: 0x170006E2 RID: 1762
	// (get) Token: 0x060030B0 RID: 12464 RVA: 0x000110A0 File Offset: 0x0000F2A0
	// (set) Token: 0x060030B1 RID: 12465 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000574")]
	private bool IsFilledTailDamage
	{
		[Token(Token = "0x60028E7")]
		[Address(RVA = "0x1DE97F0", Offset = "0x1DE98F1", VA = "0x1DE97F0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60028E8")]
		[Address(RVA = "0x1DE9800", Offset = "0x1DE9901", VA = "0x1DE9800")]
		set
		{
		}
	}

	// Token: 0x060030B2 RID: 12466 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60028E9")]
	[Address(RVA = "0x1DE98C0", Offset = "0x1DE99C1", VA = "0x1DE98C0")]
	private void WaitAnger_Init()
	{
	}

	// Token: 0x060030B3 RID: 12467 RVA: 0x000110B8 File Offset: 0x0000F2B8
	[Token(Token = "0x60028EA")]
	[Address(RVA = "0x1DE98D0", Offset = "0x1DE99D1", VA = "0x1DE98D0")]
	private TaskStatus WaitAnger_Update()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x060030B4 RID: 12468 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60028EB")]
	[Address(RVA = "0x1DE9930", Offset = "0x1DE9A31", VA = "0x1DE9930")]
	private MonsterBehaviorController.BehaviorActionParam CreateAroundMoveAction()
	{
		return null;
	}

	// Token: 0x060030B5 RID: 12469 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60028EC")]
	[Address(RVA = "0x1DE9A80", Offset = "0x1DE9B81", VA = "0x1DE9A80")]
	private MonsterBehaviorController.BehaviorActionParam CreateThreateAction()
	{
		return null;
	}

	// Token: 0x060030B6 RID: 12470 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60028ED")]
	[Address(RVA = "0x1DE9BB0", Offset = "0x1DE9CB1", VA = "0x1DE9BB0")]
	private MonsterBehaviorController.BehaviorActionParam CreateThreateAroundMoveAction()
	{
		return null;
	}

	// Token: 0x060030B7 RID: 12471 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60028EE")]
	[Address(RVA = "0x1DE9CE0", Offset = "0x1DE9DE1", VA = "0x1DE9CE0")]
	private MonsterBehaviorController.BehaviorActionParam CreateStompAttackAction()
	{
		return null;
	}

	// Token: 0x060030B8 RID: 12472 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60028EF")]
	[Address(RVA = "0x1DE9E10", Offset = "0x1DE9F11", VA = "0x1DE9E10")]
	private MonsterBehaviorController.BehaviorActionParam CreateServerAttackAction()
	{
		return null;
	}

	// Token: 0x060030B9 RID: 12473 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60028F0")]
	[Address(RVA = "0x1DE9F20", Offset = "0x1DEA021", VA = "0x1DE9F20")]
	private MonsterBehaviorController.BehaviorActionParam CreateMoveServerAttackAction()
	{
		return null;
	}

	// Token: 0x060030BA RID: 12474 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60028F1")]
	[Address(RVA = "0x1DEA090", Offset = "0x1DEA191", VA = "0x1DEA090")]
	private MonsterBehaviorController.BehaviorActionParam CreateRushServerAttackAction()
	{
		return null;
	}

	// Token: 0x060030BB RID: 12475 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60028F2")]
	[Address(RVA = "0x1DEA230", Offset = "0x1DEA331", VA = "0x1DEA230")]
	private MonsterBehaviorController.BehaviorActionParam CreateBreathAttackAction()
	{
		return null;
	}

	// Token: 0x060030BC RID: 12476 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60028F3")]
	[Address(RVA = "0x1DEA360", Offset = "0x1DEA461", VA = "0x1DEA360")]
	private MonsterBehaviorController.BehaviorActionParam CreateHeadAttackAction()
	{
		return null;
	}

	// Token: 0x060030BD RID: 12477 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60028F4")]
	[Address(RVA = "0x1DEA470", Offset = "0x1DEA571", VA = "0x1DEA470", Slot = "10")]
	protected override void OnSetup()
	{
	}

	// Token: 0x060030BE RID: 12478 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60028F5")]
	[Address(RVA = "0x1DEA6E0", Offset = "0x1DEA7E1", VA = "0x1DEA6E0", Slot = "82")]
	public override void SetBossDataAsset(BossDataAssetBase bossData)
	{
	}

	// Token: 0x060030BF RID: 12479 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60028F6")]
	[Address(RVA = "0x1DEA7D0", Offset = "0x1DEA8D1", VA = "0x1DEA7D0", Slot = "88")]
	public override void OnUpdateBossDataBitArray()
	{
	}

	// Token: 0x060030C0 RID: 12480 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60028F7")]
	[Address(RVA = "0x1DEA840", Offset = "0x1DEA941", VA = "0x1DEA840", Slot = "77")]
	public override void EndMonsterAction()
	{
	}

	// Token: 0x060030C1 RID: 12481 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60028F8")]
	[Address(RVA = "0x1DEA930", Offset = "0x1DEAA31", VA = "0x1DEA930", Slot = "57")]
	public override void TakeDamage(bool isDamage, float blowDist, DamageInfo damageInfo, ref DamageResult damageResult)
	{
	}

	// Token: 0x060030C2 RID: 12482 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60028F9")]
	[Address(RVA = "0x1DEAA10", Offset = "0x1DEAB11", VA = "0x1DEAA10", Slot = "69")]
	public override void OnEndAnimEventMadnessState()
	{
	}

	// Token: 0x060030C3 RID: 12483 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60028FA")]
	[Address(RVA = "0x1DEAA20", Offset = "0x1DEAB21", VA = "0x1DEAA20", Slot = "92")]
	protected override void UpdateRestraintBehaviorTiming()
	{
	}

	// Token: 0x060030C4 RID: 12484 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60028FB")]
	[Address(RVA = "0x1DEAB60", Offset = "0x1DEAC61", VA = "0x1DEAB60", Slot = "93")]
	protected override void UpdateReciveItemBehaviorTiming()
	{
	}

	// Token: 0x060030C5 RID: 12485 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60028FC")]
	[Address(RVA = "0x1DEABE0", Offset = "0x1DEACE1", VA = "0x1DEABE0", Slot = "79")]
	public override void OnRestraint()
	{
	}

	// Token: 0x060030C6 RID: 12486 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60028FD")]
	[Address(RVA = "0x1DEABF0", Offset = "0x1DEACF1", VA = "0x1DEABF0", Slot = "9")]
	protected override void Update()
	{
	}

	// Token: 0x060030C7 RID: 12487 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60028FE")]
	[Address(RVA = "0x1DEAC80", Offset = "0x1DEAD81", VA = "0x1DEAC80")]
	public SkullDragonBehaviorController()
	{
	}

	// Token: 0x060030C8 RID: 12488 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60028FF")]
	[Address(RVA = "0x1DEACA0", Offset = "0x1DEADA1", VA = "0x1DEACA0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A43E0", Offset = "0x1A44E1")]
	private void <CreateAroundMoveAction>b__22_0()
	{
	}

	// Token: 0x060030C9 RID: 12489 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002900")]
	[Address(RVA = "0x1DEAD00", Offset = "0x1DEAE01", VA = "0x1DEAD00")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A43F0", Offset = "0x1A44F1")]
	private void <CreateAroundMoveAction>b__22_1(int index, int type)
	{
	}

	// Token: 0x060030CA RID: 12490 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002901")]
	[Address(RVA = "0x1DEAEF0", Offset = "0x1DEAFF1", VA = "0x1DEAEF0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A4400", Offset = "0x1A4501")]
	private void <CreateThreateAction>b__23_0()
	{
	}

	// Token: 0x060030CB RID: 12491 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002902")]
	[Address(RVA = "0x1DEAFA0", Offset = "0x1DEB0A1", VA = "0x1DEAFA0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A4410", Offset = "0x1A4511")]
	private void <CreateThreateAroundMoveAction>b__24_0()
	{
	}

	// Token: 0x060030CC RID: 12492 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002903")]
	[Address(RVA = "0x1DEB050", Offset = "0x1DEB151", VA = "0x1DEB050")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A4420", Offset = "0x1A4521")]
	private void <CreateStompAttackAction>b__25_0()
	{
	}

	// Token: 0x060030CD RID: 12493 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002904")]
	[Address(RVA = "0x1DEB0C0", Offset = "0x1DEB1C1", VA = "0x1DEB0C0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A4430", Offset = "0x1A4531")]
	private void <CreateServerAttackAction>b__26_0()
	{
	}

	// Token: 0x060030CE RID: 12494 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002905")]
	[Address(RVA = "0x1DEB110", Offset = "0x1DEB211", VA = "0x1DEB110")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A4440", Offset = "0x1A4541")]
	private void <CreateMoveServerAttackAction>b__27_0()
	{
	}

	// Token: 0x060030CF RID: 12495 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002906")]
	[Address(RVA = "0x1DEB160", Offset = "0x1DEB261", VA = "0x1DEB160")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A4450", Offset = "0x1A4551")]
	private void <CreateMoveServerAttackAction>b__27_1(int index, int type)
	{
	}

	// Token: 0x060030D0 RID: 12496 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002907")]
	[Address(RVA = "0x1DEB220", Offset = "0x1DEB321", VA = "0x1DEB220")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A4460", Offset = "0x1A4561")]
	private void <CreateRushServerAttackAction>b__28_0()
	{
	}

	// Token: 0x060030D1 RID: 12497 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002908")]
	[Address(RVA = "0x1DEB350", Offset = "0x1DEB451", VA = "0x1DEB350")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A4470", Offset = "0x1A4571")]
	private void <CreateRushServerAttackAction>b__28_1(int index, int type)
	{
	}

	// Token: 0x060030D2 RID: 12498 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002909")]
	[Address(RVA = "0x1DEB410", Offset = "0x1DEB511", VA = "0x1DEB410")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A4480", Offset = "0x1A4581")]
	private void <CreateRushServerAttackAction>b__28_2()
	{
	}

	// Token: 0x060030D3 RID: 12499 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600290A")]
	[Address(RVA = "0x1DEB470", Offset = "0x1DEB571", VA = "0x1DEB470")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A4490", Offset = "0x1A4591")]
	private void <CreateBreathAttackAction>b__29_0()
	{
	}

	// Token: 0x060030D4 RID: 12500 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600290B")]
	[Address(RVA = "0x1DEB500", Offset = "0x1DEB601", VA = "0x1DEB500")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A44A0", Offset = "0x1A45A1")]
	private void <CreateHeadAttackAction>b__30_0()
	{
	}

	// Token: 0x040075E5 RID: 30181
	[Token(Token = "0x4006C0C")]
	[FieldOffset(Offset = "0x1C0")]
	private float LoopTimer;

	// Token: 0x040075E6 RID: 30182
	[Token(Token = "0x4006C0D")]
	[FieldOffset(Offset = "0x1C4")]
	private float WaitAngerTime;

	// Token: 0x040075E7 RID: 30183
	[Token(Token = "0x4006C0E")]
	[FieldOffset(Offset = "0x1C8")]
	private float FireBreathTimer;

	// Token: 0x040075E8 RID: 30184
	[Token(Token = "0x4006C0F")]
	[FieldOffset(Offset = "0x1CC")]
	private float FireBreathTime;

	// Token: 0x040075E9 RID: 30185
	[Token(Token = "0x4006C10")]
	[FieldOffset(Offset = "0x1D0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x169920", Offset = "0x169A21")]
	private bool <IsRedyFireBreath>k__BackingField;

	// Token: 0x040075EA RID: 30186
	[Token(Token = "0x4006C11")]
	[FieldOffset(Offset = "0x1D4")]
	private float MaxHP;

	// Token: 0x040075EB RID: 30187
	[Token(Token = "0x4006C12")]
	[FieldOffset(Offset = "0x1D8")]
	private float MaxTailDamageHPPercent;

	// Token: 0x040075EC RID: 30188
	[Token(Token = "0x4006C13")]
	[FieldOffset(Offset = "0x1DC")]
	private float TailTotalDamage;

	// Token: 0x040075ED RID: 30189
	[Token(Token = "0x4006C14")]
	[FieldOffset(Offset = "0x1E0")]
	private SkullDragonController _SkullDragonController;

	// Token: 0x040075EE RID: 30190
	[Token(Token = "0x4006C15")]
	[FieldOffset(Offset = "0x1E8")]
	private int BehaviorSkipCount;

	// Token: 0x040075EF RID: 30191
	[Token(Token = "0x4006C16")]
	[FieldOffset(Offset = "0x1EC")]
	private bool _IsFilledTailDamage;

	// Token: 0x02000764 RID: 1892
	[Token(Token = "0x20011D5")]
	private enum StateType
	{
		// Token: 0x040075F1 RID: 30193
		[Token(Token = "0x4019643")]
		Anger
	}
}
