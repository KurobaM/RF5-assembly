using System;
using Define;
using Il2CppDummyDll;

// Token: 0x02000457 RID: 1111
[Token(Token = "0x2000354")]
[Serializable]
public class MainEventFlagProgressData
{
	// Token: 0x06001AE7 RID: 6887 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017F1")]
	[Address(RVA = "0x1F16850", Offset = "0x1F16951", VA = "0x1F16850")]
	public MainEventFlagProgressData()
	{
	}

	// Token: 0x04005DE3 RID: 24035
	[Token(Token = "0x40059F2")]
	[FieldOffset(Offset = "0x10")]
	public int ScenarioNo;

	// Token: 0x04005DE4 RID: 24036
	[Token(Token = "0x40059F3")]
	[FieldOffset(Offset = "0x14")]
	public GameFlagData FlagId;

	// Token: 0x04005DE5 RID: 24037
	[Token(Token = "0x40059F4")]
	[FieldOffset(Offset = "0x18")]
	public int OnOff;

	// Token: 0x04005DE6 RID: 24038
	[Token(Token = "0x40059F5")]
	[FieldOffset(Offset = "0x1C")]
	public int Value;
}
