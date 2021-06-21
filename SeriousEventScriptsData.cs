using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x0200047A RID: 1146
[Token(Token = "0x2000373")]
[Serializable]
public class SeriousEventScriptsData
{
	// Token: 0x06001BD2 RID: 7122 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018D1")]
	[Address(RVA = "0x1E317D0", Offset = "0x1E318D1", VA = "0x1E317D0")]
	public SeriousEventScriptsData()
	{
	}

	// Token: 0x0400618D RID: 24973
	[Token(Token = "0x4005D87")]
	[FieldOffset(Offset = "0x10")]
	public string scriptsID;

	// Token: 0x0400618E RID: 24974
	[Token(Token = "0x4005D88")]
	[FieldOffset(Offset = "0x18")]
	public List<string> scriptsName;
}
