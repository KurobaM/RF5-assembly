using System;
using Define;
using Il2CppDummyDll;

// Token: 0x02000441 RID: 1089
[Token(Token = "0x2000341")]
[Serializable]
public class EventPointData
{
	// Token: 0x06001A7D RID: 6781 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001787")]
	[Address(RVA = "0x21B5DF0", Offset = "0x21B5EF1", VA = "0x21B5DF0")]
	public EventPointData()
	{
	}

	// Token: 0x04005D51 RID: 23889
	[Token(Token = "0x400598B")]
	[FieldOffset(Offset = "0x10")]
	public EventScriptID ScriptId;

	// Token: 0x04005D52 RID: 23890
	[Token(Token = "0x400598C")]
	[FieldOffset(Offset = "0x14")]
	public EventPointID EventPointId;

	// Token: 0x04005D53 RID: 23891
	[Token(Token = "0x400598D")]
	[FieldOffset(Offset = "0x18")]
	public string SceneName;

	// Token: 0x04005D54 RID: 23892
	[Token(Token = "0x400598E")]
	[FieldOffset(Offset = "0x20")]
	public bool BossStartArea;

	// Token: 0x04005D55 RID: 23893
	[Token(Token = "0x400598F")]
	[FieldOffset(Offset = "0x24")]
	public float PosX;

	// Token: 0x04005D56 RID: 23894
	[Token(Token = "0x4005990")]
	[FieldOffset(Offset = "0x28")]
	public float PosY;

	// Token: 0x04005D57 RID: 23895
	[Token(Token = "0x4005991")]
	[FieldOffset(Offset = "0x2C")]
	public float PosZ;

	// Token: 0x04005D58 RID: 23896
	[Token(Token = "0x4005992")]
	[FieldOffset(Offset = "0x30")]
	public float ScaleX;

	// Token: 0x04005D59 RID: 23897
	[Token(Token = "0x4005993")]
	[FieldOffset(Offset = "0x34")]
	public float ScaleY;

	// Token: 0x04005D5A RID: 23898
	[Token(Token = "0x4005994")]
	[FieldOffset(Offset = "0x38")]
	public float ScaleZ;
}
