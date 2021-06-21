using System;
using Il2CppDummyDll;

// Token: 0x02000858 RID: 2136
[Token(Token = "0x200057D")]
[Attribute(Name = "MessagePackObjectAttribute", RVA = "0x1465F0", Offset = "0x1466F1")]
public class SeedItemData : AmountItemData
{
	// Token: 0x170007EA RID: 2026
	// (get) Token: 0x06003899 RID: 14489 RVA: 0x000138D8 File Offset: 0x00011AD8
	[Token(Token = "0x1700062F")]
	[Attribute(Name = "IgnoreMemberAttribute", RVA = "0x1B87B0", Offset = "0x1B88B1")]
	public CropDataTable SeedItemDataTable
	{
		[Token(Token = "0x6002F1D")]
		[Address(RVA = "0x1E2F920", Offset = "0x1E2FA21", VA = "0x1E2F920")]
		get
		{
			return default(CropDataTable);
		}
	}

	// Token: 0x0600389A RID: 14490 RVA: 0x000138F0 File Offset: 0x00011AF0
	[Token(Token = "0x6002F1E")]
	[Address(RVA = "0x1E2F930", Offset = "0x1E2FA31", VA = "0x1E2F930", Slot = "14")]
	public override Parameter CalcParameter()
	{
		return default(Parameter);
	}

	// Token: 0x0600389B RID: 14491 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002F1F")]
	[Address(RVA = "0x1E2F970", Offset = "0x1E2FA71", VA = "0x1E2F970")]
	public SeedItemData()
	{
	}
}
