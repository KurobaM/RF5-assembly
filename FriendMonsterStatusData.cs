using System;
using Define;
using Farm;
using Il2CppDummyDll;

// Token: 0x0200085E RID: 2142
[Token(Token = "0x2000582")]
[Attribute(Name = "MessagePackObjectAttribute", RVA = "0x146670", Offset = "0x146771")]
public class FriendMonsterStatusData : StatusDataBase
{
	// Token: 0x060038B4 RID: 14516 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002F38")]
	[Address(RVA = "0x23CED30", Offset = "0x23CEE31", VA = "0x23CED30")]
	[Attribute(Name = "SerializationConstructorAttribute", RVA = "0x1A5D40", Offset = "0x1A5E41")]
	public FriendMonsterStatusData()
	{
	}

	// Token: 0x060038B5 RID: 14517 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002F39")]
	[Address(RVA = "0x23CED40", Offset = "0x23CEE41", VA = "0x23CED40")]
	public void Create(uint dataId, string name, EnemyStatusData enemyStatusData)
	{
	}

	// Token: 0x04007BCF RID: 31695
	[Token(Token = "0x4006FE2")]
	[FieldOffset(Offset = "0x10C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16C3B0", Offset = "0x16C4B1")]
	public uint DataID;

	// Token: 0x04007BD0 RID: 31696
	[Token(Token = "0x4006FE3")]
	[FieldOffset(Offset = "0x110")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16C3D0", Offset = "0x16C4D1")]
	public string Name;

	// Token: 0x04007BD1 RID: 31697
	[Token(Token = "0x4006FE4")]
	[FieldOffset(Offset = "0x118")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16C3F0", Offset = "0x16C4F1")]
	public MonsterDataID MonsterDataID;

	// Token: 0x04007BD2 RID: 31698
	[Token(Token = "0x4006FE5")]
	[FieldOffset(Offset = "0x120")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16C410", Offset = "0x16C511")]
	public MonsterLovePoint LovePoint;

	// Token: 0x04007BD3 RID: 31699
	[Token(Token = "0x4006FE6")]
	[FieldOffset(Offset = "0x128")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16C430", Offset = "0x16C531")]
	public int TimeStamp;

	// Token: 0x04007BD4 RID: 31700
	[Token(Token = "0x4006FE7")]
	[FieldOffset(Offset = "0x12C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16C450", Offset = "0x16C551")]
	public FarmManager.FARM_ID FarmId;

	// Token: 0x04007BD5 RID: 31701
	[Token(Token = "0x4006FE8")]
	[FieldOffset(Offset = "0x130")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16C470", Offset = "0x16C571")]
	public int HouseId;

	// Token: 0x04007BD6 RID: 31702
	[Token(Token = "0x4006FE9")]
	[FieldOffset(Offset = "0x134")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16C490", Offset = "0x16C591")]
	public int RoomId;

	// Token: 0x04007BD7 RID: 31703
	[Token(Token = "0x4006FEA")]
	[FieldOffset(Offset = "0x138")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16C4B0", Offset = "0x16C5B1")]
	public int PartyNo;

	// Token: 0x04007BD8 RID: 31704
	[Token(Token = "0x4006FEB")]
	[FieldOffset(Offset = "0x13C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16C4D0", Offset = "0x16C5D1")]
	public PartnerMovementOrderType PartnerMovementOrderType;

	// Token: 0x04007BD9 RID: 31705
	[Token(Token = "0x4006FEC")]
	[FieldOffset(Offset = "0x140")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16C4F0", Offset = "0x16C5F1")]
	public FarmMonsterOrder FarmMonsterOrder;

	// Token: 0x04007BDA RID: 31706
	[Token(Token = "0x4006FED")]
	[FieldOffset(Offset = "0x144")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16C510", Offset = "0x16C611")]
	public FarmFieldWorkArea FarmFieldWorkArea;

	// Token: 0x04007BDB RID: 31707
	[Token(Token = "0x4006FEE")]
	[FieldOffset(Offset = "0x148")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16C530", Offset = "0x16C631")]
	public bool IsBrushed;

	// Token: 0x04007BDC RID: 31708
	[Token(Token = "0x4006FEF")]
	[FieldOffset(Offset = "0x149")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16C550", Offset = "0x16C651")]
	public bool IsPresent;

	// Token: 0x04007BDD RID: 31709
	[Token(Token = "0x4006FF0")]
	[FieldOffset(Offset = "0x14A")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16C570", Offset = "0x16C671")]
	public bool EsaGet;

	// Token: 0x04007BDE RID: 31710
	[Token(Token = "0x4006FF1")]
	[FieldOffset(Offset = "0x14B")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16C590", Offset = "0x16C691")]
	public bool IsWorkedToday;

	// Token: 0x04007BDF RID: 31711
	[Token(Token = "0x4006FF2")]
	[FieldOffset(Offset = "0x14C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16C5B0", Offset = "0x16C6B1")]
	public bool IsSeededToday;

	// Token: 0x04007BE0 RID: 31712
	[Token(Token = "0x4006FF3")]
	[FieldOffset(Offset = "0x14D")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16C5D0", Offset = "0x16C6D1")]
	public bool IsYieldToday;

	// Token: 0x04007BE1 RID: 31713
	[Token(Token = "0x4006FF4")]
	[FieldOffset(Offset = "0x150")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16C5F0", Offset = "0x16C6F1")]
	public int Bonus_HP;

	// Token: 0x04007BE2 RID: 31714
	[Token(Token = "0x4006FF5")]
	[FieldOffset(Offset = "0x154")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16C610", Offset = "0x16C711")]
	public int Bonus_STR;

	// Token: 0x04007BE3 RID: 31715
	[Token(Token = "0x4006FF6")]
	[FieldOffset(Offset = "0x158")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16C630", Offset = "0x16C731")]
	public int Bonus_INT;

	// Token: 0x04007BE4 RID: 31716
	[Token(Token = "0x4006FF7")]
	[FieldOffset(Offset = "0x15C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16C650", Offset = "0x16C751")]
	public int Bonus_VIT;
}
