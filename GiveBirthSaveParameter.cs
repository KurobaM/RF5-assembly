using System;
using Il2CppDummyDll;

// Token: 0x02000450 RID: 1104
[Token(Token = "0x2000350")]
[Attribute(Name = "MessagePackObjectAttribute", RVA = "0x145D50", Offset = "0x145E51")]
public class GiveBirthSaveParameter
{
	// Token: 0x06001AB0 RID: 6832 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017BA")]
	[Address(RVA = "0x1FEEAA0", Offset = "0x1FEEBA1", VA = "0x1FEEAA0")]
	public void Initialize()
	{
	}

	// Token: 0x06001AB1 RID: 6833 RVA: 0x0000B958 File Offset: 0x00009B58
	[Token(Token = "0x60017BB")]
	[Address(RVA = "0x1FEEE80", Offset = "0x1FEEF81", VA = "0x1FEEE80")]
	public bool CanChildBedBuy()
	{
		return default(bool);
	}

	// Token: 0x06001AB2 RID: 6834 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017BC")]
	[Address(RVA = "0x1FEEA90", Offset = "0x1FEEB91", VA = "0x1FEEA90")]
	public GiveBirthSaveParameter()
	{
	}

	// Token: 0x04005D9E RID: 23966
	[Token(Token = "0x40059D8")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "KeyAttribute", RVA = "0x164620", Offset = "0x164721")]
	public int Targetdays;

	// Token: 0x04005D9F RID: 23967
	[Token(Token = "0x40059D9")]
	[FieldOffset(Offset = "0x14")]
	[Attribute(Name = "KeyAttribute", RVA = "0x164660", Offset = "0x164761")]
	public int NowType;
}
