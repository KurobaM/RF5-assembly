using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;

// Token: 0x0200043E RID: 1086
[Token(Token = "0x200033E")]
[Serializable]
public struct EventFlagProgressData
{
	// Token: 0x04005D4C RID: 23884
	[Token(Token = "0x4005986")]
	[FieldOffset(Offset = "0x0")]
	public int FlagType;

	// Token: 0x04005D4D RID: 23885
	[Token(Token = "0x4005987")]
	[FieldOffset(Offset = "0x8")]
	public List<GameFlagData> FlagIdList;
}
