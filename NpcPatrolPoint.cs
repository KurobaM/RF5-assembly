using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200086D RID: 2157
[Token(Token = "0x2000591")]
[Serializable]
public class NpcPatrolPoint : MonoBehaviour
{
	// Token: 0x06003928 RID: 14632 RVA: 0x00013D10 File Offset: 0x00011F10
	[Token(Token = "0x6002FAC")]
	[Address(RVA = "0x1F533E0", Offset = "0x1F534E1", VA = "0x1F533E0")]
	public bool IsOnlyNpcPoint()
	{
		return default(bool);
	}

	// Token: 0x06003929 RID: 14633 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FAD")]
	[Address(RVA = "0x1F53450", Offset = "0x1F53551", VA = "0x1F53450")]
	private void Awake()
	{
	}

	// Token: 0x0600392A RID: 14634 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FAE")]
	[Address(RVA = "0x1F53460", Offset = "0x1F53561", VA = "0x1F53460")]
	private void Start()
	{
	}

	// Token: 0x0600392B RID: 14635 RVA: 0x00013D28 File Offset: 0x00011F28
	[Token(Token = "0x6002FAF")]
	[Address(RVA = "0x1F53510", Offset = "0x1F53611", VA = "0x1F53510")]
	public bool IsRotateEndPoint()
	{
		return default(bool);
	}

	// Token: 0x0600392C RID: 14636 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002FB0")]
	[Address(RVA = "0x1F53520", Offset = "0x1F53621", VA = "0x1F53520")]
	public NpcPatrolPointData GetCopyData()
	{
		return null;
	}

	// Token: 0x0600392D RID: 14637 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FB1")]
	[Address(RVA = "0x1F536F0", Offset = "0x1F537F1", VA = "0x1F536F0")]
	private void OnDrawGizmos()
	{
	}

	// Token: 0x0600392E RID: 14638 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FB2")]
	[Address(RVA = "0x1F53730", Offset = "0x1F53831", VA = "0x1F53730")]
	public NpcPatrolPoint()
	{
	}

	// Token: 0x04007C62 RID: 31842
	[Token(Token = "0x4007075")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16D7E0", Offset = "0x16D8E1")]
	[SerializeField]
	private NpcController npc;

	// Token: 0x04007C63 RID: 31843
	[Token(Token = "0x4007076")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16D830", Offset = "0x16D931")]
	[SerializeField]
	public NpcPatrolRoute[] NpcPatrolRoutes;

	// Token: 0x04007C64 RID: 31844
	[Token(Token = "0x4007077")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16D880", Offset = "0x16D981")]
	[SerializeField]
	public float PatrolSpeed;

	// Token: 0x04007C65 RID: 31845
	[Token(Token = "0x4007078")]
	[FieldOffset(Offset = "0x2C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16D8D0", Offset = "0x16D9D1")]
	[SerializeField]
	public float WaitMinutes;

	// Token: 0x04007C66 RID: 31846
	[Token(Token = "0x4007079")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16D920", Offset = "0x16DA21")]
	[SerializeField]
	public string doorName;

	// Token: 0x04007C67 RID: 31847
	[Token(Token = "0x400707A")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16D970", Offset = "0x16DA71")]
	[SerializeField]
	public DoorType DoorType;

	// Token: 0x04007C68 RID: 31848
	[Token(Token = "0x400707B")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16D9C0", Offset = "0x16DAC1")]
	[SerializeField]
	public string WarpSceneName;

	// Token: 0x04007C69 RID: 31849
	[Token(Token = "0x400707C")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16DA10", Offset = "0x16DB11")]
	[SerializeField]
	public Place WarpPlace;

	// Token: 0x04007C6A RID: 31850
	[Token(Token = "0x400707D")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16DA60", Offset = "0x16DB61")]
	[SerializeField]
	public string WarpTagetPointName;

	// Token: 0x04007C6B RID: 31851
	[Token(Token = "0x400707E")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16DAB0", Offset = "0x16DBB1")]
	[SerializeField]
	public float arriveDistance;

	// Token: 0x04007C6C RID: 31852
	[Token(Token = "0x400707F")]
	[FieldOffset(Offset = "0x5C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16DB00", Offset = "0x16DC01")]
	[SerializeField]
	public bool useNavMesh;

	// Token: 0x04007C6D RID: 31853
	[Token(Token = "0x4007080")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16DB50", Offset = "0x16DC51")]
	[SerializeField]
	public int EndPointOfRotatePatternNumber;

	// Token: 0x04007C6E RID: 31854
	[Token(Token = "0x4007081")]
	[FieldOffset(Offset = "0x64")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16DBA0", Offset = "0x16DCA1")]
	public bool IsFree;

	// Token: 0x04007C6F RID: 31855
	[Token(Token = "0x4007082")]
	[FieldOffset(Offset = "0x68")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16DBE0", Offset = "0x16DCE1")]
	public int IsFreeCnt;

	// Token: 0x04007C70 RID: 31856
	[Token(Token = "0x4007083")]
	[FieldOffset(Offset = "0x6C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16DC20", Offset = "0x16DD21")]
	public Gender Gender;

	// Token: 0x04007C71 RID: 31857
	[Token(Token = "0x4007084")]
	[FieldOffset(Offset = "0x70")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16DC60", Offset = "0x16DD61")]
	[SerializeField]
	public bool IsSeat;

	// Token: 0x04007C72 RID: 31858
	[Token(Token = "0x4007085")]
	[FieldOffset(Offset = "0x71")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16DCB0", Offset = "0x16DDB1")]
	[SerializeField]
	public bool Destination;

	// Token: 0x04007C73 RID: 31859
	[Token(Token = "0x4007086")]
	[FieldOffset(Offset = "0x78")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16DD00", Offset = "0x16DE01")]
	[SerializeField]
	public List<NPCID> OnlyNpcIds;

	// Token: 0x04007C74 RID: 31860
	[Token(Token = "0x4007087")]
	[FieldOffset(Offset = "0x80")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16DD50", Offset = "0x16DE51")]
	[SerializeField]
	public int GroupId;

	// Token: 0x04007C75 RID: 31861
	[Token(Token = "0x4007088")]
	[FieldOffset(Offset = "0x84")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16DDA0", Offset = "0x16DEA1")]
	[SerializeField]
	public int stayingNpcId;

	// Token: 0x04007C76 RID: 31862
	[Token(Token = "0x4007089")]
	[FieldOffset(Offset = "0x88")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16DDF0", Offset = "0x16DEF1")]
	[SerializeField]
	public NpcPatrolPoint[] lookAtPoints;

	// Token: 0x04007C77 RID: 31863
	[Token(Token = "0x400708A")]
	[FieldOffset(Offset = "0x90")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16DE40", Offset = "0x16DF41")]
	[SerializeField]
	public bool NotLookatPlayer;

	// Token: 0x04007C78 RID: 31864
	[Token(Token = "0x400708B")]
	[FieldOffset(Offset = "0x94")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16DE90", Offset = "0x16DF91")]
	[SerializeField]
	public int NotLookatPlayerTime;

	// Token: 0x04007C79 RID: 31865
	[Token(Token = "0x400708C")]
	[FieldOffset(Offset = "0x98")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16DEE0", Offset = "0x16DFE1")]
	[SerializeField]
	public bool ChangeSwimWear;

	// Token: 0x04007C7A RID: 31866
	[Token(Token = "0x400708D")]
	[FieldOffset(Offset = "0x99")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16DF30", Offset = "0x16E031")]
	[SerializeField]
	public bool ChangePajama;
}
