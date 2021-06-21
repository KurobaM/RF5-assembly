using System;
using DataTable;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000393 RID: 915
[Token(Token = "0x20002BB")]
[Serializable]
public class MagicParamDataTable
{
	// Token: 0x06001710 RID: 5904 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600147C")]
	[Address(RVA = "0x1F14440", Offset = "0x1F14541", VA = "0x1F14440")]
	public static MagicParamDataTable GetDataTable(MagicParamID magicParamID)
	{
		return null;
	}

	// Token: 0x06001711 RID: 5905 RVA: 0x0000A278 File Offset: 0x00008478
	[Token(Token = "0x600147D")]
	[Address(RVA = "0x1F145E0", Offset = "0x1F146E1", VA = "0x1F145E0")]
	public static bool HasDataTable(MagicParamID magicParamID)
	{
		return default(bool);
	}

	// Token: 0x06001712 RID: 5906 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600147E")]
	[Address(RVA = "0x1F145D0", Offset = "0x1F146D1", VA = "0x1F145D0")]
	public MagicParamDataTable()
	{
	}

	// Token: 0x0400100E RID: 4110
	[Token(Token = "0x4000CC2")]
	[FieldOffset(Offset = "0x10")]
	public float Attribute_Fire;

	// Token: 0x0400100F RID: 4111
	[Token(Token = "0x4000CC3")]
	[FieldOffset(Offset = "0x14")]
	public float Attribute_Water;

	// Token: 0x04001010 RID: 4112
	[Token(Token = "0x4000CC4")]
	[FieldOffset(Offset = "0x18")]
	public float Attribute_Earth;

	// Token: 0x04001011 RID: 4113
	[Token(Token = "0x4000CC5")]
	[FieldOffset(Offset = "0x1C")]
	public float Attribute_Wind;

	// Token: 0x04001012 RID: 4114
	[Token(Token = "0x4000CC6")]
	[FieldOffset(Offset = "0x20")]
	public float Attribute_Shine;

	// Token: 0x04001013 RID: 4115
	[Token(Token = "0x4000CC7")]
	[FieldOffset(Offset = "0x24")]
	public float Attribute_Dark;

	// Token: 0x04001014 RID: 4116
	[Token(Token = "0x4000CC8")]
	[FieldOffset(Offset = "0x28")]
	public float Attribute_Love;

	// Token: 0x04001015 RID: 4117
	[Token(Token = "0x4000CC9")]
	[FieldOffset(Offset = "0x2C")]
	public AttackType AttackType;

	// Token: 0x04001016 RID: 4118
	[Token(Token = "0x4000CCA")]
	[FieldOffset(Offset = "0x30")]
	public int AddAttack;

	// Token: 0x04001017 RID: 4119
	[Token(Token = "0x4000CCB")]
	[FieldOffset(Offset = "0x38")]
	public float[] AddAttackRate;

	// Token: 0x04001018 RID: 4120
	[Token(Token = "0x4000CCC")]
	[FieldOffset(Offset = "0x40")]
	public float StrRate;

	// Token: 0x04001019 RID: 4121
	[Token(Token = "0x4000CCD")]
	[FieldOffset(Offset = "0x44")]
	public float IntRate;

	// Token: 0x0400101A RID: 4122
	[Token(Token = "0x4000CCE")]
	[FieldOffset(Offset = "0x48")]
	public float DamageRate;

	// Token: 0x0400101B RID: 4123
	[Token(Token = "0x4000CCF")]
	[FieldOffset(Offset = "0x4C")]
	public float LevelRate;

	// Token: 0x0400101C RID: 4124
	[Token(Token = "0x4000CD0")]
	[FieldOffset(Offset = "0x50")]
	public float AttackCritical;

	// Token: 0x0400101D RID: 4125
	[Token(Token = "0x4000CD1")]
	[FieldOffset(Offset = "0x54")]
	public float AttackKnockBackRate;

	// Token: 0x0400101E RID: 4126
	[Token(Token = "0x4000CD2")]
	[FieldOffset(Offset = "0x58")]
	public float AttackKnockBackTime;

	// Token: 0x0400101F RID: 4127
	[Token(Token = "0x4000CD3")]
	[FieldOffset(Offset = "0x5C")]
	public int AttackBlowPower;

	// Token: 0x04001020 RID: 4128
	[Token(Token = "0x4000CD4")]
	[FieldOffset(Offset = "0x60")]
	public Vector3 Direction;

	// Token: 0x04001021 RID: 4129
	[Token(Token = "0x4000CD5")]
	[FieldOffset(Offset = "0x6C")]
	public float AttackStun;

	// Token: 0x04001022 RID: 4130
	[Token(Token = "0x4000CD6")]
	[FieldOffset(Offset = "0x70")]
	public float AttackPoison;

	// Token: 0x04001023 RID: 4131
	[Token(Token = "0x4000CD7")]
	[FieldOffset(Offset = "0x74")]
	public float AttackSeal;

	// Token: 0x04001024 RID: 4132
	[Token(Token = "0x4000CD8")]
	[FieldOffset(Offset = "0x78")]
	public float AttackParalysis;

	// Token: 0x04001025 RID: 4133
	[Token(Token = "0x4000CD9")]
	[FieldOffset(Offset = "0x7C")]
	public float AttackSleep;

	// Token: 0x04001026 RID: 4134
	[Token(Token = "0x4000CDA")]
	[FieldOffset(Offset = "0x80")]
	public float AttackTire;

	// Token: 0x04001027 RID: 4135
	[Token(Token = "0x4000CDB")]
	[FieldOffset(Offset = "0x84")]
	public float AttackSick;

	// Token: 0x04001028 RID: 4136
	[Token(Token = "0x4000CDC")]
	[FieldOffset(Offset = "0x88")]
	public float AttackDeath;

	// Token: 0x04001029 RID: 4137
	[Token(Token = "0x4000CDD")]
	[FieldOffset(Offset = "0x8C")]
	public float AttackHpDrain;

	// Token: 0x0400102A RID: 4138
	[Token(Token = "0x4000CDE")]
	[FieldOffset(Offset = "0x90")]
	public Parameter Buff;

	// Token: 0x0400102B RID: 4139
	[Token(Token = "0x4000CDF")]
	[FieldOffset(Offset = "0x14C")]
	public FloatParameter BuffPercent;

	// Token: 0x0400102C RID: 4140
	[Token(Token = "0x4000CE0")]
	[FieldOffset(Offset = "0x208")]
	public int BuffTimeHour;

	// Token: 0x0400102D RID: 4141
	[Token(Token = "0x4000CE1")]
	[FieldOffset(Offset = "0x20C")]
	public BadStatus HealBadStatus;

	// Token: 0x0400102E RID: 4142
	[Token(Token = "0x4000CE2")]
	[FieldOffset(Offset = "0x210")]
	public BadStatus AddBadStatus;

	// Token: 0x0400102F RID: 4143
	[Token(Token = "0x4000CE3")]
	[FieldOffset(Offset = "0x214")]
	public EffectID UseEffect;

	// Token: 0x04001030 RID: 4144
	[Token(Token = "0x4000CE4")]
	[FieldOffset(Offset = "0x218")]
	public float EffectScale;

	// Token: 0x04001031 RID: 4145
	[Token(Token = "0x4000CE5")]
	[FieldOffset(Offset = "0x21C")]
	public bool EffectCenter;

	// Token: 0x04001032 RID: 4146
	[Token(Token = "0x4000CE6")]
	[FieldOffset(Offset = "0x21D")]
	public bool EffectAttach;

	// Token: 0x04001033 RID: 4147
	[Token(Token = "0x4000CE7")]
	[FieldOffset(Offset = "0x0")]
	private static MagicParamDataTableArray _MagicParamDataTableArray;
}
