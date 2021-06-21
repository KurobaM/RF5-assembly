using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000861 RID: 2145
[Token(Token = "0x2000585")]
[Attribute(Name = "MessagePackObjectAttribute", RVA = "0x146700", Offset = "0x146801")]
[Serializable]
public struct Parameter
{
	// Token: 0x060038C4 RID: 14532 RVA: 0x00013AD0 File Offset: 0x00011CD0
	[Token(Token = "0x6002F48")]
	[Address(RVA = "0x23196C0", Offset = "0x23197C1", VA = "0x23196C0")]
	public static Parameter operator +(Parameter a, Parameter b)
	{
		return default(Parameter);
	}

	// Token: 0x060038C5 RID: 14533 RVA: 0x00013AE8 File Offset: 0x00011CE8
	[Token(Token = "0x6002F49")]
	[Address(RVA = "0x2319A30", Offset = "0x2319B31", VA = "0x2319A30")]
	public static Parameter operator -(Parameter a, Parameter b)
	{
		return default(Parameter);
	}

	// Token: 0x060038C6 RID: 14534 RVA: 0x00013B00 File Offset: 0x00011D00
	[Token(Token = "0x6002F4A")]
	[Address(RVA = "0x2319DA0", Offset = "0x2319EA1", VA = "0x2319DA0")]
	public static Parameter operator *(Parameter a, int b)
	{
		return default(Parameter);
	}

	// Token: 0x060038C7 RID: 14535 RVA: 0x00013B18 File Offset: 0x00011D18
	[Token(Token = "0x6002F4B")]
	[Address(RVA = "0x2319FF0", Offset = "0x231A0F1", VA = "0x2319FF0")]
	public static Parameter operator *(Parameter a, float b)
	{
		return default(Parameter);
	}

	// Token: 0x170007F0 RID: 2032
	// (get) Token: 0x060038C8 RID: 14536 RVA: 0x00013B30 File Offset: 0x00011D30
	[Token(Token = "0x17000635")]
	[Attribute(Name = "IgnoreMemberAttribute", RVA = "0x1B8810", Offset = "0x1B8911")]
	public Parameter BasicOnly
	{
		[Token(Token = "0x6002F4C")]
		[Address(RVA = "0x2E2DE0", Offset = "0x2E2EE1", VA = "0x2E2DE0")]
		get
		{
			return default(Parameter);
		}
	}

	// Token: 0x170007F1 RID: 2033
	// (get) Token: 0x060038C9 RID: 14537 RVA: 0x00013B48 File Offset: 0x00011D48
	[Token(Token = "0x17000636")]
	[Attribute(Name = "IgnoreMemberAttribute", RVA = "0x1B8820", Offset = "0x1B8921")]
	public Parameter BasicWhithout
	{
		[Token(Token = "0x6002F4D")]
		[Address(RVA = "0x2E2E50", Offset = "0x2E2F51", VA = "0x2E2E50")]
		get
		{
			return default(Parameter);
		}
	}

	// Token: 0x170007F2 RID: 2034
	// (get) Token: 0x060038CA RID: 14538 RVA: 0x00013B60 File Offset: 0x00011D60
	[Token(Token = "0x17000637")]
	public static Parameter Dummy
	{
		[Token(Token = "0x6002F4E")]
		[Address(RVA = "0x231A3B0", Offset = "0x231A4B1", VA = "0x231A3B0")]
		get
		{
			return default(Parameter);
		}
	}

	// Token: 0x060038CB RID: 14539 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002F4F")]
	[Address(RVA = "0x2E2E70", Offset = "0x2E2F71", VA = "0x2E2E70")]
	public void CalcBase()
	{
	}

	// Token: 0x060038CC RID: 14540 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002F50")]
	[Address(RVA = "0x2E2EB0", Offset = "0x2E2FB1", VA = "0x2E2EB0")]
	public void MinZero()
	{
	}

	// Token: 0x060038CD RID: 14541 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002F51")]
	[Address(RVA = "0x2E2EC0", Offset = "0x2E2FC1", VA = "0x2E2EC0")]
	public void Clamp()
	{
	}

	// Token: 0x04007BEB RID: 31723
	[Token(Token = "0x4006FFE")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16C740", Offset = "0x16C841")]
	[SerializeField]
	public int MaxHp;

	// Token: 0x04007BEC RID: 31724
	[Token(Token = "0x4006FFF")]
	[FieldOffset(Offset = "0x4")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16C780", Offset = "0x16C881")]
	[SerializeField]
	public int MaxRp;

	// Token: 0x04007BED RID: 31725
	[Token(Token = "0x4007000")]
	[FieldOffset(Offset = "0x8")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16C7C0", Offset = "0x16C8C1")]
	[SerializeField]
	public int Attack;

	// Token: 0x04007BEE RID: 31726
	[Token(Token = "0x4007001")]
	[FieldOffset(Offset = "0xC")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16C800", Offset = "0x16C901")]
	[SerializeField]
	public int Defense;

	// Token: 0x04007BEF RID: 31727
	[Token(Token = "0x4007002")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16C840", Offset = "0x16C941")]
	[SerializeField]
	public int MagicAttack;

	// Token: 0x04007BF0 RID: 31728
	[Token(Token = "0x4007003")]
	[FieldOffset(Offset = "0x14")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16C880", Offset = "0x16C981")]
	[SerializeField]
	public int MagicDefense;

	// Token: 0x04007BF1 RID: 31729
	[Token(Token = "0x4007004")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16C8C0", Offset = "0x16C9C1")]
	[SerializeField]
	public int Strength;

	// Token: 0x04007BF2 RID: 31730
	[Token(Token = "0x4007005")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16C900", Offset = "0x16CA01")]
	[SerializeField]
	public int Intelligence;

	// Token: 0x04007BF3 RID: 31731
	[Token(Token = "0x4007006")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16C940", Offset = "0x16CA41")]
	[SerializeField]
	public int Vitality;

	// Token: 0x04007BF4 RID: 31732
	[Token(Token = "0x4007007")]
	[FieldOffset(Offset = "0x24")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16C980", Offset = "0x16CA81")]
	[SerializeField]
	public float AttackCritical;

	// Token: 0x04007BF5 RID: 31733
	[Token(Token = "0x4007008")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16C9C0", Offset = "0x16CAC1")]
	[SerializeField]
	public float AttackKnockBackRate;

	// Token: 0x04007BF6 RID: 31734
	[Token(Token = "0x4007009")]
	[FieldOffset(Offset = "0x2C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16CA00", Offset = "0x16CB01")]
	[SerializeField]
	public float AttackKnockBackTime;

	// Token: 0x04007BF7 RID: 31735
	[Token(Token = "0x400700A")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16CA40", Offset = "0x16CB41")]
	[SerializeField]
	public float AttackStun;

	// Token: 0x04007BF8 RID: 31736
	[Token(Token = "0x400700B")]
	[FieldOffset(Offset = "0x34")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16CA80", Offset = "0x16CB81")]
	[SerializeField]
	public float AttackPoison;

	// Token: 0x04007BF9 RID: 31737
	[Token(Token = "0x400700C")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16CAC0", Offset = "0x16CBC1")]
	[SerializeField]
	public float AttackSeal;

	// Token: 0x04007BFA RID: 31738
	[Token(Token = "0x400700D")]
	[FieldOffset(Offset = "0x3C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16CB00", Offset = "0x16CC01")]
	[SerializeField]
	public float AttackParalysis;

	// Token: 0x04007BFB RID: 31739
	[Token(Token = "0x400700E")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16CB40", Offset = "0x16CC41")]
	[SerializeField]
	public float AttackSleep;

	// Token: 0x04007BFC RID: 31740
	[Token(Token = "0x400700F")]
	[FieldOffset(Offset = "0x44")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16CB80", Offset = "0x16CC81")]
	[SerializeField]
	public float AttackTire;

	// Token: 0x04007BFD RID: 31741
	[Token(Token = "0x4007010")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16CBC0", Offset = "0x16CCC1")]
	[SerializeField]
	public float AttackSick;

	// Token: 0x04007BFE RID: 31742
	[Token(Token = "0x4007011")]
	[FieldOffset(Offset = "0x4C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16CC00", Offset = "0x16CD01")]
	[SerializeField]
	public float AttackDeath;

	// Token: 0x04007BFF RID: 31743
	[Token(Token = "0x4007012")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16CC40", Offset = "0x16CD41")]
	[SerializeField]
	public float AttackHpDrain;

	// Token: 0x04007C00 RID: 31744
	[Token(Token = "0x4007013")]
	[FieldOffset(Offset = "0x54")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16CC80", Offset = "0x16CD81")]
	[SerializeField]
	public float DefenceFire;

	// Token: 0x04007C01 RID: 31745
	[Token(Token = "0x4007014")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16CCC0", Offset = "0x16CDC1")]
	[SerializeField]
	public float DefenceWater;

	// Token: 0x04007C02 RID: 31746
	[Token(Token = "0x4007015")]
	[FieldOffset(Offset = "0x5C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16CD00", Offset = "0x16CE01")]
	[SerializeField]
	public float DefenceEarth;

	// Token: 0x04007C03 RID: 31747
	[Token(Token = "0x4007016")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16CD40", Offset = "0x16CE41")]
	[SerializeField]
	public float DefenceWind;

	// Token: 0x04007C04 RID: 31748
	[Token(Token = "0x4007017")]
	[FieldOffset(Offset = "0x64")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16CD80", Offset = "0x16CE81")]
	[SerializeField]
	public float DefenceShine;

	// Token: 0x04007C05 RID: 31749
	[Token(Token = "0x4007018")]
	[FieldOffset(Offset = "0x68")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16CDC0", Offset = "0x16CEC1")]
	[SerializeField]
	public float DefenceDark;

	// Token: 0x04007C06 RID: 31750
	[Token(Token = "0x4007019")]
	[FieldOffset(Offset = "0x6C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16CE00", Offset = "0x16CF01")]
	[SerializeField]
	public float DefenceLove;

	// Token: 0x04007C07 RID: 31751
	[Token(Token = "0x400701A")]
	[FieldOffset(Offset = "0x70")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16CE40", Offset = "0x16CF41")]
	[SerializeField]
	public float DefenceMu;

	// Token: 0x04007C08 RID: 31752
	[Token(Token = "0x400701B")]
	[FieldOffset(Offset = "0x74")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16CE80", Offset = "0x16CF81")]
	[SerializeField]
	public float DefenceStunRate;

	// Token: 0x04007C09 RID: 31753
	[Token(Token = "0x400701C")]
	[FieldOffset(Offset = "0x78")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16CEC0", Offset = "0x16CFC1")]
	[SerializeField]
	public float DefenceCritical;

	// Token: 0x04007C0A RID: 31754
	[Token(Token = "0x400701D")]
	[FieldOffset(Offset = "0x7C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16CF00", Offset = "0x16D001")]
	[SerializeField]
	public float DefenceKnockBackRate;

	// Token: 0x04007C0B RID: 31755
	[Token(Token = "0x400701E")]
	[FieldOffset(Offset = "0x80")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16CF40", Offset = "0x16D041")]
	[SerializeField]
	public float KnockbackTime;

	// Token: 0x04007C0C RID: 31756
	[Token(Token = "0x400701F")]
	[FieldOffset(Offset = "0x84")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16CF80", Offset = "0x16D081")]
	[SerializeField]
	public float DefencePoison;

	// Token: 0x04007C0D RID: 31757
	[Token(Token = "0x4007020")]
	[FieldOffset(Offset = "0x88")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16CFC0", Offset = "0x16D0C1")]
	[SerializeField]
	public float DefenceSeal;

	// Token: 0x04007C0E RID: 31758
	[Token(Token = "0x4007021")]
	[FieldOffset(Offset = "0x8C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16D000", Offset = "0x16D101")]
	[SerializeField]
	public float DefenceParalysis;

	// Token: 0x04007C0F RID: 31759
	[Token(Token = "0x4007022")]
	[FieldOffset(Offset = "0x90")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16D040", Offset = "0x16D141")]
	[SerializeField]
	public float DefenceSleep;

	// Token: 0x04007C10 RID: 31760
	[Token(Token = "0x4007023")]
	[FieldOffset(Offset = "0x94")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16D080", Offset = "0x16D181")]
	[SerializeField]
	public float DefenceTire;

	// Token: 0x04007C11 RID: 31761
	[Token(Token = "0x4007024")]
	[FieldOffset(Offset = "0x98")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16D0C0", Offset = "0x16D1C1")]
	[SerializeField]
	public float DefenceSick;

	// Token: 0x04007C12 RID: 31762
	[Token(Token = "0x4007025")]
	[FieldOffset(Offset = "0x9C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16D100", Offset = "0x16D201")]
	[SerializeField]
	public float DefenceDeath;

	// Token: 0x04007C13 RID: 31763
	[Token(Token = "0x4007026")]
	[FieldOffset(Offset = "0xA0")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16D140", Offset = "0x16D241")]
	[SerializeField]
	public float DefenceHpDrain;

	// Token: 0x04007C14 RID: 31764
	[Token(Token = "0x4007027")]
	[FieldOffset(Offset = "0xA4")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16D180", Offset = "0x16D281")]
	[SerializeField]
	public float SpeedRate;

	// Token: 0x04007C15 RID: 31765
	[Token(Token = "0x4007028")]
	[FieldOffset(Offset = "0xA8")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16D1C0", Offset = "0x16D2C1")]
	[SerializeField]
	public float AccelerationRate;

	// Token: 0x04007C16 RID: 31766
	[Token(Token = "0x4007029")]
	[FieldOffset(Offset = "0xAC")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16D200", Offset = "0x16D301")]
	[SerializeField]
	public float DecelerationRate;

	// Token: 0x04007C17 RID: 31767
	[Token(Token = "0x400702A")]
	[FieldOffset(Offset = "0xB0")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16D240", Offset = "0x16D341")]
	[SerializeField]
	public float RotateSpeedRate;

	// Token: 0x04007C18 RID: 31768
	[Token(Token = "0x400702B")]
	[FieldOffset(Offset = "0xB4")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16D280", Offset = "0x16D381")]
	[SerializeField]
	public float ChargeSpeed;

	// Token: 0x04007C19 RID: 31769
	[Token(Token = "0x400702C")]
	[FieldOffset(Offset = "0xB8")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16D2C0", Offset = "0x16D3C1")]
	[SerializeField]
	public float AttackLength;
}
