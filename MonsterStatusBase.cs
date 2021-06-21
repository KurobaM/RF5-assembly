using System;
using Il2CppDummyDll;

// Token: 0x020008AA RID: 2218
[Token(Token = "0x20005C0")]
public abstract class MonsterStatusBase : CharacterStatusBase
{
	// Token: 0x17000856 RID: 2134
	// (get) Token: 0x06003ABB RID: 15035
	// (set) Token: 0x06003ABC RID: 15036
	[Token(Token = "0x1700069B")]
	public abstract int BrushCount { [Token(Token = "0x6003129")] get; [Token(Token = "0x600312A")] set; }

	// Token: 0x17000857 RID: 2135
	// (get) Token: 0x06003ABD RID: 15037
	// (set) Token: 0x06003ABE RID: 15038
	[Token(Token = "0x1700069C")]
	public abstract int PresentCount { [Token(Token = "0x600312B")] get; [Token(Token = "0x600312C")] set; }

	// Token: 0x17000858 RID: 2136
	// (get) Token: 0x06003ABF RID: 15039
	[Token(Token = "0x1700069D")]
	public abstract string Name { [Token(Token = "0x600312D")] get; }

	// Token: 0x17000859 RID: 2137
	// (get) Token: 0x06003AC0 RID: 15040
	[Token(Token = "0x1700069E")]
	public abstract MonsterDataID MonsterDataID { [Token(Token = "0x600312E")] get; }

	// Token: 0x06003AC1 RID: 15041 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600312F")]
	[Address(RVA = "0x1E724D0", Offset = "0x1E725D1", VA = "0x1E724D0", Slot = "13")]
	protected override CharaParamDataTable GetCharaParam()
	{
		return null;
	}

	// Token: 0x1700085A RID: 2138
	// (get) Token: 0x06003AC2 RID: 15042 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700069F")]
	public override Character Owner
	{
		[Token(Token = "0x6003130")]
		[Address(RVA = "0x1E72510", Offset = "0x1E72611", VA = "0x1E72510", Slot = "4")]
		get
		{
			return null;
		}
	}

	// Token: 0x06003AC3 RID: 15043 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003131")]
	[Address(RVA = "0x1E72520", Offset = "0x1E72621", VA = "0x1E72520")]
	public void SetOwner(Character owner)
	{
	}

	// Token: 0x06003AC4 RID: 15044 RVA: 0x00014838 File Offset: 0x00012A38
	[Token(Token = "0x6003132")]
	[Address(RVA = "0x1E72530", Offset = "0x1E72631", VA = "0x1E72530", Slot = "19")]
	public override DamageInfo CreateMagicDamageInfo(MagicParamDataTable dataTable, int level)
	{
		return default(DamageInfo);
	}

	// Token: 0x1700085B RID: 2139
	// (get) Token: 0x06003AC5 RID: 15045 RVA: 0x00014850 File Offset: 0x00012A50
	// (set) Token: 0x06003AC6 RID: 15046 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006A0")]
	public float RestraintCounter
	{
		[Token(Token = "0x6003133")]
		[Address(RVA = "0x1E72970", Offset = "0x1E72A71", VA = "0x1E72970")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6300", Offset = "0x1A6401")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6003134")]
		[Address(RVA = "0x1E72980", Offset = "0x1E72A81", VA = "0x1E72980")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6310", Offset = "0x1A6411")]
		private set
		{
		}
	}

	// Token: 0x1700085C RID: 2140
	// (get) Token: 0x06003AC7 RID: 15047 RVA: 0x00014868 File Offset: 0x00012A68
	// (set) Token: 0x06003AC8 RID: 15048 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006A1")]
	public float RestraintReleseTimer
	{
		[Token(Token = "0x6003135")]
		[Address(RVA = "0x1E72990", Offset = "0x1E72A91", VA = "0x1E72990")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6320", Offset = "0x1A6421")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6003136")]
		[Address(RVA = "0x1E729A0", Offset = "0x1E72AA1", VA = "0x1E729A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6330", Offset = "0x1A6431")]
		private set
		{
		}
	}

	// Token: 0x1700085D RID: 2141
	// (get) Token: 0x06003AC9 RID: 15049 RVA: 0x00014880 File Offset: 0x00012A80
	[Token(Token = "0x170006A2")]
	public bool IsRestraint
	{
		[Token(Token = "0x6003137")]
		[Address(RVA = "0x1E6FE20", Offset = "0x1E6FF21", VA = "0x1E6FE20")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06003ACA RID: 15050 RVA: 0x00014898 File Offset: 0x00012A98
	[Token(Token = "0x6003138")]
	[Address(RVA = "0x1E729B0", Offset = "0x1E72AB1", VA = "0x1E729B0")]
	public bool TakeRestraintDamage(float damage)
	{
		return default(bool);
	}

	// Token: 0x06003ACB RID: 15051 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003139")]
	[Address(RVA = "0x1E72AA0", Offset = "0x1E72BA1", VA = "0x1E72AA0", Slot = "15")]
	public override void UpdateStatus()
	{
	}

	// Token: 0x06003ACC RID: 15052 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600313A")]
	[Address(RVA = "0x1E72BE0", Offset = "0x1E72CE1", VA = "0x1E72BE0")]
	protected MonsterStatusBase()
	{
	}

	// Token: 0x04007DA2 RID: 32162
	[Token(Token = "0x4007194")]
	[FieldOffset(Offset = "0x220")]
	public Character _Owner;

	// Token: 0x04007DA3 RID: 32163
	[Token(Token = "0x4007195")]
	[FieldOffset(Offset = "0x228")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E590", Offset = "0x16E691")]
	private float <RestraintCounter>k__BackingField;

	// Token: 0x04007DA4 RID: 32164
	[Token(Token = "0x4007196")]
	[FieldOffset(Offset = "0x22C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E5A0", Offset = "0x16E6A1")]
	private float <RestraintReleseTimer>k__BackingField;
}
