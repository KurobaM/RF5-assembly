using System;
using Define;
using Il2CppDummyDll;

// Token: 0x02000678 RID: 1656
[Token(Token = "0x200049B")]
[Serializable]
public class GateSeasonInfomation
{
	// Token: 0x0600290B RID: 10507 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022AE")]
	[Address(RVA = "0x1FA3EE0", Offset = "0x1FA3FE1", VA = "0x1FA3EE0")]
	public GateSeasonInfomation()
	{
	}

	// Token: 0x040070A6 RID: 28838
	[Token(Token = "0x40068A4")]
	[FieldOffset(Offset = "0x10")]
	public int EventIndex;

	// Token: 0x040070A7 RID: 28839
	[Token(Token = "0x40068A5")]
	[FieldOffset(Offset = "0x14")]
	public Season Season;

	// Token: 0x040070A8 RID: 28840
	[Token(Token = "0x40068A6")]
	[FieldOffset(Offset = "0x18")]
	public int Selectivity;

	// Token: 0x040070A9 RID: 28841
	[Token(Token = "0x40068A7")]
	[FieldOffset(Offset = "0x1C")]
	public GateStatusDataID GateStatusDataTableID;
}
