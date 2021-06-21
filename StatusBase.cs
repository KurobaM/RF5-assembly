using System;
using Define;
using Il2CppDummyDll;
using UnityEngine.Events;

// Token: 0x020008AC RID: 2220
[Token(Token = "0x20005C2")]
public abstract class StatusBase
{
	// Token: 0x17000861 RID: 2145
	// (get) Token: 0x06003ADC RID: 15068 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003ADD RID: 15069 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006A6")]
	public virtual Character Owner
	{
		[Token(Token = "0x600314A")]
		[Address(RVA = "0x23896D0", Offset = "0x23897D1", VA = "0x23896D0", Slot = "4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6380", Offset = "0x1A6481")]
		get
		{
			return null;
		}
		[Token(Token = "0x600314B")]
		[Address(RVA = "0x23896E0", Offset = "0x23897E1", VA = "0x23896E0", Slot = "5")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6390", Offset = "0x1A6491")]
		protected set
		{
		}
	}

	// Token: 0x17000862 RID: 2146
	// (get) Token: 0x06003ADE RID: 15070
	[Token(Token = "0x170006A7")]
	public abstract Alliance Alliance { [Token(Token = "0x600314C")] get; }

	// Token: 0x17000863 RID: 2147
	// (get) Token: 0x06003ADF RID: 15071 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170006A8")]
	public virtual HumanEquip EquipItem
	{
		[Token(Token = "0x600314D")]
		[Address(RVA = "0x23896F0", Offset = "0x23897F1", VA = "0x23896F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000864 RID: 2148
	// (get) Token: 0x06003AE0 RID: 15072
	// (set) Token: 0x06003AE1 RID: 15073
	[Token(Token = "0x170006A9")]
	public abstract int Hp { [Token(Token = "0x600314E")] get; [Token(Token = "0x600314F")] set; }

	// Token: 0x17000865 RID: 2149
	// (get) Token: 0x06003AE2 RID: 15074 RVA: 0x00014910 File Offset: 0x00012B10
	[Token(Token = "0x170006AA")]
	public bool IsDead
	{
		[Token(Token = "0x6003150")]
		[Address(RVA = "0x2389700", Offset = "0x2389801", VA = "0x2389700")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000866 RID: 2150
	// (get) Token: 0x06003AE3 RID: 15075 RVA: 0x00014928 File Offset: 0x00012B28
	[Token(Token = "0x170006AB")]
	public bool IsSuperArmor
	{
		[Token(Token = "0x6003151")]
		[Address(RVA = "0x2389730", Offset = "0x2389831", VA = "0x2389730")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000867 RID: 2151
	// (get) Token: 0x06003AE4 RID: 15076 RVA: 0x00014940 File Offset: 0x00012B40
	// (set) Token: 0x06003AE5 RID: 15077 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006AC")]
	public float DamageRate
	{
		[Token(Token = "0x6003152")]
		[Address(RVA = "0x23897F0", Offset = "0x23898F1", VA = "0x23897F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A63A0", Offset = "0x1A64A1")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6003153")]
		[Address(RVA = "0x2389800", Offset = "0x2389901", VA = "0x2389800")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A63B0", Offset = "0x1A64B1")]
		set
		{
		}
	}

	// Token: 0x17000868 RID: 2152
	// (get) Token: 0x06003AE6 RID: 15078 RVA: 0x00014958 File Offset: 0x00012B58
	// (set) Token: 0x06003AE7 RID: 15079 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006AD")]
	public bool IsNotDeath
	{
		[Token(Token = "0x6003154")]
		[Address(RVA = "0x2389810", Offset = "0x2389911", VA = "0x2389810")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A63C0", Offset = "0x1A64C1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003155")]
		[Address(RVA = "0x2389820", Offset = "0x2389921", VA = "0x2389820")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A63D0", Offset = "0x1A64D1")]
		set
		{
		}
	}

	// Token: 0x17000869 RID: 2153
	// (get) Token: 0x06003AE8 RID: 15080 RVA: 0x00014970 File Offset: 0x00012B70
	[Token(Token = "0x170006AE")]
	public int CurrentAttack
	{
		[Token(Token = "0x6003156")]
		[Address(RVA = "0x2389830", Offset = "0x2389931", VA = "0x2389830")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700086A RID: 2154
	// (get) Token: 0x06003AE9 RID: 15081 RVA: 0x00014988 File Offset: 0x00012B88
	[Token(Token = "0x170006AF")]
	public int CurrentMagicAttack
	{
		[Token(Token = "0x6003157")]
		[Address(RVA = "0x23898D0", Offset = "0x23899D1", VA = "0x23898D0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x06003AEA RID: 15082 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003158")]
	[Address(RVA = "0x2389970", Offset = "0x2389A71", VA = "0x2389970", Slot = "10")]
	public virtual void Renew()
	{
	}

	// Token: 0x06003AEB RID: 15083 RVA: 0x000149A0 File Offset: 0x00012BA0
	[Token(Token = "0x6003159")]
	[Address(RVA = "0x2389B70", Offset = "0x2389C71", VA = "0x2389B70", Slot = "11")]
	public virtual bool TakeDamage(DamageInfo damageInfo, out DamageResult damageResult)
	{
		return default(bool);
	}

	// Token: 0x06003AEC RID: 15084 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600315A")]
	[Address(RVA = "0x238A7C0", Offset = "0x238A8C1", VA = "0x238A7C0")]
	private void DispDamageText(DamageInfo damageInfo, DamageResult damageResult)
	{
	}

	// Token: 0x06003AED RID: 15085 RVA: 0x000149B8 File Offset: 0x00012BB8
	[Token(Token = "0x600315B")]
	[Address(RVA = "0x238A720", Offset = "0x238A821", VA = "0x238A720")]
	public bool IsPartyMonster()
	{
		return default(bool);
	}

	// Token: 0x06003AEE RID: 15086 RVA: 0x000149D0 File Offset: 0x00012BD0
	[Token(Token = "0x600315C")]
	[Address(RVA = "0x238A630", Offset = "0x238A731", VA = "0x238A630")]
	public static bool IsParty(ActorID actorID)
	{
		return default(bool);
	}

	// Token: 0x06003AEF RID: 15087 RVA: 0x000149E8 File Offset: 0x00012BE8
	[Token(Token = "0x600315D")]
	[Address(RVA = "0x238A610", Offset = "0x238A711", VA = "0x238A610")]
	public static bool IsFamily(ActorID actorID)
	{
		return default(bool);
	}

	// Token: 0x06003AF0 RID: 15088 RVA: 0x00014A00 File Offset: 0x00012C00
	[Token(Token = "0x600315E")]
	[Address(RVA = "0x238A960", Offset = "0x238AA61", VA = "0x238A960")]
	private static bool IsMarried(ActorID actorID)
	{
		return default(bool);
	}

	// Token: 0x06003AF1 RID: 15089
	[Token(Token = "0x600315F")]
	public abstract ValueTuple<Parameter, EquipSubAttributeCollection> CalcCurrentParameter(HumanEquip humanEquip, bool isWeapon);

	// Token: 0x1700086B RID: 2155
	// (get) Token: 0x06003AF2 RID: 15090 RVA: 0x00014A18 File Offset: 0x00012C18
	[Token(Token = "0x170006B0")]
	public int MaxHp
	{
		[Token(Token = "0x6003160")]
		[Address(RVA = "0x2389AC0", Offset = "0x2389BC1", VA = "0x2389AC0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700086C RID: 2156
	// (get) Token: 0x06003AF3 RID: 15091 RVA: 0x00014A30 File Offset: 0x00012C30
	[Token(Token = "0x170006B1")]
	public int MaxRp
	{
		[Token(Token = "0x6003161")]
		[Address(RVA = "0x238AA30", Offset = "0x238AB31", VA = "0x238AA30")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700086D RID: 2157
	// (get) Token: 0x06003AF4 RID: 15092 RVA: 0x00014A48 File Offset: 0x00012C48
	[Token(Token = "0x170006B2")]
	public int Attack
	{
		[Token(Token = "0x6003162")]
		[Address(RVA = "0x238AA40", Offset = "0x238AB41", VA = "0x238AA40")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700086E RID: 2158
	// (get) Token: 0x06003AF5 RID: 15093 RVA: 0x00014A60 File Offset: 0x00012C60
	[Token(Token = "0x170006B3")]
	public int Defense
	{
		[Token(Token = "0x6003163")]
		[Address(RVA = "0x238AA50", Offset = "0x238AB51", VA = "0x238AA50")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700086F RID: 2159
	// (get) Token: 0x06003AF6 RID: 15094 RVA: 0x00014A78 File Offset: 0x00012C78
	[Token(Token = "0x170006B4")]
	public int MagicAttack
	{
		[Token(Token = "0x6003164")]
		[Address(RVA = "0x238AA60", Offset = "0x238AB61", VA = "0x238AA60")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000870 RID: 2160
	// (get) Token: 0x06003AF7 RID: 15095 RVA: 0x00014A90 File Offset: 0x00012C90
	[Token(Token = "0x170006B5")]
	public int MagicDefense
	{
		[Token(Token = "0x6003165")]
		[Address(RVA = "0x238AA70", Offset = "0x238AB71", VA = "0x238AA70")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000871 RID: 2161
	// (get) Token: 0x06003AF8 RID: 15096 RVA: 0x00014AA8 File Offset: 0x00012CA8
	[Token(Token = "0x170006B6")]
	public int Strength
	{
		[Token(Token = "0x6003166")]
		[Address(RVA = "0x238AA80", Offset = "0x238AB81", VA = "0x238AA80")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000872 RID: 2162
	// (get) Token: 0x06003AF9 RID: 15097 RVA: 0x00014AC0 File Offset: 0x00012CC0
	[Token(Token = "0x170006B7")]
	public int Intelligence
	{
		[Token(Token = "0x6003167")]
		[Address(RVA = "0x238AA90", Offset = "0x238AB91", VA = "0x238AA90")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000873 RID: 2163
	// (get) Token: 0x06003AFA RID: 15098 RVA: 0x00014AD8 File Offset: 0x00012CD8
	[Token(Token = "0x170006B8")]
	public int Vitality
	{
		[Token(Token = "0x6003168")]
		[Address(RVA = "0x238AAA0", Offset = "0x238ABA1", VA = "0x238AAA0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000874 RID: 2164
	// (get) Token: 0x06003AFB RID: 15099 RVA: 0x00014AF0 File Offset: 0x00012CF0
	[Token(Token = "0x170006B9")]
	public float HPPercent
	{
		[Token(Token = "0x6003169")]
		[Address(RVA = "0x238AAB0", Offset = "0x238ABB1", VA = "0x238AAB0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06003AFC RID: 15100 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600316A")]
	[Address(RVA = "0x238AB50", Offset = "0x238AC51", VA = "0x238AB50")]
	protected StatusBase()
	{
	}

	// Token: 0x04007DA7 RID: 32167
	[Token(Token = "0x4007199")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E5D0", Offset = "0x16E6D1")]
	private Character <Owner>k__BackingField;

	// Token: 0x04007DA8 RID: 32168
	[Token(Token = "0x400719A")]
	[FieldOffset(Offset = "0x18")]
	public Parameter CurrentParameter;

	// Token: 0x04007DA9 RID: 32169
	[Token(Token = "0x400719B")]
	[FieldOffset(Offset = "0xD8")]
	public EquipSubAttributeCollection SubAttributes;

	// Token: 0x04007DAA RID: 32170
	[Token(Token = "0x400719C")]
	[FieldOffset(Offset = "0xE0")]
	public UnityEvent OnDead;

	// Token: 0x04007DAB RID: 32171
	[Token(Token = "0x400719D")]
	[FieldOffset(Offset = "0xE8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E5E0", Offset = "0x16E6E1")]
	private float <DamageRate>k__BackingField;

	// Token: 0x04007DAC RID: 32172
	[Token(Token = "0x400719E")]
	[FieldOffset(Offset = "0xEC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E5F0", Offset = "0x16E6F1")]
	private bool <IsNotDeath>k__BackingField;
}
