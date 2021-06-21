using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003B2 RID: 946
[Token(Token = "0x20002D8")]
[Serializable]
public class PersonalMotionData
{
	// Token: 0x0600174E RID: 5966 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014B8")]
	[Address(RVA = "0x213D9E0", Offset = "0x213DAE1", VA = "0x213D9E0")]
	public PersonalMotionData()
	{
	}

	// Token: 0x0400106D RID: 4205
	[Token(Token = "0x4000D1D")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public float StartTime;

	// Token: 0x0400106E RID: 4206
	[Token(Token = "0x4000D1E")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<PesronalMotionPlayData> PlayDatas;
}
