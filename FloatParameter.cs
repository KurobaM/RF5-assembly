using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200085D RID: 2141
[Token(Token = "0x2000581")]
[Attribute(Name = "MessagePackObjectAttribute", RVA = "0x146650", Offset = "0x146751")]
[Serializable]
public struct FloatParameter
{
	// Token: 0x060038AC RID: 14508 RVA: 0x000139F8 File Offset: 0x00011BF8
	[Token(Token = "0x6002F30")]
	[Address(RVA = "0x1EC8B00", Offset = "0x1EC8C01", VA = "0x1EC8B00")]
	public static FloatParameter operator +(FloatParameter a, FloatParameter b)
	{
		return default(FloatParameter);
	}

	// Token: 0x060038AD RID: 14509 RVA: 0x00013A10 File Offset: 0x00011C10
	[Token(Token = "0x6002F31")]
	[Address(RVA = "0x1EC8F20", Offset = "0x1EC9021", VA = "0x1EC8F20")]
	public static FloatParameter operator -(FloatParameter a, FloatParameter b)
	{
		return default(FloatParameter);
	}

	// Token: 0x060038AE RID: 14510 RVA: 0x00013A28 File Offset: 0x00011C28
	[Token(Token = "0x6002F32")]
	[Address(RVA = "0x1EC9340", Offset = "0x1EC9441", VA = "0x1EC9340")]
	public static FloatParameter operator *(FloatParameter a, int b)
	{
		return default(FloatParameter);
	}

	// Token: 0x060038AF RID: 14511 RVA: 0x00013A40 File Offset: 0x00011C40
	[Token(Token = "0x6002F33")]
	[Address(RVA = "0x1EC95D0", Offset = "0x1EC96D1", VA = "0x1EC95D0")]
	public static FloatParameter operator *(FloatParameter a, float b)
	{
		return default(FloatParameter);
	}

	// Token: 0x060038B0 RID: 14512 RVA: 0x00013A58 File Offset: 0x00011C58
	[Token(Token = "0x6002F34")]
	[Address(RVA = "0x1EC9870", Offset = "0x1EC9971", VA = "0x1EC9870")]
	public static FloatParameter operator /(FloatParameter a, float b)
	{
		return default(FloatParameter);
	}

	// Token: 0x060038B1 RID: 14513 RVA: 0x00013A70 File Offset: 0x00011C70
	[Token(Token = "0x6002F35")]
	[Address(RVA = "0x1EC9AF0", Offset = "0x1EC9BF1", VA = "0x1EC9AF0")]
	public static FloatParameter operator *(FloatParameter a, Parameter b)
	{
		return default(FloatParameter);
	}

	// Token: 0x060038B2 RID: 14514 RVA: 0x00013A88 File Offset: 0x00011C88
	[Token(Token = "0x6002F36")]
	[Address(RVA = "0x1EC9F30", Offset = "0x1ECA031", VA = "0x1EC9F30")]
	public static Parameter Floor(FloatParameter parameter)
	{
		return default(Parameter);
	}

	// Token: 0x060038B3 RID: 14515 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002F37")]
	[Address(RVA = "0x2DE950", Offset = "0x2DEA51", VA = "0x2DE950")]
	public void MinZero()
	{
	}

	// Token: 0x04007BA0 RID: 31648
	[Token(Token = "0x4006FB3")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16B7F0", Offset = "0x16B8F1")]
	[SerializeField]
	public float MaxHp;

	// Token: 0x04007BA1 RID: 31649
	[Token(Token = "0x4006FB4")]
	[FieldOffset(Offset = "0x4")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16B830", Offset = "0x16B931")]
	[SerializeField]
	public float MaxRp;

	// Token: 0x04007BA2 RID: 31650
	[Token(Token = "0x4006FB5")]
	[FieldOffset(Offset = "0x8")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16B870", Offset = "0x16B971")]
	[SerializeField]
	public float Attack;

	// Token: 0x04007BA3 RID: 31651
	[Token(Token = "0x4006FB6")]
	[FieldOffset(Offset = "0xC")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16B8B0", Offset = "0x16B9B1")]
	[SerializeField]
	public float Defense;

	// Token: 0x04007BA4 RID: 31652
	[Token(Token = "0x4006FB7")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16B8F0", Offset = "0x16B9F1")]
	[SerializeField]
	public float MagicAttack;

	// Token: 0x04007BA5 RID: 31653
	[Token(Token = "0x4006FB8")]
	[FieldOffset(Offset = "0x14")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16B930", Offset = "0x16BA31")]
	[SerializeField]
	public float MagicDefense;

	// Token: 0x04007BA6 RID: 31654
	[Token(Token = "0x4006FB9")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16B970", Offset = "0x16BA71")]
	[SerializeField]
	public float Strength;

	// Token: 0x04007BA7 RID: 31655
	[Token(Token = "0x4006FBA")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16B9B0", Offset = "0x16BAB1")]
	[SerializeField]
	public float Intelligence;

	// Token: 0x04007BA8 RID: 31656
	[Token(Token = "0x4006FBB")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16B9F0", Offset = "0x16BAF1")]
	[SerializeField]
	public float Vitality;

	// Token: 0x04007BA9 RID: 31657
	[Token(Token = "0x4006FBC")]
	[FieldOffset(Offset = "0x24")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16BA30", Offset = "0x16BB31")]
	[SerializeField]
	public float AttackCritical;

	// Token: 0x04007BAA RID: 31658
	[Token(Token = "0x4006FBD")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16BA70", Offset = "0x16BB71")]
	[SerializeField]
	public float AttackKnockBackRate;

	// Token: 0x04007BAB RID: 31659
	[Token(Token = "0x4006FBE")]
	[FieldOffset(Offset = "0x2C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16BAB0", Offset = "0x16BBB1")]
	[SerializeField]
	public float AttackKnockBackTime;

	// Token: 0x04007BAC RID: 31660
	[Token(Token = "0x4006FBF")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16BAF0", Offset = "0x16BBF1")]
	[SerializeField]
	public float AttackStun;

	// Token: 0x04007BAD RID: 31661
	[Token(Token = "0x4006FC0")]
	[FieldOffset(Offset = "0x34")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16BB30", Offset = "0x16BC31")]
	[SerializeField]
	public float AttackPoison;

	// Token: 0x04007BAE RID: 31662
	[Token(Token = "0x4006FC1")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16BB70", Offset = "0x16BC71")]
	[SerializeField]
	public float AttackSeal;

	// Token: 0x04007BAF RID: 31663
	[Token(Token = "0x4006FC2")]
	[FieldOffset(Offset = "0x3C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16BBB0", Offset = "0x16BCB1")]
	[SerializeField]
	public float AttackParalysis;

	// Token: 0x04007BB0 RID: 31664
	[Token(Token = "0x4006FC3")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16BBF0", Offset = "0x16BCF1")]
	[SerializeField]
	public float AttackSleep;

	// Token: 0x04007BB1 RID: 31665
	[Token(Token = "0x4006FC4")]
	[FieldOffset(Offset = "0x44")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16BC30", Offset = "0x16BD31")]
	[SerializeField]
	public float AttackTire;

	// Token: 0x04007BB2 RID: 31666
	[Token(Token = "0x4006FC5")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16BC70", Offset = "0x16BD71")]
	[SerializeField]
	public float AttackSick;

	// Token: 0x04007BB3 RID: 31667
	[Token(Token = "0x4006FC6")]
	[FieldOffset(Offset = "0x4C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16BCB0", Offset = "0x16BDB1")]
	[SerializeField]
	public float AttackDeath;

	// Token: 0x04007BB4 RID: 31668
	[Token(Token = "0x4006FC7")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16BCF0", Offset = "0x16BDF1")]
	[SerializeField]
	public float AttackHpDrain;

	// Token: 0x04007BB5 RID: 31669
	[Token(Token = "0x4006FC8")]
	[FieldOffset(Offset = "0x54")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16BD30", Offset = "0x16BE31")]
	[SerializeField]
	public float DefenceFire;

	// Token: 0x04007BB6 RID: 31670
	[Token(Token = "0x4006FC9")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16BD70", Offset = "0x16BE71")]
	[SerializeField]
	public float DefenceWater;

	// Token: 0x04007BB7 RID: 31671
	[Token(Token = "0x4006FCA")]
	[FieldOffset(Offset = "0x5C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16BDB0", Offset = "0x16BEB1")]
	[SerializeField]
	public float DefenceEarth;

	// Token: 0x04007BB8 RID: 31672
	[Token(Token = "0x4006FCB")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16BDF0", Offset = "0x16BEF1")]
	[SerializeField]
	public float DefenceWind;

	// Token: 0x04007BB9 RID: 31673
	[Token(Token = "0x4006FCC")]
	[FieldOffset(Offset = "0x64")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16BE30", Offset = "0x16BF31")]
	[SerializeField]
	public float DefenceShine;

	// Token: 0x04007BBA RID: 31674
	[Token(Token = "0x4006FCD")]
	[FieldOffset(Offset = "0x68")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16BE70", Offset = "0x16BF71")]
	[SerializeField]
	public float DefenceDark;

	// Token: 0x04007BBB RID: 31675
	[Token(Token = "0x4006FCE")]
	[FieldOffset(Offset = "0x6C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16BEB0", Offset = "0x16BFB1")]
	[SerializeField]
	public float DefenceLove;

	// Token: 0x04007BBC RID: 31676
	[Token(Token = "0x4006FCF")]
	[FieldOffset(Offset = "0x70")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16BEF0", Offset = "0x16BFF1")]
	[SerializeField]
	public float DefenceMu;

	// Token: 0x04007BBD RID: 31677
	[Token(Token = "0x4006FD0")]
	[FieldOffset(Offset = "0x74")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16BF30", Offset = "0x16C031")]
	[SerializeField]
	public float DefenceStunRate;

	// Token: 0x04007BBE RID: 31678
	[Token(Token = "0x4006FD1")]
	[FieldOffset(Offset = "0x78")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16BF70", Offset = "0x16C071")]
	[SerializeField]
	public float DefenceCritical;

	// Token: 0x04007BBF RID: 31679
	[Token(Token = "0x4006FD2")]
	[FieldOffset(Offset = "0x7C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16BFB0", Offset = "0x16C0B1")]
	[SerializeField]
	public float DefenceKnockBackRate;

	// Token: 0x04007BC0 RID: 31680
	[Token(Token = "0x4006FD3")]
	[FieldOffset(Offset = "0x80")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16BFF0", Offset = "0x16C0F1")]
	[SerializeField]
	public float KnockbackTime;

	// Token: 0x04007BC1 RID: 31681
	[Token(Token = "0x4006FD4")]
	[FieldOffset(Offset = "0x84")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16C030", Offset = "0x16C131")]
	[SerializeField]
	public float DefencePoison;

	// Token: 0x04007BC2 RID: 31682
	[Token(Token = "0x4006FD5")]
	[FieldOffset(Offset = "0x88")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16C070", Offset = "0x16C171")]
	[SerializeField]
	public float DefenceSeal;

	// Token: 0x04007BC3 RID: 31683
	[Token(Token = "0x4006FD6")]
	[FieldOffset(Offset = "0x8C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16C0B0", Offset = "0x16C1B1")]
	[SerializeField]
	public float DefenceParalysis;

	// Token: 0x04007BC4 RID: 31684
	[Token(Token = "0x4006FD7")]
	[FieldOffset(Offset = "0x90")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16C0F0", Offset = "0x16C1F1")]
	[SerializeField]
	public float DefenceSleep;

	// Token: 0x04007BC5 RID: 31685
	[Token(Token = "0x4006FD8")]
	[FieldOffset(Offset = "0x94")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16C130", Offset = "0x16C231")]
	[SerializeField]
	public float DefenceTire;

	// Token: 0x04007BC6 RID: 31686
	[Token(Token = "0x4006FD9")]
	[FieldOffset(Offset = "0x98")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16C170", Offset = "0x16C271")]
	[SerializeField]
	public float DefenceSick;

	// Token: 0x04007BC7 RID: 31687
	[Token(Token = "0x4006FDA")]
	[FieldOffset(Offset = "0x9C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16C1B0", Offset = "0x16C2B1")]
	[SerializeField]
	public float DefenceDeath;

	// Token: 0x04007BC8 RID: 31688
	[Token(Token = "0x4006FDB")]
	[FieldOffset(Offset = "0xA0")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16C1F0", Offset = "0x16C2F1")]
	[SerializeField]
	public float DefenceHpDrain;

	// Token: 0x04007BC9 RID: 31689
	[Token(Token = "0x4006FDC")]
	[FieldOffset(Offset = "0xA4")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16C230", Offset = "0x16C331")]
	[SerializeField]
	public float SpeedRate;

	// Token: 0x04007BCA RID: 31690
	[Token(Token = "0x4006FDD")]
	[FieldOffset(Offset = "0xA8")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16C270", Offset = "0x16C371")]
	[SerializeField]
	public float AccelerationRate;

	// Token: 0x04007BCB RID: 31691
	[Token(Token = "0x4006FDE")]
	[FieldOffset(Offset = "0xAC")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16C2B0", Offset = "0x16C3B1")]
	[SerializeField]
	public float DecelerationRate;

	// Token: 0x04007BCC RID: 31692
	[Token(Token = "0x4006FDF")]
	[FieldOffset(Offset = "0xB0")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16C2F0", Offset = "0x16C3F1")]
	[SerializeField]
	public float RotateSpeedRate;

	// Token: 0x04007BCD RID: 31693
	[Token(Token = "0x4006FE0")]
	[FieldOffset(Offset = "0xB4")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16C330", Offset = "0x16C431")]
	[SerializeField]
	public float ChargeSpeed;

	// Token: 0x04007BCE RID: 31694
	[Token(Token = "0x4006FE1")]
	[FieldOffset(Offset = "0xB8")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16C370", Offset = "0x16C471")]
	[SerializeField]
	public float AttackLength;
}
