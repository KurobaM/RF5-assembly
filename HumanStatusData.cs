using System;
using Define;
using Il2CppDummyDll;

// Token: 0x02000860 RID: 2144
[Token(Token = "0x2000584")]
[Attribute(Name = "MessagePackObjectAttribute", RVA = "0x1466E0", Offset = "0x1467E1")]
public class HumanStatusData : StatusDataBase
{
	// Token: 0x060038C2 RID: 14530 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002F46")]
	[Address(RVA = "0x222AC70", Offset = "0x222AD71", VA = "0x222AC70")]
	[Attribute(Name = "SerializationConstructorAttribute", RVA = "0x1A5D60", Offset = "0x1A5E61")]
	public HumanStatusData()
	{
	}

	// Token: 0x060038C3 RID: 14531 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002F47")]
	[Address(RVA = "0x22288F0", Offset = "0x22289F1", VA = "0x22288F0")]
	public HumanStatusData(ActorID id, HumanEquip humanEquip)
	{
	}

	// Token: 0x04007BE7 RID: 31719
	[Token(Token = "0x4006FFA")]
	[FieldOffset(Offset = "0x10C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16C6C0", Offset = "0x16C7C1")]
	public ActorID ActorID;

	// Token: 0x04007BE8 RID: 31720
	[Token(Token = "0x4006FFB")]
	[FieldOffset(Offset = "0x110")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16C6E0", Offset = "0x16C7E1")]
	public HumanEquip HumanEquip;

	// Token: 0x04007BE9 RID: 31721
	[Token(Token = "0x4006FFC")]
	[FieldOffset(Offset = "0x118")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16C700", Offset = "0x16C801")]
	public PartnerMovementOrderType PartnerMovementOrderType;

	// Token: 0x04007BEA RID: 31722
	[Token(Token = "0x4006FFD")]
	[FieldOffset(Offset = "0x11C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16C720", Offset = "0x16C821")]
	public float DualSkillGauge;
}
