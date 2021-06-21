using System;
using System.Collections.Generic;
using Common;
using Il2CppDummyDll;

// Token: 0x0200003E RID: 62
[Token(Token = "0x200003D")]
public class ActionBehaviorCommandInformation
{
	// Token: 0x060000B2 RID: 178 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x1FD4D00", Offset = "0x1FD4E01", VA = "0x1FD4D00")]
	public ActionBehaviorCommandInformation(ActionBehaviorCommandType commandType)
	{
	}

	// Token: 0x04000097 RID: 151
	[Token(Token = "0x4000092")]
	[FieldOffset(Offset = "0x10")]
	public ActionBehaviorCommandType CommandType;

	// Token: 0x04000098 RID: 152
	[Token(Token = "0x4000093")]
	[FieldOffset(Offset = "0x18")]
	public Dictionary<int, VariableBase> ArgumentDic;
}
