using System;
using Il2CppDummyDll;

// Token: 0x0200085C RID: 2140
[Token(Token = "0x2000580")]
[Attribute(Name = "MessagePackObjectAttribute", RVA = "0x146630", Offset = "0x146731")]
public class EnemyStatusData : StatusDataBase
{
	// Token: 0x060038AA RID: 14506 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002F2E")]
	[Address(RVA = "0x22B4770", Offset = "0x22B4871", VA = "0x22B4770")]
	[Attribute(Name = "SerializationConstructorAttribute", RVA = "0x1A5D30", Offset = "0x1A5E31")]
	public EnemyStatusData()
	{
	}

	// Token: 0x060038AB RID: 14507 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002F2F")]
	[Address(RVA = "0x22B4320", Offset = "0x22B4421", VA = "0x22B4320")]
	public EnemyStatusData(MonsterDataID id, CharaParamDataTable charaParam)
	{
	}

	// Token: 0x04007B9E RID: 31646
	[Token(Token = "0x4006FB1")]
	[FieldOffset(Offset = "0x10C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16B7B0", Offset = "0x16B8B1")]
	public MonsterDataID MonsterDataID;

	// Token: 0x04007B9F RID: 31647
	[Token(Token = "0x4006FB2")]
	[FieldOffset(Offset = "0x110")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16B7D0", Offset = "0x16B8D1")]
	public PartnerMovementOrderType PartnerMovementOrderType;
}
