using System;
using Define;
using Il2CppDummyDll;

// Token: 0x0200040E RID: 1038
[Token(Token = "0x200032B")]
public class TimelineMsg
{
	// Token: 0x0600180E RID: 6158 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600156B")]
	[Address(RVA = "0x206D460", Offset = "0x206D561", VA = "0x206D460")]
	public TimelineMsg()
	{
	}

	// Token: 0x04005BF3 RID: 23539
	[Token(Token = "0x400587A")]
	[FieldOffset(Offset = "0x10")]
	public TimelineMsgID msgId;

	// Token: 0x04005BF4 RID: 23540
	[Token(Token = "0x400587B")]
	[FieldOffset(Offset = "0x18")]
	public string name;

	// Token: 0x04005BF5 RID: 23541
	[Token(Token = "0x400587C")]
	[FieldOffset(Offset = "0x20")]
	public string msg;
}
