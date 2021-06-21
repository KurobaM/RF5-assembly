using System;
using Il2CppDummyDll;

// Token: 0x0200084F RID: 2127
[Token(Token = "0x2000575")]
[Attribute(Name = "MessagePackObjectAttribute", RVA = "0x1463C0", Offset = "0x1464C1")]
public class FishItemData : NotAmountItemData
{
	// Token: 0x06003868 RID: 14440 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002EEC")]
	[Address(RVA = "0x20349B0", Offset = "0x2034AB1", VA = "0x20349B0", Slot = "10")]
	public override ItemData Copy()
	{
		return null;
	}

	// Token: 0x06003869 RID: 14441 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002EED")]
	[Address(RVA = "0x2034A40", Offset = "0x2034B41", VA = "0x2034A40")]
	public FishItemData()
	{
	}

	// Token: 0x04007B77 RID: 31607
	[Token(Token = "0x4006F9C")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16B680", Offset = "0x16B781")]
	public int Size;
}
