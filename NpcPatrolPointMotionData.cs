using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000814 RID: 2068
[Token(Token = "0x2000553")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x146300", Offset = "0x146401")]
[Serializable]
public class NpcPatrolPointMotionData : ScriptableObject
{
	// Token: 0x0600373B RID: 14139 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DF4")]
	[Address(RVA = "0x1F53B80", Offset = "0x1F53C81", VA = "0x1F53B80")]
	public NpcPatrolPointMotionData()
	{
	}

	// Token: 0x04007A5B RID: 31323
	[Token(Token = "0x4006EC9")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public int NpcId;

	// Token: 0x04007A5C RID: 31324
	[Token(Token = "0x4006ECA")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public List<PatrolPointMotionData> PatrolPointMotionDatas;
}
