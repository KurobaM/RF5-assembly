using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x020007ED RID: 2029
[Token(Token = "0x2000540")]
public class NpcGroup
{
	// Token: 0x06003507 RID: 13575 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002C15")]
	[Address(RVA = "0x1F47750", Offset = "0x1F47851", VA = "0x1F47750")]
	public NpcGroup()
	{
	}

	// Token: 0x040078E0 RID: 30944
	[Token(Token = "0x4006DA0")]
	[FieldOffset(Offset = "0x10")]
	public int NpcGroupId;

	// Token: 0x040078E1 RID: 30945
	[Token(Token = "0x4006DA1")]
	[FieldOffset(Offset = "0x18")]
	public List<int> NpcIds;
}
