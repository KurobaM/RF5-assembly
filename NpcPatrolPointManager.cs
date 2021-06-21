using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000870 RID: 2160
[Token(Token = "0x2000594")]
[Serializable]
public class NpcPatrolPointManager : SingletonMonoBehaviour<NpcPatrolPointManager>
{
	// Token: 0x06003931 RID: 14641 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FB5")]
	[Address(RVA = "0x1F537C0", Offset = "0x1F538C1", VA = "0x1F537C0", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x06003932 RID: 14642 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FB6")]
	[Address(RVA = "0x1F53880", Offset = "0x1F53981", VA = "0x1F53880")]
	public void SetArea()
	{
	}

	// Token: 0x06003933 RID: 14643 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002FB7")]
	[Address(RVA = "0x1F53900", Offset = "0x1F53A01", VA = "0x1F53900")]
	public GameObject GetPoint(string name)
	{
		return null;
	}

	// Token: 0x06003934 RID: 14644 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002FB8")]
	[Address(RVA = "0x1F539C0", Offset = "0x1F53AC1", VA = "0x1F539C0")]
	public GameObject GetMobRoutePoint(int idx)
	{
		return null;
	}

	// Token: 0x06003935 RID: 14645 RVA: 0x00013D40 File Offset: 0x00011F40
	[Token(Token = "0x6002FB9")]
	[Address(RVA = "0x1F53A40", Offset = "0x1F53B41", VA = "0x1F53A40")]
	public int GetMobRoutePointNum()
	{
		return 0;
	}

	// Token: 0x06003936 RID: 14646 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FBA")]
	[Address(RVA = "0x1F53A90", Offset = "0x1F53B91", VA = "0x1F53A90")]
	public NpcPatrolPointManager()
	{
	}

	// Token: 0x04007C7B RID: 31867
	[Token(Token = "0x400708E")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private PositinoList m_PotisionArray;

	// Token: 0x04007C7C RID: 31868
	[Token(Token = "0x400708F")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<GameObject> m_MobRoutePotisionList;

	// Token: 0x04007C7D RID: 31869
	[Token(Token = "0x4007090")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<string, GameObject> m_PointTable;
}
