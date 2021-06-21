using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020007FB RID: 2043
[Token(Token = "0x2000542")]
[Serializable]
public class NpcPatrolPointData
{
	// Token: 0x06003668 RID: 13928 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D36")]
	[Address(RVA = "0x1F53680", Offset = "0x1F53781", VA = "0x1F53680")]
	public NpcPatrolPointData()
	{
	}

	// Token: 0x04007985 RID: 31109
	[Token(Token = "0x4006E17")]
	[FieldOffset(Offset = "0x10")]
	public Transform transform;

	// Token: 0x04007986 RID: 31110
	[Token(Token = "0x4006E18")]
	[FieldOffset(Offset = "0x18")]
	public string name;

	// Token: 0x04007987 RID: 31111
	[Token(Token = "0x4006E19")]
	[FieldOffset(Offset = "0x20")]
	public NpcController npc;

	// Token: 0x04007988 RID: 31112
	[Token(Token = "0x4006E1A")]
	[FieldOffset(Offset = "0x28")]
	public NpcPatrolRoute[] NpcPatrolRoutes;

	// Token: 0x04007989 RID: 31113
	[Token(Token = "0x4006E1B")]
	[FieldOffset(Offset = "0x30")]
	public float PatrolSpeed;

	// Token: 0x0400798A RID: 31114
	[Token(Token = "0x4006E1C")]
	[FieldOffset(Offset = "0x34")]
	public float WaitMinutes;

	// Token: 0x0400798B RID: 31115
	[Token(Token = "0x4006E1D")]
	[FieldOffset(Offset = "0x38")]
	public string doorName;

	// Token: 0x0400798C RID: 31116
	[Token(Token = "0x4006E1E")]
	[FieldOffset(Offset = "0x40")]
	public DoorType DoorType;

	// Token: 0x0400798D RID: 31117
	[Token(Token = "0x4006E1F")]
	[FieldOffset(Offset = "0x48")]
	public string WarpSceneName;

	// Token: 0x0400798E RID: 31118
	[Token(Token = "0x4006E20")]
	[FieldOffset(Offset = "0x50")]
	public string WarpTagetPointName;

	// Token: 0x0400798F RID: 31119
	[Token(Token = "0x4006E21")]
	[FieldOffset(Offset = "0x58")]
	public float arriveDistance;

	// Token: 0x04007990 RID: 31120
	[Token(Token = "0x4006E22")]
	[FieldOffset(Offset = "0x60")]
	public GameObject DoorObj;

	// Token: 0x04007991 RID: 31121
	[Token(Token = "0x4006E23")]
	[FieldOffset(Offset = "0x68")]
	public bool IsFree;

	// Token: 0x04007992 RID: 31122
	[Token(Token = "0x4006E24")]
	[FieldOffset(Offset = "0x6C")]
	public Gender Gender;

	// Token: 0x04007993 RID: 31123
	[Token(Token = "0x4006E25")]
	[FieldOffset(Offset = "0x70")]
	public bool Destination;
}
