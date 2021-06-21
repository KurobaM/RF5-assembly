using System;
using Define;
using Il2CppDummyDll;

// Token: 0x020008AB RID: 2219
[Token(Token = "0x20005C1")]
public class PlayerStatus : HumanStatus
{
	// Token: 0x1700085E RID: 2142
	// (get) Token: 0x06003ACD RID: 15053 RVA: 0x000148B0 File Offset: 0x00012AB0
	// (set) Token: 0x06003ACE RID: 15054 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006A3")]
	private float CurrentTimer_AutoRPHeal
	{
		[Token(Token = "0x600313B")]
		[Address(RVA = "0x24993F0", Offset = "0x24994F1", VA = "0x24993F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6340", Offset = "0x1A6441")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600313C")]
		[Address(RVA = "0x2499400", Offset = "0x2499501", VA = "0x2499400")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6350", Offset = "0x1A6451")]
		set
		{
		}
	}

	// Token: 0x1700085F RID: 2143
	// (get) Token: 0x06003ACF RID: 15055 RVA: 0x000148C8 File Offset: 0x00012AC8
	// (set) Token: 0x06003AD0 RID: 15056 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006A4")]
	public bool IsAutoRPHeal
	{
		[Token(Token = "0x600313D")]
		[Address(RVA = "0x2499410", Offset = "0x2499511", VA = "0x2499410")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6360", Offset = "0x1A6461")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600313E")]
		[Address(RVA = "0x2499420", Offset = "0x2499521", VA = "0x2499420")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6370", Offset = "0x1A6471")]
		set
		{
		}
	}

	// Token: 0x06003AD1 RID: 15057 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600313F")]
	[Address(RVA = "0x2499430", Offset = "0x2499531", VA = "0x2499430")]
	public PlayerStatus(ActorID actor_id)
	{
	}

	// Token: 0x17000860 RID: 2144
	// (get) Token: 0x06003AD2 RID: 15058 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170006A5")]
	public override Character Owner
	{
		[Token(Token = "0x6003140")]
		[Address(RVA = "0x2499440", Offset = "0x2499541", VA = "0x2499440", Slot = "4")]
		get
		{
			return null;
		}
	}

	// Token: 0x06003AD3 RID: 15059 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003141")]
	[Address(RVA = "0x24994F0", Offset = "0x24995F1", VA = "0x24994F0", Slot = "20")]
	protected override void LevelUp()
	{
	}

	// Token: 0x06003AD4 RID: 15060 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003142")]
	[Address(RVA = "0x2499620", Offset = "0x2499721", VA = "0x2499620", Slot = "21")]
	protected override void LevelDown()
	{
	}

	// Token: 0x06003AD5 RID: 15061 RVA: 0x000148E0 File Offset: 0x00012AE0
	[Token(Token = "0x6003143")]
	[Address(RVA = "0x2499710", Offset = "0x2499811", VA = "0x2499710", Slot = "22")]
	public override int GetSkillLevel(SkillID skill)
	{
		return 0;
	}

	// Token: 0x06003AD6 RID: 15062 RVA: 0x000148F8 File Offset: 0x00012AF8
	[Token(Token = "0x6003144")]
	[Address(RVA = "0x2499720", Offset = "0x2499821", VA = "0x2499720", Slot = "11")]
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult damageResult)
	{
		return default(bool);
	}

	// Token: 0x06003AD7 RID: 15063 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003145")]
	[Address(RVA = "0x24999E0", Offset = "0x2499AE1", VA = "0x24999E0", Slot = "23")]
	public override void DoActionRpExp(SkillActionID skillAction, int level = 1)
	{
	}

	// Token: 0x06003AD8 RID: 15064 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003146")]
	[Address(RVA = "0x24999F0", Offset = "0x2499AF1", VA = "0x24999F0", Slot = "24")]
	public override void DoActionExp(SkillActionID skillAction)
	{
	}

	// Token: 0x06003AD9 RID: 15065 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003147")]
	[Address(RVA = "0x2499A00", Offset = "0x2499B01", VA = "0x2499A00", Slot = "25")]
	public override void DoActionRp(SkillActionID skillAction, int level = 1)
	{
	}

	// Token: 0x06003ADA RID: 15066 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003148")]
	[Address(RVA = "0x2499A10", Offset = "0x2499B11", VA = "0x2499A10")]
	public void UpdateAutoRPHeal(float deltaTime)
	{
	}

	// Token: 0x06003ADB RID: 15067 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003149")]
	[Address(RVA = "0x2499BA0", Offset = "0x2499CA1", VA = "0x2499BA0", Slot = "28")]
	public override void AddDualSkillGauge(DualSkillGaugeUpType dualSkillGaugeUpType)
	{
	}

	// Token: 0x04007DA5 RID: 32165
	[Token(Token = "0x4007197")]
	[FieldOffset(Offset = "0x220")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E5B0", Offset = "0x16E6B1")]
	private float <CurrentTimer_AutoRPHeal>k__BackingField;

	// Token: 0x04007DA6 RID: 32166
	[Token(Token = "0x4007198")]
	[FieldOffset(Offset = "0x224")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E5C0", Offset = "0x16E6C1")]
	private bool <IsAutoRPHeal>k__BackingField;
}
