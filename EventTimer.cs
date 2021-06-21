using System;
using Define;
using Il2CppDummyDll;

// Token: 0x02000428 RID: 1064
[Token(Token = "0x2000334")]
[Attribute(Name = "MessagePackObjectAttribute", RVA = "0x145BE0", Offset = "0x145CE1")]
[Serializable]
public class EventTimer
{
	// Token: 0x060019DC RID: 6620 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001702")]
	[Address(RVA = "0x21BD000", Offset = "0x21BD101", VA = "0x21BD000")]
	public EventTimer()
	{
	}

	// Token: 0x04005CCD RID: 23757
	[Token(Token = "0x4005914")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "KeyAttribute", RVA = "0x162BD0", Offset = "0x162CD1")]
	public int Year;

	// Token: 0x04005CCE RID: 23758
	[Token(Token = "0x4005915")]
	[FieldOffset(Offset = "0x14")]
	[Attribute(Name = "KeyAttribute", RVA = "0x162C10", Offset = "0x162D11")]
	public Season Season;

	// Token: 0x04005CCF RID: 23759
	[Token(Token = "0x4005916")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "KeyAttribute", RVA = "0x162C50", Offset = "0x162D51")]
	public int Week;

	// Token: 0x04005CD0 RID: 23760
	[Token(Token = "0x4005917")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x162C90", Offset = "0x162D91")]
	public int Day;

	// Token: 0x04005CD1 RID: 23761
	[Token(Token = "0x4005918")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "KeyAttribute", RVA = "0x162CD0", Offset = "0x162DD1")]
	public int Hour;

	// Token: 0x04005CD2 RID: 23762
	[Token(Token = "0x4005919")]
	[FieldOffset(Offset = "0x24")]
	[Attribute(Name = "KeyAttribute", RVA = "0x162D10", Offset = "0x162E11")]
	public int Minutes;

	// Token: 0x04005CD3 RID: 23763
	[Token(Token = "0x400591A")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "KeyAttribute", RVA = "0x162D50", Offset = "0x162E51")]
	public Define.TimeZone TimeZone;

	// Token: 0x04005CD4 RID: 23764
	[Token(Token = "0x400591B")]
	[FieldOffset(Offset = "0x2C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x162D90", Offset = "0x162E91")]
	public Weather Weather;
}
