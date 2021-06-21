using System;
using Field;
using Il2CppDummyDll;

// Token: 0x02000429 RID: 1065
[Token(Token = "0x2000335")]
internal class EventStartData
{
	// Token: 0x060019DD RID: 6621 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001703")]
	[Address(RVA = "0x21BA9E0", Offset = "0x21BAAE1", VA = "0x21BA9E0")]
	public EventStartData()
	{
	}

	// Token: 0x04005CD5 RID: 23765
	[Token(Token = "0x400591C")]
	[FieldOffset(Offset = "0x10")]
	public string ForceScriptName;

	// Token: 0x04005CD6 RID: 23766
	[Token(Token = "0x400591D")]
	[FieldOffset(Offset = "0x18")]
	public FocusObjectID ObjectInteractionId;

	// Token: 0x04005CD7 RID: 23767
	[Token(Token = "0x400591E")]
	[FieldOffset(Offset = "0x20")]
	public NpcController npc;

	// Token: 0x04005CD8 RID: 23768
	[Token(Token = "0x400591F")]
	[FieldOffset(Offset = "0x28")]
	public int npcId;
}
