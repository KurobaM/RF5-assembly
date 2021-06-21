using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200053B RID: 1339
[Token(Token = "0x20003CC")]
[Serializable]
public class SnowballObjectSpawnData
{
	// Token: 0x06002068 RID: 8296 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B89")]
	[Address(RVA = "0x2252F50", Offset = "0x2253051", VA = "0x2252F50")]
	public SnowballObjectSpawnData()
	{
	}

	// Token: 0x04006750 RID: 26448
	[Token(Token = "0x4006155")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public List<SnowballObject> ObjectList;
}
