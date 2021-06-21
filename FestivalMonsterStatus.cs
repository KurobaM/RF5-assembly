using System;
using Define;
using Il2CppDummyDll;

// Token: 0x020008A4 RID: 2212
[Token(Token = "0x20005BA")]
public class FestivalMonsterStatus : FriendMonsterStatus
{
	// Token: 0x06003A7C RID: 14972 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60030EA")]
	[Address(RVA = "0x1F80B70", Offset = "0x1F80C71", VA = "0x1F80B70")]
	public FestivalMonsterStatus(FriendMonsterStatusData statusData)
	{
	}

	// Token: 0x1700083A RID: 2106
	// (get) Token: 0x06003A7D RID: 14973 RVA: 0x00014550 File Offset: 0x00012750
	[Token(Token = "0x1700067F")]
	public override Alliance Alliance
	{
		[Token(Token = "0x60030EB")]
		[Address(RVA = "0x1F80B80", Offset = "0x1F80C81", VA = "0x1F80B80", Slot = "6")]
		get
		{
			return Alliance.None;
		}
	}
}
