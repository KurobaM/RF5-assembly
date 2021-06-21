using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;

// Token: 0x02000867 RID: 2151
[Token(Token = "0x200058B")]
[Serializable]
public class AreaData
{
	// Token: 0x060038FC RID: 14588 RVA: 0x00013C20 File Offset: 0x00011E20
	[Token(Token = "0x6002F80")]
	[Address(RVA = "0x243D7E0", Offset = "0x243D8E1", VA = "0x243D7E0")]
	public int GetCapacity()
	{
		return 0;
	}

	// Token: 0x060038FD RID: 14589 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002F81")]
	[Address(RVA = "0x243D7F0", Offset = "0x243D8F1", VA = "0x243D7F0")]
	public void FreeAllPoints()
	{
	}

	// Token: 0x060038FE RID: 14590 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F82")]
	[Address(RVA = "0x243DC80", Offset = "0x243DD81", VA = "0x243DC80")]
	public NpcPatrolPointData GetBedPatrolPoint()
	{
		return null;
	}

	// Token: 0x060038FF RID: 14591 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002F83")]
	[Address(RVA = "0x243DD90", Offset = "0x243DE91", VA = "0x243DD90")]
	public void ClearBedPatrolPoint(NpcPatrolPointData pp)
	{
	}

	// Token: 0x06003900 RID: 14592 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F84")]
	[Address(RVA = "0x243DDB0", Offset = "0x243DEB1", VA = "0x243DDB0")]
	public NpcPatrolPointData GetJobPatrolPoint()
	{
		return null;
	}

	// Token: 0x06003901 RID: 14593 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F85")]
	[Address(RVA = "0x243DEC0", Offset = "0x243DFC1", VA = "0x243DEC0")]
	public NpcPatrolPointData GetWaitJobPatrolPoint()
	{
		return null;
	}

	// Token: 0x06003902 RID: 14594 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002F86")]
	[Address(RVA = "0x243DFD0", Offset = "0x243E0D1", VA = "0x243DFD0")]
	public void ClearJobPatrolPoint(NpcPatrolPointData pp)
	{
	}

	// Token: 0x06003903 RID: 14595 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F87")]
	[Address(RVA = "0x243DFF0", Offset = "0x243E0F1", VA = "0x243DFF0")]
	public NpcPatrolPointData GetSeatPatrolPoint()
	{
		return null;
	}

	// Token: 0x06003904 RID: 14596 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F88")]
	[Address(RVA = "0x243E120", Offset = "0x243E221", VA = "0x243E120")]
	public NpcPatrolPointData GetBathPatrolPoint(Gender gender)
	{
		return null;
	}

	// Token: 0x06003905 RID: 14597 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F89")]
	[Address(RVA = "0x243E250", Offset = "0x243E351", VA = "0x243E250")]
	public NpcPatrolPointData GetWaitSeatPatrolPoint()
	{
		return null;
	}

	// Token: 0x06003906 RID: 14598 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002F8A")]
	[Address(RVA = "0x243E360", Offset = "0x243E461", VA = "0x243E360")]
	public void ClearSeatPatrolPoint(NpcPatrolPointData pp)
	{
	}

	// Token: 0x06003907 RID: 14599 RVA: 0x00013C38 File Offset: 0x00011E38
	[Token(Token = "0x6002F8B")]
	[Address(RVA = "0x243E380", Offset = "0x243E481", VA = "0x243E380")]
	public bool IsAvailable()
	{
		return default(bool);
	}

	// Token: 0x06003908 RID: 14600 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002F8C")]
	[Address(RVA = "0x243D7C0", Offset = "0x243D8C1", VA = "0x243D7C0")]
	public AreaData()
	{
	}

	// Token: 0x04007C49 RID: 31817
	[Token(Token = "0x400705C")]
	[FieldOffset(Offset = "0x10")]
	public List<NpcPatrolPointData> JobPatrolPoints;

	// Token: 0x04007C4A RID: 31818
	[Token(Token = "0x400705D")]
	[FieldOffset(Offset = "0x18")]
	public List<NpcPatrolPointData> WaitJobPatrolPoints;

	// Token: 0x04007C4B RID: 31819
	[Token(Token = "0x400705E")]
	[FieldOffset(Offset = "0x20")]
	public List<NpcPatrolPointData> SeatPatrolPoints;

	// Token: 0x04007C4C RID: 31820
	[Token(Token = "0x400705F")]
	[FieldOffset(Offset = "0x28")]
	public List<NpcPatrolPointData> WaitSeatPatrolPoints;

	// Token: 0x04007C4D RID: 31821
	[Token(Token = "0x4007060")]
	[FieldOffset(Offset = "0x30")]
	public List<NpcPatrolPointData> BedPatrolPoints;

	// Token: 0x04007C4E RID: 31822
	[Token(Token = "0x4007061")]
	[FieldOffset(Offset = "0x38")]
	public List<NpcPatrolPointData> DoorPatrolPoints;

	// Token: 0x04007C4F RID: 31823
	[Token(Token = "0x4007062")]
	[FieldOffset(Offset = "0x40")]
	public List<NpcPatrolPointData> RotatePatrolPoints;

	// Token: 0x04007C50 RID: 31824
	[Token(Token = "0x4007063")]
	[FieldOffset(Offset = "0x48")]
	public int Capaticy;

	// Token: 0x04007C51 RID: 31825
	[Token(Token = "0x4007064")]
	[FieldOffset(Offset = "0x4C")]
	public Place PlaceName;
}
