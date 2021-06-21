using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000423 RID: 1059
[Token(Token = "0x200032F")]
[Serializable]
public class BirthTalkData
{
	// Token: 0x060019C6 RID: 6598 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016EC")]
	[Address(RVA = "0x2452170", Offset = "0x2452271", VA = "0x2452170")]
	public BirthTalkData()
	{
	}

	// Token: 0x04005CC7 RID: 23751
	[Token(Token = "0x400590E")]
	[FieldOffset(Offset = "0x10")]
	public int npcId;

	// Token: 0x04005CC8 RID: 23752
	[Token(Token = "0x400590F")]
	[FieldOffset(Offset = "0x18")]
	public List<bool> NpcTalkOn;
}
