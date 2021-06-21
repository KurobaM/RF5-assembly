using System;
using Il2CppDummyDll;

// Token: 0x02000464 RID: 1124
[Token(Token = "0x2000361")]
[Attribute(Name = "MessagePackObjectAttribute", RVA = "0x145DC0", Offset = "0x145EC1")]
public struct OrderSaveParameter
{
	// Token: 0x06001B19 RID: 6937 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001823")]
	[Address(RVA = "0x2E0B30", Offset = "0x2E0C31", VA = "0x2E0B30")]
	public void Initialize()
	{
	}

	// Token: 0x06001B1A RID: 6938 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001824")]
	[Address(RVA = "0x2E0BA0", Offset = "0x2E0CA1", VA = "0x2E0BA0")]
	public void SetParameterByOrderData(OrderData data)
	{
	}

	// Token: 0x04005E35 RID: 24117
	[Token(Token = "0x4005A44")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "KeyAttribute", RVA = "0x164820", Offset = "0x164921")]
	public int OrderId;

	// Token: 0x04005E36 RID: 24118
	[Token(Token = "0x4005A45")]
	[FieldOffset(Offset = "0x4")]
	[Attribute(Name = "KeyAttribute", RVA = "0x164840", Offset = "0x164941")]
	public int AcceptId;

	// Token: 0x04005E37 RID: 24119
	[Token(Token = "0x4005A46")]
	[FieldOffset(Offset = "0x8")]
	[Attribute(Name = "KeyAttribute", RVA = "0x164860", Offset = "0x164961")]
	public int OrderTargetCurrentAmount;

	// Token: 0x04005E38 RID: 24120
	[Token(Token = "0x4005A47")]
	[FieldOffset(Offset = "0xC")]
	[Attribute(Name = "KeyAttribute", RVA = "0x164880", Offset = "0x164981")]
	public int CompleteDate;

	// Token: 0x04005E39 RID: 24121
	[Token(Token = "0x4005A48")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "KeyAttribute", RVA = "0x1648A0", Offset = "0x1649A1")]
	public bool RecievedOrder;

	// Token: 0x04005E3A RID: 24122
	[Token(Token = "0x4005A49")]
	[FieldOffset(Offset = "0x11")]
	[Attribute(Name = "KeyAttribute", RVA = "0x1648C0", Offset = "0x1649C1")]
	public bool Completed;

	// Token: 0x04005E3B RID: 24123
	[Token(Token = "0x4005A4A")]
	[FieldOffset(Offset = "0x12")]
	[Attribute(Name = "KeyAttribute", RVA = "0x1648E0", Offset = "0x1649E1")]
	public bool GotReward;

	// Token: 0x04005E3C RID: 24124
	[Token(Token = "0x4005A4B")]
	[FieldOffset(Offset = "0x13")]
	[Attribute(Name = "KeyAttribute", RVA = "0x164900", Offset = "0x164A01")]
	public bool FirstCompleted;

	// Token: 0x04005E3D RID: 24125
	[Token(Token = "0x4005A4C")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "KeyAttribute", RVA = "0x164920", Offset = "0x164A21")]
	public string CompletedEventStep;
}
