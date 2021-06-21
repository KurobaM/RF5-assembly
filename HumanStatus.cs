using System;
using Define;
using Il2CppDummyDll;

// Token: 0x020008A7 RID: 2215
[Token(Token = "0x20005BD")]
public class HumanStatus : CharacterStatusBase
{
	// Token: 0x1700084B RID: 2123
	// (get) Token: 0x06003A9C RID: 15004 RVA: 0x000146E8 File Offset: 0x000128E8
	[Token(Token = "0x17000690")]
	public override Alliance Alliance
	{
		[Token(Token = "0x600310A")]
		[Address(RVA = "0x2228520", Offset = "0x2228621", VA = "0x2228520", Slot = "6")]
		get
		{
			return Alliance.None;
		}
	}

	// Token: 0x1700084C RID: 2124
	// (get) Token: 0x06003A9D RID: 15005 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000691")]
	public override Character Owner
	{
		[Token(Token = "0x600310B")]
		[Address(RVA = "0x2228530", Offset = "0x2228631", VA = "0x2228530", Slot = "4")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700084D RID: 2125
	// (get) Token: 0x06003A9E RID: 15006 RVA: 0x00014700 File Offset: 0x00012900
	// (set) Token: 0x06003A9F RID: 15007 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000692")]
	public ActorID ActorID
	{
		[Token(Token = "0x600310C")]
		[Address(RVA = "0x22285E0", Offset = "0x22286E1", VA = "0x22285E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A62C0", Offset = "0x1A63C1")]
		get
		{
			return ActorID.act000;
		}
		[Token(Token = "0x600310D")]
		[Address(RVA = "0x22285F0", Offset = "0x22286F1", VA = "0x22285F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A62D0", Offset = "0x1A63D1")]
		private set
		{
		}
	}

	// Token: 0x1700084E RID: 2126
	// (get) Token: 0x06003AA0 RID: 15008 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000693")]
	public HumanStatusData HumanStatusData
	{
		[Token(Token = "0x600310E")]
		[Address(RVA = "0x2228600", Offset = "0x2228701", VA = "0x2228600")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700084F RID: 2127
	// (get) Token: 0x06003AA1 RID: 15009 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000694")]
	public override HumanEquip EquipItem
	{
		[Token(Token = "0x600310F")]
		[Address(RVA = "0x22286A0", Offset = "0x22287A1", VA = "0x22286A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000850 RID: 2128
	// (get) Token: 0x06003AA2 RID: 15010 RVA: 0x00014718 File Offset: 0x00012918
	[Token(Token = "0x17000695")]
	protected override float PoisonDamagePercent
	{
		[Token(Token = "0x6003110")]
		[Address(RVA = "0x2228730", Offset = "0x2228831", VA = "0x2228730", Slot = "16")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06003AA3 RID: 15011 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003111")]
	[Address(RVA = "0x2228740", Offset = "0x2228841", VA = "0x2228740")]
	public HumanStatus(ActorID actor_id)
	{
	}

	// Token: 0x06003AA4 RID: 15012 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003112")]
	[Address(RVA = "0x2228940", Offset = "0x2228A41", VA = "0x2228940", Slot = "13")]
	protected override CharaParamDataTable GetCharaParam()
	{
		return null;
	}

	// Token: 0x06003AA5 RID: 15013 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003113")]
	[Address(RVA = "0x2228970", Offset = "0x2228A71", VA = "0x2228970", Slot = "20")]
	protected override void LevelUp()
	{
	}

	// Token: 0x06003AA6 RID: 15014 RVA: 0x00014730 File Offset: 0x00012930
	[Token(Token = "0x6003114")]
	[Address(RVA = "0x2228A50", Offset = "0x2228B51", VA = "0x2228A50", Slot = "22")]
	public virtual int GetSkillLevel(SkillID skill)
	{
		return 0;
	}

	// Token: 0x06003AA7 RID: 15015 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003115")]
	[Address(RVA = "0x2228AB0", Offset = "0x2228BB1", VA = "0x2228AB0", Slot = "23")]
	public virtual void DoActionRpExp(SkillActionID skillAction, int level = 1)
	{
	}

	// Token: 0x06003AA8 RID: 15016 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003116")]
	[Address(RVA = "0x2228AC0", Offset = "0x2228BC1", VA = "0x2228AC0", Slot = "24")]
	public virtual void DoActionExp(SkillActionID skillAction)
	{
	}

	// Token: 0x06003AA9 RID: 15017 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003117")]
	[Address(RVA = "0x2228AD0", Offset = "0x2228BD1", VA = "0x2228AD0", Slot = "25")]
	public virtual void DoActionRp(SkillActionID skillAction, int level = 1)
	{
	}

	// Token: 0x17000851 RID: 2129
	// (get) Token: 0x06003AAA RID: 15018 RVA: 0x00014748 File Offset: 0x00012948
	// (set) Token: 0x06003AAB RID: 15019 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000696")]
	public virtual float DualSkillGauge
	{
		[Token(Token = "0x6003118")]
		[Address(RVA = "0x2228AE0", Offset = "0x2228BE1", VA = "0x2228AE0", Slot = "26")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6003119")]
		[Address(RVA = "0x2228B70", Offset = "0x2228C71", VA = "0x2228B70", Slot = "27")]
		set
		{
		}
	}

	// Token: 0x17000852 RID: 2130
	// (get) Token: 0x06003AAC RID: 15020 RVA: 0x00014760 File Offset: 0x00012960
	[Token(Token = "0x17000697")]
	public bool IsGaugeMax
	{
		[Token(Token = "0x600311A")]
		[Address(RVA = "0x2228C00", Offset = "0x2228D01", VA = "0x2228C00")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000853 RID: 2131
	// (get) Token: 0x06003AAD RID: 15021 RVA: 0x00014778 File Offset: 0x00012978
	[Token(Token = "0x17000698")]
	public bool CanDualSkill
	{
		[Token(Token = "0x600311B")]
		[Address(RVA = "0x2228C30", Offset = "0x2228D31", VA = "0x2228C30")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06003AAE RID: 15022 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600311C")]
	[Address(RVA = "0x2228CB0", Offset = "0x2228DB1", VA = "0x2228CB0")]
	public void ClearDualSkillGauge()
	{
	}

	// Token: 0x06003AAF RID: 15023 RVA: 0x00014790 File Offset: 0x00012990
	[Token(Token = "0x600311D")]
	[Address(RVA = "0x2228CD0", Offset = "0x2228DD1", VA = "0x2228CD0", Slot = "19")]
	public override DamageInfo CreateMagicDamageInfo(MagicParamDataTable dataTable, int level)
	{
		return default(DamageInfo);
	}

	// Token: 0x06003AB0 RID: 15024 RVA: 0x000147A8 File Offset: 0x000129A8
	[Token(Token = "0x600311E")]
	[Address(RVA = "0x2229560", Offset = "0x2229661", VA = "0x2229560", Slot = "11")]
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult damageResult)
	{
		return default(bool);
	}

	// Token: 0x06003AB1 RID: 15025 RVA: 0x000147C0 File Offset: 0x000129C0
	[Token(Token = "0x600311F")]
	[Address(RVA = "0x2229620", Offset = "0x2229721", VA = "0x2229620")]
	public DamageInfo CreateObjThrowDamage()
	{
		return default(DamageInfo);
	}

	// Token: 0x06003AB2 RID: 15026 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003120")]
	[Address(RVA = "0x2229770", Offset = "0x2229871", VA = "0x2229770", Slot = "28")]
	public virtual void AddDualSkillGauge(DualSkillGaugeUpType dualSkillGaugeUpType)
	{
	}

	// Token: 0x04007D9E RID: 32158
	[Token(Token = "0x4007190")]
	[FieldOffset(Offset = "0x21C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E570", Offset = "0x16E671")]
	private ActorID <ActorID>k__BackingField;
}
