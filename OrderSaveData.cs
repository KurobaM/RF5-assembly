using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000463 RID: 1123
[Token(Token = "0x2000360")]
[Attribute(Name = "MessagePackObjectAttribute", RVA = "0x145DA0", Offset = "0x145EA1")]
public struct OrderSaveData
{
	// Token: 0x06001B17 RID: 6935 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001821")]
	[Address(RVA = "0x2E09E0", Offset = "0x2E0AE1", VA = "0x2E09E0")]
	public void InitializeForNewGame()
	{
	}

	// Token: 0x06001B18 RID: 6936 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001822")]
	[Address(RVA = "0x2E09F0", Offset = "0x2E0AF1", VA = "0x2E09F0")]
	public void Initialize()
	{
	}

	// Token: 0x04005E30 RID: 24112
	[Token(Token = "0x4005A3F")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "KeyAttribute", RVA = "0x164780", Offset = "0x164881")]
	public int OrderClearCount;

	// Token: 0x04005E31 RID: 24113
	[Token(Token = "0x4005A40")]
	[FieldOffset(Offset = "0x8")]
	[Attribute(Name = "KeyAttribute", RVA = "0x1647A0", Offset = "0x1648A1")]
	public List<OrderSaveParameter> AcceptOrderParameters;

	// Token: 0x04005E32 RID: 24114
	[Token(Token = "0x4005A41")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "KeyAttribute", RVA = "0x1647C0", Offset = "0x1648C1")]
	public List<OrderLotterySaveParameter> LotteryBoardOrderDatas;

	// Token: 0x04005E33 RID: 24115
	[Token(Token = "0x4005A42")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "KeyAttribute", RVA = "0x1647E0", Offset = "0x1648E1")]
	public List<OrderLotterySaveParameter> LotteryNpcOrderDatas;

	// Token: 0x04005E34 RID: 24116
	[Token(Token = "0x4005A43")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "KeyAttribute", RVA = "0x164800", Offset = "0x164901")]
	public List<OrderSaveParameter> LotMasterOrderParameters;
}
