using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005A6 RID: 1446
[Token(Token = "0x2000408")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x146090", Offset = "0x146191")]
[Serializable]
public class TeleportPositionDataObject : ScriptableObject
{
	// Token: 0x06002378 RID: 9080 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DBE")]
	[Address(RVA = "0x1F5F7C0", Offset = "0x1F5F8C1", VA = "0x1F5F7C0")]
	public Dictionary<string, TeleportPortalData> GetTable()
	{
		return null;
	}

	// Token: 0x06002379 RID: 9081 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DBF")]
	[Address(RVA = "0x1F6A640", Offset = "0x1F6A741", VA = "0x1F6A640")]
	public TeleportPositionDataObject()
	{
	}

	// Token: 0x04006B29 RID: 27433
	[Token(Token = "0x4006480")]
	[FieldOffset(Offset = "0x18")]
	public TeleportPositionData TeleportPositionData;
}
