using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;

// Token: 0x0200042C RID: 1068
[Token(Token = "0x2000338")]
[Attribute(Name = "MessagePackObjectAttribute", RVA = "0x145C40", Offset = "0x145D41")]
public class EventSaveParameter
{
	// Token: 0x060019DE RID: 6622 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001704")]
	[Address(RVA = "0x21B63C0", Offset = "0x21B64C1", VA = "0x21B63C0")]
	public void Initialize()
	{
	}

	// Token: 0x060019DF RID: 6623 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001705")]
	[Address(RVA = "0x21B6940", Offset = "0x21B6A41", VA = "0x21B6940")]
	public EventSaveParameter()
	{
	}

	// Token: 0x04005CDF RID: 23775
	[Token(Token = "0x4005926")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "KeyAttribute", RVA = "0x162F50", Offset = "0x163051")]
	public int CurrentEventId;

	// Token: 0x04005CE0 RID: 23776
	[Token(Token = "0x4005927")]
	[FieldOffset(Offset = "0x14")]
	[Attribute(Name = "KeyAttribute", RVA = "0x162F90", Offset = "0x163091")]
	public int CurrentEventStep;

	// Token: 0x04005CE1 RID: 23777
	[Token(Token = "0x4005928")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "KeyAttribute", RVA = "0x162FD0", Offset = "0x1630D1")]
	public bool IsTalking;

	// Token: 0x04005CE2 RID: 23778
	[Token(Token = "0x4005929")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x163010", Offset = "0x163111")]
	public int SelectMenuGroupId;

	// Token: 0x04005CE3 RID: 23779
	[Token(Token = "0x400592A")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "KeyAttribute", RVA = "0x163050", Offset = "0x163151")]
	public bool IsSelectMenu;

	// Token: 0x04005CE4 RID: 23780
	[Token(Token = "0x400592B")]
	[FieldOffset(Offset = "0x24")]
	[Attribute(Name = "KeyAttribute", RVA = "0x163090", Offset = "0x163191")]
	public int TargetNpcId;

	// Token: 0x04005CE5 RID: 23781
	[Token(Token = "0x400592C")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "KeyAttribute", RVA = "0x1630D0", Offset = "0x1631D1")]
	public int[] OrderNpcIds;

	// Token: 0x04005CE6 RID: 23782
	[Token(Token = "0x400592D")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "KeyAttribute", RVA = "0x163110", Offset = "0x163211")]
	public string ForceScriptName;

	// Token: 0x04005CE7 RID: 23783
	[Token(Token = "0x400592E")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "KeyAttribute", RVA = "0x163150", Offset = "0x163251")]
	public bool ForceEvent;

	// Token: 0x04005CE8 RID: 23784
	[Token(Token = "0x400592F")]
	[FieldOffset(Offset = "0x3C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x163190", Offset = "0x163291")]
	public int orderOccuredId;

	// Token: 0x04005CE9 RID: 23785
	[Token(Token = "0x4005930")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "KeyAttribute", RVA = "0x1631D0", Offset = "0x1632D1")]
	public EventScheduleData[] EventScheduleDatas;

	// Token: 0x04005CEA RID: 23786
	[Token(Token = "0x4005931")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "KeyAttribute", RVA = "0x163210", Offset = "0x163311")]
	public int bythewayMenuCommandNo;

	// Token: 0x04005CEB RID: 23787
	[Token(Token = "0x4005932")]
	[FieldOffset(Offset = "0x4C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x163250", Offset = "0x163351")]
	public int bythewayEventStep;

	// Token: 0x04005CEC RID: 23788
	[Token(Token = "0x4005933")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "KeyAttribute", RVA = "0x163290", Offset = "0x163391")]
	public bool Is1stBytheWay;

	// Token: 0x04005CED RID: 23789
	[Token(Token = "0x4005934")]
	[FieldOffset(Offset = "0x54")]
	[Attribute(Name = "KeyAttribute", RVA = "0x1632D0", Offset = "0x1633D1")]
	public int partnerMenuCommandNo;

	// Token: 0x04005CEE RID: 23790
	[Token(Token = "0x4005935")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "KeyAttribute", RVA = "0x163310", Offset = "0x163411")]
	public int partnerEventStep;

	// Token: 0x04005CEF RID: 23791
	[Token(Token = "0x4005936")]
	[FieldOffset(Offset = "0x5C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x163350", Offset = "0x163451")]
	public int eventValue;

	// Token: 0x04005CF0 RID: 23792
	[Token(Token = "0x4005937")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "KeyAttribute", RVA = "0x163390", Offset = "0x163491")]
	public bool UseRetentionEventType;

	// Token: 0x04005CF1 RID: 23793
	[Token(Token = "0x4005938")]
	[FieldOffset(Offset = "0x68")]
	[Attribute(Name = "KeyAttribute", RVA = "0x1633D0", Offset = "0x1634D1")]
	public List<EventUnlockFlagData> ReservedEventStartPoints;

	// Token: 0x04005CF2 RID: 23794
	[Token(Token = "0x4005939")]
	[FieldOffset(Offset = "0x70")]
	[Attribute(Name = "KeyAttribute", RVA = "0x163410", Offset = "0x163511")]
	public Place NowPlace;

	// Token: 0x04005CF3 RID: 23795
	[Token(Token = "0x400593A")]
	[FieldOffset(Offset = "0x74")]
	[Attribute(Name = "KeyAttribute", RVA = "0x163450", Offset = "0x163551")]
	public int FlagTalkIndex;

	// Token: 0x04005CF4 RID: 23796
	[Token(Token = "0x400593B")]
	[FieldOffset(Offset = "0x78")]
	[Attribute(Name = "KeyAttribute", RVA = "0x163490", Offset = "0x163591")]
	public bool IsSleepScriptCalled;

	// Token: 0x04005CF5 RID: 23797
	[Token(Token = "0x400593C")]
	[FieldOffset(Offset = "0x79")]
	[Attribute(Name = "KeyAttribute", RVA = "0x1634D0", Offset = "0x1635D1")]
	public bool IsWakeUpReserve;

	// Token: 0x04005CF6 RID: 23798
	[Token(Token = "0x400593D")]
	[FieldOffset(Offset = "0x80")]
	[Attribute(Name = "KeyAttribute", RVA = "0x163510", Offset = "0x163611")]
	public bool[] EventCheckTypeFlag;

	// Token: 0x04005CF7 RID: 23799
	[Token(Token = "0x400593E")]
	[FieldOffset(Offset = "0x88")]
	[Attribute(Name = "KeyAttribute", RVA = "0x163550", Offset = "0x163651")]
	public int[] EventCheckType;

	// Token: 0x04005CF8 RID: 23800
	[Token(Token = "0x400593F")]
	[FieldOffset(Offset = "0x90")]
	[Attribute(Name = "KeyAttribute", RVA = "0x163590", Offset = "0x163691")]
	public List<EventCheckId> EventCheckIds;

	// Token: 0x04005CF9 RID: 23801
	[Token(Token = "0x4005940")]
	[FieldOffset(Offset = "0x98")]
	[Attribute(Name = "KeyAttribute", RVA = "0x1635D0", Offset = "0x1636D1")]
	public NpcEventType NowType;

	// Token: 0x04005CFA RID: 23802
	[Token(Token = "0x4005941")]
	[FieldOffset(Offset = "0xA0")]
	[Attribute(Name = "KeyAttribute", RVA = "0x163610", Offset = "0x163711")]
	public int[] LastYearFesVictoryNpcId;

	// Token: 0x04005CFB RID: 23803
	[Token(Token = "0x4005942")]
	[FieldOffset(Offset = "0xA8")]
	[Attribute(Name = "KeyAttribute", RVA = "0x163650", Offset = "0x163751")]
	public bool SP4CharaOn;
}
