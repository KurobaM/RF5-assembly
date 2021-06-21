using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000AB3 RID: 2739
[Token(Token = "0x2000730")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x1471B0", Offset = "0x1472B1")]
[Serializable]
public class BuildDataTable : ScriptableObject
{
	// Token: 0x06004731 RID: 18225 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003BA7")]
	[Address(RVA = "0x218BB40", Offset = "0x218BC41", VA = "0x218BB40")]
	public static BuildDataTable GetTable()
	{
		return null;
	}

	// Token: 0x06004732 RID: 18226 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BA8")]
	[Address(RVA = "0x218BBF0", Offset = "0x218BCF1", VA = "0x218BBF0")]
	public BuildDataTable()
	{
	}

	// Token: 0x0400A64C RID: 42572
	[Token(Token = "0x4007DB4")]
	[FieldOffset(Offset = "0x18")]
	public List<BuildItemData> BuilderItemDatas;

	// Token: 0x0400A64D RID: 42573
	[Token(Token = "0x4007DB5")]
	[FieldOffset(Offset = "0x20")]
	public List<BuildItemData> FurnitureItemDatas;
}
