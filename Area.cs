using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000866 RID: 2150
[Token(Token = "0x200058A")]
[Serializable]
public class Area : MonoBehaviour
{
	// Token: 0x060038E2 RID: 14562 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002F66")]
	[Address(RVA = "0x243B3F0", Offset = "0x243B4F1", VA = "0x243B3F0")]
	private void Awake()
	{
	}

	// Token: 0x060038E3 RID: 14563 RVA: 0x00013BD8 File Offset: 0x00011DD8
	[Token(Token = "0x6002F67")]
	[Address(RVA = "0x243B410", Offset = "0x243B511", VA = "0x243B410")]
	public int GetCapacity()
	{
		return 0;
	}

	// Token: 0x060038E4 RID: 14564 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002F68")]
	[Address(RVA = "0x243B420", Offset = "0x243B521", VA = "0x243B420")]
	public void FreeAllPoints()
	{
	}

	// Token: 0x060038E5 RID: 14565 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F69")]
	[Address(RVA = "0x243B870", Offset = "0x243B971", VA = "0x243B870")]
	public NpcPatrolPoint GetFreeOnlyNpcPoint(NpcPatrolPoint[] CheckPatrolPoints, int NpcId)
	{
		return null;
	}

	// Token: 0x060038E6 RID: 14566 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F6A")]
	[Address(RVA = "0x243BBF0", Offset = "0x243BCF1", VA = "0x243BBF0")]
	public NpcPatrolPoint GetFreePoint(NpcPatrolPoint[] CheckPatrolPoints, int NpcId = 0)
	{
		return null;
	}

	// Token: 0x060038E7 RID: 14567 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F6B")]
	[Address(RVA = "0x243B880", Offset = "0x243B981", VA = "0x243B880")]
	private NpcPatrolPoint GetNpcPoint(NpcPatrolPoint[] CheckPatrolPoints, int NpcId = 0)
	{
		return null;
	}

	// Token: 0x060038E8 RID: 14568 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F6C")]
	[Address(RVA = "0x243BDD0", Offset = "0x243BED1", VA = "0x243BDD0")]
	public NpcPatrolPoint GetBedPatrolPoint(int NpcId)
	{
		return null;
	}

	// Token: 0x060038E9 RID: 14569 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002F6D")]
	[Address(RVA = "0x243BFD0", Offset = "0x243C0D1", VA = "0x243BFD0")]
	public void ClearBedPatrolPoint(NpcPatrolPoint pp)
	{
	}

	// Token: 0x060038EA RID: 14570 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F6E")]
	[Address(RVA = "0x243C060", Offset = "0x243C161", VA = "0x243C060")]
	public NpcPatrolPoint GetJobPatrolPoint(int NpcId)
	{
		return null;
	}

	// Token: 0x060038EB RID: 14571 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F6F")]
	[Address(RVA = "0x243C120", Offset = "0x243C221", VA = "0x243C120")]
	public NpcPatrolPoint GetWaitJobPatrolPoint(int NpcId)
	{
		return null;
	}

	// Token: 0x060038EC RID: 14572 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002F70")]
	[Address(RVA = "0x243C320", Offset = "0x243C421", VA = "0x243C320")]
	public void ClearJobPatrolPoint(NpcPatrolPoint pp)
	{
	}

	// Token: 0x060038ED RID: 14573 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F71")]
	[Address(RVA = "0x243C3B0", Offset = "0x243C4B1", VA = "0x243C3B0")]
	public NpcPatrolPoint GetEatPatrolPoint(int NpcId)
	{
		return null;
	}

	// Token: 0x060038EE RID: 14574 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F72")]
	[Address(RVA = "0x243C5C0", Offset = "0x243C6C1", VA = "0x243C5C0")]
	public NpcPatrolPoint GetFishingPatrolPoint(int NpcId)
	{
		return null;
	}

	// Token: 0x060038EF RID: 14575 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F73")]
	[Address(RVA = "0x243C6B0", Offset = "0x243C7B1", VA = "0x243C6B0")]
	public NpcPatrolPoint GetSeatPatrolPoint(int NpcId)
	{
		return null;
	}

	// Token: 0x060038F0 RID: 14576 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F74")]
	[Address(RVA = "0x243C890", Offset = "0x243C991", VA = "0x243C890")]
	public NpcPatrolPoint GetSeatPatrolPointOnlyNpc(int NpcId)
	{
		return null;
	}

	// Token: 0x060038F1 RID: 14577 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F75")]
	[Address(RVA = "0x243C790", Offset = "0x243C891", VA = "0x243C790")]
	public NpcPatrolPoint GetBathPatrolPoint(Gender gender)
	{
		return null;
	}

	// Token: 0x060038F2 RID: 14578 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F76")]
	[Address(RVA = "0x243C8A0", Offset = "0x243C9A1", VA = "0x243C8A0")]
	public NpcPatrolPoint GetWaitSeatPatrolPoint(int NpcId)
	{
		return null;
	}

	// Token: 0x060038F3 RID: 14579 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F77")]
	[Address(RVA = "0x243CAB0", Offset = "0x243CBB1", VA = "0x243CAB0")]
	public NpcPatrolPoint GetRotatePatrolPointEnd(int RotatePatternNumber, int NpcId = 0)
	{
		return null;
	}

	// Token: 0x060038F4 RID: 14580 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F78")]
	[Address(RVA = "0x243CD10", Offset = "0x243CE11", VA = "0x243CD10")]
	public NpcPatrolPoint ReadRotatePatrolPointEnd(int RotatePatternNumber)
	{
		return null;
	}

	// Token: 0x060038F5 RID: 14581 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F79")]
	[Address(RVA = "0x243CE80", Offset = "0x243CF81", VA = "0x243CE80")]
	public NpcPatrolPoint GetDoorPoint(DoorType doortype)
	{
		return null;
	}

	// Token: 0x060038F6 RID: 14582 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F7A")]
	[Address(RVA = "0x243CF70", Offset = "0x243D071", VA = "0x243CF70")]
	public NpcPatrolPoint GetRelayPatrolPoint(NpcData npcData)
	{
		return null;
	}

	// Token: 0x060038F7 RID: 14583 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002F7B")]
	[Address(RVA = "0x243D100", Offset = "0x243D201", VA = "0x243D100")]
	public void ClearSeatPatrolPoint(NpcPatrolPoint pp)
	{
	}

	// Token: 0x060038F8 RID: 14584 RVA: 0x00013BF0 File Offset: 0x00011DF0
	[Token(Token = "0x6002F7C")]
	[Address(RVA = "0x243D190", Offset = "0x243D291", VA = "0x243D190")]
	public bool IsAvailable()
	{
		return default(bool);
	}

	// Token: 0x060038F9 RID: 14585 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F7D")]
	[Address(RVA = "0x243D280", Offset = "0x243D381", VA = "0x243D280")]
	public AreaData GetCopyData()
	{
		return null;
	}

	// Token: 0x060038FA RID: 14586 RVA: 0x00013C08 File Offset: 0x00011E08
	[Token(Token = "0x6002F7E")]
	[Address(RVA = "0x243BCB0", Offset = "0x243BDB1", VA = "0x243BCB0")]
	private bool RepelPatrolPoint(int npcId, int hour, int minutes)
	{
		return default(bool);
	}

	// Token: 0x060038FB RID: 14587 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002F7F")]
	[Address(RVA = "0x243D7D0", Offset = "0x243D8D1", VA = "0x243D7D0")]
	public Area()
	{
	}

	// Token: 0x04007C3C RID: 31804
	[Token(Token = "0x400704F")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public NpcPatrolPoint[] JobPatrolPoints;

	// Token: 0x04007C3D RID: 31805
	[Token(Token = "0x4007050")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public NpcPatrolPoint[] WaitJobPatrolPoints;

	// Token: 0x04007C3E RID: 31806
	[Token(Token = "0x4007051")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public NpcPatrolPoint[] SeatPatrolPoints;

	// Token: 0x04007C3F RID: 31807
	[Token(Token = "0x4007052")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public NpcPatrolPoint[] EatPatrolPoints;

	// Token: 0x04007C40 RID: 31808
	[Token(Token = "0x4007053")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public NpcPatrolPoint[] FishingPatrolPoints;

	// Token: 0x04007C41 RID: 31809
	[Token(Token = "0x4007054")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	public NpcPatrolPoint[] DatePatrolPoints;

	// Token: 0x04007C42 RID: 31810
	[Token(Token = "0x4007055")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	public NpcPatrolPoint[] WaitSeatPatrolPoints;

	// Token: 0x04007C43 RID: 31811
	[Token(Token = "0x4007056")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	public NpcPatrolPoint[] BedPatrolPoints;

	// Token: 0x04007C44 RID: 31812
	[Token(Token = "0x4007057")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	public NpcPatrolPoint[] DoorPatrolPoints;

	// Token: 0x04007C45 RID: 31813
	[Token(Token = "0x4007058")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	public NpcPatrolPoint[] RotatePatrolPoints;

	// Token: 0x04007C46 RID: 31814
	[Token(Token = "0x4007059")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	public int RotateRoutePercent;

	// Token: 0x04007C47 RID: 31815
	[Token(Token = "0x400705A")]
	[FieldOffset(Offset = "0x6C")]
	[SerializeField]
	private int Capaticy;

	// Token: 0x04007C48 RID: 31816
	[Token(Token = "0x400705B")]
	[FieldOffset(Offset = "0x70")]
	public Place PlaceName;
}
