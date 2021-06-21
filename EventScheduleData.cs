using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000446 RID: 1094
[Token(Token = "0x2000346")]
[Attribute(Name = "MessagePackObjectAttribute", RVA = "0x145CE0", Offset = "0x145DE1")]
[Serializable]
public class EventScheduleData
{
	// Token: 0x06001A82 RID: 6786 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600178C")]
	[Address(RVA = "0x21B6810", Offset = "0x21B6911", VA = "0x21B6810")]
	public void Initialize()
	{
	}

	// Token: 0x06001A83 RID: 6787 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600178D")]
	[Address(RVA = "0x21B69D0", Offset = "0x21B6AD1", VA = "0x21B69D0")]
	public long[] GetEventDateSetting(int eventStep)
	{
		return null;
	}

	// Token: 0x06001A84 RID: 6788 RVA: 0x0000B838 File Offset: 0x00009A38
	[Token(Token = "0x600178E")]
	[Address(RVA = "0x21B6E00", Offset = "0x21B6F01", VA = "0x21B6E00")]
	public bool IsEventOpen()
	{
		return default(bool);
	}

	// Token: 0x06001A85 RID: 6789 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600178F")]
	[Address(RVA = "0x21B6F90", Offset = "0x21B7091", VA = "0x21B6F90")]
	public void Proceed()
	{
	}

	// Token: 0x06001A86 RID: 6790 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001790")]
	[Address(RVA = "0x21B6FA0", Offset = "0x21B70A1", VA = "0x21B6FA0")]
	public void ProceedEventStep()
	{
	}

	// Token: 0x06001A87 RID: 6791 RVA: 0x0000B850 File Offset: 0x00009A50
	[Token(Token = "0x6001791")]
	[Address(RVA = "0x21B7510", Offset = "0x21B7611", VA = "0x21B7510")]
	public bool IsExistNpcId(int npcId)
	{
		return default(bool);
	}

	// Token: 0x06001A88 RID: 6792 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001792")]
	[Address(RVA = "0x21B7640", Offset = "0x21B7741", VA = "0x21B7640")]
	public void ResetEventStep()
	{
	}

	// Token: 0x06001A89 RID: 6793 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001793")]
	[Address(RVA = "0x21B7050", Offset = "0x21B7151", VA = "0x21B7050")]
	public void ResetNpcEventStep(long eventStep)
	{
	}

	// Token: 0x06001A8A RID: 6794 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001794")]
	[Address(RVA = "0x21B7060", Offset = "0x21B7161", VA = "0x21B7060")]
	public void LoadEventAction(long eventStep)
	{
	}

	// Token: 0x06001A8B RID: 6795 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001795")]
	[Address(RVA = "0x21B6800", Offset = "0x21B6901", VA = "0x21B6800")]
	public EventScheduleData()
	{
	}

	// Token: 0x04005D62 RID: 23906
	[Token(Token = "0x400599C")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "KeyAttribute", RVA = "0x163AF0", Offset = "0x163BF1")]
	[SerializeField]
	public int EventId;

	// Token: 0x04005D63 RID: 23907
	[Token(Token = "0x400599D")]
	[FieldOffset(Offset = "0x14")]
	[Attribute(Name = "KeyAttribute", RVA = "0x163B40", Offset = "0x163C41")]
	[SerializeField]
	public int EventStep;

	// Token: 0x04005D64 RID: 23908
	[Token(Token = "0x400599E")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "KeyAttribute", RVA = "0x163B90", Offset = "0x163C91")]
	[SerializeField]
	public EventTimer[] StartTime;

	// Token: 0x04005D65 RID: 23909
	[Token(Token = "0x400599F")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "KeyAttribute", RVA = "0x163BE0", Offset = "0x163CE1")]
	[SerializeField]
	public EventTimer[] EndTime;

	// Token: 0x04005D66 RID: 23910
	[Token(Token = "0x40059A0")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "KeyAttribute", RVA = "0x163C30", Offset = "0x163D31")]
	[SerializeField]
	public int JoinNpcNumMin;

	// Token: 0x04005D67 RID: 23911
	[Token(Token = "0x40059A1")]
	[FieldOffset(Offset = "0x2C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x163C80", Offset = "0x163D81")]
	[SerializeField]
	public int JoinNpcNumMax;

	// Token: 0x04005D68 RID: 23912
	[Token(Token = "0x40059A2")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "KeyAttribute", RVA = "0x163CD0", Offset = "0x163DD1")]
	[SerializeField]
	public IntArray[] JoinNpcs;

	// Token: 0x04005D69 RID: 23913
	[Token(Token = "0x40059A3")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "KeyAttribute", RVA = "0x163D20", Offset = "0x163E21")]
	[SerializeField]
	public IntArray[] JoinRateNpcs;

	// Token: 0x04005D6A RID: 23914
	[Token(Token = "0x40059A4")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "KeyAttribute", RVA = "0x163D70", Offset = "0x163E71")]
	[SerializeField]
	public List<int> DecideJoinNpcs;

	// Token: 0x04005D6B RID: 23915
	[Token(Token = "0x40059A5")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "KeyAttribute", RVA = "0x163DC0", Offset = "0x163EC1")]
	[SerializeField]
	public List<int> NpcScoreResults;

	// Token: 0x04005D6C RID: 23916
	[Token(Token = "0x40059A6")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "KeyAttribute", RVA = "0x163E10", Offset = "0x163F11")]
	[SerializeField]
	public EventData[] NpcEventDatas;

	// Token: 0x04005D6D RID: 23917
	[Token(Token = "0x40059A7")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "IgnoreMemberAttribute", RVA = "0x163E60", Offset = "0x163F61")]
	[SerializeField]
	public EventProceedRequirement[] EventProceedRequirement;
}
