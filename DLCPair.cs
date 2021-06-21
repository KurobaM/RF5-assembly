using System;
using Define;
using Il2CppDummyDll;

// Token: 0x02000333 RID: 819
[Token(Token = "0x2000266")]
[Serializable]
public class DLCPair
{
	// Token: 0x06001618 RID: 5656 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600139A")]
	[Address(RVA = "0x1D9DF60", Offset = "0x1D9E061", VA = "0x1D9DF60")]
	public DLCPair()
	{
	}

	// Token: 0x04000CBB RID: 3259
	[Token(Token = "0x40009A7")]
	[FieldOffset(Offset = "0x10")]
	public int AocIndex;

	// Token: 0x04000CBC RID: 3260
	[Token(Token = "0x40009A8")]
	[FieldOffset(Offset = "0x14")]
	public DLCID DlcId;

	// Token: 0x04000CBD RID: 3261
	[Token(Token = "0x40009A9")]
	[FieldOffset(Offset = "0x18")]
	public DLCType DlcType;
}
