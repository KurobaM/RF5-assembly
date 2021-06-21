using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;

// Token: 0x020004B2 RID: 1202
[Token(Token = "0x200037C")]
[Serializable]
public struct SubEventFlagProgressData
{
	// Token: 0x040062E9 RID: 25321
	[Token(Token = "0x4005DCA")]
	[FieldOffset(Offset = "0x0")]
	public int FlagType;

	// Token: 0x040062EA RID: 25322
	[Token(Token = "0x4005DCB")]
	[FieldOffset(Offset = "0x8")]
	public List<GameFlagData> FlagIdList;

	// Token: 0x040062EB RID: 25323
	[Token(Token = "0x4005DCC")]
	[FieldOffset(Offset = "0x10")]
	public List<int> EventIdList;
}
