using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000987 RID: 2439
[Token(Token = "0x2000665")]
public class UIEMSaveData
{
	// Token: 0x06003FD7 RID: 16343 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003529")]
	[Address(RVA = "0x200EEC0", Offset = "0x200EFC1", VA = "0x200EEC0")]
	public UIEMSaveData()
	{
	}

	// Token: 0x04009E2A RID: 40490
	[Token(Token = "0x4007736")]
	[FieldOffset(Offset = "0x10")]
	public List<int> UIEMCategoriesCustomNo;

	// Token: 0x04009E2B RID: 40491
	[Token(Token = "0x4007737")]
	[FieldOffset(Offset = "0x18")]
	public List<int> UIEMQuckCategories;

	// Token: 0x04009E2C RID: 40492
	[Token(Token = "0x4007738")]
	[FieldOffset(Offset = "0x20")]
	public bool SyncToCampEquip;

	// Token: 0x04009E2D RID: 40493
	[Token(Token = "0x4007739")]
	[FieldOffset(Offset = "0x24")]
	public int QuickLastFocus;

	// Token: 0x04009E2E RID: 40494
	[Token(Token = "0x400773A")]
	[FieldOffset(Offset = "0x28")]
	public int CampLastFocus;
}
