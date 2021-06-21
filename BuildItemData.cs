using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;

// Token: 0x02000AB2 RID: 2738
[Token(Token = "0x200072F")]
[Serializable]
public struct BuildItemData
{
	// Token: 0x0400A63A RID: 42554
	[Token(Token = "0x4007DA2")]
	[FieldOffset(Offset = "0x0")]
	public int ID;

	// Token: 0x0400A63B RID: 42555
	[Token(Token = "0x4007DA3")]
	[FieldOffset(Offset = "0x8")]
	public string IconName;

	// Token: 0x0400A63C RID: 42556
	[Token(Token = "0x4007DA4")]
	[FieldOffset(Offset = "0x10")]
	public int Lumber;

	// Token: 0x0400A63D RID: 42557
	[Token(Token = "0x4007DA5")]
	[FieldOffset(Offset = "0x14")]
	public int Stone;

	// Token: 0x0400A63E RID: 42558
	[Token(Token = "0x4007DA6")]
	[FieldOffset(Offset = "0x18")]
	public int Gold;

	// Token: 0x0400A63F RID: 42559
	[Token(Token = "0x4007DA7")]
	[FieldOffset(Offset = "0x1C")]
	public int SeedPoint;

	// Token: 0x0400A640 RID: 42560
	[Token(Token = "0x4007DA8")]
	[FieldOffset(Offset = "0x20")]
	public int Limit;

	// Token: 0x0400A641 RID: 42561
	[Token(Token = "0x4007DA9")]
	[FieldOffset(Offset = "0x28")]
	public string StrNameId;

	// Token: 0x0400A642 RID: 42562
	[Token(Token = "0x4007DAA")]
	[FieldOffset(Offset = "0x30")]
	public string StrDetailId;

	// Token: 0x0400A643 RID: 42563
	[Token(Token = "0x4007DAB")]
	[FieldOffset(Offset = "0x38")]
	public int BuildFlagForMake;

	// Token: 0x0400A644 RID: 42564
	[Token(Token = "0x4007DAC")]
	[FieldOffset(Offset = "0x3C")]
	public int ShopLv;

	// Token: 0x0400A645 RID: 42565
	[Token(Token = "0x4007DAD")]
	[FieldOffset(Offset = "0x40")]
	public GameFlagData SenarioPoint;

	// Token: 0x0400A646 RID: 42566
	[Token(Token = "0x4007DAE")]
	[FieldOffset(Offset = "0x48")]
	public List<ulong> Condition;

	// Token: 0x0400A647 RID: 42567
	[Token(Token = "0x4007DAF")]
	[FieldOffset(Offset = "0x50")]
	public FurnitureID FurnitureId;

	// Token: 0x0400A648 RID: 42568
	[Token(Token = "0x4007DB0")]
	[FieldOffset(Offset = "0x58")]
	public string BuyNgPalmo;

	// Token: 0x0400A649 RID: 42569
	[Token(Token = "0x4007DB1")]
	[FieldOffset(Offset = "0x60")]
	public string BuyNgLyuca;

	// Token: 0x0400A64A RID: 42570
	[Token(Token = "0x4007DB2")]
	[FieldOffset(Offset = "0x68")]
	public ulong BuyCondition;

	// Token: 0x0400A64B RID: 42571
	[Token(Token = "0x4007DB3")]
	[FieldOffset(Offset = "0x70")]
	public bool BuildShopSkillExpUp;
}
