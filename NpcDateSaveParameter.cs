using System;
using Define;
using Il2CppDummyDll;

// Token: 0x02000422 RID: 1058
[Token(Token = "0x200032E")]
[Attribute(Name = "MessagePackObjectAttribute", RVA = "0x145BA0", Offset = "0x145CA1")]
public class NpcDateSaveParameter
{
	// Token: 0x060019BF RID: 6591 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016E5")]
	[Address(RVA = "0x1F45DE0", Offset = "0x1F45EE1", VA = "0x1F45DE0")]
	public NpcDateSaveParameter()
	{
	}

	// Token: 0x060019C0 RID: 6592 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016E6")]
	[Address(RVA = "0x1F46580", Offset = "0x1F46681", VA = "0x1F46580")]
	public void Init()
	{
	}

	// Token: 0x060019C1 RID: 6593 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60016E7")]
	[Address(RVA = "0x1F465A0", Offset = "0x1F466A1", VA = "0x1F465A0")]
	public string GetDateMeetingPlace()
	{
		return null;
	}

	// Token: 0x060019C2 RID: 6594 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60016E8")]
	[Address(RVA = "0x1F46A60", Offset = "0x1F46B61", VA = "0x1F46A60")]
	public string GetDateSpotName()
	{
		return null;
	}

	// Token: 0x060019C3 RID: 6595 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016E9")]
	[Address(RVA = "0x1F47410", Offset = "0x1F47511", VA = "0x1F47410")]
	public void ReserveDate(int _npcId, DateType _type, DateSpotID _spot, int _startTime, int _limitTime, GameFlagData _flag, bool _doSuppo)
	{
	}

	// Token: 0x060019C4 RID: 6596 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016EA")]
	[Address(RVA = "0x1F47600", Offset = "0x1F47701", VA = "0x1F47600")]
	public void ClearReserveDate()
	{
	}

	// Token: 0x04005CBD RID: 23741
	[Token(Token = "0x4005904")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "KeyAttribute", RVA = "0x1629D0", Offset = "0x162AD1")]
	public DatProgressType ProgressType;

	// Token: 0x04005CBE RID: 23742
	[Token(Token = "0x4005905")]
	[FieldOffset(Offset = "0x14")]
	[Attribute(Name = "KeyAttribute", RVA = "0x162A10", Offset = "0x162B11")]
	public DateType dateType;

	// Token: 0x04005CBF RID: 23743
	[Token(Token = "0x4005906")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "KeyAttribute", RVA = "0x162A50", Offset = "0x162B51")]
	public DateSpotID dateSpotID;

	// Token: 0x04005CC0 RID: 23744
	[Token(Token = "0x4005907")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x162A90", Offset = "0x162B91")]
	public int NpcId;

	// Token: 0x04005CC1 RID: 23745
	[Token(Token = "0x4005908")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "KeyAttribute", RVA = "0x162AD0", Offset = "0x162BD1")]
	public int dateStartTime;

	// Token: 0x04005CC2 RID: 23746
	[Token(Token = "0x4005909")]
	[FieldOffset(Offset = "0x24")]
	[Attribute(Name = "KeyAttribute", RVA = "0x162B10", Offset = "0x162C11")]
	public int meetingLimitTime;

	// Token: 0x04005CC3 RID: 23747
	[Token(Token = "0x400590A")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "KeyAttribute", RVA = "0x162B50", Offset = "0x162C51")]
	public int meetingEventPointOnFlag;

	// Token: 0x04005CC4 RID: 23748
	[Token(Token = "0x400590B")]
	[FieldOffset(Offset = "0x2C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x162B90", Offset = "0x162C91")]
	public bool doSuppo;

	// Token: 0x04005CC5 RID: 23749
	[Token(Token = "0x400590C")]
	[FieldOffset(Offset = "0x0")]
	private static string[] SpotNameIdTable;

	// Token: 0x04005CC6 RID: 23750
	[Token(Token = "0x400590D")]
	[FieldOffset(Offset = "0x8")]
	private static bool isSpotNameInitialized;
}
