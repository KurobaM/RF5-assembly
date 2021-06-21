using System;
using Il2CppDummyDll;

// Token: 0x0200033E RID: 830
[Token(Token = "0x200026E")]
public class BgmList
{
	// Token: 0x0600163D RID: 5693 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013B0")]
	[Address(RVA = "0x2450930", Offset = "0x2450A31", VA = "0x2450930")]
	public BgmList(BGMID bgmId, int sortOrder)
	{
	}

	// Token: 0x04000CD6 RID: 3286
	[Token(Token = "0x40009BB")]
	[FieldOffset(Offset = "0x10")]
	public BGMID BgmId;

	// Token: 0x04000CD7 RID: 3287
	[Token(Token = "0x40009BC")]
	[FieldOffset(Offset = "0x14")]
	public int SortOrder;
}
