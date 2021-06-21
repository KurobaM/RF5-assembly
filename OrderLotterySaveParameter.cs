using System;
using Il2CppDummyDll;

// Token: 0x02000465 RID: 1125
[Token(Token = "0x2000362")]
[Attribute(Name = "MessagePackObjectAttribute", RVA = "0x145DE0", Offset = "0x145EE1")]
public struct OrderLotterySaveParameter
{
	// Token: 0x06001B1B RID: 6939 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001825")]
	[Address(RVA = "0x2E0950", Offset = "0x2E0A51", VA = "0x2E0950")]
	public OrderLotterySaveParameter(int orderId, int reqId, int type)
	{
	}

	// Token: 0x06001B1C RID: 6940 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001826")]
	[Address(RVA = "0x2E0960", Offset = "0x2E0A61", VA = "0x2E0960")]
	public void Initialize()
	{
	}

	// Token: 0x06001B1D RID: 6941 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001827")]
	[Address(RVA = "0x2E0980", Offset = "0x2E0A81", VA = "0x2E0980")]
	public void SetParameterByOrderData(int orderId, int requestId, int type)
	{
	}

	// Token: 0x04005E3E RID: 24126
	[Token(Token = "0x4005A4D")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "KeyAttribute", RVA = "0x164940", Offset = "0x164A41")]
	public int OrderId;

	// Token: 0x04005E3F RID: 24127
	[Token(Token = "0x4005A4E")]
	[FieldOffset(Offset = "0x4")]
	[Attribute(Name = "KeyAttribute", RVA = "0x164960", Offset = "0x164A61")]
	public int OrderRequestId;

	// Token: 0x04005E40 RID: 24128
	[Token(Token = "0x4005A4F")]
	[FieldOffset(Offset = "0x8")]
	[Attribute(Name = "KeyAttribute", RVA = "0x164980", Offset = "0x164A81")]
	public int TypeKey;
}
