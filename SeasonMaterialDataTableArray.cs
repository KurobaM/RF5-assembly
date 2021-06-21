using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000584 RID: 1412
[Token(Token = "0x20003F4")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x145FF0", Offset = "0x1460F1")]
[Serializable]
public class SeasonMaterialDataTableArray : ScriptableObject
{
	// Token: 0x0600223E RID: 8766 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CD7")]
	[Address(RVA = "0x1E2EFC0", Offset = "0x1E2F0C1", VA = "0x1E2EFC0")]
	public Dictionary<string, SeasonMaterialData> GetTable()
	{
		return null;
	}

	// Token: 0x0600223F RID: 8767 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001CD8")]
	[Address(RVA = "0x1E2F020", Offset = "0x1E2F121", VA = "0x1E2F020")]
	public SeasonMaterialDataTableArray()
	{
	}

	// Token: 0x04006A87 RID: 27271
	[Token(Token = "0x400641A")]
	[FieldOffset(Offset = "0x18")]
	public SeasonMaterialDataTable SeasonMaterialDataTable;
}
