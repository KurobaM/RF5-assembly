using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200053C RID: 1340
[Token(Token = "0x20003CD")]
[Serializable]
public class SnowballObjectSpawnTerm
{
	// Token: 0x06002069 RID: 8297 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B8A")]
	[Address(RVA = "0x2253400", Offset = "0x2253501", VA = "0x2253400")]
	public SnowballObjectSpawnTerm()
	{
	}

	// Token: 0x04006751 RID: 26449
	[Token(Token = "0x4006156")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public float SpawnTime;

	// Token: 0x04006752 RID: 26450
	[Token(Token = "0x4006157")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<SnowballObjectSpawnData> SpawnList;
}
