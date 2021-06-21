using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000475 RID: 1141
[Token(Token = "0x200036E")]
[Serializable]
public class ScenarioTalkData
{
	// Token: 0x06001BC8 RID: 7112 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018C7")]
	[Address(RVA = "0x21D4320", Offset = "0x21D4421", VA = "0x21D4320")]
	public ScenarioTalkData()
	{
	}

	// Token: 0x04006091 RID: 24721
	[Token(Token = "0x4005C8B")]
	[FieldOffset(Offset = "0x10")]
	public int ScenarioId;

	// Token: 0x04006092 RID: 24722
	[Token(Token = "0x4005C8C")]
	[FieldOffset(Offset = "0x18")]
	public List<bool> NpcTalkOn;
}
