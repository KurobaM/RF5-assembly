using System;
using Il2CppDummyDll;

// Token: 0x02000806 RID: 2054
[Token(Token = "0x200054C")]
[Serializable]
public class NpcTimeAction
{
	// Token: 0x060036C0 RID: 14016 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D88")]
	[Address(RVA = "0x1F4D300", Offset = "0x1F4D401", VA = "0x1F4D300")]
	public NpcTimeAction()
	{
	}

	// Token: 0x040079C4 RID: 31172
	[Token(Token = "0x4006E53")]
	[FieldOffset(Offset = "0x10")]
	public int time;

	// Token: 0x040079C5 RID: 31173
	[Token(Token = "0x4006E54")]
	[FieldOffset(Offset = "0x18")]
	public NpcTimeActionData npcData;
}
