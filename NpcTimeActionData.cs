using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000807 RID: 2055
[Token(Token = "0x200054D")]
[Serializable]
public class NpcTimeActionData
{
	// Token: 0x170007A8 RID: 1960
	// (get) Token: 0x060036C1 RID: 14017 RVA: 0x00012E28 File Offset: 0x00011028
	[Token(Token = "0x170005F5")]
	public bool IsHomeBack
	{
		[Token(Token = "0x6002D89")]
		[Address(RVA = "0x1F55840", Offset = "0x1F55941", VA = "0x1F55840")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060036C2 RID: 14018 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002D8A")]
	[Address(RVA = "0x1F55850", Offset = "0x1F55951", VA = "0x1F55850")]
	public NpcPatrolPoint GetTargetPoint()
	{
		return null;
	}

	// Token: 0x060036C3 RID: 14019 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D8B")]
	[Address(RVA = "0x1F4D310", Offset = "0x1F4D411", VA = "0x1F4D310")]
	public NpcTimeActionData()
	{
	}

	// Token: 0x040079C6 RID: 31174
	[Token(Token = "0x4006E55")]
	[FieldOffset(Offset = "0x10")]
	public string[] PatrolPoints;

	// Token: 0x040079C7 RID: 31175
	[Token(Token = "0x4006E56")]
	[FieldOffset(Offset = "0x18")]
	public NpcPatrolPoint JobPatrolPoint;

	// Token: 0x040079C8 RID: 31176
	[Token(Token = "0x4006E57")]
	[FieldOffset(Offset = "0x20")]
	public NpcPatrolPoint SeatPatrolPoint;

	// Token: 0x040079C9 RID: 31177
	[Token(Token = "0x4006E58")]
	[FieldOffset(Offset = "0x28")]
	public NpcPatrolPoint BedPatrolPoint;

	// Token: 0x040079CA RID: 31178
	[Token(Token = "0x4006E59")]
	[FieldOffset(Offset = "0x30")]
	public string DoorPatrolPointName;

	// Token: 0x040079CB RID: 31179
	[Token(Token = "0x4006E5A")]
	[FieldOffset(Offset = "0x38")]
	public string TargetDoorPatrolPointName;

	// Token: 0x040079CC RID: 31180
	[Token(Token = "0x4006E5B")]
	[FieldOffset(Offset = "0x40")]
	public NpcPatrolPoint CurrentPatrolPoint;

	// Token: 0x040079CD RID: 31181
	[Token(Token = "0x4006E5C")]
	[FieldOffset(Offset = "0x48")]
	public Place CurrentPlace;

	// Token: 0x040079CE RID: 31182
	[Token(Token = "0x4006E5D")]
	[FieldOffset(Offset = "0x4C")]
	public Place TargetPlace;

	// Token: 0x040079CF RID: 31183
	[Token(Token = "0x4006E5E")]
	[FieldOffset(Offset = "0x50")]
	public bool IsReached;

	// Token: 0x040079D0 RID: 31184
	[Token(Token = "0x4006E5F")]
	[FieldOffset(Offset = "0x54")]
	public LifecycleState CurrentLifecycleState;

	// Token: 0x040079D1 RID: 31185
	[Token(Token = "0x4006E60")]
	[FieldOffset(Offset = "0x58")]
	public int CurrentPositionIndex;

	// Token: 0x040079D2 RID: 31186
	[Token(Token = "0x4006E61")]
	[FieldOffset(Offset = "0x5C")]
	public bool IsWaitNextAction;

	// Token: 0x040079D3 RID: 31187
	[Token(Token = "0x4006E62")]
	[FieldOffset(Offset = "0x60")]
	public Vector3 targetPosition;

	// Token: 0x040079D4 RID: 31188
	[Token(Token = "0x4006E63")]
	[FieldOffset(Offset = "0x70")]
	public GameObject NextPatrolPoint;

	// Token: 0x040079D5 RID: 31189
	[Token(Token = "0x4006E64")]
	[FieldOffset(Offset = "0x78")]
	public Vector3[] positions;

	// Token: 0x040079D6 RID: 31190
	[Token(Token = "0x4006E65")]
	[FieldOffset(Offset = "0x80")]
	public string[] pointNames;

	// Token: 0x040079D7 RID: 31191
	[Token(Token = "0x4006E66")]
	[FieldOffset(Offset = "0x88")]
	public Weather HomeBackWeather;

	// Token: 0x040079D8 RID: 31192
	[Token(Token = "0x4006E67")]
	[FieldOffset(Offset = "0x8C")]
	public int RotatePatternNumber;

	// Token: 0x040079D9 RID: 31193
	[Token(Token = "0x4006E68")]
	[FieldOffset(Offset = "0x90")]
	public bool IsOvertime;
}
