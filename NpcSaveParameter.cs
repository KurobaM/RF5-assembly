using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020007EC RID: 2028
[Token(Token = "0x200053F")]
[Attribute(Name = "MessagePackObjectAttribute", RVA = "0x1462D0", Offset = "0x1463D1")]
public class NpcSaveParameter
{
	// Token: 0x06003505 RID: 13573 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002C13")]
	[Address(RVA = "0x1F53CB0", Offset = "0x1F53DB1", VA = "0x1F53CB0")]
	public void Initialize()
	{
	}

	// Token: 0x06003506 RID: 13574 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002C14")]
	[Address(RVA = "0x1F53DD0", Offset = "0x1F53ED1", VA = "0x1F53DD0")]
	public NpcSaveParameter()
	{
	}

	// Token: 0x040078B3 RID: 30899
	[Token(Token = "0x4006D73")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16A050", Offset = "0x16A151")]
	public Vector3 SavePosition;

	// Token: 0x040078B4 RID: 30900
	[Token(Token = "0x4006D74")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16A090", Offset = "0x16A191")]
	public Quaternion SaveRotation;

	// Token: 0x040078B5 RID: 30901
	[Token(Token = "0x4006D75")]
	[FieldOffset(Offset = "0x2C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16A0D0", Offset = "0x16A1D1")]
	public bool forceDisabled;

	// Token: 0x040078B6 RID: 30902
	[Token(Token = "0x4006D76")]
	[FieldOffset(Offset = "0x2D")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16A110", Offset = "0x16A211")]
	public bool isShortPlay;

	// Token: 0x040078B7 RID: 30903
	[Token(Token = "0x4006D77")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16A150", Offset = "0x16A251")]
	public NpcAnimState AnimationState;

	// Token: 0x040078B8 RID: 30904
	[Token(Token = "0x4006D78")]
	[FieldOffset(Offset = "0x34")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16A190", Offset = "0x16A291")]
	public bool AnimationSitting;

	// Token: 0x040078B9 RID: 30905
	[Token(Token = "0x4006D79")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16A1D0", Offset = "0x16A2D1")]
	public int NpcGroupId;

	// Token: 0x040078BA RID: 30906
	[Token(Token = "0x4006D7A")]
	[FieldOffset(Offset = "0x3C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16A210", Offset = "0x16A311")]
	public FieldPlaceId CurrentFieldPlaceId;

	// Token: 0x040078BB RID: 30907
	[Token(Token = "0x4006D7B")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16A250", Offset = "0x16A351")]
	public LifecycleState CurrentLifecycleState;

	// Token: 0x040078BC RID: 30908
	[Token(Token = "0x4006D7C")]
	[FieldOffset(Offset = "0x44")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16A290", Offset = "0x16A391")]
	public Place CurrentPlace;

	// Token: 0x040078BD RID: 30909
	[Token(Token = "0x4006D7D")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16A2D0", Offset = "0x16A3D1")]
	public int RotatePatternNumber;

	// Token: 0x040078BE RID: 30910
	[Token(Token = "0x4006D7E")]
	[FieldOffset(Offset = "0x4C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16A310", Offset = "0x16A411")]
	public bool IsTalking;

	// Token: 0x040078BF RID: 30911
	[Token(Token = "0x4006D7F")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16A350", Offset = "0x16A451")]
	public int TodayTalkCount;

	// Token: 0x040078C0 RID: 30912
	[Token(Token = "0x4006D80")]
	[FieldOffset(Offset = "0x54")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16A390", Offset = "0x16A491")]
	public int NowEventId;

	// Token: 0x040078C1 RID: 30913
	[Token(Token = "0x4006D81")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16A3D0", Offset = "0x16A4D1")]
	public Place Home;

	// Token: 0x040078C2 RID: 30914
	[Token(Token = "0x4006D82")]
	[FieldOffset(Offset = "0x5C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16A410", Offset = "0x16A511")]
	public Place Job;

	// Token: 0x040078C3 RID: 30915
	[Token(Token = "0x4006D83")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16A450", Offset = "0x16A551")]
	public bool IsPartner;

	// Token: 0x040078C4 RID: 30916
	[Token(Token = "0x4006D84")]
	[FieldOffset(Offset = "0x61")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16A490", Offset = "0x16A591")]
	public bool IsSpouses;

	// Token: 0x040078C5 RID: 30917
	[Token(Token = "0x4006D85")]
	[FieldOffset(Offset = "0x62")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16A4D0", Offset = "0x16A5D1")]
	public bool IsLover;

	// Token: 0x040078C6 RID: 30918
	[Token(Token = "0x4006D86")]
	[FieldOffset(Offset = "0x63")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16A510", Offset = "0x16A611")]
	public bool IsRefused;

	// Token: 0x040078C7 RID: 30919
	[Token(Token = "0x4006D87")]
	[FieldOffset(Offset = "0x64")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16A550", Offset = "0x16A651")]
	public bool IsJealousy;

	// Token: 0x040078C8 RID: 30920
	[Token(Token = "0x4006D88")]
	[FieldOffset(Offset = "0x65")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16A590", Offset = "0x16A691")]
	public bool IsDateRefrain;

	// Token: 0x040078C9 RID: 30921
	[Token(Token = "0x4006D89")]
	[FieldOffset(Offset = "0x66")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16A5D0", Offset = "0x16A6D1")]
	public bool IsExclamation;

	// Token: 0x040078CA RID: 30922
	[Token(Token = "0x4006D8A")]
	[FieldOffset(Offset = "0x68")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16A610", Offset = "0x16A711")]
	public int AngryStep;

	// Token: 0x040078CB RID: 30923
	[Token(Token = "0x4006D8B")]
	[FieldOffset(Offset = "0x6C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16A650", Offset = "0x16A751")]
	public int LovePoint;

	// Token: 0x040078CC RID: 30924
	[Token(Token = "0x4006D8C")]
	[FieldOffset(Offset = "0x70")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16A690", Offset = "0x16A791")]
	public int DatingNum;

	// Token: 0x040078CD RID: 30925
	[Token(Token = "0x4006D8D")]
	[FieldOffset(Offset = "0x74")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16A6D0", Offset = "0x16A7D1")]
	public int PresentCount;

	// Token: 0x040078CE RID: 30926
	[Token(Token = "0x4006D8E")]
	[FieldOffset(Offset = "0x78")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16A710", Offset = "0x16A811")]
	public int NickNameToPlayerId;

	// Token: 0x040078CF RID: 30927
	[Token(Token = "0x4006D8F")]
	[FieldOffset(Offset = "0x7C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16A750", Offset = "0x16A851")]
	public int NickNameFromPlayerId;

	// Token: 0x040078D0 RID: 30928
	[Token(Token = "0x4006D90")]
	[FieldOffset(Offset = "0x80")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16A790", Offset = "0x16A891")]
	public int WeddingAnniversary;

	// Token: 0x040078D1 RID: 30929
	[Token(Token = "0x4006D91")]
	[FieldOffset(Offset = "0x88")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16A7D0", Offset = "0x16A8D1")]
	public List<LovePointManager.FavoriteType> PresentItemTypes;

	// Token: 0x040078D2 RID: 30930
	[Token(Token = "0x4006D92")]
	[FieldOffset(Offset = "0x90")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16A810", Offset = "0x16A911")]
	public bool IsVoiceSleepPlayed;

	// Token: 0x040078D3 RID: 30931
	[Token(Token = "0x4006D93")]
	[FieldOffset(Offset = "0x91")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16A850", Offset = "0x16A951")]
	public bool IsVoiceGreeted;

	// Token: 0x040078D4 RID: 30932
	[Token(Token = "0x4006D94")]
	[FieldOffset(Offset = "0x98")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16A890", Offset = "0x16A991")]
	public long[] TalkedTime;

	// Token: 0x040078D5 RID: 30933
	[Token(Token = "0x4006D95")]
	[FieldOffset(Offset = "0xA0")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16A8D0", Offset = "0x16A9D1")]
	public int FriendlyMilestoneTalk;

	// Token: 0x040078D6 RID: 30934
	[Token(Token = "0x4006D96")]
	[FieldOffset(Offset = "0xA4")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16A910", Offset = "0x16AA11")]
	public int ChatTalkLv;

	// Token: 0x040078D7 RID: 30935
	[Token(Token = "0x4006D97")]
	[FieldOffset(Offset = "0xA8")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16A950", Offset = "0x16AA51")]
	public int ChatTalkCount;

	// Token: 0x040078D8 RID: 30936
	[Token(Token = "0x4006D98")]
	[FieldOffset(Offset = "0xAC")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16A990", Offset = "0x16AA91")]
	public int ChatTalkLotteryType;

	// Token: 0x040078D9 RID: 30937
	[Token(Token = "0x4006D99")]
	[FieldOffset(Offset = "0xB0")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16A9D0", Offset = "0x16AAD1")]
	public int ChatTalkLotteryID;

	// Token: 0x040078DA RID: 30938
	[Token(Token = "0x4006D9A")]
	[FieldOffset(Offset = "0xB4")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16AA10", Offset = "0x16AB11")]
	public int HomeTalkedLv;

	// Token: 0x040078DB RID: 30939
	[Token(Token = "0x4006D9B")]
	[FieldOffset(Offset = "0xB8")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16AA50", Offset = "0x16AB51")]
	public VariationNo ModelType;

	// Token: 0x040078DC RID: 30940
	[Token(Token = "0x4006D9C")]
	[FieldOffset(Offset = "0xBC")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16AA90", Offset = "0x16AB91")]
	public int LoveStroyState;

	// Token: 0x040078DD RID: 30941
	[Token(Token = "0x4006D9D")]
	[FieldOffset(Offset = "0xC0")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16AAD0", Offset = "0x16ABD1")]
	public int FlowerFesDateNum;

	// Token: 0x040078DE RID: 30942
	[Token(Token = "0x4006D9E")]
	[FieldOffset(Offset = "0xC4")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16AB10", Offset = "0x16AC11")]
	public bool IsDateReserved;

	// Token: 0x040078DF RID: 30943
	[Token(Token = "0x4006D9F")]
	[FieldOffset(Offset = "0xC8")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16AB50", Offset = "0x16AC51")]
	public int dateDay;
}
