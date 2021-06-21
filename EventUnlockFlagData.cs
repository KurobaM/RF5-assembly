using System;
using Define;
using Field;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200044A RID: 1098
[Token(Token = "0x200034A")]
[Attribute(Name = "MessagePackObjectAttribute", RVA = "0x145D10", Offset = "0x145E11")]
[Serializable]
public class EventUnlockFlagData
{
	// Token: 0x06001A9F RID: 6815 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017A9")]
	[Address(RVA = "0x21BD020", Offset = "0x21BD121", VA = "0x21BD020")]
	public EventUnlockFlagData Clone()
	{
		return null;
	}

	// Token: 0x06001AA0 RID: 6816 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017AA")]
	[Address(RVA = "0x21BD0B0", Offset = "0x21BD1B1", VA = "0x21BD0B0")]
	public EventUnlockFlagData()
	{
	}

	// Token: 0x04005D83 RID: 23939
	[Token(Token = "0x40059BD")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "KeyAttribute", RVA = "0x163F40", Offset = "0x164041")]
	[SerializeField]
	public EventScriptID ScriptId;

	// Token: 0x04005D84 RID: 23940
	[Token(Token = "0x40059BE")]
	[FieldOffset(Offset = "0x14")]
	[Attribute(Name = "KeyAttribute", RVA = "0x163F90", Offset = "0x164091")]
	[SerializeField]
	public EventPointID EventPointId;

	// Token: 0x04005D85 RID: 23941
	[Token(Token = "0x40059BF")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "KeyAttribute", RVA = "0x163FE0", Offset = "0x1640E1")]
	[SerializeField]
	public EventCheckType eventCheckType;

	// Token: 0x04005D86 RID: 23942
	[Token(Token = "0x40059C0")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "KeyAttribute", RVA = "0x164030", Offset = "0x164131")]
	[SerializeField]
	public long EventStartDay;

	// Token: 0x04005D87 RID: 23943
	[Token(Token = "0x40059C1")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "KeyAttribute", RVA = "0x164080", Offset = "0x164181")]
	[SerializeField]
	public int EventStartTime;

	// Token: 0x04005D88 RID: 23944
	[Token(Token = "0x40059C2")]
	[FieldOffset(Offset = "0x2C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x1640D0", Offset = "0x1641D1")]
	[SerializeField]
	public int EventEndTime;

	// Token: 0x04005D89 RID: 23945
	[Token(Token = "0x40059C3")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "KeyAttribute", RVA = "0x164120", Offset = "0x164221")]
	[SerializeField]
	public IconType IconType;

	// Token: 0x04005D8A RID: 23946
	[Token(Token = "0x40059C4")]
	[FieldOffset(Offset = "0x34")]
	[Attribute(Name = "KeyAttribute", RVA = "0x164170", Offset = "0x164271")]
	[SerializeField]
	public IconViewType IconViewType;

	// Token: 0x04005D8B RID: 23947
	[Token(Token = "0x40059C5")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "KeyAttribute", RVA = "0x1641C0", Offset = "0x1642C1")]
	[SerializeField]
	public GameFlagData PointOnFlag;

	// Token: 0x04005D8C RID: 23948
	[Token(Token = "0x40059C6")]
	[FieldOffset(Offset = "0x3C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x164210", Offset = "0x164311")]
	[SerializeField]
	public GameFlagData StoryFlag;

	// Token: 0x04005D8D RID: 23949
	[Token(Token = "0x40059C7")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "KeyAttribute", RVA = "0x164260", Offset = "0x164361")]
	[SerializeField]
	public GameFlagData DeleteEventPointFlag;

	// Token: 0x04005D8E RID: 23950
	[Token(Token = "0x40059C8")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "KeyAttribute", RVA = "0x1642B0", Offset = "0x1643B1")]
	[SerializeField]
	public GameFlagData[] On;

	// Token: 0x04005D8F RID: 23951
	[Token(Token = "0x40059C9")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "KeyAttribute", RVA = "0x164300", Offset = "0x164401")]
	[SerializeField]
	public GameFlagData[] Off;

	// Token: 0x04005D90 RID: 23952
	[Token(Token = "0x40059CA")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "KeyAttribute", RVA = "0x164350", Offset = "0x164451")]
	[SerializeField]
	public GameFlagData[] NpcOn;

	// Token: 0x04005D91 RID: 23953
	[Token(Token = "0x40059CB")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "KeyAttribute", RVA = "0x1643A0", Offset = "0x1644A1")]
	[SerializeField]
	public GameFlagData[] NpcOff;

	// Token: 0x04005D92 RID: 23954
	[Token(Token = "0x40059CC")]
	[FieldOffset(Offset = "0x68")]
	[Attribute(Name = "KeyAttribute", RVA = "0x1643F0", Offset = "0x1644F1")]
	[SerializeField]
	public GameFlagData[] FlagOn;

	// Token: 0x04005D93 RID: 23955
	[Token(Token = "0x40059CD")]
	[FieldOffset(Offset = "0x70")]
	[Attribute(Name = "KeyAttribute", RVA = "0x164440", Offset = "0x164541")]
	[SerializeField]
	public GameFlagData[] FlagOff;

	// Token: 0x04005D94 RID: 23956
	[Token(Token = "0x40059CE")]
	[FieldOffset(Offset = "0x78")]
	[Attribute(Name = "KeyAttribute", RVA = "0x164490", Offset = "0x164591")]
	[SerializeField]
	public bool PointActive;

	// Token: 0x04005D95 RID: 23957
	[Token(Token = "0x40059CF")]
	[FieldOffset(Offset = "0x7C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x1644E0", Offset = "0x1645E1")]
	[SerializeField]
	public FieldSceneId SceneId;

	// Token: 0x04005D96 RID: 23958
	[Token(Token = "0x40059D0")]
	[FieldOffset(Offset = "0x80")]
	[Attribute(Name = "KeyAttribute", RVA = "0x164530", Offset = "0x164631")]
	[SerializeField]
	public float PosX;

	// Token: 0x04005D97 RID: 23959
	[Token(Token = "0x40059D1")]
	[FieldOffset(Offset = "0x84")]
	[Attribute(Name = "KeyAttribute", RVA = "0x164580", Offset = "0x164681")]
	[SerializeField]
	public float PosY;

	// Token: 0x04005D98 RID: 23960
	[Token(Token = "0x40059D2")]
	[FieldOffset(Offset = "0x88")]
	[Attribute(Name = "KeyAttribute", RVA = "0x1645D0", Offset = "0x1646D1")]
	[SerializeField]
	public float PosZ;
}
