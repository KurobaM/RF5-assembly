using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005AA RID: 1450
[Token(Token = "0x200040C")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x1460E0", Offset = "0x1461E1")]
[Serializable]
public class TeleportSceneDataObject : ScriptableObject
{
	// Token: 0x0600237D RID: 9085 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DC3")]
	[Address(RVA = "0x1F6A780", Offset = "0x1F6A881", VA = "0x1F6A780")]
	public Dictionary<string, TeleportSceneParam> GetTable()
	{
		return null;
	}

	// Token: 0x0600237E RID: 9086 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DC4")]
	[Address(RVA = "0x1F6A7E0", Offset = "0x1F6A8E1", VA = "0x1F6A7E0")]
	public TeleportSceneDataObject()
	{
	}

	// Token: 0x04006B31 RID: 27441
	[Token(Token = "0x4006488")]
	[FieldOffset(Offset = "0x18")]
	public TeleportSceneDataTable TeleportSceneDataTable;
}
